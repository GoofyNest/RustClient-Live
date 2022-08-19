public class BaseVehicle : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6327
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<BaseVehicle.MountPoint> mountPoints; // 0x18

	// Methods

	// RVA: 0x1F65B10 Offset: 0x1F64F10 VA: 0x181F65B10
	public static void ResetToPool(BaseVehicle instance) { }

	// RVA: 0x1F65960 Offset: 0x1F64D60 VA: 0x181F65960
	public void ResetToPool() { }

	// RVA: 0x1F656E0 Offset: 0x1F64AE0 VA: 0x181F656E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F64860 Offset: 0x1F63C60 VA: 0x181F64860
	public void CopyTo(BaseVehicle instance) { }

	// RVA: 0x1F649F0 Offset: 0x1F63DF0 VA: 0x181F649F0
	public BaseVehicle Copy() { }

	// RVA: 0x1F65470 Offset: 0x1F64870 VA: 0x181F65470
	public static BaseVehicle Deserialize(Stream stream) { }

	// RVA: 0x1F64EA0 Offset: 0x1F642A0 VA: 0x181F64EA0
	public static BaseVehicle DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F64F20 Offset: 0x1F64320 VA: 0x181F64F20
	public static BaseVehicle DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F65350 Offset: 0x1F64750 VA: 0x181F65350
	public static BaseVehicle Deserialize(byte[] buffer) { }

	// RVA: 0x1F65920 Offset: 0x1F64D20 VA: 0x181F65920
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F66250 Offset: 0x1F65650 VA: 0x181F66250 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F66270 Offset: 0x1F65670 VA: 0x181F66270 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseVehicle previous) { }

	// RVA: 0x1F65940 Offset: 0x1F64D40 VA: 0x181F65940 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F65250 Offset: 0x1F64650 VA: 0x181F65250
	public static BaseVehicle Deserialize(byte[] buffer, BaseVehicle instance, bool isDelta = False) { }

	// RVA: 0x1F654F0 Offset: 0x1F648F0 VA: 0x181F654F0
	public static BaseVehicle Deserialize(Stream stream, BaseVehicle instance, bool isDelta) { }

	// RVA: 0x1F64BD0 Offset: 0x1F63FD0 VA: 0x181F64BD0
	public static BaseVehicle DeserializeLengthDelimited(Stream stream, BaseVehicle instance, bool isDelta) { }

	// RVA: 0x1F64FB0 Offset: 0x1F643B0 VA: 0x181F64FB0
	public static BaseVehicle DeserializeLength(Stream stream, int length, BaseVehicle instance, bool isDelta) { }

	// RVA: 0x1F65CC0 Offset: 0x1F650C0 VA: 0x181F65CC0
	public static void SerializeDelta(Stream stream, BaseVehicle instance, BaseVehicle previous) { }

	// RVA: 0x1F66060 Offset: 0x1F65460 VA: 0x181F66060
	public static void Serialize(Stream stream, BaseVehicle instance) { }

	// RVA: 0x1F66240 Offset: 0x1F65640 VA: 0x181F66240
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F66250 Offset: 0x1F65650 VA: 0x181F66250
	public void ToProto(Stream stream) { }

	// RVA: 0x1F65F50 Offset: 0x1F65350 VA: 0x181F65F50
	public static byte[] SerializeToBytes(BaseVehicle instance) { }

	// RVA: 0x1F65EA0 Offset: 0x1F652A0 VA: 0x181F65EA0
	public static void SerializeLengthDelimited(Stream stream, BaseVehicle instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class BaseVehicle.MountPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6328
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int index; // 0x14
	public uint mountableId; // 0x18

	// Methods

	// RVA: 0x1F77B70 Offset: 0x1F76F70 VA: 0x181F77B70
	public static void ResetToPool(BaseVehicle.MountPoint instance) { }

	// RVA: 0x1F77AF0 Offset: 0x1F76EF0 VA: 0x181F77AF0
	public void ResetToPool() { }

	// RVA: 0x1F778D0 Offset: 0x1F76CD0 VA: 0x181F778D0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB9660 Offset: 0x1DB8A60 VA: 0x181DB9660
	public void CopyTo(BaseVehicle.MountPoint instance) { }

	// RVA: 0x1F76AD0 Offset: 0x1F75ED0 VA: 0x181F76AD0
	public BaseVehicle.MountPoint Copy() { }

	// RVA: 0x1F77250 Offset: 0x1F76650 VA: 0x181F77250
	public static BaseVehicle.MountPoint Deserialize(Stream stream) { }

	// RVA: 0x1F76D90 Offset: 0x1F76190 VA: 0x181F76D90
	public static BaseVehicle.MountPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F76E10 Offset: 0x1F76210 VA: 0x181F76E10
	public static BaseVehicle.MountPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F77410 Offset: 0x1F76810 VA: 0x181F77410
	public static BaseVehicle.MountPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F77950 Offset: 0x1F76D50 VA: 0x181F77950
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F78030 Offset: 0x1F77430 VA: 0x181F78030 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F78050 Offset: 0x1F77450 VA: 0x181F78050 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseVehicle.MountPoint previous) { }

	// RVA: 0x1F77AD0 Offset: 0x1F76ED0 VA: 0x181F77AD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F77680 Offset: 0x1F76A80 VA: 0x181F77680
	public static BaseVehicle.MountPoint Deserialize(byte[] buffer, BaseVehicle.MountPoint instance, bool isDelta = False) { }

	// RVA: 0x1F770D0 Offset: 0x1F764D0 VA: 0x181F770D0
	public static BaseVehicle.MountPoint Deserialize(Stream stream, BaseVehicle.MountPoint instance, bool isDelta) { }

	// RVA: 0x1F76B40 Offset: 0x1F75F40 VA: 0x181F76B40
	public static BaseVehicle.MountPoint DeserializeLengthDelimited(Stream stream, BaseVehicle.MountPoint instance, bool isDelta) { }

	// RVA: 0x1F76EA0 Offset: 0x1F762A0 VA: 0x181F76EA0
	public static BaseVehicle.MountPoint DeserializeLength(Stream stream, int length, BaseVehicle.MountPoint instance, bool isDelta) { }

	// RVA: 0x1F77BF0 Offset: 0x1F76FF0 VA: 0x181F77BF0
	public static void SerializeDelta(Stream stream, BaseVehicle.MountPoint instance, BaseVehicle.MountPoint previous) { }

	// RVA: 0x1F77F20 Offset: 0x1F77320 VA: 0x181F77F20
	public static void Serialize(Stream stream, BaseVehicle.MountPoint instance) { }

	// RVA: 0x1F78020 Offset: 0x1F77420 VA: 0x181F78020
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F78030 Offset: 0x1F77430 VA: 0x181F78030
	public void ToProto(Stream stream) { }

	// RVA: 0x1F77E10 Offset: 0x1F77210 VA: 0x181F77E10
	public static byte[] SerializeToBytes(BaseVehicle.MountPoint instance) { }

	// RVA: 0x1F77D60 Offset: 0x1F77160 VA: 0x181F77D60
	public static void SerializeLengthDelimited(Stream stream, BaseVehicle.MountPoint instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class Motorboat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6346
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint storageid; // 0x14
	public uint fuelStorageID; // 0x18

	// Methods

	// RVA: 0x1F85FF0 Offset: 0x1F853F0 VA: 0x181F85FF0
	public static void ResetToPool(Motorboat instance) { }

	// RVA: 0x1F85F70 Offset: 0x1F85370 VA: 0x181F85F70
	public void ResetToPool() { }

	// RVA: 0x1F85CD0 Offset: 0x1F850D0 VA: 0x181F85CD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB9660 Offset: 0x1DB8A60 VA: 0x181DB9660
	public void CopyTo(Motorboat instance) { }

	// RVA: 0x1F84ED0 Offset: 0x1F842D0 VA: 0x181F84ED0
	public Motorboat Copy() { }

	// RVA: 0x1F85B10 Offset: 0x1F84F10 VA: 0x181F85B10
	public static Motorboat Deserialize(Stream stream) { }

	// RVA: 0x1F84F40 Offset: 0x1F84340 VA: 0x181F84F40
	public static Motorboat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F85440 Offset: 0x1F84840 VA: 0x181F85440
	public static Motorboat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F854D0 Offset: 0x1F848D0 VA: 0x181F854D0
	public static Motorboat Deserialize(byte[] buffer) { }

	// RVA: 0x1F85DD0 Offset: 0x1F851D0 VA: 0x181F85DD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F864B0 Offset: 0x1F858B0 VA: 0x181F864B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F864D0 Offset: 0x1F858D0 VA: 0x181F864D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Motorboat previous) { }

	// RVA: 0x1F85F50 Offset: 0x1F85350 VA: 0x181F85F50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F858C0 Offset: 0x1F84CC0 VA: 0x181F858C0
	public static Motorboat Deserialize(byte[] buffer, Motorboat instance, bool isDelta = False) { }

	// RVA: 0x1F85740 Offset: 0x1F84B40 VA: 0x181F85740
	public static Motorboat Deserialize(Stream stream, Motorboat instance, bool isDelta) { }

	// RVA: 0x1F84FC0 Offset: 0x1F843C0 VA: 0x181F84FC0
	public static Motorboat DeserializeLengthDelimited(Stream stream, Motorboat instance, bool isDelta) { }

	// RVA: 0x1F85210 Offset: 0x1F84610 VA: 0x181F85210
	public static Motorboat DeserializeLength(Stream stream, int length, Motorboat instance, bool isDelta) { }

	// RVA: 0x1F86070 Offset: 0x1F85470 VA: 0x181F86070
	public static void SerializeDelta(Stream stream, Motorboat instance, Motorboat previous) { }

	// RVA: 0x1F863A0 Offset: 0x1F857A0 VA: 0x181F863A0
	public static void Serialize(Stream stream, Motorboat instance) { }

	// RVA: 0x1F864A0 Offset: 0x1F858A0 VA: 0x181F864A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F864B0 Offset: 0x1F858B0 VA: 0x181F864B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F86290 Offset: 0x1F85690 VA: 0x181F86290
	public static byte[] SerializeToBytes(Motorboat instance) { }

	// RVA: 0x1F861E0 Offset: 0x1F855E0 VA: 0x181F861E0
	public static void SerializeLengthDelimited(Stream stream, Motorboat instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ModularVehicle : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6348
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool editable; // 0x12

	// Methods

	// RVA: 0x1F82A60 Offset: 0x1F81E60 VA: 0x181F82A60
	public static void ResetToPool(ModularVehicle instance) { }

	// RVA: 0x1F829E0 Offset: 0x1F81DE0 VA: 0x181F829E0
	public void ResetToPool() { }

	// RVA: 0x1F828B0 Offset: 0x1F81CB0 VA: 0x181F828B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E13F00 Offset: 0x1E13300 VA: 0x181E13F00
	public void CopyTo(ModularVehicle instance) { }

	// RVA: 0x1F81F30 Offset: 0x1F81330 VA: 0x181F81F30
	public ModularVehicle Copy() { }

	// RVA: 0x1F82830 Offset: 0x1F81C30 VA: 0x181F82830
	public static ModularVehicle Deserialize(Stream stream) { }

	// RVA: 0x1F81FA0 Offset: 0x1F813A0 VA: 0x181F81FA0
	public static ModularVehicle DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F82240 Offset: 0x1F81640 VA: 0x181F82240
	public static ModularVehicle DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F82710 Offset: 0x1F81B10 VA: 0x181F82710
	public static ModularVehicle Deserialize(byte[] buffer) { }

	// RVA: 0x1F829A0 Offset: 0x1F81DA0 VA: 0x181F829A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F82EF0 Offset: 0x1F822F0 VA: 0x181F82EF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F82FC0 Offset: 0x1F823C0 VA: 0x181F82FC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModularVehicle previous) { }

	// RVA: 0x1F829C0 Offset: 0x1F81DC0 VA: 0x181F829C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F824D0 Offset: 0x1F818D0 VA: 0x181F824D0
	public static ModularVehicle Deserialize(byte[] buffer, ModularVehicle instance, bool isDelta = False) { }

	// RVA: 0x1F825D0 Offset: 0x1F819D0 VA: 0x181F825D0
	public static ModularVehicle Deserialize(Stream stream, ModularVehicle instance, bool isDelta) { }

	// RVA: 0x1F82020 Offset: 0x1F81420 VA: 0x181F82020
	public static ModularVehicle DeserializeLengthDelimited(Stream stream, ModularVehicle instance, bool isDelta) { }

	// RVA: 0x1F822D0 Offset: 0x1F816D0 VA: 0x181F822D0
	public static ModularVehicle DeserializeLength(Stream stream, int length, ModularVehicle instance, bool isDelta) { }

	// RVA: 0x1F82AE0 Offset: 0x1F81EE0 VA: 0x181F82AE0
	public static void SerializeDelta(Stream stream, ModularVehicle instance, ModularVehicle previous) { }

	// RVA: 0x1F82E10 Offset: 0x1F82210 VA: 0x181F82E10
	public static void Serialize(Stream stream, ModularVehicle instance) { }

	// RVA: 0x1F82EE0 Offset: 0x1F822E0 VA: 0x181F82EE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F82EF0 Offset: 0x1F822F0 VA: 0x181F82EF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F82C60 Offset: 0x1F82060 VA: 0x181F82C60
	public static byte[] SerializeToBytes(ModularVehicle instance) { }

	// RVA: 0x1F82BB0 Offset: 0x1F81FB0 VA: 0x181F82BB0
	public static void SerializeLengthDelimited(Stream stream, ModularVehicle instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ModularCar : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6349
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float steerAngle; // 0x14
	public float driveWheelVel; // 0x18
	public float throttleInput; // 0x1C
	public float brakeInput; // 0x20
	public uint fuelStorageID; // 0x24
	public float fuelFraction; // 0x28
	public int lockID; // 0x2C

	// Methods

	// RVA: 0x1F81750 Offset: 0x1F80B50 VA: 0x181F81750
	public static void ResetToPool(ModularCar instance) { }

	// RVA: 0x1F81680 Offset: 0x1F80A80 VA: 0x181F81680
	public void ResetToPool() { }

	// RVA: 0x1F80EC0 Offset: 0x1F802C0 VA: 0x181F80EC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DAE0C0 Offset: 0x1DAD4C0 VA: 0x181DAE0C0
	public void CopyTo(ModularCar instance) { }

	// RVA: 0x1F7F4B0 Offset: 0x1F7E8B0 VA: 0x181F7F4B0
	public ModularCar Copy() { }

	// RVA: 0x1F808C0 Offset: 0x1F7FCC0 VA: 0x181F808C0
	public static ModularCar Deserialize(Stream stream) { }

	// RVA: 0x1F7F900 Offset: 0x1F7ED00 VA: 0x181F7F900
	public static ModularCar DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F7FD20 Offset: 0x1F7F120 VA: 0x181F7FD20
	public static ModularCar DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F804D0 Offset: 0x1F7F8D0 VA: 0x181F804D0
	public static ModularCar Deserialize(byte[] buffer) { }

	// RVA: 0x1F81010 Offset: 0x1F80410 VA: 0x181F81010
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F81EF0 Offset: 0x1F812F0 VA: 0x181F81EF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F81F10 Offset: 0x1F81310 VA: 0x181F81F10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ModularCar previous) { }

	// RVA: 0x1F812F0 Offset: 0x1F806F0 VA: 0x181F812F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F80100 Offset: 0x1F7F500 VA: 0x181F80100
	public static ModularCar Deserialize(byte[] buffer, ModularCar instance, bool isDelta = False) { }

	// RVA: 0x1F80BE0 Offset: 0x1F7FFE0 VA: 0x181F80BE0
	public static ModularCar Deserialize(Stream stream, ModularCar instance, bool isDelta) { }

	// RVA: 0x1F7F540 Offset: 0x1F7E940 VA: 0x181F7F540
	public static ModularCar DeserializeLengthDelimited(Stream stream, ModularCar instance, bool isDelta) { }

	// RVA: 0x1F7F980 Offset: 0x1F7ED80 VA: 0x181F7F980
	public static ModularCar DeserializeLength(Stream stream, int length, ModularCar instance, bool isDelta) { }

	// RVA: 0x1F81820 Offset: 0x1F80C20 VA: 0x181F81820
	public static void SerializeDelta(Stream stream, ModularCar instance, ModularCar previous) { }

	// RVA: 0x1F81D20 Offset: 0x1F81120 VA: 0x181F81D20
	public static void Serialize(Stream stream, ModularCar instance) { }

	// RVA: 0x1F81EE0 Offset: 0x1F812E0 VA: 0x181F81EE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F81EF0 Offset: 0x1F812F0 VA: 0x181F81EF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F81C10 Offset: 0x1F81010 VA: 0x181F81C10
	public static byte[] SerializeToBytes(ModularCar instance) { }

	// RVA: 0x1F81B60 Offset: 0x1F80F60 VA: 0x181F81B60
	public static void SerializeLengthDelimited(Stream stream, ModularCar instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class VehicleLift : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6352
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool platformIsOccupied; // 0x12
	public bool editableOccupant; // 0x13
	public bool driveableOccupant; // 0x14
	public int occupantLockState; // 0x18
	public int occupantLockID; // 0x1C

	// Methods

	// RVA: 0x1EF5DD0 Offset: 0x1EF51D0 VA: 0x181EF5DD0
	public static void ResetToPool(VehicleLift instance) { }

	// RVA: 0x1EF5E80 Offset: 0x1EF5280 VA: 0x181EF5E80
	public void ResetToPool() { }

	// RVA: 0x1EF5A20 Offset: 0x1EF4E20 VA: 0x181EF5A20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF46D0 Offset: 0x1EF3AD0 VA: 0x181EF46D0
	public void CopyTo(VehicleLift instance) { }

	// RVA: 0x1EF4710 Offset: 0x1EF3B10 VA: 0x181EF4710
	public VehicleLift Copy() { }

	// RVA: 0x1EF51F0 Offset: 0x1EF45F0 VA: 0x181EF51F0
	public static VehicleLift Deserialize(Stream stream) { }

	// RVA: 0x1EF4790 Offset: 0x1EF3B90 VA: 0x181EF4790
	public static VehicleLift DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF4E30 Offset: 0x1EF4230 VA: 0x181EF4E30
	public static VehicleLift DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF56D0 Offset: 0x1EF4AD0 VA: 0x181EF56D0
	public static VehicleLift Deserialize(byte[] buffer) { }

	// RVA: 0x1EF5B60 Offset: 0x1EF4F60 VA: 0x181EF5B60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF6460 Offset: 0x1EF5860 VA: 0x181EF6460 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF6480 Offset: 0x1EF5880 VA: 0x181EF6480 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleLift previous) { }

	// RVA: 0x1EF5DB0 Offset: 0x1EF51B0 VA: 0x181EF5DB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF4EC0 Offset: 0x1EF42C0 VA: 0x181EF4EC0
	public static VehicleLift Deserialize(byte[] buffer, VehicleLift instance, bool isDelta = False) { }

	// RVA: 0x1EF5480 Offset: 0x1EF4880 VA: 0x181EF5480
	public static VehicleLift Deserialize(Stream stream, VehicleLift instance, bool isDelta) { }

	// RVA: 0x1EF4810 Offset: 0x1EF3C10 VA: 0x181EF4810
	public static VehicleLift DeserializeLengthDelimited(Stream stream, VehicleLift instance, bool isDelta) { }

	// RVA: 0x1EF4B30 Offset: 0x1EF3F30 VA: 0x181EF4B30
	public static VehicleLift DeserializeLength(Stream stream, int length, VehicleLift instance, bool isDelta) { }

	// RVA: 0x1EF5F30 Offset: 0x1EF5330 VA: 0x181EF5F30
	public static void SerializeDelta(Stream stream, VehicleLift instance, VehicleLift previous) { }

	// RVA: 0x1EF62E0 Offset: 0x1EF56E0 VA: 0x181EF62E0
	public static void Serialize(Stream stream, VehicleLift instance) { }

	// RVA: 0x1EF6450 Offset: 0x1EF5850 VA: 0x181EF6450
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF6460 Offset: 0x1EF5860 VA: 0x181EF6460
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF61D0 Offset: 0x1EF55D0 VA: 0x181EF61D0
	public static byte[] SerializeToBytes(VehicleLift instance) { }

	// RVA: 0x1EF6120 Offset: 0x1EF5520 VA: 0x181EF6120
	public static void SerializeLengthDelimited(Stream stream, VehicleLift instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class EngineStorage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6353
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool isUsable; // 0x12
	public float accelerationBoost; // 0x14
	public float topSpeedBoost; // 0x18
	public float fuelEconomyBoost; // 0x1C

	// Methods

	// RVA: 0x1E6FF50 Offset: 0x1E6F350 VA: 0x181E6FF50
	public static void ResetToPool(EngineStorage instance) { }

	// RVA: 0x1E6FFF0 Offset: 0x1E6F3F0 VA: 0x181E6FFF0
	public void ResetToPool() { }

	// RVA: 0x1E6FBF0 Offset: 0x1E6EFF0 VA: 0x181E6FBF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E6E9F0 Offset: 0x1E6DDF0 VA: 0x181E6E9F0
	public void CopyTo(EngineStorage instance) { }

	// RVA: 0x1E6EA20 Offset: 0x1E6DE20 VA: 0x181E6EA20
	public EngineStorage Copy() { }

	// RVA: 0x1E6F170 Offset: 0x1E6E570 VA: 0x181E6F170
	public static EngineStorage Deserialize(Stream stream) { }

	// RVA: 0x1E6ED90 Offset: 0x1E6E190 VA: 0x181E6ED90
	public static EngineStorage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E6EE10 Offset: 0x1E6E210 VA: 0x181E6EE10
	public static EngineStorage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E6F6C0 Offset: 0x1E6EAC0 VA: 0x181E6F6C0
	public static EngineStorage Deserialize(byte[] buffer) { }

	// RVA: 0x1E6FD10 Offset: 0x1E6F110 VA: 0x181E6FD10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E705C0 Offset: 0x1E6F9C0 VA: 0x181E705C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E705E0 Offset: 0x1E6F9E0 VA: 0x181E705E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, EngineStorage previous) { }

	// RVA: 0x1E6FF30 Offset: 0x1E6F330 VA: 0x181E6FF30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E6F3D0 Offset: 0x1E6E7D0 VA: 0x181E6F3D0
	public static EngineStorage Deserialize(byte[] buffer, EngineStorage instance, bool isDelta = False) { }

	// RVA: 0x1E6F9D0 Offset: 0x1E6EDD0 VA: 0x181E6F9D0
	public static EngineStorage Deserialize(Stream stream, EngineStorage instance, bool isDelta) { }

	// RVA: 0x1E6EAA0 Offset: 0x1E6DEA0 VA: 0x181E6EAA0
	public static EngineStorage DeserializeLengthDelimited(Stream stream, EngineStorage instance, bool isDelta) { }

	// RVA: 0x1E6EEA0 Offset: 0x1E6E2A0 VA: 0x181E6EEA0
	public static EngineStorage DeserializeLength(Stream stream, int length, EngineStorage instance, bool isDelta) { }

	// RVA: 0x1E70090 Offset: 0x1E6F490 VA: 0x181E70090
	public static void SerializeDelta(Stream stream, EngineStorage instance, EngineStorage previous) { }

	// RVA: 0x1E70460 Offset: 0x1E6F860 VA: 0x181E70460
	public static void Serialize(Stream stream, EngineStorage instance) { }

	// RVA: 0x1E705B0 Offset: 0x1E6F9B0 VA: 0x181E705B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E705C0 Offset: 0x1E6F9C0 VA: 0x181E705C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E70350 Offset: 0x1E6F750 VA: 0x181E70350
	public static byte[] SerializeToBytes(EngineStorage instance) { }

	// RVA: 0x1E702A0 Offset: 0x1E6F6A0 VA: 0x181E702A0
	public static void SerializeLengthDelimited(Stream stream, EngineStorage instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class VehicleVendor : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6378
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VehicleVendor.PlayerStorage> playerStorage; // 0x18
	public uint spawnerRef; // 0x20

	// Methods

	// RVA: 0x1EF8740 Offset: 0x1EF7B40 VA: 0x181EF8740
	public static void ResetToPool(VehicleVendor instance) { }

	// RVA: 0x1EF8920 Offset: 0x1EF7D20 VA: 0x181EF8920
	public void ResetToPool() { }

	// RVA: 0x1EF8680 Offset: 0x1EF7A80 VA: 0x181EF8680 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF7720 Offset: 0x1EF6B20 VA: 0x181EF7720
	public void CopyTo(VehicleVendor instance) { }

	// RVA: 0x1EF78C0 Offset: 0x1EF6CC0 VA: 0x181EF78C0
	public VehicleVendor Copy() { }

	// RVA: 0x1EF8500 Offset: 0x1EF7900 VA: 0x181EF8500
	public static VehicleVendor Deserialize(Stream stream) { }

	// RVA: 0x1EF7DC0 Offset: 0x1EF71C0 VA: 0x181EF7DC0
	public static VehicleVendor DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF8120 Offset: 0x1EF7520 VA: 0x181EF8120
	public static VehicleVendor DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF81B0 Offset: 0x1EF75B0 VA: 0x181EF81B0
	public static VehicleVendor Deserialize(byte[] buffer) { }

	// RVA: 0x1EF8700 Offset: 0x1EF7B00 VA: 0x181EF8700
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF9150 Offset: 0x1EF8550 VA: 0x181EF9150 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF9170 Offset: 0x1EF8570 VA: 0x181EF9170 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleVendor previous) { }

	// RVA: 0x1EF8720 Offset: 0x1EF7B20 VA: 0x181EF8720 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF8580 Offset: 0x1EF7980 VA: 0x181EF8580
	public static VehicleVendor Deserialize(byte[] buffer, VehicleVendor instance, bool isDelta = False) { }

	// RVA: 0x1EF82D0 Offset: 0x1EF76D0 VA: 0x181EF82D0
	public static VehicleVendor Deserialize(Stream stream, VehicleVendor instance, bool isDelta) { }

	// RVA: 0x1EF7AB0 Offset: 0x1EF6EB0 VA: 0x181EF7AB0
	public static VehicleVendor DeserializeLengthDelimited(Stream stream, VehicleVendor instance, bool isDelta) { }

	// RVA: 0x1EF7E40 Offset: 0x1EF7240 VA: 0x181EF7E40
	public static VehicleVendor DeserializeLength(Stream stream, int length, VehicleVendor instance, bool isDelta) { }

	// RVA: 0x1EF8B00 Offset: 0x1EF7F00 VA: 0x181EF8B00
	public static void SerializeDelta(Stream stream, VehicleVendor instance, VehicleVendor previous) { }

	// RVA: 0x1EF8F10 Offset: 0x1EF8310 VA: 0x181EF8F10
	public static void Serialize(Stream stream, VehicleVendor instance) { }

	// RVA: 0x1EF9140 Offset: 0x1EF8540 VA: 0x181EF9140
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF9150 Offset: 0x1EF8550 VA: 0x181EF9150
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF8E00 Offset: 0x1EF8200 VA: 0x181EF8E00
	public static byte[] SerializeToBytes(VehicleVendor instance) { }

	// RVA: 0x1EF8D50 Offset: 0x1EF8150 VA: 0x181EF8D50
	public static void SerializeLengthDelimited(Stream stream, VehicleVendor instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class VehicleVendor.PlayerStorage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6379
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong userid; // 0x18
	public List<VehicleVendor.PlayerStorage.PlayerStoredVehicle> storedVehicles; // 0x20

	// Methods

	// RVA: 0x1EE1A20 Offset: 0x1EE0E20 VA: 0x181EE1A20
	public static void ResetToPool(VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1EE1BE0 Offset: 0x1EE0FE0 VA: 0x181EE1BE0
	public void ResetToPool() { }

	// RVA: 0x1EE1960 Offset: 0x1EE0D60 VA: 0x181EE1960 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EE0B60 Offset: 0x1EDFF60 VA: 0x181EE0B60
	public void CopyTo(VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1EE0D10 Offset: 0x1EE0110 VA: 0x181EE0D10
	public VehicleVendor.PlayerStorage Copy() { }

	// RVA: 0x1EE16C0 Offset: 0x1EE0AC0 VA: 0x181EE16C0
	public static VehicleVendor.PlayerStorage Deserialize(Stream stream) { }

	// RVA: 0x1EE10A0 Offset: 0x1EE04A0 VA: 0x181EE10A0
	public static VehicleVendor.PlayerStorage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EE1120 Offset: 0x1EE0520 VA: 0x181EE1120
	public static VehicleVendor.PlayerStorage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EE1740 Offset: 0x1EE0B40 VA: 0x181EE1740
	public static VehicleVendor.PlayerStorage Deserialize(byte[] buffer) { }

	// RVA: 0x1EE19E0 Offset: 0x1EE0DE0 VA: 0x181EE19E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EE23D0 Offset: 0x1EE17D0 VA: 0x181EE23D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EE23F0 Offset: 0x1EE17F0 VA: 0x181EE23F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleVendor.PlayerStorage previous) { }

	// RVA: 0x1EE1A00 Offset: 0x1EE0E00 VA: 0x181EE1A00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EE1860 Offset: 0x1EE0C60 VA: 0x181EE1860
	public static VehicleVendor.PlayerStorage Deserialize(byte[] buffer, VehicleVendor.PlayerStorage instance, bool isDelta = False) { }

	// RVA: 0x1EE1490 Offset: 0x1EE0890 VA: 0x181EE1490
	public static VehicleVendor.PlayerStorage Deserialize(Stream stream, VehicleVendor.PlayerStorage instance, bool isDelta) { }

	// RVA: 0x1EE0D90 Offset: 0x1EE0190 VA: 0x181EE0D90
	public static VehicleVendor.PlayerStorage DeserializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage instance, bool isDelta) { }

	// RVA: 0x1EE11B0 Offset: 0x1EE05B0 VA: 0x181EE11B0
	public static VehicleVendor.PlayerStorage DeserializeLength(Stream stream, int length, VehicleVendor.PlayerStorage instance, bool isDelta) { }

	// RVA: 0x1EE1DA0 Offset: 0x1EE11A0 VA: 0x181EE1DA0
	public static void SerializeDelta(Stream stream, VehicleVendor.PlayerStorage instance, VehicleVendor.PlayerStorage previous) { }

	// RVA: 0x1EE21A0 Offset: 0x1EE15A0 VA: 0x181EE21A0
	public static void Serialize(Stream stream, VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1EE23C0 Offset: 0x1EE17C0 VA: 0x181EE23C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EE23D0 Offset: 0x1EE17D0 VA: 0x181EE23D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EE2090 Offset: 0x1EE1490 VA: 0x181EE2090
	public static byte[] SerializeToBytes(VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x1EE1FE0 Offset: 0x1EE13E0 VA: 0x181EE1FE0
	public static void SerializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class VehicleVendor.PlayerStorage.PlayerStoredVehicle : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6380
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string shortname; // 0x18
	public string resourcePath; // 0x20
	public float health; // 0x28

	// Methods

	// RVA: 0x1EE37B0 Offset: 0x1EE2BB0 VA: 0x181EE37B0
	public static void ResetToPool(VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1EE36E0 Offset: 0x1EE2AE0 VA: 0x181EE36E0
	public void ResetToPool() { }

	// RVA: 0x1EE3470 Offset: 0x1EE2870 VA: 0x181EE3470 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EE2410 Offset: 0x1EE1810 VA: 0x181EE2410
	public void CopyTo(VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1EE2460 Offset: 0x1EE1860 VA: 0x181EE2460
	public VehicleVendor.PlayerStorage.PlayerStoredVehicle Copy() { }

	// RVA: 0x1EE2FA0 Offset: 0x1EE23A0 VA: 0x181EE2FA0
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(Stream stream) { }

	// RVA: 0x1EE27A0 Offset: 0x1EE1BA0 VA: 0x181EE27A0
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EE2AA0 Offset: 0x1EE1EA0 VA: 0x181EE2AA0
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EE31B0 Offset: 0x1EE25B0 VA: 0x181EE31B0
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(byte[] buffer) { }

	// RVA: 0x1EE34F0 Offset: 0x1EE28F0 VA: 0x181EE34F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EE3E10 Offset: 0x1EE3210 VA: 0x181EE3E10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EE3E30 Offset: 0x1EE3230 VA: 0x181EE3E30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle previous) { }

	// RVA: 0x1EE36C0 Offset: 0x1EE2AC0 VA: 0x181EE36C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EE2B30 Offset: 0x1EE1F30 VA: 0x181EE2B30
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(byte[] buffer, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta = False) { }

	// RVA: 0x1EE2DD0 Offset: 0x1EE21D0 VA: 0x181EE2DD0
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle Deserialize(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta) { }

	// RVA: 0x1EE2500 Offset: 0x1EE1900 VA: 0x181EE2500
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta) { }

	// RVA: 0x1EE2820 Offset: 0x1EE1C20 VA: 0x181EE2820
	public static VehicleVendor.PlayerStorage.PlayerStoredVehicle DeserializeLength(Stream stream, int length, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, bool isDelta) { }

	// RVA: 0x1EE3880 Offset: 0x1EE2C80 VA: 0x181EE3880
	public static void SerializeDelta(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance, VehicleVendor.PlayerStorage.PlayerStoredVehicle previous) { }

	// RVA: 0x1EE3C50 Offset: 0x1EE3050 VA: 0x181EE3C50
	public static void Serialize(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1EE3E00 Offset: 0x1EE3200 VA: 0x181EE3E00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EE3E10 Offset: 0x1EE3210 VA: 0x181EE3E10
	public void ToProto(Stream stream) { }

	// RVA: 0x1EE3B40 Offset: 0x1EE2F40 VA: 0x181EE3B40
	public static byte[] SerializeToBytes(VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x1EE3A90 Offset: 0x1EE2E90 VA: 0x181EE3A90
	public static void SerializeLengthDelimited(Stream stream, VehicleVendor.PlayerStorage.PlayerStoredVehicle instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class VehicleModule : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6385
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int socketIndex; // 0x14

	// Methods

	// RVA: 0x1EF6F50 Offset: 0x1EF6350 VA: 0x181EF6F50
	public static void ResetToPool(VehicleModule instance) { }

	// RVA: 0x1EF6FD0 Offset: 0x1EF63D0 VA: 0x181EF6FD0
	public void ResetToPool() { }

	// RVA: 0x1EF6E20 Offset: 0x1EF6220 VA: 0x181EF6E20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(VehicleModule instance) { }

	// RVA: 0x1EF64A0 Offset: 0x1EF58A0 VA: 0x181EF64A0
	public VehicleModule Copy() { }

	// RVA: 0x1EF6DA0 Offset: 0x1EF61A0 VA: 0x181EF6DA0
	public static VehicleModule Deserialize(Stream stream) { }

	// RVA: 0x1EF6510 Offset: 0x1EF5910 VA: 0x181EF6510
	public static VehicleModule DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF69B0 Offset: 0x1EF5DB0 VA: 0x181EF69B0
	public static VehicleModule DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF6C80 Offset: 0x1EF6080 VA: 0x181EF6C80
	public static VehicleModule Deserialize(byte[] buffer) { }

	// RVA: 0x1EF6F10 Offset: 0x1EF6310 VA: 0x181EF6F10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF74A0 Offset: 0x1EF68A0 VA: 0x181EF74A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF7570 Offset: 0x1EF6970 VA: 0x181EF7570 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VehicleModule previous) { }

	// RVA: 0x1EF6F30 Offset: 0x1EF6330 VA: 0x181EF6F30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF6A40 Offset: 0x1EF5E40 VA: 0x181EF6A40
	public static VehicleModule Deserialize(byte[] buffer, VehicleModule instance, bool isDelta = False) { }

	// RVA: 0x1EF6B40 Offset: 0x1EF5F40 VA: 0x181EF6B40
	public static VehicleModule Deserialize(Stream stream, VehicleModule instance, bool isDelta) { }

	// RVA: 0x1EF6590 Offset: 0x1EF5990 VA: 0x181EF6590
	public static VehicleModule DeserializeLengthDelimited(Stream stream, VehicleModule instance, bool isDelta) { }

	// RVA: 0x1EF67B0 Offset: 0x1EF5BB0 VA: 0x181EF67B0
	public static VehicleModule DeserializeLength(Stream stream, int length, VehicleModule instance, bool isDelta) { }

	// RVA: 0x1EF7050 Offset: 0x1EF6450 VA: 0x181EF7050
	public static void SerializeDelta(Stream stream, VehicleModule instance, VehicleModule previous) { }

	// RVA: 0x1EF73C0 Offset: 0x1EF67C0 VA: 0x181EF73C0
	public static void Serialize(Stream stream, VehicleModule instance) { }

	// RVA: 0x1EF7490 Offset: 0x1EF6890 VA: 0x181EF7490
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF74A0 Offset: 0x1EF68A0 VA: 0x181EF74A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF7210 Offset: 0x1EF6610 VA: 0x181EF7210
	public static byte[] SerializeToBytes(VehicleModule instance) { }

	// RVA: 0x1EF7160 Offset: 0x1EF6560 VA: 0x181EF7160
	public static void SerializeLengthDelimited(Stream stream, VehicleModule instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class CamperModule : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6420
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint bbqId; // 0x14
	public uint lockerId; // 0x18
	public uint storageID; // 0x1C

	// Methods

	// RVA: 0x1F6FCC0 Offset: 0x1F6F0C0 VA: 0x181F6FCC0
	public static void ResetToPool(CamperModule instance) { }

	// RVA: 0x1F6FD50 Offset: 0x1F6F150 VA: 0x181F6FD50
	public void ResetToPool() { }

	// RVA: 0x1F6F9E0 Offset: 0x1F6EDE0 VA: 0x181F6F9E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E231E0 Offset: 0x1E225E0 VA: 0x181E231E0
	public void CopyTo(CamperModule instance) { }

	// RVA: 0x1F6EAB0 Offset: 0x1F6DEB0 VA: 0x181F6EAB0
	public CamperModule Copy() { }

	// RVA: 0x1F6F2D0 Offset: 0x1F6E6D0 VA: 0x181F6F2D0
	public static CamperModule Deserialize(Stream stream) { }

	// RVA: 0x1F6EB30 Offset: 0x1F6DF30 VA: 0x181F6EB30
	public static CamperModule DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F6EE30 Offset: 0x1F6E230 VA: 0x181F6EE30
	public static CamperModule DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F6F4C0 Offset: 0x1F6E8C0 VA: 0x181F6F4C0
	public static CamperModule Deserialize(byte[] buffer) { }

	// RVA: 0x1F6FAF0 Offset: 0x1F6EEF0 VA: 0x181F6FAF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F70290 Offset: 0x1F6F690 VA: 0x181F70290 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F702B0 Offset: 0x1F6F6B0 VA: 0x181F702B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CamperModule previous) { }

	// RVA: 0x1F6FCA0 Offset: 0x1F6F0A0 VA: 0x181F6FCA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F6F760 Offset: 0x1F6EB60 VA: 0x181F6F760
	public static CamperModule Deserialize(byte[] buffer, CamperModule instance, bool isDelta = False) { }

	// RVA: 0x1F6F120 Offset: 0x1F6E520 VA: 0x181F6F120
	public static CamperModule Deserialize(Stream stream, CamperModule instance, bool isDelta) { }

	// RVA: 0x1F6EBB0 Offset: 0x1F6DFB0 VA: 0x181F6EBB0
	public static CamperModule DeserializeLengthDelimited(Stream stream, CamperModule instance, bool isDelta) { }

	// RVA: 0x1F6EEC0 Offset: 0x1F6E2C0 VA: 0x181F6EEC0
	public static CamperModule DeserializeLength(Stream stream, int length, CamperModule instance, bool isDelta) { }

	// RVA: 0x1F6FDE0 Offset: 0x1F6F1E0 VA: 0x181F6FDE0
	public static void SerializeDelta(Stream stream, CamperModule instance, CamperModule previous) { }

	// RVA: 0x1F70160 Offset: 0x1F6F560 VA: 0x181F70160
	public static void Serialize(Stream stream, CamperModule instance) { }

	// RVA: 0x1F70280 Offset: 0x1F6F680 VA: 0x181F70280
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F70290 Offset: 0x1F6F690 VA: 0x181F70290
	public void ToProto(Stream stream) { }

	// RVA: 0x1F70050 Offset: 0x1F6F450 VA: 0x181F70050
	public static byte[] SerializeToBytes(CamperModule instance) { }

	// RVA: 0x1F6FFA0 Offset: 0x1F6F3A0 VA: 0x181F6FFA0
	public static void SerializeLengthDelimited(Stream stream, CamperModule instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class BaseVehicle : BaseMountable // TypeDefIndex: 8351
{	// Fields
	private Option __menuOption_Menu_Occupied; // 0x320
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

	// Properties
	public override bool HasMenuOptions { get; }
	public bool IsMovingOrOn { get; }
	public override float RealisticMass { get; }
	public BaseVehicle.Enumerable allMountPoints { get; }

	// Methods

	// RVA: 0x914F40 Offset: 0x914340 VA: 0x180914F40 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9161B0 Offset: 0x9155B0 VA: 0x1809161B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x915CD0 Offset: 0x9150D0 VA: 0x180915CD0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x915EF0 Offset: 0x9152F0 VA: 0x180915EF0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x914ED0 Offset: 0x9142D0 VA: 0x180914ED0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x915E60 Offset: 0x915260 VA: 0x180915E60 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 186
	public virtual void InitializeClientEffects() { }

	// RVA: 0x914F20 Offset: 0x914320 VA: 0x180914F20 Slot: 187
	public virtual float GetHUDHealth() { }

	// RVA: 0x914400 Offset: 0x913800 VA: 0x180914400 Slot: 188
	public virtual float GetHUDMaxHealth() { }

	// RVA: 0x915890 Offset: 0x914C90 VA: 0x180915890 Slot: 169
	public override bool LocalPlayerIsMounted() { }

	// RVA: 0x915AD0 Offset: 0x914ED0 VA: 0x180915AD0 Slot: 189
	public virtual bool Menu_Push_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCB8B0 Offset: 0xCACB0 VA: 0x1800CB8B0
	[BaseEntity.Menu.Description] // RVA: 0xCB8B0 Offset: 0xCACB0 VA: 0x1800CB8B0
	[BaseEntity.Menu.Icon] // RVA: 0xCB8B0 Offset: 0xCACB0 VA: 0x1800CB8B0
	[BaseEntity.Menu.ShowIf] // RVA: 0xCB8B0 Offset: 0xCACB0 VA: 0x1800CB8B0
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void Menu_Occupied(BasePlayer player) { }

	// RVA: 0x9159E0 Offset: 0x914DE0 VA: 0x1809159E0 Slot: 190
	protected virtual bool Menu_Occupied_ShowIf(BasePlayer player) { }

	// RVA: 0x915950 Offset: 0x914D50 VA: 0x180915950 Slot: 183
	public override bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x9160E0 Offset: 0x9154E0 VA: 0x1809160E0 Slot: 191
	protected virtual void WorkshopMode() { }

	// RVA: 0x8BE280 Offset: 0x8BD680 VA: 0x1808BE280
	public bool IsStationary() { }

	// RVA: 0x915870 Offset: 0x914C70 VA: 0x180915870
	public bool IsMoving() { }

	// RVA: 0x916280 Offset: 0x915680 VA: 0x180916280
	public bool get_IsMovingOrOn() { }

	// RVA: 0x9162C0 Offset: 0x9156C0 VA: 0x1809162C0 Slot: 76
	public override float get_RealisticMass() { }

	// RVA: 0x915DC0 Offset: 0x9151C0 VA: 0x180915DC0 Slot: 157
	public override bool PlayerIsMounted(BasePlayer player) { }

	// RVA: 0x6F2BD0 Offset: 0x6F1FD0 VA: 0x1806F2BD0 Slot: 192
	protected virtual bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x915580 Offset: 0x914980 VA: 0x180915580
	public bool HasMountPoints() { }

	// RVA: 0x915810 Offset: 0x914C10 VA: 0x180915810 Slot: 153
	public override bool IsMounted() { }

	// RVA: 0x914E40 Offset: 0x914240 VA: 0x180914E40 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x915740 Offset: 0x914B40 VA: 0x180915740
	public bool IsFlipped() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 193
	public virtual bool IsVehicleRoot() { }

	// RVA: 0x914F00 Offset: 0x914300 VA: 0x180914F00 Slot: 147
	public override bool DirectlyMountable() { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 170
	public override BaseVehicle VehicleParent() { }

	// RVA: 0x915AF0 Offset: 0x914EF0 VA: 0x180915AF0 Slot: 22
	protected override void OnChildAdded(BaseEntity child) { }

	// RVA: 0x915C00 Offset: 0x915000 VA: 0x180915C00 Slot: 23
	protected override void OnChildRemoved(BaseEntity child) { }

	// RVA: 0x916360 Offset: 0x915760 VA: 0x180916360
	public BaseVehicle.Enumerable get_allMountPoints() { }

	// RVA: 0x915250 Offset: 0x914650 VA: 0x180915250
	public BaseVehicle.MountPointInfo GetMountPoint(int index) { }

	// RVA: 0x916100 Offset: 0x915500 VA: 0x180916100
	public void .ctor() { }

}

public enum BaseVehicle.ClippingCheckMode // TypeDefIndex: 8352
{	// Fields
	public int value__; // 0x0
	public const BaseVehicle.ClippingCheckMode OnMountOnly = 0;
	public const BaseVehicle.ClippingCheckMode Always = 1;
	public const BaseVehicle.ClippingCheckMode AlwaysHeadOnly = 2;

}

public class BaseVehicle.MountPointInfo // TypeDefIndex: 8353
{	// Fields
	public bool isDriver; // 0x10
	public Vector3 pos; // 0x14
	public Vector3 rot; // 0x20
	public string bone; // 0x30
	public GameObjectRef prefab; // 0x38

	// Methods

	// RVA: 0x919D60 Offset: 0x919160 VA: 0x180919D60
	public void .ctor() { }

}

public struct BaseVehicle.Enumerable : IEnumerable<BaseVehicle.MountPointInfo>, IEnumerable // TypeDefIndex: 8354
{	// Fields
	private readonly BaseVehicle _vehicle; // 0x0

	// Methods

	// RVA: 0xF9E90 Offset: 0xF9290 VA: 0x1800F9E90
	public void .ctor(BaseVehicle vehicle) { }

	// RVA: 0xF9D60 Offset: 0xF9160 VA: 0x1800F9D60
	public BaseVehicle.Enumerator GetEnumerator() { }

	// RVA: 0xF9D90 Offset: 0xF9190 VA: 0x1800F9D90 Slot: 4
	private IEnumerator<BaseVehicle.MountPointInfo> System.Collections.Generic.IEnumerable<BaseVehicle.MountPointInfo>.GetEnumerator() { }

	// RVA: 0xF9E10 Offset: 0xF9210 VA: 0x1800F9E10 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public struct BaseVehicle.Enumerator : IEnumerator<BaseVehicle.MountPointInfo>, IEnumerator, IDisposable // TypeDefIndex: 8355
{	// Fields
	private readonly BaseVehicle _vehicle; // 0x0
	private BaseVehicle.Enumerator.State _state; // 0x8
	private int _index; // 0xC
	private int _childIndex; // 0x10
	private BaseVehicle.Enumerator.Box _enumerator; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BaseVehicle.MountPointInfo <Current>k__BackingField; // 0x20

	// Properties
	public BaseVehicle.MountPointInfo Current { get; set; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3860 Offset: 0xF2C60 VA: 0x1800F3860 Slot: 4
	public BaseVehicle.MountPointInfo get_Current() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF13D0 Offset: 0xF07D0 VA: 0x1800F13D0
	private void set_Current(BaseVehicle.MountPointInfo value) { }

	// RVA: 0xF9EF0 Offset: 0xF92F0 VA: 0x1800F9EF0
	public void .ctor(BaseVehicle vehicle) { }

	// RVA: 0xF9ED0 Offset: 0xF92D0 VA: 0x1800F9ED0 Slot: 6
	public bool MoveNext() { }

	// RVA: 0xF3860 Offset: 0xF2C60 VA: 0x1800F3860 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xF9EC0 Offset: 0xF92C0 VA: 0x1800F9EC0 Slot: 5
	public void Dispose() { }

	// RVA: 0xF9EE0 Offset: 0xF92E0 VA: 0x1800F9EE0 Slot: 8
	public void Reset() { }

}

private enum BaseVehicle.Enumerator.State // TypeDefIndex: 8356
{	// Fields
	public int value__; // 0x0
	public const BaseVehicle.Enumerator.State Direct = 0;
	public const BaseVehicle.Enumerator.State EnterChild = 1;
	public const BaseVehicle.Enumerator.State EnumerateChild = 2;
	public const BaseVehicle.Enumerator.State Finished = 3;

}

private class BaseVehicle.Enumerator.Box : Pool.IPooled // TypeDefIndex: 8357
{	// Fields
	public BaseVehicle.Enumerator Value; // 0x10

	// Methods

	// RVA: 0x919610 Offset: 0x918A10 VA: 0x180919610 Slot: 4
	public void EnterPool() { }

	// RVA: 0x919610 Offset: 0x918A10 VA: 0x180919610 Slot: 5
	public void LeavePool() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class BaseVehicleModule : BaseVehicle, IPrefabPreProcess // TypeDefIndex: 8358
{	// Fields
	private Option __menuOption_Menu_Locked; // 0x3B8
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

	// Properties
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

	// Methods

	// RVA: 0x911F40 Offset: 0x911340 VA: 0x180911F40 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9146B0 Offset: 0x913AB0 VA: 0x1809146B0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x913270 Offset: 0x912670 VA: 0x180913270 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9117F0 Offset: 0x910BF0 VA: 0x1809117F0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x911AA0 Offset: 0x910EA0 VA: 0x180911AA0 Slot: 194
	public virtual void ClientVehicleTick() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 195
	public virtual void OnClientTickStopped() { }

	// RVA: 0x911870 Offset: 0x910C70 VA: 0x180911870 Slot: 196
	public virtual void ClientOnLoad() { }

	// RVA: 0x911C00 Offset: 0x911000 VA: 0x180911C00 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x914380 Offset: 0x913780 VA: 0x180914380
	public void SetLightState(bool headlightsOn, bool brakesOn) { }

	// RVA: 0x911600 Offset: 0x910A00 VA: 0x180911600
	public void ClearDecals(BaseVehicleModule.DecalType decalType) { }

	// RVA: 0x911C70 Offset: 0x911070 VA: 0x180911C70
	public void DrawHighlight() { }

	// RVA: 0x912AF0 Offset: 0x911EF0 VA: 0x180912AF0 Slot: 183
	public override bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.Description] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.Icon] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	[BaseEntity.Menu.ShowIf] // RVA: 0x8C890 Offset: 0x8BC90 VA: 0x18008C890
	// RVA: 0x912C70 Offset: 0x912070 VA: 0x180912C70
	public void Menu_Push(BasePlayer player) { }

	// RVA: 0x912BC0 Offset: 0x911FC0 VA: 0x180912BC0 Slot: 189
	public override bool Menu_Push_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCCE60 Offset: 0xCC260 VA: 0x1800CCE60
	[BaseEntity.Menu.Description] // RVA: 0xCCE60 Offset: 0xCC260 VA: 0x1800CCE60
	[BaseEntity.Menu.Icon] // RVA: 0xCCE60 Offset: 0xCC260 VA: 0x1800CCE60
	[BaseEntity.Menu.ShowIf] // RVA: 0xCCE60 Offset: 0xCC260 VA: 0x1800CCE60
	// RVA: 0x913010 Offset: 0x912410 VA: 0x180913010
	public void Menu_Use(BasePlayer player) { }

	// RVA: 0x912D10 Offset: 0x912110 VA: 0x180912D10
	public bool Menu_Use_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xCD130 Offset: 0xCC530 VA: 0x1800CD130
	[BaseEntity.Menu.Description] // RVA: 0xCD130 Offset: 0xCC530 VA: 0x1800CD130
	[BaseEntity.Menu.Icon] // RVA: 0xCD130 Offset: 0xCC530 VA: 0x1800CD130
	[BaseEntity.Menu.ShowIf] // RVA: 0xCD130 Offset: 0xCC530 VA: 0x1800CD130
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_Locked(BasePlayer player) { }

	// RVA: 0x9129A0 Offset: 0x911DA0 VA: 0x1809129A0 Slot: 197
	public virtual bool Menu_Locked_ShowIf(BasePlayer player) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9148B0 Offset: 0x913CB0 VA: 0x1809148B0
	public BaseModularVehicle get_Vehicle() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9148D0 Offset: 0x913CD0 VA: 0x1809148D0
	private void set_Vehicle(BaseModularVehicle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9146A0 Offset: 0x913AA0 VA: 0x1809146A0
	public int get_FirstSocketIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9148C0 Offset: 0x913CC0 VA: 0x1809148C0
	private void set_FirstSocketIndex(int value) { }

	// RVA: 0x914660 Offset: 0x913A60 VA: 0x180914660
	public Vector3 get_CentreOfMass() { }

	// RVA: 0x9148A0 Offset: 0x913CA0 VA: 0x1809148A0
	public float get_Mass() { }

	// RVA: 0x548730 Offset: 0x547B30 VA: 0x180548730
	public uint get_ID() { }

	// RVA: 0x914840 Offset: 0x913C40 VA: 0x180914840
	public bool get_IsOnAVehicle() { }

	// RVA: 0x778790 Offset: 0x777B90 VA: 0x180778790
	public ItemDefinition get_AssociatedItemDef() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 198
	public virtual bool get_HasSeating() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 199
	public virtual bool get_HasAnEngine() { }

	// RVA: 0x9133A0 Offset: 0x9127A0 VA: 0x1809133A0 Slot: 84
	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x914180 Offset: 0x913580 VA: 0x180914180
	public void RefreshParameters() { }

	// RVA: 0x9131B0 Offset: 0x9125B0 VA: 0x1809131B0 Slot: 200
	public virtual void ModuleAdded(BaseModularVehicle vehicle, int firstSocketIndex) { }

	// RVA: 0x913240 Offset: 0x912640 VA: 0x180913240 Slot: 201
	public virtual void ModuleRemoved() { }

	// RVA: 0x913360 Offset: 0x912760 VA: 0x180913360
	public void OtherVehicleModulesChanged() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 202
	public virtual void OnEngineStateChanged(VehicleEngineController.EngineState<GroundVehicle> oldState, VehicleEngineController.EngineState<GroundVehicle> newState) { }

	// RVA: 0x912900 Offset: 0x911D00 VA: 0x180912900 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x914400 Offset: 0x913800 VA: 0x180914400 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x9126F0 Offset: 0x911AF0 VA: 0x1809126F0
	public int GetNumSocketsTaken() { }

	// RVA: 0x911DA0 Offset: 0x9111A0 VA: 0x180911DA0
	public List<ConditionalObject> GetConditionals() { }

	// RVA: 0x581F40 Offset: 0x581340 VA: 0x180581F40 Slot: 203
	public virtual float GetMaxDriveForce() { }

	// RVA: 0x913F60 Offset: 0x913360 VA: 0x180913F60
	public void RefreshConditionals(bool canGib) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 204
	protected virtual void PostConditionalRefresh() { }

	// RVA: 0x913480 Offset: 0x912880 VA: 0x180913480
	private void RefreshConditional(ConditionalObject conditional, bool canGib) { }

	// RVA: 0x914570 Offset: 0x913970 VA: 0x180914570
	private bool TryGetAdjacentModuleInFront(out BaseVehicleModule result) { }

	// RVA: 0x914420 Offset: 0x913820 VA: 0x180914420
	private bool TryGetAdjacentModuleBehind(out BaseVehicleModule result) { }

	// RVA: 0x912790 Offset: 0x911B90 VA: 0x180912790
	private bool InSameVisualGroupAs(BaseVehicleModule moduleEntity, ConditionalObject.AdjacentMatchType matchType) { }

	// RVA: 0x9114A0 Offset: 0x9108A0 VA: 0x1809114A0
	private bool CanBeUsedNowBy(BasePlayer player) { }

	// RVA: 0x913370 Offset: 0x912770 VA: 0x180913370
	public bool PlayerIsLookingAtUsable(string lookingAtColldierName, string usableColliderName) { }

	// RVA: 0x912890 Offset: 0x911C90 VA: 0x180912890 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 193
	public override bool IsVehicleRoot() { }

	// RVA: 0x914630 Offset: 0x913A30 VA: 0x180914630
	public void .ctor() { }

}

public enum BaseVehicleModule.DecalType // TypeDefIndex: 8359
{	// Fields
	public int value__; // 0x0
	public const BaseVehicleModule.DecalType All = 0;
	public const BaseVehicleModule.DecalType Glass = 1;

}

public enum BaseVehicleModule.VisualGroup // TypeDefIndex: 8360
{	// Fields
	public int value__; // 0x0
	public const BaseVehicleModule.VisualGroup None = 0;
	public const BaseVehicleModule.VisualGroup Engine = 1;
	public const BaseVehicleModule.VisualGroup Cabin = 2;
	public const BaseVehicleModule.VisualGroup Flatbed = 3;

}

public class BaseVehicleModule.LODLevel // TypeDefIndex: 8361
{	// Fields
	public Renderer[] renderers; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class EngineSwitch : BaseEntity // TypeDefIndex: 8389
{	// Fields
	private Option __menuOption_Menu_StartEngine; // 0x168
	private Option __menuOption_Menu_StopEngine; // 0x1C0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x8B3160 Offset: 0x8B2560 VA: 0x1808B3160 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x8B3860 Offset: 0x8B2C60 VA: 0x1808B3860 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8B3710 Offset: 0x8B2B10 VA: 0x1808B3710 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xDC270 Offset: 0xDB670 VA: 0x1800DC270
	[BaseEntity.Menu.Description] // RVA: 0xDC270 Offset: 0xDB670 VA: 0x1800DC270
	[BaseEntity.Menu.Icon] // RVA: 0xDC270 Offset: 0xDB670 VA: 0x1800DC270
	[BaseEntity.Menu.ShowIf] // RVA: 0xDC270 Offset: 0xDB670 VA: 0x1800DC270
	// RVA: 0x8B3690 Offset: 0x8B2A90 VA: 0x1808B3690
	public void Menu_StartEngine(BasePlayer player) { }

	// RVA: 0x5277F0 Offset: 0x526BF0 VA: 0x1805277F0
	public bool Menu_EngineOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xDD760 Offset: 0xDCB60 VA: 0x1800DD760
	[BaseEntity.Menu.Description] // RVA: 0xDD760 Offset: 0xDCB60 VA: 0x1800DD760
	[BaseEntity.Menu.Icon] // RVA: 0xDD760 Offset: 0xDCB60 VA: 0x1800DD760
	[BaseEntity.Menu.ShowIf] // RVA: 0xDD760 Offset: 0xDCB60 VA: 0x1800DD760
	// RVA: 0x8B36D0 Offset: 0x8B2AD0 VA: 0x1808B36D0
	public void Menu_StopEngine(BasePlayer player) { }

	// RVA: 0x4F2CB0 Offset: 0x4F20B0 VA: 0x1804F2CB0
	public bool Menu_EngineOff_ShowIf(BasePlayer player) { }

	// RVA: 0x8B3800 Offset: 0x8B2C00 VA: 0x1808B3800
	public void .ctor() { }

}

public class ModularCar : BaseModularVehicle, IVehicleLockUser, VehicleChassisVisuals.IClientWheelUser<ModularCar> // TypeDefIndex: 8415
{	// Fields
	private Option __menuOption_Menu_FuelStorage; // 0x4C0
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

	// Properties
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

	// Methods

	// RVA: 0x776210 Offset: 0x775610 VA: 0x180776210 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7787C0 Offset: 0x777BC0 VA: 0x1807787C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x777740 Offset: 0x776B40 VA: 0x180777740 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x778970 Offset: 0x777D70 VA: 0x180778970
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataFL() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7789B0 Offset: 0x777DB0 VA: 0x1807789B0
	private void set_WheelDataFL(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x778980 Offset: 0x777D80 VA: 0x180778980
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataFR() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7789C0 Offset: 0x777DC0 VA: 0x1807789C0
	private void set_WheelDataFR(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x778990 Offset: 0x777D90 VA: 0x180778990
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataRL() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7789D0 Offset: 0x777DD0 VA: 0x1807789D0
	private void set_WheelDataRL(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7789A0 Offset: 0x777DA0 VA: 0x1807789A0
	public VehicleChassisVisuals.ClientWheelData<ModularCar> get_WheelDataRR() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7789E0 Offset: 0x777DE0 VA: 0x1807789E0
	private void set_WheelDataRR(VehicleChassisVisuals.ClientWheelData<ModularCar> value) { }

	// RVA: 0x7758C0 Offset: 0x774CC0 VA: 0x1807758C0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7775F0 Offset: 0x7769F0 VA: 0x1807775F0 Slot: 132
	protected override void OnLifeStateChanged() { }

	// RVA: 0x775CD0 Offset: 0x7750D0 VA: 0x180775CD0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x7768C0 Offset: 0x775CC0 VA: 0x1807768C0
	public bool HasAnEngineAtLowPerformance() { }

	// RVA: 0x776AD0 Offset: 0x775ED0 VA: 0x180776AD0
	public bool HasLowFuel() { }

	// RVA: 0x776880 Offset: 0x775C80 VA: 0x180776880
	public bool HadRecentFailedEngineStart() { }

	// RVA: 0x778400 Offset: 0x777800 VA: 0x180778400 Slot: 62
	protected override void SpawnGibs() { }

	// RVA: 0x7767A0 Offset: 0x775BA0 VA: 0x1807767A0 Slot: 202
	protected override void GroundVehicleClientTick() { }

	// RVA: 0x777530 Offset: 0x776930 VA: 0x180777530 Slot: 201
	protected override void OnClientTickStopped() { }

	// RVA: 0x776B80 Offset: 0x775F80 VA: 0x180776B80 Slot: 204
	protected override bool IsBraking() { }

	[BaseEntity.Menu] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.Description] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.Icon] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	// RVA: 0x776EA0 Offset: 0x7762A0 VA: 0x180776EA0
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x776DD0 Offset: 0x7761D0 VA: 0x180776DD0
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x75220 Offset: 0x74620 VA: 0x180075220
	[BaseEntity.Menu.Description] // RVA: 0x75220 Offset: 0x74620 VA: 0x180075220
	[BaseEntity.Menu.Icon] // RVA: 0x75220 Offset: 0x74620 VA: 0x180075220
	[BaseEntity.Menu.ShowIf] // RVA: 0x75220 Offset: 0x74620 VA: 0x180075220
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_Locked(BasePlayer player) { }

	// RVA: 0x776EE0 Offset: 0x7762E0 VA: 0x180776EE0
	public bool Menu_Locked_ShowIf(BasePlayer player) { }

	// RVA: 0x777340 Offset: 0x776740 VA: 0x180777340 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x775DC0 Offset: 0x7751C0 VA: 0x180775DC0 Slot: 187
	public override float GetHUDHealth() { }

	// RVA: 0x775E90 Offset: 0x775290 VA: 0x180775E90 Slot: 188
	public override float GetHUDMaxHealth() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x776FC0 Offset: 0x7763C0 VA: 0x180776FC0
	private void ModularCarUpdate(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x775D00 Offset: 0x775100 VA: 0x180775D00
	private void EngineStartFailed(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7787B0 Offset: 0x777BB0 VA: 0x1807787B0 Slot: 196
	public override float get_DriveWheelVelocity() { }

	// RVA: 0x7787A0 Offset: 0x777BA0 VA: 0x1807787A0
	public float get_DriveWheelSlip() { }

	// RVA: 0x778960 Offset: 0x777D60 VA: 0x180778960 Slot: 215
	public float get_SteerAngle() { }

	// RVA: 0x778790 Offset: 0x777B90 VA: 0x180778790
	public ItemDefinition get_AssociatedItemDef() { }

	// RVA: 0x778940 Offset: 0x777D40 VA: 0x180778940 Slot: 216
	public float get_MaxSteerAngle() { }

	// RVA: 0x778910 Offset: 0x777D10 VA: 0x180778910 Slot: 206
	public override bool get_IsLockable() { }

	// RVA: 0x7780C0 Offset: 0x7774C0 VA: 0x1807780C0 Slot: 84
	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x776AF0 Offset: 0x775EF0 VA: 0x180776AF0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x776DA0 Offset: 0x7761A0 VA: 0x180776DA0 Slot: 111
	public override float MaxHealth() { }

	// RVA: 0x776DA0 Offset: 0x7761A0 VA: 0x180776DA0 Slot: 143
	public override float StartHealth() { }

	// RVA: 0x775DC0 Offset: 0x7751C0 VA: 0x180775DC0
	public float TotalHealth() { }

	// RVA: 0x775E90 Offset: 0x775290 VA: 0x180775E90
	public float TotalMaxHealth() { }

	// RVA: 0x776080 Offset: 0x775480 VA: 0x180776080 Slot: 197
	public override float GetMaxForwardSpeed() { }

	// RVA: 0x776BB0 Offset: 0x775FB0 VA: 0x180776BB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7775B0 Offset: 0x7769B0 VA: 0x1807775B0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x776770 Offset: 0x775B70 VA: 0x180776770 Slot: 198
	public override float GetThrottleInput() { }

	// RVA: 0x775D80 Offset: 0x775180 VA: 0x180775D80 Slot: 199
	public override float GetBrakeInput() { }

	// RVA: 0x775F60 Offset: 0x775360 VA: 0x180775F60
	public float GetMaxDriveForce() { }

	// RVA: 0x775DB0 Offset: 0x7751B0 VA: 0x180775DB0
	public float GetFuelFraction() { }

	// RVA: 0x778090 Offset: 0x777490 VA: 0x180778090 Slot: 210
	public bool PlayerHasUnlockPermission(BasePlayer player) { }

	// RVA: 0x778030 Offset: 0x777430 VA: 0x180778030 Slot: 207
	public override bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType) { }

	// RVA: 0x777FE0 Offset: 0x7773E0 VA: 0x180777FE0 Slot: 212
	public bool PlayerCanDestroyLock(BasePlayer player, BaseVehicleModule viaModule) { }

	// RVA: 0x775740 Offset: 0x774B40 VA: 0x180775740 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x775850 Offset: 0x774C50 VA: 0x180775850 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x7781C0 Offset: 0x7775C0 VA: 0x1807781C0
	protected bool RefreshEngineState() { }

	// RVA: 0x778390 Offset: 0x777790 VA: 0x180778390
	private float RollOffDriveForce(float driveForce) { }

	// RVA: 0x778170 Offset: 0x777570 VA: 0x180778170
	private void RefreshChassisProtectionState() { }

	// RVA: 0x7770E0 Offset: 0x7764E0 VA: 0x1807770E0 Slot: 208
	protected override void ModuleEntityAdded(BaseVehicleModule addedModule) { }

	// RVA: 0x777210 Offset: 0x776610 VA: 0x180777210 Slot: 209
	protected override void ModuleEntityRemoved(BaseVehicleModule removedModule) { }

	// RVA: 0x778770 Offset: 0x777B70 VA: 0x180778770
	public void .ctor() { }

	// RVA: 0x778700 Offset: 0x777B00 VA: 0x180778700
	private static void .cctor() { }

}

public class ModularCar.SpawnSettings // TypeDefIndex: 8416
{	// Fields
	[TooltipAttribute] // RVA: 0x757C0 Offset: 0x74BC0 VA: 0x1800757C0
	public bool useSpawnSettings; // 0x10
	[TooltipAttribute] // RVA: 0x75930 Offset: 0x74D30 VA: 0x180075930
	public ModularCarPresetConfig[] configurationOptions; // 0x18
	[TooltipAttribute] // RVA: 0x75A10 Offset: 0x74E10 VA: 0x180075A10
	public float minStartHealthPercent; // 0x20
	[TooltipAttribute] // RVA: 0x75CB0 Offset: 0x750B0 VA: 0x180075CB0
	public float maxStartHealthPercent; // 0x24
	public ModularCar.SpawnSettings.AdminBonus adminBonus; // 0x28

	// Methods

	// RVA: 0x77C800 Offset: 0x77BC00 VA: 0x18077C800
	public void .ctor() { }

}

public enum ModularCar.SpawnSettings.AdminBonus // TypeDefIndex: 8417
{	// Fields
	public int value__; // 0x0
	public const ModularCar.SpawnSettings.AdminBonus None = 0;
	public const ModularCar.SpawnSettings.AdminBonus T1PlusFuel = 1;
	public const ModularCar.SpawnSettings.AdminBonus T2PlusFuel = 2;
	public const ModularCar.SpawnSettings.AdminBonus T3PlusFuel = 3;

}

public class ModularCarGarage : ContainerIOEntity // TypeDefIndex: 8418
{	// Fields
	private Option __menuOption_Menu_EditVehicle; // 0x378
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

	// Properties
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

	// Methods

	// RVA: 0x773360 Offset: 0x772760 VA: 0x180773360 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x774A20 Offset: 0x773E20 VA: 0x180774A20 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x774110 Offset: 0x773510 VA: 0x180774110 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7731C0 Offset: 0x7725C0 VA: 0x1807731C0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7747C0 Offset: 0x773BC0 VA: 0x1807747C0
	public void TryRepair(uint itemUID) { }

	// RVA: 0x7738B0 Offset: 0x772CB0 VA: 0x1807738B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7732F0 Offset: 0x7726F0 VA: 0x1807732F0
	public void ClientSelectedLootItem(Item item) { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 165
	public override int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x774200 Offset: 0x773600 VA: 0x180774200
	private bool PlayerHasInternalModuleLoot() { }

	// RVA: 0x773230 Offset: 0x772630 VA: 0x180773230
	public void ClientRequestAddLock() { }

	// RVA: 0x7732B0 Offset: 0x7726B0 VA: 0x1807732B0
	public void ClientRequestRemoveLock() { }

	// RVA: 0x773270 Offset: 0x772670 VA: 0x180773270
	public void ClientRequestNewKey() { }

	// RVA: 0x7744C0 Offset: 0x7738C0 VA: 0x1807744C0
	private void RefreshPoweredLightState() { }

	// RVA: 0x774430 Offset: 0x773830 VA: 0x180774430
	private void RefreshInUseLightState() { }

	[BaseEntity.Menu] // RVA: 0x770F0 Offset: 0x764F0 VA: 0x1800770F0
	[BaseEntity.Menu.Description] // RVA: 0x770F0 Offset: 0x764F0 VA: 0x1800770F0
	[BaseEntity.Menu.Icon] // RVA: 0x770F0 Offset: 0x764F0 VA: 0x1800770F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x770F0 Offset: 0x764F0 VA: 0x1800770F0
	// RVA: 0x773BE0 Offset: 0x772FE0 VA: 0x180773BE0
	public void Menu_EditVehicle(BasePlayer player) { }

	// RVA: 0x773AE0 Offset: 0x772EE0 VA: 0x180773AE0
	public bool Menu_EditVehicle_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x77470 Offset: 0x76870 VA: 0x180077470
	[BaseEntity.Menu.Description] // RVA: 0x77470 Offset: 0x76870 VA: 0x180077470
	[BaseEntity.Menu.Icon] // RVA: 0x77470 Offset: 0x76870 VA: 0x180077470
	[BaseEntity.Menu.ShowIf] // RVA: 0x77470 Offset: 0x76870 VA: 0x180077470
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void Menu_InsufficientPower(BasePlayer player) { }

	// RVA: 0x773C20 Offset: 0x773020 VA: 0x180773C20
	public bool Menu_InsufficientPower_ShowIf(BasePlayer player) { }

	// RVA: 0x7745C0 Offset: 0x7739C0 VA: 0x1807745C0
	public void StartChassisDestroy() { }

	// RVA: 0x773160 Offset: 0x772560 VA: 0x180773160
	public void CancelChassisDestroy() { }

	// RVA: 0x774BF0 Offset: 0x773FF0 VA: 0x180774BF0
	public float get_TimeLeftToCancelChassisDestroy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x774BE0 Offset: 0x773FE0 VA: 0x180774BE0
	public bool get_PlatformIsOccupied() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x774CD0 Offset: 0x7740D0 VA: 0x180774CD0
	private void set_PlatformIsOccupied(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x774A10 Offset: 0x773E10 VA: 0x180774A10
	public bool get_HasEditableOccupant() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x774CA0 Offset: 0x7740A0 VA: 0x180774CA0
	private void set_HasEditableOccupant(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x774A00 Offset: 0x773E00 VA: 0x180774A00
	public bool get_HasDriveableOccupant() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x774C90 Offset: 0x774090 VA: 0x180774C90
	private void set_HasDriveableOccupant(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x774BD0 Offset: 0x773FD0 VA: 0x180774BD0
	public ModularCarGarage.OccupantLock get_OccupantLockState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x774CC0 Offset: 0x7740C0 VA: 0x180774CC0
	private void set_OccupantLockState(ModularCarGarage.OccupantLock value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x774BC0 Offset: 0x773FC0 VA: 0x180774BC0
	public int get_OccupantLockID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x774CB0 Offset: 0x7740B0 VA: 0x180774CB0
	private void set_OccupantLockID(int value) { }

	// RVA: 0x774BB0 Offset: 0x773FB0 VA: 0x180774BB0
	private bool get_LiftIsUp() { }

	// RVA: 0x774B80 Offset: 0x773F80 VA: 0x180774B80
	private bool get_LiftIsMoving() { }

	// RVA: 0x774B70 Offset: 0x773F70 VA: 0x180774B70
	private bool get_LiftIsDown() { }

	// RVA: 0x5717B0 Offset: 0x570BB0 VA: 0x1805717B0
	public bool get_IsDestroyingChassis() { }

	// RVA: 0x7743D0 Offset: 0x7737D0 VA: 0x1807743D0 Slot: 84
	public override void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x7740B0 Offset: 0x7734B0 VA: 0x1807740B0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5C9C90 Offset: 0x5C9090 VA: 0x1805C9C90 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x70CC90 Offset: 0x70C090 VA: 0x18070CC90 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x774500 Offset: 0x773900 VA: 0x180774500
	private void SetOccupantState(bool hasOccupant, bool editableOccupant, bool driveableOccupant, ModularCarGarage.OccupantLock occupantLockState, int occupantLockID, bool forced = False) { }

	// RVA: 0x774460 Offset: 0x773860 VA: 0x180774460
	private void RefreshLiftState(bool forced = False) { }

	// RVA: 0x773F10 Offset: 0x773310 VA: 0x180773F10
	private void MoveLift(ModularCarGarage.VehicleLiftState desiredLiftState, float startDelay = 0, bool forced = False) { }

	// RVA: 0x773E90 Offset: 0x773290 VA: 0x180773E90
	private void MoveLiftUp() { }

	// RVA: 0x773CE0 Offset: 0x7730E0 VA: 0x180773CE0
	private void MoveLiftDown() { }

	// RVA: 0x774610 Offset: 0x773A10 VA: 0x180774610
	private void StartLiftSounds() { }

	// RVA: 0x774810 Offset: 0x773C10 VA: 0x180774810
	private void UpdateLiftSounds() { }

	// RVA: 0x7749A0 Offset: 0x773DA0 VA: 0x1807749A0
	public void .ctor() { }

}

public class ModularCarGarage.ChassisBuildOption // TypeDefIndex: 8419
{	// Fields
	public GameObjectRef prefab; // 0x10
	public ItemDefinition itemDef; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public enum ModularCarGarage.OccupantLock // TypeDefIndex: 8420
{	// Fields
	public int value__; // 0x0
	public const ModularCarGarage.OccupantLock CannotHaveLock = 0;
	public const ModularCarGarage.OccupantLock NoLock = 1;
	public const ModularCarGarage.OccupantLock HasLock = 2;

}

private enum ModularCarGarage.VehicleLiftState // TypeDefIndex: 8421
{	// Fields
	public int value__; // 0x0
	public const ModularCarGarage.VehicleLiftState Down = 0;
	public const ModularCarGarage.VehicleLiftState Up = 1;

}

public class MotorRowboat : BaseBoat // TypeDefIndex: 8422
{	// Fields
	private Option __menuOption_Menu_FuelStorage; // 0x438
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

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7B4D40 Offset: 0x7B4140 VA: 0x1807B4D40 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7B7500 Offset: 0x7B6900 VA: 0x1807B7500 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7B5BF0 Offset: 0x7B4FF0 VA: 0x1807B5BF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7B6730 Offset: 0x7B5B30 VA: 0x1807B6730
	public void UpdateSounds() { }

	// RVA: 0x7B55F0 Offset: 0x7B49F0 VA: 0x1807B55F0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x7B6610 Offset: 0x7B5A10 VA: 0x1807B6610 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x7B72F0 Offset: 0x7B66F0 VA: 0x1807B72F0
	public void Update() { }

	// RVA: 0x7B6DD0 Offset: 0x7B61D0 VA: 0x1807B6DD0
	public void UpdateWake() { }

	// RVA: 0x7B5ED0 Offset: 0x7B52D0 VA: 0x1807B5ED0
	public void UpdateEffects() { }

	// RVA: 0x7B56A0 Offset: 0x7B4AA0 VA: 0x1807B56A0 Slot: 186
	public override void InitializeClientEffects() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 196
	public virtual void ShutdownClientEffects() { }

	// RVA: 0x7B6330 Offset: 0x7B5730 VA: 0x1807B6330 Slot: 197
	public virtual void UpdateEngineRotation() { }

	// RVA: 0x7B5DC0 Offset: 0x7B51C0 VA: 0x1807B5DC0 Slot: 59
	public override void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0x7B5B80 Offset: 0x7B4F80 VA: 0x1807B5B80 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x6B37E0 Offset: 0x6B2BE0 VA: 0x1806B37E0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x7B5830 Offset: 0x7B4C30 VA: 0x1807B5830 Slot: 198
	public virtual bool LookingAtEngine(BasePlayer player) { }

	// RVA: 0x6A0DF0 Offset: 0x6A01F0 VA: 0x1806A0DF0 Slot: 199
	public virtual bool LookingAtFuelArea(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x79F90 Offset: 0x79390 VA: 0x180079F90
	[BaseEntity.Menu.Description] // RVA: 0x79F90 Offset: 0x79390 VA: 0x180079F90
	[BaseEntity.Menu.Icon] // RVA: 0x79F90 Offset: 0x79390 VA: 0x180079F90
	[BaseEntity.Menu.ShowIf] // RVA: 0x79F90 Offset: 0x79390 VA: 0x180079F90
	// RVA: 0x7B5A60 Offset: 0x7B4E60 VA: 0x1807B5A60
	public void Menu_StartEngine(BasePlayer player) { }

	// RVA: 0x7B59C0 Offset: 0x7B4DC0 VA: 0x1807B59C0
	public bool Menu_StartEngine_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7A330 Offset: 0x79730 VA: 0x18007A330
	[BaseEntity.Menu.Description] // RVA: 0x7A330 Offset: 0x79730 VA: 0x18007A330
	[BaseEntity.Menu.Icon] // RVA: 0x7A330 Offset: 0x79730 VA: 0x18007A330
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A330 Offset: 0x79730 VA: 0x18007A330
	// RVA: 0x7B5B30 Offset: 0x7B4F30 VA: 0x1807B5B30
	public void Menu_StopEngine(BasePlayer player) { }

	// RVA: 0x7B5AB0 Offset: 0x7B4EB0 VA: 0x1807B5AB0
	public bool Menu_StopEngine_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7A670 Offset: 0x79A70 VA: 0x18007A670
	[BaseEntity.Menu.Description] // RVA: 0x7A670 Offset: 0x79A70 VA: 0x18007A670
	[BaseEntity.Menu.Icon] // RVA: 0x7A670 Offset: 0x79A70 VA: 0x18007A670
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A670 Offset: 0x79A70 VA: 0x18007A670
	// RVA: 0x7B5980 Offset: 0x7B4D80 VA: 0x1807B5980
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x7B5910 Offset: 0x7B4D10 VA: 0x1807B5910
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	// RVA: 0x7B5CE0 Offset: 0x7B50E0 VA: 0x1807B5CE0 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x7B4AF0 Offset: 0x7B3EF0 VA: 0x1807B4AF0 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x7B5E30 Offset: 0x7B5230 VA: 0x1807B5E30
	private bool ShowPushMenu(BasePlayer player) { }

	// RVA: 0x7B5780 Offset: 0x7B4B80 VA: 0x1807B5780 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7B7350 Offset: 0x7B6750 VA: 0x1807B7350 Slot: 191
	protected override void WorkshopMode() { }

	// RVA: 0x7B7410 Offset: 0x7B6810 VA: 0x1807B7410
	public void .ctor() { }

	// RVA: 0x7B73B0 Offset: 0x7B67B0 VA: 0x1807B73B0
	private static void .cctor() { }

}

public class VehicleModuleCamper : VehicleModuleSeating // TypeDefIndex: 8477
{	// Fields
	private Option __menuOption_Menu_AssignToFriend; // 0x608
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

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xACCA50 Offset: 0xACBE50 VA: 0x180ACCA50 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xACE690 Offset: 0xACDA90 VA: 0x180ACE690 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xACE540 Offset: 0xACD940 VA: 0x180ACE540 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xACC940 Offset: 0xACBD40 VA: 0x180ACC940 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0xACDBF0 Offset: 0xACCFF0 VA: 0x180ACDBF0 Slot: 205
	public override bool IsOnThisModule(BasePlayer player) { }

	// RVA: 0xACDDB0 Offset: 0xACD1B0 VA: 0x180ACDDB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x85360 Offset: 0x84760 VA: 0x180085360
	[BaseEntity.Menu.Icon] // RVA: 0x85360 Offset: 0x84760 VA: 0x180085360
	[BaseEntity.Menu.Description] // RVA: 0x85360 Offset: 0x84760 VA: 0x180085360
	[BaseEntity.Menu.ShowIf] // RVA: 0x85360 Offset: 0x84760 VA: 0x180085360
	// RVA: 0xACE1E0 Offset: 0xACD5E0 VA: 0x180ACE1E0
	public void Menu_MakeBed(BasePlayer player) { }

	// RVA: 0xACE120 Offset: 0xACD520 VA: 0x180ACE120 Slot: 206
	public virtual bool Menu_MakeBed_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x96A30 Offset: 0x95E30 VA: 0x180096A30
	[BaseEntity.Menu.Icon] // RVA: 0x96A30 Offset: 0x95E30 VA: 0x180096A30
	[BaseEntity.Menu.Description] // RVA: 0x96A30 Offset: 0x95E30 VA: 0x180096A30
	[BaseEntity.Menu.ShowIf] // RVA: 0x96A30 Offset: 0x95E30 VA: 0x180096A30
	// RVA: 0xACE090 Offset: 0xACD490 VA: 0x180ACE090
	public void Menu_ClearBedOwner(BasePlayer player) { }

	// RVA: 0xACDFD0 Offset: 0xACD3D0 VA: 0x180ACDFD0 Slot: 207
	public virtual bool Menu_ClearBedOwner_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x847F0 Offset: 0x83BF0 VA: 0x1800847F0
	[BaseEntity.Menu.Icon] // RVA: 0x847F0 Offset: 0x83BF0 VA: 0x1800847F0
	[BaseEntity.Menu.Description] // RVA: 0x847F0 Offset: 0x83BF0 VA: 0x1800847F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x847F0 Offset: 0x83BF0 VA: 0x1800847F0
	// RVA: 0xACDF40 Offset: 0xACD340 VA: 0x180ACDF40
	public void Menu_AssignToFriend(BasePlayer player) { }

	// RVA: 0xACDE80 Offset: 0xACD280 VA: 0x180ACDE80 Slot: 208
	public virtual bool Menu_AssignToFriend_Test(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x844E0 Offset: 0x838E0 VA: 0x1800844E0
	[BaseEntity.Menu.Icon] // RVA: 0x844E0 Offset: 0x838E0 VA: 0x1800844E0
	[BaseEntity.Menu.Description] // RVA: 0x844E0 Offset: 0x838E0 VA: 0x1800844E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x844E0 Offset: 0x838E0 VA: 0x1800844E0
	// RVA: 0xACE4B0 Offset: 0xACD8B0 VA: 0x180ACE4B0
	public void Menu_Rename(BasePlayer player) { }

	// RVA: 0xACC990 Offset: 0xACBD90 VA: 0x180ACC990 Slot: 209
	protected virtual bool CanRename_Test(BasePlayer player) { }

	// RVA: 0xACD810 Offset: 0xACCC10 VA: 0x180ACD810
	private SleepingBagCamper GetSleepingBagForPlayer(BasePlayer p) { }

	[BaseEntity.Menu] // RVA: 0x97270 Offset: 0x96670 VA: 0x180097270
	[BaseEntity.Menu.Description] // RVA: 0x97270 Offset: 0x96670 VA: 0x180097270
	[BaseEntity.Menu.Icon] // RVA: 0x97270 Offset: 0x96670 VA: 0x180097270
	[BaseEntity.Menu.ShowIf] // RVA: 0x97270 Offset: 0x96670 VA: 0x180097270
	// RVA: 0xACE340 Offset: 0xACD740 VA: 0x180ACE340
	public void Menu_OpenLocker(BasePlayer player) { }

	// RVA: 0xACE270 Offset: 0xACD670 VA: 0x180ACE270
	public bool Menu_OpenLocker_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x975F0 Offset: 0x969F0 VA: 0x1800975F0
	[BaseEntity.Menu.Description] // RVA: 0x975F0 Offset: 0x969F0 VA: 0x1800975F0
	[BaseEntity.Menu.Icon] // RVA: 0x975F0 Offset: 0x969F0 VA: 0x1800975F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x975F0 Offset: 0x969F0 VA: 0x1800975F0
	// RVA: 0xACE470 Offset: 0xACD870 VA: 0x180ACE470
	public void Menu_OpenStorage(BasePlayer player) { }

	// RVA: 0xACE380 Offset: 0xACD780 VA: 0x180ACE380
	public bool Menu_OpenStorage_ShowIf(BasePlayer player) { }

	// RVA: 0xACE630 Offset: 0xACDA30 VA: 0x180ACE630
	public void .ctor() { }

}

public class VehicleModuleSeating : BaseVehicleModule, IPrefabPreProcess // TypeDefIndex: 8478
{	// Fields
	private Option __menuOption_Menu_DestroyLock; // 0x520
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

	// Properties
	public override bool HasMenuOptions { get; }
	public override bool HasSeating { get; }
	protected ModularCar Car { get; set; }
	protected bool IsOnACar { get; }
	protected bool IsOnAVehicleLockUser { get; }
	public bool DoorsAreLockable { get; }

	// Methods

	// RVA: 0xAD02D0 Offset: 0xACF6D0 VA: 0x180AD02D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAD24A0 Offset: 0xAD18A0 VA: 0x180AD24A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAD1260 Offset: 0xAD0660 VA: 0x180AD1260 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAD2560 Offset: 0xAD1960 VA: 0x180AD2560 Slot: 198
	public override bool get_HasSeating() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAD2470 Offset: 0xAD1870 VA: 0x180AD2470
	protected ModularCar get_Car() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAD2620 Offset: 0xAD1A20 VA: 0x180AD2620
	private void set_Car(ModularCar value) { }

	// RVA: 0xAD25B0 Offset: 0xAD19B0 VA: 0x180AD25B0
	protected bool get_IsOnACar() { }

	// RVA: 0xAD2610 Offset: 0xAD1A10 VA: 0x180AD2610
	protected bool get_IsOnAVehicleLockUser() { }

	// RVA: 0xAD2480 Offset: 0xAD1880 VA: 0x180AD2480
	public bool get_DoorsAreLockable() { }

	// RVA: 0xAD1560 Offset: 0xAD0960 VA: 0x180AD1560 Slot: 84
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xACFBB0 Offset: 0xACEFB0 VA: 0x180ACFBB0 Slot: 194
	public override void ClientVehicleTick() { }

	// RVA: 0xAD0E30 Offset: 0xAD0230 VA: 0x180AD0E30 Slot: 195
	public override void OnClientTickStopped() { }

	// RVA: 0xAD1BD0 Offset: 0xAD0FD0 VA: 0x180AD1BD0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xAD1880 Offset: 0xAD0C80 VA: 0x180AD1880
	private void SetCheckEngineLightState(bool isOn) { }

	// RVA: 0xAD1940 Offset: 0xAD0D40 VA: 0x180AD1940
	private void SetFuelLightState(bool isOn) { }

	// RVA: 0xAD1A10 Offset: 0xAD0E10 VA: 0x180AD1A10
	private void SetLightState(bool isOn, int lightMatIndex, Color lightEmission) { }

	// RVA: 0xAD0F00 Offset: 0xAD0300 VA: 0x180AD0F00 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0xAD2350 Offset: 0xAD1750 VA: 0x180AD2350
	public bool ValidMountRay(BasePlayer player) { }

	// RVA: 0xAD0BC0 Offset: 0xACFFC0 VA: 0x180AD0BC0 Slot: 197
	public override bool Menu_Locked_ShowIf(BasePlayer player) { }

	// RVA: 0xAD0860 Offset: 0xACFC60 VA: 0x180AD0860
	private bool LookingAtAMountHotSpot(BasePlayer localPlayer) { }

	[BaseEntity.Menu] // RVA: 0x98880 Offset: 0x97C80 VA: 0x180098880
	[BaseEntity.Menu.Description] // RVA: 0x98880 Offset: 0x97C80 VA: 0x180098880
	[BaseEntity.Menu.Icon] // RVA: 0x98880 Offset: 0x97C80 VA: 0x180098880
	[BaseEntity.Menu.ShowIf] // RVA: 0x98880 Offset: 0x97C80 VA: 0x180098880
	// RVA: 0xAD0B80 Offset: 0xACFF80 VA: 0x180AD0B80
	public void Menu_DestroyLock(BasePlayer player) { }

	// RVA: 0xAD0B70 Offset: 0xACFF70 VA: 0x180AD0B70
	public bool Menu_DestroyLock_ShowIf(BasePlayer player) { }

	// RVA: 0xAD0740 Offset: 0xACFB40 VA: 0x180AD0740 Slot: 205
	public virtual bool IsOnThisModule(BasePlayer player) { }

	// RVA: 0xAD05E0 Offset: 0xACF9E0 VA: 0x180AD05E0
	public bool HasADriverSeat() { }

	// RVA: 0xAD0D20 Offset: 0xAD0120 VA: 0x180AD0D20 Slot: 200
	public override void ModuleAdded(BaseModularVehicle vehicle, int firstSocketIndex) { }

	// RVA: 0xAD0DF0 Offset: 0xAD01F0 VA: 0x180AD0DF0 Slot: 201
	public override void ModuleRemoved() { }

	// RVA: 0xAD1350 Offset: 0xAD0750 VA: 0x180AD1350
	public bool PlayerCanDestroyLock(BasePlayer player) { }

	// RVA: 0xAD2460 Offset: 0xAD1860 VA: 0x180AD2460
	public void .ctor() { }

	// RVA: 0xAD2410 Offset: 0xAD1810 VA: 0x180AD2410
	private static void .cctor() { }

}

public class VehicleModuleSeating.MountHotSpot // TypeDefIndex: 8479
{	// Fields
	public Transform transform; // 0x10
	public Vector2 size; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class VehicleModuleSeating.Seating // TypeDefIndex: 8480
{	// Fields
	[HeaderAttribute] // RVA: 0x98B90 Offset: 0x97F90 VA: 0x180098B90
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

	// Methods

	// RVA: 0xAC50C0 Offset: 0xAC44C0 VA: 0x180AC50C0
	public void .ctor() { }

}

public class VehicleModuleStorage : VehicleModuleSeating // TypeDefIndex: 8481
{	// Fields
	private Option __menuOption_Menu_Open; // 0x608
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleModuleStorage.Storage storage; // 0x660
	private EntityRef storageUnitInstance; // 0x668

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAD2730 Offset: 0xAD1B30 VA: 0x180AD2730 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAD2CA0 Offset: 0xAD20A0 VA: 0x180AD2CA0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAD2BB0 Offset: 0xAD1FB0 VA: 0x180AD2BB0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAD2690 Offset: 0xAD1A90 VA: 0x180AD2690
	public IItemContainerEntity GetContainer() { }

	// RVA: 0xAD2A40 Offset: 0xAD1E40 VA: 0x180AD2A40 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAD2630 Offset: 0xAD1A30 VA: 0x180AD2630 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	[BaseEntity.Menu.Description] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	[BaseEntity.Menu.Icon] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	[BaseEntity.Menu.ShowIf] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	// RVA: 0xAD2B70 Offset: 0xAD1F70 VA: 0x180AD2B70
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0xAD2AA0 Offset: 0xAD1EA0 VA: 0x180AD2AA0
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0xACF7B0 Offset: 0xACEBB0 VA: 0x180ACF7B0
	public void .ctor() { }

}

public class VehicleModuleStorage.Storage // TypeDefIndex: 8482
{	// Fields
	public GameObjectRef storageUnitPrefab; // 0x10
	public Transform storageUnitPoint; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class VehicleModuleTaxi : VehicleModuleStorage // TypeDefIndex: 8483
{	// Fields
	private Option __menuOption_Menu_Kick_Passengers; // 0x678
	[HeaderAttribute] // RVA: 0x99D60 Offset: 0x99160 VA: 0x180099D60
	[SerializeField] // RVA: 0x99D60 Offset: 0x99160 VA: 0x180099D60
	private SoundDefinition kickButtonSound; // 0x6D0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SphereCollider kickButtonCollider; // 0x6D8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float maxKickVelocity; // 0x6E0

	// Properties
	public override bool HasMenuOptions { get; }
	private Vector3 KickButtonPos { get; }

	// Methods

	// RVA: 0xAD30D0 Offset: 0xAD24D0 VA: 0x180AD30D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAD3680 Offset: 0xAD2A80 VA: 0x180AD3680 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAD3530 Offset: 0xAD2930 VA: 0x180AD3530 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAD37F0 Offset: 0xAD2BF0 VA: 0x180AD37F0
	private Vector3 get_KickButtonPos() { }

	// RVA: 0xAD2D60 Offset: 0xAD2160 VA: 0x180AD2D60
	private bool CanKickPassengers(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9A150 Offset: 0x99550 VA: 0x18009A150
	[BaseEntity.Menu.Description] // RVA: 0x9A150 Offset: 0x99550 VA: 0x18009A150
	[BaseEntity.Menu.Icon] // RVA: 0x9A150 Offset: 0x99550 VA: 0x18009A150
	[BaseEntity.Menu.ShowIf] // RVA: 0x9A150 Offset: 0x99550 VA: 0x18009A150
	// RVA: 0xAD34A0 Offset: 0xAD28A0 VA: 0x180AD34A0
	public void Menu_Kick_Passengers(BasePlayer player) { }

	// RVA: 0xAD33E0 Offset: 0xAD27E0 VA: 0x180AD33E0
	public bool Menu_Kick_Passengers_ShowIf(BasePlayer player) { }

	// RVA: 0xAD3620 Offset: 0xAD2A20 VA: 0x180AD3620
	public void .ctor() { }

}

public class ModularCarOven : BaseOven // TypeDefIndex: 8608
{	// Fields
	private BaseVehicleModule moduleParent; // 0x4E8

	// Properties
	private BaseVehicleModule ModuleParent { get; }

	// Methods

	// RVA: 0x775100 Offset: 0x774500 VA: 0x180775100 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x775410 Offset: 0x774810 VA: 0x180775410
	private BaseVehicleModule get_ModuleParent() { }

	// RVA: 0x7751F0 Offset: 0x7745F0 VA: 0x1807751F0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x775220 Offset: 0x774620 VA: 0x180775220 Slot: 156
	protected override bool SwitchOff_ShowIf(BasePlayer player) { }

	// RVA: 0x7752F0 Offset: 0x7746F0 VA: 0x1807752F0 Slot: 155
	protected override bool SwitchOn_ShowIf(BasePlayer player) { }

	// RVA: 0x775030 Offset: 0x774430 VA: 0x180775030 Slot: 154
	protected override bool Menu_Open_ShowIf(BasePlayer player) { }

	// RVA: 0x548550 Offset: 0x547950 VA: 0x180548550
	public void .ctor() { }

}

public class VehicleVendor : NPCTalking // TypeDefIndex: 8851
{	// Fields
	public EntityRef spawnerRef; // 0x858
	public VehicleSpawner vehicleSpawner; // 0x868

	// Methods

	// RVA: 0xAD3BE0 Offset: 0xAD2FE0 VA: 0x180AD3BE0 Slot: 158
	public override string GetConversationStartSpeech(BasePlayer player) { }

	// RVA: 0xAD3C30 Offset: 0xAD3030 VA: 0x180AD3C30
	public VehicleSpawner GetVehicleSpawner() { }

	// RVA: 0xAD3CD0 Offset: 0xAD30D0 VA: 0x180AD3CD0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7C2400 Offset: 0x7C1800 VA: 0x1807C2400 Slot: 159
	public override ConversationData GetConversationFor(BasePlayer player) { }

	// RVA: 0xAD3D30 Offset: 0xAD3130 VA: 0x180AD3D30
	public void .ctor() { }

}

public class VehicleSpawner : BaseEntity // TypeDefIndex: 8852
{	// Fields
	public float spawnNudgeRadius; // 0x168
	public float cleanupRadius; // 0x16C
	public float occupyRadius; // 0x170
	public VehicleSpawner.SpawnPair[] objectsToSpawn; // 0x178
	public Transform spawnOffset; // 0x180
	public float safeRadius; // 0x188

	// Methods

	// RVA: 0xAD39B0 Offset: 0xAD2DB0 VA: 0x180AD39B0 Slot: 131
	public virtual int GetOccupyLayer() { }

	// RVA: 0xAD39C0 Offset: 0xAD2DC0 VA: 0x180AD39C0
	public BaseVehicle GetVehicleOccupying() { }

	// RVA: 0xAD3B60 Offset: 0xAD2F60 VA: 0x180AD3B60
	public void .ctor() { }

}

public class VehicleSpawner.SpawnPair // TypeDefIndex: 8853
{	// Fields
	public string message; // 0x10
	public GameObjectRef prefabToSpawn; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class EngineAudioClip : MonoBehaviour, IClientComponent // TypeDefIndex: 8987
{	// Fields
	public AudioClip granularClip; // 0x18
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

	// Methods

	// RVA: 0x8B1810 Offset: 0x8B0C10 VA: 0x1808B1810
	private int GetBucketRPM(int RPM) { }

	// RVA: 0x8B1680 Offset: 0x8B0A80 VA: 0x1808B1680
	private void Awake() { }

	// RVA: 0x8B22B0 Offset: 0x8B16B0 VA: 0x1808B22B0
	private void Update() { }

	// RVA: 0x8B2190 Offset: 0x8B1590 VA: 0x1808B2190
	private void UpdateRPM() { }

	// RVA: 0x8B1880 Offset: 0x8B0C80 VA: 0x1808B1880
	private void InitAudioClip() { }

	// RVA: 0x8B19B0 Offset: 0x8B0DB0 VA: 0x1808B19B0
	private void OnAudioRead(float[] data) { }

	// RVA: 0x8B1E20 Offset: 0x8B1220 VA: 0x1808B1E20
	private void SpawnGrain() { }

	// RVA: 0x8B1700 Offset: 0x8B0B00 VA: 0x1808B1700
	private void CleanupFinishedGrains() { }

	// RVA: 0x8B1B70 Offset: 0x8B0F70 VA: 0x1808B1B70
	private void SetupRPMBuckets() { }

	// RVA: 0x8B2680 Offset: 0x8B1A80 VA: 0x1808B2680
	public void .ctor() { }

}

public class EngineAudioClip.EngineCycle // TypeDefIndex: 8988
{	// Fields
	public int RPM; // 0x10
	public int startSample; // 0x14
	public int endSample; // 0x18
	public float period; // 0x1C
	public int id; // 0x20

	// Methods

	// RVA: 0x8B2B90 Offset: 0x8B1F90 VA: 0x1808B2B90
	public void .ctor(int RPM, int startSample, int endSample, float period, int id) { }

}

public class EngineAudioClip.EngineCycleBucket // TypeDefIndex: 8989
{	// Fields
	public int RPM; // 0x10
	public List<EngineAudioClip.EngineCycle> cycles; // 0x18
	public List<int> remainingCycles; // 0x20

	// Methods

	// RVA: 0x8B2AE0 Offset: 0x8B1EE0 VA: 0x1808B2AE0
	public void .ctor(int RPM) { }

	// RVA: 0x8B2910 Offset: 0x8B1D10 VA: 0x1808B2910
	public EngineAudioClip.EngineCycle GetCycle(Random random, int lastCycleId) { }

	// RVA: 0x8B2A20 Offset: 0x8B1E20 VA: 0x1808B2A20
	private void ResetRemainingCycles(Random random) { }

	// RVA: 0x8B28A0 Offset: 0x8B1CA0 VA: 0x1808B28A0
	public void Add(EngineAudioClip.EngineCycle cycle) { }

}

public class EngineAudioClip.Grain // TypeDefIndex: 8990
{	// Fields
	private float[] sourceData; // 0x10
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

	// Properties
	public bool finished { get; }

	// Methods

	// RVA: 0x5BE730 Offset: 0x5BDB30 VA: 0x1805BE730
	public bool get_finished() { }

	// RVA: 0x8C63C0 Offset: 0x8C57C0 VA: 0x1808C63C0
	public void Init(float[] source, EngineAudioClip.EngineCycle cycle, int cyclePadding) { }

	// RVA: 0x8C6300 Offset: 0x8C5700 VA: 0x1808C6300
	public float GetSample() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class BaseVehicleMountPoint : BaseMountable // TypeDefIndex: 9696
{	// Methods

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 147
	public override bool DirectlyMountable() { }

	// RVA: 0x914A30 Offset: 0x913E30 VA: 0x180914A30 Slot: 170
	public override BaseVehicle VehicleParent() { }

	// RVA: 0x914980 Offset: 0x913D80 VA: 0x180914980 Slot: 109
	public override bool BlocksWaterFor(BasePlayer player) { }

	// RVA: 0x914BA0 Offset: 0x913FA0 VA: 0x180914BA0 Slot: 156
	public override float WaterFactorForPlayer(BasePlayer player) { }

	// RVA: 0x9148E0 Offset: 0x913CE0 VA: 0x1809148E0 Slot: 108
	public override float AirFactor() { }

	// RVA: 0x914C50 Offset: 0x914050 VA: 0x180914C50
	public void .ctor() { }

}

public class BaseVehicleSeat : BaseVehicleMountPoint // TypeDefIndex: 9697
{	// Fields
	public float mountedAnimationSpeed; // 0x320
	public bool sendClientInputToVehicleParent; // 0x324
	public bool forcePlayerModelUpdate; // 0x325

	// Methods

	// RVA: 0x914CD0 Offset: 0x9140D0 VA: 0x180914CD0 Slot: 158
	public override void OnClientInput(BasePlayer player) { }

	// RVA: 0x914D90 Offset: 0x914190 VA: 0x180914D90 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x914CC0 Offset: 0x9140C0 VA: 0x180914CC0 Slot: 164
	public override float GetMountedAnimationSpeed() { }

	// RVA: 0x914CB0 Offset: 0x9140B0 VA: 0x180914CB0 Slot: 159
	public override bool ForceUpdatePlayerModel(BasePlayer p) { }

	// RVA: 0x914C50 Offset: 0x914050 VA: 0x180914C50
	public void .ctor() { }

}

public class EngineAudioSet : ScriptableObject // TypeDefIndex: 9734
{	// Fields
	public BlendedEngineLoopDefinition[] engineAudioLoops; // 0x18
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

	// Methods

	// RVA: 0x8B27F0 Offset: 0x8B1BF0 VA: 0x1808B27F0
	public BlendedEngineLoopDefinition GetEngineLoopDef(int numEngines) { }

	// RVA: 0x8B2830 Offset: 0x8B1C30 VA: 0x1808B2830
	public void .ctor() { }

}

public class ModularCarCentralLockingSwitch : VehicleModuleButtonComponent // TypeDefIndex: 9737
{	// Fields
	public Transform centralLockingSwitch; // 0x28
	public Vector3 switchOffPos; // 0x30
	public Vector3 switchOnPos; // 0x3C

	// Methods

	// RVA: 0x7725E0 Offset: 0x7719E0 VA: 0x1807725E0 Slot: 4
	public override void ClientUse(BasePlayer player, BaseVehicleModule parentModule) { }

	// RVA: 0x772460 Offset: 0x771860 VA: 0x180772460 Slot: 5
	public override void ClientUpdateTick(BaseVehicleModule parentModule) { }

	// RVA: 0x7726F0 Offset: 0x771AF0 VA: 0x1807726F0
	public void .ctor() { }

}

public class ModularCarChassisVisuals : VehicleChassisVisuals<ModularCar>, IClientComponent // TypeDefIndex: 9738
{	// Fields
	public Transform frontAxle; // 0x30
	public Transform rearAxle; // 0x38
	public ModularCarChassisVisuals.Steering steering; // 0x40
	public ModularCarChassisVisuals.LookAtTarget transmission; // 0x48
	private ModularCar modularCar; // 0x50

	// Methods

	// RVA: 0x772700 Offset: 0x771B00 VA: 0x180772700 Slot: 4
	public override void Init(ModularCar owner, VehicleChassisVisuals.ClientWheelData<ModularCar>[] clientWheelData) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	protected override void PreWheelUpdateTick() { }

	// RVA: 0x772960 Offset: 0x771D60 VA: 0x180772960 Slot: 7
	protected override void PostWheelUpdateTick(bool instant, bool isCloseToCamera, float steer, float dt) { }

	// RVA: 0x772E80 Offset: 0x772280 VA: 0x180772E80 Slot: 6
	protected override void UpdateWheelVisuals(VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData, bool isOn, float steer, float dt) { }

	// RVA: 0x772AF0 Offset: 0x771EF0 VA: 0x180772AF0
	private void UpdateAxle(Transform axle, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataL, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataR, float dt, bool instant) { }

	// RVA: 0x772770 Offset: 0x771B70 VA: 0x180772770
	private void LookAt(ModularCarChassisVisuals.LookAtTarget lookAt) { }

	// RVA: 0x773120 Offset: 0x772520 VA: 0x180773120
	public void .ctor() { }

}

public class ModularCarChassisVisuals.Steering // TypeDefIndex: 9739
{	// Fields
	public Transform steerL; // 0x10
	public Transform steerR; // 0x18
	public ModularCarChassisVisuals.LookAtTarget steerRodL; // 0x20
	public ModularCarChassisVisuals.LookAtTarget steerRodR; // 0x28
	public ModularCarChassisVisuals.LookAtTarget steeringArm; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class ModularCarChassisVisuals.LookAtTarget // TypeDefIndex: 9740
{	// Fields
	public Transform aim; // 0x10
	public Transform target; // 0x18
	public Vector3 angleAdjust; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class VehicleLiftOccupantTrigger : TriggerBase // TypeDefIndex: 9741
{	// Methods

	// RVA: 0x4D0250 Offset: 0x4CF650 VA: 0x1804D0250
	public void .ctor() { }

}

public class ModularCarLock // TypeDefIndex: 9743
{	// Fields
	private readonly bool isServer; // 0x10
	private readonly ModularCar owner; // 0x18
	public int LockID; // 0x20
	public const BaseEntity.Flags FLAG_CENTRAL_LOCKING = 256;
	public const float LOCK_DESTROY_HEALTH = 0,15;

	// Properties
	public bool HasALock { get; }
	public bool IsLocked { get; }
	public bool CentralLockingIsOn { get; }

	// Methods

	// RVA: 0x774F90 Offset: 0x774390 VA: 0x180774F90
	public bool get_HasALock() { }

	// RVA: 0x774FA0 Offset: 0x7743A0 VA: 0x180774FA0
	public bool get_IsLocked() { }

	// RVA: 0x774F00 Offset: 0x774300 VA: 0x180774F00
	public bool get_CentralLockingIsOn() { }

	// RVA: 0x774EB0 Offset: 0x7742B0 VA: 0x180774EB0
	public void .ctor(ModularCar owner, bool isServer) { }

	// RVA: 0x774DB0 Offset: 0x7741B0 VA: 0x180774DB0
	public bool PlayerHasUnlockPermission(BasePlayer player) { }

	// RVA: 0x774D60 Offset: 0x774160 VA: 0x180774D60
	public bool PlayerCanUseThis(BasePlayer player, ModularCarLock.LockType lockType) { }

	// RVA: 0x774D20 Offset: 0x774120 VA: 0x180774D20
	public bool PlayerCanDestroyLock(BaseVehicleModule viaModule) { }

	// RVA: 0x774CE0 Offset: 0x7740E0 VA: 0x180774CE0
	private bool KeyCanUnlockThis(Item key) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x774CE0 Offset: 0x7740E0 VA: 0x180774CE0
	private bool <PlayerHasUnlockPermission>b__13_0(Item key) { }

}

public enum ModularCarLock.LockType // TypeDefIndex: 9744
{	// Fields
	public int value__; // 0x0
	public const ModularCarLock.LockType Door = 0;
	public const ModularCarLock.LockType General = 1;

}

public class ModularCarPresetConfig : ScriptableObject // TypeDefIndex: 9745
{	// Fields
	public ItemModVehicleModule[] socketItemDefs; // 0x18

	// Methods

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public class ModularCarSeat : MouseSteerableSeat // TypeDefIndex: 9746
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 leftFootIKPos; // 0x330
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 rightFootIKPos; // 0x33C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 leftHandIKPos; // 0x348
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 rightHandIKPos; // 0x354
	public float providesComfort; // 0x360

	// Properties
	public bool HasLeftFootIK { get; }
	public bool HasRightFootIK { get; }
	public Vector3 LeftFootIKPos { get; }
	public Vector3 RightFootIKPos { get; }
	public bool HasLeftHandIK { get; }
	public bool HasRightHandIK { get; }
	public Vector3 LeftHandIKPos { get; }
	public Vector3 RightHandIKPos { get; }

	// Methods

	// RVA: 0x775500 Offset: 0x774900 VA: 0x180775500
	public bool get_HasLeftFootIK() { }

	// RVA: 0x775540 Offset: 0x774940 VA: 0x180775540
	public bool get_HasRightFootIK() { }

	// RVA: 0x775580 Offset: 0x774980 VA: 0x180775580
	public Vector3 get_LeftFootIKPos() { }

	// RVA: 0x775660 Offset: 0x774A60 VA: 0x180775660
	public Vector3 get_RightFootIKPos() { }

	// RVA: 0x775520 Offset: 0x774920 VA: 0x180775520
	public bool get_HasLeftHandIK() { }

	// RVA: 0x775560 Offset: 0x774960 VA: 0x180775560
	public bool get_HasRightHandIK() { }

	// RVA: 0x7755F0 Offset: 0x7749F0 VA: 0x1807755F0
	public Vector3 get_LeftHandIKPos() { }

	// RVA: 0x7756D0 Offset: 0x774AD0 VA: 0x1807756D0
	public Vector3 get_RightHandIKPos() { }

	// RVA: 0x7754F0 Offset: 0x7748F0 VA: 0x1807754F0
	public void .ctor() { }

}

public class ModularVehicleShopFront : ShopFront // TypeDefIndex: 9747
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float maxUseDistance; // 0x3F0

	// Methods

	// RVA: 0x7789F0 Offset: 0x777DF0 VA: 0x1807789F0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x778A80 Offset: 0x777E80 VA: 0x180778A80 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x778B90 Offset: 0x777F90 VA: 0x180778B90
	private bool WithinUseDistance(BasePlayer player) { }

	// RVA: 0x778C00 Offset: 0x778000 VA: 0x180778C00
	public void .ctor() { }

}

public class CamperSeatConfig : MonoBehaviour // TypeDefIndex: 9748
{	// Fields
	public Transform[] SeatPositions; // 0x18
	public Transform StovePosition; // 0x20
	public Transform StoragePosition; // 0x28

	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public abstract class VehicleModuleButtonComponent : MonoBehaviour // TypeDefIndex: 9749
{	// Fields
	public string interactionColliderName; // 0x18
	public SoundDefinition pressSoundDef; // 0x20

	// Methods

	// RVA: 0xACC830 Offset: 0xACBC30 VA: 0x180ACC830 Slot: 4
	public virtual void ClientUse(BasePlayer player, BaseVehicleModule parentModule) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public virtual void ClientUpdateTick(BaseVehicleModule parentModule) { }

	// RVA: 0xACC8F0 Offset: 0xACBCF0 VA: 0x180ACC8F0
	protected void .ctor() { }

}

public class VehicleModuleEngine : VehicleModuleStorage // TypeDefIndex: 9750
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
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

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 199
	public override bool get_HasAnEngine() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xACF960 Offset: 0xACED60 VA: 0x180ACF960
	public bool get_IsUsable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xACF9D0 Offset: 0xACEDD0 VA: 0x180ACF9D0
	private void set_IsUsable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xACF9A0 Offset: 0xACEDA0 VA: 0x180ACF9A0
	public float get_PerformanceFractionAcceleration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xACF9F0 Offset: 0xACEDF0 VA: 0x180ACF9F0
	private void set_PerformanceFractionAcceleration(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xACF9C0 Offset: 0xACEDC0 VA: 0x180ACF9C0
	public float get_PerformanceFractionTopSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xACFA10 Offset: 0xACEE10 VA: 0x180ACFA10
	private void set_PerformanceFractionTopSpeed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xACF9B0 Offset: 0xACEDB0 VA: 0x180ACF9B0
	public float get_PerformanceFractionFuelEconomy() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xACFA00 Offset: 0xACEE00 VA: 0x180ACFA00
	private void set_PerformanceFractionFuelEconomy(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xACF990 Offset: 0xACED90 VA: 0x180ACF990
	public float get_OverallPerformanceFraction() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xACF9E0 Offset: 0xACEDE0 VA: 0x180ACF9E0
	private void set_OverallPerformanceFraction(float value) { }

	// RVA: 0xACF810 Offset: 0xACEC10 VA: 0x180ACF810
	public bool get_AtLowPerformance() { }

	// RVA: 0xACF830 Offset: 0xACEC30 VA: 0x180ACF830
	public bool get_AtPeakPerformance() { }

	// RVA: 0xACF970 Offset: 0xACED70 VA: 0x180ACF970
	public int get_KW() { }

	// RVA: 0xACF8A0 Offset: 0xACECA0 VA: 0x180ACF8A0
	public EngineAudioSet get_AudioSet() { }

	// RVA: 0xACF8C0 Offset: 0xACECC0 VA: 0x180ACF8C0
	private bool get_EngineIsOn() { }

	// RVA: 0xACF1A0 Offset: 0xACE5A0 VA: 0x180ACF1A0 Slot: 28
	public override void InitShared() { }

	// RVA: 0xACF310 Offset: 0xACE710 VA: 0x180ACF310 Slot: 202
	public override void OnEngineStateChanged(VehicleEngineController.EngineState<GroundVehicle> oldState, VehicleEngineController.EngineState<GroundVehicle> newState) { }

	// RVA: 0xACF070 Offset: 0xACE470 VA: 0x180ACF070 Slot: 203
	public override float GetMaxDriveForce() { }

	// RVA: 0xACF550 Offset: 0xACE950 VA: 0x180ACF550
	public void RefreshPerformanceStats(EngineStorage engineStorage) { }

	// RVA: 0xACF0C0 Offset: 0xACE4C0 VA: 0x180ACF0C0
	private float GetPerformanceFraction(float statBoostPercent) { }

	// RVA: 0xACF240 Offset: 0xACE640 VA: 0x180ACF240 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xACE8F0 Offset: 0xACDCF0 VA: 0x180ACE8F0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0xACE990 Offset: 0xACDD90 VA: 0x180ACE990 Slot: 194
	public override void ClientVehicleTick() { }

	// RVA: 0xACF3F0 Offset: 0xACE7F0 VA: 0x180ACF3F0
	private void PlayBadPerformanceSound() { }

	// RVA: 0xACF6F0 Offset: 0xACEAF0 VA: 0x180ACF6F0
	private void StopBadPerformanceSound() { }

	// RVA: 0xACF660 Offset: 0xACEA60 VA: 0x180ACF660
	private void SetFXState(bool isOn) { }

	// RVA: 0xACF7B0 Offset: 0xACEBB0 VA: 0x180ACF7B0
	public void .ctor() { }

}

public class VehicleModuleEngine.Engine // TypeDefIndex: 9751
{	// Fields
	[HeaderAttribute] // RVA: 0x8EC10 Offset: 0x8E010 VA: 0x18008EC10
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

	// Methods

	// RVA: 0xAC2F70 Offset: 0xAC2370 VA: 0x180AC2F70
	public void .ctor() { }

}

public class VehicleLight : MonoBehaviour, IClientComponent // TypeDefIndex: 9753
{	// Fields
	public bool IsBrake; // 0x18
	public GameObject toggleObject; // 0x20
	public VehicleLight.LightRenderer[] renderers; // 0x28
	[ColorUsageAttribute] // RVA: 0x859B0 Offset: 0x84DB0 VA: 0x1800859B0
	public Color lightOnColour; // 0x30
	[ColorUsageAttribute] // RVA: 0x859B0 Offset: 0x84DB0 VA: 0x1800859B0
	public Color brakesOnColour; // 0x40
	private static MaterialPropertyBlock materialPB; // 0x0
	private static int emissionColorID; // 0x8

	// Methods

	// RVA: 0xACC570 Offset: 0xACB970 VA: 0x180ACC570
	public void SetLightVisuals(bool headlightsOn, bool brakesOn) { }

	// RVA: 0xACC300 Offset: 0xACB700 VA: 0x180ACC300
	public static void SetLightVisuals(IReadOnlyList<VehicleLight> lights, bool headlightsOn, bool brakesOn) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0xACC7E0 Offset: 0xACBBE0 VA: 0x180ACC7E0
	private static void .cctor() { }

}

public class VehicleLight.LightRenderer // TypeDefIndex: 9754
{	// Fields
	public Renderer renderer; // 0x10
	public int matIndex; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class EngineDamageOverTime // TypeDefIndex: 9761
{	// Fields
	private readonly List<EngineDamageOverTime.RecentDamage> recentDamage; // 0x10
	private readonly float maxSeconds; // 0x18
	private readonly float triggerDamage; // 0x1C
	private readonly Action trigger; // 0x20

	// Methods

	// RVA: 0x8B2E70 Offset: 0x8B2270 VA: 0x1808B2E70
	public void .ctor(float triggerDamage, float maxSeconds, Action trigger) { }

	// RVA: 0x8B2D00 Offset: 0x8B2100 VA: 0x1808B2D00
	public void TakeDamage(float amount) { }

	// RVA: 0x8B2BF0 Offset: 0x8B1FF0 VA: 0x1808B2BF0
	private float GetRecentDamage() { }

}

private struct EngineDamageOverTime.RecentDamage // TypeDefIndex: 9762
{	// Fields
	public readonly float time; // 0x0
	public readonly float amount; // 0x4

	// Methods

	// RVA: 0xF2260 Offset: 0xF1660 VA: 0x1800F2260
	public void .ctor(float time, float amount) { }

}

public abstract class VehicleChassisVisuals<T> : MonoBehaviour // TypeDefIndex: 9780
{	// Fields
	protected T owner; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private VehicleChassisVisuals.ClientWheelData<T>[] <clientWheelData>k__BackingField; // 0x0
	private float prevSteer; // 0x0
	private bool isStopped; // 0x0

	// Properties
	public VehicleChassisVisuals.ClientWheelData<T>[] clientWheelData { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public VehicleChassisVisuals.ClientWheelData<T>[] get_clientWheelData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	|-VehicleChassisVisuals<object>.get_clientWheelData
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	protected void set_clientWheelData(VehicleChassisVisuals.ClientWheelData<T>[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	|-VehicleChassisVisuals<object>.set_clientWheelData
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public virtual void Init(T owner, VehicleChassisVisuals.ClientWheelData<T>[] clientWheelData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C8DE0 Offset: 0x19C81E0 VA: 0x1819C8DE0
	|-VehicleChassisVisuals<ModularCar>.Init
	|-VehicleChassisVisuals<Snowmobile>.Init
	|-VehicleChassisVisuals<object>.Init
	*/

	// RVA: -1 Offset: -1
	public void UpdateTick(float dt, bool instantForced = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C9860 Offset: 0x19C8C60 VA: 0x1819C9860
	|-VehicleChassisVisuals<ModularCar>.UpdateTick
	|-VehicleChassisVisuals<Snowmobile>.UpdateTick
	|-VehicleChassisVisuals<object>.UpdateTick
	*/

	// RVA: -1 Offset: -1
	public bool IsGrounded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C8E50 Offset: 0x19C8250 VA: 0x1819C8E50
	|-VehicleChassisVisuals<Snowmobile>.IsGrounded
	|-VehicleChassisVisuals<object>.IsGrounded
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void PreWheelUpdateTick();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals<object>.PreWheelUpdateTick
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void UpdateWheelVisuals(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool isOn, float steer, float dt);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals<object>.UpdateWheelVisuals
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void PostWheelUpdateTick(bool instant, bool isCloseToCamera, float steer, float dt);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VehicleChassisVisuals<object>.PostWheelUpdateTick
	*/

	// RVA: -1 Offset: -1
	public float CalculateWheelSlip() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C8720 Offset: 0x19C7B20 VA: 0x1819C8720
	|-VehicleChassisVisuals<ModularCar>.CalculateWheelSlip
	|-VehicleChassisVisuals<Snowmobile>.CalculateWheelSlip
	|-VehicleChassisVisuals<object>.CalculateWheelSlip
	*/

	// RVA: -1 Offset: -1
	protected void UpdateWheelSuspensionData(VehicleChassisVisuals.ClientWheelData<T> wheelData, Vector3 traceSource, Nullable<Vector3> traceSource2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C9C70 Offset: 0x19C9070 VA: 0x1819C9C70
	|-VehicleChassisVisuals<ModularCar>.UpdateWheelSuspensionData
	|-VehicleChassisVisuals<Snowmobile>.UpdateWheelSuspensionData
	|-VehicleChassisVisuals<object>.UpdateWheelSuspensionData
	*/

	// RVA: -1 Offset: -1
	protected float GetWheelRotation(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool receivingDriveWheelVels, float dt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C8B60 Offset: 0x19C7F60 VA: 0x1819C8B60
	|-VehicleChassisVisuals<ModularCar>.GetWheelRotation
	|-VehicleChassisVisuals<Snowmobile>.GetWheelRotation
	|-VehicleChassisVisuals<object>.GetWheelRotation
	*/

	// RVA: -1 Offset: -1
	protected static void UpdateSteerRotation(Transform t, float steer, int axis) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C9770 Offset: 0x19C8B70 VA: 0x1819C9770
	|-VehicleChassisVisuals<ModularCar>.UpdateSteerRotation
	|-VehicleChassisVisuals<object>.UpdateSteerRotation
	*/

	// RVA: -1 Offset: -1
	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, float throttleInput) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C8F20 Offset: 0x19C8320 VA: 0x1819C8F20
	|-VehicleChassisVisuals<ModularCar>.ShowTerrainFX
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	// RVA: -1 Offset: -1
	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, float throttleInput, float speed, float minSpeed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C9380 Offset: 0x19C8780 VA: 0x1819C9380
	|-VehicleChassisVisuals<Snowmobile>.ShowTerrainFX
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	// RVA: -1 Offset: -1
	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool isOnWater, float spinSlip, TerrainConfig.GroundType groundType, float throttleInput) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C9010 Offset: 0x19C8410 VA: 0x1819C9010
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	// RVA: -1 Offset: -1
	protected static void ShowTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData, bool isOnWater, float spinSlip, TerrainConfig.GroundType groundType, float throttleInput, float speed, float minSpeed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C90E0 Offset: 0x19C84E0 VA: 0x1819C90E0
	|-VehicleChassisVisuals<Snowmobile>.ShowTerrainFX
	|-VehicleChassisVisuals<object>.ShowTerrainFX
	*/

	// RVA: -1 Offset: -1
	public void UpdateTickStopped() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C9810 Offset: 0x19C8C10 VA: 0x1819C9810
	|-VehicleChassisVisuals<ModularCar>.UpdateTickStopped
	|-VehicleChassisVisuals<Snowmobile>.UpdateTickStopped
	|-VehicleChassisVisuals<object>.UpdateTickStopped
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected virtual void StopAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C94A0 Offset: 0x19C88A0 VA: 0x1819C94A0
	|-VehicleChassisVisuals<ModularCar>.StopAll
	|-VehicleChassisVisuals<Snowmobile>.StopAll
	|-VehicleChassisVisuals<object>.StopAll
	*/

	// RVA: -1 Offset: -1
	protected static void StopTerrainFX(VehicleChassisVisuals.ClientWheelData<T> wheelData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C9550 Offset: 0x19C8950 VA: 0x1819C9550
	|-VehicleChassisVisuals<object>.StopTerrainFX
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x8ED830 Offset: 0x8ECC30 VA: 0x1808ED830
	|-VehicleChassisVisuals<ModularCar>..ctor
	|-VehicleChassisVisuals<Snowmobile>..ctor
	|-VehicleChassisVisuals<object>..ctor
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal static bool <UpdateWheelSuspensionData>g__GetSuspensionHit|17_0(Vector3 ts, out RaycastHit hit, ref VehicleChassisVisuals.<>c__DisplayClass17_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C9650 Offset: 0x19C8A50 VA: 0x1819C9650
	|-VehicleChassisVisuals<object>.<UpdateWheelSuspensionData>g__GetSuspensionHit|17_0
	*/

}

public class VehicleChassisVisuals.ClientWheelData<T> // TypeDefIndex: 9782
{	// Fields
	public VisualCarWheel wheel; // 0x0
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

	// Properties
	public bool isOnHardGround { get; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_isOnHardGround() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B66F0 Offset: 0x19B5AF0 VA: 0x1819B66F0
	|-VehicleChassisVisuals.ClientWheelData<ModularCar>.get_isOnHardGround
	|-VehicleChassisVisuals.ClientWheelData<object>.get_isOnHardGround
	*/

	// RVA: -1 Offset: -1
	public void .ctor(VisualCarWheel wheel, Transform vehicleTransform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B6620 Offset: 0x19B5A20 VA: 0x1819B6620
	|-VehicleChassisVisuals.ClientWheelData<ModularCar>..ctor
	|-VehicleChassisVisuals.ClientWheelData<Snowmobile>..ctor
	|-VehicleChassisVisuals.ClientWheelData<object>..ctor
	*/

}

private struct VehicleChassisVisuals.<>c__DisplayClass17_0<T> // TypeDefIndex: 9784
{	// Fields
	public Vector3 vehicleDown; // 0x0
	public float wheelRadius; // 0x0
	public float suspensionDistance; // 0x0

}

public class VehicleEngineController<TOwner> // TypeDefIndex: 9786
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EntityFuelSystem <FuelSystem>k__BackingField; // 0x0
	private readonly TOwner owner; // 0x0
	private readonly bool isServer; // 0x0
	private readonly float engineStartupTime; // 0x0
	private readonly Transform waterloggedPoint; // 0x0
	private readonly BaseEntity.Flags engineStartingFlag; // 0x0

	// Properties
	public VehicleEngineController.EngineState<TOwner> CurEngineState { get; }
	public bool IsOn { get; }
	public bool IsOff { get; }
	public bool IsStarting { get; }
	public bool IsStartingOrOn { get; }
	public EntityFuelSystem FuelSystem { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public VehicleEngineController.EngineState<TOwner> get_CurEngineState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CA340 Offset: 0x19C9740 VA: 0x1819CA340
	|-VehicleEngineController<BaseSubmarine>.get_CurEngineState
	|-VehicleEngineController<GroundVehicle>.get_CurEngineState
	|-VehicleEngineController<MiniCopter>.get_CurEngineState
	|-VehicleEngineController<object>.get_CurEngineState
	|-VehicleEngineController<TrainEngine>.get_CurEngineState
	*/

	// RVA: -1 Offset: -1
	public bool get_IsOn() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CA3A0 Offset: 0x19C97A0 VA: 0x1819CA3A0
	|-VehicleEngineController<BaseSubmarine>.get_IsOn
	|-VehicleEngineController<GroundVehicle>.get_IsOn
	|-VehicleEngineController<object>.get_IsOn
	*/

	// RVA: -1 Offset: -1
	public bool get_IsOff() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15E14E0 Offset: 0x15E08E0 VA: 0x1815E14E0
	|-VehicleEngineController<object>.get_IsOff
	|-VehicleEngineController<TrainEngine>.get_IsOff
	*/

	// RVA: -1 Offset: -1
	public bool get_IsStarting() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CA400 Offset: 0x19C9800 VA: 0x1819CA400
	|-VehicleEngineController<MiniCopter>.get_IsStarting
	|-VehicleEngineController<object>.get_IsStarting
	*/

	// RVA: -1 Offset: -1
	public bool get_IsStartingOrOn() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CA3D0 Offset: 0x19C97D0 VA: 0x1819CA3D0
	|-VehicleEngineController<GroundVehicle>.get_IsStartingOrOn
	|-VehicleEngineController<object>.get_IsStartingOrOn
	|-VehicleEngineController<TrainEngine>.get_IsStartingOrOn
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public EntityFuelSystem get_FuelSystem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	|-VehicleEngineController<BaseSubmarine>.get_FuelSystem
	|-VehicleEngineController<GroundVehicle>.get_FuelSystem
	|-VehicleEngineController<MiniCopter>.get_FuelSystem
	|-VehicleEngineController<object>.get_FuelSystem
	|-VehicleEngineController<TrainEngine>.get_FuelSystem
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	private void set_FuelSystem(EntityFuelSystem value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	|-VehicleEngineController<object>.set_FuelSystem
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TOwner owner, bool isServer, float engineStartupTime, GameObjectRef fuelStoragePrefab, Transform waterloggedPoint, BaseEntity.Flags engineStartingFlag = 128) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CA220 Offset: 0x19C9620 VA: 0x1819CA220
	|-VehicleEngineController<BaseSubmarine>..ctor
	|-VehicleEngineController<GroundVehicle>..ctor
	|-VehicleEngineController<MiniCopter>..ctor
	|-VehicleEngineController<object>..ctor
	|-VehicleEngineController<TrainEngine>..ctor
	*/

	// RVA: -1 Offset: -1
	public VehicleEngineController.EngineState<TOwner> EngineStateFrom(BaseEntity.Flags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19CA120 Offset: 0x19C9520 VA: 0x1819CA120
	|-VehicleEngineController<object>.EngineStateFrom
	|-VehicleEngineController<TrainEngine>.EngineStateFrom
	*/

}

public enum VehicleEngineController.EngineState<TOwner> // TypeDefIndex: 9787
{	// Fields
	public int value__; // 0x0
	public const VehicleEngineController.EngineState<TOwner> Off = 0;
	public const VehicleEngineController.EngineState<TOwner> Starting = 1;
	public const VehicleEngineController.EngineState<TOwner> On = 2;

}

public class VehicleSpawnPoint : SpaceCheckingSpawnPoint // TypeDefIndex: 10010
{	// Methods

	// RVA: 0xAD39A0 Offset: 0xAD2DA0 VA: 0x180AD39A0
	public void .ctor() { }

}

public class EngineItemInformationPanel : ItemInformationPanel // TypeDefIndex: 11001
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Methods

	// RVA: 0x8B2F20 Offset: 0x8B2320 VA: 0x1808B2F20 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0x8B2FA0 Offset: 0x8B23A0 VA: 0x1808B2FA0 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

public class VehicleEditingItemIcon : MonoBehaviour, IInventoryChanged // TypeDefIndex: 11060
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image foregroundImage; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Image linkImage; // 0x20
	private ItemIcon itemIcon; // 0x28

	// Methods

	// RVA: 0xAC8FB0 Offset: 0xAC83B0 VA: 0x180AC8FB0
	protected void Awake() { }

	// RVA: 0xAC9250 Offset: 0xAC8650 VA: 0x180AC9250
	protected void OnEnable() { }

	// RVA: 0xAC91D0 Offset: 0xAC85D0 VA: 0x180AC91D0
	protected void OnDisable() { }

	// RVA: 0xAC9310 Offset: 0xAC8710 VA: 0x180AC9310 Slot: 4
	public void OnInventoryChanged() { }

	// RVA: 0xAC9040 Offset: 0xAC8440 VA: 0x180AC9040
	private void InventoryChangeRefresh() { }

	// RVA: 0xAC9320 Offset: 0xAC8720 VA: 0x180AC9320
	private void SetLinkSprite(Sprite sprite) { }

	// RVA: 0xAC9000 Offset: 0xAC8400 VA: 0x180AC9000
	private void ClearLinkSprite() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class VehicleEditingPanel : LootPanel // TypeDefIndex: 11061
{	// Fields
	[SerializeField] // RVA: 0x76430 Offset: 0x75830 VA: 0x180076430
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

	// Properties
	private Item CurSelectedItem { get; }
	private ItemContainer ModulesContainer { get; }
	private ItemContainer ChassisContainer { get; }
	private ItemContainer ModuleInternalItemContainer { get; }

	// Methods

	// RVA: 0xACC240 Offset: 0xACB640 VA: 0x180ACC240
	private Item get_CurSelectedItem() { }

	// RVA: 0xACC2F0 Offset: 0xACB6F0 VA: 0x180ACC2F0
	private ItemContainer get_ModulesContainer() { }

	// RVA: 0xACC230 Offset: 0xACB630 VA: 0x180ACC230
	private ItemContainer get_ChassisContainer() { }

	// RVA: 0xACC2E0 Offset: 0xACB6E0 VA: 0x180ACC2E0
	private ItemContainer get_ModuleInternalItemContainer() { }

	// RVA: 0xAC9B50 Offset: 0xAC8F50 VA: 0x180AC9B50
	protected void OnEnable() { }

	// RVA: 0xACC010 Offset: 0xACB410 VA: 0x180ACC010 Slot: 5
	public override void Update() { }

	// RVA: 0xACB860 Offset: 0xACAC60 VA: 0x180ACB860
	public void RepairClicked() { }

	// RVA: 0xAC95A0 Offset: 0xAC89A0 VA: 0x180AC95A0
	public void CraftLockClicked() { }

	// RVA: 0xACB7E0 Offset: 0xACABE0 VA: 0x180ACB7E0
	public void RemoveLockClicked() { }

	// RVA: 0xAC9650 Offset: 0xAC8A50 VA: 0x180AC9650
	public void DestroyChassisClicked() { }

	// RVA: 0xACB9B0 Offset: 0xACADB0 VA: 0x180ACB9B0
	public void TakeInternalItemsClicked() { }

	// RVA: 0xAC98E0 Offset: 0xAC8CE0 VA: 0x180AC98E0
	public void OnCopyFromLiquidDown() { }

	// RVA: 0xAC9960 Offset: 0xAC8D60 VA: 0x180AC9960
	public void OnCopyFromLiquidUp() { }

	// RVA: 0xACB910 Offset: 0xACAD10 VA: 0x180ACB910
	private bool SelectedValidLiquidTarget() { }

	// RVA: 0xAC9780 Offset: 0xAC8B80 VA: 0x180AC9780
	private void LiquidCopyFrom() { }

	// RVA: 0xAC9370 Offset: 0xAC8770 VA: 0x180AC9370
	private bool CanTakeLiquid() { }

	// RVA: 0xAC96F0 Offset: 0xAC8AF0 VA: 0x180AC96F0
	private ModularCarGarage GetGarage() { }

	// RVA: 0xACA010 Offset: 0xAC9410 VA: 0x180ACA010
	private void RefreshEditUI() { }

	// RVA: 0xACA270 Offset: 0xAC9670 VA: 0x180ACA270
	private void RefreshHasVehicle(ModularCarGarage garage, bool forced = False) { }

	// RVA: 0xACA3E0 Offset: 0xAC97E0 VA: 0x180ACA3E0
	private void RefreshInfoText() { }

	// RVA: 0xACB390 Offset: 0xACA790 VA: 0x180ACB390
	private void RefreshWarningText() { }

	// RVA: 0xAC9D00 Offset: 0xAC9100 VA: 0x180AC9D00
	private void OnSelectedItemChanged(Item newSelectedItem) { }

	// RVA: 0xAC9D90 Offset: 0xAC9190 VA: 0x180AC9D90
	private void RefreshDestroyGroup(ModularCarGarage garage) { }

	// RVA: 0xACA6D0 Offset: 0xAC9AD0 VA: 0x180ACA6D0
	private void RefreshLockCreation(ModularCarGarage garage) { }

	// RVA: 0xACAD30 Offset: 0xACA130 VA: 0x180ACAD30
	private void RefreshRepair() { }

	// RVA: 0xACC220 Offset: 0xACB620 VA: 0x180ACC220
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xACBC70 Offset: 0xACB070 VA: 0x180ACBC70
	private bool <RefreshLockCreation>g__AddResourceInfo|72_0(string prefixText, ItemAmount ingredient, ref VehicleEditingPanel.<>c__DisplayClass72_0 ) { }

}

private class VehicleEditingPanel.CreateChassisEntry // TypeDefIndex: 11062
{	// Fields
	public byte garageChassisIndex; // 0x10
	public Button craftButton; // 0x18
	public Text craftButtonText; // 0x20
	public Text requirementsText; // 0x28

	// Methods

	// RVA: 0xAC2F20 Offset: 0xAC2320 VA: 0x180AC2F20
	public ItemDefinition GetChassisItemDef(ModularCarGarage garage) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private struct VehicleEditingPanel.<>c__DisplayClass72_0 // TypeDefIndex: 11063
{	// Fields
	public VehicleEditingPanel <>4__this; // 0x0
	public string infoText; // 0x8

}

public class VehicleModuleInformationPanel : ItemInformationPanel // TypeDefIndex: 11064
{	// Fields
	public ItemStatValue socketsDisplay; // 0x18
	public ItemStatValue hpDisplay; // 0x20

	// Methods

	// RVA: 0xACFA20 Offset: 0xACEE20 VA: 0x180ACFA20 Slot: 4
	public override bool EligableForDisplay(ItemDefinition info) { }

	// RVA: 0xACFA70 Offset: 0xACEE70 VA: 0x180ACFA70 Slot: 5
	public override void SetupForItem(ItemDefinition info, Item item) { }

	// RVA: 0x4B7D40 Offset: 0x4B7140 VA: 0x1804B7D40
	public void .ctor() { }

}

public class vehicle : ConsoleSystem // TypeDefIndex: 11968
{	// Methods

	// RVA: 0x3749B0 Offset: 0x373DB0 VA: 0x1803749B0
	public void .ctor() { }

}

public static class EngineItemTypeEx // TypeDefIndex: 12098
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9B30 Offset: 0x4B8F30 VA: 0x1804B9B30
	public static bool BoostsAcceleration(EngineStorage.EngineItemTypes engineItemType) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9B50 Offset: 0x4B8F50 VA: 0x1804B9B50
	public static bool BoostsTopSpeed(EngineStorage.EngineItemTypes engineItemType) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9B40 Offset: 0x4B8F40 VA: 0x1804B9B40
	public static bool BoostsFuelEconomy(EngineStorage.EngineItemTypes engineItemType) { }

}

public class EngineStorage : StorageContainer // TypeDefIndex: 12099
{	// Fields
	[HeaderAttribute] // RVA: 0xD90A0 Offset: 0xD84A0 VA: 0x1800D90A0
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

	// Properties
	public bool isUsable { get; set; }
	public float accelerationBoostPercent { get; set; }
	public float topSpeedBoostPercent { get; set; }
	public float fuelEconomyBoostPercent { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9FE0 Offset: 0x4B93E0 VA: 0x1804B9FE0
	public bool get_isUsable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BA020 Offset: 0x4B9420 VA: 0x1804BA020
	private void set_isUsable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9FC0 Offset: 0x4B93C0 VA: 0x1804B9FC0
	public float get_accelerationBoostPercent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BA000 Offset: 0x4B9400 VA: 0x1804BA000
	private void set_accelerationBoostPercent(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9FF0 Offset: 0x4B93F0 VA: 0x1804B9FF0
	public float get_topSpeedBoostPercent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BA030 Offset: 0x4B9430 VA: 0x1804BA030
	private void set_topSpeedBoostPercent(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9FD0 Offset: 0x4B93D0 VA: 0x1804B9FD0
	public float get_fuelEconomyBoostPercent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BA010 Offset: 0x4B9410 VA: 0x1804BA010
	private void set_fuelEconomyBoostPercent(float value) { }

	// RVA: 0x4B9C30 Offset: 0x4B9030 VA: 0x1804B9C30
	public VehicleModuleEngine GetEngineModule() { }

	// RVA: 0x4B9C00 Offset: 0x4B9000 VA: 0x1804B9C00
	public float GetAveragedLoadoutPercent() { }

	// RVA: 0x4B9EB0 Offset: 0x4B92B0 VA: 0x1804B9EB0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x4B9B60 Offset: 0x4B8F60 VA: 0x1804B9B60 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x4B9CD0 Offset: 0x4B90D0 VA: 0x1804B9CD0
	private int GetValidSlot(Item item) { }

	// RVA: 0x4B9CC0 Offset: 0x4B90C0 VA: 0x1804B9CC0 Slot: 152
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x4B9F60 Offset: 0x4B9360 VA: 0x1804B9F60
	public void .ctor() { }

}

public enum EngineStorage.EngineItemTypes // TypeDefIndex: 12100
{	// Fields
	public int value__; // 0x0
	public const EngineStorage.EngineItemTypes Crankshaft = 0;
	public const EngineStorage.EngineItemTypes Carburetor = 1;
	public const EngineStorage.EngineItemTypes SparkPlug = 2;
	public const EngineStorage.EngineItemTypes Piston = 3;
	public const EngineStorage.EngineItemTypes Valve = 4;

}

public class ModularCarAudio : GroundVehicleAudio // TypeDefIndex: 12101
{	// Fields
	public bool showDebug; // 0x98
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

	// Properties
	protected override EngineAudioSet EngineAudioSet { get; set; }
	private VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataFL { get; }
	private VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataFR { get; }
	private VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataRL { get; }
	private VehicleChassisVisuals.ClientWheelData<ModularCar> wheelDataRR { get; }

	// Methods

	// RVA: 0x4BE070 Offset: 0x4BD470 VA: 0x1804BE070 Slot: 4
	protected override EngineAudioSet get_EngineAudioSet() { }

	// RVA: 0x4BE140 Offset: 0x4BD540 VA: 0x1804BE140 Slot: 5
	protected override void set_EngineAudioSet(EngineAudioSet value) { }

	// RVA: 0x4BE080 Offset: 0x4BD480 VA: 0x1804BE080
	private VehicleChassisVisuals.ClientWheelData<ModularCar> get_wheelDataFL() { }

	// RVA: 0x4BE0B0 Offset: 0x4BD4B0 VA: 0x1804BE0B0
	private VehicleChassisVisuals.ClientWheelData<ModularCar> get_wheelDataFR() { }

	// RVA: 0x4BE0E0 Offset: 0x4BD4E0 VA: 0x1804BE0E0
	private VehicleChassisVisuals.ClientWheelData<ModularCar> get_wheelDataRL() { }

	// RVA: 0x4BE110 Offset: 0x4BD510 VA: 0x1804BE110
	private VehicleChassisVisuals.ClientWheelData<ModularCar> get_wheelDataRR() { }

	// RVA: 0x4BC0B0 Offset: 0x4BB4B0 VA: 0x1804BC0B0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x4BC150 Offset: 0x4BB550 VA: 0x1804BC150 Slot: 7
	public override void ClientTick() { }

	// RVA: 0x4BC500 Offset: 0x4BB900 VA: 0x1804BC500 Slot: 8
	public override void OnClientTickStopped() { }

	// RVA: 0x4BC540 Offset: 0x4BB940 VA: 0x1804BC540
	internal void OnModuleAdded(BaseVehicleModule addedModule) { }

	// RVA: 0x4BC6F0 Offset: 0x4BBAF0 VA: 0x1804BC6F0
	internal void OnModuleRemoved(BaseVehicleModule removedModule) { }

	// RVA: 0x4BC490 Offset: 0x4BB890 VA: 0x1804BC490 Slot: 9
	protected override int GetNumEngines() { }

	// RVA: 0x4BCA30 Offset: 0x4BBE30 VA: 0x1804BCA30
	private void PlayTyreAudio() { }

	// RVA: 0x4BCD10 Offset: 0x4BC110 VA: 0x1804BCD10
	private void StopTyreAudio() { }

	// RVA: 0x4BCC50 Offset: 0x4BC050 VA: 0x1804BCC50
	private void StopSkidSound() { }

	// RVA: 0x4BCE70 Offset: 0x4BC270 VA: 0x1804BCE70
	private void UpdateMovementRattleSound() { }

	// RVA: 0x4BCB90 Offset: 0x4BBF90 VA: 0x1804BCB90
	private void StopMovementRattleSound() { }

	// RVA: 0x4BD7A0 Offset: 0x4BCBA0 VA: 0x1804BD7A0
	private void UpdateSuspensionSounds() { }

	// RVA: 0x4BD390 Offset: 0x4BC790 VA: 0x1804BD390
	private void UpdateSkidSound(float dt, VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData) { }

	// RVA: 0x4BCDA0 Offset: 0x4BC1A0 VA: 0x1804BCDA0
	private void StopTyreSound(VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData) { }

	// RVA: 0x4BDB40 Offset: 0x4BCF40 VA: 0x1804BDB40
	private void UpdateTyreSound(VehicleChassisVisuals.ClientWheelData<ModularCar> wheelData, float speedRatio) { }

	// RVA: 0x4BDF10 Offset: 0x4BD310 VA: 0x1804BDF10
	public void .ctor() { }

}

public class ModularVehicleSocket // TypeDefIndex: 12102
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform socketTransform; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ModularVehicleSocket.SocketWheelType wheelType; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ModularVehicleSocket.SocketLocationType locationType; // 0x1C

	// Properties
	public Vector3 WorldPosition { get; }
	public Quaternion WorldRotation { get; }
	public ModularVehicleSocket.SocketWheelType WheelType { get; }
	public ModularVehicleSocket.SocketLocationType LocationType { get; }

	// Methods

	// RVA: 0x4BE210 Offset: 0x4BD610 VA: 0x1804BE210
	public Vector3 get_WorldPosition() { }

	// RVA: 0x4BE250 Offset: 0x4BD650 VA: 0x1804BE250
	public Quaternion get_WorldRotation() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public ModularVehicleSocket.SocketWheelType get_WheelType() { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public ModularVehicleSocket.SocketLocationType get_LocationType() { }

	// RVA: 0x4BE150 Offset: 0x4BD550 VA: 0x1804BE150
	public bool ShouldBeActive(ConditionalSocketSettings modelSettings) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public enum ModularVehicleSocket.SocketWheelType // TypeDefIndex: 12103
{	// Fields
	public int value__; // 0x0
	public const ModularVehicleSocket.SocketWheelType NoWheel = 0;
	public const ModularVehicleSocket.SocketWheelType ForwardWheel = 1;
	public const ModularVehicleSocket.SocketWheelType BackWheel = 2;

}

public enum ModularVehicleSocket.SocketLocationType // TypeDefIndex: 12104
{	// Fields
	public int value__; // 0x0
	public const ModularVehicleSocket.SocketLocationType Middle = 0;
	public const ModularVehicleSocket.SocketLocationType Front = 1;
	public const ModularVehicleSocket.SocketLocationType Back = 2;

}

public class VehicleModuleEngineItems : ScriptableObject // TypeDefIndex: 12105
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ItemModEngineItem[] engineItems; // 0x18

	// Methods

	// RVA: 0x4CF550 Offset: 0x4CE950 VA: 0x1804CF550
	public bool TryGetItem(int tier, EngineStorage.EngineItemTypes type, out ItemModEngineItem output) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public class VehicleModuleSlidingComponent // TypeDefIndex: 12106
{	// Fields
	public string interactionColliderName; // 0x10
	public BaseEntity.Flags flag_SliderOpen; // 0x18
	public float moveTime; // 0x1C
	public VehicleModuleSlidingComponent.SlidingPart[] slidingParts; // 0x20
	public SoundDefinition openSoundDef; // 0x28
	public SoundDefinition closeSoundDef; // 0x30
	private float positionPercent; // 0x38

	// Methods

	// RVA: 0x4CFB80 Offset: 0x4CEF80 VA: 0x1804CFB80
	public bool WantsOpenPos(BaseEntity parentEntity) { }

	// RVA: 0x4CF950 Offset: 0x4CED50 VA: 0x1804CF950
	public void ClientUpdateTick(BaseVehicleModule parentModule) { }

	// RVA: 0x4CF990 Offset: 0x4CED90 VA: 0x1804CF990
	private void PlaySounds(bool wantsOpenPos) { }

	// RVA: 0x4CF6C0 Offset: 0x4CEAC0 VA: 0x1804CF6C0
	private void CheckPosition(BaseEntity parentEntity, float dt) { }

	// RVA: 0x4CFBB0 Offset: 0x4CEFB0 VA: 0x1804CFBB0
	public void .ctor() { }

}

public class VehicleModuleSlidingComponent.SlidingPart // TypeDefIndex: 12107
{	// Fields
	public Transform transform; // 0x10
	public Vector3 openPosition; // 0x18
	public Vector3 closedPosition; // 0x24

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

