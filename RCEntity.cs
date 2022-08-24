public class RCEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6375
{
	public bool ShouldPool; 
	private bool _disposed; 
	public Vector3 aim; 
	public float zoom; 
	public string identifier; 
	public string password; 


public static void ResetToPool(RCEntity instance) { }

public void ResetToPool() { }

public virtual void Dispose() { }

public virtual void EnterPool() { }

public virtual void LeavePool() { }

public void CopyTo(RCEntity instance) { }

public RCEntity Copy() { }

public static RCEntity Deserialize(Stream stream) { }

public static RCEntity DeserializeLengthDelimited(Stream stream) { }

public static RCEntity DeserializeLength(Stream stream, int length) { }

public static RCEntity Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public virtual void WriteToStream(Stream stream) { }

public virtual void WriteToStreamDelta(Stream stream, RCEntity previous) { }

public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static RCEntity Deserialize(byte[] buffer, RCEntity instance, bool isDelta = False) { }

public static RCEntity Deserialize(Stream stream, RCEntity instance, bool isDelta) { }

public static RCEntity DeserializeLengthDelimited(Stream stream, RCEntity instance, bool isDelta) { }

public static RCEntity DeserializeLength(Stream stream, int length, RCEntity instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, RCEntity instance, RCEntity previous) { }

public static void Serialize(Stream stream, RCEntity instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(RCEntity instance) { }

public static void SerializeLengthDelimited(Stream stream, RCEntity instance) { }

public void .ctor() { }

}

