public class BaseTrain : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6448
{
	public bool ShouldPool;
	private bool _disposed;
	public float time;
	public float frontBogieYRot;
	public float rearBogieYRot;
	public uint frontCouplingID;
	public bool frontCouplingToFront;
	public uint rearCouplingID;
	public bool rearCouplingToFront;
	public int lootTypeIndex;
	public float lootPercent;


	public static void ResetToPool(BaseTrain instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BaseTrain instance) { }

	public BaseTrain Copy() { }

	public static BaseTrain Deserialize(Stream stream) { }

	public static BaseTrain DeserializeLengthDelimited(Stream stream) { }

	public static BaseTrain DeserializeLength(Stream stream, int length) { }

	public static BaseTrain Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BaseTrain previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BaseTrain Deserialize(byte[] buffer, BaseTrain instance, bool isDelta = False) { }

	public static BaseTrain Deserialize(Stream stream, BaseTrain instance, bool isDelta) { }

	public static BaseTrain DeserializeLengthDelimited(Stream stream, BaseTrain instance, bool isDelta) { }

	public static BaseTrain DeserializeLength(Stream stream, int length, BaseTrain instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BaseTrain instance, BaseTrain previous) { }

	public static void Serialize(Stream stream, BaseTrain instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BaseTrain instance) { }

	public static void SerializeLengthDelimited(Stream stream, BaseTrain instance) { }

	public void .ctor() { }

}

