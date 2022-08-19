public class Snowmobile : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6423
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float steerInput; // 0x14
	public float driveWheelVel; // 0x18
	public float throttleInput; // 0x1C
	public float brakeInput; // 0x20
	public uint storageID; // 0x24
	public uint fuelStorageID; // 0x28
	public float fuelFraction; // 0x2C

	// Methods

	// RVA: 0x1DB03A0 Offset: 0x1DAF7A0 VA: 0x181DB03A0
	public static void ResetToPool(Snowmobile instance) { }

	// RVA: 0x1DB02D0 Offset: 0x1DAF6D0 VA: 0x181DB02D0
	public void ResetToPool() { }

	// RVA: 0x1DAFB10 Offset: 0x1DAEF10 VA: 0x181DAFB10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DAE0C0 Offset: 0x1DAD4C0 VA: 0x181DAE0C0
	public void CopyTo(Snowmobile instance) { }

	// RVA: 0x1DAE100 Offset: 0x1DAD500 VA: 0x181DAE100
	public Snowmobile Copy() { }

	// RVA: 0x1DAF7F0 Offset: 0x1DAEBF0 VA: 0x181DAF7F0
	public static Snowmobile Deserialize(Stream stream) { }

	// RVA: 0x1DAE190 Offset: 0x1DAD590 VA: 0x181DAE190
	public static Snowmobile DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DAE5D0 Offset: 0x1DAD9D0 VA: 0x181DAE5D0
	public static Snowmobile DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DAF400 Offset: 0x1DAE800 VA: 0x181DAF400
	public static Snowmobile Deserialize(byte[] buffer) { }

	// RVA: 0x1DAFC60 Offset: 0x1DAF060 VA: 0x181DAFC60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB0B40 Offset: 0x1DAFF40 VA: 0x181DB0B40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB0B60 Offset: 0x1DAFF60 VA: 0x181DB0B60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Snowmobile previous) { }

	// RVA: 0x1DAFF40 Offset: 0x1DAF340 VA: 0x181DAFF40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DAF030 Offset: 0x1DAE430 VA: 0x181DAF030
	public static Snowmobile Deserialize(byte[] buffer, Snowmobile instance, bool isDelta = False) { }

	// RVA: 0x1DAED50 Offset: 0x1DAE150 VA: 0x181DAED50
	public static Snowmobile Deserialize(Stream stream, Snowmobile instance, bool isDelta) { }

	// RVA: 0x1DAE210 Offset: 0x1DAD610 VA: 0x181DAE210
	public static Snowmobile DeserializeLengthDelimited(Stream stream, Snowmobile instance, bool isDelta) { }

	// RVA: 0x1DAE9B0 Offset: 0x1DADDB0 VA: 0x181DAE9B0
	public static Snowmobile DeserializeLength(Stream stream, int length, Snowmobile instance, bool isDelta) { }

	// RVA: 0x1DB0470 Offset: 0x1DAF870 VA: 0x181DB0470
	public static void SerializeDelta(Stream stream, Snowmobile instance, Snowmobile previous) { }

	// RVA: 0x1DB0970 Offset: 0x1DAFD70 VA: 0x181DB0970
	public static void Serialize(Stream stream, Snowmobile instance) { }

	// RVA: 0x1DB0B30 Offset: 0x1DAFF30 VA: 0x181DB0B30
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB0B40 Offset: 0x1DAFF40 VA: 0x181DB0B40
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB0860 Offset: 0x1DAFC60 VA: 0x181DB0860
	public static byte[] SerializeToBytes(Snowmobile instance) { }

	// RVA: 0x1DB07B0 Offset: 0x1DAFBB0 VA: 0x181DB07B0
	public static void SerializeLengthDelimited(Stream stream, Snowmobile instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class Snowmobile : GroundVehicle, VehicleChassisVisuals.IClientWheelUser<Snowmobile>, IPrefabPreProcess // TypeDefIndex: 8451
{	// Fields
	private Option __menuOption_Menu_FuelStorage; // 0x408
	private Option __menuOption_Menu_ItemStorage; // 0x460
	private Option __menuOption_Menu_Push; // 0x4B8
	public TimeSince timeSinceLastUpdate; // 0x510
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> treadFLData; // 0x518
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> treadFRData; // 0x520
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> treadRLData; // 0x528
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> treadRRData; // 0x530
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> skiLData; // 0x538
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> skiRData; // 0x540
	private float clientSteerInput; // 0x548
	private float clientDriveWheelVelocity; // 0x54C
	private float clientDriveWheelSlip; // 0x550
	private bool wasBraking; // 0x554
	private Vector3 leanVector; // 0x558
	private Vector3[] recentVels; // 0x568
	private int recentVelsIndex; // 0x570
	private TimeSince timeSinceFailedStartAttempt; // 0x574
	private const float FAILED_START_MIN_TIME = 1;
	[HeaderAttribute] // RVA: 0x88830 Offset: 0x87C30 VA: 0x180088830
	[SerializeField] // RVA: 0x88830 Offset: 0x87C30 VA: 0x180088830
	private Transform centreOfMassTransform; // 0x578
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef itemStoragePrefab; // 0x580
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VisualCarWheel wheelSkiFL; // 0x588
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VisualCarWheel wheelSkiFR; // 0x590
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VisualCarWheel wheelTreadFL; // 0x598
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VisualCarWheel wheelTreadFR; // 0x5A0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VisualCarWheel wheelTreadRL; // 0x5A8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VisualCarWheel wheelTreadRR; // 0x5B0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CarSettings carSettings; // 0x5B8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int engineKW; // 0x5C0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float idleFuelPerSec; // 0x5C4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float maxFuelPerSec; // 0x5C8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float airControlStability; // 0x5CC
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float airControlPower; // 0x5D0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float badTerrainDrag; // 0x5D4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ProtectionProperties riderProtection; // 0x5D8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float hurtTriggerMinSpeed; // 0x5E0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TriggerHurtNotChild hurtTriggerFront; // 0x5E8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TriggerHurtNotChild hurtTriggerRear; // 0x5F0
	[HeaderAttribute] // RVA: 0x8AB50 Offset: 0x89F50 VA: 0x18008AB50
	public float minGroundFXSpeed; // 0x5F8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SnowmobileChassisVisuals chassisVisuals; // 0x600
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleLight[] lights; // 0x608
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform steeringLeftIK; // 0x610
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform steeringRightIK; // 0x618
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform leftFootIK; // 0x620
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform rightFootIK; // 0x628
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform starterKey; // 0x630
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 engineOffKeyRot; // 0x638
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 engineOnKeyRot; // 0x644
	[ServerVar] // RVA: 0x8B090 Offset: 0x8A490 VA: 0x18008B090
	public static float outsideDecayMinutes; // 0x0
	[ServerVar] // RVA: 0x8B1B0 Offset: 0x8A5B0 VA: 0x18008B1B0
	public static bool allowPassengerOnly; // 0x4
	[ServerVar] // RVA: 0x8B2B0 Offset: 0x8A6B0 VA: 0x18008B2B0
	public static bool allTerrain; // 0x5
	private float _throttle; // 0x650
	private float _brake; // 0x654
	private float _steer; // 0x658
	private float _mass; // 0x65C
	public const BaseEntity.Flags Flag_Slowmode = 65536;
	private EntityRef<StorageContainer> itemStorageInstance; // 0x660
	private float cachedFuelFraction; // 0x670
	private const float FORCE_MULTIPLIER = 10;

	// Properties
	public override bool HasMenuOptions { get; }
	public float ThrottleInput { get; set; }
	public float BrakeInput { get; set; }
	public bool IsBraking { get; }
	public float SteerInput { get; set; }
	public float SteerAngle { get; }
	public override float DriveWheelVelocity { get; }
	public float DriveWheelSlip { get; }
	public float MaxSteerAngle { get; }
	public bool InSlowMode { get; }
	private float Mass { get; }

	// Methods

	// RVA: 0x5CE1B0 Offset: 0x5CD5B0 VA: 0x1805CE1B0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x5D06B0 Offset: 0x5CFAB0 VA: 0x1805D06B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5CF1E0 Offset: 0x5CE5E0 VA: 0x1805CF1E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5CD8D0 Offset: 0x5CCCD0 VA: 0x1805CD8D0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x5CD760 Offset: 0x5CCB60 VA: 0x1805CD760 Slot: 200
	protected override void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5CFB40 Offset: 0x5CEF40 VA: 0x1805CFB40 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x5CEC50 Offset: 0x5CE050 VA: 0x1805CEC50
	public bool IsATreadWheel(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData) { }

	// RVA: 0x5CEC30 Offset: 0x5CE030 VA: 0x1805CEC30
	public bool IsASkiWheel(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData) { }

	// RVA: 0x5CDEC0 Offset: 0x5CD2C0 VA: 0x1805CDEC0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x5CEA70 Offset: 0x5CDE70 VA: 0x1805CEA70 Slot: 202
	protected override void GroundVehicleClientTick() { }

	// RVA: 0x5CF120 Offset: 0x5CE520 VA: 0x1805CF120 Slot: 201
	protected override void OnClientTickStopped() { }

	[BaseEntity.Menu] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.Description] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.Icon] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	// RVA: 0x5CEF90 Offset: 0x5CE390 VA: 0x1805CEF90
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x5CEDB0 Offset: 0x5CE1B0 VA: 0x1805CEDB0
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8C750 Offset: 0x8BB50 VA: 0x18008C750
	[BaseEntity.Menu.Description] // RVA: 0x8C750 Offset: 0x8BB50 VA: 0x18008C750
	[BaseEntity.Menu.Icon] // RVA: 0x8C750 Offset: 0x8BB50 VA: 0x18008C750
	[BaseEntity.Menu.ShowIf] // RVA: 0x8C750 Offset: 0x8BB50 VA: 0x18008C750
	// RVA: 0x5CF0A0 Offset: 0x5CE4A0 VA: 0x1805CF0A0
	public void Menu_ItemStorage(BasePlayer player) { }

	// RVA: 0x5CEFD0 Offset: 0x5CE3D0 VA: 0x1805CEFD0
	public bool Menu_ItemStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.Description] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.Icon] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.ShowIf] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	// RVA: 0x5CF0E0 Offset: 0x5CE4E0 VA: 0x1805CF0E0
	public void Menu_Push(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5CFA20 Offset: 0x5CEE20 VA: 0x1805CFA20
	private void SnowmobileUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5CDF10 Offset: 0x5CD310 VA: 0x1805CDF10
	private void EngineStartFailed(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5CEA10 Offset: 0x5CDE10 VA: 0x1805CEA10
	public float get_ThrottleInput() { }

	// RVA: 0x5D0AB0 Offset: 0x5CFEB0 VA: 0x1805D0AB0
	protected void set_ThrottleInput(float value) { }

	// RVA: 0x5CDF70 Offset: 0x5CD370 VA: 0x1805CDF70
	public float get_BrakeInput() { }

	// RVA: 0x5D09B0 Offset: 0x5CFDB0 VA: 0x1805D09B0
	protected void set_BrakeInput(float value) { }

	// RVA: 0x5D0890 Offset: 0x5CFC90 VA: 0x1805D0890
	public bool get_IsBraking() { }

	// RVA: 0x5CEA00 Offset: 0x5CDE00 VA: 0x1805CEA00
	public float get_SteerInput() { }

	// RVA: 0x5D0A30 Offset: 0x5CFE30 VA: 0x1805D0A30
	protected void set_SteerInput(float value) { }

	// RVA: 0x5D0980 Offset: 0x5CFD80 VA: 0x1805D0980 Slot: 205
	public float get_SteerAngle() { }

	// RVA: 0x5D05B0 Offset: 0x5CF9B0 VA: 0x1805D05B0 Slot: 196
	public override float get_DriveWheelVelocity() { }

	// RVA: 0x5D05A0 Offset: 0x5CF9A0 VA: 0x1805D05A0
	public float get_DriveWheelSlip() { }

	// RVA: 0x5D0960 Offset: 0x5CFD60 VA: 0x1805D0960 Slot: 206
	public float get_MaxSteerAngle() { }

	// RVA: 0x5714C0 Offset: 0x5708C0 VA: 0x1805714C0
	public bool get_InSlowMode() { }

	// RVA: 0x5D08B0 Offset: 0x5CFCB0 VA: 0x1805D08B0
	private float get_Mass() { }

	// RVA: 0x5CEC70 Offset: 0x5CE070 VA: 0x1805CEC70 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5CDF90 Offset: 0x5CD390 VA: 0x1805CDF90
	public float GetMaxDriveForce() { }

	// RVA: 0x5CE050 Offset: 0x5CD450 VA: 0x1805CE050 Slot: 197
	public override float GetMaxForwardSpeed() { }

	// RVA: 0x5CEA10 Offset: 0x5CDE10 VA: 0x1805CEA10 Slot: 198
	public override float GetThrottleInput() { }

	// RVA: 0x5CDF70 Offset: 0x5CD370 VA: 0x1805CDF70 Slot: 199
	public override float GetBrakeInput() { }

	// RVA: 0x5CEA00 Offset: 0x5CDE00 VA: 0x1805CEA00
	public float GetSteerInput() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	public bool GetSteerModInput() { }

	// RVA: 0x5CE960 Offset: 0x5CDD60 VA: 0x1805CE960
	public float GetPerformanceFraction() { }

	// RVA: 0x5CDF80 Offset: 0x5CD380 VA: 0x1805CDF80
	public float GetFuelFraction() { }

	// RVA: 0x572DD0 Offset: 0x5721D0 VA: 0x180572DD0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x5CF1D0 Offset: 0x5CE5D0 VA: 0x1805CF1D0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5D04F0 Offset: 0x5CF8F0 VA: 0x1805D04F0
	public void .ctor() { }

	// RVA: 0x5D0490 Offset: 0x5CF890 VA: 0x1805D0490
	private static void .cctor() { }

}

