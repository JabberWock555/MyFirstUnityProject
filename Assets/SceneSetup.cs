using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSetup : MonoBehaviour
{
   public void SceneLoader(int Button)
    {
        switch (Button)
        {
            case 1:
                SceneManager.LoadScene("Scene_1");
                break;

            case 2:
                SceneManager.LoadScene("Scene_2");
                break;

            case 3:
                SceneManager.LoadScene("Scene_3");
                break;

            default:
                SceneManager.LoadScene("Master_Scene");
                break;
        }
    }
}
