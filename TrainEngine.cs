public class TrainEngine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6394
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int throttleSetting; // 0x14
	public uint fuelStorageID; // 0x18
	public int fuelAmount; // 0x1C
	public int numConnectedCars; // 0x20
	public int linedUpToUnload; // 0x24

	// Methods

	// RVA: 0x1EECAB0 Offset: 0x1EEBEB0 VA: 0x181EECAB0
	public static void ResetToPool(TrainEngine instance) { }

	// RVA: 0x1EECB60 Offset: 0x1EEBF60 VA: 0x181EECB60
	public void ResetToPool() { }

	// RVA: 0x1EEC710 Offset: 0x1EEBB10 VA: 0x181EEC710 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1C720 Offset: 0x1E1BB20 VA: 0x181E1C720
	public void CopyTo(TrainEngine instance) { }

	// RVA: 0x1EEB400 Offset: 0x1EEA800 VA: 0x181EEB400
	public TrainEngine Copy() { }

	// RVA: 0x1EEBBB0 Offset: 0x1EEAFB0 VA: 0x181EEBBB0
	public static TrainEngine Deserialize(Stream stream) { }

	// RVA: 0x1EEB480 Offset: 0x1EEA880 VA: 0x181EEB480
	public static TrainEngine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EEB820 Offset: 0x1EEAC20 VA: 0x181EEB820
	public static TrainEngine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EEC170 Offset: 0x1EEB570 VA: 0x181EEC170
	public static TrainEngine Deserialize(byte[] buffer) { }

	// RVA: 0x1EEC840 Offset: 0x1EEBC40 VA: 0x181EEC840
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EED1C0 Offset: 0x1EEC5C0 VA: 0x181EED1C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EED1E0 Offset: 0x1EEC5E0 VA: 0x181EED1E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, TrainEngine previous) { }

	// RVA: 0x1EECA90 Offset: 0x1EEBE90 VA: 0x181EECA90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEBE40 Offset: 0x1EEB240 VA: 0x181EEBE40
	public static TrainEngine Deserialize(byte[] buffer, TrainEngine instance, bool isDelta = False) { }

	// RVA: 0x1EEC4C0 Offset: 0x1EEB8C0 VA: 0x181EEC4C0
	public static TrainEngine Deserialize(Stream stream, TrainEngine instance, bool isDelta) { }

	// RVA: 0x1EEB500 Offset: 0x1EEA900 VA: 0x181EEB500
	public static TrainEngine DeserializeLengthDelimited(Stream stream, TrainEngine instance, bool isDelta) { }

	// RVA: 0x1EEB8B0 Offset: 0x1EEACB0 VA: 0x181EEB8B0
	public static TrainEngine DeserializeLength(Stream stream, int length, TrainEngine instance, bool isDelta) { }

	// RVA: 0x1EECC10 Offset: 0x1EEC010 VA: 0x181EECC10
	public static void SerializeDelta(Stream stream, TrainEngine instance, TrainEngine previous) { }

	// RVA: 0x1EED040 Offset: 0x1EEC440 VA: 0x181EED040
	public static void Serialize(Stream stream, TrainEngine instance) { }

	// RVA: 0x1EED1B0 Offset: 0x1EEC5B0 VA: 0x181EED1B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EED1C0 Offset: 0x1EEC5C0 VA: 0x181EED1C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EECF30 Offset: 0x1EEC330 VA: 0x181EECF30
	public static byte[] SerializeToBytes(TrainEngine instance) { }

	// RVA: 0x1EECE80 Offset: 0x1EEC280 VA: 0x181EECE80
	public static void SerializeLengthDelimited(Stream stream, TrainEngine instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class TrainEngine : TrainCar, IEngineControllerUser, IEntity // TypeDefIndex: 8472
{	// Fields
	private Option __menuOption_Menu_FuelStorage; // 0x538
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

	// Properties
	public override bool HasMenuOptions { get; }
	public bool LightsAreOn { get; }
	public bool CloseToHazard { get; }
	public bool EngineIsSlowed { get; }
	public TrainEngine.EngineSpeeds CurThrottleSetting { get; set; }
	public override TrainCar.TrainCarType CarType { get; }

	// Methods

	// RVA: 0x9F2770 Offset: 0x9F1B70 VA: 0x1809F2770 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9F53B0 Offset: 0x9F47B0 VA: 0x1809F53B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9F3320 Offset: 0x9F2720 VA: 0x1809F3320 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9F25F0 Offset: 0x9F19F0 VA: 0x1809F25F0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x9F2440 Offset: 0x9F1840 VA: 0x1809F2440 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x9F25C0 Offset: 0x9F19C0 VA: 0x1809F25C0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x9F41D0 Offset: 0x9F35D0 VA: 0x1809F41D0 Slot: 201
	protected override void TrainClientTick() { }

	// RVA: 0x9F3FE0 Offset: 0x9F33E0 VA: 0x1809F3FE0 Slot: 200
	protected override void StopClientTick() { }

	// RVA: 0x9F3AB0 Offset: 0x9F2EB0 VA: 0x1809F3AB0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x9F50A0 Offset: 0x9F44A0 VA: 0x1809F50A0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x9F31C0 Offset: 0x9F25C0 VA: 0x1809F31C0 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x9F2070 Offset: 0x9F1470 VA: 0x1809F2070 Slot: 199
	protected override void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x9F32F0 Offset: 0x9F26F0 VA: 0x1809F32F0 Slot: 132
	protected override void OnLifeStateChanged() { }

	// RVA: 0x9F3AF0 Offset: 0x9F2EF0 VA: 0x1809F3AF0
	private void RefreshMovementLightVisuals() { }

	// RVA: 0x9F4CF0 Offset: 0x9F40F0 VA: 0x1809F4CF0
	private void UpdateMonitorVisuals(bool couplingChanged = False) { }

	// RVA: 0x9F3D30 Offset: 0x9F3130 VA: 0x1809F3D30
	private void ResetMonitorCouplingHighlight() { }

	// RVA: 0x9F4510 Offset: 0x9F3910 VA: 0x1809F4510
	private void UpdateControlLeverVisuals() { }

	// RVA: 0x9F43B0 Offset: 0x9F37B0 VA: 0x1809F43B0 Slot: 202
	protected override bool UpdateBraking(float forwardSpeed) { }

	// RVA: 0x9F3AA0 Offset: 0x9F2EA0 VA: 0x1809F3AA0
	protected void PlaySparks() { }

	// RVA: 0x9F41C0 Offset: 0x9F35C0 VA: 0x1809F41C0
	protected void StopSparks() { }

	// RVA: 0x9F3DA0 Offset: 0x9F31A0 VA: 0x1809F3DA0
	protected void SetSparks(bool play) { }

	// RVA: 0x9F4840 Offset: 0x9F3C40 VA: 0x1809F4840
	private void UpdateDamageFX() { }

	// RVA: 0x9F4BC0 Offset: 0x9F3FC0 VA: 0x1809F4BC0
	private void UpdateEngineFX() { }

	[BaseEntity.Menu] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.Description] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.Icon] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	// RVA: 0x9F3180 Offset: 0x9F2580 VA: 0x1809F3180
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x9F30B0 Offset: 0x9F24B0 VA: 0x1809F30B0
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9F3F60 Offset: 0x9F3360 VA: 0x1809F3F60
	private void SetThrottle(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9F3D50 Offset: 0x9F3150 VA: 0x1809F3D50
	private void SetFuelAmount(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7518F0 Offset: 0x750CF0 VA: 0x1807518F0
	public bool get_LightsAreOn() { }

	// RVA: 0x5717B0 Offset: 0x570BB0 VA: 0x1805717B0
	public bool get_CloseToHazard() { }

	// RVA: 0x9F53A0 Offset: 0x9F47A0 VA: 0x1809F53A0
	public bool get_EngineIsSlowed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9F5390 Offset: 0x9F4790 VA: 0x1809F5390
	public TrainEngine.EngineSpeeds get_CurThrottleSetting() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9F5470 Offset: 0x9F4870 VA: 0x1809F5470
	protected void set_CurThrottleSetting(TrainEngine.EngineSpeeds value) { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 204
	public override TrainCar.TrainCarType get_CarType() { }

	// RVA: 0x9F2B00 Offset: 0x9F1F00 VA: 0x1809F2B00 Slot: 28
	public override void InitShared() { }

	// RVA: 0x9F2E90 Offset: 0x9F2290 VA: 0x1809F2E90 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x9F1ED0 Offset: 0x9F12D0 VA: 0x1809F1ED0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x9F26A0 Offset: 0x9F1AA0 VA: 0x1809F26A0
	private float GetEnginePowerMultiplier(float minPercent) { }

	// RVA: 0x9F2A80 Offset: 0x9F1E80 VA: 0x1809F2A80
	public float GetThrottleFraction() { }

	// RVA: 0x9F2D50 Offset: 0x9F2150 VA: 0x1809F2D50
	public bool IsNearDesiredSpeed(float leeway) { }

	// RVA: 0x9F3FA0 Offset: 0x9F33A0 VA: 0x1809F3FA0 Slot: 205
	protected override void SetTrackSelection(TrainTrackSpline.TrackSelection trackSelection) { }

	// RVA: 0x9F3ED0 Offset: 0x9F32D0 VA: 0x1809F3ED0
	private void SetThrottle(TrainEngine.EngineSpeeds throttle) { }

	// RVA: 0x9F2760 Offset: 0x9F1B60 VA: 0x1809F2760
	private int GetFuelAmount() { }

	// RVA: 0x9F1FF0 Offset: 0x9F13F0 VA: 0x1809F1FF0
	private bool CanMount(BasePlayer player) { }

	// RVA: 0x9F1FF0 Offset: 0x9F13F0 VA: 0x1809F1FF0
	private bool PlayerIsOnPlatform(BasePlayer player) { }

	// RVA: 0x9F5250 Offset: 0x9F4650 VA: 0x1809F5250
	public void .ctor() { }

}

private enum TrainEngine.TrainMovementState // TypeDefIndex: 8473
{	// Fields
	public int value__; // 0x0
	public const TrainEngine.TrainMovementState Stationary = 0;
	public const TrainEngine.TrainMovementState MovingForwards = 1;
	public const TrainEngine.TrainMovementState MovingBackwards = 2;

}

private enum TrainEngine.LeverStyle // TypeDefIndex: 8474
{	// Fields
	public int value__; // 0x0
	public const TrainEngine.LeverStyle WorkCart = 0;
	public const TrainEngine.LeverStyle Locomotive = 1;

}

public enum TrainEngine.EngineSpeeds // TypeDefIndex: 8475
{	// Fields
	public int value__; // 0x0
	public const TrainEngine.EngineSpeeds Rev_Hi = 0;
	public const TrainEngine.EngineSpeeds Rev_Med = 1;
	public const TrainEngine.EngineSpeeds Rev_Lo = 2;
	public const TrainEngine.EngineSpeeds Zero = 3;
	public const TrainEngine.EngineSpeeds Fwd_Lo = 4;
	public const TrainEngine.EngineSpeeds Fwd_Med = 5;
	public const TrainEngine.EngineSpeeds Fwd_Hi = 6;

}

