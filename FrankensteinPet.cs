public class FrankensteinPet : BasePet, IAISenses, IAIAttack // TypeDefIndex: 8571
{	// Fields
	[HeaderAttribute] // RVA: 0xAB2D0 Offset: 0xAA6D0 VA: 0x1800AB2D0
	[ServerVar] // RVA: 0xAB2D0 Offset: 0xAA6D0 VA: 0x1800AB2D0
	public static float decayminutes; // 0x0
	[HeaderAttribute] // RVA: 0x71F00 Offset: 0x71300 VA: 0x180071F00
	public SoundDefinition AttackVocalSFX; // 0x858

	// Methods

	// RVA: 0x6EEE80 Offset: 0x6EE280 VA: 0x1806EEE80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x6EEDD0 Offset: 0x6EE1D0 VA: 0x1806EEDD0
	private void OnAttack(BaseEntity.RPCMessage msg) { }

	// RVA: 0x6EF380 Offset: 0x6EE780 VA: 0x1806EF380
	public void .ctor() { }

	// RVA: 0x6EF340 Offset: 0x6EE740 VA: 0x1806EF340
	private static void .cctor() { }

}

