using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardMovementHandler : MonoBehaviour
{

    private CharacterController characterController;
    private int direction = 0;
    private int jump = 0;
    
    void Start() {
        characterController = this.GetComponent<CharacterController>();
    }

    
    void Update() {

        if (Input.GetKey(KeyCode.D)) {
            direction = 1;
        } else if (Input.GetKey(KeyCode.A)) {
            direction = -1;
        } else {
            direction = 0;
        }

        if (Input.GetKeyDown(KeyCode.W)) {
            jump = 1;
        } else {
            jump = 0;
        }

        this.characterController.SimpleMove(new Vector3(2 * direction, 10 * jump, 0));
    }
}
