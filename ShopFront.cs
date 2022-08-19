public class ShopFront : StorageContainer // TypeDefIndex: 8637
{	// Fields
	public float maxUseAngle; // 0x3D0
	public BasePlayer vendorPlayer; // 0x3D8
	public BasePlayer customerPlayer; // 0x3E0
	public GameObjectRef transactionCompleteEffect; // 0x3E8

	// Properties
	private float AngleDotProduct { get; }

	// Methods

	// RVA: 0x5AF960 Offset: 0x5AED60 VA: 0x1805AF960 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5B03D0 Offset: 0x5AF7D0 VA: 0x1805B03D0
	private float get_AngleDotProduct() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	public bool TradeLocked() { }

	// RVA: 0x5AF440 Offset: 0x5AE840 VA: 0x1805AF440
	public bool IsTradingPlayer(BasePlayer player) { }

	// RVA: 0x5AF360 Offset: 0x5AE760 VA: 0x1805AF360
	public bool IsPlayerCustomer(BasePlayer player) { }

	// RVA: 0x5AF3D0 Offset: 0x5AE7D0 VA: 0x1805AF3D0
	public bool IsPlayerVendor(BasePlayer player) { }

	// RVA: 0x5B00D0 Offset: 0x5AF4D0 VA: 0x1805B00D0
	public bool PlayerInVendorPos(BasePlayer player) { }

	// RVA: 0x5AFF00 Offset: 0x5AF300 VA: 0x1805AFF00
	public bool PlayerInCustomerPos(BasePlayer player) { }

	// RVA: 0x5AF570 Offset: 0x5AE970 VA: 0x1805AF570
	public bool LootEligable(BasePlayer player) { }

	// RVA: 0x5AF2C0 Offset: 0x5AE6C0 VA: 0x1805AF2C0 Slot: 151
	public override int GetMoveToContainerIndex(BasePlayer player, Item item) { }

	// RVA: 0x5B02B0 Offset: 0x5AF6B0 VA: 0x1805B02B0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5AF120 Offset: 0x5AE520 VA: 0x1805AF120
	public void CLIENT_ReceivePlayers(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5B0370 Offset: 0x5AF770 VA: 0x1805B0370
	public void .ctor() { }

}

public static class ShopFront.ShopFrontFlags // TypeDefIndex: 8638
{	// Fields
	public const BaseEntity.Flags VendorAccepted = 128;
	public const BaseEntity.Flags CustomerAccepted = 256;
	public const BaseEntity.Flags Exchanging = 512;

}

