public class TrainEngine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6398
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int throttleSetting; 
	public uint fuelStorageID; 
	public int fuelAmount; 
	public int numConnectedCars; 
	public int linedUpToUnload; 


	public static void ResetToPool(TrainEngine instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(TrainEngine instance) { }

	public TrainEngine Copy() { }

	public static TrainEngine Deserialize(Stream stream) { }

	public static TrainEngine DeserializeLengthDelimited(Stream stream) { }

	public static TrainEngine DeserializeLength(Stream stream, int length) { }

	public static TrainEngine Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, TrainEngine previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static TrainEngine Deserialize(byte[] buffer, TrainEngine instance, bool isDelta = False) { }

	public static TrainEngine Deserialize(Stream stream, TrainEngine instance, bool isDelta) { }

	public static TrainEngine DeserializeLengthDelimited(Stream stream, TrainEngine instance, bool isDelta) { }

	public static TrainEngine DeserializeLength(Stream stream, int length, TrainEngine instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, TrainEngine instance, TrainEngine previous) { }

	public static void Serialize(Stream stream, TrainEngine instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(TrainEngine instance) { }

	public static void SerializeLengthDelimited(Stream stream, TrainEngine instance) { }

	public void .ctor() { }

}

public class TrainEngine : TrainCar, IEngineControllerUser, IEntity // TypeDefIndex: 10177
{
	private Option __menuOption_Menu_FuelStorage; 
	private int clientFuelAmount; 
	private int clientNumConnectedCars; 
	private int clientLinedUpToUnload; 
	private float lastUpdateHealth; 
	private StringBuilder monitorTextStr; 
	private bool wasBraking; 
	private bool highlightCouplingInfo; 
	private TrainEngine.TrainMovementState movementState; 
	private Nullable<TrainEngine.TrainMovementState> prevLightVisualsState; 
	private Nullable<bool> prevLightVisualsOnState; 
	private Nullable<bool> prevLightVisualsHeadlightOnState; 
	[HeaderAttribute] 
	[SerializeField] 
	private Transform leftHandLever; 
	[SerializeField] 
	private Transform rightHandLever; 
	[SerializeField] 
	private Transform leftHandGrip; 
	[SerializeField] 
	private Transform rightHandGrip; 
	[SerializeField] 
	private TrainEngine.LeverStyle leverStyle; 
	[SerializeField] 
	private Canvas monitorCanvas; 
	[SerializeField] 
	private RustText monitorText; 
	[SerializeField] 
	private LocomotiveExtraVisuals gauges; 
	[SerializeField] 
	private float engineForce; 
	[SerializeField] 
	private float maxSpeed; 
	[SerializeField] 
	private float engineStartupTime; 
	[SerializeField] 
	private GameObjectRef fuelStoragePrefab; 
	[SerializeField] 
	private float idleFuelPerSec; 
	[SerializeField] 
	private float maxFuelPerSec; 
	[SerializeField] 
	private ProtectionProperties driverProtection; 
	[SerializeField] 
	private bool lootablesAreOnPlatform; 
	[SerializeField] 
	private bool mustMountFromPlatform; 
	[SerializeField] 
	private VehicleLight[] onLights; 
	[SerializeField] 
	private VehicleLight[] headlights; 
	[SerializeField] 
	private VehicleLight[] notMovingLights; 
	[SerializeField] 
	private VehicleLight[] movingForwardLights; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private VehicleLight[] movingBackwardLights; 
	[SerializeField] 
	private ParticleSystemContainer fxEngineOn; 
	[SerializeField] 
	private ParticleSystemContainer fxLightDamage; 
	[SerializeField] 
	private ParticleSystemContainer fxMediumDamage; 
	[SerializeField] 
	private ParticleSystemContainer fxHeavyDamage; 
	[SerializeField] 
	private ParticleSystemContainer fxEngineTrouble; 
	[SerializeField] 
	private BoxCollider engineWorldCol; 
	[SerializeField] 
	private float engineDamageToSlow; 
	[SerializeField] 
	private float engineDamageTimeframe; 
	[SerializeField] 
	private float engineSlowedTime; 
	[SerializeField] 
	private float engineSlowedMaxVel; 
	[SerializeField] 
	private ParticleSystemContainer[] sparks; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private Light[] sparkLights; 
	[SerializeField] 
	private TrainEngineAudio trainAudio; 
	public const BaseEntity.Flags Flag_HazardAhead = 16384;
	private const BaseEntity.Flags Flag_Horn = 65536;
	public const BaseEntity.Flags Flag_AltColor = 131072;
	public const BaseEntity.Flags Flag_EngineSlowed = 262144;
	private VehicleEngineController<TrainEngine> engineController; 
	[CompilerGeneratedAttribute] 
	private TrainEngine.EngineSpeeds <CurThrottleSetting>k__BackingField; 

	public override bool HasMenuOptions { get; }
	public bool LightsAreOn { get; }
	public bool CloseToHazard { get; }
	public bool EngineIsSlowed { get; }
	public TrainEngine.EngineSpeeds CurThrottleSetting { get; set; }
	public override TrainCar.TrainCarType CarType { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	protected override void ClientInit(Entity info) { }

	public override void ClientOnEnable() { }

	protected override void TrainClientTick() { }

	protected override void StopClientTick() { }

	public override void PostNetworkUpdate() { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public override bool MountMenuVisible(BasePlayer player) { }

	public override GameObjectRef GetImpactEffect(HitInfo info) { }

	protected override void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	protected override void OnLifeStateChanged() { }

	private void RefreshMovementLightVisuals() { }

	private void UpdateMonitorVisuals(bool couplingChanged = False) { }

	private void ResetMonitorCouplingHighlight() { }

	private void UpdateControlLeverVisuals() { }

	protected override bool UpdateBraking(float forwardSpeed) { }

	protected void PlaySparks() { }

	protected void StopSparks() { }

	protected void SetSparks(bool play) { }

	private void UpdateDamageFX() { }

	private void UpdateEngineFX() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_FuelStorage(BasePlayer player) { }

	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] 
	private void SetThrottle(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void SetFuelAmount(BaseEntity.RPCMessage msg) { }

	public bool get_LightsAreOn() { }

	public bool get_CloseToHazard() { }

	public bool get_EngineIsSlowed() { }

	[CompilerGeneratedAttribute] 
	public TrainEngine.EngineSpeeds get_CurThrottleSetting() { }

	[CompilerGeneratedAttribute] 
	protected void set_CurThrottleSetting(TrainEngine.EngineSpeeds value) { }

	public override TrainCar.TrainCarType get_CarType() { }

	public override void InitShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override bool CanBeLooted(BasePlayer player) { }

	private float GetEnginePowerMultiplier(float minPercent) { }

	public float GetThrottleFraction() { }

	public bool IsNearDesiredSpeed(float leeway) { }

	protected override void SetTrackSelection(TrainTrackSpline.TrackSelection trackSelection) { }

	private void SetThrottle(TrainEngine.EngineSpeeds throttle) { }

	private int GetFuelAmount() { }

	private bool CanMount(BasePlayer player) { }

	private bool PlayerIsOnPlatform(BasePlayer player) { }

	public void .ctor() { }

}

private enum TrainEngine.TrainMovementState // TypeDefIndex: 10178
{
	public int value__; 
	public const TrainEngine.TrainMovementState Stationary = 0;
	public const TrainEngine.TrainMovementState MovingForwards = 1;
	public const TrainEngine.TrainMovementState MovingBackwards = 2;

}

private enum TrainEngine.LeverStyle // TypeDefIndex: 10179
{
	public int value__; 
	public const TrainEngine.LeverStyle WorkCart = 0;
	public const TrainEngine.LeverStyle Locomotive = 1;

}

public enum TrainEngine.EngineSpeeds // TypeDefIndex: 10180
{
	public int value__; 
	public const TrainEngine.EngineSpeeds Rev_Hi = 0;
	public const TrainEngine.EngineSpeeds Rev_Med = 1;
	public const TrainEngine.EngineSpeeds Rev_Lo = 2;
	public const TrainEngine.EngineSpeeds Zero = 3;
	public const TrainEngine.EngineSpeeds Fwd_Lo = 4;
	public const TrainEngine.EngineSpeeds Fwd_Med = 5;
	public const TrainEngine.EngineSpeeds Fwd_Hi = 6;

}

