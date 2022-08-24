public class PaintableSign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6421
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<uint> crcs; 
	public List<ulong> editHistory; 


public static void ResetToPool(PaintableSign instance) { }

public void ResetToPool() { }

public virtual void Dispose() { }

public virtual void EnterPool() { }

public virtual void LeavePool() { }

public void CopyTo(PaintableSign instance) { }

public PaintableSign Copy() { }

public static PaintableSign Deserialize(Stream stream) { }

public static PaintableSign DeserializeLengthDelimited(Stream stream) { }

public static PaintableSign DeserializeLength(Stream stream, int length) { }

public static PaintableSign Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public virtual void WriteToStream(Stream stream) { }

public virtual void WriteToStreamDelta(Stream stream, PaintableSign previous) { }

public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static PaintableSign Deserialize(byte[] buffer, PaintableSign instance, bool isDelta = False) { }

public static PaintableSign Deserialize(Stream stream, PaintableSign instance, bool isDelta) { }

public static PaintableSign DeserializeLengthDelimited(Stream stream, PaintableSign instance, bool isDelta) { }

public static PaintableSign DeserializeLength(Stream stream, int length, PaintableSign instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, PaintableSign instance, PaintableSign previous) { }

public static void Serialize(Stream stream, PaintableSign instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(PaintableSign instance) { }

public static void SerializeLengthDelimited(Stream stream, PaintableSign instance) { }

public void .ctor() { }

}

