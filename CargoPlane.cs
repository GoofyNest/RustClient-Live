public class CargoPlane : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6428
{
	public bool ShouldPool; 
	private bool _disposed; 
	public Vector3 startPos; 
	public Vector3 endPos; 
	public float secondsToTake; 
	public float secondsTaken; 
	public bool dropped; 
	public Vector3 dropPosition; 


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
{
	public GameObjectRef prefabDrop; 
	public SpawnFilter filter; 


public void .ctor() { }

}

