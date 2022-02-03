using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{

    private EnemyPeacefulState peacefulState = new EnemyPeacefulState();
    private EnemySearchingState searchingState = new EnemySearchingState();
    private EnemyHostileState hostileState = new EnemyHostileState();
    private EnemyStateManager stateManager;

    // Start is called before the first frame update
    void Start() {
        stateManager = new EnemyStateManager(peacefulState);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
