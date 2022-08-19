public class SimpleFloat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6351
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float value; // 0x14

	// Methods

	// RVA: 0x1E06E10 Offset: 0x1E06210 VA: 0x181E06E10
	public static void ResetToPool(SimpleFloat instance) { }

	// RVA: 0x1E06D90 Offset: 0x1E06190 VA: 0x181E06D90
	public void ResetToPool() { }

	// RVA: 0x1E06C60 Offset: 0x1E06060 VA: 0x181E06C60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(SimpleFloat instance) { }

	// RVA: 0x1E062D0 Offset: 0x1E056D0 VA: 0x181E062D0
	public SimpleFloat Copy() { }

	// RVA: 0x1E06870 Offset: 0x1E05C70 VA: 0x181E06870
	public static SimpleFloat Deserialize(Stream stream) { }

	// RVA: 0x1E06340 Offset: 0x1E05740 VA: 0x181E06340
	public static SimpleFloat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E067E0 Offset: 0x1E05BE0 VA: 0x181E067E0
	public static SimpleFloat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E069F0 Offset: 0x1E05DF0 VA: 0x181E069F0
	public static SimpleFloat Deserialize(byte[] buffer) { }

	// RVA: 0x1E06D50 Offset: 0x1E06150 VA: 0x181E06D50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E07260 Offset: 0x1E06660 VA: 0x181E07260 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E07280 Offset: 0x1E06680 VA: 0x181E07280 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SimpleFloat previous) { }

	// RVA: 0x1E06D70 Offset: 0x1E06170 VA: 0x181E06D70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E068F0 Offset: 0x1E05CF0 VA: 0x181E068F0
	public static SimpleFloat Deserialize(byte[] buffer, SimpleFloat instance, bool isDelta = False) { }

	// RVA: 0x1E06B10 Offset: 0x1E05F10 VA: 0x181E06B10
	public static SimpleFloat Deserialize(Stream stream, SimpleFloat instance, bool isDelta) { }

	// RVA: 0x1E063C0 Offset: 0x1E057C0 VA: 0x181E063C0
	public static SimpleFloat DeserializeLengthDelimited(Stream stream, SimpleFloat instance, bool isDelta) { }

	// RVA: 0x1E065E0 Offset: 0x1E059E0 VA: 0x181E065E0
	public static SimpleFloat DeserializeLength(Stream stream, int length, SimpleFloat instance, bool isDelta) { }

	// RVA: 0x1E06E90 Offset: 0x1E06290 VA: 0x181E06E90
	public static void SerializeDelta(Stream stream, SimpleFloat instance, SimpleFloat previous) { }

	// RVA: 0x1E07170 Offset: 0x1E06570 VA: 0x181E07170
	public static void Serialize(Stream stream, SimpleFloat instance) { }

	// RVA: 0x1E07250 Offset: 0x1E06650 VA: 0x181E07250
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E07260 Offset: 0x1E06660 VA: 0x181E07260
	public void ToProto(Stream stream) { }

	// RVA: 0x1E07060 Offset: 0x1E06460 VA: 0x181E07060
	public static byte[] SerializeToBytes(SimpleFloat instance) { }

	// RVA: 0x1E06FB0 Offset: 0x1E063B0 VA: 0x181E06FB0
	public static void SerializeLengthDelimited(Stream stream, SimpleFloat instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

