using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;






namespace KayBarhoum
{ 
public class LevelLoader : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            LoadLevel("SampleScene");
        }
       
    }

    /// <summary>
    /// This will Load a different scene.
    /// </summary>
    private void LoadLevel(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
}
   