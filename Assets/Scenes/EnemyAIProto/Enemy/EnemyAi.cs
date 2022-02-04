using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum EnemyState {
    PEACEFUL,
    SEARCHING,
    HOSTILE
}

public class EnemyAi : MonoBehaviour
{
    public Rigidbody rigidBody;
    private EnemyState currentState;

    void Start() {
        currentState = EnemyState.PEACEFUL;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState) {
            case EnemyState.HOSTILE:
                // Lock on to player transform an attack.

                break;

            case EnemyState.SEARCHING:
                // Distractions. Initiate search pattern.

                break;

            case EnemyState.PEACEFUL:
            default:
                // Just move normally. Either randomly or on a path of some kind.
                float direction = (Mathf.PerlinNoise(Time.realtimeSinceStartup / 10, Time.realtimeSinceStartup / 10) * 2) - 1;
                Debug.Log(direction);
                rigidBody.AddForce((Vector3.left * 10) * direction);

                break;
        }
    }
}
