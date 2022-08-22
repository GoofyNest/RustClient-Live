public class ShopFront : StorageContainer // TypeDefIndex: 8637
{	public float maxUseAngle; // 0x3D0
	public BasePlayer vendorPlayer; // 0x3D8
	public BasePlayer customerPlayer; // 0x3E0
	public GameObjectRef transactionCompleteEffect; // 0x3E8

	private float AngleDotProduct { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	private float get_AngleDotProduct() { }

	public bool TradeLocked() { }

	public bool IsTradingPlayer(BasePlayer player) { }

	public bool IsPlayerCustomer(BasePlayer player) { }

	public bool IsPlayerVendor(BasePlayer player) { }

	public bool PlayerInVendorPos(BasePlayer player) { }

	public bool PlayerInCustomerPos(BasePlayer player) { }

	public bool LootEligable(BasePlayer player) { }

	public override int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	public override bool ShouldShowLootMenus() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_ReceivePlayers(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

}

public static class ShopFront.ShopFrontFlags // TypeDefIndex: 8638
{	public const BaseEntity.Flags VendorAccepted = 128;
	public const BaseEntity.Flags CustomerAccepted = 256;
	public const BaseEntity.Flags Exchanging = 512;

}

