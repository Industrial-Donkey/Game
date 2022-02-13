using UnityEngine;

public class PassiveDroidWorkingState : PassiveDroidBaseState {

    // Each bot has up to 10 minutes of life span before they are destroyed
    private float lifespan;

    public override void EnterState(AssemblyDroid assemblyDroid) {
        //lifespan = Mathf.Clamp(Random.value * 2, 0.4f, 2f) * (60 * 5);
        lifespan = 20;
    }

    public override void UpdateState(AssemblyDroid assemblyDroid) {
        Debug.Log(lifespan);
        lifespan = Mathf.Clamp(lifespan - Time.deltaTime, 0, float.MaxValue);

        if (lifespan == 0) {
            assemblyDroid.SwitchState(assemblyDroid.DeadState);
        }
    }
}