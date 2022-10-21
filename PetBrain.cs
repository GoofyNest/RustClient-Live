public class PetBrain : BaseAIBrain // TypeDefIndex: 10323
{
	[HeaderAttribute] 
	public SoundDefinition CommandGivenVocalSFX; 
	[ServerVar] 
	public static bool DrownInDeepWater; 
	[ServerVar] 
	public static bool IdleWhenOwnerOfflineOrDead; 
	[ServerVar] 
	public static bool IdleWhenOwnerMounted; 
	[ServerVar] 
	public static float DrownTimer; 
	[ReplicatedVar] 
	public static float ControlDistance; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] 
	private void OnCommandGiven(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

