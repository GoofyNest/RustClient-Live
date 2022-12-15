public class TreeMarker : BaseEntity // TypeDefIndex: 9987
{
	public GameObjectRef hitEffect;
	public SoundDefinition hitEffectSound;
	public GameObjectRef spawnEffect;
	private Vector3 initialPosition;
	public bool SpherecastOnInit;
	private const float markerDistSq = 900;


	protected override void ClientInit(Entity info) { }

	public override void PostNetworkUpdate() { }

	[BaseEntity.RPC_Client]
	public void MarkerHit(BaseEntity.RPCMessage msg) { }

	public void UpdatePositioning() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

}

