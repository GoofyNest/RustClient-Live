public class Megaphone : HeldEntity // TypeDefIndex: 10311
{
	[HeaderAttribute] 
	public VoiceProcessor voiceProcessor; 
	public float VoiceDamageMinFrequency; 
	public float VoiceDamageAmount; 
	public AudioSource VoiceSource; 
	public SoundDefinition StartBroadcastingSfx; 
	public SoundDefinition StopBroadcastingSfx; 
	[CompilerGeneratedAttribute] 
	private static float <MegaphoneVoiceRange>k__BackingField; 
	[ClientVar] 
	public static bool IgnorePushToTalk; 
	private static int BroadcastBoolAnim; 
	private float talkingLayerWeight; 

	[ReplicatedVar] 
	public static float MegaphoneVoiceRange { get; set; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] 
	public static float get_MegaphoneVoiceRange() { }

	[CompilerGeneratedAttribute] 
	public static void set_MegaphoneVoiceRange(float value) { }

	public bool Receive(byte[] data) { }

	public override void OnInput() { }

	private void Update() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void .ctor() { }

	private static void .cctor() { }

}

