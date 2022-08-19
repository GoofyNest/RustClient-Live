public class MapData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6508
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public byte[] data; // 0x20

	// Methods

	// RVA: 0x1F25B30 Offset: 0x1F24F30 VA: 0x181F25B30
	public static void ResetToPool(MapData instance) { }

	// RVA: 0x1F25A80 Offset: 0x1F24E80 VA: 0x181F25A80
	public void ResetToPool() { }

	// RVA: 0x1F25910 Offset: 0x1F24D10 VA: 0x181F25910 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F24D50 Offset: 0x1F24150 VA: 0x181F24D50
	public void CopyTo(MapData instance) { }

	// RVA: 0x1F24E00 Offset: 0x1F24200 VA: 0x181F24E00
	public MapData Copy() { }

	// RVA: 0x1F255E0 Offset: 0x1F249E0 VA: 0x181F255E0
	public static MapData Deserialize(Stream stream) { }

	// RVA: 0x1F25180 Offset: 0x1F24580 VA: 0x181F25180
	public static MapData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F25200 Offset: 0x1F24600 VA: 0x181F25200
	public static MapData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F257F0 Offset: 0x1F24BF0 VA: 0x181F257F0
	public static MapData Deserialize(byte[] buffer) { }

	// RVA: 0x1F25A40 Offset: 0x1F24E40 VA: 0x181F25A40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F26170 Offset: 0x1F25570 VA: 0x181F26170 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F26190 Offset: 0x1F25590 VA: 0x181F26190 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MapData previous) { }

	// RVA: 0x1F25A60 Offset: 0x1F24E60 VA: 0x181F25A60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F254E0 Offset: 0x1F248E0 VA: 0x181F254E0
	public static MapData Deserialize(byte[] buffer, MapData instance, bool isDelta = False) { }

	// RVA: 0x1F25660 Offset: 0x1F24A60 VA: 0x181F25660
	public static MapData Deserialize(Stream stream, MapData instance, bool isDelta) { }

	// RVA: 0x1F24F10 Offset: 0x1F24310 VA: 0x181F24F10
	public static MapData DeserializeLengthDelimited(Stream stream, MapData instance, bool isDelta) { }

	// RVA: 0x1F25290 Offset: 0x1F24690 VA: 0x181F25290
	public static MapData DeserializeLength(Stream stream, int length, MapData instance, bool isDelta) { }

	// RVA: 0x1F25BE0 Offset: 0x1F24FE0 VA: 0x181F25BE0
	public static void SerializeDelta(Stream stream, MapData instance, MapData previous) { }

	// RVA: 0x1F25F90 Offset: 0x1F25390 VA: 0x181F25F90
	public static void Serialize(Stream stream, MapData instance) { }

	// RVA: 0x1F26160 Offset: 0x1F25560 VA: 0x181F26160
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F26170 Offset: 0x1F25570 VA: 0x181F26170
	public void ToProto(Stream stream) { }

	// RVA: 0x1F25E80 Offset: 0x1F25280 VA: 0x181F25E80
	public static byte[] SerializeToBytes(MapData instance) { }

	// RVA: 0x1F25DD0 Offset: 0x1F251D0 VA: 0x181F25DD0
	public static void SerializeLengthDelimited(Stream stream, MapData instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

