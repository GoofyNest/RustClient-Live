public class PathData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6510
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public bool spline; // 0x20
	public bool start; // 0x21
	public bool end; // 0x22
	public float width; // 0x24
	public float innerPadding; // 0x28
	public float outerPadding; // 0x2C
	public float innerFade; // 0x30
	public float outerFade; // 0x34
	public float randomScale; // 0x38
	public float meshOffset; // 0x3C
	public float terrainOffset; // 0x40
	public int splat; // 0x44
	public int topology; // 0x48
	public List<VectorData> nodes; // 0x50
	public int hierarchy; // 0x58


	public static void ResetToPool(PathData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PathData instance) { }

	public PathData Copy() { }

	public static PathData Deserialize(Stream stream) { }

	public static PathData DeserializeLengthDelimited(Stream stream) { }

	public static PathData DeserializeLength(Stream stream, int length) { }

	public static PathData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PathData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PathData Deserialize(byte[] buffer, PathData instance, bool isDelta = False) { }

	public static PathData Deserialize(Stream stream, PathData instance, bool isDelta) { }

	public static PathData DeserializeLengthDelimited(Stream stream, PathData instance, bool isDelta) { }

	public static PathData DeserializeLength(Stream stream, int length, PathData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PathData instance, PathData previous) { }

	public static void Serialize(Stream stream, PathData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PathData instance) { }

	public static void SerializeLengthDelimited(Stream stream, PathData instance) { }

	public void .ctor() { }

}

