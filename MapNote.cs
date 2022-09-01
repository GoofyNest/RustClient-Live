public class MapNote : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6461
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int noteType; 
	public Vector3 worldPosition; 


	public static void ResetToPool(MapNote instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(MapNote instance) { }

	public MapNote Copy() { }

	public static MapNote Deserialize(Stream stream) { }

	public static MapNote DeserializeLengthDelimited(Stream stream) { }

	public static MapNote DeserializeLength(Stream stream, int length) { }

	public static MapNote Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, MapNote previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static MapNote Deserialize(byte[] buffer, MapNote instance, bool isDelta = False) { }

	public static MapNote Deserialize(Stream stream, MapNote instance, bool isDelta) { }

	public static MapNote DeserializeLengthDelimited(Stream stream, MapNote instance, bool isDelta) { }

	public static MapNote DeserializeLength(Stream stream, int length, MapNote instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, MapNote instance, MapNote previous) { }

	public static void Serialize(Stream stream, MapNote instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(MapNote instance) { }

	public static void SerializeLengthDelimited(Stream stream, MapNote instance) { }

	public void .ctor() { }

}

