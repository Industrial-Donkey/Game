using UnityEngine;

public class PassiveDroidDeadState : PassiveDroidBaseState {
    public override void EnterState(AssemblyDroid assemblyDroid) {
        Debug.Log("Hello from the death state");

        // 1. Remove initial droid sprites

        // 2. Make crush rig sprites visable and add some small velocity to them

        // 3. Particle effect to hide any imperfections
    }

    public override void UpdateState(AssemblyDroid assemblyDroid) {
        // Do nothing
    }
}