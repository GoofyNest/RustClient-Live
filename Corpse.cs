public class Corpse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6299
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint parentID; // 0x14

	// Methods

	// RVA: 0x20AE470 Offset: 0x20AD870 VA: 0x1820AE470
	public static void ResetToPool(Corpse instance) { }

	// RVA: 0x20AE3F0 Offset: 0x20AD7F0 VA: 0x1820AE3F0
	public void ResetToPool() { }

	// RVA: 0x20AE2C0 Offset: 0x20AD6C0 VA: 0x1820AE2C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(Corpse instance) { }

	// RVA: 0x20AD940 Offset: 0x20ACD40 VA: 0x1820AD940
	public Corpse Copy() { }

	// RVA: 0x20AE140 Offset: 0x20AD540 VA: 0x1820AE140
	public static Corpse Deserialize(Stream stream) { }

	// RVA: 0x20ADBD0 Offset: 0x20ACFD0 VA: 0x1820ADBD0
	public static Corpse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20ADC50 Offset: 0x20AD050 VA: 0x1820ADC50
	public static Corpse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20ADEE0 Offset: 0x20AD2E0 VA: 0x1820ADEE0
	public static Corpse Deserialize(byte[] buffer) { }

	// RVA: 0x20AE3B0 Offset: 0x20AD7B0 VA: 0x1820AE3B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20AE940 Offset: 0x20ADD40 VA: 0x1820AE940 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20AEA10 Offset: 0x20ADE10 VA: 0x1820AEA10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Corpse previous) { }

	// RVA: 0x20AE3D0 Offset: 0x20AD7D0 VA: 0x1820AE3D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20AE1C0 Offset: 0x20AD5C0 VA: 0x1820AE1C0
	public static Corpse Deserialize(byte[] buffer, Corpse instance, bool isDelta = False) { }

	// RVA: 0x20AE000 Offset: 0x20AD400 VA: 0x1820AE000
	public static Corpse Deserialize(Stream stream, Corpse instance, bool isDelta) { }

	// RVA: 0x20AD9B0 Offset: 0x20ACDB0 VA: 0x1820AD9B0
	public static Corpse DeserializeLengthDelimited(Stream stream, Corpse instance, bool isDelta) { }

	// RVA: 0x20ADCE0 Offset: 0x20AD0E0 VA: 0x1820ADCE0
	public static Corpse DeserializeLength(Stream stream, int length, Corpse instance, bool isDelta) { }

	// RVA: 0x20AE4F0 Offset: 0x20AD8F0 VA: 0x1820AE4F0
	public static void SerializeDelta(Stream stream, Corpse instance, Corpse previous) { }

	// RVA: 0x20AE860 Offset: 0x20ADC60 VA: 0x1820AE860
	public static void Serialize(Stream stream, Corpse instance) { }

	// RVA: 0x20AE930 Offset: 0x20ADD30 VA: 0x1820AE930
	public byte[] ToProtoBytes() { }

	// RVA: 0x20AE940 Offset: 0x20ADD40 VA: 0x1820AE940
	public void ToProto(Stream stream) { }

	// RVA: 0x20AE6B0 Offset: 0x20ADAB0 VA: 0x1820AE6B0
	public static byte[] SerializeToBytes(Corpse instance) { }

	// RVA: 0x20AE600 Offset: 0x20ADA00 VA: 0x1820AE600
	public static void SerializeLengthDelimited(Stream stream, Corpse instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

