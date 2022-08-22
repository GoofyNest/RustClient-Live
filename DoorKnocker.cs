public class DoorKnocker : BaseCombatEntity // TypeDefIndex: 8566
{	public Animator knocker1; // 0x240
	public Animator knocker2; // 0x248


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void ClientKnock(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

}

