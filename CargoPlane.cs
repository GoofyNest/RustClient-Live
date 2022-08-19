public class CargoPlane : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6428
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 startPos; // 0x14
	public Vector3 endPos; // 0x20
	public float secondsToTake; // 0x2C
	public float secondsTaken; // 0x30
	public bool dropped; // 0x34
	public Vector3 dropPosition; // 0x38

	// Methods

	// RVA: 0x20A0CD0 Offset: 0x20A00D0 VA: 0x1820A0CD0
	public static void ResetToPool(CargoPlane instance) { }

	// RVA: 0x20A0C00 Offset: 0x20A0000 VA: 0x1820A0C00
	public void ResetToPool() { }

	// RVA: 0x20A04F0 Offset: 0x209F8F0 VA: 0x1820A04F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x209ED90 Offset: 0x209E190 VA: 0x18209ED90
	public void CopyTo(CargoPlane instance) { }

	// RVA: 0x209EDF0 Offset: 0x209E1F0 VA: 0x18209EDF0
	public CargoPlane Copy() { }

	// RVA: 0x209FB90 Offset: 0x209EF90 VA: 0x18209FB90
	public static CargoPlane Deserialize(Stream stream) { }

	// RVA: 0x209EEA0 Offset: 0x209E2A0 VA: 0x18209EEA0
	public static CargoPlane DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x209F270 Offset: 0x209E670 VA: 0x18209F270
	public static CargoPlane DeserializeLength(Stream stream, int length) { }

	// RVA: 0x209FE40 Offset: 0x209F240 VA: 0x18209FE40
	public static CargoPlane Deserialize(byte[] buffer) { }

	// RVA: 0x20A0650 Offset: 0x209FA50 VA: 0x1820A0650
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20A18D0 Offset: 0x20A0CD0 VA: 0x1820A18D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20A18F0 Offset: 0x20A0CF0 VA: 0x1820A18F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CargoPlane previous) { }

	// RVA: 0x20A08D0 Offset: 0x209FCD0 VA: 0x1820A08D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A01A0 Offset: 0x209F5A0 VA: 0x1820A01A0
	public static CargoPlane Deserialize(byte[] buffer, CargoPlane instance, bool isDelta = False) { }

	// RVA: 0x209F910 Offset: 0x209ED10 VA: 0x18209F910
	public static CargoPlane Deserialize(Stream stream, CargoPlane instance, bool isDelta) { }

	// RVA: 0x209EF20 Offset: 0x209E320 VA: 0x18209EF20
	public static CargoPlane DeserializeLengthDelimited(Stream stream, CargoPlane instance, bool isDelta) { }

	// RVA: 0x209F5E0 Offset: 0x209E9E0 VA: 0x18209F5E0
	public static CargoPlane DeserializeLength(Stream stream, int length, CargoPlane instance, bool isDelta) { }

	// RVA: 0x20A0DA0 Offset: 0x20A01A0 VA: 0x1820A0DA0
	public static void SerializeDelta(Stream stream, CargoPlane instance, CargoPlane previous) { }

	// RVA: 0x20A1550 Offset: 0x20A0950 VA: 0x1820A1550
	public static void Serialize(Stream stream, CargoPlane instance) { }

	// RVA: 0x20A18C0 Offset: 0x20A0CC0 VA: 0x1820A18C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20A18D0 Offset: 0x20A0CD0 VA: 0x1820A18D0
	public void ToProto(Stream stream) { }

	// RVA: 0x20A1440 Offset: 0x20A0840 VA: 0x1820A1440
	public static byte[] SerializeToBytes(CargoPlane instance) { }

	// RVA: 0x20A1390 Offset: 0x20A0790 VA: 0x1820A1390
	public static void SerializeLengthDelimited(Stream stream, CargoPlane instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class CargoPlane : BaseEntity // TypeDefIndex: 9815
{	// Fields
	public GameObjectRef prefabDrop; // 0x168
	public SpawnFilter filter; // 0x170

	// Methods

	// RVA: 0x5439B0 Offset: 0x542DB0 VA: 0x1805439B0
	public void .ctor() { }

}

