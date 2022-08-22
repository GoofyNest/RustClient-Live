public class TreeMarker : BaseEntity // TypeDefIndex: 8269
{	public GameObjectRef hitEffect; // 0x168
	public SoundDefinition hitEffectSound; // 0x170
	public GameObjectRef spawnEffect; // 0x178
	private Vector3 initialPosition; // 0x180
	public bool SpherecastOnInit; // 0x18C
	private const float markerDistSq = 900;


	protected override void ClientInit(Entity info) { }

	public override void PostNetworkUpdate() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void MarkerHit(BaseEntity.RPCMessage msg) { }

	public void UpdatePositioning() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

}

