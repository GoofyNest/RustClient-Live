public class NewYearGong : BaseCombatEntity // TypeDefIndex: 8609
{	// Fields
	public SoundDefinition gongSound; // 0x240
	public float minTimeBetweenSounds; // 0x248
	public GameObject soundRoot; // 0x250
	public Transform gongCentre; // 0x258
	public float gongRadius; // 0x260
	public AnimationCurve pitchCurve; // 0x268
	public Animator gongAnimator; // 0x270
	private static int gongHit_trigger; // 0x0
	private Sound playingSound; // 0x278

	// Methods

	// RVA: 0xA347F0 Offset: 0xA33BF0 VA: 0x180A347F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA34C40 Offset: 0xA34040 VA: 0x180A34C40
	public void PlaySound(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA34EA0 Offset: 0xA342A0 VA: 0x180A34EA0
	public void .ctor() { }

	// RVA: 0xA34E50 Offset: 0xA34250 VA: 0x180A34E50
	private static void .cctor() { }

}

