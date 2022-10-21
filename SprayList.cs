public class SprayList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6437
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<LinePoint> linePoints; 


	public static void ResetToPool(SprayList instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(SprayList instance) { }

	public SprayList Copy() { }

	public static SprayList Deserialize(Stream stream) { }

	public static SprayList DeserializeLengthDelimited(Stream stream) { }

	public static SprayList DeserializeLength(Stream stream, int length) { }

	public static SprayList Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, SprayList previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static SprayList Deserialize(byte[] buffer, SprayList instance, bool isDelta = False) { }

	public static SprayList Deserialize(Stream stream, SprayList instance, bool isDelta) { }

	public static SprayList DeserializeLengthDelimited(Stream stream, SprayList instance, bool isDelta) { }

	public static SprayList DeserializeLength(Stream stream, int length, SprayList instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, SprayList instance, SprayList previous) { }

	public static void Serialize(Stream stream, SprayList instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(SprayList instance) { }

	public static void SerializeLengthDelimited(Stream stream, SprayList instance) { }

	public void .ctor() { }

}

