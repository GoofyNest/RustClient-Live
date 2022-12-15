public class FrankensteinPet : BasePet, IAISenses, IAIAttack // TypeDefIndex: 10297
{
	[HeaderAttribute]
	[ServerVar]
	public static float decayminutes;
	[HeaderAttribute]
	public SoundDefinition AttackVocalSFX;


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client]
	private void OnAttack(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

