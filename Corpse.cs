public class Corpse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6300
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint parentID; 


	public static void ResetToPool(Corpse instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Corpse instance) { }

	public Corpse Copy() { }

	public static Corpse Deserialize(Stream stream) { }

	public static Corpse DeserializeLengthDelimited(Stream stream) { }

	public static Corpse DeserializeLength(Stream stream, int length) { }

	public static Corpse Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Corpse previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Corpse Deserialize(byte[] buffer, Corpse instance, bool isDelta = False) { }

	public static Corpse Deserialize(Stream stream, Corpse instance, bool isDelta) { }

	public static Corpse DeserializeLengthDelimited(Stream stream, Corpse instance, bool isDelta) { }

	public static Corpse DeserializeLength(Stream stream, int length, Corpse instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Corpse instance, Corpse previous) { }

	public static void Serialize(Stream stream, Corpse instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Corpse instance) { }

	public static void SerializeLengthDelimited(Stream stream, Corpse instance) { }

	public void .ctor() { }

}

