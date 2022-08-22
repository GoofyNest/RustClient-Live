public class Spray : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6430
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong sprayedBy; // 0x18
	public long timestamp; // 0x20


	public static void ResetToPool(Spray instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Spray instance) { }

	public Spray Copy() { }

	public static Spray Deserialize(Stream stream) { }

	public static Spray DeserializeLengthDelimited(Stream stream) { }

	public static Spray DeserializeLength(Stream stream, int length) { }

	public static Spray Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Spray previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Spray Deserialize(byte[] buffer, Spray instance, bool isDelta = False) { }

	public static Spray Deserialize(Stream stream, Spray instance, bool isDelta) { }

	public static Spray DeserializeLengthDelimited(Stream stream, Spray instance, bool isDelta) { }

	public static Spray DeserializeLength(Stream stream, int length, Spray instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Spray instance, Spray previous) { }

	public static void Serialize(Stream stream, Spray instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Spray instance) { }

	public static void SerializeLengthDelimited(Stream stream, Spray instance) { }

	public void .ctor() { }

}

