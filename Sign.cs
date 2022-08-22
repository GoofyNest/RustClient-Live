public class Sign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6319
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint imageid; // 0x14
	public List<uint> imageIds; // 0x18
	public List<ulong> editHistory; // 0x20


	public static void ResetToPool(Sign instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Sign instance) { }

	public Sign Copy() { }

	public static Sign Deserialize(Stream stream) { }

	public static Sign DeserializeLengthDelimited(Stream stream) { }

	public static Sign DeserializeLength(Stream stream, int length) { }

	public static Sign Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Sign previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Sign Deserialize(byte[] buffer, Sign instance, bool isDelta = False) { }

	public static Sign Deserialize(Stream stream, Sign instance, bool isDelta) { }

	public static Sign DeserializeLengthDelimited(Stream stream, Sign instance, bool isDelta) { }

	public static Sign DeserializeLength(Stream stream, int length, Sign instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Sign instance, Sign previous) { }

	public static void Serialize(Stream stream, Sign instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Sign instance) { }

	public static void SerializeLengthDelimited(Stream stream, Sign instance) { }

	public void .ctor() { }

}

