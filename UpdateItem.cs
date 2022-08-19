public class UpdateItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6479
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Item item; // 0x18

	// Methods

	// RVA: 0x1EF3050 Offset: 0x1EF2450 VA: 0x181EF3050
	public static void ResetToPool(UpdateItem instance) { }

	// RVA: 0x1EF2FB0 Offset: 0x1EF23B0 VA: 0x181EF2FB0
	public void ResetToPool() { }

	// RVA: 0x1EF2E50 Offset: 0x1EF2250 VA: 0x181EF2E50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E51B90 Offset: 0x1E50F90 VA: 0x181E51B90
	public void CopyTo(UpdateItem instance) { }

	// RVA: 0x1EF2420 Offset: 0x1EF1820 VA: 0x181EF2420
	public UpdateItem Copy() { }

	// RVA: 0x1EF2A50 Offset: 0x1EF1E50 VA: 0x181EF2A50
	public static UpdateItem Deserialize(Stream stream) { }

	// RVA: 0x1EF2730 Offset: 0x1EF1B30 VA: 0x181EF2730
	public static UpdateItem DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF29C0 Offset: 0x1EF1DC0 VA: 0x181EF29C0
	public static UpdateItem DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF2AD0 Offset: 0x1EF1ED0 VA: 0x181EF2AD0
	public static UpdateItem Deserialize(byte[] buffer) { }

	// RVA: 0x1EF2F70 Offset: 0x1EF2370 VA: 0x181EF2F70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF3660 Offset: 0x1EF2A60 VA: 0x181EF3660 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF3680 Offset: 0x1EF2A80 VA: 0x181EF3680 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, UpdateItem previous) { }

	// RVA: 0x1EF2F90 Offset: 0x1EF2390 VA: 0x181EF2F90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF2BF0 Offset: 0x1EF1FF0 VA: 0x181EF2BF0
	public static UpdateItem Deserialize(byte[] buffer, UpdateItem instance, bool isDelta = False) { }

	// RVA: 0x1EF2CF0 Offset: 0x1EF20F0 VA: 0x181EF2CF0
	public static UpdateItem Deserialize(Stream stream, UpdateItem instance, bool isDelta) { }

	// RVA: 0x1EF24F0 Offset: 0x1EF18F0 VA: 0x181EF24F0
	public static UpdateItem DeserializeLengthDelimited(Stream stream, UpdateItem instance, bool isDelta) { }

	// RVA: 0x1EF27B0 Offset: 0x1EF1BB0 VA: 0x181EF27B0
	public static UpdateItem DeserializeLength(Stream stream, int length, UpdateItem instance, bool isDelta) { }

	// RVA: 0x1EF30F0 Offset: 0x1EF24F0 VA: 0x181EF30F0
	public static void SerializeDelta(Stream stream, UpdateItem instance, UpdateItem previous) { }

	// RVA: 0x1EF3490 Offset: 0x1EF2890 VA: 0x181EF3490
	public static void Serialize(Stream stream, UpdateItem instance) { }

	// RVA: 0x1EF3650 Offset: 0x1EF2A50 VA: 0x181EF3650
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF3660 Offset: 0x1EF2A60 VA: 0x181EF3660
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF3380 Offset: 0x1EF2780 VA: 0x181EF3380
	public static byte[] SerializeToBytes(UpdateItem instance) { }

	// RVA: 0x1EF32D0 Offset: 0x1EF26D0 VA: 0x181EF32D0
	public static void SerializeLengthDelimited(Stream stream, UpdateItem instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

