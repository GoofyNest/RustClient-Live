public class RespawnInformation : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6497
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<RespawnInformation.SpawnOptions> spawnOptions; 
	public PlayerLifeStory previousLife; 
	public bool fadeIn; 


	public static void ResetToPool(RespawnInformation instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(RespawnInformation instance) { }

	public RespawnInformation Copy() { }

	public static RespawnInformation Deserialize(Stream stream) { }

	public static RespawnInformation DeserializeLengthDelimited(Stream stream) { }

	public static RespawnInformation DeserializeLength(Stream stream, int length) { }

	public static RespawnInformation Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, RespawnInformation previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static RespawnInformation Deserialize(byte[] buffer, RespawnInformation instance, bool isDelta = False) { }

	public static RespawnInformation Deserialize(Stream stream, RespawnInformation instance, bool isDelta) { }

	public static RespawnInformation DeserializeLengthDelimited(Stream stream, RespawnInformation instance, bool isDelta) { }

	public static RespawnInformation DeserializeLength(Stream stream, int length, RespawnInformation instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, RespawnInformation instance, RespawnInformation previous) { }

	public static void Serialize(Stream stream, RespawnInformation instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(RespawnInformation instance) { }

	public static void SerializeLengthDelimited(Stream stream, RespawnInformation instance) { }

	public void .ctor() { }

}

public class RespawnInformation.SpawnOptions : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6498
{
	public bool ShouldPool; 
	private bool _disposed; 
	public RespawnInformation.SpawnOptions.RespawnType type; 
	public uint id; 
	public string name; 
	public float unlockSeconds; 
	public Vector3 worldPosition; 
	public bool occupied; 


	public static void ResetToPool(RespawnInformation.SpawnOptions instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(RespawnInformation.SpawnOptions instance) { }

	public RespawnInformation.SpawnOptions Copy() { }

	public static RespawnInformation.SpawnOptions Deserialize(Stream stream) { }

	public static RespawnInformation.SpawnOptions DeserializeLengthDelimited(Stream stream) { }

	public static RespawnInformation.SpawnOptions DeserializeLength(Stream stream, int length) { }

	public static RespawnInformation.SpawnOptions Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, RespawnInformation.SpawnOptions previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static RespawnInformation.SpawnOptions Deserialize(byte[] buffer, RespawnInformation.SpawnOptions instance, bool isDelta = False) { }

	public static RespawnInformation.SpawnOptions Deserialize(Stream stream, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	public static RespawnInformation.SpawnOptions DeserializeLengthDelimited(Stream stream, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	public static RespawnInformation.SpawnOptions DeserializeLength(Stream stream, int length, RespawnInformation.SpawnOptions instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, RespawnInformation.SpawnOptions instance, RespawnInformation.SpawnOptions previous) { }

	public static void Serialize(Stream stream, RespawnInformation.SpawnOptions instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(RespawnInformation.SpawnOptions instance) { }

	public static void SerializeLengthDelimited(Stream stream, RespawnInformation.SpawnOptions instance) { }

	public void .ctor() { }

}

public enum RespawnInformation.SpawnOptions.RespawnType // TypeDefIndex: 6499
{
	public int value__; 
	public const RespawnInformation.SpawnOptions.RespawnType SleepingBag = 1;
	public const RespawnInformation.SpawnOptions.RespawnType Bed = 2;
	public const RespawnInformation.SpawnOptions.RespawnType BeachTowel = 3;
	public const RespawnInformation.SpawnOptions.RespawnType Camper = 4;

}

