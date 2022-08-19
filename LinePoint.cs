public class LinePoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6433
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 localPosition; // 0x14
	public Vector3 worldNormal; // 0x20

	// Methods

	// RVA: 0x1F1DC30 Offset: 0x1F1D030 VA: 0x181F1DC30
	public static void ResetToPool(LinePoint instance) { }

	// RVA: 0x1F1DBA0 Offset: 0x1F1CFA0 VA: 0x181F1DBA0
	public void ResetToPool() { }

	// RVA: 0x1F1D8F0 Offset: 0x1F1CCF0 VA: 0x181F1D8F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F1CAD0 Offset: 0x1F1BED0 VA: 0x181F1CAD0
	public void CopyTo(LinePoint instance) { }

	// RVA: 0x1F1CB10 Offset: 0x1F1BF10 VA: 0x181F1CB10
	public LinePoint Copy() { }

	// RVA: 0x1F1D2A0 Offset: 0x1F1C6A0 VA: 0x181F1D2A0
	public static LinePoint Deserialize(Stream stream) { }

	// RVA: 0x1F1CBA0 Offset: 0x1F1BFA0 VA: 0x181F1CBA0
	public static LinePoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1CE70 Offset: 0x1F1C270 VA: 0x181F1CE70
	public static LinePoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1D6A0 Offset: 0x1F1CAA0 VA: 0x181F1D6A0
	public static LinePoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F1DA00 Offset: 0x1F1CE00 VA: 0x181F1DA00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1E470 Offset: 0x1F1D870 VA: 0x181F1E470 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1E490 Offset: 0x1F1D890 VA: 0x181F1E490 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LinePoint previous) { }

	// RVA: 0x1F1DB80 Offset: 0x1F1CF80 VA: 0x181F1DB80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1D460 Offset: 0x1F1C860 VA: 0x181F1D460
	public static LinePoint Deserialize(byte[] buffer, LinePoint instance, bool isDelta = False) { }

	// RVA: 0x1F1D120 Offset: 0x1F1C520 VA: 0x181F1D120
	public static LinePoint Deserialize(Stream stream, LinePoint instance, bool isDelta) { }

	// RVA: 0x1F1CC20 Offset: 0x1F1C020 VA: 0x181F1CC20
	public static LinePoint DeserializeLengthDelimited(Stream stream, LinePoint instance, bool isDelta) { }

	// RVA: 0x1F1CF00 Offset: 0x1F1C300 VA: 0x181F1CF00
	public static LinePoint DeserializeLength(Stream stream, int length, LinePoint instance, bool isDelta) { }

	// RVA: 0x1F1DCC0 Offset: 0x1F1D0C0 VA: 0x181F1DCC0
	public static void SerializeDelta(Stream stream, LinePoint instance, LinePoint previous) { }

	// RVA: 0x1F1E220 Offset: 0x1F1D620 VA: 0x181F1E220
	public static void Serialize(Stream stream, LinePoint instance) { }

	// RVA: 0x1F1E460 Offset: 0x1F1D860 VA: 0x181F1E460
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1E470 Offset: 0x1F1D870 VA: 0x181F1E470
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1E110 Offset: 0x1F1D510 VA: 0x181F1E110
	public static byte[] SerializeToBytes(LinePoint instance) { }

	// RVA: 0x1F1E060 Offset: 0x1F1D460 VA: 0x181F1E060
	public static void SerializeLengthDelimited(Stream stream, LinePoint instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

