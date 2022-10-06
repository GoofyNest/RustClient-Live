public class ArcadeMachine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6368
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<ArcadeMachine.ScoreEntry> scores; 
	public int genericInt1; 
	public int genericInt2; 
	public int genericInt3; 
	public int genericInt4; 
	public float genericFloat1; 
	public float genericFloat2; 
	public float genericFloat3; 
	public float genericFloat4; 


	public static void ResetToPool(ArcadeMachine instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ArcadeMachine instance) { }

	public ArcadeMachine Copy() { }

	public static ArcadeMachine Deserialize(Stream stream) { }

	public static ArcadeMachine DeserializeLengthDelimited(Stream stream) { }

	public static ArcadeMachine DeserializeLength(Stream stream, int length) { }

	public static ArcadeMachine Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ArcadeMachine previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ArcadeMachine Deserialize(byte[] buffer, ArcadeMachine instance, bool isDelta = False) { }

	public static ArcadeMachine Deserialize(Stream stream, ArcadeMachine instance, bool isDelta) { }

	public static ArcadeMachine DeserializeLengthDelimited(Stream stream, ArcadeMachine instance, bool isDelta) { }

	public static ArcadeMachine DeserializeLength(Stream stream, int length, ArcadeMachine instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ArcadeMachine instance, ArcadeMachine previous) { }

	public static void Serialize(Stream stream, ArcadeMachine instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ArcadeMachine instance) { }

	public static void SerializeLengthDelimited(Stream stream, ArcadeMachine instance) { }

	public void .ctor() { }

}

public class ArcadeMachine.ScoreEntry : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6369
{
	public bool ShouldPool; 
	private bool _disposed; 
	public ulong playerID; 
	public string displayName; 
	public int score; 


	public static void ResetToPool(ArcadeMachine.ScoreEntry instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ArcadeMachine.ScoreEntry instance) { }

	public ArcadeMachine.ScoreEntry Copy() { }

	public static ArcadeMachine.ScoreEntry Deserialize(Stream stream) { }

	public static ArcadeMachine.ScoreEntry DeserializeLengthDelimited(Stream stream) { }

	public static ArcadeMachine.ScoreEntry DeserializeLength(Stream stream, int length) { }

	public static ArcadeMachine.ScoreEntry Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ArcadeMachine.ScoreEntry previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ArcadeMachine.ScoreEntry Deserialize(byte[] buffer, ArcadeMachine.ScoreEntry instance, bool isDelta = False) { }

	public static ArcadeMachine.ScoreEntry Deserialize(Stream stream, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	public static ArcadeMachine.ScoreEntry DeserializeLengthDelimited(Stream stream, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	public static ArcadeMachine.ScoreEntry DeserializeLength(Stream stream, int length, ArcadeMachine.ScoreEntry instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ArcadeMachine.ScoreEntry instance, ArcadeMachine.ScoreEntry previous) { }

	public static void Serialize(Stream stream, ArcadeMachine.ScoreEntry instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ArcadeMachine.ScoreEntry instance) { }

	public static void SerializeLengthDelimited(Stream stream, ArcadeMachine.ScoreEntry instance) { }

	public void .ctor() { }

}

