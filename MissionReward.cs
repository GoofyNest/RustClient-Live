public class MissionReward : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6452
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemID; // 0x14
	public int itemAmount; // 0x18

	// Methods

	// RVA: 0x1F4A9C0 Offset: 0x1F49DC0 VA: 0x181F4A9C0
	public static void ResetToPool(MissionReward instance) { }

	// RVA: 0x1F4A940 Offset: 0x1F49D40 VA: 0x181F4A940
	public void ResetToPool() { }

	// RVA: 0x1F4A720 Offset: 0x1F49B20 VA: 0x181F4A720 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DB9660 Offset: 0x1DB8A60 VA: 0x181DB9660
	public void CopyTo(MissionReward instance) { }

	// RVA: 0x1F49920 Offset: 0x1F48D20 VA: 0x181F49920
	public MissionReward Copy() { }

	// RVA: 0x1F49F20 Offset: 0x1F49320 VA: 0x181F49F20
	public static MissionReward Deserialize(Stream stream) { }

	// RVA: 0x1F49990 Offset: 0x1F48D90 VA: 0x181F49990
	public static MissionReward DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F49C60 Offset: 0x1F49060 VA: 0x181F49C60
	public static MissionReward DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F4A0E0 Offset: 0x1F494E0 VA: 0x181F4A0E0
	public static MissionReward Deserialize(byte[] buffer) { }

	// RVA: 0x1F4A7A0 Offset: 0x1F49BA0 VA: 0x181F4A7A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F4AE80 Offset: 0x1F4A280 VA: 0x181F4AE80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F4AEA0 Offset: 0x1F4A2A0 VA: 0x181F4AEA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MissionReward previous) { }

	// RVA: 0x1F4A920 Offset: 0x1F49D20 VA: 0x181F4A920 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F4A350 Offset: 0x1F49750 VA: 0x181F4A350
	public static MissionReward Deserialize(byte[] buffer, MissionReward instance, bool isDelta = False) { }

	// RVA: 0x1F4A5A0 Offset: 0x1F499A0 VA: 0x181F4A5A0
	public static MissionReward Deserialize(Stream stream, MissionReward instance, bool isDelta) { }

	// RVA: 0x1F49A10 Offset: 0x1F48E10 VA: 0x181F49A10
	public static MissionReward DeserializeLengthDelimited(Stream stream, MissionReward instance, bool isDelta) { }

	// RVA: 0x1F49CF0 Offset: 0x1F490F0 VA: 0x181F49CF0
	public static MissionReward DeserializeLength(Stream stream, int length, MissionReward instance, bool isDelta) { }

	// RVA: 0x1F4AA40 Offset: 0x1F49E40 VA: 0x181F4AA40
	public static void SerializeDelta(Stream stream, MissionReward instance, MissionReward previous) { }

	// RVA: 0x1F4AD70 Offset: 0x1F4A170 VA: 0x181F4AD70
	public static void Serialize(Stream stream, MissionReward instance) { }

	// RVA: 0x1F4AE70 Offset: 0x1F4A270 VA: 0x181F4AE70
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F4AE80 Offset: 0x1F4A280 VA: 0x181F4AE80
	public void ToProto(Stream stream) { }

	// RVA: 0x1F4AC60 Offset: 0x1F4A060 VA: 0x181F4AC60
	public static byte[] SerializeToBytes(MissionReward instance) { }

	// RVA: 0x1F4ABB0 Offset: 0x1F49FB0 VA: 0x181F4ABB0
	public static void SerializeLengthDelimited(Stream stream, MissionReward instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

