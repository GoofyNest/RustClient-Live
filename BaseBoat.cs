public class BaseBoat : BaseVehicle // TypeDefIndex: 10032
{
	private Option __menuOption_Menu_Push; 
	public float engineThrust; 
	public float steeringScale; 
	public float gasPedal; 
	public float steering; 
	public Transform thrustPoint; 
	public Transform centerOfMass; 
	public Buoyancy buoyancy; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public bool InDryDock() { }

	public override float MaxVelocity() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public virtual void Menu_Push(BasePlayer player) { }

	public virtual bool EngineInWater() { }

	public override float WaterFactorForPlayer(BasePlayer player) { }

	public static float GetWaterDepth(Vector3 pos) { }

	public void .ctor() { }

}

