public class CargoPlane : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6428
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 startPos; // 0x14
	public Vector3 endPos; // 0x20
	public float secondsToTake; // 0x2C
	public float secondsTaken; // 0x30
	public bool dropped; // 0x34
	public Vector3 dropPosition; // 0x38


	public static void ResetToPool(CargoPlane instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(CargoPlane instance) { }

	public CargoPlane Copy() { }

	public static CargoPlane Deserialize(Stream stream) { }

	public static CargoPlane DeserializeLengthDelimited(Stream stream) { }

	public static CargoPlane DeserializeLength(Stream stream, int length) { }

	public static CargoPlane Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, CargoPlane previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static CargoPlane Deserialize(byte[] buffer, CargoPlane instance, bool isDelta = False) { }

	public static CargoPlane Deserialize(Stream stream, CargoPlane instance, bool isDelta) { }

	public static CargoPlane DeserializeLengthDelimited(Stream stream, CargoPlane instance, bool isDelta) { }

	public static CargoPlane DeserializeLength(Stream stream, int length, CargoPlane instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, CargoPlane instance, CargoPlane previous) { }

	public static void Serialize(Stream stream, CargoPlane instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(CargoPlane instance) { }

	public static void SerializeLengthDelimited(Stream stream, CargoPlane instance) { }

	public void .ctor() { }

}

public class CargoPlane : BaseEntity // TypeDefIndex: 9815
{	public GameObjectRef prefabDrop; // 0x168
	public SpawnFilter filter; // 0x170


	public void .ctor() { }

}

