public class CreateBuilding : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6482
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint entity; // 0x14
	public uint socket; // 0x18
	public bool onterrain; // 0x1C
	public Vector3 position; // 0x20
	public Vector3 normal; // 0x2C
	public Ray ray; // 0x38
	public uint blockID; // 0x50
	public Vector3 rotation; // 0x54

	// Methods

	// RVA: 0x20B33C0 Offset: 0x20B27C0 VA: 0x1820B33C0
	public static void ResetToPool(CreateBuilding instance) { }

	// RVA: 0x20B34C0 Offset: 0x20B28C0 VA: 0x1820B34C0
	public void ResetToPool() { }

	// RVA: 0x20B2B90 Offset: 0x20B1F90 VA: 0x1820B2B90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20B0CD0 Offset: 0x20B00D0 VA: 0x1820B0CD0
	public void CopyTo(CreateBuilding instance) { }

	// RVA: 0x20B0D40 Offset: 0x20B0140 VA: 0x1820B0D40
	public CreateBuilding Copy() { }

	// RVA: 0x20B2460 Offset: 0x20B1860 VA: 0x1820B2460
	public static CreateBuilding Deserialize(Stream stream) { }

	// RVA: 0x20B11D0 Offset: 0x20B05D0 VA: 0x1820B11D0
	public static CreateBuilding DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20B15F0 Offset: 0x20B09F0 VA: 0x1820B15F0
	public static CreateBuilding DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20B2790 Offset: 0x20B1B90 VA: 0x1820B2790
	public static CreateBuilding Deserialize(byte[] buffer) { }

	// RVA: 0x20B2D10 Offset: 0x20B2110 VA: 0x1820B2D10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20B4310 Offset: 0x20B3710 VA: 0x1820B4310 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20B4330 Offset: 0x20B3730 VA: 0x1820B4330 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CreateBuilding previous) { }

	// RVA: 0x20B3010 Offset: 0x20B2410 VA: 0x1820B3010 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20B2090 Offset: 0x20B1490 VA: 0x1820B2090
	public static CreateBuilding Deserialize(byte[] buffer, CreateBuilding instance, bool isDelta = False) { }

	// RVA: 0x20B1D90 Offset: 0x20B1190 VA: 0x1820B1D90
	public static CreateBuilding Deserialize(Stream stream, CreateBuilding instance, bool isDelta) { }

	// RVA: 0x20B0E00 Offset: 0x20B0200 VA: 0x1820B0E00
	public static CreateBuilding DeserializeLengthDelimited(Stream stream, CreateBuilding instance, bool isDelta) { }

	// RVA: 0x20B19E0 Offset: 0x20B0DE0 VA: 0x1820B19E0
	public static CreateBuilding DeserializeLength(Stream stream, int length, CreateBuilding instance, bool isDelta) { }

	// RVA: 0x20B35C0 Offset: 0x20B29C0 VA: 0x1820B35C0
	public static void SerializeDelta(Stream stream, CreateBuilding instance, CreateBuilding previous) { }

	// RVA: 0x20B3EB0 Offset: 0x20B32B0 VA: 0x1820B3EB0
	public static void Serialize(Stream stream, CreateBuilding instance) { }

	// RVA: 0x20B4300 Offset: 0x20B3700 VA: 0x1820B4300
	public byte[] ToProtoBytes() { }

	// RVA: 0x20B4310 Offset: 0x20B3710 VA: 0x1820B4310
	public void ToProto(Stream stream) { }

	// RVA: 0x20B3DA0 Offset: 0x20B31A0 VA: 0x1820B3DA0
	public static byte[] SerializeToBytes(CreateBuilding instance) { }

	// RVA: 0x20B3CF0 Offset: 0x20B30F0 VA: 0x1820B3CF0
	public static void SerializeLengthDelimited(Stream stream, CreateBuilding instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

