public class Composter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6377
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float fertilizerProductionProgress; // 0x14

	// Methods

	// RVA: 0x20AAF40 Offset: 0x20AA340 VA: 0x1820AAF40
	public static void ResetToPool(Composter instance) { }

	// RVA: 0x20AAFC0 Offset: 0x20AA3C0 VA: 0x1820AAFC0
	public void ResetToPool() { }

	// RVA: 0x20AAE10 Offset: 0x20AA210 VA: 0x1820AAE10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(Composter instance) { }

	// RVA: 0x20AA480 Offset: 0x20A9880 VA: 0x1820AA480
	public Composter Copy() { }

	// RVA: 0x20AAB20 Offset: 0x20A9F20 VA: 0x1820AAB20
	public static Composter Deserialize(Stream stream) { }

	// RVA: 0x20AA710 Offset: 0x20A9B10 VA: 0x1820AA710
	public static Composter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20AA790 Offset: 0x20A9B90 VA: 0x1820AA790
	public static Composter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20AACF0 Offset: 0x20AA0F0 VA: 0x1820AACF0
	public static Composter Deserialize(byte[] buffer) { }

	// RVA: 0x20AAF00 Offset: 0x20AA300 VA: 0x1820AAF00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20AB410 Offset: 0x20AA810 VA: 0x1820AB410 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20AB430 Offset: 0x20AA830 VA: 0x1820AB430 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Composter previous) { }

	// RVA: 0x20AAF20 Offset: 0x20AA320 VA: 0x1820AAF20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20AAA20 Offset: 0x20A9E20 VA: 0x1820AAA20
	public static Composter Deserialize(byte[] buffer, Composter instance, bool isDelta = False) { }

	// RVA: 0x20AABA0 Offset: 0x20A9FA0 VA: 0x1820AABA0
	public static Composter Deserialize(Stream stream, Composter instance, bool isDelta) { }

	// RVA: 0x20AA4F0 Offset: 0x20A98F0 VA: 0x1820AA4F0
	public static Composter DeserializeLengthDelimited(Stream stream, Composter instance, bool isDelta) { }

	// RVA: 0x20AA820 Offset: 0x20A9C20 VA: 0x1820AA820
	public static Composter DeserializeLength(Stream stream, int length, Composter instance, bool isDelta) { }

	// RVA: 0x20AB040 Offset: 0x20AA440 VA: 0x1820AB040
	public static void SerializeDelta(Stream stream, Composter instance, Composter previous) { }

	// RVA: 0x20AB320 Offset: 0x20AA720 VA: 0x1820AB320
	public static void Serialize(Stream stream, Composter instance) { }

	// RVA: 0x20AB400 Offset: 0x20AA800 VA: 0x1820AB400
	public byte[] ToProtoBytes() { }

	// RVA: 0x20AB410 Offset: 0x20AA810 VA: 0x1820AB410
	public void ToProto(Stream stream) { }

	// RVA: 0x20AB210 Offset: 0x20AA610 VA: 0x1820AB210
	public static byte[] SerializeToBytes(Composter instance) { }

	// RVA: 0x20AB160 Offset: 0x20AA560 VA: 0x1820AB160
	public static void SerializeLengthDelimited(Stream stream, Composter instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class Composter : StorageContainer // TypeDefIndex: 8684
{	// Methods

	// RVA: 0x6CF780 Offset: 0x6CEB80 VA: 0x1806CF780
	public void .ctor() { }

}

