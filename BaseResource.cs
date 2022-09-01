public class BaseResource : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6298
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int stage; 
	public float health; 


	public static void ResetToPool(BaseResource instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BaseResource instance) { }

	public BaseResource Copy() { }

	public static BaseResource Deserialize(Stream stream) { }

	public static BaseResource DeserializeLengthDelimited(Stream stream) { }

	public static BaseResource DeserializeLength(Stream stream, int length) { }

	public static BaseResource Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BaseResource previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BaseResource Deserialize(byte[] buffer, BaseResource instance, bool isDelta = False) { }

	public static BaseResource Deserialize(Stream stream, BaseResource instance, bool isDelta) { }

	public static BaseResource DeserializeLengthDelimited(Stream stream, BaseResource instance, bool isDelta) { }

	public static BaseResource DeserializeLength(Stream stream, int length, BaseResource instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BaseResource instance, BaseResource previous) { }

	public static void Serialize(Stream stream, BaseResource instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BaseResource instance) { }

	public static void SerializeLengthDelimited(Stream stream, BaseResource instance) { }

	public void .ctor() { }

}

