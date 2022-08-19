public class SprayLine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6431
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<LinePoint> linePoints; // 0x18
	public Vector3 colour; // 0x20
	public float width; // 0x2C
	public uint editingPlayer; // 0x30

	// Methods

	// RVA: 0x1DB58E0 Offset: 0x1DB4CE0 VA: 0x181DB58E0
	public static void ResetToPool(SprayLine instance) { }

	// RVA: 0x1DB5AE0 Offset: 0x1DB4EE0 VA: 0x181DB5AE0
	public void ResetToPool() { }

	// RVA: 0x1DB55E0 Offset: 0x1DB49E0 VA: 0x181DB55E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB4090 Offset: 0x1DB3490 VA: 0x181DB4090
	public void CopyTo(SprayLine instance) { }

	// RVA: 0x1DB41E0 Offset: 0x1DB35E0 VA: 0x181DB41E0
	public SprayLine Copy() { }

	// RVA: 0x1DB4DE0 Offset: 0x1DB41E0 VA: 0x181DB4DE0
	public static SprayLine Deserialize(Stream stream) { }

	// RVA: 0x1DB4380 Offset: 0x1DB3780 VA: 0x181DB4380
	public static SprayLine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB4A30 Offset: 0x1DB3E30 VA: 0x181DB4A30
	public static SprayLine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB5060 Offset: 0x1DB4460 VA: 0x181DB5060
	public static SprayLine Deserialize(byte[] buffer) { }

	// RVA: 0x1DB5660 Offset: 0x1DB4A60 VA: 0x181DB5660
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB6610 Offset: 0x1DB5A10 VA: 0x181DB6610 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB6630 Offset: 0x1DB5A30 VA: 0x181DB6630 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SprayLine previous) { }

	// RVA: 0x1DB58C0 Offset: 0x1DB4CC0 VA: 0x181DB58C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB4AC0 Offset: 0x1DB3EC0 VA: 0x181DB4AC0
	public static SprayLine Deserialize(byte[] buffer, SprayLine instance, bool isDelta = False) { }

	// RVA: 0x1DB5370 Offset: 0x1DB4770 VA: 0x181DB5370
	public static SprayLine Deserialize(Stream stream, SprayLine instance, bool isDelta) { }

	// RVA: 0x1DB4400 Offset: 0x1DB3800 VA: 0x181DB4400
	public static SprayLine DeserializeLengthDelimited(Stream stream, SprayLine instance, bool isDelta) { }

	// RVA: 0x1DB4730 Offset: 0x1DB3B30 VA: 0x181DB4730
	public static SprayLine DeserializeLength(Stream stream, int length, SprayLine instance, bool isDelta) { }

	// RVA: 0x1DB5CE0 Offset: 0x1DB50E0 VA: 0x181DB5CE0
	public static void SerializeDelta(Stream stream, SprayLine instance, SprayLine previous) { }

	// RVA: 0x1DB62F0 Offset: 0x1DB56F0 VA: 0x181DB62F0
	public static void Serialize(Stream stream, SprayLine instance) { }

	// RVA: 0x1DB6600 Offset: 0x1DB5A00 VA: 0x181DB6600
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB6610 Offset: 0x1DB5A10 VA: 0x181DB6610
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB61E0 Offset: 0x1DB55E0 VA: 0x181DB61E0
	public static byte[] SerializeToBytes(SprayLine instance) { }

	// RVA: 0x1DB6130 Offset: 0x1DB5530 VA: 0x181DB6130
	public static void SerializeLengthDelimited(Stream stream, SprayLine instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

