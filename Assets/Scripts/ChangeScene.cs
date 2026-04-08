using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // private static bool IsWebGL() => Application.platform == RuntimePlatform.WebGLPlayer;


    public void MoveToScene(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }


    public void LinkToScene(string LocationLink)
    {
        Debug.Log(LocationLink);
        // SceneManager.LoadScene(LocationLink);

        #if UNITY_EDITOR // UNITY_WEBGL borken???
            
            Debug.Log("Unity Editor");

        #elif UNITY_IOS

            Debug.Log("Unity iOS");

        #else

            Debug.Log("Any other platform");

        #endif
        
    }
}
