public class BaseSubmarine : BaseVehicle, IEngineControllerUser, IEntity, IAirSupply // TypeDefIndex: 10070
{
	private Option __menuOption_Menu_FuelStorage;
	private Option __menuOption_Menu_ItemStorage;
	private Option __menuOption_Menu_Push;
	private Option __menuOption_Menu_TorpedoStorage;
	[CompilerGeneratedAttribute]
	private float <PropPercentVelocity>k__BackingField;
	private bool runningClientTick;
	private bool playedDiveBubbles;
	private bool playedWindowFilm;
	private float baseAlphaInside;
	private float baseAlphaOutside;
	[HeaderAttribute]
	[SerializeField]
	private Transform centreOfMassTransform;
	[SerializeField]
	private Buoyancy buoyancy;
	[SerializeField]
	protected float maxRudderAngle;
	[SerializeField]
	private Transform rudderVisualTransform;
	[SerializeField]
	private Transform rudderDetailedColliderTransform;
	[SerializeField]
	private Transform propellerTransform;
	[SerializeField]
	private float timeUntilAutoSurface;
	[SerializeField]
	private Renderer[] interiorRenderers;
	[SerializeField]
	private SonarObject sonarObject;
	[SerializeField]
	private BaseSubmarine.ParentTriggerInfo[] parentTriggers;
	[SerializeField]
	private GameObjectRef fuelStoragePrefab;
	[HeaderAttribute]
	[SerializeField]
	private float engineKW;
	[SerializeField]
	private float turnPower;
	[SerializeField]
	private float engineStartupTime;
	[SerializeField]
	private GameObjectRef itemStoragePrefab;
	[SerializeField]
	private float depthChangeTargetSpeed;
	[SerializeField]
	private float idleFuelPerSec;
	[SerializeField]
	private float maxFuelPerSec;
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private bool internalAccessStorage;
	[HeaderAttribute]
	[SerializeField]
	private GameObjectRef torpedoStoragePrefab;
	[SerializeField]
	private Transform torpedoFiringPoint;
	[SerializeField]
	private float maxFireRate;
	[HeaderAttribute]
	[SerializeField]
	protected SubmarineAudio submarineAudio;
	[SerializeField]
	private ParticleSystem fxTorpedoFire;
	[SerializeField]
	private GameObject internalFXContainer;
	[SerializeField]
	private GameObject internalOnFXContainer;
	[SerializeField]
	private ParticleSystem fxIntAmbientBubbleLoop;
	[SerializeField]
	private ParticleSystem fxIntInitialDiveBubbles;
	[SerializeField]
	private ParticleSystem fxIntWaterDropSpray;
	[SerializeField]
	private ParticleSystem fxIntWindowFilm;
	[SerializeField]
	private ParticleSystemContainer fxIntMediumDamage;
	[SerializeField]
	private ParticleSystemContainer fxIntHeavyDamage;
	[SerializeField]
	private GameObject externalFXContainer;
	[SerializeField]
	private GameObject externalOnFXContainer;
	[SerializeField]
	private ParticleSystem fxExtAmbientBubbleLoop;
	[SerializeField]
	private ParticleSystem fxExtInitialDiveBubbles;
	[SerializeField]
	private ParticleSystem fxExtAboveWaterEngineThrustForward;
	[SerializeField]
	private ParticleSystem fxExtAboveWaterEngineThrustReverse;
	[SerializeField]
	private ParticleSystem fxExtUnderWaterEngineThrustForward;
	[SerializeField]
	private ParticleSystem[] fxExtUnderWaterEngineThrustForwardSubs;
	[SerializeField]
	private ParticleSystem fxExtUnderWaterEngineThrustReverse;
	[SerializeField]
	private ParticleSystem[] fxExtUnderWaterEngineThrustReverseSubs;
	[SerializeField]
	private ParticleSystem fxExtBowWave;
	[SerializeField]
	private ParticleSystem fxExtWakeEffect;
	[SerializeField]
	private GameObjectRef aboveWatercollisionEffect;
	[SerializeField]
	private GameObjectRef underWatercollisionEffect;
	[SerializeField]
	private VolumetricLightBeam spotlightVolumetrics;
	[SerializeField]
	private float mountedAlphaInside;
	[SerializeField]
	private float mountedAlphaOutside;
	[ServerVar]
	public static float outsidedecayminutes;
	[ServerVar]
	public static float deepwaterdecayminutes;
	[ServerVar]
	public static float oxygenminutes;
	[CompilerGeneratedAttribute]
	private Vector3 <Velocity>k__BackingField;
	public const BaseEntity.Flags Flag_Ammo = 16384;
	private float _throttle;
	private float _rudder;
	private float _upDown;
	private float _oxygen;
	protected VehicleEngineController<BaseSubmarine> engineController;
	protected float cachedFuelAmount;
	protected Vector3 steerAngle;
	protected float waterSurfaceY;
	protected float curSubDepthY;
	private EntityRef<StorageContainer> torpedoStorageInstance;
	private EntityRef<StorageContainer> itemStorageInstance;
	private int waterLayerMask;

	public override bool HasMenuOptions { get; }
	public float PropPercentVelocity { get; set; }
	public ItemModGiveOxygen.AirSupplyType AirType { get; }
	public VehicleEngineController.EngineState<BaseSubmarine> EngineState { get; }
	public Vector3 Velocity { get; set; }
	public bool LightsAreOn { get; }
	public bool HasAmmo { get; }
	public float ThrottleInput { get; set; }
	public float RudderInput { get; set; }
	public float UpDownInput { get; set; }
	public float Oxygen { get; set; }
	protected float PhysicalRudderAngle { get; }
	protected bool IsInWater { get; }
	protected bool IsSurfaced { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute]
	public float get_PropPercentVelocity() { }

	[CompilerGeneratedAttribute]
	private void set_PropPercentVelocity(float value) { }

	protected override void ClientInit(Entity info) { }

	private void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public override bool MountMenuVisible(BasePlayer player) { }

	private void StartClientTick() { }

	private void StopClientTick() { }

	protected void SubmarineClientTick() { }

	protected virtual bool UpdateInteriorVisuals(bool playerIsInside, float speed) { }

	protected virtual bool UpdateExteriorVisuals(bool playerIsInside, float speed) { }

	private void AmbientLoopBubbles(ParticleSystem particleSystem) { }

	private void InitialDiveBubbles(ParticleSystem particleSystem) { }

	protected virtual void TorpedoFired() { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_FuelStorage(BasePlayer player) { }

	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_TorpedoStorage(BasePlayer player) { }

	public bool Menu_TorpedoStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_ItemStorage(BasePlayer player) { }

	public bool Menu_ItemStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public virtual void Menu_Push(BasePlayer player) { }

	[BaseEntity.RPC_Client]
	private void SubmarineUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client]
	private void EngineStartFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client]
	private void TorpedoFired(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client]
	private void TorpedoFireFailed(BaseEntity.RPCMessage msg) { }

	public ItemModGiveOxygen.AirSupplyType get_AirType() { }

	public VehicleEngineController.EngineState<BaseSubmarine> get_EngineState() { }

	[CompilerGeneratedAttribute]
	public Vector3 get_Velocity() { }

	[CompilerGeneratedAttribute]
	private void set_Velocity(Vector3 value) { }

	public bool get_LightsAreOn() { }

	public bool get_HasAmmo() { }

	public float get_ThrottleInput() { }

	protected void set_ThrottleInput(float value) { }

	public float get_RudderInput() { }

	protected void set_RudderInput(float value) { }

	public float get_UpDownInput() { }

	protected void set_UpDownInput(float value) { }

	public float get_Oxygen() { }

	protected void set_Oxygen(float value) { }

	protected float get_PhysicalRudderAngle() { }

	protected bool get_IsInWater() { }

	protected bool get_IsSurfaced() { }

	public override void InitShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public override float WaterFactorForPlayer(BasePlayer player) { }

	public override float AirFactor() { }

	public override bool BlocksWaterFor(BasePlayer player) { }

	public float GetFuelAmount() { }

	public float GetSpeed() { }

	public override bool CanBeLooted(BasePlayer player) { }

	public float GetAirTimeRemaining() { }

	protected override bool CanPushNow(BasePlayer pusher) { }

	private void UpdatePhysicalRudder(float turnInput, float deltaTime) { }

	private bool CanMount(BasePlayer player) { }

	private void UpdateWaterInfo() { }

	private float GetWaterSurfaceY() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class BaseSubmarine.ParentTriggerInfo // TypeDefIndex: 10071
{
	public TriggerParent trigger;
	public Transform triggerWaterLevel;


	public void .ctor() { }

}

