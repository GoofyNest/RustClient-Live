public class LightDeployer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6374
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint active; // 0x14

	// Methods

	// RVA: 0x1F1A7C0 Offset: 0x1F19BC0 VA: 0x181F1A7C0
	public static void ResetToPool(LightDeployer instance) { }

	// RVA: 0x1F1A740 Offset: 0x1F19B40 VA: 0x181F1A740
	public void ResetToPool() { }

	// RVA: 0x1F1A610 Offset: 0x1F19A10 VA: 0x181F1A610 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(LightDeployer instance) { }

	// RVA: 0x1F19C90 Offset: 0x1F19090 VA: 0x181F19C90
	public LightDeployer Copy() { }

	// RVA: 0x1F1A450 Offset: 0x1F19850 VA: 0x181F1A450
	public static LightDeployer Deserialize(Stream stream) { }

	// RVA: 0x1F19F20 Offset: 0x1F19320 VA: 0x181F19F20
	public static LightDeployer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1A1A0 Offset: 0x1F195A0 VA: 0x181F1A1A0
	public static LightDeployer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1A230 Offset: 0x1F19630 VA: 0x181F1A230
	public static LightDeployer Deserialize(byte[] buffer) { }

	// RVA: 0x1F1A700 Offset: 0x1F19B00 VA: 0x181F1A700
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1AC90 Offset: 0x1F1A090 VA: 0x181F1AC90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1AD60 Offset: 0x1F1A160 VA: 0x181F1AD60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LightDeployer previous) { }

	// RVA: 0x1F1A720 Offset: 0x1F19B20 VA: 0x181F1A720 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1A350 Offset: 0x1F19750 VA: 0x181F1A350
	public static LightDeployer Deserialize(byte[] buffer, LightDeployer instance, bool isDelta = False) { }

	// RVA: 0x1F1A4D0 Offset: 0x1F198D0 VA: 0x181F1A4D0
	public static LightDeployer Deserialize(Stream stream, LightDeployer instance, bool isDelta) { }

	// RVA: 0x1F19D00 Offset: 0x1F19100 VA: 0x181F19D00
	public static LightDeployer DeserializeLengthDelimited(Stream stream, LightDeployer instance, bool isDelta) { }

	// RVA: 0x1F19FA0 Offset: 0x1F193A0 VA: 0x181F19FA0
	public static LightDeployer DeserializeLength(Stream stream, int length, LightDeployer instance, bool isDelta) { }

	// RVA: 0x1F1A840 Offset: 0x1F19C40 VA: 0x181F1A840
	public static void SerializeDelta(Stream stream, LightDeployer instance, LightDeployer previous) { }

	// RVA: 0x1F1ABB0 Offset: 0x1F19FB0 VA: 0x181F1ABB0
	public static void Serialize(Stream stream, LightDeployer instance) { }

	// RVA: 0x1F1AC80 Offset: 0x1F1A080 VA: 0x181F1AC80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1AC90 Offset: 0x1F1A090 VA: 0x181F1AC90
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1AA00 Offset: 0x1F19E00 VA: 0x181F1AA00
	public static byte[] SerializeToBytes(LightDeployer instance) { }

	// RVA: 0x1F1A950 Offset: 0x1F19D50 VA: 0x181F1A950
	public static void SerializeLengthDelimited(Stream stream, LightDeployer instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

