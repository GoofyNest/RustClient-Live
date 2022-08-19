public class VendingMachine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6339
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public VendingMachine.SellOrderContainer sellOrderContainer; // 0x18
	public string shopName; // 0x20
	public int vmoIndex; // 0x28
	public uint networkID; // 0x2C

	// Methods

	// RVA: 0x1EFA970 Offset: 0x1EF9D70 VA: 0x181EFA970
	public static void ResetToPool(VendingMachine instance) { }

	// RVA: 0x1EFA870 Offset: 0x1EF9C70 VA: 0x181EFA870
	public void ResetToPool() { }

	// RVA: 0x1EFA4B0 Offset: 0x1EF98B0 VA: 0x181EFA4B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EF9190 Offset: 0x1EF8590 VA: 0x181EF9190
	public void CopyTo(VendingMachine instance) { }

	// RVA: 0x1EF9230 Offset: 0x1EF8630 VA: 0x181EF9230
	public VendingMachine Copy() { }

	// RVA: 0x1EF9D30 Offset: 0x1EF9130 VA: 0x181EF9D30
	public static VendingMachine Deserialize(Stream stream) { }

	// RVA: 0x1EF9620 Offset: 0x1EF8A20 VA: 0x181EF9620
	public static VendingMachine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EF9980 Offset: 0x1EF8D80 VA: 0x181EF9980
	public static VendingMachine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EF9A10 Offset: 0x1EF8E10 VA: 0x181EF9A10
	public static VendingMachine Deserialize(byte[] buffer) { }

	// RVA: 0x1EFA620 Offset: 0x1EF9A20 VA: 0x181EFA620
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EFB170 Offset: 0x1EFA570 VA: 0x181EFB170 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EFB190 Offset: 0x1EFA590 VA: 0x181EFB190 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VendingMachine previous) { }

	// RVA: 0x1EFA850 Offset: 0x1EF9C50 VA: 0x181EFA850 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EFA1C0 Offset: 0x1EF95C0 VA: 0x181EFA1C0
	public static VendingMachine Deserialize(byte[] buffer, VendingMachine instance, bool isDelta = False) { }

	// RVA: 0x1EF9F90 Offset: 0x1EF9390 VA: 0x181EF9F90
	public static VendingMachine Deserialize(Stream stream, VendingMachine instance, bool isDelta) { }

	// RVA: 0x1EF9310 Offset: 0x1EF8710 VA: 0x181EF9310
	public static VendingMachine DeserializeLengthDelimited(Stream stream, VendingMachine instance, bool isDelta) { }

	// RVA: 0x1EF96A0 Offset: 0x1EF8AA0 VA: 0x181EF96A0
	public static VendingMachine DeserializeLength(Stream stream, int length, VendingMachine instance, bool isDelta) { }

	// RVA: 0x1EFAA70 Offset: 0x1EF9E70 VA: 0x181EFAA70
	public static void SerializeDelta(Stream stream, VendingMachine instance, VendingMachine previous) { }

	// RVA: 0x1EFAF00 Offset: 0x1EFA300 VA: 0x181EFAF00
	public static void Serialize(Stream stream, VendingMachine instance) { }

	// RVA: 0x1EFB160 Offset: 0x1EFA560 VA: 0x181EFB160
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EFB170 Offset: 0x1EFA570 VA: 0x181EFB170
	public void ToProto(Stream stream) { }

	// RVA: 0x1EFADF0 Offset: 0x1EFA1F0 VA: 0x181EFADF0
	public static byte[] SerializeToBytes(VendingMachine instance) { }

	// RVA: 0x1EFAD40 Offset: 0x1EFA140 VA: 0x181EFAD40
	public static void SerializeLengthDelimited(Stream stream, VendingMachine instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class VendingMachine.SellOrder : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6340
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemToSellID; // 0x14
	public int itemToSellAmount; // 0x18
	public int currencyID; // 0x1C
	public int currencyAmountPerItem; // 0x20
	public int inStock; // 0x24
	public bool currencyIsBP; // 0x28
	public bool itemToSellIsBP; // 0x29
	public float itemCondition; // 0x2C
	public float itemConditionMax; // 0x30
	public int instanceData; // 0x34

	// Methods

	// RVA: 0x1EE5F80 Offset: 0x1EE5380 VA: 0x181EE5F80
	public static void ResetToPool(VendingMachine.SellOrder instance) { }

	// RVA: 0x1EE6080 Offset: 0x1EE5480 VA: 0x181EE6080
	public void ResetToPool() { }

	// RVA: 0x1EE5A30 Offset: 0x1EE4E30 VA: 0x181EE5A30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EE3E50 Offset: 0x1EE3250 VA: 0x181EE3E50
	public void CopyTo(VendingMachine.SellOrder instance) { }

	// RVA: 0x1EE3EB0 Offset: 0x1EE32B0 VA: 0x181EE3EB0
	public VendingMachine.SellOrder Copy() { }

	// RVA: 0x1EE4E10 Offset: 0x1EE4210 VA: 0x181EE4E10
	public static VendingMachine.SellOrder Deserialize(Stream stream) { }

	// RVA: 0x1EE43E0 Offset: 0x1EE37E0 VA: 0x181EE43E0
	public static VendingMachine.SellOrder DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EE4460 Offset: 0x1EE3860 VA: 0x181EE4460
	public static VendingMachine.SellOrder DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EE4950 Offset: 0x1EE3D50 VA: 0x181EE4950
	public static VendingMachine.SellOrder Deserialize(byte[] buffer) { }

	// RVA: 0x1EE5BC0 Offset: 0x1EE4FC0 VA: 0x181EE5BC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EE6950 Offset: 0x1EE5D50 VA: 0x181EE6950 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EE6970 Offset: 0x1EE5D70 VA: 0x181EE6970 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VendingMachine.SellOrder previous) { }

	// RVA: 0x1EE5F60 Offset: 0x1EE5360 VA: 0x181EE5F60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EE51F0 Offset: 0x1EE45F0 VA: 0x181EE51F0
	public static VendingMachine.SellOrder Deserialize(byte[] buffer, VendingMachine.SellOrder instance, bool isDelta = False) { }

	// RVA: 0x1EE5690 Offset: 0x1EE4A90 VA: 0x181EE5690
	public static VendingMachine.SellOrder Deserialize(Stream stream, VendingMachine.SellOrder instance, bool isDelta) { }

	// RVA: 0x1EE3F60 Offset: 0x1EE3360 VA: 0x181EE3F60
	public static VendingMachine.SellOrder DeserializeLengthDelimited(Stream stream, VendingMachine.SellOrder instance, bool isDelta) { }

	// RVA: 0x1EE44F0 Offset: 0x1EE38F0 VA: 0x181EE44F0
	public static VendingMachine.SellOrder DeserializeLength(Stream stream, int length, VendingMachine.SellOrder instance, bool isDelta) { }

	// RVA: 0x1EE6180 Offset: 0x1EE5580 VA: 0x181EE6180
	public static void SerializeDelta(Stream stream, VendingMachine.SellOrder instance, VendingMachine.SellOrder previous) { }

	// RVA: 0x1EE6720 Offset: 0x1EE5B20 VA: 0x181EE6720
	public static void Serialize(Stream stream, VendingMachine.SellOrder instance) { }

	// RVA: 0x1EE6940 Offset: 0x1EE5D40 VA: 0x181EE6940
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EE6950 Offset: 0x1EE5D50 VA: 0x181EE6950
	public void ToProto(Stream stream) { }

	// RVA: 0x1EE6610 Offset: 0x1EE5A10 VA: 0x181EE6610
	public static byte[] SerializeToBytes(VendingMachine.SellOrder instance) { }

	// RVA: 0x1EE6560 Offset: 0x1EE5960 VA: 0x181EE6560
	public static void SerializeLengthDelimited(Stream stream, VendingMachine.SellOrder instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class VendingMachine.SellOrderContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6341
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VendingMachine.SellOrder> sellOrders; // 0x18

	// Methods

	// RVA: 0x1E45A30 Offset: 0x1E44E30 VA: 0x181E45A30
	public static void ResetToPool(VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E45BE0 Offset: 0x1E44FE0 VA: 0x181E45BE0
	public void ResetToPool() { }

	// RVA: 0x1E457B0 Offset: 0x1E44BB0 VA: 0x181E457B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E44B10 Offset: 0x1E43F10 VA: 0x181E44B10
	public void CopyTo(VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E44C40 Offset: 0x1E44040 VA: 0x181E44C40
	public VendingMachine.SellOrderContainer Copy() { }

	// RVA: 0x1E45380 Offset: 0x1E44780 VA: 0x181E45380
	public static VendingMachine.SellOrderContainer Deserialize(Stream stream) { }

	// RVA: 0x1E44DB0 Offset: 0x1E441B0 VA: 0x181E44DB0
	public static VendingMachine.SellOrderContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E452F0 Offset: 0x1E446F0 VA: 0x181E452F0
	public static VendingMachine.SellOrderContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E45590 Offset: 0x1E44990 VA: 0x181E45590
	public static VendingMachine.SellOrderContainer Deserialize(byte[] buffer) { }

	// RVA: 0x1E459F0 Offset: 0x1E44DF0 VA: 0x181E459F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E46400 Offset: 0x1E45800 VA: 0x181E46400 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E46420 Offset: 0x1E45820 VA: 0x181E46420 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VendingMachine.SellOrderContainer previous) { }

	// RVA: 0x1E45A10 Offset: 0x1E44E10 VA: 0x181E45A10 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E456B0 Offset: 0x1E44AB0 VA: 0x181E456B0
	public static VendingMachine.SellOrderContainer Deserialize(byte[] buffer, VendingMachine.SellOrderContainer instance, bool isDelta = False) { }

	// RVA: 0x1E45400 Offset: 0x1E44800 VA: 0x181E45400
	public static VendingMachine.SellOrderContainer Deserialize(Stream stream, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	// RVA: 0x1E44E30 Offset: 0x1E44230 VA: 0x181E44E30
	public static VendingMachine.SellOrderContainer DeserializeLengthDelimited(Stream stream, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	// RVA: 0x1E450A0 Offset: 0x1E444A0 VA: 0x181E450A0
	public static VendingMachine.SellOrderContainer DeserializeLength(Stream stream, int length, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	// RVA: 0x1E45D90 Offset: 0x1E45190 VA: 0x181E45D90
	public static void SerializeDelta(Stream stream, VendingMachine.SellOrderContainer instance, VendingMachine.SellOrderContainer previous) { }

	// RVA: 0x1E461C0 Offset: 0x1E455C0 VA: 0x181E461C0
	public static void Serialize(Stream stream, VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E463F0 Offset: 0x1E457F0 VA: 0x181E463F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E46400 Offset: 0x1E45800 VA: 0x181E46400
	public void ToProto(Stream stream) { }

	// RVA: 0x1E460B0 Offset: 0x1E454B0 VA: 0x181E460B0
	public static byte[] SerializeToBytes(VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E45FC0 Offset: 0x1E453C0 VA: 0x181E45FC0
	public static void SerializeLengthDelimited(Stream stream, VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class VendingMachine : StorageContainer // TypeDefIndex: 8484
{	// Fields
	private Option __menuOption_Menu_BroadcastOff; // 0x3D0
	private Option __menuOption_Menu_BroadcastOn; // 0x428
	private Option __menuOption_Menu_OpenAdmin; // 0x480
	private Option __menuOption_Menu_RotateVM; // 0x4D8
	private Option __menuOption_Menu_Shop; // 0x530
	[HeaderAttribute] // RVA: 0x9A760 Offset: 0x99B60 VA: 0x18009A760
	public static readonly Translate.Phrase WaitForVendingMessage; // 0x0
	public GameObjectRef adminMenuPrefab; // 0x588
	public string customerPanel; // 0x590
	public VendingMachine.SellOrderContainer sellOrders; // 0x598
	public SoundPlayer buySound; // 0x5A0
	public string shopName; // 0x5A8
	public GameObjectRef mapMarkerPrefab; // 0x5B0
	public ItemDefinition blueprintBaseDef; // 0x5B8
	private List<SoundManager.ScheduledSound> scheduledPhysSounds; // 0x5C0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAD5430 Offset: 0xAD4830 VA: 0x180AD5430 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xAD7F80 Offset: 0xAD7380 VA: 0x180AD7F80 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xAD65F0 Offset: 0xAD59F0 VA: 0x180AD65F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xAD60B0 Offset: 0xAD54B0 VA: 0x180AD60B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAD6000 Offset: 0xAD5400 VA: 0x180AD6000 Slot: 155
	public virtual void InstallDefaultSellOrders() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAD50C0 Offset: 0xAD44C0 VA: 0x180AD50C0
	public void CLIENT_StartVendingSounds(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAD4D60 Offset: 0xAD4160 VA: 0x180AD4D60
	public void CLIENT_CancelVendingSounds(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAD4F70 Offset: 0xAD4370 VA: 0x180AD4F70
	public void CLIENT_ReceiveSellOrders(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 156
	public virtual bool ShouldShowAdminPanel() { }

	// RVA: 0xAD7CE0 Offset: 0xAD70E0 VA: 0x180AD7CE0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0x9A9F0 Offset: 0x99DF0 VA: 0x18009A9F0
	[BaseEntity.Menu.Description] // RVA: 0x9A9F0 Offset: 0x99DF0 VA: 0x18009A9F0
	[BaseEntity.Menu.Icon] // RVA: 0x9A9F0 Offset: 0x99DF0 VA: 0x18009A9F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9A9F0 Offset: 0x99DF0 VA: 0x18009A9F0
	// RVA: 0xAD65B0 Offset: 0xAD59B0 VA: 0x180AD65B0
	public void Menu_Shop(BasePlayer player) { }

	// RVA: 0xAD63B0 Offset: 0xAD57B0 VA: 0x180AD63B0
	public bool Menu_Shop_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9AC30 Offset: 0x9A030 VA: 0x18009AC30
	[BaseEntity.Menu.Description] // RVA: 0x9AC30 Offset: 0x9A030 VA: 0x18009AC30
	[BaseEntity.Menu.Icon] // RVA: 0x9AC30 Offset: 0x9A030 VA: 0x18009AC30
	[BaseEntity.Menu.ShowIf] // RVA: 0x9AC30 Offset: 0x9A030 VA: 0x18009AC30
	// RVA: 0xAD62D0 Offset: 0xAD56D0 VA: 0x180AD62D0
	public void Menu_OpenAdmin(BasePlayer player) { }

	// RVA: 0xAD6290 Offset: 0xAD5690 VA: 0x180AD6290
	public bool Menu_OpenAdmin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9AED0 Offset: 0x9A2D0 VA: 0x18009AED0
	[BaseEntity.Menu.Description] // RVA: 0x9AED0 Offset: 0x9A2D0 VA: 0x18009AED0
	[BaseEntity.Menu.Icon] // RVA: 0x9AED0 Offset: 0x9A2D0 VA: 0x18009AED0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9AED0 Offset: 0x9A2D0 VA: 0x18009AED0
	// RVA: 0xAD61A0 Offset: 0xAD55A0 VA: 0x180AD61A0
	public void Menu_BroadcastOn(BasePlayer player) { }

	// RVA: 0xAD6240 Offset: 0xAD5640 VA: 0x180AD6240
	public bool Menu_Broadcast_On_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9B210 Offset: 0x9A610 VA: 0x18009B210
	[BaseEntity.Menu.Description] // RVA: 0x9B210 Offset: 0x9A610 VA: 0x18009B210
	[BaseEntity.Menu.Icon] // RVA: 0x9B210 Offset: 0x9A610 VA: 0x18009B210
	[BaseEntity.Menu.ShowIf] // RVA: 0x9B210 Offset: 0x9A610 VA: 0x18009B210
	// RVA: 0xAD6150 Offset: 0xAD5550 VA: 0x180AD6150
	public void Menu_BroadcastOff(BasePlayer player) { }

	// RVA: 0xAD61F0 Offset: 0xAD55F0 VA: 0x180AD61F0
	public bool Menu_Broadcast_Off_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9B440 Offset: 0x9A840 VA: 0x18009B440
	[BaseEntity.Menu.Description] // RVA: 0x9B440 Offset: 0x9A840 VA: 0x18009B440
	[BaseEntity.Menu.Icon] // RVA: 0x9B440 Offset: 0x9A840 VA: 0x18009B440
	[BaseEntity.Menu.ShowIf] // RVA: 0x9B440 Offset: 0x9A840 VA: 0x18009B440
	// RVA: 0xAD6370 Offset: 0xAD5770 VA: 0x180AD6370
	public void Menu_RotateVM(BasePlayer player) { }

	// RVA: 0xAD6310 Offset: 0xAD5710 VA: 0x180AD6310 Slot: 157
	public virtual bool Menu_RotateVM_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAD4E70 Offset: 0xAD4270 VA: 0x180AD4E70
	private void CLIENT_OpenAdminMenu(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xAD7990 Offset: 0xAD6D90 VA: 0x180AD7990 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 158
	protected virtual bool CanRotate() { }

	// RVA: 0x7518E0 Offset: 0x750CE0 VA: 0x1807518E0
	public bool IsBroadcasting() { }

	// RVA: 0x4989F0 Offset: 0x497DF0 VA: 0x1804989F0
	public bool IsInventoryEmpty() { }

	// RVA: 0x593220 Offset: 0x592620 VA: 0x180593220
	public bool IsVending() { }

	// RVA: 0xAD7610 Offset: 0xAD6A10 VA: 0x180AD7610
	public bool PlayerBehind(BasePlayer player) { }

	// RVA: 0xAD77D0 Offset: 0xAD6BD0 VA: 0x180AD77D0
	public bool PlayerInfront(BasePlayer player) { }

	// RVA: 0xAD53F0 Offset: 0xAD47F0 VA: 0x180AD53F0 Slot: 159
	public virtual bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0xAD7EC0 Offset: 0xAD72C0 VA: 0x180AD7EC0
	public void .ctor() { }

	// RVA: 0xAD7E50 Offset: 0xAD7250 VA: 0x180AD7E50
	private static void .cctor() { }

}

public static class VendingMachine.VendingMachineFlags // TypeDefIndex: 8485
{	// Fields
	public const BaseEntity.Flags EmptyInv = 128;
	public const BaseEntity.Flags IsVending = 256;
	public const BaseEntity.Flags Broadcasting = 1024;
	public const BaseEntity.Flags OutOfStock = 2048;
	public const BaseEntity.Flags NoDirectAccess = 16384;

}

