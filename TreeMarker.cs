public class TreeMarker : BaseEntity // TypeDefIndex: 8269
{	// Fields
	public GameObjectRef hitEffect; // 0x168
	public SoundDefinition hitEffectSound; // 0x170
	public GameObjectRef spawnEffect; // 0x178
	private Vector3 initialPosition; // 0x180
	public bool SpherecastOnInit; // 0x18C
	private const float markerDistSq = 900;

	// Methods

	// RVA: 0x9FD330 Offset: 0x9FC730 VA: 0x1809FD330 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x9FDAA0 Offset: 0x9FCEA0 VA: 0x1809FDAA0 Slot: 16
	public override void PostNetworkUpdate() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9FD390 Offset: 0x9FC790 VA: 0x1809FD390
	public void MarkerHit(BaseEntity.RPCMessage msg) { }

	// RVA: 0x9FDBE0 Offset: 0x9FCFE0 VA: 0x1809FDBE0
	public void UpdatePositioning() { }

	// RVA: 0x9FD650 Offset: 0x9FCA50 VA: 0x1809FD650 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9FDF50 Offset: 0x9FD350 VA: 0x1809FDF50
	public void .ctor() { }

}

