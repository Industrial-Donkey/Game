using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateManager
{
    private BaseEnemyState currentState;

    public EnemyStateManager(BaseEnemyState initialState) {
        currentState = initialState;
        currentState.EnterState(this);
    }

    public void ChangeState(BaseEnemyState state) {
        currentState = state;
        currentState.EnterState(this);
    }

    public void Update() {
        currentState.Update(this);
    }
}
