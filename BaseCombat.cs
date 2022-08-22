public class BaseCombat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6294
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int state; // 0x14
	public float health; // 0x18


	public static void ResetToPool(BaseCombat instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BaseCombat instance) { }

	public BaseCombat Copy() { }

	public static BaseCombat Deserialize(Stream stream) { }

	public static BaseCombat DeserializeLengthDelimited(Stream stream) { }

	public static BaseCombat DeserializeLength(Stream stream, int length) { }

	public static BaseCombat Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BaseCombat previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BaseCombat Deserialize(byte[] buffer, BaseCombat instance, bool isDelta = False) { }

	public static BaseCombat Deserialize(Stream stream, BaseCombat instance, bool isDelta) { }

	public static BaseCombat DeserializeLengthDelimited(Stream stream, BaseCombat instance, bool isDelta) { }

	public static BaseCombat DeserializeLength(Stream stream, int length, BaseCombat instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BaseCombat instance, BaseCombat previous) { }

	public static void Serialize(Stream stream, BaseCombat instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BaseCombat instance) { }

	public static void SerializeLengthDelimited(Stream stream, BaseCombat instance) { }

	public void .ctor() { }

}

