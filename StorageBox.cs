public class StorageBox : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6311
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ItemContainer contents; // 0x18


	public static void ResetToPool(StorageBox instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(StorageBox instance) { }

	public StorageBox Copy() { }

	public static StorageBox Deserialize(Stream stream) { }

	public static StorageBox DeserializeLengthDelimited(Stream stream) { }

	public static StorageBox DeserializeLength(Stream stream, int length) { }

	public static StorageBox Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, StorageBox previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static StorageBox Deserialize(byte[] buffer, StorageBox instance, bool isDelta = False) { }

	public static StorageBox Deserialize(Stream stream, StorageBox instance, bool isDelta) { }

	public static StorageBox DeserializeLengthDelimited(Stream stream, StorageBox instance, bool isDelta) { }

	public static StorageBox DeserializeLength(Stream stream, int length, StorageBox instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, StorageBox instance, StorageBox previous) { }

	public static void Serialize(Stream stream, StorageBox instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(StorageBox instance) { }

	public static void SerializeLengthDelimited(Stream stream, StorageBox instance) { }

	public void .ctor() { }

}

