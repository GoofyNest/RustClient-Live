public class RepeatingFirework : BaseFirework // TypeDefIndex: 8280
{
	public float timeBetweenRepeats; 
	public int maxRepeats; 
	public SoundPlayer launchSound; 


	[BaseEntity.RPC_Client] 
	public void RPCFire(BaseEntity.RPCMessage msg) { }

	public virtual void Fire() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

}

