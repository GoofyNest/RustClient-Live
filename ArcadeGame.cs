public class ArcadeGame : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6512
{
	public bool ShouldPool;
	private bool _disposed;
	public List<ArcadeGame.arcadeEnt> arcadeEnts;


	public static void ResetToPool(ArcadeGame instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ArcadeGame instance) { }

	public ArcadeGame Copy() { }

	public static ArcadeGame Deserialize(Stream stream) { }

	public static ArcadeGame DeserializeLengthDelimited(Stream stream) { }

	public static ArcadeGame DeserializeLength(Stream stream, int length) { }

	public static ArcadeGame Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ArcadeGame previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ArcadeGame Deserialize(byte[] buffer, ArcadeGame instance, bool isDelta = False) { }

	public static ArcadeGame Deserialize(Stream stream, ArcadeGame instance, bool isDelta) { }

	public static ArcadeGame DeserializeLengthDelimited(Stream stream, ArcadeGame instance, bool isDelta) { }

	public static ArcadeGame DeserializeLength(Stream stream, int length, ArcadeGame instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ArcadeGame instance, ArcadeGame previous) { }

	public static void Serialize(Stream stream, ArcadeGame instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ArcadeGame instance) { }

	public static void SerializeLengthDelimited(Stream stream, ArcadeGame instance) { }

	public void .ctor() { }

}

public class ArcadeGame.arcadeEnt : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6513
{
	public bool ShouldPool;
	private bool _disposed;
	public uint id;
	public string name;
	public uint spriteID;
	public uint soundID;
	public bool visible;
	public Vector3 position;
	public Vector3 heading;
	public bool enabled;
	public Vector3 scale;
	public Vector3 colliderScale;
	public float alpha;
	public uint prefabID;
	public uint parentID;


	public static void ResetToPool(ArcadeGame.arcadeEnt instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ArcadeGame.arcadeEnt instance) { }

	public ArcadeGame.arcadeEnt Copy() { }

	public static ArcadeGame.arcadeEnt Deserialize(Stream stream) { }

	public static ArcadeGame.arcadeEnt DeserializeLengthDelimited(Stream stream) { }

	public static ArcadeGame.arcadeEnt DeserializeLength(Stream stream, int length) { }

	public static ArcadeGame.arcadeEnt Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ArcadeGame.arcadeEnt previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ArcadeGame.arcadeEnt Deserialize(byte[] buffer, ArcadeGame.arcadeEnt instance, bool isDelta = False) { }

	public static ArcadeGame.arcadeEnt Deserialize(Stream stream, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	public static ArcadeGame.arcadeEnt DeserializeLengthDelimited(Stream stream, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	public static ArcadeGame.arcadeEnt DeserializeLength(Stream stream, int length, ArcadeGame.arcadeEnt instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ArcadeGame.arcadeEnt instance, ArcadeGame.arcadeEnt previous) { }

	public static void Serialize(Stream stream, ArcadeGame.arcadeEnt instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ArcadeGame.arcadeEnt instance) { }

	public static void SerializeLengthDelimited(Stream stream, ArcadeGame.arcadeEnt instance) { }

	public void .ctor() { }

}

