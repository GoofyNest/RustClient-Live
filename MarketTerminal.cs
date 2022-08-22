public class MarketTerminal : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6396
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong customerSteamId; // 0x18
	public uint marketplaceId; // 0x20
	public List<MarketTerminal.PendingOrder> orders; // 0x28
	public string customerName; // 0x30
	public TimeUntil timeUntilExpiry; // 0x38


	public static void ResetToPool(MarketTerminal instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(MarketTerminal instance) { }

	public MarketTerminal Copy() { }

	public static MarketTerminal Deserialize(Stream stream) { }

	public static MarketTerminal DeserializeLengthDelimited(Stream stream) { }

	public static MarketTerminal DeserializeLength(Stream stream, int length) { }

	public static MarketTerminal Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, MarketTerminal previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static MarketTerminal Deserialize(byte[] buffer, MarketTerminal instance, bool isDelta = False) { }

	public static MarketTerminal Deserialize(Stream stream, MarketTerminal instance, bool isDelta) { }

	public static MarketTerminal DeserializeLengthDelimited(Stream stream, MarketTerminal instance, bool isDelta) { }

	public static MarketTerminal DeserializeLength(Stream stream, int length, MarketTerminal instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, MarketTerminal instance, MarketTerminal previous) { }

	public static void Serialize(Stream stream, MarketTerminal instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(MarketTerminal instance) { }

	public static void SerializeLengthDelimited(Stream stream, MarketTerminal instance) { }

	public void .ctor() { }

}

public class MarketTerminal.PendingOrder : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6397
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint vendingMachineId; // 0x14
	public uint droneId; // 0x18
	public TimeUntil timeUntilExpiry; // 0x1C


	public static void ResetToPool(MarketTerminal.PendingOrder instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(MarketTerminal.PendingOrder instance) { }

	public MarketTerminal.PendingOrder Copy() { }

	public static MarketTerminal.PendingOrder Deserialize(Stream stream) { }

	public static MarketTerminal.PendingOrder DeserializeLengthDelimited(Stream stream) { }

	public static MarketTerminal.PendingOrder DeserializeLength(Stream stream, int length) { }

	public static MarketTerminal.PendingOrder Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, MarketTerminal.PendingOrder previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static MarketTerminal.PendingOrder Deserialize(byte[] buffer, MarketTerminal.PendingOrder instance, bool isDelta = False) { }

	public static MarketTerminal.PendingOrder Deserialize(Stream stream, MarketTerminal.PendingOrder instance, bool isDelta) { }

	public static MarketTerminal.PendingOrder DeserializeLengthDelimited(Stream stream, MarketTerminal.PendingOrder instance, bool isDelta) { }

	public static MarketTerminal.PendingOrder DeserializeLength(Stream stream, int length, MarketTerminal.PendingOrder instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, MarketTerminal.PendingOrder instance, MarketTerminal.PendingOrder previous) { }

	public static void Serialize(Stream stream, MarketTerminal.PendingOrder instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(MarketTerminal.PendingOrder instance) { }

	public static void SerializeLengthDelimited(Stream stream, MarketTerminal.PendingOrder instance) { }

	public void .ctor() { }

}

public class MarketTerminal : StorageContainer // TypeDefIndex: 8409
{	private Option __menuOption_Menu_RequestOpenMarket; // 0x3D0
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

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Client_OpenMarket(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Client_ShowItemNotice(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Client_CloseMarketUI(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0xED5E0 Offset: 0xEC9E0 VA: 0x1800ED5E0
	[BaseEntity.Menu.Description] // RVA: 0xED5E0 Offset: 0xEC9E0 VA: 0x1800ED5E0
	[BaseEntity.Menu.Icon] // RVA: 0xED5E0 Offset: 0xEC9E0 VA: 0x1800ED5E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xED5E0 Offset: 0xEC9E0 VA: 0x1800ED5E0
	public void Menu_RequestOpenMarket(BasePlayer player) { }

	public bool Menu_RequestOpenMarket_ShowIf(BasePlayer player) { }

	public override bool ShouldShowLootMenus() { }

	public override void PostNetworkUpdate() { }

	public bool CanPlayerAffordOrderAndDeliveryFee(BasePlayer player, VendingMachine.SellOrder sellOrder, int numberOfTransactions) { }

	public bool HasPendingOrderFor(uint vendingMachineId) { }

	public bool CanPlayerInteract(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

private sealed class MarketTerminal.<>c // TypeDefIndex: 8410
{	public static readonly MarketTerminal.<>c <>9; // 0x0
	public static Func<Item, int> <>9__27_0; // 0x8
	public static Func<MarketTerminal.PendingOrder, uint> <>9__28_0; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal int <CanPlayerAffordOrderAndDeliveryFee>b__27_0(Item i) { }

	internal uint <HasPendingOrderFor>b__28_0(MarketTerminal.PendingOrder o) { }

}

