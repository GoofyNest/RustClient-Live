public class BaseVehicle : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6327
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<BaseVehicle.MountPoint> mountPoints; // 0x18


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

public class BaseVehicle.MountPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6328
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int index; // 0x14
	public uint mountableId; // 0x18


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

public class Motorboat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6346
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint storageid; // 0x14
	public uint fuelStorageID; // 0x18


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

public class ModularVehicle : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6348
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool editable; // 0x12


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

public class ModularCar : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6349
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float steerAngle; // 0x14
	public float driveWheelVel; // 0x18
	public float throttleInput; // 0x1C
	public float brakeInput; // 0x20
	public uint fuelStorageID; // 0x24
	public float fuelFraction; // 0x28
	public int lockID; // 0x2C


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

public class VehicleLift : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6352
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool platformIsOccupied; // 0x12
	public bool editableOccupant; // 0x13
	public bool driveableOccupant; // 0x14
	public int occupantLockState; // 0x18
	public int occupantLockID; // 0x1C


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

public class EngineStorage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6353
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool isUsable; // 0x12
	public float accelerationBoost; // 0x14
	public float topSpeedBoost; // 0x18
	public float fuelEconomyBoost; // 0x1C


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

public class VehicleVendor : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6378
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VehicleVendor.PlayerStorage> playerStorage; // 0x18
	public uint spawnerRef; // 0x20


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

public class VehicleVendor.PlayerStorage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6379
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong userid; // 0x18
	public List<VehicleVendor.PlayerStorage.PlayerStoredVehicle> storedVehicles; // 0x20


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

public class VehicleVendor.PlayerStorage.PlayerStoredVehicle : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6380
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string shortname; // 0x18
	public string resourcePath; // 0x20
	public float health; // 0x28


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

public class VehicleModule : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6385
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int socketIndex; // 0x14


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

public class CamperModule : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6420
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint bbqId; // 0x14
	public uint lockerId; // 0x18
	public uint storageID; // 0x1C


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

public class BaseVehicle : BaseMountable // TypeDefIndex: 8351
{	private Option __menuOption_Menu_Occupied; // 0x320
	[TooltipAttribute] // RVA: 0xCB180 Offset: 0xCA580 VA: 0x1800CB180
	public bool mountChaining; // 0x378
	public BaseVehicle.ClippingCheckMode clippingChecks; // 0x37C
	public bool shouldShowHudHealth; // 0x380
	public bool ignoreDamageFromOutside; // 0x381
	[HeaderAttribute] // RVA: 0xCB200 Offset: 0xCA600 VA: 0x1800CB200
	public Rigidbody rigidBody; // 0x388
	[HeaderAttribute] // RVA: 0xCB350 Offset: 0xCA750 VA: 0x1800CB350
	public List<BaseVehicle.MountPointInfo> mountPoints; // 0x390
	public bool doClippingAndVisChecks; // 0x398
	[HeaderAttribute] // RVA: 0xCB4E0 Offset: 0xCA8E0 VA: 0x1800CB4E0
	public DamageRenderer damageRenderer; // 0x3A0
	[FormerlySerializedAsAttribute] // RVA: 0xCB740 Offset: 0xCAB40 VA: 0x1800CB740
	public float explosionForceMultiplier; // 0x3A8
	public float explosionForceMax; // 0x3AC
	public const BaseEntity.Flags Flag_OnlyOwnerEntry = 16;
	public const BaseEntity.Flags Flag_Headlights = 2048;
	public const BaseEntity.Flags Flag_Stationary = 32768;
	public const BaseEntity.Flags Flag_SeatsFull = 524288;
	private readonly List<BaseVehicle> childVehicles; // 0x3B0

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

	[BaseEntity.Menu] // RVA: 0xCB8B0 Offset: 0xCACB0 VA: 0x1800CB8B0
	[BaseEntity.Menu.Description] // RVA: 0xCB8B0 Offset: 0xCACB0 VA: 0x1800CB8B0
	[BaseEntity.Menu.Icon] // RVA: 0xCB8B0 Offset: 0xCACB0 VA: 0x1800CB8B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCB8B0 Offset: 0xCACB0 VA: 0x1800CB8B0
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

public enum BaseVehicle.ClippingCheckMode // TypeDefIndex: 8352
{	public int value__; // 0x0
	public const BaseVehicle.ClippingCheckMode OnMountOnly = 0;
	public const BaseVehicle.ClippingCheckMode Always = 1;
	public const BaseVehicle.ClippingCheckMode AlwaysHeadOnly = 2;

}

public class BaseVehicle.MountPointInfo // TypeDefIndex: 8353
{	public bool isDriver; // 0x10
	public Vector3 pos; // 0x14
	public Vector3 rot; // 0x20
	public string bone; // 0x30
	public GameObjectRef prefab; // 0x38


	public void .ctor() { }

}

public struct BaseVehicle.Enumerable : IEnumerable<BaseVehicle.MountPointInfo>, IEnumerable // TypeDefIndex: 8354
{	private readonly BaseVehicle _vehicle; // 0x0


	public void .ctor(BaseVehicle vehicle) { }

	public BaseVehicle.Enumerator GetEnumerator() { }

	private IEnumerator<BaseVehicle.MountPointInfo> System.Collections.Generic.IEnumerable<BaseVehicle.MountPointInfo>.GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public struct BaseVehicle.Enumerator : IEnumerator<BaseVehicle.MountPointInfo>, IEnumerator, IDisposable // TypeDefIndex: 8355
{	private readonly BaseVehicle _vehicle; // 0x0
	private BaseVehicle.Enumerator.State _state; // 0x8
	private int _index; // 0xC
	private int _childIndex; // 0x10
	private BaseVehicle.Enumerator.Box _enumerator; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BaseVehicle.MountPointInfo <Current>k__BackingField; // 0x20

	public BaseVehicle.MountPointInfo Current { get; set; }
	private object System.Collections.IEnumerator.Current { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public BaseVehicle.MountPointInfo get_Current() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Current(BaseVehicle.MountPointInfo value) { }

	public void .ctor(BaseVehicle vehicle) { }

	public bool MoveNext() { }

	private object System.Collections.IEnumerator.get_Current() { }

	public void Dispose() { }

	public void Reset() { }

}

private enum BaseVehicle.Enumerator.State // TypeDefIndex: 8356
{	public int value__; // 0x0
	public const BaseVehicle.Enumerator.State Direct = 0;
	public const BaseVehicle.Enumerator.State EnterChild = 1;
	public const BaseVehicle.Enumerator.State EnumerateChild = 2;
	public const BaseVehicle.Enumerator.State Finished = 3;

}

private class BaseVehicle.Enumerator.Box : Pool.IPooled // TypeDefIndex: 8357
{	public BaseVehicle.Enumerator Value; // 0x10


	public void EnterPool() { }

	public void LeavePool() { }

	public void .ctor() { }

}

public class BaseVehicleModule : BaseVehicle, IPrefabPreProcess // TypeDefIndex: 8358
{	private Option __menuOption_Menu_Locked; // 0x3B8
	private Option __menuOption_Menu_Push; // 0x410
	private Option __menuOption_Menu_Use; // 0x468
	public const string CAR_LOCKED_ACTION_NAME = "car_locked";
	[HeaderAttribute] // RVA: 0xCC0C0 Offset: 0xCB4C0 VA: 0x1800CC0C0
	[SerializeField] // RVA: 0xCC0C0 Offset: 0xCB4C0 VA: 0x1800CC0C0
	private Transform centreOfMassTransform; // 0x4C0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float mass; // 0x4C8
	public BaseVehicleModule.VisualGroup visualGroup; // 0x4CC
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[HideInInspector] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private VehicleLight[] lights; // 0x4D0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BaseModularVehicle <Vehicle>k__BackingField; // 0x4D8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <FirstSocketIndex>k__BackingField; // 0x4E0
	public BaseVehicleModule.LODLevel[] lodRenderers; // 0x4E8
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[HideInInspector] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private List<ConditionalObject> conditionals; // 0x4F0
	[HeaderAttribute] // RVA: 0xCC8E0 Offset: 0xCBCE0 VA: 0x1800CC8E0
	[SerializeField] // RVA: 0xCC8E0 Offset: 0xCBCE0 VA: 0x1800CC8E0
	private TriggerParent[] triggerParents; // 0x4F8
	[HeaderAttribute] // RVA: 0xCCB60 Offset: 0xCBF60 VA: 0x1800CCB60
	[SerializeField] // RVA: 0xCCB60 Offset: 0xCBF60 VA: 0x1800CCB60
	private VehicleModuleSlidingComponent[] slidingComponents; // 0x500
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleModuleButtonComponent[] buttonComponents; // 0x508
	private TimeSince TimeSinceAddedToVehicle; // 0x510
	private float prevRefreshHealth; // 0x514
	private bool prevRefreshVehicleIsDead; // 0x518
	private bool prevRefreshVehicleIsLockable; // 0x519

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

	[BaseEntity.Menu] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.Description] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.Icon] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.ShowIf] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	public void Menu_Push(BasePlayer player) { }

	public override bool Menu_Push_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCCE60 Offset: 0xCC260 VA: 0x1800CCE60
	[BaseEntity.Menu.Description] // RVA: 0xCCE60 Offset: 0xCC260 VA: 0x1800CCE60
	[BaseEntity.Menu.Icon] // RVA: 0xCCE60 Offset: 0xCC260 VA: 0x1800CCE60
	[BaseEntity.Menu.ShowIf] // RVA: 0xCCE60 Offset: 0xCC260 VA: 0x1800CCE60
	public void Menu_Use(BasePlayer player) { }

	public bool Menu_Use_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCD130 Offset: 0xCC530 VA: 0x1800CD130
	[BaseEntity.Menu.Description] // RVA: 0xCD130 Offset: 0xCC530 VA: 0x1800CD130
	[BaseEntity.Menu.Icon] // RVA: 0xCD130 Offset: 0xCC530 VA: 0x1800CD130
	[BaseEntity.Menu.ShowIf] // RVA: 0xCD130 Offset: 0xCC530 VA: 0x1800CD130
	public void Menu_Locked(BasePlayer player) { }

	public virtual bool Menu_Locked_ShowIf(BasePlayer player) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public BaseModularVehicle get_Vehicle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Vehicle(BaseModularVehicle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_FirstSocketIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

public enum BaseVehicleModule.DecalType // TypeDefIndex: 8359
{	public int value__; // 0x0
	public const BaseVehicleModule.DecalType All = 0;
	public const BaseVehicleModule.DecalType Glass = 1;

}

public enum BaseVehicleModule.VisualGroup // TypeDefIndex: 8360
{	public int value__; // 0x0
	public const BaseVehicleModule.VisualGroup None = 0;
	public const BaseVehicleModule.VisualGroup Engine = 1;
	public const BaseVehicleModule.VisualGroup Cabin = 2;
	public const BaseVehicleModule.VisualGroup Flatbed = 3;

}

public class BaseVehicleModule.LODLevel // TypeDefIndex: 8361
{	public Renderer[] renderers; // 0x10


	public void .ctor() { }

}

public class EngineSwitch : BaseEntity // TypeDefIndex: 8389
{	private Option __menuOption_Menu_StartEngine; // 0x168
	private Option __menuOption_Menu_StopEngine; // 0x1C0

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xDC270 Offset: 0xDB670 VA: 0x1800DC270
	[BaseEntity.Menu.Description] // RVA: 0xDC270 Offset: 0xDB670 VA: 0x1800DC270
	[BaseEntity.Menu.Icon] // RVA: 0xDC270 Offset: 0xDB670 VA: 0x1800DC270
	[BaseEntity.Menu.ShowIf] // RVA: 0xDC270 Offset: 0xDB670 VA: 0x1800DC270
	public void Menu_StartEngine(BasePlayer player) { }

	public bool Menu_EngineOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDD760 Offset: 0xDCB60 VA: 0x1800DD760
	[BaseEntity.Menu.Description] // RVA: 0xDD760 Offset: 0xDCB60 VA: 0x1800DD760
	[BaseEntity.Menu.Icon] // RVA: 0xDD760 Offset: 0xDCB60 VA: 0x1800DD760
	[BaseEntity.Menu.ShowIf] // RVA: 0xDD760 Offset: 0xDCB60 VA: 0x1800DD760
	public void Menu_StopEngine(BasePlayer player) { }

	public bool Menu_EngineOff_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public class ModularCar : BaseModularVehicle, IVehicleLockUser, VehicleChassisVisuals.IClientWheelUser<ModularCar> // TypeDefIndex: 8415
{	private Option __menuOption_Menu_FuelStorage; // 0x4C0
	private Option __menuOption_Menu_Locked; // 0x518
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleChassisVisuals.ClientWheelData<ModularCar> <WheelDataFL>k__BackingField; // 0x570
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleChassisVisuals.ClientWheelData<ModularCar> <WheelDataFR>k__BackingField; // 0x578
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleChassisVisuals.ClientWheelData<ModularCar> <WheelDataRL>k__BackingField; // 0x580
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleChassisVisuals.ClientWheelData<ModularCar> <WheelDataRR>k__BackingField; // 0x588
	public TimeSince timeSinceLastUpdate; // 0x590
	public TimeSince timeSinceFailedStartAttempt; // 0x594
	private float clientSteerAngle; // 0x598
	private float clientDriveWheelVelocity; // 0x59C
	private float clientDriveWheelSlip; // 0x5A0
	private float clientThrottle; // 0x5A4
	private float clientBrake; // 0x5A8
	private bool cachedEngineLowPerf; // 0x5AC
	private TimeSince timeSinceEnginePerfCheck; // 0x5B0
	private bool failedStartWasEngineProblem; // 0x5B4
	private bool wasBraking; // 0x5B5
	private const float FAILED_START_LIGHT_TIME = 1;
	private static int detailColorID; // 0x0
	[HeaderAttribute] // RVA: 0x71370 Offset: 0x70770 VA: 0x180071370
	public ModularCarChassisVisuals chassisVisuals; // 0x5B8
	public VisualCarWheel wheelFL; // 0x5C0
	public VisualCarWheel wheelFR; // 0x5C8
	public VisualCarWheel wheelRL; // 0x5D0
	public VisualCarWheel wheelRR; // 0x5D8
	public ItemDefinition carKeyDefinition; // 0x5E0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CarSettings carSettings; // 0x5E8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float hurtTriggerMinSpeed; // 0x5F0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TriggerHurtNotChild hurtTriggerFront; // 0x5F8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TriggerHurtNotChild hurtTriggerRear; // 0x600
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ProtectionProperties immortalProtection; // 0x608
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ProtectionProperties mortalProtection; // 0x610
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ModularCar.SpawnSettings spawnSettings; // 0x618
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[HideInInspector] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private MeshRenderer[] damageShowingRenderers; // 0x620
	[ServerVar] // RVA: 0x71DA0 Offset: 0x711A0 VA: 0x180071DA0
	public static float population; // 0x4
	[ServerVar] // RVA: 0x71FC0 Offset: 0x713C0 VA: 0x180071FC0
	public static float outsidedecayminutes; // 0x8
	public const BUTTON RapidSteerButton = 128;
	public ModularCarLock carLock; // 0x628
	private VehicleEngineController.EngineState<GroundVehicle> lastSetEngineState; // 0x630
	private float cachedFuelFraction; // 0x634

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataFL() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_WheelDataFL(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataFR() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_WheelDataFR(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataRL() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_WheelDataRL(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataRR() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[BaseEntity.Menu] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.Description] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.Icon] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	public void Menu_FuelStorage(BasePlayer player) { }

	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x75220 Offset: 0x74620 VA: 0x180075220
	[BaseEntity.Menu.Description] // RVA: 0x75220 Offset: 0x74620 VA: 0x180075220
	[BaseEntity.Menu.Icon] // RVA: 0x75220 Offset: 0x74620 VA: 0x180075220
	[BaseEntity.Menu.ShowIf] // RVA: 0x75220 Offset: 0x74620 VA: 0x180075220
	public void Menu_Locked(BasePlayer player) { }

	public bool Menu_Locked_ShowIf(BasePlayer player) { }

	public override bool MountMenuVisible(BasePlayer player) { }

	public override float GetHUDHealth() { }

	public override float GetHUDMaxHealth() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void ModularCarUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

public class ModularCar.SpawnSettings // TypeDefIndex: 8416
{	[TooltipAttribute] // RVA: 0x757C0 Offset: 0x74BC0 VA: 0x1800757C0
	public bool useSpawnSettings; // 0x10
	[TooltipAttribute] // RVA: 0x75930 Offset: 0x74D30 VA: 0x180075930
	public ModularCarPresetConfig[] configurationOptions; // 0x18
	[TooltipAttribute] // RVA: 0x75A10 Offset: 0x74E10 VA: 0x180075A10
	public float minStartHealthPercent; // 0x20
	[TooltipAttribute] // RVA: 0x75CB0 Offset: 0x750B0 VA: 0x180075CB0
	public float maxStartHealthPercent; // 0x24
	public ModularCar.SpawnSettings.AdminBonus adminBonus; // 0x28


	public void .ctor() { }

}

public enum ModularCar.SpawnSettings.AdminBonus // TypeDefIndex: 8417
{	public int value__; // 0x0
	public const ModularCar.SpawnSettings.AdminBonus None = 0;
	public const ModularCar.SpawnSettings.AdminBonus T1PlusFuel = 1;
	public const ModularCar.SpawnSettings.AdminBonus T2PlusFuel = 2;
	public const ModularCar.SpawnSettings.AdminBonus T3PlusFuel = 3;

}

public class ModularCarGarage : ContainerIOEntity // TypeDefIndex: 8418
{	private Option __menuOption_Menu_EditVehicle; // 0x378
	private Option __menuOption_Menu_InsufficientPower; // 0x3D0
	private TimeSince lastChassisDestroyTime; // 0x428
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform vehicleLift; // 0x430
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Animation vehicleLiftAnim; // 0x438
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string animName; // 0x440
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleLiftOccupantTrigger occupantTrigger; // 0x448
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float liftMoveTime; // 0x450
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EmissionToggle poweredLight; // 0x458
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EmissionToggle inUseLight; // 0x460
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform vehicleLiftPos; // 0x468
	[SerializeField] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	[RangeAttribute] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	private float recycleEfficiency; // 0x470
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform recycleDropPos; // 0x478
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool needsElectricity; // 0x480
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition liftStartSoundDef; // 0x488
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition liftStopSoundDef; // 0x490
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition liftStopDownSoundDef; // 0x498
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition liftLoopSoundDef; // 0x4A0
	public ModularCarGarage.ChassisBuildOption[] chassisBuildOptions; // 0x4A8
	public ItemAmount lockResourceCost; // 0x4B0
	public ItemDefinition carKeyDefinition; // 0x4B8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <PlatformIsOccupied>k__BackingField; // 0x4C0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <HasEditableOccupant>k__BackingField; // 0x4C1
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <HasDriveableOccupant>k__BackingField; // 0x4C2
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ModularCarGarage.OccupantLock <OccupantLockState>k__BackingField; // 0x4C4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <OccupantLockID>k__BackingField; // 0x4C8
	private ModularCarGarage.VehicleLiftState vehicleLiftState; // 0x4CC
	private Sound liftLoopSound; // 0x4D0
	private Vector3 downPos; // 0x4D8
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

	public override int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	private bool PlayerHasInternalModuleLoot() { }

	public void ClientRequestAddLock() { }

	public void ClientRequestRemoveLock() { }

	public void ClientRequestNewKey() { }

	private void RefreshPoweredLightState() { }

	private void RefreshInUseLightState() { }

	[BaseEntity.Menu] // RVA: 0x770F0 Offset: 0x764F0 VA: 0x1800770F0
	[BaseEntity.Menu.Description] // RVA: 0x770F0 Offset: 0x764F0 VA: 0x1800770F0
	[BaseEntity.Menu.Icon] // RVA: 0x770F0 Offset: 0x764F0 VA: 0x1800770F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x770F0 Offset: 0x764F0 VA: 0x1800770F0
	public void Menu_EditVehicle(BasePlayer player) { }

	public bool Menu_EditVehicle_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x77470 Offset: 0x76870 VA: 0x180077470
	[BaseEntity.Menu.Description] // RVA: 0x77470 Offset: 0x76870 VA: 0x180077470
	[BaseEntity.Menu.Icon] // RVA: 0x77470 Offset: 0x76870 VA: 0x180077470
	[BaseEntity.Menu.ShowIf] // RVA: 0x77470 Offset: 0x76870 VA: 0x180077470
	public void Menu_InsufficientPower(BasePlayer player) { }

	public bool Menu_InsufficientPower_ShowIf(BasePlayer player) { }

	public void StartChassisDestroy() { }

	public void CancelChassisDestroy() { }

	public float get_TimeLeftToCancelChassisDestroy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_PlatformIsOccupied() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_PlatformIsOccupied(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_HasEditableOccupant() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_HasEditableOccupant(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_HasDriveableOccupant() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_HasDriveableOccupant(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ModularCarGarage.OccupantLock get_OccupantLockState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_OccupantLockState(ModularCarGarage.OccupantLock value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_OccupantLockID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

public class ModularCarGarage.ChassisBuildOption // TypeDefIndex: 8419
{	public GameObjectRef prefab; // 0x10
	public ItemDefinition itemDef; // 0x18


	public void .ctor() { }

}

public enum ModularCarGarage.OccupantLock // TypeDefIndex: 8420
{	public int value__; // 0x0
	public const ModularCarGarage.OccupantLock CannotHaveLock = 0;
	public const ModularCarGarage.OccupantLock NoLock = 1;
	public const ModularCarGarage.OccupantLock HasLock = 2;

}

private enum ModularCarGarage.VehicleLiftState // TypeDefIndex: 8421
{	public int value__; // 0x0
	public const ModularCarGarage.VehicleLiftState Down = 0;
	public const ModularCarGarage.VehicleLiftState Up = 1;

}

public class MotorRowboat : BaseBoat // TypeDefIndex: 8422
{	private Option __menuOption_Menu_FuelStorage; // 0x438
	private Option __menuOption_Menu_StartEngine; // 0x490
	private Option __menuOption_Menu_StopEngine; // 0x4E8
	[HeaderAttribute] // RVA: 0x71F00 Offset: 0x71300 VA: 0x180071F00
	public BlendedSoundLoops engineLoops; // 0x540
	public BlendedSoundLoops waterLoops; // 0x548
	public SoundDefinition engineStartSoundDef; // 0x550
	public SoundDefinition engineStopSoundDef; // 0x558
	public SoundDefinition movementSplashAccentSoundDef; // 0x560
	public SoundDefinition engineSteerSoundDef; // 0x568
	public GameObjectRef pushLandEffect; // 0x570
	public GameObjectRef pushWaterEffect; // 0x578
	public float waterSpeedDivisor; // 0x580
	public float turnPitchModScale; // 0x584
	public float tiltPitchModScale; // 0x588
	public float splashAccentFrequencyMin; // 0x58C
	public float splashAccentFrequencyMax; // 0x590
	private float directionalPitchModScale; // 0x594
	private float vol; // 0x598
	private float pitch; // 0x59C
	private float speed; // 0x5A0
	private bool wasEngineOn; // 0x5A4
	private float nextSplashAccent; // 0x5A8
	private int prevSteering; // 0x5AC
	protected const BaseEntity.Flags Flag_EngineOn = 128;
	protected const BaseEntity.Flags Flag_ThrottleOn = 256;
	protected const BaseEntity.Flags Flag_TurnLeft = 512;
	protected const BaseEntity.Flags Flag_TurnRight = 1024;
	protected const BaseEntity.Flags Flag_Submerged = 2048;
	protected const BaseEntity.Flags Flag_HasFuel = 16384;
	protected const BaseEntity.Flags Flag_RecentlyPushed = 65536;
	private const float submergeFractionMinimum = 0,85;
	[HeaderAttribute] // RVA: 0x78380 Offset: 0x77780 VA: 0x180078380
	public GameObjectRef fuelStoragePrefab; // 0x5B0
	public float fuelPerSec; // 0x5B8
	[HeaderAttribute] // RVA: 0x78450 Offset: 0x77850 VA: 0x180078450
	public GameObjectRef storageUnitPrefab; // 0x5C0
	public EntityRef<StorageContainer> storageUnitInstance; // 0x5C8
	[HeaderAttribute] // RVA: 0x785E0 Offset: 0x779E0 VA: 0x1800785E0
	public Transform boatRear; // 0x5D8
	public ParticleSystemContainer wakeEffect; // 0x5E0
	public ParticleSystemContainer engineEffectIdle; // 0x5E8
	public ParticleSystemContainer engineEffectThrottle; // 0x5F0
	public Projector causticsProjector; // 0x5F8
	public Transform causticsDepthTest; // 0x600
	public Transform engineLeftHandPosition; // 0x608
	public Transform engineRotate; // 0x610
	public Transform propellerRotate; // 0x618
	[ServerVar] // RVA: 0x71DA0 Offset: 0x711A0 VA: 0x180071DA0
	public static float population; // 0x0
	[ServerVar] // RVA: 0x79A60 Offset: 0x78E60 VA: 0x180079A60
	public static float outsidedecayminutes; // 0x4
	[ServerVar] // RVA: 0x79D90 Offset: 0x79190 VA: 0x180079D90
	public static float deepwaterdecayminutes; // 0x8
	protected EntityFuelSystem fuelSystem; // 0x620
	public Transform[] stationaryDismounts; // 0x628
	public Collider mainCollider; // 0x630
	public float angularDragBase; // 0x638
	public float angularDragVelocity; // 0x63C
	public float landDrag; // 0x640
	public float waterDrag; // 0x644
	public float offAxisDrag; // 0x648
	public float offAxisDot; // 0x64C
	private AverageVelocity averageVelocity; // 0x650
	private bool wasWakeOn; // 0x658
	private bool wasEngineSprayOn; // 0x659
	private bool wasEngineIdleOn; // 0x65A
	private Material causticsMaterial; // 0x660
	private Color causticsColor; // 0x668
	private float causticsAlpha; // 0x678
	protected float currentEngineRotation; // 0x67C
	protected float propellerRotationSpeed; // 0x680

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

	[BaseEntity.Menu] // RVA: 0x79F90 Offset: 0x79390 VA: 0x180079F90
	[BaseEntity.Menu.Description] // RVA: 0x79F90 Offset: 0x79390 VA: 0x180079F90
	[BaseEntity.Menu.Icon] // RVA: 0x79F90 Offset: 0x79390 VA: 0x180079F90
	[BaseEntity.Menu.ShowIf] // RVA: 0x79F90 Offset: 0x79390 VA: 0x180079F90
	public void Menu_StartEngine(BasePlayer player) { }

	public bool Menu_StartEngine_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7A330 Offset: 0x79730 VA: 0x18007A330
	[BaseEntity.Menu.Description] // RVA: 0x7A330 Offset: 0x79730 VA: 0x18007A330
	[BaseEntity.Menu.Icon] // RVA: 0x7A330 Offset: 0x79730 VA: 0x18007A330
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A330 Offset: 0x79730 VA: 0x18007A330
	public void Menu_StopEngine(BasePlayer player) { }

	public bool Menu_StopEngine_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7A670 Offset: 0x79A70 VA: 0x18007A670
	[BaseEntity.Menu.Description] // RVA: 0x7A670 Offset: 0x79A70 VA: 0x18007A670
	[BaseEntity.Menu.Icon] // RVA: 0x7A670 Offset: 0x79A70 VA: 0x18007A670
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A670 Offset: 0x79A70 VA: 0x18007A670
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

public class VehicleModuleCamper : VehicleModuleSeating // TypeDefIndex: 8477
{	private Option __menuOption_Menu_AssignToFriend; // 0x608
	private Option __menuOption_Menu_ClearBedOwner; // 0x660
	private Option __menuOption_Menu_MakeBed; // 0x6B8
	private Option __menuOption_Menu_OpenLocker; // 0x710
	private Option __menuOption_Menu_OpenStorage; // 0x768
	private Option __menuOption_Menu_Rename; // 0x7C0
	public GameObjectRef SleepingBagEntity; // 0x818
	public Transform[] SleepingBagPoints; // 0x820
	public GameObjectRef LockerEntity; // 0x828
	public Transform LockerPoint; // 0x830
	public GameObjectRef BbqEntity; // 0x838
	public Transform BbqPoint; // 0x840
	public GameObjectRef StorageEntity; // 0x848
	public Transform StoragePoint; // 0x850
	private EntityRef<BaseOven> activeBbq; // 0x858
	private EntityRef<Locker> activeLocker; // 0x868
	private EntityRef<StorageContainer> activeStorage; // 0x878

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override bool CanBeLooted(BasePlayer player) { }

	public override bool IsOnThisModule(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x85360 Offset: 0x84760 VA: 0x180085360
	[BaseEntity.Menu.Icon] // RVA: 0x85360 Offset: 0x84760 VA: 0x180085360
	[BaseEntity.Menu.Description] // RVA: 0x85360 Offset: 0x84760 VA: 0x180085360
	[BaseEntity.Menu.ShowIf] // RVA: 0x85360 Offset: 0x84760 VA: 0x180085360
	public void Menu_MakeBed(BasePlayer player) { }

	public virtual bool Menu_MakeBed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x96A30 Offset: 0x95E30 VA: 0x180096A30
	[BaseEntity.Menu.Icon] // RVA: 0x96A30 Offset: 0x95E30 VA: 0x180096A30
	[BaseEntity.Menu.Description] // RVA: 0x96A30 Offset: 0x95E30 VA: 0x180096A30
	[BaseEntity.Menu.ShowIf] // RVA: 0x96A30 Offset: 0x95E30 VA: 0x180096A30
	public void Menu_ClearBedOwner(BasePlayer player) { }

	public virtual bool Menu_ClearBedOwner_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x847F0 Offset: 0x83BF0 VA: 0x1800847F0
	[BaseEntity.Menu.Icon] // RVA: 0x847F0 Offset: 0x83BF0 VA: 0x1800847F0
	[BaseEntity.Menu.Description] // RVA: 0x847F0 Offset: 0x83BF0 VA: 0x1800847F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x847F0 Offset: 0x83BF0 VA: 0x1800847F0
	public void Menu_AssignToFriend(BasePlayer player) { }

	public virtual bool Menu_AssignToFriend_Test(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x844E0 Offset: 0x838E0 VA: 0x1800844E0
	[BaseEntity.Menu.Icon] // RVA: 0x844E0 Offset: 0x838E0 VA: 0x1800844E0
	[BaseEntity.Menu.Description] // RVA: 0x844E0 Offset: 0x838E0 VA: 0x1800844E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x844E0 Offset: 0x838E0 VA: 0x1800844E0
	public void Menu_Rename(BasePlayer player) { }

	protected virtual bool CanRename_Test(BasePlayer player) { }

	private SleepingBagCamper GetSleepingBagForPlayer(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0x97270 Offset: 0x96670 VA: 0x180097270
	[BaseEntity.Menu.Description] // RVA: 0x97270 Offset: 0x96670 VA: 0x180097270
	[BaseEntity.Menu.Icon] // RVA: 0x97270 Offset: 0x96670 VA: 0x180097270
	[BaseEntity.Menu.ShowIf] // RVA: 0x97270 Offset: 0x96670 VA: 0x180097270
	public void Menu_OpenLocker(BasePlayer player) { }

	public bool Menu_OpenLocker_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x975F0 Offset: 0x969F0 VA: 0x1800975F0
	[BaseEntity.Menu.Description] // RVA: 0x975F0 Offset: 0x969F0 VA: 0x1800975F0
	[BaseEntity.Menu.Icon] // RVA: 0x975F0 Offset: 0x969F0 VA: 0x1800975F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x975F0 Offset: 0x969F0 VA: 0x1800975F0
	public void Menu_OpenStorage(BasePlayer player) { }

	public bool Menu_OpenStorage_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public class VehicleModuleSeating : BaseVehicleModule, IPrefabPreProcess // TypeDefIndex: 8478
{	private Option __menuOption_Menu_DestroyLock; // 0x520
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ProtectionProperties passengerProtection; // 0x578
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleModuleSeating.Seating seating; // 0x580
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[HideInInspector] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private Vector3 steerAngle; // 0x588
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[HideInInspector] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private Vector3 accelAngle; // 0x594
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[HideInInspector] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private Vector3 brakeAngle; // 0x5A0
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[HideInInspector] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private Vector3 speedometerAngle; // 0x5AC
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[HideInInspector] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private Vector3 fuelAngle; // 0x5B8
	[HeaderAttribute] // RVA: 0x967C0 Offset: 0x95BC0 VA: 0x1800967C0
	[SerializeField] // RVA: 0x967C0 Offset: 0x95BC0 VA: 0x1800967C0
	private SoundDefinition hornLoop; // 0x5C8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition hornStart; // 0x5D0
	private Sound activeHorn; // 0x5D8
	private const BaseEntity.Flags FLAG_HORN = 65536;
	private float steerPercent; // 0x5E0
	private float throttlePercent; // 0x5E4
	private float brakePercent; // 0x5E8
	private Nullable<bool> checkEngineLightOn; // 0x5EC
	private Nullable<bool> fuelLightOn; // 0x5EE
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ModularCar <Car>k__BackingField; // 0x5F0
	protected IVehicleLockUser VehicleLockUser; // 0x5F8
	private MaterialPropertyBlock dashboardLightPB; // 0x600
	private static int emissionColorID; // 0x0

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected ModularCar get_Car() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[BaseEntity.Menu] // RVA: 0x98880 Offset: 0x97C80 VA: 0x180098880
	[BaseEntity.Menu.Description] // RVA: 0x98880 Offset: 0x97C80 VA: 0x180098880
	[BaseEntity.Menu.Icon] // RVA: 0x98880 Offset: 0x97C80 VA: 0x180098880
	[BaseEntity.Menu.ShowIf] // RVA: 0x98880 Offset: 0x97C80 VA: 0x180098880
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

public class VehicleModuleSeating.MountHotSpot // TypeDefIndex: 8479
{	public Transform transform; // 0x10
	public Vector2 size; // 0x18


	public void .ctor() { }

}

public class VehicleModuleSeating.Seating // TypeDefIndex: 8480
{	[HeaderAttribute] // RVA: 0x98B90 Offset: 0x97F90 VA: 0x180098B90
	public bool doorsAreLockable; // 0x10
	[ObsoleteAttribute] // RVA: 0x98C60 Offset: 0x98060 VA: 0x180098C60
	[HideInInspector] // RVA: 0x98C60 Offset: 0x98060 VA: 0x180098C60
	public BaseVehicle.MountPointInfo[] mountPoints; // 0x18
	public Transform steeringWheel; // 0x20
	public Transform accelPedal; // 0x28
	public Transform brakePedal; // 0x30
	public Transform steeringWheelLeftGrip; // 0x38
	public Transform steeringWheelRightGrip; // 0x40
	public Transform accelPedalGrip; // 0x48
	public Transform brakePedalGrip; // 0x50
	public VehicleModuleSeating.MountHotSpot[] mountHotSpots; // 0x58
	[HeaderAttribute] // RVA: 0x98E90 Offset: 0x98290 VA: 0x180098E90
	public Transform speedometer; // 0x60
	public Transform fuelGauge; // 0x68
	public Renderer dashboardRenderer; // 0x70
	[RangeAttribute] // RVA: 0x84380 Offset: 0x83780 VA: 0x180084380
	public int checkEngineLightMatIndex; // 0x78
	[ColorUsageAttribute] // RVA: 0x859B0 Offset: 0x84DB0 VA: 0x1800859B0
	public Color checkEngineLightEmission; // 0x7C
	[RangeAttribute] // RVA: 0x84380 Offset: 0x83780 VA: 0x180084380
	public int fuelLightMatIndex; // 0x8C
	[ColorUsageAttribute] // RVA: 0x859B0 Offset: 0x84DB0 VA: 0x1800859B0
	public Color fuelLightEmission; // 0x90


	public void .ctor() { }

}

public class VehicleModuleStorage : VehicleModuleSeating // TypeDefIndex: 8481
{	private Option __menuOption_Menu_Open; // 0x608
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleModuleStorage.Storage storage; // 0x660
	private EntityRef storageUnitInstance; // 0x668

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public IItemContainerEntity GetContainer() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override bool CanBeLooted(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	[BaseEntity.Menu.Description] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	[BaseEntity.Menu.Icon] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	[BaseEntity.Menu.ShowIf] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	public void Menu_Open(BasePlayer player) { }

	public bool Menu_Open_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public class VehicleModuleStorage.Storage // TypeDefIndex: 8482
{	public GameObjectRef storageUnitPrefab; // 0x10
	public Transform storageUnitPoint; // 0x18


	public void .ctor() { }

}

public class VehicleModuleTaxi : VehicleModuleStorage // TypeDefIndex: 8483
{	private Option __menuOption_Menu_Kick_Passengers; // 0x678
	[HeaderAttribute] // RVA: 0x99D60 Offset: 0x99160 VA: 0x180099D60
	[SerializeField] // RVA: 0x99D60 Offset: 0x99160 VA: 0x180099D60
	private SoundDefinition kickButtonSound; // 0x6D0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SphereCollider kickButtonCollider; // 0x6D8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float maxKickVelocity; // 0x6E0

	public override bool HasMenuOptions { get; }
	private Vector3 KickButtonPos { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private Vector3 get_KickButtonPos() { }

	private bool CanKickPassengers(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9A150 Offset: 0x99550 VA: 0x18009A150
	[BaseEntity.Menu.Description] // RVA: 0x9A150 Offset: 0x99550 VA: 0x18009A150
	[BaseEntity.Menu.Icon] // RVA: 0x9A150 Offset: 0x99550 VA: 0x18009A150
	[BaseEntity.Menu.ShowIf] // RVA: 0x9A150 Offset: 0x99550 VA: 0x18009A150
	public void Menu_Kick_Passengers(BasePlayer player) { }

	public bool Menu_Kick_Passengers_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public class ModularCarOven : BaseOven // TypeDefIndex: 8608
{	private BaseVehicleModule moduleParent; // 0x4E8

	private BaseVehicleModule ModuleParent { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private BaseVehicleModule get_ModuleParent() { }

	public override void ResetState() { }

	protected override bool SwitchOff_ShowIf(BasePlayer player) { }

	protected override bool SwitchOn_ShowIf(BasePlayer player) { }

	protected override bool Menu_Open_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

public class VehicleVendor : NPCTalking // TypeDefIndex: 8851
{	public EntityRef spawnerRef; // 0x858
	public VehicleSpawner vehicleSpawner; // 0x868


	public override string GetConversationStartSpeech(BasePlayer player) { }

	public VehicleSpawner GetVehicleSpawner() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override ConversationData GetConversationFor(BasePlayer player) { }

	public void .ctor() { }

}

public class VehicleSpawner : BaseEntity // TypeDefIndex: 8852
{	public float spawnNudgeRadius; // 0x168
	public float cleanupRadius; // 0x16C
	public float occupyRadius; // 0x170
	public VehicleSpawner.SpawnPair[] objectsToSpawn; // 0x178
	public Transform spawnOffset; // 0x180
	public float safeRadius; // 0x188


	public virtual int GetOccupyLayer() { }

	public BaseVehicle GetVehicleOccupying() { }

	public void .ctor() { }

}

public class VehicleSpawner.SpawnPair // TypeDefIndex: 8853
{	public string message; // 0x10
	public GameObjectRef prefabToSpawn; // 0x18


	public void .ctor() { }

}

public class EngineAudioClip : MonoBehaviour, IClientComponent // TypeDefIndex: 8987
{	public AudioClip granularClip; // 0x18
	public AudioClip accelerationClip; // 0x20
	public TextAsset accelerationCyclesJson; // 0x28
	public List<EngineAudioClip.EngineCycle> accelerationCycles; // 0x30
	public List<EngineAudioClip.EngineCycleBucket> cycleBuckets; // 0x38
	public Dictionary<int, EngineAudioClip.EngineCycleBucket> accelerationCyclesByRPM; // 0x40
	public Dictionary<int, int> rpmBucketLookup; // 0x48
	public int sampleRate; // 0x50
	public int samplesUntilNextGrain; // 0x54
	public int lastCycleId; // 0x58
	public List<EngineAudioClip.Grain> grains; // 0x60
	public int currentRPM; // 0x68
	public int targetRPM; // 0x6C
	public int minRPM; // 0x70
	public int maxRPM; // 0x74
	public int cyclePadding; // 0x78
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float RPMControl; // 0x7C
	public AudioSource source; // 0x80
	public float rpmLerpSpeed; // 0x88
	public float rpmLerpSpeedDown; // 0x8C
	private Random random; // 0x90
	private float[] accelerationAudioData; // 0x98
	private EngineAudioClip.EngineCycle currentCycle; // 0xA0
	private bool audioDataLoaded; // 0xA8


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

public class EngineAudioClip.EngineCycle // TypeDefIndex: 8988
{	public int RPM; // 0x10
	public int startSample; // 0x14
	public int endSample; // 0x18
	public float period; // 0x1C
	public int id; // 0x20


	public void .ctor(int RPM, int startSample, int endSample, float period, int id) { }

}

public class EngineAudioClip.EngineCycleBucket // TypeDefIndex: 8989
{	public int RPM; // 0x10
	public List<EngineAudioClip.EngineCycle> cycles; // 0x18
	public List<int> remainingCycles; // 0x20


	public void .ctor(int RPM) { }

	public EngineAudioClip.EngineCycle GetCycle(Random random, int lastCycleId) { }

	private void ResetRemainingCycles(Random random) { }

	public void Add(EngineAudioClip.EngineCycle cycle) { }

}

public class EngineAudioClip.Grain // TypeDefIndex: 8990
{	private float[] sourceData; // 0x10
	private int startSample; // 0x18
	private int currentSample; // 0x1C
	private int attackTimeSamples; // 0x20
	private int sustainTimeSamples; // 0x24
	private int releaseTimeSamples; // 0x28
	private float gain; // 0x2C
	private float gainPerSampleAttack; // 0x30
	private float gainPerSampleRelease; // 0x34
	private int attackEndSample; // 0x38
	private int releaseStartSample; // 0x3C
	private int endSample; // 0x40

	public bool finished { get; }


	public bool get_finished() { }

	public void Init(float[] source, EngineAudioClip.EngineCycle cycle, int cyclePadding) { }

	public float GetSample() { }

	public void .ctor() { }

}

public class BaseVehicleMountPoint : BaseMountable // TypeDefIndex: 9696
{
	public override bool DirectlyMountable() { }

	public override BaseVehicle VehicleParent() { }

	public override bool BlocksWaterFor(BasePlayer player) { }

	public override float WaterFactorForPlayer(BasePlayer player) { }

	public override float AirFactor() { }

	public void .ctor() { }

}

public class BaseVehicleSeat : BaseVehicleMountPoint // TypeDefIndex: 9697
{	public float mountedAnimationSpeed; // 0x320
	public bool sendClientInputToVehicleParent; // 0x324
	public bool forcePlayerModelUpdate; // 0x325


	public override void OnClientInput(BasePlayer player) { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public override float GetMountedAnimationSpeed() { }

	public override bool ForceUpdatePlayerModel(BasePlayer p) { }

	public void .ctor() { }

}

public class EngineAudioSet : ScriptableObject // TypeDefIndex: 9734
{	public BlendedEngineLoopDefinition[] engineAudioLoops; // 0x18
	public int priority; // 0x20
	public float idleVolume; // 0x24
	public float maxVolume; // 0x28
	public float volumeChangeRateUp; // 0x2C
	public float volumeChangeRateDown; // 0x30
	public float idlePitch; // 0x34
	public float maxPitch; // 0x38
	public float idleRpm; // 0x3C
	public float gearUpRpm; // 0x40
	public float gearDownRpm; // 0x44
	public int numGears; // 0x48
	public float maxRpm; // 0x4C
	public float gearUpRpmRate; // 0x50
	public float gearDownRpmRate; // 0x54
	public SoundDefinition badPerformanceLoop; // 0x58


	public BlendedEngineLoopDefinition GetEngineLoopDef(int numEngines) { }

	public void .ctor() { }

}

public class ModularCarCentralLockingSwitch : VehicleModuleButtonComponent // TypeDefIndex: 9737
{	public Transform centralLockingSwitch; // 0x28
	public Vector3 switchOffPos; // 0x30
	public Vector3 switchOnPos; // 0x3C


	public override void ClientUse(BasePlayer player, BaseVehicleModule parentModule) { }

	public override void ClientUpdateTick(BaseVehicleModule parentModule) { }

	public void .ctor() { }

}

public class ModularCarChassisVisuals : VehicleChassisVisuals<ModularCar>, IClientComponent // TypeDefIndex: 9738
{	public Transform frontAxle; // 0x30
	public Transform rearAxle; // 0x38
	public ModularCarChassisVisuals.Steering steering; // 0x40
	public ModularCarChassisVisuals.LookAtTarget transmission; // 0x48
	private ModularCar modularCar; // 0x50


	public override void Init(ModularCar owner, VehicleChassisVisuals.ClientWheelData<ModularCar>[] clientWheelData) { }

	protected override void PreWheelUpdateTick() { }

	protected override void PostWheelUpdateTick(bool instant, bool isCloseToCamera, float steer, float dt) { }

	protected override void UpdateWheelVisuals(VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData, bool isOn, float steer, float dt) { }

	private void UpdateAxle(Transform axle, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataL, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataR, float dt, bool instant) { }

	private void LookAt(ModularCarChassisVisuals.LookAtTarget lookAt) { }

	public void .ctor() { }

}

public class ModularCarChassisVisuals.Steering // TypeDefIndex: 9739
{	public Transform steerL; // 0x10
	public Transform steerR; // 0x18
	public ModularCarChassisVisuals.LookAtTarget steerRodL; // 0x20
	public ModularCarChassisVisuals.LookAtTarget steerRodR; // 0x28
	public ModularCarChassisVisuals.LookAtTarget steeringArm; // 0x30


	public void .ctor() { }

}

public class ModularCarChassisVisuals.LookAtTarget // TypeDefIndex: 9740
{	public Transform aim; // 0x10
	public Transform target; // 0x18
	public Vector3 angleAdjust; // 0x20


	public void .ctor() { }

}

public class VehicleLiftOccupantTrigger : TriggerBase // TypeDefIndex: 9741
{
	public void .ctor() { }

}

public class ModularCarLock // TypeDefIndex: 9743
{	private readonly bool isServer; // 0x10
	private readonly ModularCar owner; // 0x18
	public int LockID; // 0x20
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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <PlayerHasUnlockPermission>b__13_0(Item key) { }

}

public enum ModularCarLock.LockType // TypeDefIndex: 9744
{	public int value__; // 0x0
	public const ModularCarLock.LockType Door = 0;
	public const ModularCarLock.LockType General = 1;

}

public class ModularCarPresetConfig : ScriptableObject // TypeDefIndex: 9745
{	public ItemModVehicleModule[] socketItemDefs; // 0x18


	public void .ctor() { }

}

public class ModularCarSeat : MouseSteerableSeat // TypeDefIndex: 9746
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 leftFootIKPos; // 0x330
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 rightFootIKPos; // 0x33C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 leftHandIKPos; // 0x348
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 rightHandIKPos; // 0x354
	public float providesComfort; // 0x360

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

public class ModularVehicleShopFront : ShopFront // TypeDefIndex: 9747
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float maxUseDistance; // 0x3F0


	public override bool CanBeLooted(BasePlayer player) { }

	public override bool ShouldShowLootMenus() { }

	private bool WithinUseDistance(BasePlayer player) { }

	public void .ctor() { }

}

public class CamperSeatConfig : MonoBehaviour // TypeDefIndex: 9748
{	public Transform[] SeatPositions; // 0x18
	public Transform StovePosition; // 0x20
	public Transform StoragePosition; // 0x28


	public void .ctor() { }

}

public abstract class VehicleModuleButtonComponent : MonoBehaviour // TypeDefIndex: 9749
{	public string interactionColliderName; // 0x18
	public SoundDefinition pressSoundDef; // 0x20


	public virtual void ClientUse(BasePlayer player, BaseVehicleModule parentModule) { }

	public virtual void ClientUpdateTick(BaseVehicleModule parentModule) { }

	protected void .ctor() { }

}

public class VehicleModuleEngine : VehicleModuleStorage // TypeDefIndex: 9750
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleModuleEngine.Engine engine; // 0x678
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsUsable>k__BackingField; // 0x680
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <PerformanceFractionAcceleration>k__BackingField; // 0x684
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <PerformanceFractionTopSpeed>k__BackingField; // 0x688
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <PerformanceFractionFuelEconomy>k__BackingField; // 0x68C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <OverallPerformanceFraction>k__BackingField; // 0x690
	private const float FORCE_MULTIPLIER = 12,75;
	private const float HEALTH_PERFORMANCE_FRACTION = 0,25;
	private const float LOW_PERFORMANCE_THRESHOLD = 0,5;
	private Sound badPerformanceLoop; // 0x698
	private SoundModulation.Modulator badPerformancePitchModulator; // 0x6A0
	private float prevSmokePercent; // 0x6A8

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IsUsable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_IsUsable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_PerformanceFractionAcceleration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_PerformanceFractionAcceleration(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_PerformanceFractionTopSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_PerformanceFractionTopSpeed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_PerformanceFractionFuelEconomy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_PerformanceFractionFuelEconomy(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_OverallPerformanceFraction() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	public override void ClientOnEnable() { }

	public override void ClientVehicleTick() { }

	private void PlayBadPerformanceSound() { }

	private void StopBadPerformanceSound() { }

	private void SetFXState(bool isOn) { }

	public void .ctor() { }

}

public class VehicleModuleEngine.Engine // TypeDefIndex: 9751
{	[HeaderAttribute] // RVA: 0x8EC10 Offset: 0x8E010 VA: 0x18008EC10
	public int engineKW; // 0x10
	public float idleFuelPerSec; // 0x14
	public float maxFuelPerSec; // 0x18
	[HeaderAttribute] // RVA: 0x8ECE0 Offset: 0x8E0E0 VA: 0x18008ECE0
	public EngineAudioSet audioSet; // 0x20
	[HeaderAttribute] // RVA: 0x8EE10 Offset: 0x8E210 VA: 0x18008EE10
	public ParticleSystemContainer[] engineParticles; // 0x28
	public ParticleSystem[] exhaustSmoke; // 0x30
	public ParticleSystem[] exhaustBackfire; // 0x38
	public float exhaustSmokeMinOpacity; // 0x40
	public float exhaustSmokeMaxOpacity; // 0x44
	public float exhaustSmokeChangeRate; // 0x48


	public void .ctor() { }

}

public class VehicleLight : MonoBehaviour, IClientComponent // TypeDefIndex: 9753
{	public bool IsBrake; // 0x18
	public GameObject toggleObject; // 0x20
	public VehicleLight.LightRenderer[] renderers; // 0x28
	[ColorUsageAttribute] // RVA: 0x859B0 Offset: 0x84DB0 VA: 0x1800859B0
	public Color lightOnColour; // 0x30
	[ColorUsageAttribute] // RVA: 0x859B0 Offset: 0x84DB0 VA: 0x1800859B0
	public Color brakesOnColour; // 0x40
	private static MaterialPropertyBlock materialPB; // 0x0
	private static int emissionColorID; // 0x8


	public void SetLightVisuals(bool headlightsOn, bool brakesOn) { }

	public static void SetLightVisuals(IReadOnlyList<VehicleLight> lights, bool headlightsOn, bool brakesOn) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class VehicleLight.LightRenderer // TypeDefIndex: 9754
{	public Renderer renderer; // 0x10
	public int matIndex; // 0x18


	public void .ctor() { }

}

public class EngineDamageOverTime // TypeDefIndex: 9761
{	private readonly List<EngineDamageOverTime.RecentDamage> recentDamage; // 0x10
	private readonly float maxSeconds; // 0x18
	private readonly float triggerDamage; // 0x1C
	private readonly Action trigger; // 0x20


	public void .ctor(float triggerDamage, float maxSeconds, Action trigger) { }

	public void TakeDamage(float amount) { }

	private float GetRecentDamage() { }

}

private struct EngineDamageOverTime.RecentDamage // TypeDefIndex: 9762
{	public readonly float time; // 0x0
	public readonly float amount; // 0x4


	public void .ctor(float time, float amount) { }

}

public abstract class VehicleChassisVisuals<T> : MonoBehaviour // TypeDefIndex: 9780
{	protected T owner; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleChassisVisuals.ClientWheelData<T>[] <clientWheelData>k__BackingField; // 0x0
	private float prevSteer; // 0x0
	private bool isStopped; // 0x0

	public VehicleChassisVisuals.ClientWheelData<T>[] clientWheelData { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public VehicleChassisVisuals.ClientWheelData<T>[] get_clientWheelData() { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<object>.get_clientWheelData
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static bool <UpdateWheelSuspensionData>g__GetSuspensionHit|17_0(Vector3 ts, out RaycastHit hit, ref VehicleChassisVisuals.<>c__DisplayClass17_0<T> ) { }
	/* GenericInstMethod :
	|
	|-VehicleChassisVisuals<object>.<UpdateWheelSuspensionData>g__GetSuspensionHit|17_0
	*/

}

public class VehicleChassisVisuals.ClientWheelData<T> // TypeDefIndex: 9782
{	public VisualCarWheel wheel; // 0x0
	public Vector3 vehicleLocalPos; // 0x0
	public Vector3 restingLocalPos; // 0x0
	public RaycastHit hit; // 0x0
	public bool isGrounded; // 0x0
	public bool isOnWater; // 0x0
	public float spinSlip; // 0x0
	public TerrainConfig.GroundType groundType; // 0x0
	public Vector3 latestWorldPos; // 0x0
	public float extension; // 0x0
	public float prevExtension; // 0x0
	public float extensionPercent; // 0x0
	public Sound sound; // 0x0
	public SoundModulation.Modulator gainModulator; // 0x0

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

private struct VehicleChassisVisuals.<>c__DisplayClass17_0<T> // TypeDefIndex: 9784
{	public Vector3 vehicleDown; // 0x0
	public float wheelRadius; // 0x0
	public float suspensionDistance; // 0x0

}

public class VehicleEngineController<TOwner> // TypeDefIndex: 9786
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EntityFuelSystem <FuelSystem>k__BackingField; // 0x0
	private readonly TOwner owner; // 0x0
	private readonly bool isServer; // 0x0
	private readonly float engineStartupTime; // 0x0
	private readonly Transform waterloggedPoint; // 0x0
	private readonly BaseEntity.Flags engineStartingFlag; // 0x0

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public EntityFuelSystem get_FuelSystem() { }
	/* GenericInstMethod :
	|
	|-VehicleEngineController<BaseSubmarine>.get_FuelSystem
	|-VehicleEngineController<GroundVehicle>.get_FuelSystem
	|-VehicleEngineController<MiniCopter>.get_FuelSystem
	|-VehicleEngineController<object>.get_FuelSystem
	|-VehicleEngineController<TrainEngine>.get_FuelSystem
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

public enum VehicleEngineController.EngineState<TOwner> // TypeDefIndex: 9787
{	public int value__; // 0x0
	public const VehicleEngineController.EngineState<TOwner> Off = 0;
	public const VehicleEngineController.EngineState<TOwner> Starting = 1;
	public const VehicleEngineController.EngineState<TOwner> On = 2;

}

public class VehicleSpawnPoint : SpaceCheckingSpawnPoint // TypeDefIndex: 10010
{
	public void .ctor() { }

}

public class EngineItemInformationPanel : ItemInformationPanel // TypeDefIndex: 11001
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Text tier; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase low; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase medium; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase high; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject accelerationRoot; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject topSpeedRoot; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject fuelEconomyRoot; // 0x48


	public override bool EligableForDisplay(ItemDefinition info) { }

	public override void SetupForItem(ItemDefinition info, Item item) { }

	public void .ctor() { }

}

public class VehicleEditingItemIcon : MonoBehaviour, IInventoryChanged // TypeDefIndex: 11060
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image foregroundImage; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image linkImage; // 0x20
	private ItemIcon itemIcon; // 0x28


	protected void Awake() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void OnInventoryChanged() { }

	private void InventoryChangeRefresh() { }

	private void SetLinkSprite(Sprite sprite) { }

	private void ClearLinkSprite() { }

	public void .ctor() { }

}

public class VehicleEditingPanel : LootPanel // TypeDefIndex: 11061
{	[SerializeField] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	[RangeAttribute] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
	private float disabledAlpha; // 0x38
	[HeaderAttribute] // RVA: 0x91940 Offset: 0x90D40 VA: 0x180091940
	[SerializeField] // RVA: 0x91940 Offset: 0x90D40 VA: 0x180091940
	private CanvasGroup editGroup; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject moduleInternalItemsGroup; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject moduleInternalLiquidsGroup; // 0x50
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject destroyChassisGroup; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Button itemTakeButton; // 0x60
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Button liquidTakeButton; // 0x68
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject liquidHelp; // 0x70
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject liquidButton; // 0x78
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color gotColor; // 0x80
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color notGotColor; // 0x90
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Text generalInfoText; // 0xA0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Text generalWarningText; // 0xA8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image generalWarningImage; // 0xB0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Text repairInfoText; // 0xB8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Button repairButton; // 0xC0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Text destroyChassisButtonText; // 0xC8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Text destroyChassisCountdown; // 0xD0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseEditingInfo; // 0xD8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseNoOccupant; // 0xE0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseBadOccupant; // 0xE8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseNotDriveable; // 0xF0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseNotRepairable; // 0xF8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseRepairNotNeeded; // 0x100
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseRepairSelectInfo; // 0x108
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseRepairEnactInfo; // 0x110
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseHasLock; // 0x118
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseHasNoLock; // 0x120
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseAddLock; // 0x128
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseAddKey; // 0x130
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseAddLockButton; // 0x138
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseCraftKeyButton; // 0x140
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Text carLockInfoText; // 0x148
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Text carLockButtonText; // 0x150
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Button actionLockButton; // 0x158
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Button removeLockButton; // 0x160
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Translate.Phrase phraseEmptyStorage; // 0x168
	[HeaderAttribute] // RVA: 0x94390 Offset: 0x93790 VA: 0x180094390
	[SerializeField] // RVA: 0x94390 Offset: 0x93790 VA: 0x180094390
	private VehicleEditingPanel.CreateChassisEntry[] chassisOptions; // 0x170
	private uint prevSelectedUID; // 0x178
	private bool platformWasOccupied; // 0x17C
	private bool hadEditableOccupant; // 0x17D
	private bool hasDriveableOccupant; // 0x17E
	private ModularCarGarage.OccupantLock occupantLockState; // 0x180
	private int occupantLockID; // 0x184

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <RefreshLockCreation>g__AddResourceInfo|72_0(string prefixText, ItemAmount ingredient, ref VehicleEditingPanel.<>c__DisplayClass72_0 ) { }

}

private class VehicleEditingPanel.CreateChassisEntry // TypeDefIndex: 11062
{	public byte garageChassisIndex; // 0x10
	public Button craftButton; // 0x18
	public Text craftButtonText; // 0x20
	public Text requirementsText; // 0x28


	public ItemDefinition GetChassisItemDef(ModularCarGarage garage) { }

	public void .ctor() { }

}

private struct VehicleEditingPanel.<>c__DisplayClass72_0 // TypeDefIndex: 11063
{	public VehicleEditingPanel <>4__this; // 0x0
	public string infoText; // 0x8

}

public class VehicleModuleInformationPanel : ItemInformationPanel // TypeDefIndex: 11064
{	public ItemStatValue socketsDisplay; // 0x18
	public ItemStatValue hpDisplay; // 0x20


	public override bool EligableForDisplay(ItemDefinition info) { }

	public override void SetupForItem(ItemDefinition info, Item item) { }

	public void .ctor() { }

}

public class vehicle : ConsoleSystem // TypeDefIndex: 11968
{
	public void .ctor() { }

}

public static class EngineItemTypeEx // TypeDefIndex: 12098
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static bool BoostsAcceleration(EngineStorage.EngineItemTypes engineItemType) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static bool BoostsTopSpeed(EngineStorage.EngineItemTypes engineItemType) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static bool BoostsFuelEconomy(EngineStorage.EngineItemTypes engineItemType) { }

}

public class EngineStorage : StorageContainer // TypeDefIndex: 12099
{	[HeaderAttribute] // RVA: 0xD90A0 Offset: 0xD84A0 VA: 0x1800D90A0
	public Sprite engineIcon; // 0x3D0
	public float internalDamageMultiplier; // 0x3D8
	public EngineStorage.EngineItemTypes[] slotTypes; // 0x3E0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleModuleEngineItems allEngineItems; // 0x3E8
	[SerializeField] // RVA: 0x93360 Offset: 0x92760 VA: 0x180093360
	[ReadOnlyAttribute] // RVA: 0x93360 Offset: 0x92760 VA: 0x180093360
	private int accelerationBoostSlots; // 0x3F0
	[SerializeField] // RVA: 0x93360 Offset: 0x92760 VA: 0x180093360
	[ReadOnlyAttribute] // RVA: 0x93360 Offset: 0x92760 VA: 0x180093360
	private int topSpeedBoostSlots; // 0x3F4
	[SerializeField] // RVA: 0x93360 Offset: 0x92760 VA: 0x180093360
	[ReadOnlyAttribute] // RVA: 0x93360 Offset: 0x92760 VA: 0x180093360
	private int fuelEconomyBoostSlots; // 0x3F8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <isUsable>k__BackingField; // 0x3FC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <accelerationBoostPercent>k__BackingField; // 0x400
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <topSpeedBoostPercent>k__BackingField; // 0x404
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <fuelEconomyBoostPercent>k__BackingField; // 0x408

	public bool isUsable { get; set; }
	public float accelerationBoostPercent { get; set; }
	public float topSpeedBoostPercent { get; set; }
	public float fuelEconomyBoostPercent { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_isUsable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_isUsable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_accelerationBoostPercent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_accelerationBoostPercent(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_topSpeedBoostPercent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_topSpeedBoostPercent(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_fuelEconomyBoostPercent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_fuelEconomyBoostPercent(float value) { }

	public VehicleModuleEngine GetEngineModule() { }

	public float GetAveragedLoadoutPercent() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override bool CanBeLooted(BasePlayer player) { }

	private int GetValidSlot(Item item) { }

	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	public void .ctor() { }

}

public enum EngineStorage.EngineItemTypes // TypeDefIndex: 12100
{	public int value__; // 0x0
	public const EngineStorage.EngineItemTypes Crankshaft = 0;
	public const EngineStorage.EngineItemTypes Carburetor = 1;
	public const EngineStorage.EngineItemTypes SparkPlug = 2;
	public const EngineStorage.EngineItemTypes Piston = 3;
	public const EngineStorage.EngineItemTypes Valve = 4;

}

public class ModularCarAudio : GroundVehicleAudio // TypeDefIndex: 12101
{	public bool showDebug; // 0x98
	[HeaderAttribute] // RVA: 0xDA0B0 Offset: 0xD94B0 VA: 0x1800DA0B0
	[SerializeField] // RVA: 0xDA0B0 Offset: 0xD94B0 VA: 0x1800DA0B0
	private SoundDefinition skidSoundLoop; // 0xA0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition skidSoundDirtLoop; // 0xA8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition skidSoundSnowLoop; // 0xB0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float skidMinSlip; // 0xB8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float skidMaxSlip; // 0xBC
	[HeaderAttribute] // RVA: 0xDA560 Offset: 0xD9960 VA: 0x1800DA560
	[SerializeField] // RVA: 0xDA560 Offset: 0xD9960 VA: 0x1800DA560
	private SoundDefinition movementStartOneshot; // 0xC0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition movementStopOneshot; // 0xC8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float movementStartStopMinTimeBetweenSounds; // 0xD0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition movementRattleLoop; // 0xD8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float movementRattleMaxSpeed; // 0xE0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float movementRattleMaxAngSpeed; // 0xE4
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float movementRattleIdleGain; // 0xE8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition suspensionLurchSound; // 0xF0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float suspensionLurchMinExtensionDelta; // 0xF8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float suspensionLurchMinTimeBetweenSounds; // 0xFC
	[HeaderAttribute] // RVA: 0xDADF0 Offset: 0xDA1F0 VA: 0x1800DADF0
	[SerializeField] // RVA: 0xDADF0 Offset: 0xDA1F0 VA: 0x1800DADF0
	private SoundDefinition tyreRollingSoundDef; // 0x100
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition tyreRollingWaterSoundDef; // 0x108
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition tyreRollingGrassSoundDef; // 0x110
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition tyreRollingSnowSoundDef; // 0x118
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AnimationCurve tyreRollGainCurve; // 0x120
	private EngineAudioSet currentEngineAudioSet; // 0x128
	private ModularCar modularCar; // 0x130
	private float skidRatio; // 0x138
	private Sound skidSound; // 0x140
	private SoundModulation.Modulator skidGain; // 0x148
	private const float SKID_RATIO_CHANGE_RATE = 12;
	private Dictionary<VehicleChassisVisuals.ClientWheelData<ModularCar>, float> prevWheelExtensionPercent; // 0x150
	private Dictionary<VehicleChassisVisuals.ClientWheelData<ModularCar>, bool> wheelWasGrounded; // 0x158
	private Dictionary<VehicleChassisVisuals.ClientWheelData<ModularCar>, float> lastSuspensionSoundPlayed; // 0x160
	private Dictionary<EngineAudioSet, byte> attachedEngineCounts; // 0x168
	private Sound movementRattleSound; // 0x170
	private SoundModulation.Modulator rattleGain; // 0x178
	private Quaternion prevRotation; // 0x180
	private bool wasStationary; // 0x190
	private float lastMovementStartSoundPlayed; // 0x194
	private float lastMovementStopSoundPlayed; // 0x198
	private float noMovementCount; // 0x19C

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

public class ModularVehicleSocket // TypeDefIndex: 12102
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform socketTransform; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ModularVehicleSocket.SocketWheelType wheelType; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ModularVehicleSocket.SocketLocationType locationType; // 0x1C

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

public enum ModularVehicleSocket.SocketWheelType // TypeDefIndex: 12103
{	public int value__; // 0x0
	public const ModularVehicleSocket.SocketWheelType NoWheel = 0;
	public const ModularVehicleSocket.SocketWheelType ForwardWheel = 1;
	public const ModularVehicleSocket.SocketWheelType BackWheel = 2;

}

public enum ModularVehicleSocket.SocketLocationType // TypeDefIndex: 12104
{	public int value__; // 0x0
	public const ModularVehicleSocket.SocketLocationType Middle = 0;
	public const ModularVehicleSocket.SocketLocationType Front = 1;
	public const ModularVehicleSocket.SocketLocationType Back = 2;

}

public class VehicleModuleEngineItems : ScriptableObject // TypeDefIndex: 12105
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ItemModEngineItem[] engineItems; // 0x18


	public bool TryGetItem(int tier, EngineStorage.EngineItemTypes type, out ItemModEngineItem output) { }

	public void .ctor() { }

}

public class VehicleModuleSlidingComponent // TypeDefIndex: 12106
{	public string interactionColliderName; // 0x10
	public BaseEntity.Flags flag_SliderOpen; // 0x18
	public float moveTime; // 0x1C
	public VehicleModuleSlidingComponent.SlidingPart[] slidingParts; // 0x20
	public SoundDefinition openSoundDef; // 0x28
	public SoundDefinition closeSoundDef; // 0x30
	private float positionPercent; // 0x38


	public bool WantsOpenPos(BaseEntity parentEntity) { }

	public void ClientUpdateTick(BaseVehicleModule parentModule) { }

	private void PlaySounds(bool wantsOpenPos) { }

	private void CheckPosition(BaseEntity parentEntity, float dt) { }

	public void .ctor() { }

}

public class VehicleModuleSlidingComponent.SlidingPart // TypeDefIndex: 12107
{	public Transform transform; // 0x10
	public Vector3 openPosition; // 0x18
	public Vector3 closedPosition; // 0x24


	public void .ctor() { }

}

