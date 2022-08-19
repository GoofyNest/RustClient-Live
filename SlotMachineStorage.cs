public class SlotMachineStorage : StorageContainer // TypeDefIndex: 8640
{	// Fields
	public int Amount; // 0x3D0

	// Methods

	// RVA: 0x5C58C0 Offset: 0x5C4CC0 VA: 0x1805C58C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x5C5810 Offset: 0x5C4C10 VA: 0x1805C5810
	public bool IsPlayerValid(BasePlayer player) { }

	// RVA: 0x5C5D50 Offset: 0x5C5150 VA: 0x1805C5D50 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5C5D10 Offset: 0x5C5110 VA: 0x1805C5D10
	private void RPC_UpdateAmount(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5C5EA0 Offset: 0x5C52A0 VA: 0x1805C5EA0
	public void .ctor() { }

}

