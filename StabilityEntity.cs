public class StabilityEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6333
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float stability; // 0x14
	public int distanceFromGround; // 0x18

	// Methods

	// RVA: 0x1DBA720 Offset: 0x1DB9B20 VA: 0x181DBA720
	public static void ResetToPool(StabilityEntity instance) { }

	// RVA: 0x1DBA7A0 Offset: 0x1DB9BA0 VA: 0x181DBA7A0
	public void ResetToPool() { }

	// RVA: 0x1DBA480 Offset: 0x1DB9880 VA: 0x181DBA480 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB9660 Offset: 0x1DB8A60 VA: 0x181DB9660
	public void CopyTo(StabilityEntity instance) { }

	// RVA: 0x1DB9680 Offset: 0x1DB8A80 VA: 0x181DB9680
	public StabilityEntity Copy() { }

	// RVA: 0x1DBA2C0 Offset: 0x1DB96C0 VA: 0x181DBA2C0
	public static StabilityEntity Deserialize(Stream stream) { }

	// RVA: 0x1DB9940 Offset: 0x1DB8D40 VA: 0x181DB9940
	public static StabilityEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DB99C0 Offset: 0x1DB8DC0 VA: 0x181DB99C0
	public static StabilityEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DB9C80 Offset: 0x1DB9080 VA: 0x181DB9C80
	public static StabilityEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1DBA580 Offset: 0x1DB9980 VA: 0x181DBA580
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DBAC60 Offset: 0x1DBA060 VA: 0x181DBAC60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DBAC80 Offset: 0x1DBA080 VA: 0x181DBAC80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, StabilityEntity previous) { }

	// RVA: 0x1DBA700 Offset: 0x1DB9B00 VA: 0x181DBA700 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DBA070 Offset: 0x1DB9470 VA: 0x181DBA070
	public static StabilityEntity Deserialize(byte[] buffer, StabilityEntity instance, bool isDelta = False) { }

	// RVA: 0x1DB9EF0 Offset: 0x1DB92F0 VA: 0x181DB9EF0
	public static StabilityEntity Deserialize(Stream stream, StabilityEntity instance, bool isDelta) { }

	// RVA: 0x1DB96F0 Offset: 0x1DB8AF0 VA: 0x181DB96F0
	public static StabilityEntity DeserializeLengthDelimited(Stream stream, StabilityEntity instance, bool isDelta) { }

	// RVA: 0x1DB9A50 Offset: 0x1DB8E50 VA: 0x181DB9A50
	public static StabilityEntity DeserializeLength(Stream stream, int length, StabilityEntity instance, bool isDelta) { }

	// RVA: 0x1DBA820 Offset: 0x1DB9C20 VA: 0x181DBA820
	public static void SerializeDelta(Stream stream, StabilityEntity instance, StabilityEntity previous) { }

	// RVA: 0x1DBAB50 Offset: 0x1DB9F50 VA: 0x181DBAB50
	public static void Serialize(Stream stream, StabilityEntity instance) { }

	// RVA: 0x1DBAC50 Offset: 0x1DBA050 VA: 0x181DBAC50
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DBAC60 Offset: 0x1DBA060 VA: 0x181DBAC60
	public void ToProto(Stream stream) { }

	// RVA: 0x1DBAA40 Offset: 0x1DB9E40 VA: 0x181DBAA40
	public static byte[] SerializeToBytes(StabilityEntity instance) { }

	// RVA: 0x1DBA990 Offset: 0x1DB9D90 VA: 0x181DBA990
	public static void SerializeLengthDelimited(Stream stream, StabilityEntity instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class StabilityEntity : DecayEntity // TypeDefIndex: 9682
{	// Fields
	public bool grounded; // 0x258
	public float cachedStability; // 0x25C
	public int cachedDistanceFromGround; // 0x260

	// Methods

	// RVA: 0xA85950 Offset: 0xA84D50 VA: 0x180A85950 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA859E0 Offset: 0xA84DE0 VA: 0x180A859E0 Slot: 27
	public override void ResetState() { }

	// RVA: 0xA85A10 Offset: 0xA84E10 VA: 0x180A85A10
	public void .ctor() { }

}

