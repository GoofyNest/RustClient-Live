public class MarketTerminal : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6396
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong customerSteamId; // 0x18
	public uint marketplaceId; // 0x20
	public List<MarketTerminal.PendingOrder> orders; // 0x28
	public string customerName; // 0x30
	public TimeUntil timeUntilExpiry; // 0x38

	// Methods

	// RVA: 0x1F3DEC0 Offset: 0x1F3D2C0 VA: 0x181F3DEC0
	public static void ResetToPool(MarketTerminal instance) { }

	// RVA: 0x1F3E0E0 Offset: 0x1F3D4E0 VA: 0x181F3E0E0
	public void ResetToPool() { }

	// RVA: 0x1F3DE00 Offset: 0x1F3D200 VA: 0x181F3DE00 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F3C810 Offset: 0x1F3BC10 VA: 0x181F3C810
	public void CopyTo(MarketTerminal instance) { }

	// RVA: 0x1F3C9D0 Offset: 0x1F3BDD0 VA: 0x181F3C9D0
	public MarketTerminal Copy() { }

	// RVA: 0x1F3DAE0 Offset: 0x1F3CEE0 VA: 0x181F3DAE0
	public static MarketTerminal Deserialize(Stream stream) { }

	// RVA: 0x1F3CA50 Offset: 0x1F3BE50 VA: 0x181F3CA50
	public static MarketTerminal DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F3CEC0 Offset: 0x1F3C2C0 VA: 0x181F3CEC0
	public static MarketTerminal DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F3D410 Offset: 0x1F3C810 VA: 0x181F3D410
	public static MarketTerminal Deserialize(byte[] buffer) { }

	// RVA: 0x1F3DE80 Offset: 0x1F3D280 VA: 0x181F3DE80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F3EB40 Offset: 0x1F3DF40 VA: 0x181F3EB40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F3EB60 Offset: 0x1F3DF60 VA: 0x181F3EB60 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MarketTerminal previous) { }

	// RVA: 0x1F3DEA0 Offset: 0x1F3D2A0 VA: 0x181F3DEA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F3D310 Offset: 0x1F3C710 VA: 0x181F3D310
	public static MarketTerminal Deserialize(byte[] buffer, MarketTerminal instance, bool isDelta = False) { }

	// RVA: 0x1F3D7D0 Offset: 0x1F3CBD0 VA: 0x181F3D7D0
	public static MarketTerminal Deserialize(Stream stream, MarketTerminal instance, bool isDelta) { }

	// RVA: 0x1F3CAD0 Offset: 0x1F3BED0 VA: 0x181F3CAD0
	public static MarketTerminal DeserializeLengthDelimited(Stream stream, MarketTerminal instance, bool isDelta) { }

	// RVA: 0x1F3CF50 Offset: 0x1F3C350 VA: 0x181F3CF50
	public static MarketTerminal DeserializeLength(Stream stream, int length, MarketTerminal instance, bool isDelta) { }

	// RVA: 0x1F3E300 Offset: 0x1F3D700 VA: 0x181F3E300
	public static void SerializeDelta(Stream stream, MarketTerminal instance, MarketTerminal previous) { }

	// RVA: 0x1F3E840 Offset: 0x1F3DC40 VA: 0x181F3E840
	public static void Serialize(Stream stream, MarketTerminal instance) { }

	// RVA: 0x1F3EB30 Offset: 0x1F3DF30 VA: 0x181F3EB30
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F3EB40 Offset: 0x1F3DF40 VA: 0x181F3EB40
	public void ToProto(Stream stream) { }

	// RVA: 0x1F3E730 Offset: 0x1F3DB30 VA: 0x181F3E730
	public static byte[] SerializeToBytes(MarketTerminal instance) { }

	// RVA: 0x1F3E680 Offset: 0x1F3DA80 VA: 0x181F3E680
	public static void SerializeLengthDelimited(Stream stream, MarketTerminal instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class MarketTerminal.PendingOrder : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6397
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint vendingMachineId; // 0x14
	public uint droneId; // 0x18
	public TimeUntil timeUntilExpiry; // 0x1C

	// Methods

	// RVA: 0x1F52030 Offset: 0x1F51430 VA: 0x181F52030
	public static void ResetToPool(MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F520D0 Offset: 0x1F514D0 VA: 0x181F520D0
	public void ResetToPool() { }

	// RVA: 0x1F51DD0 Offset: 0x1F511D0 VA: 0x181F51DD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F50E10 Offset: 0x1F50210 VA: 0x181F50E10
	public void CopyTo(MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F50E40 Offset: 0x1F50240 VA: 0x181F50E40
	public MarketTerminal.PendingOrder Copy() { }

	// RVA: 0x1F51BD0 Offset: 0x1F50FD0 VA: 0x181F51BD0
	public static MarketTerminal.PendingOrder Deserialize(Stream stream) { }

	// RVA: 0x1F50EC0 Offset: 0x1F502C0 VA: 0x181F50EC0
	public static MarketTerminal.PendingOrder DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F51440 Offset: 0x1F50840 VA: 0x181F51440
	public static MarketTerminal.PendingOrder DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F51690 Offset: 0x1F50A90 VA: 0x181F51690
	public static MarketTerminal.PendingOrder Deserialize(byte[] buffer) { }

	// RVA: 0x1F51E50 Offset: 0x1F51250 VA: 0x181F51E50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F52660 Offset: 0x1F51A60 VA: 0x181F52660 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F52680 Offset: 0x1F51A80 VA: 0x181F52680 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MarketTerminal.PendingOrder previous) { }

	// RVA: 0x1F52010 Offset: 0x1F51410 VA: 0x181F52010 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F51940 Offset: 0x1F50D40 VA: 0x181F51940
	public static MarketTerminal.PendingOrder Deserialize(byte[] buffer, MarketTerminal.PendingOrder instance, bool isDelta = False) { }

	// RVA: 0x1F514D0 Offset: 0x1F508D0 VA: 0x181F514D0
	public static MarketTerminal.PendingOrder Deserialize(Stream stream, MarketTerminal.PendingOrder instance, bool isDelta) { }

	// RVA: 0x1F50F40 Offset: 0x1F50340 VA: 0x181F50F40
	public static MarketTerminal.PendingOrder DeserializeLengthDelimited(Stream stream, MarketTerminal.PendingOrder instance, bool isDelta) { }

	// RVA: 0x1F511D0 Offset: 0x1F505D0 VA: 0x181F511D0
	public static MarketTerminal.PendingOrder DeserializeLength(Stream stream, int length, MarketTerminal.PendingOrder instance, bool isDelta) { }

	// RVA: 0x1F52170 Offset: 0x1F51570 VA: 0x181F52170
	public static void SerializeDelta(Stream stream, MarketTerminal.PendingOrder instance, MarketTerminal.PendingOrder previous) { }

	// RVA: 0x1F52520 Offset: 0x1F51920 VA: 0x181F52520
	public static void Serialize(Stream stream, MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F52650 Offset: 0x1F51A50 VA: 0x181F52650
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F52660 Offset: 0x1F51A60 VA: 0x181F52660
	public void ToProto(Stream stream) { }

	// RVA: 0x1F52410 Offset: 0x1F51810 VA: 0x181F52410
	public static byte[] SerializeToBytes(MarketTerminal.PendingOrder instance) { }

	// RVA: 0x1F52360 Offset: 0x1F51760 VA: 0x181F52360
	public static void SerializeLengthDelimited(Stream stream, MarketTerminal.PendingOrder instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class MarketTerminal : StorageContainer // TypeDefIndex: 8409
{	// Fields
	private Option __menuOption_Menu_RequestOpenMarket; // 0x3D0
	private ulong _currentlyDisplayedUserId; // 0x428
	public const BaseEntity.Flags Flag_HasItems = 128;
	public const BaseEntity.Flags Flag_InventoryFull = 256;
	[HeaderAttribute] // RVA: 0xED250 Offset: 0xEC650 VA: 0x1800ED250
	public GameObjectRef menuPrefab; // 0x430
	public ulong lockToCustomerDuration; // 0x438
	public ulong orderTimeout; // 0x440
	public ItemDefinition deliveryFeeCurrency; // 0x448
	public int deliveryFeeAmount; // 0x450
	public DeliveryDroneConfig config; // 0x458
	public RustText userLabel; // 0x460
	private ulong _customerSteamId; // 0x468
	private string _customerName; // 0x470
	private TimeUntil _timeUntilCustomerExpiry; // 0x478
	private EntityRef<Marketplace> _marketplace; // 0x480
	public List<MarketTerminal.PendingOrder> pendingOrders; // 0x490

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x954280 Offset: 0x953680 VA: 0x180954280 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9559D0 Offset: 0x954DD0 VA: 0x1809559D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x954B70 Offset: 0x953F70 VA: 0x180954B70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x953F00 Offset: 0x953300 VA: 0x180953F00
	public void Client_OpenMarket(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x954120 Offset: 0x953520 VA: 0x180954120
	public void Client_ShowItemNotice(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x953CA0 Offset: 0x9530A0 VA: 0x180953CA0
	public void Client_CloseMarketUI(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0xED5E0 Offset: 0xEC9E0 VA: 0x1800ED5E0
	[BaseEntity.Menu.Description] // RVA: 0xED5E0 Offset: 0xEC9E0 VA: 0x1800ED5E0
	[BaseEntity.Menu.Icon] // RVA: 0xED5E0 Offset: 0xEC9E0 VA: 0x1800ED5E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xED5E0 Offset: 0xEC9E0 VA: 0x1800ED5E0
	// RVA: 0x954B30 Offset: 0x953F30 VA: 0x180954B30
	public void Menu_RequestOpenMarket(BasePlayer player) { }

	// RVA: 0x954B20 Offset: 0x953F20 VA: 0x180954B20
	public bool Menu_RequestOpenMarket_ShowIf(BasePlayer player) { }

	// RVA: 0x955880 Offset: 0x954C80 VA: 0x180955880 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x9556E0 Offset: 0x954AE0 VA: 0x1809556E0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x953A40 Offset: 0x952E40 VA: 0x180953A40
	public bool CanPlayerAffordOrderAndDeliveryFee(BasePlayer player, VendingMachine.SellOrder sellOrder, int numberOfTransactions) { }

	// RVA: 0x954590 Offset: 0x953990 VA: 0x180954590
	public bool HasPendingOrderFor(uint vendingMachineId) { }

	// RVA: 0x953BE0 Offset: 0x952FE0 VA: 0x180953BE0
	public bool CanPlayerInteract(BasePlayer player) { }

	// RVA: 0x9546C0 Offset: 0x953AC0 VA: 0x1809546C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x955960 Offset: 0x954D60 VA: 0x180955960
	public void .ctor() { }

}

private sealed class MarketTerminal.<>c // TypeDefIndex: 8410
{	// Fields
	public static readonly MarketTerminal.<>c <>9; // 0x0
	public static Func<Item, int> <>9__27_0; // 0x8
	public static Func<MarketTerminal.PendingOrder, uint> <>9__28_0; // 0x10

	// Methods

	// RVA: 0x96C390 Offset: 0x96B790 VA: 0x18096C390
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x588420 Offset: 0x587820 VA: 0x180588420
	internal int <CanPlayerAffordOrderAndDeliveryFee>b__27_0(Item i) { }

	// RVA: 0x96C250 Offset: 0x96B650 VA: 0x18096C250
	internal uint <HasPendingOrderFor>b__28_0(MarketTerminal.PendingOrder o) { }

}

