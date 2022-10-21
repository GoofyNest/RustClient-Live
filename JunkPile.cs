public class JunkPile : BaseEntity // TypeDefIndex: 10301
{
	public GameObjectRef sinkEffect; 
	public SpawnGroup[] spawngroups; 
	public NPCSpawner NPCSpawn; 
	private const float lifetimeMinutes = 30;
	private float sunkAmount; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] 
	public void CLIENT_StartSink(BaseEntity.RPCMessage msg) { }

	public void SinkThink() { }

	public void .ctor() { }

}

