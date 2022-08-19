public class EnvironmentVolume : MonoBehaviour // TypeDefIndex: 9862
{	// Fields
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public EnvironmentType Type; // 0x18
	public Vector3 Center; // 0x1C
	public Vector3 Size; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Collider <trigger>k__BackingField; // 0x38

	// Properties
	public Collider trigger { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public Collider get_trigger() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	private void set_trigger(Collider value) { }

	// RVA: 0x8BB170 Offset: 0x8BA570 VA: 0x1808BB170 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x8BB180 Offset: 0x8BA580 VA: 0x1808BB180
	public void UpdateTrigger() { }

	// RVA: 0x8BB360 Offset: 0x8BA760 VA: 0x1808BB360
	public void .ctor() { }

}

