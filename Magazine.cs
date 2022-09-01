public class Magazine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6318
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int capacity; 
	public int contents; 
	public int ammoType; 


	public static void ResetToPool(Magazine instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Magazine instance) { }

	public Magazine Copy() { }

	public static Magazine Deserialize(Stream stream) { }

	public static Magazine DeserializeLengthDelimited(Stream stream) { }

	public static Magazine DeserializeLength(Stream stream, int length) { }

	public static Magazine Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Magazine previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Magazine Deserialize(byte[] buffer, Magazine instance, bool isDelta = False) { }

	public static Magazine Deserialize(Stream stream, Magazine instance, bool isDelta) { }

	public static Magazine DeserializeLengthDelimited(Stream stream, Magazine instance, bool isDelta) { }

	public static Magazine DeserializeLength(Stream stream, int length, Magazine instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Magazine instance, Magazine previous) { }

	public static void Serialize(Stream stream, Magazine instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Magazine instance) { }

	public static void SerializeLengthDelimited(Stream stream, Magazine instance) { }

	public void .ctor() { }

}

