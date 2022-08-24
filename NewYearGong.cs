public class NewYearGong : BaseCombatEntity // TypeDefIndex: 8609
{
	public SoundDefinition gongSound; 
	public float minTimeBetweenSounds; 
	public GameObject soundRoot; 
	public Transform gongCentre; 
	public float gongRadius; 
	public AnimationCurve pitchCurve; 
	public Animator gongAnimator; 
	private static int gongHit_trigger; 
	private Sound playingSound; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] 
	public void PlaySound(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

