public class RadioList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6510
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<string> stationUrls; 
	public List<string> stationNames; 


	public static void ResetToPool(RadioList instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(RadioList instance) { }

	public RadioList Copy() { }

	public static RadioList Deserialize(Stream stream) { }

	public static RadioList DeserializeLengthDelimited(Stream stream) { }

	public static RadioList DeserializeLength(Stream stream, int length) { }

	public static RadioList Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, RadioList previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static RadioList Deserialize(byte[] buffer, RadioList instance, bool isDelta = False) { }

	public static RadioList Deserialize(Stream stream, RadioList instance, bool isDelta) { }

	public static RadioList DeserializeLengthDelimited(Stream stream, RadioList instance, bool isDelta) { }

	public static RadioList DeserializeLength(Stream stream, int length, RadioList instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, RadioList instance, RadioList previous) { }

	public static void Serialize(Stream stream, RadioList instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(RadioList instance) { }

	public static void SerializeLengthDelimited(Stream stream, RadioList instance) { }

	public void .ctor() { }

}

