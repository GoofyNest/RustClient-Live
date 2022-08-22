public class TrainEngine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6394
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int throttleSetting; // 0x14
	public uint fuelStorageID; // 0x18
	public int fuelAmount; // 0x1C
	public int numConnectedCars; // 0x20
	public int linedUpToUnload; // 0x24


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

public class TrainEngine : TrainCar, IEngineControllerUser, IEntity // TypeDefIndex: 8472
{	private Option __menuOption_Menu_FuelStorage; // 0x538
	private int clientFuelAmount; // 0x590
	private int clientNumConnectedCars; // 0x594
	private int clientLinedUpToUnload; // 0x598
	private float lastUpdateHealth; // 0x59C
	private StringBuilder monitorTextStr; // 0x5A0
	private bool wasBraking; // 0x5A8
	private bool highlightCouplingInfo; // 0x5A9
	private TrainEngine.TrainMovementState movementState; // 0x5AC
	private Nullable<TrainEngine.TrainMovementState> prevLightVisualsState; // 0x5B0
	private Nullable<bool> prevLightVisualsOnState; // 0x5B8
	private Nullable<bool> prevLightVisualsHeadlightOnState; // 0x5BA
	[HeaderAttribute] // RVA: 0x947B0 Offset: 0x93BB0 VA: 0x1800947B0
	[SerializeField] // RVA: 0x947B0 Offset: 0x93BB0 VA: 0x1800947B0
	private Transform leftHandLever; // 0x5C0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform rightHandLever; // 0x5C8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform leftHandGrip; // 0x5D0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform rightHandGrip; // 0x5D8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TrainEngine.LeverStyle leverStyle; // 0x5E0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Canvas monitorCanvas; // 0x5E8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RustText monitorText; // 0x5F0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private LocomotiveExtraVisuals gauges; // 0x5F8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float engineForce; // 0x600
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float maxSpeed; // 0x604
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float engineStartupTime; // 0x608
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef fuelStoragePrefab; // 0x610
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float idleFuelPerSec; // 0x618
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float maxFuelPerSec; // 0x61C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ProtectionProperties driverProtection; // 0x620
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool lootablesAreOnPlatform; // 0x628
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleLight[] onLights; // 0x630
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleLight[] headlights; // 0x638
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleLight[] notMovingLights; // 0x640
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleLight[] movingForwardLights; // 0x648
	[FormerlySerializedAsAttribute] // RVA: 0x954D0 Offset: 0x948D0 VA: 0x1800954D0
	[SerializeField] // RVA: 0x954D0 Offset: 0x948D0 VA: 0x1800954D0
	private VehicleLight[] movingBackwardLights; // 0x650
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystemContainer fxEngineOn; // 0x658
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystemContainer fxLightDamage; // 0x660
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystemContainer fxMediumDamage; // 0x668
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystemContainer fxHeavyDamage; // 0x670
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystemContainer fxEngineTrouble; // 0x678
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BoxCollider engineWorldCol; // 0x680
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float engineDamageToSlow; // 0x688
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float engineDamageTimeframe; // 0x68C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float engineSlowedTime; // 0x690
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float engineSlowedMaxVel; // 0x694
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystemContainer[] sparks; // 0x698
	[FormerlySerializedAsAttribute] // RVA: 0x95FC0 Offset: 0x953C0 VA: 0x180095FC0
	[SerializeField] // RVA: 0x95FC0 Offset: 0x953C0 VA: 0x180095FC0
	private Light[] sparkLights; // 0x6A0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TrainEngineAudio trainAudio; // 0x6A8
	public const BaseEntity.Flags Flag_HazardAhead = 16384;
	private const BaseEntity.Flags Flag_Horn = 65536;
	public const BaseEntity.Flags Flag_AltColor = 131072;
	public const BaseEntity.Flags Flag_EngineSlowed = 262144;
	private VehicleEngineController<TrainEngine> engineController; // 0x6B0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TrainEngine.EngineSpeeds <CurThrottleSetting>k__BackingField; // 0x6B8

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

	[BaseEntity.Menu] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.Description] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.Icon] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	public void Menu_FuelStorage(BasePlayer player) { }

	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetThrottle(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetFuelAmount(BaseEntity.RPCMessage msg) { }

	public bool get_LightsAreOn() { }

	public bool get_CloseToHazard() { }

	public bool get_EngineIsSlowed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public TrainEngine.EngineSpeeds get_CurThrottleSetting() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

private enum TrainEngine.TrainMovementState // TypeDefIndex: 8473
{	public int value__; // 0x0
	public const TrainEngine.TrainMovementState Stationary = 0;
	public const TrainEngine.TrainMovementState MovingForwards = 1;
	public const TrainEngine.TrainMovementState MovingBackwards = 2;

}

private enum TrainEngine.LeverStyle // TypeDefIndex: 8474
{	public int value__; // 0x0
	public const TrainEngine.LeverStyle WorkCart = 0;
	public const TrainEngine.LeverStyle Locomotive = 1;

}

public enum TrainEngine.EngineSpeeds // TypeDefIndex: 8475
{	public int value__; // 0x0
	public const TrainEngine.EngineSpeeds Rev_Hi = 0;
	public const TrainEngine.EngineSpeeds Rev_Med = 1;
	public const TrainEngine.EngineSpeeds Rev_Lo = 2;
	public const TrainEngine.EngineSpeeds Zero = 3;
	public const TrainEngine.EngineSpeeds Fwd_Lo = 4;
	public const TrainEngine.EngineSpeeds Fwd_Med = 5;
	public const TrainEngine.EngineSpeeds Fwd_Hi = 6;

}

