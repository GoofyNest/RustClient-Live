public class OwnerInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6334
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamid; // 0x18


	public static void ResetToPool(OwnerInfo instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(OwnerInfo instance) { }

	public OwnerInfo Copy() { }

	public static OwnerInfo Deserialize(Stream stream) { }

	public static OwnerInfo DeserializeLengthDelimited(Stream stream) { }

	public static OwnerInfo DeserializeLength(Stream stream, int length) { }

	public static OwnerInfo Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, OwnerInfo previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static OwnerInfo Deserialize(byte[] buffer, OwnerInfo instance, bool isDelta = False) { }

	public static OwnerInfo Deserialize(Stream stream, OwnerInfo instance, bool isDelta) { }

	public static OwnerInfo DeserializeLengthDelimited(Stream stream, OwnerInfo instance, bool isDelta) { }

	public static OwnerInfo DeserializeLength(Stream stream, int length, OwnerInfo instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, OwnerInfo instance, OwnerInfo previous) { }

	public static void Serialize(Stream stream, OwnerInfo instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(OwnerInfo instance) { }

	public static void SerializeLengthDelimited(Stream stream, OwnerInfo instance) { }

	public void .ctor() { }

}

