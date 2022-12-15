public class TakeDamage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6494
{
	public bool ShouldPool;
	private bool _disposed;
	public float amount;
	public Vector3 direction;
	public int type;


	public static void ResetToPool(TakeDamage instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(TakeDamage instance) { }

	public TakeDamage Copy() { }

	public static TakeDamage Deserialize(Stream stream) { }

	public static TakeDamage DeserializeLengthDelimited(Stream stream) { }

	public static TakeDamage DeserializeLength(Stream stream, int length) { }

	public static TakeDamage Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, TakeDamage previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static TakeDamage Deserialize(byte[] buffer, TakeDamage instance, bool isDelta = False) { }

	public static TakeDamage Deserialize(Stream stream, TakeDamage instance, bool isDelta) { }

	public static TakeDamage DeserializeLengthDelimited(Stream stream, TakeDamage instance, bool isDelta) { }

	public static TakeDamage DeserializeLength(Stream stream, int length, TakeDamage instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, TakeDamage instance, TakeDamage previous) { }

	public static void Serialize(Stream stream, TakeDamage instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(TakeDamage instance) { }

	public static void SerializeLengthDelimited(Stream stream, TakeDamage instance) { }

	public void .ctor() { }

}

