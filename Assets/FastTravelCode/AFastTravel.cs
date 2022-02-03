using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AFastTravel : MonoBehaviour
{
    // Triggers upon entering the object
    // Loads a different scene
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(0);
    }
}

