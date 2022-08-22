public class Whitelist : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6308
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ulong> users; // 0x18


	public static void ResetToPool(Whitelist instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Whitelist instance) { }

	public Whitelist Copy() { }

	public static Whitelist Deserialize(Stream stream) { }

	public static Whitelist DeserializeLengthDelimited(Stream stream) { }

	public static Whitelist DeserializeLength(Stream stream, int length) { }

	public static Whitelist Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Whitelist previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Whitelist Deserialize(byte[] buffer, Whitelist instance, bool isDelta = False) { }

	public static Whitelist Deserialize(Stream stream, Whitelist instance, bool isDelta) { }

	public static Whitelist DeserializeLengthDelimited(Stream stream, Whitelist instance, bool isDelta) { }

	public static Whitelist DeserializeLength(Stream stream, int length, Whitelist instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Whitelist instance, Whitelist previous) { }

	public static void Serialize(Stream stream, Whitelist instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Whitelist instance) { }

	public static void SerializeLengthDelimited(Stream stream, Whitelist instance) { }

	public void .ctor() { }

}

