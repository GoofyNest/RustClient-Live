public class DoorKnocker : BaseCombatEntity // TypeDefIndex: 10292
{
	public Animator knocker1;
	public Animator knocker2;


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client]
	public void ClientKnock(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

}

