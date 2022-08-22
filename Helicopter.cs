public class Helicopter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6329
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 tiltRot; // 0x14
	public Vector3 leftGun; // 0x20
	public Vector3 rightGun; // 0x2C
	public Vector3 spotlightVec; // 0x38
	public List<float> weakspothealths; // 0x48


	public static void ResetToPool(Helicopter instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Helicopter instance) { }

	public Helicopter Copy() { }

	public static Helicopter Deserialize(Stream stream) { }

	public static Helicopter DeserializeLengthDelimited(Stream stream) { }

	public static Helicopter DeserializeLength(Stream stream, int length) { }

	public static Helicopter Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Helicopter previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Helicopter Deserialize(byte[] buffer, Helicopter instance, bool isDelta = False) { }

	public static Helicopter Deserialize(Stream stream, Helicopter instance, bool isDelta) { }

	public static Helicopter DeserializeLengthDelimited(Stream stream, Helicopter instance, bool isDelta) { }

	public static Helicopter DeserializeLength(Stream stream, int length, Helicopter instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Helicopter instance, Helicopter previous) { }

	public static void Serialize(Stream stream, Helicopter instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Helicopter instance) { }

	public static void SerializeLengthDelimited(Stream stream, Helicopter instance) { }

	public void .ctor() { }

}

