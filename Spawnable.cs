public class Spawnable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6336
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint population; // 0x14


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

public class Spawnable : MonoBehaviour, IServerComponent // TypeDefIndex: 9995
{	[ReadOnlyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public SpawnPopulation Population; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool ForceSpawnOnly; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string ForceSpawnInfoMessage; // 0x28


	protected void OnValidate() { }

	public void .ctor() { }

}

