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
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(sceneId);
        }
    }
}

