public class BaseCombat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6294
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int state; // 0x14
	public float health; // 0x18

	// Methods

	// RVA: 0x1FF73B0 Offset: 0x1FF67B0 VA: 0x181FF73B0
	public static void ResetToPool(BaseCombat instance) { }

	// RVA: 0x1FF7330 Offset: 0x1FF6730 VA: 0x181FF7330
	public void ResetToPool() { }

	// RVA: 0x1FF7090 Offset: 0x1FF6490 VA: 0x181FF7090 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB9660 Offset: 0x1DB8A60 VA: 0x181DB9660
	public void CopyTo(BaseCombat instance) { }

	// RVA: 0x1FF6290 Offset: 0x1FF5690 VA: 0x181FF6290
	public BaseCombat Copy() { }

	// RVA: 0x1FF6A10 Offset: 0x1FF5E10 VA: 0x181FF6A10
	public static BaseCombat Deserialize(Stream stream) { }

	// RVA: 0x1FF6300 Offset: 0x1FF5700 VA: 0x181FF6300
	public static BaseCombat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF6800 Offset: 0x1FF5C00 VA: 0x181FF6800
	public static BaseCombat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF6E20 Offset: 0x1FF6220 VA: 0x181FF6E20
	public static BaseCombat Deserialize(byte[] buffer) { }

	// RVA: 0x1FF7190 Offset: 0x1FF6590 VA: 0x181FF7190
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF7880 Offset: 0x1FF6C80 VA: 0x181FF7880 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF78A0 Offset: 0x1FF6CA0 VA: 0x181FF78A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseCombat previous) { }

	// RVA: 0x1FF7310 Offset: 0x1FF6710 VA: 0x181FF7310 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF6BD0 Offset: 0x1FF5FD0 VA: 0x181FF6BD0
	public static BaseCombat Deserialize(byte[] buffer, BaseCombat instance, bool isDelta = False) { }

	// RVA: 0x1FF6890 Offset: 0x1FF5C90 VA: 0x181FF6890
	public static BaseCombat Deserialize(Stream stream, BaseCombat instance, bool isDelta) { }

	// RVA: 0x1FF6380 Offset: 0x1FF5780 VA: 0x181FF6380
	public static BaseCombat DeserializeLengthDelimited(Stream stream, BaseCombat instance, bool isDelta) { }

	// RVA: 0x1FF65D0 Offset: 0x1FF59D0 VA: 0x181FF65D0
	public static BaseCombat DeserializeLength(Stream stream, int length, BaseCombat instance, bool isDelta) { }

	// RVA: 0x1FF7430 Offset: 0x1FF6830 VA: 0x181FF7430
	public static void SerializeDelta(Stream stream, BaseCombat instance, BaseCombat previous) { }

	// RVA: 0x1FF7770 Offset: 0x1FF6B70 VA: 0x181FF7770
	public static void Serialize(Stream stream, BaseCombat instance) { }

	// RVA: 0x1FF7870 Offset: 0x1FF6C70 VA: 0x181FF7870
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF7880 Offset: 0x1FF6C80 VA: 0x181FF7880
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF7660 Offset: 0x1FF6A60 VA: 0x181FF7660
	public static byte[] SerializeToBytes(BaseCombat instance) { }

	// RVA: 0x1FF75B0 Offset: 0x1FF69B0 VA: 0x181FF75B0
	public static void SerializeLengthDelimited(Stream stream, BaseCombat instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

