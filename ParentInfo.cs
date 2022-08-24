public class ParentInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6302
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint uid; 
	public uint bone; 


	public static void ResetToPool(ParentInfo instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ParentInfo instance) { }

	public ParentInfo Copy() { }

	public static ParentInfo Deserialize(Stream stream) { }

	public static ParentInfo DeserializeLengthDelimited(Stream stream) { }

	public static ParentInfo DeserializeLength(Stream stream, int length) { }

	public static ParentInfo Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ParentInfo previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ParentInfo Deserialize(byte[] buffer, ParentInfo instance, bool isDelta = False) { }

	public static ParentInfo Deserialize(Stream stream, ParentInfo instance, bool isDelta) { }

	public static ParentInfo DeserializeLengthDelimited(Stream stream, ParentInfo instance, bool isDelta) { }

	public static ParentInfo DeserializeLength(Stream stream, int length, ParentInfo instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ParentInfo instance, ParentInfo previous) { }

	public static void Serialize(Stream stream, ParentInfo instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ParentInfo instance) { }

	public static void SerializeLengthDelimited(Stream stream, ParentInfo instance) { }

	public void .ctor() { }

}

