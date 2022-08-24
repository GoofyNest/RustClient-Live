public class LinePoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6433
{
	public bool ShouldPool; 
	private bool _disposed; 
	public Vector3 localPosition; 
	public Vector3 worldNormal; 


public static void ResetToPool(LinePoint instance) { }

public void ResetToPool() { }

public virtual void Dispose() { }

public virtual void EnterPool() { }

public virtual void LeavePool() { }

public void CopyTo(LinePoint instance) { }

public LinePoint Copy() { }

public static LinePoint Deserialize(Stream stream) { }

public static LinePoint DeserializeLengthDelimited(Stream stream) { }

public static LinePoint DeserializeLength(Stream stream, int length) { }

public static LinePoint Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public virtual void WriteToStream(Stream stream) { }

public virtual void WriteToStreamDelta(Stream stream, LinePoint previous) { }

public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static LinePoint Deserialize(byte[] buffer, LinePoint instance, bool isDelta = False) { }

public static LinePoint Deserialize(Stream stream, LinePoint instance, bool isDelta) { }

public static LinePoint DeserializeLengthDelimited(Stream stream, LinePoint instance, bool isDelta) { }

public static LinePoint DeserializeLength(Stream stream, int length, LinePoint instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, LinePoint instance, LinePoint previous) { }

public static void Serialize(Stream stream, LinePoint instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(LinePoint instance) { }

public static void SerializeLengthDelimited(Stream stream, LinePoint instance) { }

public void .ctor() { }

}

