public class FrankensteinPet : BasePet, IAISenses, IAIAttack // TypeDefIndex: 8571
{	[HeaderAttribute] // RVA: 0xAB2D0 Offset: 0xAA6D0 VA: 0x1800AB2D0
	[ServerVar] // RVA: 0xAB2D0 Offset: 0xAA6D0 VA: 0x1800AB2D0
	public static float decayminutes; // 0x0
	[HeaderAttribute] // RVA: 0x71F00 Offset: 0x71300 VA: 0x180071F00
	public SoundDefinition AttackVocalSFX; // 0x858


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnAttack(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

