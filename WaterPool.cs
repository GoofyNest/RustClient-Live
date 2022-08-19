public class WaterPool : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6382
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float fillAmount; // 0x14

	// Methods

	// RVA: 0x1E4C0E0 Offset: 0x1E4B4E0 VA: 0x181E4C0E0
	public static void ResetToPool(WaterPool instance) { }

	// RVA: 0x1E4C160 Offset: 0x1E4B560 VA: 0x181E4C160
	public void ResetToPool() { }

	// RVA: 0x1E4BFB0 Offset: 0x1E4B3B0 VA: 0x181E4BFB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(WaterPool instance) { }

	// RVA: 0x1E4B470 Offset: 0x1E4A870 VA: 0x181E4B470
	public WaterPool Copy() { }

	// RVA: 0x1E4BF30 Offset: 0x1E4B330 VA: 0x181E4BF30
	public static WaterPool Deserialize(Stream stream) { }

	// RVA: 0x1E4B4E0 Offset: 0x1E4A8E0 VA: 0x181E4B4E0
	public static WaterPool DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E4B810 Offset: 0x1E4AC10 VA: 0x181E4B810
	public static WaterPool DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E4BD10 Offset: 0x1E4B110 VA: 0x181E4BD10
	public static WaterPool Deserialize(byte[] buffer) { }

	// RVA: 0x1E4C0A0 Offset: 0x1E4B4A0 VA: 0x181E4C0A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E4C5F0 Offset: 0x1E4B9F0 VA: 0x181E4C5F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E4C610 Offset: 0x1E4BA10 VA: 0x181E4C610 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WaterPool previous) { }

	// RVA: 0x1E4C0C0 Offset: 0x1E4B4C0 VA: 0x181E4C0C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E4BE30 Offset: 0x1E4B230 VA: 0x181E4BE30
	public static WaterPool Deserialize(byte[] buffer, WaterPool instance, bool isDelta = False) { }

	// RVA: 0x1E4BB30 Offset: 0x1E4AF30 VA: 0x181E4BB30
	public static WaterPool Deserialize(Stream stream, WaterPool instance, bool isDelta) { }

	// RVA: 0x1E4B560 Offset: 0x1E4A960 VA: 0x181E4B560
	public static WaterPool DeserializeLengthDelimited(Stream stream, WaterPool instance, bool isDelta) { }

	// RVA: 0x1E4B8A0 Offset: 0x1E4ACA0 VA: 0x181E4B8A0
	public static WaterPool DeserializeLength(Stream stream, int length, WaterPool instance, bool isDelta) { }

	// RVA: 0x1E4C1E0 Offset: 0x1E4B5E0 VA: 0x181E4C1E0
	public static void SerializeDelta(Stream stream, WaterPool instance, WaterPool previous) { }

	// RVA: 0x1E4C500 Offset: 0x1E4B900 VA: 0x181E4C500
	public static void Serialize(Stream stream, WaterPool instance) { }

	// RVA: 0x1E4C5E0 Offset: 0x1E4B9E0 VA: 0x181E4C5E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E4C5F0 Offset: 0x1E4B9F0 VA: 0x181E4C5F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E4C3F0 Offset: 0x1E4B7F0 VA: 0x181E4C3F0
	public static byte[] SerializeToBytes(WaterPool instance) { }

	// RVA: 0x1E4C300 Offset: 0x1E4B700 VA: 0x181E4C300
	public static void SerializeLengthDelimited(Stream stream, WaterPool instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

