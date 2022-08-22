public class WaterVisibilityTrigger : EnvironmentVolumeTrigger // TypeDefIndex: 10633
{	public bool togglePhysics; // 0x38
	public bool toggleVisuals; // 0x39
	private long enteredTick; // 0x40
	private static long ticks; // 0x0
	private static SortedList<long, WaterVisibilityTrigger> tracker; // 0x8


	public static void Reset() { }

	protected void OnDestroy() { }

	private int GetVisibilityMask() { }

	private void ToggleVisibility() { }

	private void ResetVisibility() { }

	private void ToggleCollision(Collider other) { }

	private void ResetCollision(Collider other) { }

	protected void OnTriggerEnter(Collider other) { }

	protected void OnTriggerExit(Collider other) { }

	public void .ctor() { }

	private static void .cctor() { }

}

