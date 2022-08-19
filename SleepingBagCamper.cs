public class SleepingBagCamper : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6419
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint seatID; // 0x14

	// Methods

	// RVA: 0x1DA79E0 Offset: 0x1DA6DE0 VA: 0x181DA79E0
	public static void ResetToPool(SleepingBagCamper instance) { }

	// RVA: 0x1DA7A60 Offset: 0x1DA6E60 VA: 0x181DA7A60
	public void ResetToPool() { }

	// RVA: 0x1DA78B0 Offset: 0x1DA6CB0 VA: 0x181DA78B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(SleepingBagCamper instance) { }

	// RVA: 0x1DA6F30 Offset: 0x1DA6330 VA: 0x181DA6F30
	public SleepingBagCamper Copy() { }

	// RVA: 0x1DA7830 Offset: 0x1DA6C30 VA: 0x181DA7830
	public static SleepingBagCamper Deserialize(Stream stream) { }

	// RVA: 0x1DA71C0 Offset: 0x1DA65C0 VA: 0x181DA71C0
	public static SleepingBagCamper DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DA7240 Offset: 0x1DA6640 VA: 0x181DA7240
	public static SleepingBagCamper DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DA7710 Offset: 0x1DA6B10 VA: 0x181DA7710
	public static SleepingBagCamper Deserialize(byte[] buffer) { }

	// RVA: 0x1DA79A0 Offset: 0x1DA6DA0 VA: 0x181DA79A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DA7F30 Offset: 0x1DA7330 VA: 0x181DA7F30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DA8000 Offset: 0x1DA7400 VA: 0x181DA8000 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, SleepingBagCamper previous) { }

	// RVA: 0x1DA79C0 Offset: 0x1DA6DC0 VA: 0x181DA79C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DA7610 Offset: 0x1DA6A10 VA: 0x181DA7610
	public static SleepingBagCamper Deserialize(byte[] buffer, SleepingBagCamper instance, bool isDelta = False) { }

	// RVA: 0x1DA74D0 Offset: 0x1DA68D0 VA: 0x181DA74D0
	public static SleepingBagCamper Deserialize(Stream stream, SleepingBagCamper instance, bool isDelta) { }

	// RVA: 0x1DA6FA0 Offset: 0x1DA63A0 VA: 0x181DA6FA0
	public static SleepingBagCamper DeserializeLengthDelimited(Stream stream, SleepingBagCamper instance, bool isDelta) { }

	// RVA: 0x1DA72D0 Offset: 0x1DA66D0 VA: 0x181DA72D0
	public static SleepingBagCamper DeserializeLength(Stream stream, int length, SleepingBagCamper instance, bool isDelta) { }

	// RVA: 0x1DA7AE0 Offset: 0x1DA6EE0 VA: 0x181DA7AE0
	public static void SerializeDelta(Stream stream, SleepingBagCamper instance, SleepingBagCamper previous) { }

	// RVA: 0x1DA7E50 Offset: 0x1DA7250 VA: 0x181DA7E50
	public static void Serialize(Stream stream, SleepingBagCamper instance) { }

	// RVA: 0x1DA7F20 Offset: 0x1DA7320 VA: 0x181DA7F20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DA7F30 Offset: 0x1DA7330 VA: 0x181DA7F30
	public void ToProto(Stream stream) { }

	// RVA: 0x1DA7CA0 Offset: 0x1DA70A0 VA: 0x181DA7CA0
	public static byte[] SerializeToBytes(SleepingBagCamper instance) { }

	// RVA: 0x1DA7BF0 Offset: 0x1DA6FF0 VA: 0x181DA7BF0
	public static void SerializeLengthDelimited(Stream stream, SleepingBagCamper instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class SleepingBagCamper : SleepingBag // TypeDefIndex: 8639
{	// Fields
	public EntityRef<BaseVehicleSeat> AssociatedSeat; // 0x450

	// Methods

	// RVA: 0x5C1480 Offset: 0x5C0880 VA: 0x1805C1480 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5C12D0 Offset: 0x5C06D0 VA: 0x1805C12D0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5C1410 Offset: 0x5C0810 VA: 0x1805C1410 Slot: 148
	public override bool Menu_MakeBed_ShowIf(BasePlayer player) { }

	// RVA: 0x5C13D0 Offset: 0x5C07D0 VA: 0x1805C13D0
	public void Menu_ClearBed(BasePlayer player) { }

	// RVA: 0x5C13C0 Offset: 0x5C07C0 VA: 0x1805C13C0
	public bool Menu_ClearBed_ShowIf(BasePlayer player) { }

	// RVA: 0x5C12A0 Offset: 0x5C06A0 VA: 0x1805C12A0 Slot: 145
	public override bool CanRename_Test(BasePlayer player) { }

	// RVA: 0x5C1570 Offset: 0x5C0970 VA: 0x1805C1570
	public void .ctor() { }

}

