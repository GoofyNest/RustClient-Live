public class NewYearGong : BaseCombatEntity // TypeDefIndex: 8609
{	public SoundDefinition gongSound; // 0x240
	public float minTimeBetweenSounds; // 0x248
	public GameObject soundRoot; // 0x250
	public Transform gongCentre; // 0x258
	public float gongRadius; // 0x260
	public AnimationCurve pitchCurve; // 0x268
	public Animator gongAnimator; // 0x270
	private static int gongHit_trigger; // 0x0
	private Sound playingSound; // 0x278


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void PlaySound(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

