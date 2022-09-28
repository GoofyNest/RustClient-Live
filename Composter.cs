public class Composter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6378
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float fertilizerProductionProgress; 


	public static void ResetToPool(Composter instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Composter instance) { }

	public Composter Copy() { }

	public static Composter Deserialize(Stream stream) { }

	public static Composter DeserializeLengthDelimited(Stream stream) { }

	public static Composter DeserializeLength(Stream stream, int length) { }

	public static Composter Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Composter previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Composter Deserialize(byte[] buffer, Composter instance, bool isDelta = False) { }

	public static Composter Deserialize(Stream stream, Composter instance, bool isDelta) { }

	public static Composter DeserializeLengthDelimited(Stream stream, Composter instance, bool isDelta) { }

	public static Composter DeserializeLength(Stream stream, int length, Composter instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Composter instance, Composter previous) { }

	public static void Serialize(Stream stream, Composter instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Composter instance) { }

	public static void SerializeLengthDelimited(Stream stream, Composter instance) { }

	public void .ctor() { }

}

public class Composter : StorageContainer // TypeDefIndex: 10356
{

	public void .ctor() { }

}

