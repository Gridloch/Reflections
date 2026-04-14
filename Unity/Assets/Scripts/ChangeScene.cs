using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class ChangeScene : MonoBehaviour
{
    #if !UNITY_EDITOR && UNITY_WEBGL
        [DllImport("__Internal")]
        private static extern void OpenSameTab(string link);
    #endif

    private static string[] Links = {
        "/town/main map/index.html",
        "/home/garden/index.html",
        "/home/living room/index.html"
    };

    public void MoveToScene(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    } 


    public void LinkToScene(int SceneID)
    {

        #if !UNITY_EDITOR && UNITY_WEBGL
            
            OpenSameTab(Links[SceneID]);

        #else

            SceneManager.LoadScene(SceneID);

        #endif
        
    }
}
