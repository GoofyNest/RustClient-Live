public class WaterVisibilityTrigger : EnvironmentVolumeTrigger // TypeDefIndex: 12312
{
	public bool togglePhysics; 
	public bool toggleVisuals; 
	private long enteredTick; 
	private static long ticks; 
	private static SortedList<long, WaterVisibilityTrigger> tracker; 


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

