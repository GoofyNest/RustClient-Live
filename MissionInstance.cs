public class MissionInstance : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6453
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x1F46F30 Offset: 0x1F46330 VA: 0x181F46F30
	public static void ResetToPool(MissionInstance instance) { }

	// RVA: 0x1F46F20 Offset: 0x1F46320 VA: 0x181F46F20
	public void ResetToPool() { }

	// RVA: 0x1F46E60 Offset: 0x1F46260 VA: 0x181F46E60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F45390 Offset: 0x1F44790 VA: 0x181F45390
	public void CopyTo(MissionInstance instance) { }

	// RVA: 0x1F45850 Offset: 0x1F44C50 VA: 0x181F45850
	public MissionInstance Copy() { }

	// RVA: 0x1F46650 Offset: 0x1F45A50 VA: 0x181F46650
	public static MissionInstance Deserialize(Stream stream) { }

	// RVA: 0x1F458D0 Offset: 0x1F44CD0 VA: 0x181F458D0
	public static MissionInstance DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F45FA0 Offset: 0x1F453A0 VA: 0x181F45FA0
	public static MissionInstance DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F467D0 Offset: 0x1F45BD0 VA: 0x181F467D0
	public static MissionInstance Deserialize(byte[] buffer) { }

	// RVA: 0x1F46EE0 Offset: 0x1F462E0 VA: 0x181F46EE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F484F0 Offset: 0x1F478F0 VA: 0x181F484F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F48510 Offset: 0x1F47910 VA: 0x181F48510 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MissionInstance previous) { }

	// RVA: 0x1F46F00 Offset: 0x1F46300 VA: 0x181F46F00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F466D0 Offset: 0x1F45AD0 VA: 0x181F466D0
	public static MissionInstance Deserialize(byte[] buffer, MissionInstance instance, bool isDelta = False) { }

	// RVA: 0x1F468F0 Offset: 0x1F45CF0 VA: 0x181F468F0
	public static MissionInstance Deserialize(Stream stream, MissionInstance instance, bool isDelta) { }

	// RVA: 0x1F45950 Offset: 0x1F44D50 VA: 0x181F45950
	public static MissionInstance DeserializeLengthDelimited(Stream stream, MissionInstance instance, bool isDelta) { }

	// RVA: 0x1F46030 Offset: 0x1F45430 VA: 0x181F46030
	public static MissionInstance DeserializeLength(Stream stream, int length, MissionInstance instance, bool isDelta) { }

	// RVA: 0x1F47420 Offset: 0x1F46820 VA: 0x181F47420
	public static void SerializeDelta(Stream stream, MissionInstance instance, MissionInstance previous) { }

	// RVA: 0x1F47E60 Offset: 0x1F47260 VA: 0x181F47E60
	public static void Serialize(Stream stream, MissionInstance instance) { }

	// RVA: 0x1F484E0 Offset: 0x1F478E0 VA: 0x181F484E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F484F0 Offset: 0x1F478F0 VA: 0x181F484F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F47D50 Offset: 0x1F47150 VA: 0x181F47D50
	public static byte[] SerializeToBytes(MissionInstance instance) { }

	// RVA: 0x1F47CA0 Offset: 0x1F470A0 VA: 0x181F47CA0
	public static void SerializeLengthDelimited(Stream stream, MissionInstance instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

