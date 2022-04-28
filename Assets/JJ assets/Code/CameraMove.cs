using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform player;
    void Update()
    {
        // Camera follows the player but 10 to the right
        transform.position = new Vector3(player.position.x + 8, 3, -10);
    }
}
