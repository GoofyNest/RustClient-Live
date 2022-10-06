public class MapData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6513
{
	public bool ShouldPool; 
	private bool _disposed; 
	public string name; 
	public byte[] data; 


	public static void ResetToPool(MapData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(MapData instance) { }

	public MapData Copy() { }

	public static MapData Deserialize(Stream stream) { }

	public static MapData DeserializeLengthDelimited(Stream stream) { }

	public static MapData DeserializeLength(Stream stream, int length) { }

	public static MapData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, MapData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static MapData Deserialize(byte[] buffer, MapData instance, bool isDelta = False) { }

	public static MapData Deserialize(Stream stream, MapData instance, bool isDelta) { }

	public static MapData DeserializeLengthDelimited(Stream stream, MapData instance, bool isDelta) { }

	public static MapData DeserializeLength(Stream stream, int length, MapData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, MapData instance, MapData previous) { }

	public static void Serialize(Stream stream, MapData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(MapData instance) { }

	public static void SerializeLengthDelimited(Stream stream, MapData instance) { }

	public void .ctor() { }

}

