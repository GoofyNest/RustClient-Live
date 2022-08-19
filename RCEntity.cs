public class RCEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6375
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 aim; // 0x14
	public float zoom; // 0x20
	public string identifier; // 0x28
	public string password; // 0x30

	// Methods

	// RVA: 0x204A4C0 Offset: 0x20498C0 VA: 0x18204A4C0
	public static void ResetToPool(RCEntity instance) { }

	// RVA: 0x204A5B0 Offset: 0x20499B0 VA: 0x18204A5B0
	public void ResetToPool() { }

	// RVA: 0x204A110 Offset: 0x2049510 VA: 0x18204A110 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2048E70 Offset: 0x2048270 VA: 0x182048E70
	public void CopyTo(RCEntity instance) { }

	// RVA: 0x2048ED0 Offset: 0x20482D0 VA: 0x182048ED0
	public RCEntity Copy() { }

	// RVA: 0x2049B90 Offset: 0x2048F90 VA: 0x182049B90
	public static RCEntity Deserialize(Stream stream) { }

	// RVA: 0x2048F80 Offset: 0x2048380 VA: 0x182048F80
	public static RCEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20495D0 Offset: 0x20489D0 VA: 0x1820495D0
	public static RCEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2049E00 Offset: 0x2049200 VA: 0x182049E00
	public static RCEntity Deserialize(byte[] buffer) { }

	// RVA: 0x204A270 Offset: 0x2049670 VA: 0x18204A270
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x204AE50 Offset: 0x204A250 VA: 0x18204AE50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x204AE70 Offset: 0x204A270 VA: 0x18204AE70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, RCEntity previous) { }

	// RVA: 0x204A4A0 Offset: 0x20498A0 VA: 0x18204A4A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20498A0 Offset: 0x2048CA0 VA: 0x1820498A0
	public static RCEntity Deserialize(byte[] buffer, RCEntity instance, bool isDelta = False) { }

	// RVA: 0x2049660 Offset: 0x2048A60 VA: 0x182049660
	public static RCEntity Deserialize(Stream stream, RCEntity instance, bool isDelta) { }

	// RVA: 0x2049000 Offset: 0x2048400 VA: 0x182049000
	public static RCEntity DeserializeLengthDelimited(Stream stream, RCEntity instance, bool isDelta) { }

	// RVA: 0x2049300 Offset: 0x2048700 VA: 0x182049300
	public static RCEntity DeserializeLength(Stream stream, int length, RCEntity instance, bool isDelta) { }

	// RVA: 0x204A6A0 Offset: 0x2049AA0 VA: 0x18204A6A0
	public static void SerializeDelta(Stream stream, RCEntity instance, RCEntity previous) { }

	// RVA: 0x204ABE0 Offset: 0x2049FE0 VA: 0x18204ABE0
	public static void Serialize(Stream stream, RCEntity instance) { }

	// RVA: 0x204AE40 Offset: 0x204A240 VA: 0x18204AE40
	public byte[] ToProtoBytes() { }

	// RVA: 0x204AE50 Offset: 0x204A250 VA: 0x18204AE50
	public void ToProto(Stream stream) { }

	// RVA: 0x204AAD0 Offset: 0x2049ED0 VA: 0x18204AAD0
	public static byte[] SerializeToBytes(RCEntity instance) { }

	// RVA: 0x204AA20 Offset: 0x2049E20 VA: 0x18204AA20
	public static void SerializeLengthDelimited(Stream stream, RCEntity instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

