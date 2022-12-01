public class ResourceExtractor : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6332
{
	public bool ShouldPool;
	private bool _disposed;
	public ItemContainer fuelContents;
	public ItemContainer outputContents;


	public static void ResetToPool(ResourceExtractor instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ResourceExtractor instance) { }

	public ResourceExtractor Copy() { }

	public static ResourceExtractor Deserialize(Stream stream) { }

	public static ResourceExtractor DeserializeLengthDelimited(Stream stream) { }

	public static ResourceExtractor DeserializeLength(Stream stream, int length) { }

	public static ResourceExtractor Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ResourceExtractor previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ResourceExtractor Deserialize(byte[] buffer, ResourceExtractor instance, bool isDelta = False) { }

	public static ResourceExtractor Deserialize(Stream stream, ResourceExtractor instance, bool isDelta) { }

	public static ResourceExtractor DeserializeLengthDelimited(Stream stream, ResourceExtractor instance, bool isDelta) { }

	public static ResourceExtractor DeserializeLength(Stream stream, int length, ResourceExtractor instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ResourceExtractor instance, ResourceExtractor previous) { }

	public static void Serialize(Stream stream, ResourceExtractor instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ResourceExtractor instance) { }

	public static void SerializeLengthDelimited(Stream stream, ResourceExtractor instance) { }

	public void .ctor() { }

}

