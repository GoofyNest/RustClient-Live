public class MarketTerminal : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6400
{
	public bool ShouldPool; 
	private bool _disposed; 
	public ulong customerSteamId; 
	public uint marketplaceId; 
	public List<MarketTerminal.PendingOrder> orders; 
	public string customerName; 
	public TimeUntil timeUntilExpiry; 


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

public class MarketTerminal.PendingOrder : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6401
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint vendingMachineId; 
	public uint droneId; 
	public TimeUntil timeUntilExpiry; 


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

public class MarketTerminal : StorageContainer // TypeDefIndex: 10114
{
	private Option __menuOption_Menu_RequestOpenMarket; 
	private ulong _currentlyDisplayedUserId; 
	public const BaseEntity.Flags Flag_HasItems = 128;
	public const BaseEntity.Flags Flag_InventoryFull = 256;
	[HeaderAttribute] 
	public GameObjectRef menuPrefab; 
	public ulong lockToCustomerDuration; 
	public ulong orderTimeout; 
	public ItemDefinition deliveryFeeCurrency; 
	public int deliveryFeeAmount; 
	public DeliveryDroneConfig config; 
	public RustText userLabel; 
	private ulong _customerSteamId; 
	private string _customerName; 
	private TimeUntil _timeUntilCustomerExpiry; 
	private EntityRef<Marketplace> _marketplace; 
	public List<MarketTerminal.PendingOrder> pendingOrders; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] 
	public void Client_OpenMarket(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void Client_ShowItemNotice(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void Client_CloseMarketUI(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
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

private sealed class MarketTerminal.<>c // TypeDefIndex: 10115
{
	public static readonly MarketTerminal.<>c <>9; 
	public static Func<Item, int> <>9__27_0; 
	public static Func<MarketTerminal.PendingOrder, uint> <>9__28_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <CanPlayerAffordOrderAndDeliveryFee>b__27_0(Item i) { }

	internal uint <HasPendingOrderFor>b__28_0(MarketTerminal.PendingOrder o) { }

}

