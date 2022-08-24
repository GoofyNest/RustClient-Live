public class SprayLine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6431
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<LinePoint> linePoints; 
	public Vector3 colour; 
	public float width; 
	public uint editingPlayer; 


	public static void ResetToPool(SprayLine instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(SprayLine instance) { }

	public SprayLine Copy() { }

	public static SprayLine Deserialize(Stream stream) { }

	public static SprayLine DeserializeLengthDelimited(Stream stream) { }

	public static SprayLine DeserializeLength(Stream stream, int length) { }

	public static SprayLine Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, SprayLine previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static SprayLine Deserialize(byte[] buffer, SprayLine instance, bool isDelta = False) { }

	public static SprayLine Deserialize(Stream stream, SprayLine instance, bool isDelta) { }

	public static SprayLine DeserializeLengthDelimited(Stream stream, SprayLine instance, bool isDelta) { }

	public static SprayLine DeserializeLength(Stream stream, int length, SprayLine instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, SprayLine instance, SprayLine previous) { }

	public static void Serialize(Stream stream, SprayLine instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(SprayLine instance) { }

	public static void SerializeLengthDelimited(Stream stream, SprayLine instance) { }

	public void .ctor() { }

}

