public class StabilityEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6333
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float stability; // 0x14
	public int distanceFromGround; // 0x18


	public static void ResetToPool(StabilityEntity instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(StabilityEntity instance) { }

	public StabilityEntity Copy() { }

	public static StabilityEntity Deserialize(Stream stream) { }

	public static StabilityEntity DeserializeLengthDelimited(Stream stream) { }

	public static StabilityEntity DeserializeLength(Stream stream, int length) { }

	public static StabilityEntity Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, StabilityEntity previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static StabilityEntity Deserialize(byte[] buffer, StabilityEntity instance, bool isDelta = False) { }

	public static StabilityEntity Deserialize(Stream stream, StabilityEntity instance, bool isDelta) { }

	public static StabilityEntity DeserializeLengthDelimited(Stream stream, StabilityEntity instance, bool isDelta) { }

	public static StabilityEntity DeserializeLength(Stream stream, int length, StabilityEntity instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, StabilityEntity instance, StabilityEntity previous) { }

	public static void Serialize(Stream stream, StabilityEntity instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(StabilityEntity instance) { }

	public static void SerializeLengthDelimited(Stream stream, StabilityEntity instance) { }

	public void .ctor() { }

}

public class StabilityEntity : DecayEntity // TypeDefIndex: 9682
{	public bool grounded; // 0x258
	public float cachedStability; // 0x25C
	public int cachedDistanceFromGround; // 0x260


	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void ResetState() { }

	public void .ctor() { }

}

