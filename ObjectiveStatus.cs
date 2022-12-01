public class ObjectiveStatus : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6462
{
	public bool ShouldPool;
	private bool _disposed;
	public bool started;
	public bool completed;
	public bool failed;
	public int genericInt1;
	public float genericFloat1;


	public static void ResetToPool(ObjectiveStatus instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ObjectiveStatus instance) { }

	public ObjectiveStatus Copy() { }

	public static ObjectiveStatus Deserialize(Stream stream) { }

	public static ObjectiveStatus DeserializeLengthDelimited(Stream stream) { }

	public static ObjectiveStatus DeserializeLength(Stream stream, int length) { }

	public static ObjectiveStatus Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ObjectiveStatus previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ObjectiveStatus Deserialize(byte[] buffer, ObjectiveStatus instance, bool isDelta = False) { }

	public static ObjectiveStatus Deserialize(Stream stream, ObjectiveStatus instance, bool isDelta) { }

	public static ObjectiveStatus DeserializeLengthDelimited(Stream stream, ObjectiveStatus instance, bool isDelta) { }

	public static ObjectiveStatus DeserializeLength(Stream stream, int length, ObjectiveStatus instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ObjectiveStatus instance, ObjectiveStatus previous) { }

	public static void Serialize(Stream stream, ObjectiveStatus instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ObjectiveStatus instance) { }

	public static void SerializeLengthDelimited(Stream stream, ObjectiveStatus instance) { }

	public void .ctor() { }

}

