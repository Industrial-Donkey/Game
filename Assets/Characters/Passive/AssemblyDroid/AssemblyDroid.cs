using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssemblyDroid : MonoBehaviour
{

    private float health = 1f;

    PassiveDroidBaseState currentState;
    public PassiveDroidWorkingState WorkingState = new PassiveDroidWorkingState();
    public PassiveDroidDeadState DeadState = new PassiveDroidDeadState();

    void Start() {
        currentState = WorkingState;
        currentState.EnterState(this);
    }

    void Update() {
        currentState.UpdateState(this);
    }

    public void SwitchState(PassiveDroidBaseState state) {
        currentState = state;
        currentState.EnterState(this);
    }
}