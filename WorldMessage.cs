public class WorldMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6508
{
	public bool ShouldPool; 
	private bool _disposed; 
	public WorldMessage.MessageType status; 
	public List<PrefabData> prefabs; 
	public List<PathData> paths; 


	public static void ResetToPool(WorldMessage instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(WorldMessage instance) { }

	public WorldMessage Copy() { }

	public static WorldMessage Deserialize(Stream stream) { }

	public static WorldMessage DeserializeLengthDelimited(Stream stream) { }

	public static WorldMessage DeserializeLength(Stream stream, int length) { }

	public static WorldMessage Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, WorldMessage previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static WorldMessage Deserialize(byte[] buffer, WorldMessage instance, bool isDelta = False) { }

	public static WorldMessage Deserialize(Stream stream, WorldMessage instance, bool isDelta) { }

	public static WorldMessage DeserializeLengthDelimited(Stream stream, WorldMessage instance, bool isDelta) { }

	public static WorldMessage DeserializeLength(Stream stream, int length, WorldMessage instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, WorldMessage instance, WorldMessage previous) { }

	public static void Serialize(Stream stream, WorldMessage instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(WorldMessage instance) { }

	public static void SerializeLengthDelimited(Stream stream, WorldMessage instance) { }

	public void .ctor() { }

}

public enum WorldMessage.MessageType // TypeDefIndex: 6509
{
	public int value__; 
	public const WorldMessage.MessageType Request = 1;
	public const WorldMessage.MessageType Receive = 2;
	public const WorldMessage.MessageType Done = 3;

}

