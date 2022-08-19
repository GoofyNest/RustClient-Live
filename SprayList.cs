public class SprayList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6432
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<LinePoint> linePoints; // 0x18

	// Methods

	// RVA: 0x1DB7720 Offset: 0x1DB6B20 VA: 0x181DB7720
	public static void ResetToPool(SprayList instance) { }

	// RVA: 0x1DB7570 Offset: 0x1DB6970 VA: 0x181DB7570
	public void ResetToPool() { }

	// RVA: 0x1DB72F0 Offset: 0x1DB66F0 VA: 0x181DB72F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB6650 Offset: 0x1DB5A50 VA: 0x181DB6650
	public void CopyTo(SprayList instance) { }

	// RVA: 0x1DB6780 Offset: 0x1DB5B80 VA: 0x181DB6780
	public SprayList Copy() { }

	// RVA: 0x1DB7270 Offset: 0x1DB6670 VA: 0x181DB7270
	public static SprayList Deserialize(Stream stream) { }

	// RVA: 0x1DB6B60 Offset: 0x1DB5F60 VA: 0x181DB6B60
	public static SprayList DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB6BE0 Offset: 0x1DB5FE0 VA: 0x181DB6BE0
	public static SprayList DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB7150 Offset: 0x1DB6550 VA: 0x181DB7150
	public static SprayList Deserialize(byte[] buffer) { }

	// RVA: 0x1DB7530 Offset: 0x1DB6930 VA: 0x181DB7530
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB7E60 Offset: 0x1DB7260 VA: 0x181DB7E60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB7E80 Offset: 0x1DB7280 VA: 0x181DB7E80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SprayList previous) { }

	// RVA: 0x1DB7550 Offset: 0x1DB6950 VA: 0x181DB7550 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB6EC0 Offset: 0x1DB62C0 VA: 0x181DB6EC0
	public static SprayList Deserialize(byte[] buffer, SprayList instance, bool isDelta = False) { }

	// RVA: 0x1DB6FC0 Offset: 0x1DB63C0 VA: 0x181DB6FC0
	public static SprayList Deserialize(Stream stream, SprayList instance, bool isDelta) { }

	// RVA: 0x1DB68F0 Offset: 0x1DB5CF0 VA: 0x181DB68F0
	public static SprayList DeserializeLengthDelimited(Stream stream, SprayList instance, bool isDelta) { }

	// RVA: 0x1DB6C70 Offset: 0x1DB6070 VA: 0x181DB6C70
	public static SprayList DeserializeLength(Stream stream, int length, SprayList instance, bool isDelta) { }

	// RVA: 0x1DB78D0 Offset: 0x1DB6CD0 VA: 0x181DB78D0
	public static void SerializeDelta(Stream stream, SprayList instance, SprayList previous) { }

	// RVA: 0x1DB7C70 Offset: 0x1DB7070 VA: 0x181DB7C70
	public static void Serialize(Stream stream, SprayList instance) { }

	// RVA: 0x1DB7E50 Offset: 0x1DB7250 VA: 0x181DB7E50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB7E60 Offset: 0x1DB7260 VA: 0x181DB7E60
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB7B60 Offset: 0x1DB6F60 VA: 0x181DB7B60
	public static byte[] SerializeToBytes(SprayList instance) { }

	// RVA: 0x1DB7AB0 Offset: 0x1DB6EB0 VA: 0x181DB7AB0
	public static void SerializeLengthDelimited(Stream stream, SprayList instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

