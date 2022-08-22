public class CreateBuilding : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6482
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint entity; // 0x14
	public uint socket; // 0x18
	public bool onterrain; // 0x1C
	public Vector3 position; // 0x20
	public Vector3 normal; // 0x2C
	public Ray ray; // 0x38
	public uint blockID; // 0x50
	public Vector3 rotation; // 0x54


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

