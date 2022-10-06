public class MissionInstance : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6458
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint providerID; 
	public uint missionID; 
	public uint missionStatus; 
	public float completionScale; 
	public float startTime; 
	public float endTime; 
	public Vector3 missionLocation; 
	public List<ObjectiveStatus> objectiveStatuses; 
	public List<MissionPoint> missionPoints; 
	public List<uint> createdEntities; 
	public List<MissionReward> rewards; 


	public static void ResetToPool(MissionInstance instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(MissionInstance instance) { }

	public MissionInstance Copy() { }

	public static MissionInstance Deserialize(Stream stream) { }

	public static MissionInstance DeserializeLengthDelimited(Stream stream) { }

	public static MissionInstance DeserializeLength(Stream stream, int length) { }

	public static MissionInstance Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, MissionInstance previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static MissionInstance Deserialize(byte[] buffer, MissionInstance instance, bool isDelta = False) { }

	public static MissionInstance Deserialize(Stream stream, MissionInstance instance, bool isDelta) { }

	public static MissionInstance DeserializeLengthDelimited(Stream stream, MissionInstance instance, bool isDelta) { }

	public static MissionInstance DeserializeLength(Stream stream, int length, MissionInstance instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, MissionInstance instance, MissionInstance previous) { }

	public static void Serialize(Stream stream, MissionInstance instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(MissionInstance instance) { }

	public static void SerializeLengthDelimited(Stream stream, MissionInstance instance) { }

	public void .ctor() { }

}

