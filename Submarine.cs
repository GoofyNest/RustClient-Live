public class Submarine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6418
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float throttle; // 0x14
	public float upDown; // 0x18
	public float rudder; // 0x1C
	public uint fuelStorageID; // 0x20
	public float fuelAmount; // 0x24
	public uint torpedoStorageID; // 0x28
	public float oxygen; // 0x2C
	public uint itemStorageID; // 0x30


	public static void ResetToPool(Submarine instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Submarine instance) { }

	public Submarine Copy() { }

	public static Submarine Deserialize(Stream stream) { }

	public static Submarine DeserializeLengthDelimited(Stream stream) { }

	public static Submarine DeserializeLength(Stream stream, int length) { }

	public static Submarine Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Submarine previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Submarine Deserialize(byte[] buffer, Submarine instance, bool isDelta = False) { }

	public static Submarine Deserialize(Stream stream, Submarine instance, bool isDelta) { }

	public static Submarine DeserializeLengthDelimited(Stream stream, Submarine instance, bool isDelta) { }

	public static Submarine DeserializeLength(Stream stream, int length, Submarine instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Submarine instance, Submarine previous) { }

	public static void Serialize(Stream stream, Submarine instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Submarine instance) { }

	public static void SerializeLengthDelimited(Stream stream, Submarine instance) { }

	public void .ctor() { }

}

