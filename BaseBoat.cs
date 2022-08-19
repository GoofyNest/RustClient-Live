public class BaseBoat : BaseVehicle // TypeDefIndex: 8318
{	// Fields
	private Option __menuOption_Menu_Push; // 0x3B8
	public float engineThrust; // 0x410
	public float steeringScale; // 0x414
	public float gasPedal; // 0x418
	public float steering; // 0x41C
	public Transform thrustPoint; // 0x420
	public Transform centerOfMass; // 0x428
	public Buoyancy buoyancy; // 0x430

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7EE440 Offset: 0x7ED840 VA: 0x1807EE440 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7EEB00 Offset: 0x7EDF00 VA: 0x1807EEB00 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7EE930 Offset: 0x7EDD30 VA: 0x1807EE930
	public bool InDryDock() { }

	// RVA: 0x7EE9A0 Offset: 0x7EDDA0 VA: 0x1807EE9A0 Slot: 112
	public override float MaxVelocity() { }

	[BaseEntity.Menu] // RVA: 0xB47E0 Offset: 0xB3BE0 VA: 0x1800B47E0
	[BaseEntity.Menu.Description] // RVA: 0xB47E0 Offset: 0xB3BE0 VA: 0x1800B47E0
	[BaseEntity.Menu.Icon] // RVA: 0xB47E0 Offset: 0xB3BE0 VA: 0x1800B47E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB47E0 Offset: 0xB3BE0 VA: 0x1800B47E0
	// RVA: 0x7EE9B0 Offset: 0x7EDDB0 VA: 0x1807EE9B0 Slot: 194
	public virtual void Menu_Push(BasePlayer player) { }

	// RVA: 0x7EE380 Offset: 0x7ED780 VA: 0x1807EE380 Slot: 195
	public virtual bool EngineInWater() { }

	// RVA: 0x7EE9F0 Offset: 0x7EDDF0 VA: 0x1807EE9F0 Slot: 156
	public override float WaterFactorForPlayer(BasePlayer player) { }

	// RVA: 0x7EE760 Offset: 0x7EDB60 VA: 0x1807EE760
	public static float GetWaterDepth(Vector3 pos) { }

	// RVA: 0x7EEAE0 Offset: 0x7EDEE0 VA: 0x1807EEAE0
	public void .ctor() { }

}

