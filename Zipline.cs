public class Zipline : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6434
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VectorData> destinationPoints; // 0x18


	public static void ResetToPool(Zipline instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Zipline instance) { }

	public Zipline Copy() { }

	public static Zipline Deserialize(Stream stream) { }

	public static Zipline DeserializeLengthDelimited(Stream stream) { }

	public static Zipline DeserializeLength(Stream stream, int length) { }

	public static Zipline Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Zipline previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Zipline Deserialize(byte[] buffer, Zipline instance, bool isDelta = False) { }

	public static Zipline Deserialize(Stream stream, Zipline instance, bool isDelta) { }

	public static Zipline DeserializeLengthDelimited(Stream stream, Zipline instance, bool isDelta) { }

	public static Zipline DeserializeLength(Stream stream, int length, Zipline instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Zipline instance, Zipline previous) { }

	public static void Serialize(Stream stream, Zipline instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Zipline instance) { }

	public static void SerializeLengthDelimited(Stream stream, Zipline instance) { }

	public void .ctor() { }

}

