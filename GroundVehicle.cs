public abstract class GroundVehicle : BaseVehicle, IEngineControllerUser, IEntity // TypeDefIndex: 9710
{	// Fields
	[HeaderAttribute] // RVA: 0x85CF0 Offset: 0x850F0 VA: 0x180085CF0
	[SerializeField] // RVA: 0x85CF0 Offset: 0x850F0 VA: 0x180085CF0
	protected GroundVehicleAudio gvAudio; // 0x3B8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef fuelStoragePrefab; // 0x3C0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform waterloggedPoint; // 0x3C8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef collisionEffect; // 0x3D0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float engineStartupTime; // 0x3D8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float minCollisionDamageForce; // 0x3DC
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float maxCollisionDamageForce; // 0x3E0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float collisionDamageMultiplier; // 0x3E4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <Velocity>k__BackingField; // 0x3E8
	protected VehicleEngineController<GroundVehicle> engineController; // 0x3F8
	private bool runningClientTick; // 0x400

	// Properties
	public Vector3 Velocity { get; set; }
	public abstract float DriveWheelVelocity { get; }
	public bool LightsAreOn { get; }
	public VehicleEngineController.EngineState<GroundVehicle> CurEngineState { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC86980 Offset: 0xC85D80 VA: 0x180C86980 Slot: 195
	public Vector3 get_Velocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC869A0 Offset: 0xC85DA0 VA: 0x180C869A0
	private void set_Velocity(Vector3 value) { }

	// RVA: -1 Offset: -1 Slot: 196
	public abstract float get_DriveWheelVelocity();

	// RVA: 0x7518F0 Offset: 0x750CF0 VA: 0x1807518F0
	public bool get_LightsAreOn() { }

	// RVA: 0xC86930 Offset: 0xC85D30 VA: 0x180C86930
	public VehicleEngineController.EngineState<GroundVehicle> get_CurEngineState() { }

	// RVA: 0xC86640 Offset: 0xC85A40 VA: 0x180C86640 Slot: 28
	public override void InitShared() { }

	// RVA: 0xC86720 Offset: 0xC85B20 VA: 0x180C86720 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xC864A0 Offset: 0xC858A0 VA: 0x180C864A0
	public float GetSpeed() { }

	// RVA: -1 Offset: -1 Slot: 197
	public abstract float GetMaxForwardSpeed();

	// RVA: -1 Offset: -1 Slot: 198
	public abstract float GetThrottleInput();

	// RVA: -1 Offset: -1 Slot: 199
	public abstract float GetBrakeInput();

	// RVA: 0xC86180 Offset: 0xC85580 VA: 0x180C86180 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0xC86460 Offset: 0xC85860 VA: 0x180C86460 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xC86200 Offset: 0xC85600 VA: 0x180C86200 Slot: 200
	protected virtual void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xC86780 Offset: 0xC85B80 VA: 0x180C86780
	private void StartClientTick() { }

	// RVA: 0xC86810 Offset: 0xC85C10 VA: 0x180C86810
	private void StopClientTick() { }

	// RVA: -1 Offset: -1 Slot: 201
	protected abstract void OnClientTickStopped();

	// RVA: 0xC86590 Offset: 0xC85990 VA: 0x180C86590 Slot: 202
	protected virtual void GroundVehicleClientTick() { }

	// RVA: 0xC86900 Offset: 0xC85D00 VA: 0x180C86900
	protected void .ctor() { }

}

