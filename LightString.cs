public class LightString : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6372
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<LightString.StringPoint> points; // 0x18
	public int lengthUsed; // 0x20
	public int animationStyle; // 0x24

	// Methods

	// RVA: 0x1F1C1D0 Offset: 0x1F1B5D0 VA: 0x181F1C1D0
	public static void ResetToPool(LightString instance) { }

	// RVA: 0x1F1BFE0 Offset: 0x1F1B3E0 VA: 0x181F1BFE0
	public void ResetToPool() { }

	// RVA: 0x1F1BF20 Offset: 0x1F1B320 VA: 0x181F1BF20 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F1AF10 Offset: 0x1F1A310 VA: 0x181F1AF10
	public void CopyTo(LightString instance) { }

	// RVA: 0x1F1B0C0 Offset: 0x1F1A4C0 VA: 0x181F1B0C0
	public LightString Copy() { }

	// RVA: 0x1F1BDA0 Offset: 0x1F1B1A0 VA: 0x181F1BDA0
	public static LightString Deserialize(Stream stream) { }

	// RVA: 0x1F1B2C0 Offset: 0x1F1A6C0 VA: 0x181F1B2C0
	public static LightString DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F1B680 Offset: 0x1F1AA80 VA: 0x181F1B680
	public static LightString DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F1BA20 Offset: 0x1F1AE20 VA: 0x181F1BA20
	public static LightString Deserialize(byte[] buffer) { }

	// RVA: 0x1F1BFA0 Offset: 0x1F1B3A0 VA: 0x181F1BFA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F1CA90 Offset: 0x1F1BE90 VA: 0x181F1CA90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F1CAB0 Offset: 0x1F1BEB0 VA: 0x181F1CAB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LightString previous) { }

	// RVA: 0x1F1BFC0 Offset: 0x1F1B3C0 VA: 0x181F1BFC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F1BE20 Offset: 0x1F1B220 VA: 0x181F1BE20
	public static LightString Deserialize(byte[] buffer, LightString instance, bool isDelta = False) { }

	// RVA: 0x1F1BB40 Offset: 0x1F1AF40 VA: 0x181F1BB40
	public static LightString Deserialize(Stream stream, LightString instance, bool isDelta) { }

	// RVA: 0x1F1B340 Offset: 0x1F1A740 VA: 0x181F1B340
	public static LightString DeserializeLengthDelimited(Stream stream, LightString instance, bool isDelta) { }

	// RVA: 0x1F1B710 Offset: 0x1F1AB10 VA: 0x181F1B710
	public static LightString DeserializeLength(Stream stream, int length, LightString instance, bool isDelta) { }

	// RVA: 0x1F1C3C0 Offset: 0x1F1B7C0 VA: 0x181F1C3C0
	public static void SerializeDelta(Stream stream, LightString instance, LightString previous) { }

	// RVA: 0x1F1C830 Offset: 0x1F1BC30 VA: 0x181F1C830
	public static void Serialize(Stream stream, LightString instance) { }

	// RVA: 0x1F1CA80 Offset: 0x1F1BE80 VA: 0x181F1CA80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F1CA90 Offset: 0x1F1BE90 VA: 0x181F1CA90
	public void ToProto(Stream stream) { }

	// RVA: 0x1F1C720 Offset: 0x1F1BB20 VA: 0x181F1C720
	public static byte[] SerializeToBytes(LightString instance) { }

	// RVA: 0x1F1C670 Offset: 0x1F1BA70 VA: 0x181F1C670
	public static void SerializeLengthDelimited(Stream stream, LightString instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class LightString.StringPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6373
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 point; // 0x14
	public Vector3 normal; // 0x20

	// Methods

	// RVA: 0x1F28950 Offset: 0x1F27D50 VA: 0x181F28950
	public static void ResetToPool(LightString.StringPoint instance) { }

	// RVA: 0x1F288C0 Offset: 0x1F27CC0 VA: 0x181F288C0
	public void ResetToPool() { }

	// RVA: 0x1F286A0 Offset: 0x1F27AA0 VA: 0x181F286A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F1CAD0 Offset: 0x1F1BED0 VA: 0x181F1CAD0
	public void CopyTo(LightString.StringPoint instance) { }

	// RVA: 0x1F278C0 Offset: 0x1F26CC0 VA: 0x181F278C0
	public LightString.StringPoint Copy() { }

	// RVA: 0x1F27ED0 Offset: 0x1F272D0 VA: 0x181F27ED0
	public static LightString.StringPoint Deserialize(Stream stream) { }

	// RVA: 0x1F27BA0 Offset: 0x1F26FA0 VA: 0x181F27BA0
	public static LightString.StringPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F27E40 Offset: 0x1F27240 VA: 0x181F27E40
	public static LightString.StringPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F282D0 Offset: 0x1F276D0 VA: 0x181F282D0
	public static LightString.StringPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F28720 Offset: 0x1F27B20 VA: 0x181F28720
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F29190 Offset: 0x1F28590 VA: 0x181F29190 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F291B0 Offset: 0x1F285B0 VA: 0x181F291B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LightString.StringPoint previous) { }

	// RVA: 0x1F288A0 Offset: 0x1F27CA0 VA: 0x181F288A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F28090 Offset: 0x1F27490 VA: 0x181F28090
	public static LightString.StringPoint Deserialize(byte[] buffer, LightString.StringPoint instance, bool isDelta = False) { }

	// RVA: 0x1F28520 Offset: 0x1F27920 VA: 0x181F28520
	public static LightString.StringPoint Deserialize(Stream stream, LightString.StringPoint instance, bool isDelta) { }

	// RVA: 0x1F27950 Offset: 0x1F26D50 VA: 0x181F27950
	public static LightString.StringPoint DeserializeLengthDelimited(Stream stream, LightString.StringPoint instance, bool isDelta) { }

	// RVA: 0x1F27C20 Offset: 0x1F27020 VA: 0x181F27C20
	public static LightString.StringPoint DeserializeLength(Stream stream, int length, LightString.StringPoint instance, bool isDelta) { }

	// RVA: 0x1F289E0 Offset: 0x1F27DE0 VA: 0x181F289E0
	public static void SerializeDelta(Stream stream, LightString.StringPoint instance, LightString.StringPoint previous) { }

	// RVA: 0x1F28F40 Offset: 0x1F28340 VA: 0x181F28F40
	public static void Serialize(Stream stream, LightString.StringPoint instance) { }

	// RVA: 0x1F29180 Offset: 0x1F28580 VA: 0x181F29180
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F29190 Offset: 0x1F28590 VA: 0x181F29190
	public void ToProto(Stream stream) { }

	// RVA: 0x1F28E30 Offset: 0x1F28230 VA: 0x181F28E30
	public static byte[] SerializeToBytes(LightString.StringPoint instance) { }

	// RVA: 0x1F28D80 Offset: 0x1F28180 VA: 0x181F28D80
	public static void SerializeLengthDelimited(Stream stream, LightString.StringPoint instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

