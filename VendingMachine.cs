public class VendingMachine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6346
{
	public bool ShouldPool; 
	private bool _disposed; 
	public VendingMachine.SellOrderContainer sellOrderContainer; 
	public string shopName; 
	public int vmoIndex; 
	public uint networkID; 


	public static void ResetToPool(VendingMachine instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(VendingMachine instance) { }

	public VendingMachine Copy() { }

	public static VendingMachine Deserialize(Stream stream) { }

	public static VendingMachine DeserializeLengthDelimited(Stream stream) { }

	public static VendingMachine DeserializeLength(Stream stream, int length) { }

	public static VendingMachine Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, VendingMachine previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static VendingMachine Deserialize(byte[] buffer, VendingMachine instance, bool isDelta = False) { }

	public static VendingMachine Deserialize(Stream stream, VendingMachine instance, bool isDelta) { }

	public static VendingMachine DeserializeLengthDelimited(Stream stream, VendingMachine instance, bool isDelta) { }

	public static VendingMachine DeserializeLength(Stream stream, int length, VendingMachine instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, VendingMachine instance, VendingMachine previous) { }

	public static void Serialize(Stream stream, VendingMachine instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(VendingMachine instance) { }

	public static void SerializeLengthDelimited(Stream stream, VendingMachine instance) { }

	public void .ctor() { }

}

public class VendingMachine.SellOrder : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6347
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int itemToSellID; 
	public int itemToSellAmount; 
	public int currencyID; 
	public int currencyAmountPerItem; 
	public int inStock; 
	public bool currencyIsBP; 
	public bool itemToSellIsBP; 
	public float itemCondition; 
	public float itemConditionMax; 
	public int instanceData; 


	public static void ResetToPool(VendingMachine.SellOrder instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(VendingMachine.SellOrder instance) { }

	public VendingMachine.SellOrder Copy() { }

	public static VendingMachine.SellOrder Deserialize(Stream stream) { }

	public static VendingMachine.SellOrder DeserializeLengthDelimited(Stream stream) { }

	public static VendingMachine.SellOrder DeserializeLength(Stream stream, int length) { }

	public static VendingMachine.SellOrder Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, VendingMachine.SellOrder previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static VendingMachine.SellOrder Deserialize(byte[] buffer, VendingMachine.SellOrder instance, bool isDelta = False) { }

	public static VendingMachine.SellOrder Deserialize(Stream stream, VendingMachine.SellOrder instance, bool isDelta) { }

	public static VendingMachine.SellOrder DeserializeLengthDelimited(Stream stream, VendingMachine.SellOrder instance, bool isDelta) { }

	public static VendingMachine.SellOrder DeserializeLength(Stream stream, int length, VendingMachine.SellOrder instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, VendingMachine.SellOrder instance, VendingMachine.SellOrder previous) { }

	public static void Serialize(Stream stream, VendingMachine.SellOrder instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(VendingMachine.SellOrder instance) { }

	public static void SerializeLengthDelimited(Stream stream, VendingMachine.SellOrder instance) { }

	public void .ctor() { }

}

public class VendingMachine.SellOrderContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6348
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<VendingMachine.SellOrder> sellOrders; 


	public static void ResetToPool(VendingMachine.SellOrderContainer instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(VendingMachine.SellOrderContainer instance) { }

	public VendingMachine.SellOrderContainer Copy() { }

	public static VendingMachine.SellOrderContainer Deserialize(Stream stream) { }

	public static VendingMachine.SellOrderContainer DeserializeLengthDelimited(Stream stream) { }

	public static VendingMachine.SellOrderContainer DeserializeLength(Stream stream, int length) { }

	public static VendingMachine.SellOrderContainer Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, VendingMachine.SellOrderContainer previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static VendingMachine.SellOrderContainer Deserialize(byte[] buffer, VendingMachine.SellOrderContainer instance, bool isDelta = False) { }

	public static VendingMachine.SellOrderContainer Deserialize(Stream stream, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	public static VendingMachine.SellOrderContainer DeserializeLengthDelimited(Stream stream, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	public static VendingMachine.SellOrderContainer DeserializeLength(Stream stream, int length, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, VendingMachine.SellOrderContainer instance, VendingMachine.SellOrderContainer previous) { }

	public static void Serialize(Stream stream, VendingMachine.SellOrderContainer instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(VendingMachine.SellOrderContainer instance) { }

	public static void SerializeLengthDelimited(Stream stream, VendingMachine.SellOrderContainer instance) { }

	public void .ctor() { }

}

public class VendingMachine : StorageContainer // TypeDefIndex: 10202
{
	private Option __menuOption_Menu_BroadcastOff; 
	private Option __menuOption_Menu_BroadcastOn; 
	private Option __menuOption_Menu_OpenAdmin; 
	private Option __menuOption_Menu_RotateVM; 
	private Option __menuOption_Menu_Shop; 
	[HeaderAttribute] 
	public static readonly Translate.Phrase WaitForVendingMessage; 
	public GameObjectRef adminMenuPrefab; 
	public string customerPanel; 
	public VendingMachine.SellOrderContainer sellOrders; 
	public SoundPlayer buySound; 
	public string shopName; 
	public GameObjectRef mapMarkerPrefab; 
	public ItemDefinition blueprintBaseDef; 
	private List<SoundManager.ScheduledSound> scheduledPhysSounds; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public virtual void InstallDefaultSellOrders() { }

	[BaseEntity.RPC_Client] 
	public void CLIENT_StartVendingSounds(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void CLIENT_CancelVendingSounds(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	public void CLIENT_ReceiveSellOrders(BaseEntity.RPCMessage msg) { }

	public virtual bool ShouldShowAdminPanel() { }

	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_Shop(BasePlayer player) { }

	public bool Menu_Shop_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_OpenAdmin(BasePlayer player) { }

	public bool Menu_OpenAdmin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_BroadcastOn(BasePlayer player) { }

	public bool Menu_Broadcast_On_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_BroadcastOff(BasePlayer player) { }

	public bool Menu_Broadcast_Off_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_RotateVM(BasePlayer player) { }

	public virtual bool Menu_RotateVM_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] 
	private void CLIENT_OpenAdminMenu(BaseEntity.RPCMessage rpc) { }

	public override void PostNetworkUpdate() { }

	protected virtual bool CanRotate() { }

	public bool IsBroadcasting() { }

	public bool IsInventoryEmpty() { }

	public bool IsVending() { }

	public bool PlayerBehind(BasePlayer player) { }

	public bool PlayerInfront(BasePlayer player) { }

	public virtual bool CanPlayerAdmin(BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public static class VendingMachine.VendingMachineFlags // TypeDefIndex: 10203
{
	public const BaseEntity.Flags EmptyInv = 128;
	public const BaseEntity.Flags IsVending = 256;
	public const BaseEntity.Flags Broadcasting = 1024;
	public const BaseEntity.Flags OutOfStock = 2048;
	public const BaseEntity.Flags NoDirectAccess = 16384;

}

