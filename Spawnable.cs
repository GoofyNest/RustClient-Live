public class Spawnable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6345
{
	public bool ShouldPool;
	private bool _disposed;
	public uint population;


	public static void ResetToPool(Spawnable instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Spawnable instance) { }

	public Spawnable Copy() { }

	public static Spawnable Deserialize(Stream stream) { }

	public static Spawnable DeserializeLengthDelimited(Stream stream) { }

	public static Spawnable DeserializeLength(Stream stream, int length) { }

	public static Spawnable Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Spawnable previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Spawnable Deserialize(byte[] buffer, Spawnable instance, bool isDelta = False) { }

	public static Spawnable Deserialize(Stream stream, Spawnable instance, bool isDelta) { }

	public static Spawnable DeserializeLengthDelimited(Stream stream, Spawnable instance, bool isDelta) { }

	public static Spawnable DeserializeLength(Stream stream, int length, Spawnable instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Spawnable instance, Spawnable previous) { }

	public static void Serialize(Stream stream, Spawnable instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Spawnable instance) { }

	public static void SerializeLengthDelimited(Stream stream, Spawnable instance) { }

	public void .ctor() { }

}

public class Spawnable : MonoBehaviour, IServerComponent // TypeDefIndex: 11747
{
	[ReadOnlyAttribute]
	public SpawnPopulation Population;
	[SerializeField]
	private bool ForceSpawnOnly;
	[SerializeField]
	private string ForceSpawnInfoMessage;


	protected void OnValidate() { }

	public void .ctor() { }

}

