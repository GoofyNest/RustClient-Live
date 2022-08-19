public class ShopKeeper : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6381
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint vendingRef; // 0x14

	// Methods

	// RVA: 0x1E04030 Offset: 0x1E03430 VA: 0x181E04030
	public static void ResetToPool(ShopKeeper instance) { }

	// RVA: 0x1E040B0 Offset: 0x1E034B0 VA: 0x181E040B0
	public void ResetToPool() { }

	// RVA: 0x1E03F00 Offset: 0x1E03300 VA: 0x181E03F00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(ShopKeeper instance) { }

	// RVA: 0x1E03580 Offset: 0x1E02980 VA: 0x181E03580
	public ShopKeeper Copy() { }

	// RVA: 0x1E03E80 Offset: 0x1E03280 VA: 0x181E03E80
	public static ShopKeeper Deserialize(Stream stream) { }

	// RVA: 0x1E03810 Offset: 0x1E02C10 VA: 0x181E03810
	public static ShopKeeper DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E03890 Offset: 0x1E02C90 VA: 0x181E03890
	public static ShopKeeper DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E03C60 Offset: 0x1E03060 VA: 0x181E03C60
	public static ShopKeeper Deserialize(byte[] buffer) { }

	// RVA: 0x1E03FF0 Offset: 0x1E033F0 VA: 0x181E03FF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E04580 Offset: 0x1E03980 VA: 0x181E04580 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E04650 Offset: 0x1E03A50 VA: 0x181E04650 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ShopKeeper previous) { }

	// RVA: 0x1E04010 Offset: 0x1E03410 VA: 0x181E04010 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E03D80 Offset: 0x1E03180 VA: 0x181E03D80
	public static ShopKeeper Deserialize(byte[] buffer, ShopKeeper instance, bool isDelta = False) { }

	// RVA: 0x1E03B20 Offset: 0x1E02F20 VA: 0x181E03B20
	public static ShopKeeper Deserialize(Stream stream, ShopKeeper instance, bool isDelta) { }

	// RVA: 0x1E035F0 Offset: 0x1E029F0 VA: 0x181E035F0
	public static ShopKeeper DeserializeLengthDelimited(Stream stream, ShopKeeper instance, bool isDelta) { }

	// RVA: 0x1E03920 Offset: 0x1E02D20 VA: 0x181E03920
	public static ShopKeeper DeserializeLength(Stream stream, int length, ShopKeeper instance, bool isDelta) { }

	// RVA: 0x1E04130 Offset: 0x1E03530 VA: 0x181E04130
	public static void SerializeDelta(Stream stream, ShopKeeper instance, ShopKeeper previous) { }

	// RVA: 0x1E044A0 Offset: 0x1E038A0 VA: 0x181E044A0
	public static void Serialize(Stream stream, ShopKeeper instance) { }

	// RVA: 0x1E04570 Offset: 0x1E03970 VA: 0x181E04570
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E04580 Offset: 0x1E03980 VA: 0x181E04580
	public void ToProto(Stream stream) { }

	// RVA: 0x1E042F0 Offset: 0x1E036F0 VA: 0x181E042F0
	public static byte[] SerializeToBytes(ShopKeeper instance) { }

	// RVA: 0x1E04240 Offset: 0x1E03640 VA: 0x181E04240
	public static void SerializeLengthDelimited(Stream stream, ShopKeeper instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

