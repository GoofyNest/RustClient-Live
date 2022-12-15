public class BrainComponent : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6451
{
	public bool ShouldPool;
	private bool _disposed;
	public int currentState;


	public static void ResetToPool(BrainComponent instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BrainComponent instance) { }

	public BrainComponent Copy() { }

	public static BrainComponent Deserialize(Stream stream) { }

	public static BrainComponent DeserializeLengthDelimited(Stream stream) { }

	public static BrainComponent DeserializeLength(Stream stream, int length) { }

	public static BrainComponent Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BrainComponent previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BrainComponent Deserialize(byte[] buffer, BrainComponent instance, bool isDelta = False) { }

	public static BrainComponent Deserialize(Stream stream, BrainComponent instance, bool isDelta) { }

	public static BrainComponent DeserializeLengthDelimited(Stream stream, BrainComponent instance, bool isDelta) { }

	public static BrainComponent DeserializeLength(Stream stream, int length, BrainComponent instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BrainComponent instance, BrainComponent previous) { }

	public static void Serialize(Stream stream, BrainComponent instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BrainComponent instance) { }

	public static void SerializeLengthDelimited(Stream stream, BrainComponent instance) { }

	public void .ctor() { }

}

