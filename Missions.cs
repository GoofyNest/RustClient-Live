public class Missions : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6454
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<MissionInstance> missions; 
	public int activeMission; 
	public int protocol; 
	public uint seed; 
	public int saveCreatedTime; 


	public static void ResetToPool(Missions instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Missions instance) { }

	public Missions Copy() { }

	public static Missions Deserialize(Stream stream) { }

	public static Missions DeserializeLengthDelimited(Stream stream) { }

	public static Missions DeserializeLength(Stream stream, int length) { }

	public static Missions Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Missions previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Missions Deserialize(byte[] buffer, Missions instance, bool isDelta = False) { }

	public static Missions Deserialize(Stream stream, Missions instance, bool isDelta) { }

	public static Missions DeserializeLengthDelimited(Stream stream, Missions instance, bool isDelta) { }

	public static Missions DeserializeLength(Stream stream, int length, Missions instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Missions instance, Missions previous) { }

	public static void Serialize(Stream stream, Missions instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Missions instance) { }

	public static void SerializeLengthDelimited(Stream stream, Missions instance) { }

	public void .ctor() { }

}

