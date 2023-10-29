using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void delayLoad(string scene, float delay)
    {
        Invoke("Load", delay);

    }
   public void Load (string scene)
    {

        SceneManager.LoadScene (scene);

    }
  
}
