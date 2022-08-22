public class VendingMachine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6339
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public VendingMachine.SellOrderContainer sellOrderContainer; // 0x18
	public string shopName; // 0x20
	public int vmoIndex; // 0x28
	public uint networkID; // 0x2C


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

public class VendingMachine.SellOrder : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6340
{	public bool ShouldPool; // 0x10
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

public class VendingMachine.SellOrderContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6341
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VendingMachine.SellOrder> sellOrders; // 0x18


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

public class VendingMachine : StorageContainer // TypeDefIndex: 8484
{	private Option __menuOption_Menu_BroadcastOff; // 0x3D0
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

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public virtual void InstallDefaultSellOrders() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_StartVendingSounds(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_CancelVendingSounds(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_ReceiveSellOrders(BaseEntity.RPCMessage msg) { }

	public virtual bool ShouldShowAdminPanel() { }

	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0x9A9F0 Offset: 0x99DF0 VA: 0x18009A9F0
	[BaseEntity.Menu.Description] // RVA: 0x9A9F0 Offset: 0x99DF0 VA: 0x18009A9F0
	[BaseEntity.Menu.Icon] // RVA: 0x9A9F0 Offset: 0x99DF0 VA: 0x18009A9F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9A9F0 Offset: 0x99DF0 VA: 0x18009A9F0
	public void Menu_Shop(BasePlayer player) { }

	public bool Menu_Shop_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9AC30 Offset: 0x9A030 VA: 0x18009AC30
	[BaseEntity.Menu.Description] // RVA: 0x9AC30 Offset: 0x9A030 VA: 0x18009AC30
	[BaseEntity.Menu.Icon] // RVA: 0x9AC30 Offset: 0x9A030 VA: 0x18009AC30
	[BaseEntity.Menu.ShowIf] // RVA: 0x9AC30 Offset: 0x9A030 VA: 0x18009AC30
	public void Menu_OpenAdmin(BasePlayer player) { }

	public bool Menu_OpenAdmin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9AED0 Offset: 0x9A2D0 VA: 0x18009AED0
	[BaseEntity.Menu.Description] // RVA: 0x9AED0 Offset: 0x9A2D0 VA: 0x18009AED0
	[BaseEntity.Menu.Icon] // RVA: 0x9AED0 Offset: 0x9A2D0 VA: 0x18009AED0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9AED0 Offset: 0x9A2D0 VA: 0x18009AED0
	public void Menu_BroadcastOn(BasePlayer player) { }

	public bool Menu_Broadcast_On_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9B210 Offset: 0x9A610 VA: 0x18009B210
	[BaseEntity.Menu.Description] // RVA: 0x9B210 Offset: 0x9A610 VA: 0x18009B210
	[BaseEntity.Menu.Icon] // RVA: 0x9B210 Offset: 0x9A610 VA: 0x18009B210
	[BaseEntity.Menu.ShowIf] // RVA: 0x9B210 Offset: 0x9A610 VA: 0x18009B210
	public void Menu_BroadcastOff(BasePlayer player) { }

	public bool Menu_Broadcast_Off_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9B440 Offset: 0x9A840 VA: 0x18009B440
	[BaseEntity.Menu.Description] // RVA: 0x9B440 Offset: 0x9A840 VA: 0x18009B440
	[BaseEntity.Menu.Icon] // RVA: 0x9B440 Offset: 0x9A840 VA: 0x18009B440
	[BaseEntity.Menu.ShowIf] // RVA: 0x9B440 Offset: 0x9A840 VA: 0x18009B440
	public void Menu_RotateVM(BasePlayer player) { }

	public virtual bool Menu_RotateVM_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

public static class VendingMachine.VendingMachineFlags // TypeDefIndex: 8485
{	public const BaseEntity.Flags EmptyInv = 128;
	public const BaseEntity.Flags IsVending = 256;
	public const BaseEntity.Flags Broadcasting = 1024;
	public const BaseEntity.Flags OutOfStock = 2048;
	public const BaseEntity.Flags NoDirectAccess = 16384;

}

