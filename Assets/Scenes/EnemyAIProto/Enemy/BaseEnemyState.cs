using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemyState {
    public abstract void EnterState(EnemyAi enemyStateManager);
    public abstract void HandleInput(EnemyAi enemyStateManager);
    public abstract void Update(EnemyAi enemyStateManager);
}