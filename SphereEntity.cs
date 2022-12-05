public class SphereEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6341
{
	public bool ShouldPool;
	private bool _disposed;
	public float radius;


	public static void ResetToPool(SphereEntity instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(SphereEntity instance) { }

	public SphereEntity Copy() { }

	public static SphereEntity Deserialize(Stream stream) { }

	public static SphereEntity DeserializeLengthDelimited(Stream stream) { }

	public static SphereEntity DeserializeLength(Stream stream, int length) { }

	public static SphereEntity Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, SphereEntity previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static SphereEntity Deserialize(byte[] buffer, SphereEntity instance, bool isDelta = False) { }

	public static SphereEntity Deserialize(Stream stream, SphereEntity instance, bool isDelta) { }

	public static SphereEntity DeserializeLengthDelimited(Stream stream, SphereEntity instance, bool isDelta) { }

	public static SphereEntity DeserializeLength(Stream stream, int length, SphereEntity instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, SphereEntity instance, SphereEntity previous) { }

	public static void Serialize(Stream stream, SphereEntity instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(SphereEntity instance) { }

	public static void SerializeLengthDelimited(Stream stream, SphereEntity instance) { }

	public void .ctor() { }

}

public class SphereEntity : BaseEntity // TypeDefIndex: 11351
{
	public float currentRadius;
	public float lerpRadius;
	public float lerpSpeed;


	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected void UpdateScale() { }

	protected void Update() { }

	public void .ctor() { }

}

