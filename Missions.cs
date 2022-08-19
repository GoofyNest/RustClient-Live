public class Missions : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6449
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<MissionInstance> missions; // 0x18
	public int activeMission; // 0x20
	public int protocol; // 0x24
	public uint seed; // 0x28
	public int saveCreatedTime; // 0x2C

	// Methods

	// RVA: 0x1F4CC30 Offset: 0x1F4C030 VA: 0x181F4CC30
	public static void ResetToPool(Missions instance) { }

	// RVA: 0x1F4CE30 Offset: 0x1F4C230 VA: 0x181F4CE30
	public void ResetToPool() { }

	// RVA: 0x1F4C8A0 Offset: 0x1F4BCA0 VA: 0x181F4C8A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F4AEC0 Offset: 0x1F4A2C0 VA: 0x181F4AEC0
	public void CopyTo(Missions instance) { }

	// RVA: 0x1F4B070 Offset: 0x1F4A470 VA: 0x181F4B070
	public Missions Copy() { }

	// RVA: 0x1F4C590 Offset: 0x1F4B990 VA: 0x181F4C590
	public static Missions Deserialize(Stream stream) { }

	// RVA: 0x1F4B650 Offset: 0x1F4AA50 VA: 0x181F4B650
	public static Missions DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F4BA80 Offset: 0x1F4AE80 VA: 0x181F4BA80
	public static Missions DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4C1E0 Offset: 0x1F4B5E0 VA: 0x181F4C1E0
	public static Missions Deserialize(byte[] buffer) { }

	// RVA: 0x1F4C920 Offset: 0x1F4BD20 VA: 0x181F4C920
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F4D7F0 Offset: 0x1F4CBF0 VA: 0x181F4D7F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F4D810 Offset: 0x1F4CC10 VA: 0x181F4D810 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Missions previous) { }

	// RVA: 0x1F4CC10 Offset: 0x1F4C010 VA: 0x181F4CC10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F4BB10 Offset: 0x1F4AF10 VA: 0x181F4BB10
	public static Missions Deserialize(byte[] buffer, Missions instance, bool isDelta = False) { }

	// RVA: 0x1F4BEE0 Offset: 0x1F4B2E0 VA: 0x181F4BEE0
	public static Missions Deserialize(Stream stream, Missions instance, bool isDelta) { }

	// RVA: 0x1F4B270 Offset: 0x1F4A670 VA: 0x181F4B270
	public static Missions DeserializeLengthDelimited(Stream stream, Missions instance, bool isDelta) { }

	// RVA: 0x1F4B6D0 Offset: 0x1F4AAD0 VA: 0x181F4B6D0
	public static Missions DeserializeLength(Stream stream, int length, Missions instance, bool isDelta) { }

	// RVA: 0x1F4D030 Offset: 0x1F4C430 VA: 0x181F4D030
	public static void SerializeDelta(Stream stream, Missions instance, Missions previous) { }

	// RVA: 0x1F4D540 Offset: 0x1F4C940 VA: 0x181F4D540
	public static void Serialize(Stream stream, Missions instance) { }

	// RVA: 0x1F4D7E0 Offset: 0x1F4CBE0 VA: 0x181F4D7E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F4D7F0 Offset: 0x1F4CBF0 VA: 0x181F4D7F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F4D430 Offset: 0x1F4C830 VA: 0x181F4D430
	public static byte[] SerializeToBytes(Missions instance) { }

	// RVA: 0x1F4D380 Offset: 0x1F4C780 VA: 0x181F4D380
	public static void SerializeLengthDelimited(Stream stream, Missions instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

