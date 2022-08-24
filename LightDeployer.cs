public class LightDeployer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6374
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint active; 


	public static void ResetToPool(LightDeployer instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(LightDeployer instance) { }

	public LightDeployer Copy() { }

	public static LightDeployer Deserialize(Stream stream) { }

	public static LightDeployer DeserializeLengthDelimited(Stream stream) { }

	public static LightDeployer DeserializeLength(Stream stream, int length) { }

	public static LightDeployer Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, LightDeployer previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static LightDeployer Deserialize(byte[] buffer, LightDeployer instance, bool isDelta = False) { }

	public static LightDeployer Deserialize(Stream stream, LightDeployer instance, bool isDelta) { }

	public static LightDeployer DeserializeLengthDelimited(Stream stream, LightDeployer instance, bool isDelta) { }

	public static LightDeployer DeserializeLength(Stream stream, int length, LightDeployer instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, LightDeployer instance, LightDeployer previous) { }

	public static void Serialize(Stream stream, LightDeployer instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(LightDeployer instance) { }

	public static void SerializeLengthDelimited(Stream stream, LightDeployer instance) { }

	public void .ctor() { }

}

