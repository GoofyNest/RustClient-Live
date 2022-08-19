public class Flashbang : TimedExplosive // TypeDefIndex: 8570
{	// Fields
	public SoundDefinition deafLoopDef; // 0x1B8
	public float flashReductionPerSecond; // 0x1C0
	public float flashToAdd; // 0x1C4
	public float flashMinRange; // 0x1C8
	public float flashMaxRange; // 0x1CC
	public static float localFlashAmount; // 0x0
	private Sound deafLoop; // 0x1D0
	private SoundModulation.Modulator deafGain; // 0x1D8

	// Methods

	// RVA: 0x78F980 Offset: 0x78ED80 VA: 0x18078F980 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x78F670 Offset: 0x78EA70 VA: 0x18078F670
	public void FlashFrom(Vector3 pos, float amount) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x78F600 Offset: 0x78EA00 VA: 0x18078F600
	public void Client_DoFlash(BaseEntity.RPCMessage msg) { }

	// RVA: 0x78FDF0 Offset: 0x78F1F0 VA: 0x18078FDF0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

