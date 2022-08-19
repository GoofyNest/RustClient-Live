public class PrefabData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6509
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string category; // 0x18
	public uint id; // 0x20
	public VectorData position; // 0x24
	public VectorData rotation; // 0x30
	public VectorData scale; // 0x3C

	// Methods

	// RVA: 0x2042A40 Offset: 0x2041E40 VA: 0x182042A40
	public static void ResetToPool(PrefabData instance) { }

	// RVA: 0x2042B20 Offset: 0x2041F20 VA: 0x182042B20
	public void ResetToPool() { }

	// RVA: 0x2042680 Offset: 0x2041A80 VA: 0x182042680 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2041320 Offset: 0x2040720 VA: 0x182041320
	public void CopyTo(PrefabData instance) { }

	// RVA: 0x2041390 Offset: 0x2040790 VA: 0x182041390
	public PrefabData Copy() { }

	// RVA: 0x20420D0 Offset: 0x20414D0 VA: 0x1820420D0
	public static PrefabData Deserialize(Stream stream) { }

	// RVA: 0x2041450 Offset: 0x2040850 VA: 0x182041450
	public static PrefabData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20417F0 Offset: 0x2040BF0 VA: 0x1820417F0
	public static PrefabData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2042350 Offset: 0x2041750 VA: 0x182042350
	public static PrefabData Deserialize(byte[] buffer) { }

	// RVA: 0x20427E0 Offset: 0x2041BE0 VA: 0x1820427E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20435E0 Offset: 0x20429E0 VA: 0x1820435E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2043600 Offset: 0x2042A00 VA: 0x182043600 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PrefabData previous) { }

	// RVA: 0x2042A20 Offset: 0x2041E20 VA: 0x182042A20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2041DC0 Offset: 0x20411C0 VA: 0x182041DC0
	public static PrefabData Deserialize(byte[] buffer, PrefabData instance, bool isDelta = False) { }

	// RVA: 0x2041B80 Offset: 0x2040F80 VA: 0x182041B80
	public static PrefabData Deserialize(Stream stream, PrefabData instance, bool isDelta) { }

	// RVA: 0x20414D0 Offset: 0x20408D0 VA: 0x1820414D0
	public static PrefabData DeserializeLengthDelimited(Stream stream, PrefabData instance, bool isDelta) { }

	// RVA: 0x2041880 Offset: 0x2040C80 VA: 0x182041880
	public static PrefabData DeserializeLength(Stream stream, int length, PrefabData instance, bool isDelta) { }

	// RVA: 0x2042C00 Offset: 0x2042000 VA: 0x182042C00
	public static void SerializeDelta(Stream stream, PrefabData instance, PrefabData previous) { }

	// RVA: 0x2043220 Offset: 0x2042620 VA: 0x182043220
	public static void Serialize(Stream stream, PrefabData instance) { }

	// RVA: 0x20435D0 Offset: 0x20429D0 VA: 0x1820435D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20435E0 Offset: 0x20429E0 VA: 0x1820435E0
	public void ToProto(Stream stream) { }

	// RVA: 0x2043110 Offset: 0x2042510 VA: 0x182043110
	public static byte[] SerializeToBytes(PrefabData instance) { }

	// RVA: 0x2043060 Offset: 0x2042460 VA: 0x182043060
	public static void SerializeLengthDelimited(Stream stream, PrefabData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

