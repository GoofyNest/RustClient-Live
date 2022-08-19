public class CeilingLight : IOEntity // TypeDefIndex: 8548
{	// Fields
	public float pushScale; // 0x288

	// Methods

	// RVA: 0x54B440 Offset: 0x54A840 VA: 0x18054B440 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x54B2E0 Offset: 0x54A6E0 VA: 0x18054B2E0 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54B080 Offset: 0x54A480 VA: 0x18054B080
	public void ClientPhysPush(BaseEntity.RPCMessage msg) { }

	// RVA: 0x54B890 Offset: 0x54AC90 VA: 0x18054B890
	public void PhysPush(Vector3 attackNormal, Vector3 hitPositionWorld) { }

	// RVA: 0x54AFD0 Offset: 0x54A3D0 VA: 0x18054AFD0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x54BA00 Offset: 0x54AE00 VA: 0x18054BA00
	public void .ctor() { }

}

