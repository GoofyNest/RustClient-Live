public class PetBrain : BaseAIBrain<BasePet> // TypeDefIndex: 8614
{	// Fields
	[HeaderAttribute] // RVA: 0x71F00 Offset: 0x71300 VA: 0x180071F00
	public SoundDefinition CommandGivenVocalSFX; // 0xF8
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool DrownInDeepWater; // 0x0
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool IdleWhenOwnerOfflineOrDead; // 0x1
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool IdleWhenOwnerMounted; // 0x2
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float DrownTimer; // 0x4
	[ReplicatedVar] // RVA: 0xA98E0 Offset: 0xA8CE0 VA: 0x1800A98E0
	public static float ControlDistance; // 0x8

	// Methods

	// RVA: 0x94B290 Offset: 0x94A690 VA: 0x18094B290 Slot: 9
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94B1E0 Offset: 0x94A5E0 VA: 0x18094B1E0
	private void OnCommandGiven(BaseEntity.RPCMessage msg) { }

	// RVA: 0x94B7E0 Offset: 0x94ABE0 VA: 0x18094B7E0
	public void .ctor() { }

	// RVA: 0x94B750 Offset: 0x94AB50 VA: 0x18094B750
	private static void .cctor() { }

}

