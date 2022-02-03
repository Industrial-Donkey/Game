using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemyState {
    public abstract void EnterState(EnemyStateManager enemyStateManager);
    public abstract void HandleInput(EnemyStateManager enemyStateManager);
    public abstract void Update(EnemyStateManager enemyStateManager);
}