public class CeilingLight : IOEntity // TypeDefIndex: 10220
{
	public float pushScale; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override int ConsumptionAmount() { }

	public override void OnAttacked(HitInfo info) { }

	[BaseEntity.RPC_Client] 
	public void ClientPhysPush(BaseEntity.RPCMessage msg) { }

	public void PhysPush(Vector3 attackNormal, Vector3 hitPositionWorld) { }

	protected override void ClientInit(Entity info) { }

	public void .ctor() { }

}

