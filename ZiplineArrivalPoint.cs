public class ZiplineArrivalPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6440
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<VectorData> linePoints; 


	public static void ResetToPool(ZiplineArrivalPoint instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ZiplineArrivalPoint instance) { }

	public ZiplineArrivalPoint Copy() { }

	public static ZiplineArrivalPoint Deserialize(Stream stream) { }

	public static ZiplineArrivalPoint DeserializeLengthDelimited(Stream stream) { }

	public static ZiplineArrivalPoint DeserializeLength(Stream stream, int length) { }

	public static ZiplineArrivalPoint Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ZiplineArrivalPoint previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ZiplineArrivalPoint Deserialize(byte[] buffer, ZiplineArrivalPoint instance, bool isDelta = False) { }

	public static ZiplineArrivalPoint Deserialize(Stream stream, ZiplineArrivalPoint instance, bool isDelta) { }

	public static ZiplineArrivalPoint DeserializeLengthDelimited(Stream stream, ZiplineArrivalPoint instance, bool isDelta) { }

	public static ZiplineArrivalPoint DeserializeLength(Stream stream, int length, ZiplineArrivalPoint instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ZiplineArrivalPoint instance, ZiplineArrivalPoint previous) { }

	public static void Serialize(Stream stream, ZiplineArrivalPoint instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ZiplineArrivalPoint instance) { }

	public static void SerializeLengthDelimited(Stream stream, ZiplineArrivalPoint instance) { }

	public void .ctor() { }

}

public class ZiplineArrivalPoint : BaseEntity // TypeDefIndex: 10377
{
	public LineRenderer Line; 
	private Vector3[] linePositions; 


	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override void ResetState() { }

	private void UpdateLineRenderer() { }

	public void .ctor() { }

}

