using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vent : MonoBehaviour
{
    public uint destinationSceneId = 0;
    public uint detectionRadius = 1;
    public SpriteRenderer openTexture;
    public SpriteRenderer closedTexture;
    private Transform transform;

    void Start() {
        transform = GetComponent<Transform>();
    }

    void Update() {

        if (Physics.CheckSphere(transform.position, detectionRadius, LayerMask.GetMask("Player"))) {
            openTexture.enabled = true;
            closedTexture.enabled = false;

            if (Input.GetKey(KeyCode.E)) {
                SceneManager.LoadScene((int) destinationSceneId);
            }

            return;
        }

        openTexture.enabled = false;
        closedTexture.enabled = true;

    }
}
