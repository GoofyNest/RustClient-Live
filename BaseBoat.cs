public class BaseBoat : BaseVehicle // TypeDefIndex: 8318
{	private Option __menuOption_Menu_Push; // 0x3B8
	public float engineThrust; // 0x410
	public float steeringScale; // 0x414
	public float gasPedal; // 0x418
	public float steering; // 0x41C
	public Transform thrustPoint; // 0x420
	public Transform centerOfMass; // 0x428
	public Buoyancy buoyancy; // 0x430

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public bool InDryDock() { }

	public override float MaxVelocity() { }

	[BaseEntity.Menu] // RVA: 0xB47E0 Offset: 0xB3BE0 VA: 0x1800B47E0
	[BaseEntity.Menu.Description] // RVA: 0xB47E0 Offset: 0xB3BE0 VA: 0x1800B47E0
	[BaseEntity.Menu.Icon] // RVA: 0xB47E0 Offset: 0xB3BE0 VA: 0x1800B47E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB47E0 Offset: 0xB3BE0 VA: 0x1800B47E0
	public virtual void Menu_Push(BasePlayer player) { }

	public virtual bool EngineInWater() { }

	public override float WaterFactorForPlayer(BasePlayer player) { }

	public static float GetWaterDepth(Vector3 pos) { }

	public void .ctor() { }

}

