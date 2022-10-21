public class WorldData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6513
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint size; 
	public List<MapData> maps; 
	public List<PrefabData> prefabs; 
	public List<PathData> paths; 


	public static void ResetToPool(WorldData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(WorldData instance) { }

	public WorldData Copy() { }

	public static WorldData Deserialize(Stream stream) { }

	public static WorldData DeserializeLengthDelimited(Stream stream) { }

	public static WorldData DeserializeLength(Stream stream, int length) { }

	public static WorldData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, WorldData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static WorldData Deserialize(byte[] buffer, WorldData instance, bool isDelta = False) { }

	public static WorldData Deserialize(Stream stream, WorldData instance, bool isDelta) { }

	public static WorldData DeserializeLengthDelimited(Stream stream, WorldData instance, bool isDelta) { }

	public static WorldData DeserializeLength(Stream stream, int length, WorldData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, WorldData instance, WorldData previous) { }

	public static void Serialize(Stream stream, WorldData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(WorldData instance) { }

	public static void SerializeLengthDelimited(Stream stream, WorldData instance) { }

	public void .ctor() { }

}

