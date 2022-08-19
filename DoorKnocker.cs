public class DoorKnocker : BaseCombatEntity // TypeDefIndex: 8566
{	// Fields
	public Animator knocker1; // 0x240
	public Animator knocker2; // 0x248

	// Methods

	// RVA: 0xAA80E0 Offset: 0xAA74E0 VA: 0x180AA80E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAA7F40 Offset: 0xAA7340 VA: 0x180AA7F40
	public void ClientKnock(BaseEntity.RPCMessage msg) { }

	// RVA: 0x499120 Offset: 0x498520 VA: 0x180499120
	public void .ctor() { }

}

