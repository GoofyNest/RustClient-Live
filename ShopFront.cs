public class ShopFront : StorageContainer // TypeDefIndex: 8637
{
	public float maxUseAngle; 
	public BasePlayer vendorPlayer; 
	public BasePlayer customerPlayer; 
	public GameObjectRef transactionCompleteEffect; 

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

	[BaseEntity.RPC_Client] 
	public void CLIENT_ReceivePlayers(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

}

public static class ShopFront.ShopFrontFlags // TypeDefIndex: 8638
{
	public const BaseEntity.Flags VendorAccepted = 128;
	public const BaseEntity.Flags CustomerAccepted = 256;
	public const BaseEntity.Flags Exchanging = 512;

}

