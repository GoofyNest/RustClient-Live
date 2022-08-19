public class JunkPile : BaseEntity // TypeDefIndex: 8592
{	// Fields
	public GameObjectRef sinkEffect; // 0x168
	public SpawnGroup[] spawngroups; // 0x170
	public NPCSpawner NPCSpawn; // 0x178
	private const float lifetimeMinutes = 30;
	private float sunkAmount; // 0x180

	// Methods

	// RVA: 0x6B2A00 Offset: 0x6B1E00 VA: 0x1806B2A00 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6B28A0 Offset: 0x6B1CA0 VA: 0x1806B28A0
	public void CLIENT_StartSink(BaseEntity.RPCMessage msg) { }

	// RVA: 0x6B2F70 Offset: 0x6B2370 VA: 0x1806B2F70
	public void SinkThink() { }

	// RVA: 0x6B2840 Offset: 0x6B1C40 VA: 0x1806B2840
	public void .ctor() { }

}

