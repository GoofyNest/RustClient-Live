public class WaitForSecondsRealtimeEx : CustomYieldInstruction, Pool.IPooled // TypeDefIndex: 6168
{	// Fields
	private bool _isInPool; // 0x10
	private float _waitUntilTime; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <WaitTime>k__BackingField; // 0x18

	// Properties
	public float WaitTime { get; set; }
	public override bool keepWaiting { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x772410 Offset: 0x771810 VA: 0x180772410
	public float get_WaitTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x772450 Offset: 0x771850 VA: 0x180772450
	public void set_WaitTime(float value) { }

	// RVA: 0x14F4E00 Offset: 0x14F4200 VA: 0x1814F4E00 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x14F4DD0 Offset: 0x14F41D0 VA: 0x1814F4DD0 Slot: 8
	public void EnterPool() { }

	// RVA: 0x14F4DE0 Offset: 0x14F41E0 VA: 0x1814F4DE0 Slot: 9
	public void LeavePool() { }

	// RVA: 0x14F4DF0 Offset: 0x14F41F0 VA: 0x1814F4DF0
	public void .ctor() { }

}

