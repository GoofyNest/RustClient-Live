public class Helicopter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6329
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 tiltRot; // 0x14
	public Vector3 leftGun; // 0x20
	public Vector3 rightGun; // 0x2C
	public Vector3 spotlightVec; // 0x38
	public List<float> weakspothealths; // 0x48

	// Methods

	// RVA: 0x1BF4F40 Offset: 0x1BF4340 VA: 0x181BF4F40
	public static void ResetToPool(Helicopter instance) { }

	// RVA: 0x1BF4E10 Offset: 0x1BF4210 VA: 0x181BF4E10
	public void ResetToPool() { }

	// RVA: 0x1BF49B0 Offset: 0x1BF3DB0 VA: 0x181BF49B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF32F0 Offset: 0x1BF26F0 VA: 0x181BF32F0
	public void CopyTo(Helicopter instance) { }

	// RVA: 0x1BF3440 Offset: 0x1BF2840 VA: 0x181BF3440
	public Helicopter Copy() { }

	// RVA: 0x1BF4100 Offset: 0x1BF3500 VA: 0x181BF4100
	public static Helicopter Deserialize(Stream stream) { }

	// RVA: 0x1BF3960 Offset: 0x1BF2D60 VA: 0x181BF3960
	public static Helicopter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1BF39E0 Offset: 0x1BF2DE0 VA: 0x181BF39E0
	public static Helicopter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1BF3DC0 Offset: 0x1BF31C0 VA: 0x181BF3DC0
	public static Helicopter Deserialize(byte[] buffer) { }

	// RVA: 0x1BF4B60 Offset: 0x1BF3F60 VA: 0x181BF4B60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1BF5DB0 Offset: 0x1BF51B0 VA: 0x181BF5DB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1BF5DD0 Offset: 0x1BF51D0 VA: 0x181BF5DD0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Helicopter previous) { }

	// RVA: 0x1BF4DF0 Offset: 0x1BF41F0 VA: 0x181BF4DF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1BF43B0 Offset: 0x1BF37B0 VA: 0x181BF43B0
	public static Helicopter Deserialize(byte[] buffer, Helicopter instance, bool isDelta = False) { }

	// RVA: 0x1BF4710 Offset: 0x1BF3B10 VA: 0x181BF4710
	public static Helicopter Deserialize(Stream stream, Helicopter instance, bool isDelta) { }

	// RVA: 0x1BF35F0 Offset: 0x1BF29F0 VA: 0x181BF35F0
	public static Helicopter DeserializeLengthDelimited(Stream stream, Helicopter instance, bool isDelta) { }

	// RVA: 0x1BF3A70 Offset: 0x1BF2E70 VA: 0x181BF3A70
	public static Helicopter DeserializeLength(Stream stream, int length, Helicopter instance, bool isDelta) { }

	// RVA: 0x1BF5070 Offset: 0x1BF4470 VA: 0x181BF5070
	public static void SerializeDelta(Stream stream, Helicopter instance, Helicopter previous) { }

	// RVA: 0x1BF5910 Offset: 0x1BF4D10 VA: 0x181BF5910
	public static void Serialize(Stream stream, Helicopter instance) { }

	// RVA: 0x1BF5DA0 Offset: 0x1BF51A0 VA: 0x181BF5DA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1BF5DB0 Offset: 0x1BF51B0 VA: 0x181BF5DB0
	public void ToProto(Stream stream) { }

	// RVA: 0x1BF5800 Offset: 0x1BF4C00 VA: 0x181BF5800
	public static byte[] SerializeToBytes(Helicopter instance) { }

	// RVA: 0x1BF5750 Offset: 0x1BF4B50 VA: 0x181BF5750
	public static void SerializeLengthDelimited(Stream stream, Helicopter instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

