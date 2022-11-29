public class UpdateItemContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6487
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int type; 
	public List<ItemContainer> container; 


	public static void ResetToPool(UpdateItemContainer instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(UpdateItemContainer instance) { }

	public UpdateItemContainer Copy() { }

	public static UpdateItemContainer Deserialize(Stream stream) { }

	public static UpdateItemContainer DeserializeLengthDelimited(Stream stream) { }

	public static UpdateItemContainer DeserializeLength(Stream stream, int length) { }

	public static UpdateItemContainer Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, UpdateItemContainer previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static UpdateItemContainer Deserialize(byte[] buffer, UpdateItemContainer instance, bool isDelta = False) { }

	public static UpdateItemContainer Deserialize(Stream stream, UpdateItemContainer instance, bool isDelta) { }

	public static UpdateItemContainer DeserializeLengthDelimited(Stream stream, UpdateItemContainer instance, bool isDelta) { }

	public static UpdateItemContainer DeserializeLength(Stream stream, int length, UpdateItemContainer instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, UpdateItemContainer instance, UpdateItemContainer previous) { }

	public static void Serialize(Stream stream, UpdateItemContainer instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(UpdateItemContainer instance) { }

	public static void SerializeLengthDelimited(Stream stream, UpdateItemContainer instance) { }

	public void .ctor() { }

}

