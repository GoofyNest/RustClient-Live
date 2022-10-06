public abstract class GroundVehicle : BaseVehicle, IEngineControllerUser, IEntity // TypeDefIndex: 11421
{
	[HeaderAttribute] 
	[SerializeField] 
	protected GroundVehicleAudio gvAudio; 
	[SerializeField] 
	private GameObjectRef fuelStoragePrefab; 
	[SerializeField] 
	private Transform waterloggedPoint; 
	[SerializeField] 
	private GameObjectRef collisionEffect; 
	[SerializeField] 
	private float engineStartupTime; 
	[SerializeField] 
	private float minCollisionDamageForce; 
	[SerializeField] 
	private float maxCollisionDamageForce; 
	[SerializeField] 
	private float collisionDamageMultiplier; 
	[CompilerGeneratedAttribute] 
	private Vector3 <Velocity>k__BackingField; 
	protected VehicleEngineController<GroundVehicle> engineController; 
	private bool runningClientTick; 

	public Vector3 Velocity { get; set; }
	public abstract float DriveWheelVelocity { get; }
	public bool LightsAreOn { get; }
	public VehicleEngineController.EngineState<GroundVehicle> CurEngineState { get; }


	[CompilerGeneratedAttribute] 
	public Vector3 get_Velocity() { }

	[CompilerGeneratedAttribute] 
	private void set_Velocity(Vector3 value) { }

	public abstract float get_DriveWheelVelocity();

	public bool get_LightsAreOn() { }

	public VehicleEngineController.EngineState<GroundVehicle> get_CurEngineState() { }

	public override void InitShared() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public float GetSpeed() { }

	public abstract float GetMaxForwardSpeed();

	public abstract float GetThrottleInput();

	public abstract float GetBrakeInput();

	protected override bool CanPushNow(BasePlayer pusher) { }

	protected override void ClientInit(Entity info) { }

	protected virtual void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	private void StartClientTick() { }

	private void StopClientTick() { }

	protected abstract void OnClientTickStopped();

	protected virtual void GroundVehicleClientTick() { }

	protected void .ctor() { }

}

