public class InputMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6276
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int buttons; // 0x14
	public Vector3 aimAngles; // 0x18
	public Vector3 mouseDelta; // 0x24

	// Methods

	// RVA: 0x2017500 Offset: 0x2016900 VA: 0x182017500
	public static void ResetToPool(InputMessage instance) { }

	// RVA: 0x2017460 Offset: 0x2016860 VA: 0x182017460
	public void ResetToPool() { }

	// RVA: 0x2017200 Offset: 0x2016600 VA: 0x182017200 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2016260 Offset: 0x2015660 VA: 0x182016260
	public void CopyTo(InputMessage instance) { }

	// RVA: 0x20162A0 Offset: 0x20156A0 VA: 0x1820162A0
	public InputMessage Copy() { }

	// RVA: 0x2016930 Offset: 0x2015D30 VA: 0x182016930
	public static InputMessage Deserialize(Stream stream) { }

	// RVA: 0x20165C0 Offset: 0x20159C0 VA: 0x1820165C0
	public static InputMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2016640 Offset: 0x2015A40 VA: 0x182016640
	public static InputMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2016B30 Offset: 0x2015F30 VA: 0x182016B30
	public static InputMessage Deserialize(byte[] buffer) { }

	// RVA: 0x2017280 Offset: 0x2016680 VA: 0x182017280
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2017DD0 Offset: 0x20171D0 VA: 0x182017DD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2017DF0 Offset: 0x20171F0 VA: 0x182017DF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InputMessage previous) { }

	// RVA: 0x2017440 Offset: 0x2016840 VA: 0x182017440 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2016F80 Offset: 0x2016380 VA: 0x182016F80
	public static InputMessage Deserialize(byte[] buffer, InputMessage instance, bool isDelta = False) { }

	// RVA: 0x2016DC0 Offset: 0x20161C0 VA: 0x182016DC0
	public static InputMessage Deserialize(Stream stream, InputMessage instance, bool isDelta) { }

	// RVA: 0x2016330 Offset: 0x2015730 VA: 0x182016330
	public static InputMessage DeserializeLengthDelimited(Stream stream, InputMessage instance, bool isDelta) { }

	// RVA: 0x20166D0 Offset: 0x2015AD0 VA: 0x1820166D0
	public static InputMessage DeserializeLength(Stream stream, int length, InputMessage instance, bool isDelta) { }

	// RVA: 0x20175A0 Offset: 0x20169A0 VA: 0x1820175A0
	public static void SerializeDelta(Stream stream, InputMessage instance, InputMessage previous) { }

	// RVA: 0x2017B60 Offset: 0x2016F60 VA: 0x182017B60
	public static void Serialize(Stream stream, InputMessage instance) { }

	// RVA: 0x2017DC0 Offset: 0x20171C0 VA: 0x182017DC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2017DD0 Offset: 0x20171D0 VA: 0x182017DD0
	public void ToProto(Stream stream) { }

	// RVA: 0x2017A50 Offset: 0x2016E50 VA: 0x182017A50
	public static byte[] SerializeToBytes(InputMessage instance) { }

	// RVA: 0x20179A0 Offset: 0x2016DA0 VA: 0x1820179A0
	public static void SerializeLengthDelimited(Stream stream, InputMessage instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

