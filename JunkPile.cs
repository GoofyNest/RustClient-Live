public class JunkPile : BaseEntity // TypeDefIndex: 8592
{	public GameObjectRef sinkEffect; // 0x168
	public SpawnGroup[] spawngroups; // 0x170
	public NPCSpawner NPCSpawn; // 0x178
	private const float lifetimeMinutes = 30;
	private float sunkAmount; // 0x180


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void CLIENT_StartSink(BaseEntity.RPCMessage msg) { }

	public void SinkThink() { }

	public void .ctor() { }

}

