public class GenericSpawner : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6314
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<GenericSpawner.SpawnedEnt> ents; // 0x18


	public static void ResetToPool(GenericSpawner instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(GenericSpawner instance) { }

	public GenericSpawner Copy() { }

	public static GenericSpawner Deserialize(Stream stream) { }

	public static GenericSpawner DeserializeLengthDelimited(Stream stream) { }

	public static GenericSpawner DeserializeLength(Stream stream, int length) { }

	public static GenericSpawner Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, GenericSpawner previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static GenericSpawner Deserialize(byte[] buffer, GenericSpawner instance, bool isDelta = False) { }

	public static GenericSpawner Deserialize(Stream stream, GenericSpawner instance, bool isDelta) { }

	public static GenericSpawner DeserializeLengthDelimited(Stream stream, GenericSpawner instance, bool isDelta) { }

	public static GenericSpawner DeserializeLength(Stream stream, int length, GenericSpawner instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, GenericSpawner instance, GenericSpawner previous) { }

	public static void Serialize(Stream stream, GenericSpawner instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(GenericSpawner instance) { }

	public static void SerializeLengthDelimited(Stream stream, GenericSpawner instance) { }

	public void .ctor() { }

}

public class GenericSpawner.SpawnedEnt : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6315
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14
	public uint spawnPointIndex; // 0x18
	public bool mobile; // 0x1C


	public static void ResetToPool(GenericSpawner.SpawnedEnt instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(GenericSpawner.SpawnedEnt instance) { }

	public GenericSpawner.SpawnedEnt Copy() { }

	public static GenericSpawner.SpawnedEnt Deserialize(Stream stream) { }

	public static GenericSpawner.SpawnedEnt DeserializeLengthDelimited(Stream stream) { }

	public static GenericSpawner.SpawnedEnt DeserializeLength(Stream stream, int length) { }

	public static GenericSpawner.SpawnedEnt Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, GenericSpawner.SpawnedEnt previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static GenericSpawner.SpawnedEnt Deserialize(byte[] buffer, GenericSpawner.SpawnedEnt instance, bool isDelta = False) { }

	public static GenericSpawner.SpawnedEnt Deserialize(Stream stream, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	public static GenericSpawner.SpawnedEnt DeserializeLengthDelimited(Stream stream, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	public static GenericSpawner.SpawnedEnt DeserializeLength(Stream stream, int length, GenericSpawner.SpawnedEnt instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, GenericSpawner.SpawnedEnt instance, GenericSpawner.SpawnedEnt previous) { }

	public static void Serialize(Stream stream, GenericSpawner.SpawnedEnt instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(GenericSpawner.SpawnedEnt instance) { }

	public static void SerializeLengthDelimited(Stream stream, GenericSpawner.SpawnedEnt instance) { }

	public void .ctor() { }

}

