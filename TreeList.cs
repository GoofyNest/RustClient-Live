public class TreeList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6497
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<Tree> trees; 


	public static void ResetToPool(TreeList instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(TreeList instance) { }

	public TreeList Copy() { }

	public static TreeList Deserialize(Stream stream) { }

	public static TreeList DeserializeLengthDelimited(Stream stream) { }

	public static TreeList DeserializeLength(Stream stream, int length) { }

	public static TreeList Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, TreeList previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static TreeList Deserialize(byte[] buffer, TreeList instance, bool isDelta = False) { }

	public static TreeList Deserialize(Stream stream, TreeList instance, bool isDelta) { }

	public static TreeList DeserializeLengthDelimited(Stream stream, TreeList instance, bool isDelta) { }

	public static TreeList DeserializeLength(Stream stream, int length, TreeList instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, TreeList instance, TreeList previous) { }

	public static void Serialize(Stream stream, TreeList instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(TreeList instance) { }

	public static void SerializeLengthDelimited(Stream stream, TreeList instance) { }

	public void .ctor() { }

}

