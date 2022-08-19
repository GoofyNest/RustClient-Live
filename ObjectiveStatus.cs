public class ObjectiveStatus : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6450
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool started; // 0x12
	public bool completed; // 0x13
	public bool failed; // 0x14
	public int genericInt1; // 0x18
	public float genericFloat1; // 0x1C

	// Methods

	// RVA: 0x1F89990 Offset: 0x1F88D90 VA: 0x181F89990
	public static void ResetToPool(ObjectiveStatus instance) { }

	// RVA: 0x1F898E0 Offset: 0x1F88CE0 VA: 0x181F898E0
	public void ResetToPool() { }

	// RVA: 0x1F89530 Offset: 0x1F88930 VA: 0x181F89530 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF46D0 Offset: 0x1EF3AD0 VA: 0x181EF46D0
	public void CopyTo(ObjectiveStatus instance) { }

	// RVA: 0x1F88220 Offset: 0x1F87620 VA: 0x181F88220
	public ObjectiveStatus Copy() { }

	// RVA: 0x1F892A0 Offset: 0x1F886A0 VA: 0x181F892A0
	public static ObjectiveStatus Deserialize(Stream stream) { }

	// RVA: 0x1F882A0 Offset: 0x1F876A0 VA: 0x181F882A0
	public static ObjectiveStatus DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F88640 Offset: 0x1F87A40 VA: 0x181F88640
	public static ObjectiveStatus DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F889D0 Offset: 0x1F87DD0 VA: 0x181F889D0
	public static ObjectiveStatus Deserialize(byte[] buffer) { }

	// RVA: 0x1F89670 Offset: 0x1F88A70 VA: 0x181F89670
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F89F80 Offset: 0x1F89380 VA: 0x181F89F80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F89FA0 Offset: 0x1F893A0 VA: 0x181F89FA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ObjectiveStatus previous) { }

	// RVA: 0x1F898C0 Offset: 0x1F88CC0 VA: 0x181F898C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F88D20 Offset: 0x1F88120 VA: 0x181F88D20
	public static ObjectiveStatus Deserialize(byte[] buffer, ObjectiveStatus instance, bool isDelta = False) { }

	// RVA: 0x1F89050 Offset: 0x1F88450 VA: 0x181F89050
	public static ObjectiveStatus Deserialize(Stream stream, ObjectiveStatus instance, bool isDelta) { }

	// RVA: 0x1F88320 Offset: 0x1F87720 VA: 0x181F88320
	public static ObjectiveStatus DeserializeLengthDelimited(Stream stream, ObjectiveStatus instance, bool isDelta) { }

	// RVA: 0x1F886D0 Offset: 0x1F87AD0 VA: 0x181F886D0
	public static ObjectiveStatus DeserializeLength(Stream stream, int length, ObjectiveStatus instance, bool isDelta) { }

	// RVA: 0x1F89A40 Offset: 0x1F88E40 VA: 0x181F89A40
	public static void SerializeDelta(Stream stream, ObjectiveStatus instance, ObjectiveStatus previous) { }

	// RVA: 0x1F89E00 Offset: 0x1F89200 VA: 0x181F89E00
	public static void Serialize(Stream stream, ObjectiveStatus instance) { }

	// RVA: 0x1F89F70 Offset: 0x1F89370 VA: 0x181F89F70
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F89F80 Offset: 0x1F89380 VA: 0x181F89F80
	public void ToProto(Stream stream) { }

	// RVA: 0x1F89CF0 Offset: 0x1F890F0 VA: 0x181F89CF0
	public static byte[] SerializeToBytes(ObjectiveStatus instance) { }

	// RVA: 0x1F89C40 Offset: 0x1F89040 VA: 0x181F89C40
	public static void SerializeLengthDelimited(Stream stream, ObjectiveStatus instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

