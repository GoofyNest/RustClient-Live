public class PhoneDirectory : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6502
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<PhoneDirectory.DirectoryEntry> entries; // 0x18
	public bool atEnd; // 0x20

	// Methods

	// RVA: 0x1EA2980 Offset: 0x1EA1D80 VA: 0x181EA2980
	public static void ResetToPool(PhoneDirectory instance) { }

	// RVA: 0x1EA27C0 Offset: 0x1EA1BC0 VA: 0x181EA27C0
	public void ResetToPool() { }

	// RVA: 0x1EA2700 Offset: 0x1EA1B00 VA: 0x181EA2700 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA1900 Offset: 0x1EA0D00 VA: 0x181EA1900
	public void CopyTo(PhoneDirectory instance) { }

	// RVA: 0x1EA1AB0 Offset: 0x1EA0EB0 VA: 0x181EA1AB0
	public PhoneDirectory Copy() { }

	// RVA: 0x1EA2680 Offset: 0x1EA1A80 VA: 0x181EA2680
	public static PhoneDirectory Deserialize(Stream stream) { }

	// RVA: 0x1EA1E40 Offset: 0x1EA1240 VA: 0x181EA1E40
	public static PhoneDirectory DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA21A0 Offset: 0x1EA15A0 VA: 0x181EA21A0
	public static PhoneDirectory DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA2230 Offset: 0x1EA1630 VA: 0x181EA2230
	public static PhoneDirectory Deserialize(byte[] buffer) { }

	// RVA: 0x1EA2780 Offset: 0x1EA1B80 VA: 0x181EA2780
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA3170 Offset: 0x1EA2570 VA: 0x181EA3170 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA3190 Offset: 0x1EA2590 VA: 0x181EA3190 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PhoneDirectory previous) { }

	// RVA: 0x1EA27A0 Offset: 0x1EA1BA0 VA: 0x181EA27A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA2580 Offset: 0x1EA1980 VA: 0x181EA2580
	public static PhoneDirectory Deserialize(byte[] buffer, PhoneDirectory instance, bool isDelta = False) { }

	// RVA: 0x1EA2350 Offset: 0x1EA1750 VA: 0x181EA2350
	public static PhoneDirectory Deserialize(Stream stream, PhoneDirectory instance, bool isDelta) { }

	// RVA: 0x1EA1B30 Offset: 0x1EA0F30 VA: 0x181EA1B30
	public static PhoneDirectory DeserializeLengthDelimited(Stream stream, PhoneDirectory instance, bool isDelta) { }

	// RVA: 0x1EA1EC0 Offset: 0x1EA12C0 VA: 0x181EA1EC0
	public static PhoneDirectory DeserializeLength(Stream stream, int length, PhoneDirectory instance, bool isDelta) { }

	// RVA: 0x1EA2B40 Offset: 0x1EA1F40 VA: 0x181EA2B40
	public static void SerializeDelta(Stream stream, PhoneDirectory instance, PhoneDirectory previous) { }

	// RVA: 0x1EA2F30 Offset: 0x1EA2330 VA: 0x181EA2F30
	public static void Serialize(Stream stream, PhoneDirectory instance) { }

	// RVA: 0x1EA3160 Offset: 0x1EA2560 VA: 0x181EA3160
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA3170 Offset: 0x1EA2570 VA: 0x181EA3170
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA2E20 Offset: 0x1EA2220 VA: 0x181EA2E20
	public static byte[] SerializeToBytes(PhoneDirectory instance) { }

	// RVA: 0x1EA2D70 Offset: 0x1EA2170 VA: 0x181EA2D70
	public static void SerializeLengthDelimited(Stream stream, PhoneDirectory instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PhoneDirectory.DirectoryEntry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6503
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int phoneNumber; // 0x14
	public string phoneName; // 0x18

	// Methods

	// RVA: 0x1E9E720 Offset: 0x1E9DB20 VA: 0x181E9E720
	public static void ResetToPool(PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1E9E7C0 Offset: 0x1E9DBC0 VA: 0x181E9E7C0
	public void ResetToPool() { }

	// RVA: 0x1E9E660 Offset: 0x1E9DA60 VA: 0x181E9E660 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E9D920 Offset: 0x1E9CD20 VA: 0x181E9D920
	public void CopyTo(PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1E9D950 Offset: 0x1E9CD50 VA: 0x181E9D950
	public PhoneDirectory.DirectoryEntry Copy() { }

	// RVA: 0x1E9E090 Offset: 0x1E9D490 VA: 0x181E9E090
	public static PhoneDirectory.DirectoryEntry Deserialize(Stream stream) { }

	// RVA: 0x1E9D9E0 Offset: 0x1E9CDE0 VA: 0x181E9D9E0
	public static PhoneDirectory.DirectoryEntry DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E9DF00 Offset: 0x1E9D300 VA: 0x181E9DF00
	public static PhoneDirectory.DirectoryEntry DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E9E260 Offset: 0x1E9D660 VA: 0x181E9E260
	public static PhoneDirectory.DirectoryEntry Deserialize(byte[] buffer) { }

	// RVA: 0x1E9E6E0 Offset: 0x1E9DAE0 VA: 0x181E9E6E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E9ED70 Offset: 0x1E9E170 VA: 0x181E9ED70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E9ED90 Offset: 0x1E9E190 VA: 0x181E9ED90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PhoneDirectory.DirectoryEntry previous) { }

	// RVA: 0x1E9E700 Offset: 0x1E9DB00 VA: 0x181E9E700 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E9DF90 Offset: 0x1E9D390 VA: 0x181E9DF90
	public static PhoneDirectory.DirectoryEntry Deserialize(byte[] buffer, PhoneDirectory.DirectoryEntry instance, bool isDelta = False) { }

	// RVA: 0x1E9E4D0 Offset: 0x1E9D8D0 VA: 0x181E9E4D0
	public static PhoneDirectory.DirectoryEntry Deserialize(Stream stream, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	// RVA: 0x1E9DA60 Offset: 0x1E9CE60 VA: 0x181E9DA60
	public static PhoneDirectory.DirectoryEntry DeserializeLengthDelimited(Stream stream, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	// RVA: 0x1E9DCC0 Offset: 0x1E9D0C0 VA: 0x181E9DCC0
	public static PhoneDirectory.DirectoryEntry DeserializeLength(Stream stream, int length, PhoneDirectory.DirectoryEntry instance, bool isDelta) { }

	// RVA: 0x1E9E860 Offset: 0x1E9DC60 VA: 0x181E9E860
	public static void SerializeDelta(Stream stream, PhoneDirectory.DirectoryEntry instance, PhoneDirectory.DirectoryEntry previous) { }

	// RVA: 0x1E9EBE0 Offset: 0x1E9DFE0 VA: 0x181E9EBE0
	public static void Serialize(Stream stream, PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1E9ED60 Offset: 0x1E9E160 VA: 0x181E9ED60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E9ED70 Offset: 0x1E9E170 VA: 0x181E9ED70
	public void ToProto(Stream stream) { }

	// RVA: 0x1E9EAD0 Offset: 0x1E9DED0 VA: 0x181E9EAD0
	public static byte[] SerializeToBytes(PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x1E9EA20 Offset: 0x1E9DE20 VA: 0x181E9EA20
	public static void SerializeLengthDelimited(Stream stream, PhoneDirectory.DirectoryEntry instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

