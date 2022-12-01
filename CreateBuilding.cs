public class CreateBuilding : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6494
{
	public bool ShouldPool;
	private bool _disposed;
	public uint entity;
	public uint socket;
	public bool onterrain;
	public Vector3 position;
	public Vector3 normal;
	public Ray ray;
	public uint blockID;
	public Vector3 rotation;


	public static void ResetToPool(CreateBuilding instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CreateBuilding instance) { }

	public CreateBuilding Copy() { }

	public static CreateBuilding Deserialize(Stream stream) { }

	public static CreateBuilding DeserializeLengthDelimited(Stream stream) { }

	public static CreateBuilding DeserializeLength(Stream stream, int length) { }

	public static CreateBuilding Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CreateBuilding previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CreateBuilding Deserialize(byte[] buffer, CreateBuilding instance, bool isDelta = False) { }

	public static CreateBuilding Deserialize(Stream stream, CreateBuilding instance, bool isDelta) { }

	public static CreateBuilding DeserializeLengthDelimited(Stream stream, CreateBuilding instance, bool isDelta) { }

	public static CreateBuilding DeserializeLength(Stream stream, int length, CreateBuilding instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CreateBuilding instance, CreateBuilding previous) { }

	public static void Serialize(Stream stream, CreateBuilding instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CreateBuilding instance) { }

	public static void SerializeLengthDelimited(Stream stream, CreateBuilding instance) { }

	public void .ctor() { }

}

