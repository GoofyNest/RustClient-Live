public class DudExplosive : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6322
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float fuseTimeLeft; 


	public static void ResetToPool(DudExplosive instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(DudExplosive instance) { }

	public DudExplosive Copy() { }

	public static DudExplosive Deserialize(Stream stream) { }

	public static DudExplosive DeserializeLengthDelimited(Stream stream) { }

	public static DudExplosive DeserializeLength(Stream stream, int length) { }

	public static DudExplosive Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, DudExplosive previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static DudExplosive Deserialize(byte[] buffer, DudExplosive instance, bool isDelta = False) { }

	public static DudExplosive Deserialize(Stream stream, DudExplosive instance, bool isDelta) { }

	public static DudExplosive DeserializeLengthDelimited(Stream stream, DudExplosive instance, bool isDelta) { }

	public static DudExplosive DeserializeLength(Stream stream, int length, DudExplosive instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, DudExplosive instance, DudExplosive previous) { }

	public static void Serialize(Stream stream, DudExplosive instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(DudExplosive instance) { }

	public static void SerializeLengthDelimited(Stream stream, DudExplosive instance) { }

	public void .ctor() { }

}

