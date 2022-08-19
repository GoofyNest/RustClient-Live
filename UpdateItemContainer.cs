public class UpdateItemContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6477
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int type; // 0x14
	public List<ItemContainer> container; // 0x18

	// Methods

	// RVA: 0x1EF1BF0 Offset: 0x1EF0FF0 VA: 0x181EF1BF0
	public static void ResetToPool(UpdateItemContainer instance) { }

	// RVA: 0x1EF1A30 Offset: 0x1EF0E30 VA: 0x181EF1A30
	public void ResetToPool() { }

	// RVA: 0x1EF1970 Offset: 0x1EF0D70 VA: 0x181EF1970 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF08D0 Offset: 0x1EEFCD0 VA: 0x181EF08D0
	public void CopyTo(UpdateItemContainer instance) { }

	// RVA: 0x1EF0A00 Offset: 0x1EEFE00 VA: 0x181EF0A00
	public UpdateItemContainer Copy() { }

	// RVA: 0x1EF13B0 Offset: 0x1EF07B0 VA: 0x181EF13B0
	public static UpdateItemContainer Deserialize(Stream stream) { }

	// RVA: 0x1EF0E30 Offset: 0x1EF0230 VA: 0x181EF0E30
	public static UpdateItemContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF0EB0 Offset: 0x1EF02B0 VA: 0x181EF0EB0
	public static UpdateItemContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF16C0 Offset: 0x1EF0AC0 VA: 0x181EF16C0
	public static UpdateItemContainer Deserialize(byte[] buffer) { }

	// RVA: 0x1EF19F0 Offset: 0x1EF0DF0 VA: 0x181EF19F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EF23E0 Offset: 0x1EF17E0 VA: 0x181EF23E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EF2400 Offset: 0x1EF1800 VA: 0x181EF2400 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, UpdateItemContainer previous) { }

	// RVA: 0x1EF1A10 Offset: 0x1EF0E10 VA: 0x181EF1A10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF15C0 Offset: 0x1EF09C0 VA: 0x181EF15C0
	public static UpdateItemContainer Deserialize(byte[] buffer, UpdateItemContainer instance, bool isDelta = False) { }

	// RVA: 0x1EF11D0 Offset: 0x1EF05D0 VA: 0x181EF11D0
	public static UpdateItemContainer Deserialize(Stream stream, UpdateItemContainer instance, bool isDelta) { }

	// RVA: 0x1EF0B80 Offset: 0x1EEFF80 VA: 0x181EF0B80
	public static UpdateItemContainer DeserializeLengthDelimited(Stream stream, UpdateItemContainer instance, bool isDelta) { }

	// RVA: 0x1EF0F40 Offset: 0x1EF0340 VA: 0x181EF0F40
	public static UpdateItemContainer DeserializeLength(Stream stream, int length, UpdateItemContainer instance, bool isDelta) { }

	// RVA: 0x1EF1DB0 Offset: 0x1EF11B0 VA: 0x181EF1DB0
	public static void SerializeDelta(Stream stream, UpdateItemContainer instance, UpdateItemContainer previous) { }

	// RVA: 0x1EF21B0 Offset: 0x1EF15B0 VA: 0x181EF21B0
	public static void Serialize(Stream stream, UpdateItemContainer instance) { }

	// RVA: 0x1EF23D0 Offset: 0x1EF17D0 VA: 0x181EF23D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EF23E0 Offset: 0x1EF17E0 VA: 0x181EF23E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF20A0 Offset: 0x1EF14A0 VA: 0x181EF20A0
	public static byte[] SerializeToBytes(UpdateItemContainer instance) { }

	// RVA: 0x1EF1FF0 Offset: 0x1EF13F0 VA: 0x181EF1FF0
	public static void SerializeLengthDelimited(Stream stream, UpdateItemContainer instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

