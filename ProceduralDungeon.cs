public class ProceduralDungeon : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6452
{
	public bool ShouldPool;
	private bool _disposed;
	public uint seed;
	public uint exitPortalID;
	public Vector3 mapOffset;


	public static void ResetToPool(ProceduralDungeon instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ProceduralDungeon instance) { }

	public ProceduralDungeon Copy() { }

	public static ProceduralDungeon Deserialize(Stream stream) { }

	public static ProceduralDungeon DeserializeLengthDelimited(Stream stream) { }

	public static ProceduralDungeon DeserializeLength(Stream stream, int length) { }

	public static ProceduralDungeon Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ProceduralDungeon previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ProceduralDungeon Deserialize(byte[] buffer, ProceduralDungeon instance, bool isDelta = False) { }

	public static ProceduralDungeon Deserialize(Stream stream, ProceduralDungeon instance, bool isDelta) { }

	public static ProceduralDungeon DeserializeLengthDelimited(Stream stream, ProceduralDungeon instance, bool isDelta) { }

	public static ProceduralDungeon DeserializeLength(Stream stream, int length, ProceduralDungeon instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ProceduralDungeon instance, ProceduralDungeon previous) { }

	public static void Serialize(Stream stream, ProceduralDungeon instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ProceduralDungeon instance) { }

	public static void SerializeLengthDelimited(Stream stream, ProceduralDungeon instance) { }

	public void .ctor() { }

}

