public class Snowmobile : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6423
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float steerInput; 
	public float driveWheelVel; 
	public float throttleInput; 
	public float brakeInput; 
	public uint storageID; 
	public uint fuelStorageID; 
	public float fuelFraction; 


public static void ResetToPool(Snowmobile instance) { }

public void ResetToPool() { }

public virtual void Dispose() { }

public virtual void EnterPool() { }

public virtual void LeavePool() { }

public void CopyTo(Snowmobile instance) { }

public Snowmobile Copy() { }

public static Snowmobile Deserialize(Stream stream) { }

public static Snowmobile DeserializeLengthDelimited(Stream stream) { }

public static Snowmobile DeserializeLength(Stream stream, int length) { }

public static Snowmobile Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public virtual void WriteToStream(Stream stream) { }

public virtual void WriteToStreamDelta(Stream stream, Snowmobile previous) { }

public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static Snowmobile Deserialize(byte[] buffer, Snowmobile instance, bool isDelta = False) { }

public static Snowmobile Deserialize(Stream stream, Snowmobile instance, bool isDelta) { }

public static Snowmobile DeserializeLengthDelimited(Stream stream, Snowmobile instance, bool isDelta) { }

public static Snowmobile DeserializeLength(Stream stream, int length, Snowmobile instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, Snowmobile instance, Snowmobile previous) { }

public static void Serialize(Stream stream, Snowmobile instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(Snowmobile instance) { }

public static void SerializeLengthDelimited(Stream stream, Snowmobile instance) { }

public void .ctor() { }

}

public class Snowmobile : GroundVehicle, VehicleChassisVisuals.IClientWheelUser<Snowmobile>, IPrefabPreProcess // TypeDefIndex: 8451
{
	private Option __menuOption_Menu_FuelStorage; 
	private Option __menuOption_Menu_ItemStorage; 
	private Option __menuOption_Menu_Push; 
	public TimeSince timeSinceLastUpdate; 
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> treadFLData; 
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> treadFRData; 
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> treadRLData; 
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> treadRRData; 
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> skiLData; 
	public VehicleChassisVisuals.ClientWheelData<Snowmobile> skiRData; 
	private float clientSteerInput; 
	private float clientDriveWheelVelocity; 
	private float clientDriveWheelSlip; 
	private bool wasBraking; 
	private Vector3 leanVector; 
	private Vector3[] recentVels; 
	private int recentVelsIndex; 
	private TimeSince timeSinceFailedStartAttempt; 
private const float FAILED_START_MIN_TIME = 1;
	[HeaderAttribute] 
	[SerializeField] 
	private Transform centreOfMassTransform; 
	[SerializeField] 
	private GameObjectRef itemStoragePrefab; 
	[SerializeField] 
	private VisualCarWheel wheelSkiFL; 
	[SerializeField] 
	private VisualCarWheel wheelSkiFR; 
	[SerializeField] 
	private VisualCarWheel wheelTreadFL; 
	[SerializeField] 
	private VisualCarWheel wheelTreadFR; 
	[SerializeField] 
	private VisualCarWheel wheelTreadRL; 
	[SerializeField] 
	private VisualCarWheel wheelTreadRR; 
	[SerializeField] 
	private CarSettings carSettings; 
	[SerializeField] 
	private int engineKW; 
	[SerializeField] 
	private float idleFuelPerSec; 
	[SerializeField] 
	private float maxFuelPerSec; 
	[SerializeField] 
	private float airControlStability; 
	[SerializeField] 
	private float airControlPower; 
	[SerializeField] 
	private float badTerrainDrag; 
	[SerializeField] 
	private ProtectionProperties riderProtection; 
	[SerializeField] 
	private float hurtTriggerMinSpeed; 
	[SerializeField] 
	private TriggerHurtNotChild hurtTriggerFront; 
	[SerializeField] 
	private TriggerHurtNotChild hurtTriggerRear; 
	[HeaderAttribute] 
	public float minGroundFXSpeed; 
	[SerializeField] 
	private SnowmobileChassisVisuals chassisVisuals; 
	[SerializeField] 
	private VehicleLight[] lights; 
	[SerializeField] 
	private Transform steeringLeftIK; 
	[SerializeField] 
	private Transform steeringRightIK; 
	[SerializeField] 
	private Transform leftFootIK; 
	[SerializeField] 
	private Transform rightFootIK; 
	[SerializeField] 
	private Transform starterKey; 
	[SerializeField] 
	private Vector3 engineOffKeyRot; 
	[SerializeField] 
	private Vector3 engineOnKeyRot; 
	[ServerVar] 
	public static float outsideDecayMinutes; 
	[ServerVar] 
	public static bool allowPassengerOnly; 
	[ServerVar] 
	public static bool allTerrain; 
	private float _throttle; 
	private float _brake; 
	private float _steer; 
	private float _mass; 
public const BaseEntity.Flags Flag_Slowmode = 65536;
	private EntityRef<StorageContainer> itemStorageInstance; 
	private float cachedFuelFraction; 
private const float FORCE_MULTIPLIER = 10;

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


public override void GetMenuOptions(List<Option> list) { }

public override bool get_HasMenuOptions() { }

public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

protected override void ClientInit(Entity info) { }

protected override void ClientFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

public override void UpdatePlayerModel(BasePlayer player) { }

public bool IsATreadWheel(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData) { }

public bool IsASkiWheel(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData) { }

public override bool DisplayHealthInfo(BasePlayer player) { }

protected override void GroundVehicleClientTick() { }

protected override void OnClientTickStopped() { }

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
public void Menu_ItemStorage(BasePlayer player) { }

public bool Menu_ItemStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
public void Menu_Push(BasePlayer player) { }

	[BaseEntity.RPC_Client] 
private void SnowmobileUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
private void EngineStartFailed(BaseEntity.RPCMessage msg) { }

public float get_ThrottleInput() { }

protected void set_ThrottleInput(float value) { }

public float get_BrakeInput() { }

protected void set_BrakeInput(float value) { }

public bool get_IsBraking() { }

public float get_SteerInput() { }

protected void set_SteerInput(float value) { }

public float get_SteerAngle() { }

public override float get_DriveWheelVelocity() { }

public float get_DriveWheelSlip() { }

public float get_MaxSteerAngle() { }

public bool get_InSlowMode() { }

private float get_Mass() { }

public override void Load(BaseNetworkable.LoadInfo info) { }

public float GetMaxDriveForce() { }

public override float GetMaxForwardSpeed() { }

public override float GetThrottleInput() { }

public override float GetBrakeInput() { }

public float GetSteerInput() { }

public bool GetSteerModInput() { }

public float GetPerformanceFraction() { }

public float GetFuelFraction() { }

public override bool CanBeLooted(BasePlayer player) { }

public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

public void .ctor() { }

private static void .cctor() { }

}

