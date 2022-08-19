public class PuzzleReset : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6358
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool playerBlocksReset; // 0x12
	public float playerDetectionRadius; // 0x14
	public Vector3 playerDetectionOrigin; // 0x18
	public float timeBetweenResets; // 0x24
	public bool scaleWithServerPopulation; // 0x28

	// Methods

	// RVA: 0x2048570 Offset: 0x2047970 VA: 0x182048570
	public static void ResetToPool(PuzzleReset instance) { }

	// RVA: 0x2048620 Offset: 0x2047A20 VA: 0x182048620
	public void ResetToPool() { }

	// RVA: 0x20481C0 Offset: 0x20475C0 VA: 0x1820481C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2046E70 Offset: 0x2046270 VA: 0x182046E70
	public void CopyTo(PuzzleReset instance) { }

	// RVA: 0x2046EB0 Offset: 0x20462B0 VA: 0x182046EB0
	public PuzzleReset Copy() { }

	// RVA: 0x2047CD0 Offset: 0x20470D0 VA: 0x182047CD0
	public static PuzzleReset Deserialize(Stream stream) { }

	// RVA: 0x2046F40 Offset: 0x2046340 VA: 0x182046F40
	public static PuzzleReset DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20475F0 Offset: 0x20469F0 VA: 0x1820475F0
	public static PuzzleReset DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2047990 Offset: 0x2046D90 VA: 0x182047990
	public static PuzzleReset Deserialize(byte[] buffer) { }

	// RVA: 0x20482F0 Offset: 0x20476F0 VA: 0x1820482F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2048E30 Offset: 0x2048230 VA: 0x182048E30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2048E50 Offset: 0x2048250 VA: 0x182048E50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PuzzleReset previous) { }

	// RVA: 0x2048550 Offset: 0x2047950 VA: 0x182048550 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2047680 Offset: 0x2046A80 VA: 0x182047680
	public static PuzzleReset Deserialize(byte[] buffer, PuzzleReset instance, bool isDelta = False) { }

	// RVA: 0x2047F60 Offset: 0x2047360 VA: 0x182047F60
	public static PuzzleReset Deserialize(Stream stream, PuzzleReset instance, bool isDelta) { }

	// RVA: 0x2046FC0 Offset: 0x20463C0 VA: 0x182046FC0
	public static PuzzleReset DeserializeLengthDelimited(Stream stream, PuzzleReset instance, bool isDelta) { }

	// RVA: 0x20472F0 Offset: 0x20466F0 VA: 0x1820472F0
	public static PuzzleReset DeserializeLength(Stream stream, int length, PuzzleReset instance, bool isDelta) { }

	// RVA: 0x20486D0 Offset: 0x2047AD0 VA: 0x1820486D0
	public static void SerializeDelta(Stream stream, PuzzleReset instance, PuzzleReset previous) { }

	// RVA: 0x2048C10 Offset: 0x2048010 VA: 0x182048C10
	public static void Serialize(Stream stream, PuzzleReset instance) { }

	// RVA: 0x2048E20 Offset: 0x2048220 VA: 0x182048E20
	public byte[] ToProtoBytes() { }

	// RVA: 0x2048E30 Offset: 0x2048230 VA: 0x182048E30
	public void ToProto(Stream stream) { }

	// RVA: 0x2048B00 Offset: 0x2047F00 VA: 0x182048B00
	public static byte[] SerializeToBytes(PuzzleReset instance) { }

	// RVA: 0x2048A50 Offset: 0x2047E50 VA: 0x182048A50
	public static void SerializeLengthDelimited(Stream stream, PuzzleReset instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class PuzzleReset : FacepunchBehaviour // TypeDefIndex: 9810
{	// Fields
	public SpawnGroup[] respawnGroups; // 0x18
	public IOEntity[] resetEnts; // 0x20
	public GameObject[] resetObjects; // 0x28
	public bool playersBlockReset; // 0x30
	public bool CheckSleepingAIZForPlayers; // 0x31
	public float playerDetectionRadius; // 0x34
	public float playerHeightDetectionMinMax; // 0x38
	public Transform playerDetectionOrigin; // 0x40
	public float timeBetweenResets; // 0x48
	public bool scaleWithServerPopulation; // 0x4C
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector3[] resetPositions; // 0x50

	// Methods

	// RVA: 0x69A3A0 Offset: 0x6997A0 VA: 0x18069A3A0
	public void .ctor() { }

}

