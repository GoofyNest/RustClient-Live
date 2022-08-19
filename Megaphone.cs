public class Megaphone : HeldEntity // TypeDefIndex: 8604
{	// Fields
	[HeaderAttribute] // RVA: 0xB0300 Offset: 0xAF700 VA: 0x1800B0300
	public VoiceProcessor voiceProcessor; // 0x1F8
	public float VoiceDamageMinFrequency; // 0x200
	public float VoiceDamageAmount; // 0x204
	public AudioSource VoiceSource; // 0x208
	public SoundDefinition StartBroadcastingSfx; // 0x210
	public SoundDefinition StopBroadcastingSfx; // 0x218
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static float <MegaphoneVoiceRange>k__BackingField; // 0x0
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool IgnorePushToTalk; // 0x4
	private static int BroadcastBoolAnim; // 0x8
	private float talkingLayerWeight; // 0x220

	// Properties
	[ReplicatedVar] // RVA: 0xB0620 Offset: 0xAFA20 VA: 0x1800B0620
	public static float MegaphoneVoiceRange { get; set; }

	// Methods

	// RVA: 0x958A20 Offset: 0x957E20 VA: 0x180958A20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x958D40 Offset: 0x958140 VA: 0x180958D40
	public static float get_MegaphoneVoiceRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x958E00 Offset: 0x958200 VA: 0x180958E00
	public static void set_MegaphoneVoiceRange(float value) { }

	// RVA: 0x958B10 Offset: 0x957F10 VA: 0x180958B10
	public bool Receive(byte[] data) { }

	// RVA: 0x9585F0 Offset: 0x9579F0 VA: 0x1809585F0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x958C20 Offset: 0x958020 VA: 0x180958C20
	private void Update() { }

	// RVA: 0x958410 Offset: 0x957810 VA: 0x180958410 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x958CD0 Offset: 0x9580D0 VA: 0x180958CD0
	public void .ctor() { }

	// RVA: 0x958C60 Offset: 0x958060 VA: 0x180958C60
	private static void .cctor() { }

}

