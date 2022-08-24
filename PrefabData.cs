public class PrefabData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6509
{
	public bool ShouldPool; 
	private bool _disposed; 
	public string category; 
	public uint id; 
	public VectorData position; 
	public VectorData rotation; 
	public VectorData scale; 


	public static void ResetToPool(PrefabData instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(PrefabData instance) { }

	public PrefabData Copy() { }

	public static PrefabData Deserialize(Stream stream) { }

	public static PrefabData DeserializeLengthDelimited(Stream stream) { }

	public static PrefabData DeserializeLength(Stream stream, int length) { }

	public static PrefabData Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, PrefabData previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static PrefabData Deserialize(byte[] buffer, PrefabData instance, bool isDelta = False) { }

	public static PrefabData Deserialize(Stream stream, PrefabData instance, bool isDelta) { }

	public static PrefabData DeserializeLengthDelimited(Stream stream, PrefabData instance, bool isDelta) { }

	public static PrefabData DeserializeLength(Stream stream, int length, PrefabData instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, PrefabData instance, PrefabData previous) { }

	public static void Serialize(Stream stream, PrefabData instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(PrefabData instance) { }

	public static void SerializeLengthDelimited(Stream stream, PrefabData instance) { }

	public void .ctor() { }

}

