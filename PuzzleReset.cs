public class PuzzleReset : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6362
{
	public bool ShouldPool; 
	private bool _disposed; 
	public bool playerBlocksReset; 
	public float playerDetectionRadius; 
	public Vector3 playerDetectionOrigin; 
	public float timeBetweenResets; 
	public bool scaleWithServerPopulation; 


	public static void ResetToPool(PuzzleReset instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PuzzleReset instance) { }

	public PuzzleReset Copy() { }

	public static PuzzleReset Deserialize(Stream stream) { }

	public static PuzzleReset DeserializeLengthDelimited(Stream stream) { }

	public static PuzzleReset DeserializeLength(Stream stream, int length) { }

	public static PuzzleReset Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PuzzleReset previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PuzzleReset Deserialize(byte[] buffer, PuzzleReset instance, bool isDelta = False) { }

	public static PuzzleReset Deserialize(Stream stream, PuzzleReset instance, bool isDelta) { }

	public static PuzzleReset DeserializeLengthDelimited(Stream stream, PuzzleReset instance, bool isDelta) { }

	public static PuzzleReset DeserializeLength(Stream stream, int length, PuzzleReset instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PuzzleReset instance, PuzzleReset previous) { }

	public static void Serialize(Stream stream, PuzzleReset instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PuzzleReset instance) { }

	public static void SerializeLengthDelimited(Stream stream, PuzzleReset instance) { }

	public void .ctor() { }

}

public class PuzzleReset : FacepunchBehaviour // TypeDefIndex: 11521
{
	public SpawnGroup[] respawnGroups; 
	public IOEntity[] resetEnts; 
	public GameObject[] resetObjects; 
	public bool playersBlockReset; 
	public bool CheckSleepingAIZForPlayers; 
	public float playerDetectionRadius; 
	public float playerHeightDetectionMinMax; 
	public Transform playerDetectionOrigin; 
	public float timeBetweenResets; 
	public bool scaleWithServerPopulation; 
	[HideInInspector] 
	public Vector3[] resetPositions; 


	public void .ctor() { }

}

