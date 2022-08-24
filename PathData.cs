public class PathData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6510
{
	public bool ShouldPool; 
	private bool _disposed; 
	public string name; 
	public bool spline; 
	public bool start; 
	public bool end; 
	public float width; 
	public float innerPadding; 
	public float outerPadding; 
	public float innerFade; 
	public float outerFade; 
	public float randomScale; 
	public float meshOffset; 
	public float terrainOffset; 
	public int splat; 
	public int topology; 
	public List<VectorData> nodes; 
	public int hierarchy; 


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

