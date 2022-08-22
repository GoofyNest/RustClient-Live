public class MissionInstance : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6453
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint providerID; // 0x14
	public uint missionID; // 0x18
	public uint missionStatus; // 0x1C
	public float completionScale; // 0x20
	public float startTime; // 0x24
	public float endTime; // 0x28
	public Vector3 missionLocation; // 0x2C
	public List<ObjectiveStatus> objectiveStatuses; // 0x38
	public List<MissionPoint> missionPoints; // 0x40
	public List<uint> createdEntities; // 0x48
	public List<MissionReward> rewards; // 0x50


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

