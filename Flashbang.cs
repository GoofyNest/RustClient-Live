public class Flashbang : TimedExplosive // TypeDefIndex: 8570
{	public SoundDefinition deafLoopDef; // 0x1B8
	public float flashReductionPerSecond; // 0x1C0
	public float flashToAdd; // 0x1C4
	public float flashMinRange; // 0x1C8
	public float flashMaxRange; // 0x1CC
	public static float localFlashAmount; // 0x0
	private Sound deafLoop; // 0x1D0
	private SoundModulation.Modulator deafGain; // 0x1D8


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void FlashFrom(Vector3 pos, float amount) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Client_DoFlash(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

