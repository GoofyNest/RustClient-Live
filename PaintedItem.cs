public class PaintedItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6438
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint imageCrc; 
	public ulong editedBy; 


	public static void ResetToPool(PaintedItem instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PaintedItem instance) { }

	public PaintedItem Copy() { }

	public static PaintedItem Deserialize(Stream stream) { }

	public static PaintedItem DeserializeLengthDelimited(Stream stream) { }

	public static PaintedItem DeserializeLength(Stream stream, int length) { }

	public static PaintedItem Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PaintedItem previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PaintedItem Deserialize(byte[] buffer, PaintedItem instance, bool isDelta = False) { }

	public static PaintedItem Deserialize(Stream stream, PaintedItem instance, bool isDelta) { }

	public static PaintedItem DeserializeLengthDelimited(Stream stream, PaintedItem instance, bool isDelta) { }

	public static PaintedItem DeserializeLength(Stream stream, int length, PaintedItem instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PaintedItem instance, PaintedItem previous) { }

	public static void Serialize(Stream stream, PaintedItem instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PaintedItem instance) { }

	public static void SerializeLengthDelimited(Stream stream, PaintedItem instance) { }

	public void .ctor() { }

}

