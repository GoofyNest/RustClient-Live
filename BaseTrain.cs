public class BaseTrain : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6437
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float time; // 0x14
	public float frontBogieYRot; // 0x18
	public float rearBogieYRot; // 0x1C
	public uint frontCouplingID; // 0x20
	public bool frontCouplingToFront; // 0x24
	public uint rearCouplingID; // 0x28
	public bool rearCouplingToFront; // 0x2C
	public int lootTypeIndex; // 0x30
	public float lootPercent; // 0x34

	// Methods

	// RVA: 0x1F63EC0 Offset: 0x1F632C0 VA: 0x181F63EC0
	public static void ResetToPool(BaseTrain instance) { }

	// RVA: 0x1F63FB0 Offset: 0x1F633B0 VA: 0x181F63FB0
	public void ResetToPool() { }

	// RVA: 0x1F639B0 Offset: 0x1F62DB0 VA: 0x181F639B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F61F50 Offset: 0x1F61350 VA: 0x181F61F50
	public void CopyTo(BaseTrain instance) { }

	// RVA: 0x1F61FA0 Offset: 0x1F613A0 VA: 0x181F61FA0
	public BaseTrain Copy() { }

	// RVA: 0x1F62E30 Offset: 0x1F62230 VA: 0x181F62E30
	public static BaseTrain Deserialize(Stream stream) { }

	// RVA: 0x1F62480 Offset: 0x1F61880 VA: 0x181F62480
	public static BaseTrain DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F62500 Offset: 0x1F61900 VA: 0x181F62500
	public static BaseTrain DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F629B0 Offset: 0x1F61DB0 VA: 0x181F629B0
	public static BaseTrain Deserialize(byte[] buffer) { }

	// RVA: 0x1F63B30 Offset: 0x1F62F30 VA: 0x181F63B30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F64820 Offset: 0x1F63C20 VA: 0x181F64820 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F64840 Offset: 0x1F63C40 VA: 0x181F64840 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseTrain previous) { }

	// RVA: 0x1F63EA0 Offset: 0x1F632A0 VA: 0x181F63EA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F631E0 Offset: 0x1F625E0 VA: 0x181F631E0
	public static BaseTrain Deserialize(byte[] buffer, BaseTrain instance, bool isDelta = False) { }

	// RVA: 0x1F63640 Offset: 0x1F62A40 VA: 0x181F63640
	public static BaseTrain Deserialize(Stream stream, BaseTrain instance, bool isDelta) { }

	// RVA: 0x1F62040 Offset: 0x1F61440 VA: 0x181F62040
	public static BaseTrain DeserializeLengthDelimited(Stream stream, BaseTrain instance, bool isDelta) { }

	// RVA: 0x1F62590 Offset: 0x1F61990 VA: 0x181F62590
	public static BaseTrain DeserializeLength(Stream stream, int length, BaseTrain instance, bool isDelta) { }

	// RVA: 0x1F640A0 Offset: 0x1F634A0 VA: 0x181F640A0
	public static void SerializeDelta(Stream stream, BaseTrain instance, BaseTrain previous) { }

	// RVA: 0x1F64610 Offset: 0x1F63A10 VA: 0x181F64610
	public static void Serialize(Stream stream, BaseTrain instance) { }

	// RVA: 0x1F64810 Offset: 0x1F63C10 VA: 0x181F64810
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F64820 Offset: 0x1F63C20 VA: 0x181F64820
	public void ToProto(Stream stream) { }

	// RVA: 0x1F64500 Offset: 0x1F63900 VA: 0x181F64500
	public static byte[] SerializeToBytes(BaseTrain instance) { }

	// RVA: 0x1F64450 Offset: 0x1F63850 VA: 0x181F64450
	public static void SerializeLengthDelimited(Stream stream, BaseTrain instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

