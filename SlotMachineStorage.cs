public class SlotMachineStorage : StorageContainer // TypeDefIndex: 10365
{
	public int Amount;


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsPlayerValid(BasePlayer player) { }

	public override bool ShouldShowLootMenus() { }

	[BaseEntity.RPC_Client]
	private void RPC_UpdateAmount(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

}

