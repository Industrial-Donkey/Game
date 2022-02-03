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

    private EnemyState currentState;

    void Start() {
        currentState = EnemyState.PEACEFUL;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState) {
            case EnemyState.HOSTILE:
                break;

            case EnemyState.SEARCHING:
                break;

            case EnemyState.PEACEFUL:
            default:
                break;
        }
    }
}
