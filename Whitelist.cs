public class Whitelist : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6308
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ulong> users; // 0x18

	// Methods

	// RVA: 0x1E4EC30 Offset: 0x1E4E030 VA: 0x181E4EC30
	public static void ResetToPool(Whitelist instance) { }

	// RVA: 0x1E4ED10 Offset: 0x1E4E110 VA: 0x181E4ED10
	public void ResetToPool() { }

	// RVA: 0x1E4EAA0 Offset: 0x1E4DEA0 VA: 0x181E4EAA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E4DDB0 Offset: 0x1E4D1B0 VA: 0x181E4DDB0
	public void CopyTo(Whitelist instance) { }

	// RVA: 0x1E4DED0 Offset: 0x1E4D2D0 VA: 0x181E4DED0
	public Whitelist Copy() { }

	// RVA: 0x1E4E900 Offset: 0x1E4DD00 VA: 0x181E4E900
	public static Whitelist Deserialize(Stream stream) { }

	// RVA: 0x1E4E030 Offset: 0x1E4D430 VA: 0x181E4E030
	public static Whitelist DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E4E340 Offset: 0x1E4D740 VA: 0x181E4E340
	public static Whitelist DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E4E980 Offset: 0x1E4DD80 VA: 0x181E4E980
	public static Whitelist Deserialize(byte[] buffer) { }

	// RVA: 0x1E4EBF0 Offset: 0x1E4DFF0 VA: 0x181E4EBF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E4F320 Offset: 0x1E4E720 VA: 0x181E4F320 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E4F340 Offset: 0x1E4E740 VA: 0x181E4F340 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Whitelist previous) { }

	// RVA: 0x1E4EC10 Offset: 0x1E4E010 VA: 0x181E4EC10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E4E800 Offset: 0x1E4DC00 VA: 0x181E4E800
	public static Whitelist Deserialize(byte[] buffer, Whitelist instance, bool isDelta = False) { }

	// RVA: 0x1E4E640 Offset: 0x1E4DA40 VA: 0x181E4E640
	public static Whitelist Deserialize(Stream stream, Whitelist instance, bool isDelta) { }

	// RVA: 0x1E4E0B0 Offset: 0x1E4D4B0 VA: 0x181E4E0B0
	public static Whitelist DeserializeLengthDelimited(Stream stream, Whitelist instance, bool isDelta) { }

	// RVA: 0x1E4E3D0 Offset: 0x1E4D7D0 VA: 0x181E4E3D0
	public static Whitelist DeserializeLength(Stream stream, int length, Whitelist instance, bool isDelta) { }

	// RVA: 0x1E4EDF0 Offset: 0x1E4E1F0 VA: 0x181E4EDF0
	public static void SerializeDelta(Stream stream, Whitelist instance, Whitelist previous) { }

	// RVA: 0x1E4F180 Offset: 0x1E4E580 VA: 0x181E4F180
	public static void Serialize(Stream stream, Whitelist instance) { }

	// RVA: 0x1E4F310 Offset: 0x1E4E710 VA: 0x181E4F310
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E4F320 Offset: 0x1E4E720 VA: 0x181E4F320
	public void ToProto(Stream stream) { }

	// RVA: 0x1E4F070 Offset: 0x1E4E470 VA: 0x181E4F070
	public static byte[] SerializeToBytes(Whitelist instance) { }

	// RVA: 0x1E4EF80 Offset: 0x1E4E380 VA: 0x181E4EF80
	public static void SerializeLengthDelimited(Stream stream, Whitelist instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

