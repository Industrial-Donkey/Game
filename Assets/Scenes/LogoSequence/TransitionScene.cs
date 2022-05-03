using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class TransitionScene : MonoBehaviour
{

    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((videoPlayer.length - 1) <= videoPlayer.time) {
            // Transition to intro scene
            Debug.Log("Load Scene 1");
            
            SceneManager.LoadScene(1);
        }
    }
}
