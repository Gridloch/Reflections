using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void MoveToScene(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }


    public void LinkToScene(int SceneID)
    {

        #if UNITY_WEBGL
            
            Application.OpenURL("https://www.youtube.com/watch?v=XfELJU1mRMg");

        #else

            SceneManager.LoadScene(SceneID);

        #endif
        
    }
}
