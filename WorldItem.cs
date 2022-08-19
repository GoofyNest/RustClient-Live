public class WorldItem : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6304
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Item item; // 0x18

	// Methods

	// RVA: 0x1E52790 Offset: 0x1E51B90 VA: 0x181E52790
	public static void ResetToPool(WorldItem instance) { }

	// RVA: 0x1E52830 Offset: 0x1E51C30 VA: 0x181E52830
	public void ResetToPool() { }

	// RVA: 0x1E52630 Offset: 0x1E51A30 VA: 0x181E52630 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E51B90 Offset: 0x1E50F90 VA: 0x181E51B90
	public void CopyTo(WorldItem instance) { }

	// RVA: 0x1E51C00 Offset: 0x1E51000 VA: 0x181E51C00
	public WorldItem Copy() { }

	// RVA: 0x1E52230 Offset: 0x1E51630 VA: 0x181E52230
	public static WorldItem Deserialize(Stream stream) { }

	// RVA: 0x1E51CD0 Offset: 0x1E510D0 VA: 0x181E51CD0
	public static WorldItem DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E51F90 Offset: 0x1E51390 VA: 0x181E51F90
	public static WorldItem DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E52510 Offset: 0x1E51910 VA: 0x181E52510
	public static WorldItem Deserialize(byte[] buffer) { }

	// RVA: 0x1E52750 Offset: 0x1E51B50 VA: 0x181E52750
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E52EB0 Offset: 0x1E522B0 VA: 0x181E52EB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E52ED0 Offset: 0x1E522D0 VA: 0x181E52ED0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, WorldItem previous) { }

	// RVA: 0x1E52770 Offset: 0x1E51B70 VA: 0x181E52770 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E52410 Offset: 0x1E51810 VA: 0x181E52410
	public static WorldItem Deserialize(byte[] buffer, WorldItem instance, bool isDelta = False) { }

	// RVA: 0x1E522B0 Offset: 0x1E516B0 VA: 0x181E522B0
	public static WorldItem Deserialize(Stream stream, WorldItem instance, bool isDelta) { }

	// RVA: 0x1E51D50 Offset: 0x1E51150 VA: 0x181E51D50
	public static WorldItem DeserializeLengthDelimited(Stream stream, WorldItem instance, bool isDelta) { }

	// RVA: 0x1E52020 Offset: 0x1E51420 VA: 0x181E52020
	public static WorldItem DeserializeLength(Stream stream, int length, WorldItem instance, bool isDelta) { }

	// RVA: 0x1E528D0 Offset: 0x1E51CD0 VA: 0x181E528D0
	public static void SerializeDelta(Stream stream, WorldItem instance, WorldItem previous) { }

	// RVA: 0x1E52CC0 Offset: 0x1E520C0 VA: 0x181E52CC0
	public static void Serialize(Stream stream, WorldItem instance) { }

	// RVA: 0x1E52EA0 Offset: 0x1E522A0 VA: 0x181E52EA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E52EB0 Offset: 0x1E522B0 VA: 0x181E52EB0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E52BB0 Offset: 0x1E51FB0 VA: 0x181E52BB0
	public static byte[] SerializeToBytes(WorldItem instance) { }

	// RVA: 0x1E52AC0 Offset: 0x1E51EC0 VA: 0x181E52AC0
	public static void SerializeLengthDelimited(Stream stream, WorldItem instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class WorldItem : BaseEntity // TypeDefIndex: 8667
{	// Fields
	[HeaderAttribute] // RVA: 0xB8E00 Offset: 0xB8200 VA: 0x1800B8E00
	public bool allowPickup; // 0x168
	public Item item; // 0x170

	// Properties
	public override BaseEntity.TraitFlag Traits { get; }

	// Methods

	// RVA: 0x8AA260 Offset: 0x8A9660 VA: 0x1808AA260 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8A9880 Offset: 0x8A8C80 VA: 0x1808A9880 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8AAE50 Offset: 0x8AA250 VA: 0x1808AAE50
	public void UpdateItem(BaseEntity.RPCMessage packet) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8AAB40 Offset: 0x8A9F40 VA: 0x1808AAB40
	public void PickupSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x8A9D60 Offset: 0x8A9160 VA: 0x1808A9D60 Slot: 131
	public virtual Vector3 IdealMenuPosition(BasePlayer playerUser) { }

	// RVA: 0x8A99F0 Offset: 0x8A8DF0 VA: 0x1808A99F0 Slot: 64
	public override Info GetMenuInformation(GameObject primaryObject, BasePlayer player) { }

	// RVA: 0x8A9BE0 Offset: 0x8A8FE0 VA: 0x1808A9BE0 Slot: 66
	public override List<Option> GetMenuItems(BasePlayer player) { }

	// RVA: 0x8A99C0 Offset: 0x8A8DC0 VA: 0x1808A99C0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x8A99E0 Offset: 0x8A8DE0 VA: 0x1808A99E0 Slot: 117
	public override Item GetItem() { }

	// RVA: 0x8A9F10 Offset: 0x8A9310 VA: 0x1808A9F10
	public void InitializeItem(Item in_item) { }

	// RVA: 0x8AAC40 Offset: 0x8AA040 VA: 0x1808AAC40
	public void RemoveItem() { }

	// RVA: 0x8A98F0 Offset: 0x8A8CF0 VA: 0x1808A98F0
	public void DestroyItem() { }

	// RVA: 0x8AA1B0 Offset: 0x8A95B0 VA: 0x1808AA1B0 Slot: 132
	protected virtual void OnItemDirty(Item in_item) { }

	// RVA: 0x8AA030 Offset: 0x8A9430 VA: 0x1808AA030 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x8AAF80 Offset: 0x8AA380 VA: 0x1808AAF80 Slot: 86
	public override BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x8AACF0 Offset: 0x8AA0F0 VA: 0x1808AACF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x8AAF20 Offset: 0x8AA320 VA: 0x1808AAF20
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8AAE10 Offset: 0x8AA210 VA: 0x1808AAE10
	private void <GetMenuItems>b__6_0(BasePlayer ply) { }

}

