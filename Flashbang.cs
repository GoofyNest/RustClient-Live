public class Flashbang : TimedExplosive // TypeDefIndex: 10278
{
	public SoundDefinition deafLoopDef; 
	public float flashReductionPerSecond; 
	public float flashToAdd; 
	public float flashMinRange; 
	public float flashMaxRange; 
	public static float localFlashAmount; 
	private Sound deafLoop; 
	private SoundModulation.Modulator deafGain; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void FlashFrom(Vector3 pos, float amount) { }

	[BaseEntity.RPC_Client] 
	public void Client_DoFlash(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

