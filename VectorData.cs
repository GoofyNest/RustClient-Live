public struct VectorData : IProto // TypeDefIndex: 6290
{	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8

	// Methods

	// RVA: 0xFAFF0 Offset: 0xFA3F0 VA: 0x1800FAFF0
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x1EF4510 Offset: 0x1EF3910 VA: 0x181EF4510
	public static VectorData op_Implicit(Vector3 v) { }

	// RVA: 0x1EF4590 Offset: 0x1EF3990 VA: 0x181EF4590
	public static VectorData op_Implicit(Quaternion q) { }

	// RVA: 0x1EF4540 Offset: 0x1EF3940 VA: 0x181EF4540
	public static Vector3 op_Implicit(VectorData v) { }

	// RVA: 0x1EF45F0 Offset: 0x1EF39F0 VA: 0x181EF45F0
	public static Quaternion op_Implicit(VectorData v) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void ResetToPool(VectorData instance) { }

	// RVA: 0xF1DA0 Offset: 0xF11A0 VA: 0x1800F1DA0
	public void CopyTo(VectorData instance) { }

	// RVA: 0xFAED0 Offset: 0xFA2D0 VA: 0x1800FAED0
	public VectorData Copy() { }

	// RVA: 0x1EF3E40 Offset: 0x1EF3240 VA: 0x181EF3E40
	public static VectorData Deserialize(Stream stream) { }

	// RVA: 0x1EF3940 Offset: 0x1EF2D40 VA: 0x181EF3940
	public static VectorData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF3970 Offset: 0x1EF2D70 VA: 0x181EF3970
	public static VectorData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF3D40 Offset: 0x1EF3140 VA: 0x181EF3D40
	public static VectorData Deserialize(byte[] buffer) { }

	// RVA: 0x231FA0 Offset: 0x2313A0 VA: 0x180231FA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x232030 Offset: 0x231430 VA: 0x180232030 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x232060 Offset: 0x231460 VA: 0x180232060
	public void WriteToStreamDelta(Stream stream, VectorData previous) { }

	// RVA: 0x231FD0 Offset: 0x2313D0 VA: 0x180231FD0 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EF3C10 Offset: 0x1EF3010 VA: 0x181EF3C10
	public static VectorData Deserialize(byte[] buffer, ref VectorData instance, bool isDelta = False) { }

	// RVA: 0x1EF3E70 Offset: 0x1EF3270 VA: 0x181EF3E70
	public static VectorData Deserialize(Stream stream, ref VectorData instance, bool isDelta) { }

	// RVA: 0x1EF36A0 Offset: 0x1EF2AA0 VA: 0x181EF36A0
	public static VectorData DeserializeLengthDelimited(Stream stream, ref VectorData instance, bool isDelta) { }

	// RVA: 0x1EF39A0 Offset: 0x1EF2DA0 VA: 0x181EF39A0
	public static VectorData DeserializeLength(Stream stream, int length, ref VectorData instance, bool isDelta) { }

	// RVA: 0x1EF4020 Offset: 0x1EF3420 VA: 0x181EF4020
	public static void SerializeDelta(Stream stream, VectorData instance, VectorData previous) { }

	// RVA: 0x1EF43F0 Offset: 0x1EF37F0 VA: 0x181EF43F0
	public static void Serialize(Stream stream, VectorData instance) { }

	// RVA: 0x232000 Offset: 0x231400 VA: 0x180232000
	public byte[] ToProtoBytes() { }

	// RVA: 0x232030 Offset: 0x231430 VA: 0x180232030
	public void ToProto(Stream stream) { }

	// RVA: 0x1EF42D0 Offset: 0x1EF36D0 VA: 0x181EF42D0
	public static byte[] SerializeToBytes(VectorData instance) { }

	// RVA: 0x1EF4210 Offset: 0x1EF3610 VA: 0x181EF4210
	public static void SerializeLengthDelimited(Stream stream, VectorData instance) { }

}

