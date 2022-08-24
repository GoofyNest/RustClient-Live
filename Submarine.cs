public class Submarine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6418
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float throttle; 
	public float upDown; 
	public float rudder; 
	public uint fuelStorageID; 
	public float fuelAmount; 
	public uint torpedoStorageID; 
	public float oxygen; 
	public uint itemStorageID; 


public static void ResetToPool(Submarine instance) { }

public void ResetToPool() { }

public virtual void Dispose() { }

public virtual void EnterPool() { }

public virtual void LeavePool() { }

public void CopyTo(Submarine instance) { }

public Submarine Copy() { }

public static Submarine Deserialize(Stream stream) { }

public static Submarine DeserializeLengthDelimited(Stream stream) { }

public static Submarine DeserializeLength(Stream stream, int length) { }

public static Submarine Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public virtual void WriteToStream(Stream stream) { }

public virtual void WriteToStreamDelta(Stream stream, Submarine previous) { }

public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static Submarine Deserialize(byte[] buffer, Submarine instance, bool isDelta = False) { }

public static Submarine Deserialize(Stream stream, Submarine instance, bool isDelta) { }

public static Submarine DeserializeLengthDelimited(Stream stream, Submarine instance, bool isDelta) { }

public static Submarine DeserializeLength(Stream stream, int length, Submarine instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, Submarine instance, Submarine previous) { }

public static void Serialize(Stream stream, Submarine instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(Submarine instance) { }

public static void SerializeLengthDelimited(Stream stream, Submarine instance) { }

public void .ctor() { }

}

