public class WaterVisibilityTrigger : EnvironmentVolumeTrigger // TypeDefIndex: 10633
{	// Fields
	public bool togglePhysics; // 0x38
	public bool toggleVisuals; // 0x39
	private long enteredTick; // 0x40
	private static long ticks; // 0x0
	private static SortedList<long, WaterVisibilityTrigger> tracker; // 0x8

	// Methods

	// RVA: 0x898E70 Offset: 0x898270 VA: 0x180898E70
	public static void Reset() { }

	// RVA: 0x898200 Offset: 0x897600 VA: 0x180898200
	protected void OnDestroy() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	private int GetVisibilityMask() { }

	// RVA: 0x8990A0 Offset: 0x8984A0 VA: 0x1808990A0
	private void ToggleVisibility() { }

	// RVA: 0x898D00 Offset: 0x898100 VA: 0x180898D00
	private void ResetVisibility() { }

	// RVA: 0x898F00 Offset: 0x898300 VA: 0x180898F00
	private void ToggleCollision(Collider other) { }

	// RVA: 0x898B60 Offset: 0x897F60 VA: 0x180898B60
	private void ResetCollision(Collider other) { }

	// RVA: 0x8982C0 Offset: 0x8976C0 VA: 0x1808982C0
	protected void OnTriggerEnter(Collider other) { }

	// RVA: 0x8985E0 Offset: 0x8979E0 VA: 0x1808985E0
	protected void OnTriggerExit(Collider other) { }

	// RVA: 0x899290 Offset: 0x898690 VA: 0x180899290
	public void .ctor() { }

	// RVA: 0x899210 Offset: 0x898610 VA: 0x180899210
	private static void .cctor() { }

}

