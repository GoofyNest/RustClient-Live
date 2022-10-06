public class WaterPool : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6386
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float fillAmount; 


	public static void ResetToPool(WaterPool instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(WaterPool instance) { }

	public WaterPool Copy() { }

	public static WaterPool Deserialize(Stream stream) { }

	public static WaterPool DeserializeLengthDelimited(Stream stream) { }

	public static WaterPool DeserializeLength(Stream stream, int length) { }

	public static WaterPool Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, WaterPool previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static WaterPool Deserialize(byte[] buffer, WaterPool instance, bool isDelta = False) { }

	public static WaterPool Deserialize(Stream stream, WaterPool instance, bool isDelta) { }

	public static WaterPool DeserializeLengthDelimited(Stream stream, WaterPool instance, bool isDelta) { }

	public static WaterPool DeserializeLength(Stream stream, int length, WaterPool instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, WaterPool instance, WaterPool previous) { }

	public static void Serialize(Stream stream, WaterPool instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(WaterPool instance) { }

	public static void SerializeLengthDelimited(Stream stream, WaterPool instance) { }

	public void .ctor() { }

}

