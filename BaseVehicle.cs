public class BaseVehicle : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6332
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<BaseVehicle.MountPoint> mountPoints; 


	public static void ResetToPool(BaseVehicle instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BaseVehicle instance) { }

	public BaseVehicle Copy() { }

	public static BaseVehicle Deserialize(Stream stream) { }

	public static BaseVehicle DeserializeLengthDelimited(Stream stream) { }

	public static BaseVehicle DeserializeLength(Stream stream, int length) { }

	public static BaseVehicle Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BaseVehicle previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BaseVehicle Deserialize(byte[] buffer, BaseVehicle instance, bool isDelta = False) { }

	public static BaseVehicle Deserialize(Stream stream, BaseVehicle instance, bool isDelta) { }

	public static BaseVehicle DeserializeLengthDelimited(Stream stream, BaseVehicle instance, bool isDelta) { }

	public static BaseVehicle DeserializeLength(Stream stream, int length, BaseVehicle instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BaseVehicle instance, BaseVehicle previous) { }

	public static void Serialize(Stream stream, BaseVehicle instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BaseVehicle instance) { }

	public static void SerializeLengthDelimited(Stream stream, BaseVehicle instance) { }

	public void .ctor() { }

}

public class BaseVehicle.MountPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6333
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int index; 
	public uint mountableId; 


	public static void ResetToPool(BaseVehicle.MountPoint instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BaseVehicle.MountPoint instance) { }

	public BaseVehicle.MountPoint Copy() { }

	public static BaseVehicle.MountPoint Deserialize(Stream stream) { }

	public static BaseVehicle.MountPoint DeserializeLengthDelimited(Stream stream) { }

	public static BaseVehicle.MountPoint DeserializeLength(Stream stream, int length) { }

	public static BaseVehicle.MountPoint Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BaseVehicle.MountPoint previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BaseVehicle.MountPoint Deserialize(byte[] buffer, BaseVehicle.MountPoint instance, bool isDelta = False) { }

	public static BaseVehicle.MountPoint Deserialize(Stream stream, BaseVehicle.MountPoint instance, bool isDelta) { }

	public static BaseVehicle.MountPoint DeserializeLengthDelimited(Stream stream, BaseVehicle.MountPoint instance, bool isDelta) { }

	public static BaseVehicle.MountPoint DeserializeLength(Stream stream, int length, BaseVehicle.MountPoint instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BaseVehicle.MountPoint instance, BaseVehicle.MountPoint previous) { }

	public static void Serialize(Stream stream, BaseVehicle.MountPoint instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BaseVehicle.MountPoint instance) { }

	public static void SerializeLengthDelimited(Stream stream, BaseVehicle.MountPoint instance) { }

	public void .ctor() { }

}

public class Motorboat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6351
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint storageid; 
	public uint fuelStorageID; 


	public static void ResetToPool(Motorboat instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Motorboat instance) { }

	public Motorboat Copy() { }

	public static Motorboat Deserialize(Stream stream) { }

	public static Motorboat DeserializeLengthDelimited(Stream stream) { }

	public static Motorboat DeserializeLength(Stream stream, int length) { }

	public static Motorboat Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Motorboat previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Motorboat Deserialize(byte[] buffer, Motorboat instance, bool isDelta = False) { }

	public static Motorboat Deserialize(Stream stream, Motorboat instance, bool isDelta) { }

	public static Motorboat DeserializeLengthDelimited(Stream stream, Motorboat instance, bool isDelta) { }

	public static Motorboat DeserializeLength(Stream stream, int length, Motorboat instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Motorboat instance, Motorboat previous) { }

	public static void Serialize(Stream stream, Motorboat instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Motorboat instance) { }

	public static void SerializeLengthDelimited(Stream stream, Motorboat instance) { }

	public void .ctor() { }

}

public class ModularVehicle : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6353
{
	public bool ShouldPool; 
	private bool _disposed; 
	public bool editable; 


	public static void ResetToPool(ModularVehicle instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ModularVehicle instance) { }

	public ModularVehicle Copy() { }

	public static ModularVehicle Deserialize(Stream stream) { }

	public static ModularVehicle DeserializeLengthDelimited(Stream stream) { }

	public static ModularVehicle DeserializeLength(Stream stream, int length) { }

	public static ModularVehicle Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ModularVehicle previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ModularVehicle Deserialize(byte[] buffer, ModularVehicle instance, bool isDelta = False) { }

	public static ModularVehicle Deserialize(Stream stream, ModularVehicle instance, bool isDelta) { }

	public static ModularVehicle DeserializeLengthDelimited(Stream stream, ModularVehicle instance, bool isDelta) { }

	public static ModularVehicle DeserializeLength(Stream stream, int length, ModularVehicle instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ModularVehicle instance, ModularVehicle previous) { }

	public static void Serialize(Stream stream, ModularVehicle instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ModularVehicle instance) { }

	public static void SerializeLengthDelimited(Stream stream, ModularVehicle instance) { }

	public void .ctor() { }

}

public class ModularCar : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6354
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float steerAngle; 
	public float driveWheelVel; 
	public float throttleInput; 
	public float brakeInput; 
	public uint fuelStorageID; 
	public float fuelFraction; 
	public int lockID; 


	public static void ResetToPool(ModularCar instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ModularCar instance) { }

	public ModularCar Copy() { }

	public static ModularCar Deserialize(Stream stream) { }

	public static ModularCar DeserializeLengthDelimited(Stream stream) { }

	public static ModularCar DeserializeLength(Stream stream, int length) { }

	public static ModularCar Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ModularCar previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ModularCar Deserialize(byte[] buffer, ModularCar instance, bool isDelta = False) { }

	public static ModularCar Deserialize(Stream stream, ModularCar instance, bool isDelta) { }

	public static ModularCar DeserializeLengthDelimited(Stream stream, ModularCar instance, bool isDelta) { }

	public static ModularCar DeserializeLength(Stream stream, int length, ModularCar instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ModularCar instance, ModularCar previous) { }

	public static void Serialize(Stream stream, ModularCar instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ModularCar instance) { }

	public static void SerializeLengthDelimited(Stream stream, ModularCar instance) { }

	public void .ctor() { }

}

public class VehicleLift : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6357
{
	public bool ShouldPool; 
	private bool _disposed; 
	public bool platformIsOccupied; 
	public bool editableOccupant; 
	public bool driveableOccupant; 
	public int occupantLockState; 
	public int occupantLockID; 


	public static void ResetToPool(VehicleLift instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(VehicleLift instance) { }

	public VehicleLift Copy() { }

	public static VehicleLift Deserialize(Stream stream) { }

	public static VehicleLift DeserializeLengthDelimited(Stream stream) { }

	public static VehicleLift DeserializeLength(Stream stream, int length) { }

	public static VehicleLift Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, VehicleLift previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static VehicleLift Deserialize(byte[] buffer, VehicleLift instance, bool isDelta = False) { }

	public static VehicleLift Deserialize(Stream stream, VehicleLift instance, bool isDelta) { }

	public static VehicleLift DeserializeLengthDelimited(Stream stream, VehicleLift instance, bool isDelta) { }

	public static VehicleLift DeserializeLength(Stream stream, int length, VehicleLift instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, VehicleLift instance, VehicleLift previous) { }

	public static void Serialize(Stream stream, VehicleLift instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(VehicleLift instance) { }

	public static void SerializeLengthDelimited(Stream stream, VehicleLift instance) { }

	public void .ctor() { }

}

public class EngineStorage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6358
{
	public bool ShouldPool; 
	private bool _disposed; 
	public bool isUsable; 
	public float accelerationBoost; 
	public float topSpeedBoost; 
	public float fuelEconomyBoost; 


	public static void ResetToPool(EngineStorage instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(EngineStorage instance) { }

	public EngineStorage Copy() { }

	public static EngineStorage Deserialize(Stream stream) { }

	public static EngineStorage DeserializeLengthDelimited(Stream stream) { }

	public static EngineStorage DeserializeLength(Stream stream, int length) { }

	public static EngineStorage Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, EngineStorage previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static EngineStorage Deserialize(byte[] buffer, EngineStorage instance, bool isDelta = False) { }

	public static EngineStorage Deserialize(Stream stream, EngineStorage instance, bool isDelta) { }

	public static EngineStorage DeserializeLengthDelimited(Stream stream, EngineStorage instance, bool isDelta) { }

	public static EngineStorage DeserializeLength(Stream stream, int length, EngineStorage instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, EngineStorage instance, EngineStorage previous) { }

	public static void Serialize(Stream stream, EngineStorage instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(EngineStorage instance) { }

	public static void SerializeLengthDelimited(Stream stream, EngineStorage instance) { }

	public void .ctor() { }

}

public class VehicleVendor : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6383
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<VehicleVendor.PlayerStorage> playerStorage; 
	public uint spawnerRef; 


	public static void ResetToPool(VehicleVendor instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(VehicleVendor instance) { }

	public VehicleVendor Copy() { }

	public static VehicleVendor Deserialize(Stream stream) { }

	public static VehicleVendor DeserializeLengthDelimited(Stream stream) { }

	public static VehicleVendor DeserializeLength(Stream stream, int length) { }

	public static VehicleVendor Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, VehicleVendor previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static VehicleVendor Deserialize(byte[] buffer, VehicleVendor instance, bool isDelta = False) { }

	public static VehicleVendor Deserialize(Stream stream, VehicleVendor instance, bool isDelta) { }

	public static VehicleVendor DeserializeLengthDelimited(Stream stream, VehicleVendor instance, bool isDelta) { }

	public static VehicleVendor DeserializeLength(Stream stream, int length, VehicleVendor instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, VehicleVendor instance, VehicleVendor previous) { }

	public static void Serialize(Stream stream, VehicleVendor instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(VehicleVendor instance) { }

	public static void SerializeLengthDelimited(Stream stream, VehicleVendor instance) { }

	public void .ctor() { }

}

public class VehicleVendor.PlayerStorage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6384
{
	public bool ShouldPool; 
	private bool _disposed; 
	public ulong userid; 
	public List<VehicleVendor.PlayerStorage.PlayerStoredVehicle> storedVehicles; 


	public static void ResetToPool(VehicleVendor.PlayerStorage instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(VehicleVendor.PlayerStorage instance) { }

	public VehicleVendor.PlayerStorage Copy() { }

	public static VehicleVendor.PlayerStorage Deserialize(Stream stream) { }

	public static VehicleVendor.PlayerStorage DeserializeLengthDelimited(Stream stream) { }

	public static VehicleVendor.PlayerStorage DeserializeLength(Stream stream, int length) { }

	public static VehicleVendor.PlayerStorage Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, VehicleVendor.PlayerStorage previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static VehicleVendor.PlayerStorage Deserialize(byte[] buffer, VehicleVendor.PlayerStorage instance, bool isDelta = False) { }

	public static VehicleVendor.PlayerStorage Deserialize(Stream stream, VehicleVendor.PlayerStorage instance, bool isDelta) { }

	public static VehicleVendor.PlayerStorage DeserializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage instance, bool isDelta) { }

	public static VehicleVendor.PlayerStorage DeserializeLength(Stream stream, int length, VehicleVendor.PlayerStorage instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, VehicleVendor.PlayerStorage instance, VehicleVendor.PlayerStorage previous) { }

	public static void Serialize(Stream stream, VehicleVendor.PlayerStorage instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(VehicleVendor.PlayerStorage instance) { }

	public static void SerializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage instance) { }

	public void .ctor() { }

}

public class VehicleVendor.PlayerStorage.PlayerStoredVehicle : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6385
{
	public bool ShouldPool; 
	private bool _disposed; 
	public string shortname; 
	public string resourcePath; 
	public float health; 


	public static void ResetToPool(VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	public VehicleVendor.PlayerStorage.PlayerStoredVehicle Copy() { }

	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(Stream stream) { }

	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLengthDelimited(Stream stream) { }

	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLength(Stream stream, int length) { }

	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(byte[] buffer, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta = False) { }

	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta) { }

	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta) { }

	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLength(Stream stream, int length, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, VehicleVendor.PlayerStorage.PlayerStoredVehicle previous) { }

	public static void Serialize(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	public static void SerializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	public void .ctor() { }

}

public class VehicleModule : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6390
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int socketIndex; 


	public static void ResetToPool(VehicleModule instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(VehicleModule instance) { }

	public VehicleModule Copy() { }

	public static VehicleModule Deserialize(Stream stream) { }

	public static VehicleModule DeserializeLengthDelimited(Stream stream) { }

	public static VehicleModule DeserializeLength(Stream stream, int length) { }

	public static VehicleModule Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, VehicleModule previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static VehicleModule Deserialize(byte[] buffer, VehicleModule instance, bool isDelta = False) { }

	public static VehicleModule Deserialize(Stream stream, VehicleModule instance, bool isDelta) { }

	public static VehicleModule DeserializeLengthDelimited(Stream stream, VehicleModule instance, bool isDelta) { }

	public static VehicleModule DeserializeLength(Stream stream, int length, VehicleModule instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, VehicleModule instance, VehicleModule previous) { }

	public static void Serialize(Stream stream, VehicleModule instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(VehicleModule instance) { }

	public static void SerializeLengthDelimited(Stream stream, VehicleModule instance) { }

	public void .ctor() { }

}

public class CamperModule : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6425
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint bbqId; 
	public uint lockerId; 
	public uint storageID; 


	public static void ResetToPool(CamperModule instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CamperModule instance) { }

	public CamperModule Copy() { }

	public static CamperModule Deserialize(Stream stream) { }

	public static CamperModule DeserializeLengthDelimited(Stream stream) { }

	public static CamperModule DeserializeLength(Stream stream, int length) { }

	public static CamperModule Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CamperModule previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CamperModule Deserialize(byte[] buffer, CamperModule instance, bool isDelta = False) { }

	public static CamperModule Deserialize(Stream stream, CamperModule instance, bool isDelta) { }

	public static CamperModule DeserializeLengthDelimited(Stream stream, CamperModule instance, bool isDelta) { }

	public static CamperModule DeserializeLength(Stream stream, int length, CamperModule instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CamperModule instance, CamperModule previous) { }

	public static void Serialize(Stream stream, CamperModule instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CamperModule instance) { }

	public static void SerializeLengthDelimited(Stream stream, CamperModule instance) { }

	public void .ctor() { }

}

public class BaseVehicle : BaseMountable // TypeDefIndex: 10058
{
	private Option __menuOption_Menu_Occupied; 
	[TooltipAttribute] 
	public bool mountChaining; 
	public BaseVehicle.ClippingCheckMode clippingChecks; 
	public bool shouldShowHudHealth; 
	public bool ignoreDamageFromOutside; 
	[HeaderAttribute] 
	public Rigidbody rigidBody; 
	[HeaderAttribute] 
	public List<BaseVehicle.MountPointInfo> mountPoints; 
	public bool doClippingAndVisChecks; 
	[HeaderAttribute] 
	public DamageRenderer damageRenderer; 
	[FormerlySerializedAsAttribute] 
	public float explosionForceMultiplier; 
	public float explosionForceMax; 
	public const BaseEntity.Flags Flag_OnlyOwnerEntry = 16;
	public const BaseEntity.Flags Flag_Headlights = 2048;
	public const BaseEntity.Flags Flag_Stationary = 32768;
	public const BaseEntity.Flags Flag_SeatsFull = 524288;
	private readonly List<BaseVehicle> childVehicles; 

	public override bool HasMenuOptions { get; }
	public bool IsMovingOrOn { get; }
	public override float RealisticMass { get; }
	public BaseVehicle.Enumerable allMountPoints { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	protected override void ClientInit(Entity info) { }

	public override void PostNetworkUpdate() { }

	public virtual void InitializeClientEffects() { }

	public virtual float GetHUDHealth() { }

	public virtual float GetHUDMaxHealth() { }

	public override bool LocalPlayerIsMounted() { }

	public virtual bool Menu_Push_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	private void Menu_Occupied(BasePlayer player) { }

	protected virtual bool Menu_Occupied_ShowIf(BasePlayer player) { }

	public override bool Menu_Mount_ShowIf(BasePlayer player) { }

	protected virtual void WorkshopMode() { }

	public bool IsStationary() { }

	public bool IsMoving() { }

	public bool get_IsMovingOrOn() { }

	public override float get_RealisticMass() { }

	public override bool PlayerIsMounted(BasePlayer player) { }

	protected virtual bool CanPushNow(BasePlayer pusher) { }

	public bool HasMountPoints() { }

	public override bool IsMounted() { }

	public override bool CanBeLooted(BasePlayer player) { }

	public bool IsFlipped() { }

	public virtual bool IsVehicleRoot() { }

	public override bool DirectlyMountable() { }

	public override BaseVehicle VehicleParent() { }

	protected override void OnChildAdded(BaseEntity child) { }

	protected override void OnChildRemoved(BaseEntity child) { }

	public BaseVehicle.Enumerable get_allMountPoints() { }

	public BaseVehicle.MountPointInfo GetMountPoint(int index) { }

	public void .ctor() { }

}

public enum BaseVehicle.ClippingCheckMode // TypeDefIndex: 10059
{
	public int value__; 
	public const BaseVehicle.ClippingCheckMode OnMountOnly = 0;
	public const BaseVehicle.ClippingCheckMode Always = 1;
	public const BaseVehicle.ClippingCheckMode AlwaysHeadOnly = 2;

}

public class BaseVehicle.MountPointInfo // TypeDefIndex: 10060
{
	public bool isDriver; 
	public Vector3 pos; 
	public Vector3 rot; 
	public string bone; 
	public GameObjectRef prefab; 


	public void .ctor() { }

}

public struct BaseVehicle.Enumerable : IEnumerable<BaseVehicle.MountPointInfo>, IEnumerable // TypeDefIndex: 10061
{
	private readonly BaseVehicle _vehicle; 


	public void .ctor(BaseVehicle vehicle) { }

	public BaseVehicle.Enumerator GetEnumerator() { }

	private IEnumerator<BaseVehicle.MountPointInfo> System.Collections.Generic.IEnumerable<BaseVehicle.MountPointInfo>.GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public struct BaseVehicle.Enumerator : IEnumerator<BaseVehicle.MountPointInfo>, IEnumerator, IDisposable // TypeDefIndex: 10062
{
	private readonly BaseVehicle _vehicle; 
	private BaseVehicle.Enumerator.State _state; 
	private int _index; 
	private int _childIndex; 
	private BaseVehicle.Enumerator.Box _enumerator; 
	[CompilerGeneratedAttribute] 
	private BaseVehicle.MountPointInfo <Current>k__BackingField; 

	public BaseVehicle.MountPointInfo Current { get; set; }
	private object System.Collections.IEnumerator.Current { get; }


	[CompilerGeneratedAttribute] 
	public BaseVehicle.MountPointInfo get_Current() { }

	[CompilerGeneratedAttribute] 
	private void set_Current(BaseVehicle.MountPointInfo value) { }

	public void .ctor(BaseVehicle vehicle) { }

	public bool MoveNext() { }

	private object System.Collections.IEnumerator.get_Current() { }

	public void Dispose() { }

	public void Reset() { }

}

private enum BaseVehicle.Enumerator.State // TypeDefIndex: 10063
{
	public int value__; 
	public const BaseVehicle.Enumerator.State Direct = 0;
	public const BaseVehicle.Enumerator.State EnterChild = 1;
	public const BaseVehicle.Enumerator.State EnumerateChild = 2;
	public const BaseVehicle.Enumerator.State Finished = 3;

}

private class BaseVehicle.Enumerator.Box : Pool.IPooled // TypeDefIndex: 10064
{
	public BaseVehicle.Enumerator Value; 


	public void EnterPool() { }

	public void LeavePool() { }

	public void .ctor() { }

}

public class BaseVehicleModule : BaseVehicle, IPrefabPreProcess // TypeDefIndex: 10065
{
	private Option __menuOption_Menu_Locked; 
	private Option __menuOption_Menu_Push; 
	private Option __menuOption_Menu_Use; 
	public const string CAR_LOCKED_ACTION_NAME = "car_locked";
	[HeaderAttribute] 
	[SerializeField] 
	private Transform centreOfMassTransform; 
	[SerializeField] 
	private float mass; 
	public BaseVehicleModule.VisualGroup visualGroup; 
	[SerializeField] 
	[HideInInspector] 
	private VehicleLight[] lights; 
	[CompilerGeneratedAttribute] 
	private BaseModularVehicle <Vehicle>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <FirstSocketIndex>k__BackingField; 
	public BaseVehicleModule.LODLevel[] lodRenderers; 
	[SerializeField] 
	[HideInInspector] 
	private List<ConditionalObject> conditionals; 
	[HeaderAttribute] 
	[SerializeField] 
	private TriggerParent[] triggerParents; 
	[HeaderAttribute] 
	[SerializeField] 
	private VehicleModuleSlidingComponent[] slidingComponents; 
	[SerializeField] 
	private VehicleModuleButtonComponent[] buttonComponents; 
	private TimeSince TimeSinceAddedToVehicle; 
	private float prevRefreshHealth; 
	private bool prevRefreshVehicleIsDead; 
	private bool prevRefreshVehicleIsLockable; 

	public override bool HasMenuOptions { get; }
	public BaseModularVehicle Vehicle { get; set; }
	public int FirstSocketIndex { get; set; }
	public Vector3 CentreOfMass { get; }
	public float Mass { get; }
	public uint ID { get; }
	public bool IsOnAVehicle { get; }
	public ItemDefinition AssociatedItemDef { get; }
	public virtual bool HasSeating { get; }
	public virtual bool HasAnEngine { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected override void ClientInit(Entity info) { }

	public virtual void ClientVehicleTick() { }

	public virtual void OnClientTickStopped() { }

	public virtual void ClientOnLoad() { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public void SetLightState(bool headlightsOn, bool brakesOn) { }

	public void ClearDecals(BaseVehicleModule.DecalType decalType) { }

	public void DrawHighlight() { }

	public override bool Menu_Mount_ShowIf(BasePlayer player) { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Push(BasePlayer player) { }

	public override bool Menu_Push_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Use(BasePlayer player) { }

	public bool Menu_Use_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Locked(BasePlayer player) { }

	public virtual bool Menu_Locked_ShowIf(BasePlayer player) { }

	[CompilerGeneratedAttribute] 
	public BaseModularVehicle get_Vehicle() { }

	[CompilerGeneratedAttribute] 
	private void set_Vehicle(BaseModularVehicle value) { }

	[CompilerGeneratedAttribute] 
	public int get_FirstSocketIndex() { }

	[CompilerGeneratedAttribute] 
	private void set_FirstSocketIndex(int value) { }

	public Vector3 get_CentreOfMass() { }

	public float get_Mass() { }

	public uint get_ID() { }

	public bool get_IsOnAVehicle() { }

	public ItemDefinition get_AssociatedItemDef() { }

	public virtual bool get_HasSeating() { }

	public virtual bool get_HasAnEngine() { }

	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void RefreshParameters() { }

	public virtual void ModuleAdded(BaseModularVehicle vehicle, int firstSocketIndex) { }

	public virtual void ModuleRemoved() { }

	public void OtherVehicleModulesChanged() { }

	public override bool CanBeLooted(BasePlayer player) { }

	public virtual void OnEngineStateChanged(VehicleEngineController.EngineState<GroundVehicle> oldState, VehicleEngineController.EngineState<GroundVehicle> newState) { }

	public override float MaxHealth() { }

	public override float StartHealth() { }

	public int GetNumSocketsTaken() { }

	public List<ConditionalObject> GetConditionals() { }

	public virtual float GetMaxDriveForce() { }

	public void RefreshConditionals(bool canGib) { }

	protected virtual void PostConditionalRefresh() { }

	private void RefreshConditional(ConditionalObject conditional, bool canGib) { }

	private bool TryGetAdjacentModuleInFront(out BaseVehicleModule result) { }

	private bool TryGetAdjacentModuleBehind(out BaseVehicleModule result) { }

	private bool InSameVisualGroupAs(BaseVehicleModule moduleEntity, ConditionalObject.AdjacentMatchType matchType) { }

	private bool CanBeUsedNowBy(BasePlayer player) { }

	public bool PlayerIsLookingAtUsable(string lookingAtColldierName, string usableColliderName) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override bool IsVehicleRoot() { }

	public void .ctor() { }

}

public enum BaseVehicleModule.DecalType // TypeDefIndex: 10066
{
	public int value__; 
	public const BaseVehicleModule.DecalType All = 0;
	public const BaseVehicleModule.DecalType Glass = 1;

}

public enum BaseVehicleModule.VisualGroup // TypeDefIndex: 10067
{
	public int value__; 
	public const BaseVehicleModule.VisualGroup None = 0;
	public const BaseVehicleModule.VisualGroup Engine = 1;
	public const BaseVehicleModule.VisualGroup Cabin = 2;
	public const BaseVehicleModule.VisualGroup Flatbed = 3;

}

public class BaseVehicleModule.LODLevel // TypeDefIndex: 10068
{
	public Renderer[] renderers; 


	public void .ctor() { }

}

public class EngineSwitch : BaseEntity // TypeDefIndex: 10096
{
	private Option __menuOption_Menu_StartEngine; 
	private Option __menuOption_Menu_StopEngine; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_StartEngine(BasePlayer player) { }

	public bool Menu_EngineOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_StopEngine(BasePlayer player) { }

	public bool Menu_EngineOff_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public class ModularCar : BaseModularVehicle, IVehicleLockUser, VehicleChassisVisuals.IClientWheelUser<ModularCar> // TypeDefIndex: 10122
{
	private Option __menuOption_Menu_FuelStorage; 
	private Option __menuOption_Menu_Locked; 
	[CompilerGeneratedAttribute] 
	private VehicleChassisVisuals.ClientWheelData<ModularCar> <WheelDataFL>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private VehicleChassisVisuals.ClientWheelData<ModularCar> <WheelDataFR>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private VehicleChassisVisuals.ClientWheelData<ModularCar> <WheelDataRL>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private VehicleChassisVisuals.ClientWheelData<ModularCar> <WheelDataRR>k__BackingField; 
	public TimeSince timeSinceLastUpdate; 
	public TimeSince timeSinceFailedStartAttempt; 
	private float clientSteerAngle; 
	private float clientDriveWheelVelocity; 
	private float clientDriveWheelSlip; 
	private float clientThrottle; 
	private float clientBrake; 
	private bool cachedEngineLowPerf; 
	private TimeSince timeSinceEnginePerfCheck; 
	private bool failedStartWasEngineProblem; 
	private bool wasBraking; 
	private const float FAILED_START_LIGHT_TIME = 1;
	private static int detailColorID; 
	[HeaderAttribute] 
	public ModularCarChassisVisuals chassisVisuals; 
	public VisualCarWheel wheelFL; 
	public VisualCarWheel wheelFR; 
	public VisualCarWheel wheelRL; 
	public VisualCarWheel wheelRR; 
	public ItemDefinition carKeyDefinition; 
	[SerializeField] 
	private CarSettings carSettings; 
	[SerializeField] 
	private float hurtTriggerMinSpeed; 
	[SerializeField] 
	private TriggerHurtNotChild hurtTriggerFront; 
	[SerializeField] 
	private TriggerHurtNotChild hurtTriggerRear; 
	[SerializeField] 
	private ProtectionProperties immortalProtection; 
	[SerializeField] 
	private ProtectionProperties mortalProtection; 
	[SerializeField] 
	private BoxCollider mainChassisCollider; 
	[SerializeField] 
	private ModularCar.SpawnSettings spawnSettings; 
	[SerializeField] 
	[HideInInspector] 
	private MeshRenderer[] damageShowingRenderers; 
	[ServerVar] 
	public static float population; 
	[ServerVar] 
	public static float outsidedecayminutes; 
	public const BUTTON RapidSteerButton = 128;
	public ModularCarLock carLock; 
	private VehicleEngineController.EngineState<GroundVehicle> lastSetEngineState; 
	private float cachedFuelFraction; 

	public override bool HasMenuOptions { get; }
	public VehicleChassisVisuals.ClientWheelData<ModularCar> WheelDataFL { get; set; }
	public VehicleChassisVisuals.ClientWheelData<ModularCar> WheelDataFR { get; set; }
	public VehicleChassisVisuals.ClientWheelData<ModularCar> WheelDataRL { get; set; }
	public VehicleChassisVisuals.ClientWheelData<ModularCar> WheelDataRR { get; set; }
	public override float DriveWheelVelocity { get; }
	public float DriveWheelSlip { get; }
	public float SteerAngle { get; }
	public ItemDefinition AssociatedItemDef { get; }
	public float MaxSteerAngle { get; }
	public override bool IsLockable { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] 
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataFL() { }

	[CompilerGeneratedAttribute] 
	private void set_WheelDataFL(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] 
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataFR() { }

	[CompilerGeneratedAttribute] 
	private void set_WheelDataFR(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] 
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataRL() { }

	[CompilerGeneratedAttribute] 
	private void set_WheelDataRL(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] 
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataRR() { }

	[CompilerGeneratedAttribute] 
	private void set_WheelDataRR(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	protected override void ClientInit(Entity info) { }

	protected override void OnLifeStateChanged() { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public bool HasAnEngineAtLowPerformance() { }

	public bool HasLowFuel() { }

	public bool HadRecentFailedEngineStart() { }

	protected override void SpawnGibs() { }

	protected override void GroundVehicleClientTick() { }

	protected override void OnClientTickStopped() { }

	protected override bool IsBraking() { }

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
	public void Menu_Locked(BasePlayer player) { }

	public bool Menu_Locked_ShowIf(BasePlayer player) { }

	public override bool MountMenuVisible(BasePlayer player) { }

	public override float GetHUDHealth() { }

	public override float GetHUDMaxHealth() { }

	[BaseEntity.RPC_Client] 
	private void ModularCarUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void EngineStartFailed(BaseEntity.RPCMessage msg) { }

	public override float get_DriveWheelVelocity() { }

	public float get_DriveWheelSlip() { }

	public float get_SteerAngle() { }

	public ItemDefinition get_AssociatedItemDef() { }

	public float get_MaxSteerAngle() { }

	public override bool get_IsLockable() { }

	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public override void InitShared() { }

	public override float MaxHealth() { }

	public override float StartHealth() { }

	public float TotalHealth() { }

	public float TotalMaxHealth() { }

	public override float GetMaxForwardSpeed() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public override float GetThrottleInput() { }

	public override float GetBrakeInput() { }

	public float GetMaxDriveForce() { }

	public float GetFuelFraction() { }

	public bool PlayerHasUnlockPermission(BasePlayer player) { }

	public override bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType) { }

	public bool PlayerCanDestroyLock(BasePlayer player, BaseVehicleModule viaModule) { }

	public override bool CanBeLooted(BasePlayer player) { }

	protected override bool CanPushNow(BasePlayer pusher) { }

	protected bool RefreshEngineState() { }

	private float RollOffDriveForce(float driveForce) { }

	private void RefreshChassisProtectionState() { }

	protected override void ModuleEntityAdded(BaseVehicleModule addedModule) { }

	protected override void ModuleEntityRemoved(BaseVehicleModule removedModule) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class ModularCar.SpawnSettings // TypeDefIndex: 10123
{
	[TooltipAttribute] 
	public bool useSpawnSettings; 
	[TooltipAttribute] 
	public ModularCarPresetConfig[] configurationOptions; 
	[TooltipAttribute] 
	public float minStartHealthPercent; 
	[TooltipAttribute] 
	public float maxStartHealthPercent; 
	public ModularCar.SpawnSettings.AdminBonus adminBonus; 


	public void .ctor() { }

}

public enum ModularCar.SpawnSettings.AdminBonus // TypeDefIndex: 10124
{
	public int value__; 
	public const ModularCar.SpawnSettings.AdminBonus None = 0;
	public const ModularCar.SpawnSettings.AdminBonus T1PlusFuel = 1;
	public const ModularCar.SpawnSettings.AdminBonus T2PlusFuel = 2;
	public const ModularCar.SpawnSettings.AdminBonus T3PlusFuel = 3;

}

public class ModularCarGarage : ContainerIOEntity // TypeDefIndex: 10125
{
	private Option __menuOption_Menu_EditVehicle; 
	private Option __menuOption_Menu_InsufficientPower; 
	private TimeSince lastChassisDestroyTime; 
	[SerializeField] 
	private Transform vehicleLift; 
	[SerializeField] 
	private Animation vehicleLiftAnim; 
	[SerializeField] 
	private string animName; 
	[SerializeField] 
	private VehicleLiftOccupantTrigger occupantTrigger; 
	[SerializeField] 
	private float liftMoveTime; 
	[SerializeField] 
	private EmissionToggle poweredLight; 
	[SerializeField] 
	private EmissionToggle inUseLight; 
	[SerializeField] 
	private Transform vehicleLiftPos; 
	[SerializeField] 
	[RangeAttribute] 
	private float recycleEfficiency; 
	[SerializeField] 
	private Transform recycleDropPos; 
	[SerializeField] 
	private bool needsElectricity; 
	[SerializeField] 
	private SoundDefinition liftStartSoundDef; 
	[SerializeField] 
	private SoundDefinition liftStopSoundDef; 
	[SerializeField] 
	private SoundDefinition liftStopDownSoundDef; 
	[SerializeField] 
	private SoundDefinition liftLoopSoundDef; 
	public ModularCarGarage.ChassisBuildOption[] chassisBuildOptions; 
	public ItemAmount lockResourceCost; 
	public ItemDefinition carKeyDefinition; 
	[CompilerGeneratedAttribute] 
	private bool <PlatformIsOccupied>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <HasEditableOccupant>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <HasDriveableOccupant>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ModularCarGarage.OccupantLock <OccupantLockState>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <OccupantLockID>k__BackingField; 
	private ModularCarGarage.VehicleLiftState vehicleLiftState; 
	private Sound liftLoopSound; 
	private Vector3 downPos; 
	public const BaseEntity.Flags DestroyingChassis = 16384;
	public const float TimeToDestroyChassis = 10;

	public override bool HasMenuOptions { get; }
	public float TimeLeftToCancelChassisDestroy { get; }
	public bool PlatformIsOccupied { get; set; }
	public bool HasEditableOccupant { get; set; }
	public bool HasDriveableOccupant { get; set; }
	public ModularCarGarage.OccupantLock OccupantLockState { get; set; }
	public int OccupantLockID { get; set; }
	private bool LiftIsUp { get; }
	private bool LiftIsMoving { get; }
	private bool LiftIsDown { get; }
	public bool IsDestroyingChassis { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected override void ClientInit(Entity info) { }

	public void TryRepair(uint itemUID) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void ClientSelectedLootItem(Item item) { }

	private bool PlayerHasInternalModuleLoot() { }

	public void ClientRequestAddLock() { }

	public void ClientRequestRemoveLock() { }

	public void ClientRequestNewKey() { }

	private void RefreshPoweredLightState() { }

	private void RefreshInUseLightState() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_EditVehicle(BasePlayer player) { }

	public bool Menu_EditVehicle_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_InsufficientPower(BasePlayer player) { }

	public bool Menu_InsufficientPower_ShowIf(BasePlayer player) { }

	public void StartChassisDestroy() { }

	public void CancelChassisDestroy() { }

	public float get_TimeLeftToCancelChassisDestroy() { }

	[CompilerGeneratedAttribute] 
	public bool get_PlatformIsOccupied() { }

	[CompilerGeneratedAttribute] 
	private void set_PlatformIsOccupied(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_HasEditableOccupant() { }

	[CompilerGeneratedAttribute] 
	private void set_HasEditableOccupant(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_HasDriveableOccupant() { }

	[CompilerGeneratedAttribute] 
	private void set_HasDriveableOccupant(bool value) { }

	[CompilerGeneratedAttribute] 
	public ModularCarGarage.OccupantLock get_OccupantLockState() { }

	[CompilerGeneratedAttribute] 
	private void set_OccupantLockState(ModularCarGarage.OccupantLock value) { }

	[CompilerGeneratedAttribute] 
	public int get_OccupantLockID() { }

	[CompilerGeneratedAttribute] 
	private void set_OccupantLockID(int value) { }

	private bool get_LiftIsUp() { }

	private bool get_LiftIsMoving() { }

	private bool get_LiftIsDown() { }

	public bool get_IsDestroyingChassis() { }

	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public override bool CanBeLooted(BasePlayer player) { }

	public override int ConsumptionAmount() { }

	private void SetOccupantState(bool hasOccupant, bool editableOccupant, bool driveableOccupant, ModularCarGarage.OccupantLock occupantLockState, int occupantLockID, bool forced = False) { }

	private void RefreshLiftState(bool forced = False) { }

	private void MoveLift(ModularCarGarage.VehicleLiftState desiredLiftState, float startDelay = 0, bool forced = False) { }

	private void MoveLiftUp() { }

	private void MoveLiftDown() { }

	private void StartLiftSounds() { }

	private void UpdateLiftSounds() { }

	public void .ctor() { }

}

public class ModularCarGarage.ChassisBuildOption // TypeDefIndex: 10126
{
	public GameObjectRef prefab; 
	public ItemDefinition itemDef; 


	public void .ctor() { }

}

public enum ModularCarGarage.OccupantLock // TypeDefIndex: 10127
{
	public int value__; 
	public const ModularCarGarage.OccupantLock CannotHaveLock = 0;
	public const ModularCarGarage.OccupantLock NoLock = 1;
	public const ModularCarGarage.OccupantLock HasLock = 2;

}

private enum ModularCarGarage.VehicleLiftState // TypeDefIndex: 10128
{
	public int value__; 
	public const ModularCarGarage.VehicleLiftState Down = 0;
	public const ModularCarGarage.VehicleLiftState Up = 1;

}

public class MotorRowboat : BaseBoat // TypeDefIndex: 10129
{
	private Option __menuOption_Menu_FuelStorage; 
	private Option __menuOption_Menu_StartEngine; 
	private Option __menuOption_Menu_StopEngine; 
	[HeaderAttribute] 
	public BlendedSoundLoops engineLoops; 
	public BlendedSoundLoops waterLoops; 
	public SoundDefinition engineStartSoundDef; 
	public SoundDefinition engineStopSoundDef; 
	public SoundDefinition movementSplashAccentSoundDef; 
	public SoundDefinition engineSteerSoundDef; 
	public GameObjectRef pushLandEffect; 
	public GameObjectRef pushWaterEffect; 
	public float waterSpeedDivisor; 
	public float turnPitchModScale; 
	public float tiltPitchModScale; 
	public float splashAccentFrequencyMin; 
	public float splashAccentFrequencyMax; 
	private float directionalPitchModScale; 
	private float vol; 
	private float pitch; 
	private float speed; 
	private bool wasEngineOn; 
	private float nextSplashAccent; 
	private int prevSteering; 
	protected const BaseEntity.Flags Flag_EngineOn = 128;
	protected const BaseEntity.Flags Flag_ThrottleOn = 256;
	protected const BaseEntity.Flags Flag_TurnLeft = 512;
	protected const BaseEntity.Flags Flag_TurnRight = 1024;
	protected const BaseEntity.Flags Flag_Submerged = 2048;
	protected const BaseEntity.Flags Flag_HasFuel = 16384;
	protected const BaseEntity.Flags Flag_RecentlyPushed = 65536;
	private const float submergeFractionMinimum = 0,85;
	[HeaderAttribute] 
	public GameObjectRef fuelStoragePrefab; 
	public float fuelPerSec; 
	[HeaderAttribute] 
	public GameObjectRef storageUnitPrefab; 
	public EntityRef<StorageContainer> storageUnitInstance; 
	[HeaderAttribute] 
	public Transform boatRear; 
	public ParticleSystemContainer wakeEffect; 
	public ParticleSystemContainer engineEffectIdle; 
	public ParticleSystemContainer engineEffectThrottle; 
	public Projector causticsProjector; 
	public Transform causticsDepthTest; 
	public Transform engineLeftHandPosition; 
	public Transform engineRotate; 
	public Transform propellerRotate; 
	[ServerVar] 
	public static float population; 
	[ServerVar] 
	public static float outsidedecayminutes; 
	[ServerVar] 
	public static float deepwaterdecayminutes; 
	protected EntityFuelSystem fuelSystem; 
	public Transform[] stationaryDismounts; 
	public Collider mainCollider; 
	public float angularDragBase; 
	public float angularDragVelocity; 
	public float landDrag; 
	public float waterDrag; 
	public float offAxisDrag; 
	public float offAxisDot; 
	private AverageVelocity averageVelocity; 
	private bool wasWakeOn; 
	private bool wasEngineSprayOn; 
	private bool wasEngineIdleOn; 
	private Material causticsMaterial; 
	private Color causticsColor; 
	private float causticsAlpha; 
	protected float currentEngineRotation; 
	protected float propellerRotationSpeed; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void UpdateSounds() { }

	public override void InitShared() { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public void Update() { }

	public void UpdateWake() { }

	public void UpdateEffects() { }

	public override void InitializeClientEffects() { }

	public virtual void ShutdownClientEffects() { }

	public virtual void UpdateEngineRotation() { }

	public override void SetNetworkPosition(Vector3 vPos) { }

	public override bool MountMenuVisible(BasePlayer player) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public virtual bool LookingAtEngine(BasePlayer player) { }

	public virtual bool LookingAtFuelArea(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_StartEngine(BasePlayer player) { }

	public bool Menu_StartEngine_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_StopEngine(BasePlayer player) { }

	public bool Menu_StopEngine_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_FuelStorage(BasePlayer player) { }

	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	protected override bool CanPushNow(BasePlayer pusher) { }

	private bool ShowPushMenu(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected override void WorkshopMode() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class VehicleModuleCamper : VehicleModuleSeating // TypeDefIndex: 10184
{
	private Option __menuOption_Menu_AssignToFriend; 
	private Option __menuOption_Menu_ClearBedOwner; 
	private Option __menuOption_Menu_MakeBed; 
	private Option __menuOption_Menu_OpenLocker; 
	private Option __menuOption_Menu_OpenStorage; 
	private Option __menuOption_Menu_Rename; 
	public GameObjectRef SleepingBagEntity; 
	public Transform[] SleepingBagPoints; 
	public GameObjectRef LockerEntity; 
	public Transform LockerPoint; 
	public GameObjectRef BbqEntity; 
	public Transform BbqPoint; 
	public GameObjectRef StorageEntity; 
	public Transform StoragePoint; 
	private EntityRef<BaseOven> activeBbq; 
	private EntityRef<Locker> activeLocker; 
	private EntityRef<StorageContainer> activeStorage; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool CanBeLooted(BasePlayer player) { }

	public override bool IsOnThisModule(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_MakeBed(BasePlayer player) { }

	public virtual bool Menu_MakeBed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_ClearBedOwner(BasePlayer player) { }

	public virtual bool Menu_ClearBedOwner_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_AssignToFriend(BasePlayer player) { }

	public virtual bool Menu_AssignToFriend_Test(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Rename(BasePlayer player) { }

	protected virtual bool CanRename_Test(BasePlayer player) { }

	private SleepingBagCamper GetSleepingBagForPlayer(BasePlayer p) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_OpenLocker(BasePlayer player) { }

	public bool Menu_OpenLocker_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_OpenStorage(BasePlayer player) { }

	public bool Menu_OpenStorage_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public class VehicleModuleSeating : BaseVehicleModule, IPrefabPreProcess // TypeDefIndex: 10185
{
	private Option __menuOption_Menu_DestroyLock; 
	[SerializeField] 
	private ProtectionProperties passengerProtection; 
	[SerializeField] 
	private VehicleModuleSeating.Seating seating; 
	[SerializeField] 
	[HideInInspector] 
	private Vector3 steerAngle; 
	[SerializeField] 
	[HideInInspector] 
	private Vector3 accelAngle; 
	[SerializeField] 
	[HideInInspector] 
	private Vector3 brakeAngle; 
	[SerializeField] 
	[HideInInspector] 
	private Vector3 speedometerAngle; 
	[SerializeField] 
	[HideInInspector] 
	private Vector3 fuelAngle; 
	[HeaderAttribute] 
	[SerializeField] 
	private SoundDefinition hornLoop; 
	[SerializeField] 
	private SoundDefinition hornStart; 
	private Sound activeHorn; 
	private const BaseEntity.Flags FLAG_HORN = 65536;
	private float steerPercent; 
	private float throttlePercent; 
	private float brakePercent; 
	private Nullable<bool> checkEngineLightOn; 
	private Nullable<bool> fuelLightOn; 
	[CompilerGeneratedAttribute] 
	private ModularCar <Car>k__BackingField; 
	protected IVehicleLockUser VehicleLockUser; 
	private MaterialPropertyBlock dashboardLightPB; 
	private static int emissionColorID; 

	public override bool HasMenuOptions { get; }
	public override bool HasSeating { get; }
	protected ModularCar Car { get; set; }
	protected bool IsOnACar { get; }
	protected bool IsOnAVehicleLockUser { get; }
	public bool DoorsAreLockable { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool get_HasSeating() { }

	[CompilerGeneratedAttribute] 
	protected ModularCar get_Car() { }

	[CompilerGeneratedAttribute] 
	private void set_Car(ModularCar value) { }

	protected bool get_IsOnACar() { }

	protected bool get_IsOnAVehicleLockUser() { }

	public bool get_DoorsAreLockable() { }

	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public override void ClientVehicleTick() { }

	public override void OnClientTickStopped() { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	private void SetCheckEngineLightState(bool isOn) { }

	private void SetFuelLightState(bool isOn) { }

	private void SetLightState(bool isOn, int lightMatIndex, Color lightEmission) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public bool ValidMountRay(BasePlayer player) { }

	public override bool Menu_Locked_ShowIf(BasePlayer player) { }

	private bool LookingAtAMountHotSpot(BasePlayer localPlayer) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_DestroyLock(BasePlayer player) { }

	public bool Menu_DestroyLock_ShowIf(BasePlayer player) { }

	public virtual bool IsOnThisModule(BasePlayer player) { }

	public bool HasADriverSeat() { }

	public override void ModuleAdded(BaseModularVehicle vehicle, int firstSocketIndex) { }

	public override void ModuleRemoved() { }

	public bool PlayerCanDestroyLock(BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class VehicleModuleSeating.MountHotSpot // TypeDefIndex: 10186
{
	public Transform transform; 
	public Vector2 size; 


	public void .ctor() { }

}

public class VehicleModuleSeating.Seating // TypeDefIndex: 10187
{
	[HeaderAttribute] 
	public bool doorsAreLockable; 
	[ObsoleteAttribute] 
	[HideInInspector] 
	public BaseVehicle.MountPointInfo[] mountPoints; 
	public Transform steeringWheel; 
	public Transform accelPedal; 
	public Transform brakePedal; 
	public Transform steeringWheelLeftGrip; 
	public Transform steeringWheelRightGrip; 
	public Transform accelPedalGrip; 
	public Transform brakePedalGrip; 
	public VehicleModuleSeating.MountHotSpot[] mountHotSpots; 
	[HeaderAttribute] 
	public Transform speedometer; 
	public Transform fuelGauge; 
	public Renderer dashboardRenderer; 
	[RangeAttribute] 
	public int checkEngineLightMatIndex; 
	[ColorUsageAttribute] 
	public Color checkEngineLightEmission; 
	[RangeAttribute] 
	public int fuelLightMatIndex; 
	[ColorUsageAttribute] 
	public Color fuelLightEmission; 


	public void .ctor() { }

}

public class VehicleModuleStorage : VehicleModuleSeating // TypeDefIndex: 10188
{
	private Option __menuOption_Menu_Open; 
	[SerializeField] 
	private VehicleModuleStorage.Storage storage; 
	private EntityRef storageUnitInstance; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public IItemContainerEntity GetContainer() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Open(BasePlayer player) { }

	public bool Menu_Open_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public class VehicleModuleStorage.Storage // TypeDefIndex: 10189
{
	public GameObjectRef storageUnitPrefab; 
	public Transform storageUnitPoint; 


	public void .ctor() { }

}

public class VehicleModuleTaxi : VehicleModuleStorage // TypeDefIndex: 10190
{
	private Option __menuOption_Menu_Kick_Passengers; 
	[HeaderAttribute] 
	[SerializeField] 
	private SoundDefinition kickButtonSound; 
	[SerializeField] 
	private SphereCollider kickButtonCollider; 
	[SerializeField] 
	private float maxKickVelocity; 

	public override bool HasMenuOptions { get; }
	private Vector3 KickButtonPos { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private Vector3 get_KickButtonPos() { }

	private bool CanKickPassengers(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Kick_Passengers(BasePlayer player) { }

	public bool Menu_Kick_Passengers_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public class ModularCarOven : BaseOven // TypeDefIndex: 10317
{
	private BaseVehicleModule moduleParent; 

	private BaseVehicleModule ModuleParent { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private BaseVehicleModule get_ModuleParent() { }

	public override void ResetState() { }

	protected override bool SwitchOff_ShowIf(BasePlayer player) { }

	protected override bool SwitchOn_ShowIf(BasePlayer player) { }

	protected override bool Menu_Open_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public class VehicleVendor : NPCTalking // TypeDefIndex: 10567
{
	public EntityRef spawnerRef; 
	public VehicleSpawner vehicleSpawner; 


	public override string GetConversationStartSpeech(BasePlayer player) { }

	public VehicleSpawner GetVehicleSpawner() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override ConversationData GetConversationFor(BasePlayer player) { }

	public void .ctor() { }

}

public class VehicleSpawner : BaseEntity // TypeDefIndex: 10568
{
	public float spawnNudgeRadius; 
	public float cleanupRadius; 
	public float occupyRadius; 
	public VehicleSpawner.SpawnPair[] objectsToSpawn; 
	public Transform spawnOffset; 
	public float safeRadius; 


	public virtual int GetOccupyLayer() { }

	public BaseVehicle GetVehicleOccupying() { }

	public void .ctor() { }

}

public class VehicleSpawner.SpawnPair // TypeDefIndex: 10569
{
	public string message; 
	public GameObjectRef prefabToSpawn; 


	public void .ctor() { }

}

public class EngineAudioClip : MonoBehaviour, IClientComponent // TypeDefIndex: 10703
{
	public AudioClip granularClip; 
	public AudioClip accelerationClip; 
	public TextAsset accelerationCyclesJson; 
	public List<EngineAudioClip.EngineCycle> accelerationCycles; 
	public List<EngineAudioClip.EngineCycleBucket> cycleBuckets; 
	public Dictionary<int, EngineAudioClip.EngineCycleBucket> accelerationCyclesByRPM; 
	public Dictionary<int, int> rpmBucketLookup; 
	public int sampleRate; 
	public int samplesUntilNextGrain; 
	public int lastCycleId; 
	public List<EngineAudioClip.Grain> grains; 
	public int currentRPM; 
	public int targetRPM; 
	public int minRPM; 
	public int maxRPM; 
	public int cyclePadding; 
	[RangeAttribute] 
	public float RPMControl; 
	public AudioSource source; 
	public float rpmLerpSpeed; 
	public float rpmLerpSpeedDown; 
	private Random random; 
	private float[] accelerationAudioData; 
	private EngineAudioClip.EngineCycle currentCycle; 
	private bool audioDataLoaded; 


	private int GetBucketRPM(int RPM) { }

	private void Awake() { }

	private void Update() { }

	private void UpdateRPM() { }

	private void InitAudioClip() { }

	private void OnAudioRead(float[] data) { }

	private void SpawnGrain() { }

	private void CleanupFinishedGrains() { }

	private void SetupRPMBuckets() { }

	public void .ctor() { }

}

public class EngineAudioClip.EngineCycle // TypeDefIndex: 10704
{
	public int RPM; 
	public int startSample; 
	public int endSample; 
	public float period; 
	public int id; 


	public void .ctor(int RPM, int startSample, int endSample, float period, int id) { }

}

public class EngineAudioClip.EngineCycleBucket // TypeDefIndex: 10705
{
	public int RPM; 
	public List<EngineAudioClip.EngineCycle> cycles; 
	public List<int> remainingCycles; 


	public void .ctor(int RPM) { }

	public EngineAudioClip.EngineCycle GetCycle(Random random, int lastCycleId) { }

	private void ResetRemainingCycles(Random random) { }

	public void Add(EngineAudioClip.EngineCycle cycle) { }

}

public class EngineAudioClip.Grain // TypeDefIndex: 10706
{
	private float[] sourceData; 
	private int startSample; 
	private int currentSample; 
	private int attackTimeSamples; 
	private int sustainTimeSamples; 
	private int releaseTimeSamples; 
	private float gain; 
	private float gainPerSampleAttack; 
	private float gainPerSampleRelease; 
	private int attackEndSample; 
	private int releaseStartSample; 
	private int endSample; 

	public bool finished { get; }


	public bool get_finished() { }

	public void Init(float[] source, EngineAudioClip.EngineCycle cycle, int cyclePadding) { }

	public float GetSample() { }

	public void .ctor() { }

}

public class BaseVehicleMountPoint : BaseMountable // TypeDefIndex: 11418
{

	public override bool DirectlyMountable() { }

	public override BaseVehicle VehicleParent() { }

	public override bool BlocksWaterFor(BasePlayer player) { }

	public override float WaterFactorForPlayer(BasePlayer player) { }

	public override float AirFactor() { }

	public void .ctor() { }

}

public class BaseVehicleSeat : BaseVehicleMountPoint // TypeDefIndex: 11419
{
	public float mountedAnimationSpeed; 
	public bool sendClientInputToVehicleParent; 
	public bool forcePlayerModelUpdate; 


	public override void OnClientInput(BasePlayer player) { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public override float GetMountedAnimationSpeed() { }

	public override bool ForceUpdatePlayerModel(BasePlayer p) { }

	public void .ctor() { }

}

public class EngineAudioSet : ScriptableObject // TypeDefIndex: 11456
{
	public BlendedEngineLoopDefinition[] engineAudioLoops; 
	public int priority; 
	public float idleVolume; 
	public float maxVolume; 
	public float volumeChangeRateUp; 
	public float volumeChangeRateDown; 
	public float idlePitch; 
	public float maxPitch; 
	public float idleRpm; 
	public float gearUpRpm; 
	public float gearDownRpm; 
	public int numGears; 
	public float maxRpm; 
	public float gearUpRpmRate; 
	public float gearDownRpmRate; 
	public SoundDefinition badPerformanceLoop; 


	public BlendedEngineLoopDefinition GetEngineLoopDef(int numEngines) { }

	public void .ctor() { }

}

public class ModularCarCentralLockingSwitch : VehicleModuleButtonComponent // TypeDefIndex: 11459
{
	public Transform centralLockingSwitch; 
	public Vector3 switchOffPos; 
	public Vector3 switchOnPos; 


	public override void ClientUse(BasePlayer player, BaseVehicleModule parentModule) { }

	public override void ClientUpdateTick(BaseVehicleModule parentModule) { }

	public void .ctor() { }

}

public class ModularCarChassisVisuals : VehicleChassisVisuals<ModularCar>, IClientComponent // TypeDefIndex: 11460
{
	public Transform frontAxle; 
	public Transform rearAxle; 
	public ModularCarChassisVisuals.Steering steering; 
	public ModularCarChassisVisuals.LookAtTarget transmission; 
	private ModularCar modularCar; 


	public override void Init(ModularCar owner, VehicleChassisVisuals.ClientWheelData<ModularCar>[] clientWheelData) { }

	protected override void PreWheelUpdateTick() { }

	protected override void PostWheelUpdateTick(bool instant, bool isCloseToCamera, float steer, float dt) { }

	protected override void UpdateWheelVisuals(VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData, bool isOn, float steer, float dt) { }

	private void UpdateAxle(Transform axle, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataL, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataR, float dt, bool instant) { }

	private void LookAt(ModularCarChassisVisuals.LookAtTarget lookAt) { }

	public void .ctor() { }

}

public class ModularCarChassisVisuals.Steering // TypeDefIndex: 11461
{
	public Transform steerL; 
	public Transform steerR; 
	public ModularCarChassisVisuals.LookAtTarget steerRodL; 
	public ModularCarChassisVisuals.LookAtTarget steerRodR; 
	public ModularCarChassisVisuals.LookAtTarget steeringArm; 


	public void .ctor() { }

}

public class ModularCarChassisVisuals.LookAtTarget // TypeDefIndex: 11462
{
	public Transform aim; 
	public Transform target; 
	public Vector3 angleAdjust; 


	public void .ctor() { }

}

public class VehicleLiftOccupantTrigger : TriggerBase // TypeDefIndex: 11463
{

	public void .ctor() { }

}

public class ModularCarLock // TypeDefIndex: 11465
{
	private readonly bool isServer; 
	private readonly ModularCar owner; 
	public int LockID; 
	public const BaseEntity.Flags FLAG_CENTRAL_LOCKING = 256;
	public const float LOCK_DESTROY_HEALTH = 0,15;

	public bool HasALock { get; }
	public bool IsLocked { get; }
	public bool CentralLockingIsOn { get; }


	public bool get_HasALock() { }

	public bool get_IsLocked() { }

	public bool get_CentralLockingIsOn() { }

	public void .ctor(ModularCar owner, bool isServer) { }

	public bool PlayerHasUnlockPermission(BasePlayer player) { }

	public bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType) { }

	public bool PlayerCanDestroyLock(BaseVehicleModule viaModule) { }

	private bool KeyCanUnlockThis(Item key) { }

	[CompilerGeneratedAttribute] 
	private bool <PlayerHasUnlockPermission>b__13_0(Item key) { }

}

public enum ModularCarLock.LockType // TypeDefIndex: 11466
{
	public int value__; 
	public const ModularCarLock.LockType Door = 0;
	public const ModularCarLock.LockType General = 1;

}

public class ModularCarPresetConfig : ScriptableObject // TypeDefIndex: 11467
{
	public ItemModVehicleModule[] socketItemDefs; 


	public void .ctor() { }

}

public class ModularCarSeat : MouseSteerableSeat // TypeDefIndex: 11468
{
	[SerializeField] 
	private Vector3 leftFootIKPos; 
	[SerializeField] 
	private Vector3 rightFootIKPos; 
	[SerializeField] 
	private Vector3 leftHandIKPos; 
	[SerializeField] 
	private Vector3 rightHandIKPos; 
	public float providesComfort; 

	public bool HasLeftFootIK { get; }
	public bool HasRightFootIK { get; }
	public Vector3 LeftFootIKPos { get; }
	public Vector3 RightFootIKPos { get; }
	public bool HasLeftHandIK { get; }
	public bool HasRightHandIK { get; }
	public Vector3 LeftHandIKPos { get; }
	public Vector3 RightHandIKPos { get; }


	public bool get_HasLeftFootIK() { }

	public bool get_HasRightFootIK() { }

	public Vector3 get_LeftFootIKPos() { }

	public Vector3 get_RightFootIKPos() { }

	public bool get_HasLeftHandIK() { }

	public bool get_HasRightHandIK() { }

	public Vector3 get_LeftHandIKPos() { }

	public Vector3 get_RightHandIKPos() { }

	public void .ctor() { }

}

public class ModularVehicleShopFront : ShopFront // TypeDefIndex: 11469
{
	[SerializeField] 
	private float maxUseDistance; 


	public override bool CanBeLooted(BasePlayer player) { }

	public override bool ShouldShowLootMenus() { }

	private bool WithinUseDistance(BasePlayer player) { }

	public void .ctor() { }

}

public class CamperSeatConfig : MonoBehaviour // TypeDefIndex: 11470
{
	public Transform[] SeatPositions; 
	public Transform StovePosition; 
	public Transform StoragePosition; 


	public void .ctor() { }

}

public abstract class VehicleModuleButtonComponent : MonoBehaviour // TypeDefIndex: 11471
{
	public string interactionColliderName; 
	public SoundDefinition pressSoundDef; 


	public virtual void ClientUse(BasePlayer player, BaseVehicleModule parentModule) { }

	public virtual void ClientUpdateTick(BaseVehicleModule parentModule) { }

	protected void .ctor() { }

}

public class VehicleModuleEngine : VehicleModuleStorage // TypeDefIndex: 11472
{
	[SerializeField] 
	private VehicleModuleEngine.Engine engine; 
	[CompilerGeneratedAttribute] 
	private bool <IsUsable>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <PerformanceFractionAcceleration>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <PerformanceFractionTopSpeed>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <PerformanceFractionFuelEconomy>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <OverallPerformanceFraction>k__BackingField; 
	private const float FORCE_MULTIPLIER = 12,75;
	private const float HEALTH_PERFORMANCE_FRACTION = 0,25;
	private const float LOW_PERFORMANCE_THRESHOLD = 0,5;
	private Sound badPerformanceLoop; 
	private SoundModulation.Modulator badPerformancePitchModulator; 
	private float prevSmokePercent; 

	public override bool HasAnEngine { get; }
	public bool IsUsable { get; set; }
	public float PerformanceFractionAcceleration { get; set; }
	public float PerformanceFractionTopSpeed { get; set; }
	public float PerformanceFractionFuelEconomy { get; set; }
	public float OverallPerformanceFraction { get; set; }
	public bool AtLowPerformance { get; }
	public bool AtPeakPerformance { get; }
	public int KW { get; }
	public EngineAudioSet AudioSet { get; }
	private bool EngineIsOn { get; }


	public override bool get_HasAnEngine() { }

	[CompilerGeneratedAttribute] 
	public bool get_IsUsable() { }

	[CompilerGeneratedAttribute] 
	private void set_IsUsable(bool value) { }

	[CompilerGeneratedAttribute] 
	public float get_PerformanceFractionAcceleration() { }

	[CompilerGeneratedAttribute] 
	private void set_PerformanceFractionAcceleration(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_PerformanceFractionTopSpeed() { }

	[CompilerGeneratedAttribute] 
	private void set_PerformanceFractionTopSpeed(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_PerformanceFractionFuelEconomy() { }

	[CompilerGeneratedAttribute] 
	private void set_PerformanceFractionFuelEconomy(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_OverallPerformanceFraction() { }

	[CompilerGeneratedAttribute] 
	private void set_OverallPerformanceFraction(float value) { }

	public bool get_AtLowPerformance() { }

	public bool get_AtPeakPerformance() { }

	public int get_KW() { }

	public EngineAudioSet get_AudioSet() { }

	private bool get_EngineIsOn() { }

	public override void InitShared() { }

	public override void OnEngineStateChanged(VehicleEngineController.EngineState<GroundVehicle> oldState, VehicleEngineController.EngineState<GroundVehicle> newState) { }

	public override float GetMaxDriveForce() { }

	public void RefreshPerformanceStats(EngineStorage engineStorage) { }

	private float GetPerformanceFraction(float statBoostPercent) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override bool CanBeLooted(BasePlayer player) { }

	public override void ClientOnEnable() { }

	public override void ClientVehicleTick() { }

	private void PlayBadPerformanceSound() { }

	private void StopBadPerformanceSound() { }

	private void SetFXState(bool isOn) { }

	public void .ctor() { }

}

public class VehicleModuleEngine.Engine // TypeDefIndex: 11473
{
	[HeaderAttribute] 
	public int engineKW; 
	public float idleFuelPerSec; 
	public float maxFuelPerSec; 
	[HeaderAttribute] 
	public EngineAudioSet audioSet; 
	[HeaderAttribute] 
	public ParticleSystemContainer[] engineParticles; 
	public ParticleSystem[] exhaustSmoke; 
	public ParticleSystem[] exhaustBackfire; 
	public float exhaustSmokeMinOpacity; 
	public float exhaustSmokeMaxOpacity; 
	public float exhaustSmokeChangeRate; 


	public void .ctor() { }

}

public class VehicleLight : MonoBehaviour, IClientComponent // TypeDefIndex: 11475
{
	public bool IsBrake; 
	public GameObject toggleObject; 
	public VehicleLight.LightRenderer[] renderers; 
	[ColorUsageAttribute] 
	public Color lightOnColour; 
	[ColorUsageAttribute] 
	public Color brakesOnColour; 
	private static MaterialPropertyBlock materialPB; 
	private static int emissionColorID; 


	public void SetLightVisuals(bool headlightsOn, bool brakesOn) { }

	public static void SetLightVisuals(IReadOnlyList<VehicleLight> lights, bool headlightsOn, bool brakesOn) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class VehicleLight.LightRenderer // TypeDefIndex: 11476
{
	public Renderer renderer; 
	public int matIndex; 


	public void .ctor() { }

}

public class EngineDamageOverTime // TypeDefIndex: 11483
{
	private readonly List<EngineDamageOverTime.RecentDamage> recentDamage; 
	private readonly float maxSeconds; 
	private readonly float triggerDamage; 
	private readonly Action trigger; 


	public void .ctor(float triggerDamage, float maxSeconds, Action trigger) { }

	public void TakeDamage(float amount) { }

	private float GetRecentDamage() { }

}

private struct EngineDamageOverTime.RecentDamage // TypeDefIndex: 11484
{
	public readonly float time; 
	public readonly float amount; 


	public void .ctor(float time, float amount) { }

}

public abstract class VehicleChassisVisuals<T> : MonoBehaviour // TypeDefIndex: 11502
{
	protected T owner; 
	[CompilerGeneratedAttribute] 
	private VehicleChassisVisuals.ClientWheelData<T>[] <clientWheelData>k__BackingField; 
	private float prevSteer; 
	private bool isStopped; 

	public VehicleChassisVisuals.ClientWheelData<T>[] clientWheelData { get; set; }


	[CompilerGeneratedAttribute] 
	public VehicleChassisVisuals.ClientWheelData<T>[] get_clientWheelData() { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<object>.get_clientWheelData
	*/

	[CompilerGeneratedAttribute] 
	protected void set_clientWheelData(VehicleChassisVisuals.ClientWheelData<T>[] value) { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<object>.set_clientWheelData
	*/

	public virtual void Init(T owner, VehicleChassisVisuals.ClientWheelData<T>[] clientWheelData) { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<ModularCar>.Init
	|-VehicleChassisVisuals<Snowmobile>.Init
	|-VehicleChassisVisuals<object>.Init
	*/

	public void UpdateTick(float dt, bool instantForced = False) { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<ModularCar>.UpdateTick
	|-VehicleChassisVisuals<Snowmobile>.UpdateTick
	|-VehicleChassisVisuals<object>.UpdateTick
	*/

	public bool IsGrounded() { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<Snowmobile>.IsGrounded
	|-VehicleChassisVisuals<object>.IsGrounded
	*/

	protected abstract void PreWheelUpdateTick();
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<object>.PreWheelUpdateTick
	*/

	protected abstract void UpdateWheelVisuals(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool isOn, float steer, float dt);
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<object>.UpdateWheelVisuals
	*/

	protected abstract void PostWheelUpdateTick(bool instant, bool isCloseToCamera, float steer, float dt);
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<object>.PostWheelUpdateTick
	*/

	public float CalculateWheelSlip() { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<ModularCar>.CalculateWheelSlip
	|-VehicleChassisVisuals<Snowmobile>.CalculateWheelSlip
	|-VehicleChassisVisuals<object>.CalculateWheelSlip
	*/

	protected void UpdateWheelSuspensionData(VehicleChassisVisuals.ClientWheelData<T> wheelData, Vector3 traceSource, Nullable<Vector3> traceSource2) { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<ModularCar>.UpdateWheelSuspensionData
	|-VehicleChassisVisuals<Snowmobile>.UpdateWheelSuspensionData
	|-VehicleChassisVisuals<object>.UpdateWheelSuspensionData
	*/

	protected float GetWheelRotation(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool receivingDriveWheelVels, float dt) { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<ModularCar>.GetWheelRotation
	|-VehicleChassisVisuals<Snowmobile>.GetWheelRotation
	|-VehicleChassisVisuals<object>.GetWheelRotation
	*/

	protected static void UpdateSteerRotation(Transform t, float steer, int axis) { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<ModularCar>.UpdateSteerRotation
	|-VehicleChassisVisuals<object>.UpdateSteerRotation
	*/

	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, float throttleInput) { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<ModularCar>.ShowTerrainFX
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, float throttleInput, float speed, float minSpeed) { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<Snowmobile>.ShowTerrainFX
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool isOnWater, float spinSlip, TerrainConfig.GroundType groundType, float throttleInput) { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool isOnWater, float spinSlip, TerrainConfig.GroundType groundType, float throttleInput, float speed, float minSpeed) { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<Snowmobile>.ShowTerrainFX
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	public void UpdateTickStopped() { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<ModularCar>.UpdateTickStopped
	|-VehicleChassisVisuals<Snowmobile>.UpdateTickStopped
	|-VehicleChassisVisuals<object>.UpdateTickStopped
	*/

	protected virtual void StopAll() { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<ModularCar>.StopAll
	|-VehicleChassisVisuals<Snowmobile>.StopAll
	|-VehicleChassisVisuals<object>.StopAll
	*/

	protected static void StopTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData) { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<object>.StopTerrainFX
	*/

	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<ModularCar>..ctor
	|-VehicleChassisVisuals<Snowmobile>..ctor
	|-VehicleChassisVisuals<object>..ctor
	*/

	[CompilerGeneratedAttribute] 
	internal static bool <UpdateWheelSuspensionData>g__GetSuspensionHit|17_0(Vector3 ts, out RaycastHit hit, ref VehicleChassisVisuals.<>c__DisplayClass17_0<T> ) { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<object>.<UpdateWheelSuspensionData>g__GetSuspensionHit|17_0
	*/

}

public class VehicleChassisVisuals.ClientWheelData<T> // TypeDefIndex: 11504
{
	public VisualCarWheel wheel; 
	public Vector3 vehicleLocalPos; 
	public Vector3 restingLocalPos; 
	public RaycastHit hit; 
	public bool isGrounded; 
	public bool isOnWater; 
	public float spinSlip; 
	public TerrainConfig.GroundType groundType; 
	public Vector3 latestWorldPos; 
	public float extension; 
	public float prevExtension; 
	public float extensionPercent; 
	public Sound sound; 
	public SoundModulation.Modulator gainModulator; 

	public bool isOnHardGround { get; }


	public bool get_isOnHardGround() { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals.ClientWheelData<ModularCar>.get_isOnHardGround
	|-VehicleChassisVisuals.ClientWheelData<object>.get_isOnHardGround
	*/

	public void .ctor(VisualCarWheel wheel, Transform vehicleTransform) { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals.ClientWheelData<ModularCar>..ctor
	|-VehicleChassisVisuals.ClientWheelData<Snowmobile>..ctor
	|-VehicleChassisVisuals.ClientWheelData<object>..ctor
	*/

}

private struct VehicleChassisVisuals.<>c__DisplayClass17_0<T> // TypeDefIndex: 11506
{
	public Vector3 vehicleDown; 
	public float wheelRadius; 
	public float suspensionDistance; 

}

public class VehicleEngineController<TOwner> // TypeDefIndex: 11508
{
	[CompilerGeneratedAttribute] 
	private EntityFuelSystem <FuelSystem>k__BackingField; 
	private readonly TOwner owner; 
	private readonly bool isServer; 
	private readonly float engineStartupTime; 
	private readonly Transform waterloggedPoint; 
	private readonly BaseEntity.Flags engineStartingFlag; 

	public VehicleEngineController.EngineState<TOwner> CurEngineState { get; }
	public bool IsOn { get; }
	public bool IsOff { get; }
	public bool IsStarting { get; }
	public bool IsStartingOrOn { get; }
	public EntityFuelSystem FuelSystem { get; set; }


	public VehicleEngineController.EngineState<TOwner> get_CurEngineState() { }
	/* GenericInstMethod :
	|
	|-VehicleEngineController<BaseSubmarine>.get_CurEngineState
	|-VehicleEngineController<GroundVehicle>.get_CurEngineState
	|-VehicleEngineController<MiniCopter>.get_CurEngineState
	|-VehicleEngineController<object>.get_CurEngineState
	|-VehicleEngineController<TrainEngine>.get_CurEngineState
	*/

	public bool get_IsOn() { }
	/* GenericInstMethod :
	|
	|-VehicleEngineController<BaseSubmarine>.get_IsOn
	|-VehicleEngineController<GroundVehicle>.get_IsOn
	|-VehicleEngineController<object>.get_IsOn
	*/

	public bool get_IsOff() { }
	/* GenericInstMethod :
	|
	|-VehicleEngineController<object>.get_IsOff
	|-VehicleEngineController<TrainEngine>.get_IsOff
	*/

	public bool get_IsStarting() { }
	/* GenericInstMethod :
	|
	|-VehicleEngineController<MiniCopter>.get_IsStarting
	|-VehicleEngineController<object>.get_IsStarting
	*/

	public bool get_IsStartingOrOn() { }
	/* GenericInstMethod :
	|
	|-VehicleEngineController<GroundVehicle>.get_IsStartingOrOn
	|-VehicleEngineController<object>.get_IsStartingOrOn
	|-VehicleEngineController<TrainEngine>.get_IsStartingOrOn
	*/

	[CompilerGeneratedAttribute] 
	public EntityFuelSystem get_FuelSystem() { }
	/* GenericInstMethod :
	|
	|-VehicleEngineController<BaseSubmarine>.get_FuelSystem
	|-VehicleEngineController<GroundVehicle>.get_FuelSystem
	|-VehicleEngineController<MiniCopter>.get_FuelSystem
	|-VehicleEngineController<object>.get_FuelSystem
	|-VehicleEngineController<TrainEngine>.get_FuelSystem
	*/

	[CompilerGeneratedAttribute] 
	private void set_FuelSystem(EntityFuelSystem value) { }
	/* GenericInstMethod :
	|
	|-VehicleEngineController<object>.set_FuelSystem
	*/

	public void .ctor(TOwner owner, bool isServer, float engineStartupTime, GameObjectRef fuelStoragePrefab, Transform waterloggedPoint, BaseEntity.Flags engineStartingFlag = 128) { }
	/* GenericInstMethod :
	|
	|-VehicleEngineController<BaseSubmarine>..ctor
	|-VehicleEngineController<GroundVehicle>..ctor
	|-VehicleEngineController<MiniCopter>..ctor
	|-VehicleEngineController<object>..ctor
	|-VehicleEngineController<TrainEngine>..ctor
	*/

	public VehicleEngineController.EngineState<TOwner> EngineStateFrom(BaseEntity.Flags flags) { }
	/* GenericInstMethod :
	|
	|-VehicleEngineController<object>.EngineStateFrom
	|-VehicleEngineController<TrainEngine>.EngineStateFrom
	*/

}

public enum VehicleEngineController.EngineState<TOwner> // TypeDefIndex: 11509
{
	public int value__; 
	public const VehicleEngineController.EngineState<TOwner> Off = 0;
	public const VehicleEngineController.EngineState<TOwner> Starting = 1;
	public const VehicleEngineController.EngineState<TOwner> On = 2;

}

public class VehicleSpawnPoint : SpaceCheckingSpawnPoint // TypeDefIndex: 11734
{

	public void .ctor() { }

}

public class EngineItemInformationPanel : ItemInformationPanel // TypeDefIndex: 12739
{
	[SerializeField] 
	private Text tier; 
	[SerializeField] 
	private Translate.Phrase low; 
	[SerializeField] 
	private Translate.Phrase medium; 
	[SerializeField] 
	private Translate.Phrase high; 
	[SerializeField] 
	private GameObject accelerationRoot; 
	[SerializeField] 
	private GameObject topSpeedRoot; 
	[SerializeField] 
	private GameObject fuelEconomyRoot; 


	public override bool EligableForDisplay(ItemDefinition info) { }

	public override void SetupForItem(ItemDefinition info, Item item) { }

	public void .ctor() { }

}

public class VehicleEditingItemIcon : MonoBehaviour, IInventoryChanged // TypeDefIndex: 12808
{
	[SerializeField] 
	private Image foregroundImage; 
	[SerializeField] 
	private Image linkImage; 
	private ItemIcon itemIcon; 


	protected void Awake() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void OnInventoryChanged() { }

	private void InventoryChangeRefresh() { }

	private void SetLinkSprite(Sprite sprite) { }

	private void ClearLinkSprite() { }

	public void .ctor() { }

}

public class VehicleEditingPanel : LootPanel // TypeDefIndex: 12809
{
	[SerializeField] 
	[RangeAttribute] 
	private float disabledAlpha; 
	[HeaderAttribute] 
	[SerializeField] 
	private CanvasGroup editGroup; 
	[SerializeField] 
	private GameObject moduleInternalItemsGroup; 
	[SerializeField] 
	private GameObject moduleInternalLiquidsGroup; 
	[SerializeField] 
	private GameObject destroyChassisGroup; 
	[SerializeField] 
	private Button itemTakeButton; 
	[SerializeField] 
	private Button liquidTakeButton; 
	[SerializeField] 
	private GameObject liquidHelp; 
	[SerializeField] 
	private GameObject liquidButton; 
	[SerializeField] 
	private Color gotColor; 
	[SerializeField] 
	private Color notGotColor; 
	[SerializeField] 
	private Text generalInfoText; 
	[SerializeField] 
	private Text generalWarningText; 
	[SerializeField] 
	private Image generalWarningImage; 
	[SerializeField] 
	private Text repairInfoText; 
	[SerializeField] 
	private Button repairButton; 
	[SerializeField] 
	private Text destroyChassisButtonText; 
	[SerializeField] 
	private Text destroyChassisCountdown; 
	[SerializeField] 
	private Translate.Phrase phraseEditingInfo; 
	[SerializeField] 
	private Translate.Phrase phraseNoOccupant; 
	[SerializeField] 
	private Translate.Phrase phraseBadOccupant; 
	[SerializeField] 
	private Translate.Phrase phraseNotDriveable; 
	[SerializeField] 
	private Translate.Phrase phraseNotRepairable; 
	[SerializeField] 
	private Translate.Phrase phraseRepairNotNeeded; 
	[SerializeField] 
	private Translate.Phrase phraseRepairSelectInfo; 
	[SerializeField] 
	private Translate.Phrase phraseRepairEnactInfo; 
	[SerializeField] 
	private Translate.Phrase phraseHasLock; 
	[SerializeField] 
	private Translate.Phrase phraseHasNoLock; 
	[SerializeField] 
	private Translate.Phrase phraseAddLock; 
	[SerializeField] 
	private Translate.Phrase phraseAddKey; 
	[SerializeField] 
	private Translate.Phrase phraseAddLockButton; 
	[SerializeField] 
	private Translate.Phrase phraseCraftKeyButton; 
	[SerializeField] 
	private Text carLockInfoText; 
	[SerializeField] 
	private Text carLockButtonText; 
	[SerializeField] 
	private Button actionLockButton; 
	[SerializeField] 
	private Button removeLockButton; 
	[SerializeField] 
	private Translate.Phrase phraseEmptyStorage; 
	[HeaderAttribute] 
	[SerializeField] 
	private VehicleEditingPanel.CreateChassisEntry[] chassisOptions; 
	private uint prevSelectedUID; 
	private bool platformWasOccupied; 
	private bool hadEditableOccupant; 
	private bool hasDriveableOccupant; 
	private ModularCarGarage.OccupantLock occupantLockState; 
	private int occupantLockID; 

	private Item CurSelectedItem { get; }
	private ItemContainer ModulesContainer { get; }
	private ItemContainer ChassisContainer { get; }
	private ItemContainer ModuleInternalItemContainer { get; }


	private Item get_CurSelectedItem() { }

	private ItemContainer get_ModulesContainer() { }

	private ItemContainer get_ChassisContainer() { }

	private ItemContainer get_ModuleInternalItemContainer() { }

	protected void OnEnable() { }

	public override void Update() { }

	public void RepairClicked() { }

	public void CraftLockClicked() { }

	public void RemoveLockClicked() { }

	public void DestroyChassisClicked() { }

	public void TakeInternalItemsClicked() { }

	public void OnCopyFromLiquidDown() { }

	public void OnCopyFromLiquidUp() { }

	private bool SelectedValidLiquidTarget() { }

	private void LiquidCopyFrom() { }

	private bool CanTakeLiquid() { }

	private ModularCarGarage GetGarage() { }

	private void RefreshEditUI() { }

	private void RefreshHasVehicle(ModularCarGarage garage, bool forced = False) { }

	private void RefreshInfoText() { }

	private void RefreshWarningText() { }

	private void OnSelectedItemChanged(Item newSelectedItem) { }

	private void RefreshDestroyGroup(ModularCarGarage garage) { }

	private void RefreshLockCreation(ModularCarGarage garage) { }

	private void RefreshRepair() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private bool <RefreshLockCreation>g__AddResourceInfo|72_0(string prefixText, ItemAmount ingredient, ref VehicleEditingPanel.<>c__DisplayClass72_0 ) { }

}

private class VehicleEditingPanel.CreateChassisEntry // TypeDefIndex: 12810
{
	public byte garageChassisIndex; 
	public Button craftButton; 
	public Text craftButtonText; 
	public Text requirementsText; 


	public ItemDefinition GetChassisItemDef(ModularCarGarage garage) { }

	public void .ctor() { }

}

private struct VehicleEditingPanel.<>c__DisplayClass72_0 // TypeDefIndex: 12811
{
	public VehicleEditingPanel <>4__this; 
	public string infoText; 

}

public class VehicleModuleInformationPanel : ItemInformationPanel // TypeDefIndex: 12812
{
	public ItemStatValue socketsDisplay; 
	public ItemStatValue hpDisplay; 


	public override bool EligableForDisplay(ItemDefinition info) { }

	public override void SetupForItem(ItemDefinition info, Item item) { }

	public void .ctor() { }

}

public class vehicle : ConsoleSystem // TypeDefIndex: 13722
{

	public void .ctor() { }

}

public static class EngineItemTypeEx // TypeDefIndex: 13852
{

	[ExtensionAttribute] 
	public static bool BoostsAcceleration(EngineStorage.EngineItemTypes engineItemType) { }

	[ExtensionAttribute] 
	public static bool BoostsTopSpeed(EngineStorage.EngineItemTypes engineItemType) { }

	[ExtensionAttribute] 
	public static bool BoostsFuelEconomy(EngineStorage.EngineItemTypes engineItemType) { }

}

public class EngineStorage : StorageContainer // TypeDefIndex: 13853
{
	[HeaderAttribute] 
	public Sprite engineIcon; 
	public float internalDamageMultiplier; 
	public EngineStorage.EngineItemTypes[] slotTypes; 
	[SerializeField] 
	private VehicleModuleEngineItems allEngineItems; 
	[SerializeField] 
	[ReadOnlyAttribute] 
	private int accelerationBoostSlots; 
	[SerializeField] 
	[ReadOnlyAttribute] 
	private int topSpeedBoostSlots; 
	[SerializeField] 
	[ReadOnlyAttribute] 
	private int fuelEconomyBoostSlots; 
	[CompilerGeneratedAttribute] 
	private bool <isUsable>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <accelerationBoostPercent>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <topSpeedBoostPercent>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <fuelEconomyBoostPercent>k__BackingField; 

	public bool isUsable { get; set; }
	public float accelerationBoostPercent { get; set; }
	public float topSpeedBoostPercent { get; set; }
	public float fuelEconomyBoostPercent { get; set; }


	[CompilerGeneratedAttribute] 
	public bool get_isUsable() { }

	[CompilerGeneratedAttribute] 
	private void set_isUsable(bool value) { }

	[CompilerGeneratedAttribute] 
	public float get_accelerationBoostPercent() { }

	[CompilerGeneratedAttribute] 
	private void set_accelerationBoostPercent(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_topSpeedBoostPercent() { }

	[CompilerGeneratedAttribute] 
	private void set_topSpeedBoostPercent(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_fuelEconomyBoostPercent() { }

	[CompilerGeneratedAttribute] 
	private void set_fuelEconomyBoostPercent(float value) { }

	public VehicleModuleEngine GetEngineModule() { }

	public float GetAveragedLoadoutPercent() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override bool CanBeLooted(BasePlayer player) { }

	public void .ctor() { }

}

public enum EngineStorage.EngineItemTypes // TypeDefIndex: 13854
{
	public int value__; 
	public const EngineStorage.EngineItemTypes Crankshaft = 0;
	public const EngineStorage.EngineItemTypes Carburetor = 1;
	public const EngineStorage.EngineItemTypes SparkPlug = 2;
	public const EngineStorage.EngineItemTypes Piston = 3;
	public const EngineStorage.EngineItemTypes Valve = 4;

}

public class ModularCarAudio : GroundVehicleAudio // TypeDefIndex: 13855
{
	public bool showDebug; 
	[HeaderAttribute] 
	[SerializeField] 
	private SoundDefinition skidSoundLoop; 
	[SerializeField] 
	private SoundDefinition skidSoundDirtLoop; 
	[SerializeField] 
	private SoundDefinition skidSoundSnowLoop; 
	[SerializeField] 
	private float skidMinSlip; 
	[SerializeField] 
	private float skidMaxSlip; 
	[HeaderAttribute] 
	[SerializeField] 
	private SoundDefinition movementStartOneshot; 
	[SerializeField] 
	private SoundDefinition movementStopOneshot; 
	[SerializeField] 
	private float movementStartStopMinTimeBetweenSounds; 
	[SerializeField] 
	private SoundDefinition movementRattleLoop; 
	[SerializeField] 
	private float movementRattleMaxSpeed; 
	[SerializeField] 
	private float movementRattleMaxAngSpeed; 
	[SerializeField] 
	private float movementRattleIdleGain; 
	[SerializeField] 
	private SoundDefinition suspensionLurchSound; 
	[SerializeField] 
	private float suspensionLurchMinExtensionDelta; 
	[SerializeField] 
	private float suspensionLurchMinTimeBetweenSounds; 
	[HeaderAttribute] 
	[SerializeField] 
	private SoundDefinition tyreRollingSoundDef; 
	[SerializeField] 
	private SoundDefinition tyreRollingWaterSoundDef; 
	[SerializeField] 
	private SoundDefinition tyreRollingGrassSoundDef; 
	[SerializeField] 
	private SoundDefinition tyreRollingSnowSoundDef; 
	[SerializeField] 
	private AnimationCurve tyreRollGainCurve; 
	private EngineAudioSet currentEngineAudioSet; 
	private ModularCar modularCar; 
	private float skidRatio; 
	private Sound skidSound; 
	private SoundModulation.Modulator skidGain; 
	private const float SKID_RATIO_CHANGE_RATE = 12;
	private Dictionary<VehicleChassisVisuals.ClientWheelData<ModularCar>, float> prevWheelExtensionPercent; 
	private Dictionary<VehicleChassisVisuals.ClientWheelData<ModularCar>, bool> wheelWasGrounded; 
	private Dictionary<VehicleChassisVisuals.ClientWheelData<ModularCar>, float> lastSuspensionSoundPlayed; 
	private Dictionary<EngineAudioSet, byte> attachedEngineCounts; 
	private Sound movementRattleSound; 
	private SoundModulation.Modulator rattleGain; 
	private Quaternion prevRotation; 
	private bool wasStationary; 
	private float lastMovementStartSoundPlayed; 
	private float lastMovementStopSoundPlayed; 
	private float noMovementCount; 

	protected override EngineAudioSet EngineAudioSet { get; set; }
	private VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataFL { get; }
	private VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataFR { get; }
	private VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataRL { get; }
	private VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataRR { get; }


	protected override EngineAudioSet get_EngineAudioSet() { }

	protected override void set_EngineAudioSet(EngineAudioSet value) { }

	private VehicleChassisVisuals.ClientWheelData<ModularCar> get_wheelDataFL() { }

	private VehicleChassisVisuals.ClientWheelData<ModularCar> get_wheelDataFR() { }

	private VehicleChassisVisuals.ClientWheelData<ModularCar> get_wheelDataRL() { }

	private VehicleChassisVisuals.ClientWheelData<ModularCar> get_wheelDataRR() { }

	protected override void Awake() { }

	public override void ClientTick() { }

	public override void OnClientTickStopped() { }

	internal void OnModuleAdded(BaseVehicleModule addedModule) { }

	internal void OnModuleRemoved(BaseVehicleModule removedModule) { }

	protected override int GetNumEngines() { }

	private void PlayTyreAudio() { }

	private void StopTyreAudio() { }

	private void StopSkidSound() { }

	private void UpdateMovementRattleSound() { }

	private void StopMovementRattleSound() { }

	private void UpdateSuspensionSounds() { }

	private void UpdateSkidSound(float dt, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData) { }

	private void StopTyreSound(VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData) { }

	private void UpdateTyreSound(VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData, float speedRatio) { }

	public void .ctor() { }

}

public class ModularVehicleSocket // TypeDefIndex: 13856
{
	[SerializeField] 
	private Transform socketTransform; 
	[SerializeField] 
	private ModularVehicleSocket.SocketWheelType wheelType; 
	[SerializeField] 
	private ModularVehicleSocket.SocketLocationType locationType; 

	public Vector3 WorldPosition { get; }
	public Quaternion WorldRotation { get; }
	public ModularVehicleSocket.SocketWheelType WheelType { get; }
	public ModularVehicleSocket.SocketLocationType LocationType { get; }


	public Vector3 get_WorldPosition() { }

	public Quaternion get_WorldRotation() { }

	public ModularVehicleSocket.SocketWheelType get_WheelType() { }

	public ModularVehicleSocket.SocketLocationType get_LocationType() { }

	public bool ShouldBeActive(ConditionalSocketSettings modelSettings) { }

	public void .ctor() { }

}

public enum ModularVehicleSocket.SocketWheelType // TypeDefIndex: 13857
{
	public int value__; 
	public const ModularVehicleSocket.SocketWheelType NoWheel = 0;
	public const ModularVehicleSocket.SocketWheelType ForwardWheel = 1;
	public const ModularVehicleSocket.SocketWheelType BackWheel = 2;

}

public enum ModularVehicleSocket.SocketLocationType // TypeDefIndex: 13858
{
	public int value__; 
	public const ModularVehicleSocket.SocketLocationType Middle = 0;
	public const ModularVehicleSocket.SocketLocationType Front = 1;
	public const ModularVehicleSocket.SocketLocationType Back = 2;

}

public class VehicleModuleEngineItems : ScriptableObject // TypeDefIndex: 13859
{
	[SerializeField] 
	private ItemModEngineItem[] engineItems; 


	public bool TryGetItem(int tier, EngineStorage.EngineItemTypes type, out ItemModEngineItem output) { }

	public void .ctor() { }

}

public class VehicleModuleSlidingComponent // TypeDefIndex: 13860
{
	public string interactionColliderName; 
	public BaseEntity.Flags flag_SliderOpen; 
	public float moveTime; 
	public VehicleModuleSlidingComponent.SlidingPart[] slidingParts; 
	public SoundDefinition openSoundDef; 
	public SoundDefinition closeSoundDef; 
	private float positionPercent; 


	public bool WantsOpenPos(BaseEntity parentEntity) { }

	public void ClientUpdateTick(BaseVehicleModule parentModule) { }

	private void PlaySounds(bool wantsOpenPos) { }

	private void CheckPosition(BaseEntity parentEntity, float dt) { }

	public void .ctor() { }

}

public class VehicleModuleSlidingComponent.SlidingPart // TypeDefIndex: 13861
{
	public Transform transform; 
	public Vector3 openPosition; 
	public Vector3 closedPosition; 


	public void .ctor() { }

}

