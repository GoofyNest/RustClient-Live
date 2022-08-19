public class SphereEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6332
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float radius; // 0x14

	// Methods

	// RVA: 0x1DB2940 Offset: 0x1DB1D40 VA: 0x181DB2940
	public static void ResetToPool(SphereEntity instance) { }

	// RVA: 0x1DB28C0 Offset: 0x1DB1CC0 VA: 0x181DB28C0
	public void ResetToPool() { }

	// RVA: 0x1DB2790 Offset: 0x1DB1B90 VA: 0x181DB2790 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(SphereEntity instance) { }

	// RVA: 0x1DB1E00 Offset: 0x1DB1200 VA: 0x181DB1E00
	public SphereEntity Copy() { }

	// RVA: 0x1DB2710 Offset: 0x1DB1B10 VA: 0x181DB2710
	public static SphereEntity Deserialize(Stream stream) { }

	// RVA: 0x1DB1E70 Offset: 0x1DB1270 VA: 0x181DB1E70
	public static SphereEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB2310 Offset: 0x1DB1710 VA: 0x181DB2310
	public static SphereEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB24A0 Offset: 0x1DB18A0 VA: 0x181DB24A0
	public static SphereEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1DB2880 Offset: 0x1DB1C80 VA: 0x181DB2880
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DB2D90 Offset: 0x1DB2190 VA: 0x181DB2D90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DB2DB0 Offset: 0x1DB21B0 VA: 0x181DB2DB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SphereEntity previous) { }

	// RVA: 0x1DB28A0 Offset: 0x1DB1CA0 VA: 0x181DB28A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DB23A0 Offset: 0x1DB17A0 VA: 0x181DB23A0
	public static SphereEntity Deserialize(byte[] buffer, SphereEntity instance, bool isDelta = False) { }

	// RVA: 0x1DB25C0 Offset: 0x1DB19C0 VA: 0x181DB25C0
	public static SphereEntity Deserialize(Stream stream, SphereEntity instance, bool isDelta) { }

	// RVA: 0x1DB1EF0 Offset: 0x1DB12F0 VA: 0x181DB1EF0
	public static SphereEntity DeserializeLengthDelimited(Stream stream, SphereEntity instance, bool isDelta) { }

	// RVA: 0x1DB2110 Offset: 0x1DB1510 VA: 0x181DB2110
	public static SphereEntity DeserializeLength(Stream stream, int length, SphereEntity instance, bool isDelta) { }

	// RVA: 0x1DB29C0 Offset: 0x1DB1DC0 VA: 0x181DB29C0
	public static void SerializeDelta(Stream stream, SphereEntity instance, SphereEntity previous) { }

	// RVA: 0x1DB2CA0 Offset: 0x1DB20A0 VA: 0x181DB2CA0
	public static void Serialize(Stream stream, SphereEntity instance) { }

	// RVA: 0x1DB2D80 Offset: 0x1DB2180 VA: 0x181DB2D80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DB2D90 Offset: 0x1DB2190 VA: 0x181DB2D90
	public void ToProto(Stream stream) { }

	// RVA: 0x1DB2B90 Offset: 0x1DB1F90 VA: 0x181DB2B90
	public static byte[] SerializeToBytes(SphereEntity instance) { }

	// RVA: 0x1DB2AE0 Offset: 0x1DB1EE0 VA: 0x181DB2AE0
	public static void SerializeLengthDelimited(Stream stream, SphereEntity instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class SphereEntity : BaseEntity // TypeDefIndex: 9608
{	// Fields
	public float currentRadius; // 0x168
	public float lerpRadius; // 0x16C
	public float lerpSpeed; // 0x170

	// Methods

	// RVA: 0xA7A600 Offset: 0xA79A00 VA: 0x180A7A600 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA7A670 Offset: 0xA79A70 VA: 0x180A7A670
	protected void UpdateScale() { }

	// RVA: 0xA7A6F0 Offset: 0xA79AF0 VA: 0x180A7A6F0
	protected void Update() { }

	// RVA: 0xA7A880 Offset: 0xA79C80 VA: 0x180A7A880
	public void .ctor() { }

}

