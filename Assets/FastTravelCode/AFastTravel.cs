using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AFastTravel : MonoBehaviour
{
    // Triggers upon entering the object
    // Loads a different scene

    public Collider collider;
    public int sceneId;
    
    
    void OnTriggerEnter(Collider other)
    {
        if (other == collider)
        {
            SceneManager.LoadScene(sceneId);
        }
    }
}

