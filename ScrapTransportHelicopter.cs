public class ScrapTransportHelicopter : MiniCopter // TypeDefIndex: 8295
{	// Fields
	public Transform searchlightEye; // 0x630
	public BoxCollider parentTriggerCollider; // 0x638
	[HeaderAttribute] // RVA: 0xAC7B0 Offset: 0xABBB0 VA: 0x1800AC7B0
	public ParticleSystemContainer tailDamageLight; // 0x640
	public ParticleSystemContainer tailDamageHeavy; // 0x648
	public ParticleSystemContainer mainEngineDamageLight; // 0x650
	public ParticleSystemContainer mainEngineDamageHeavy; // 0x658
	public ParticleSystemContainer cockpitSparks; // 0x660
	public Transform tailDamageLightEffects; // 0x668
	public Transform mainEngineDamageLightEffects; // 0x670
	public SoundDefinition damagedFireSoundDef; // 0x678
	public SoundDefinition damagedFireTailSoundDef; // 0x680
	public SoundDefinition damagedSparksSoundDef; // 0x688
	private Sound damagedFireSound; // 0x690
	private Sound damagedFireTailSound; // 0x698
	private Sound damagedSparksSound; // 0x6A0
	public float pilotRotorScale; // 0x6A8
	public float compassOffset; // 0x6AC
	[ServerVar] // RVA: 0x71DA0 Offset: 0x711A0 VA: 0x180071DA0
	public static float population; // 0x0
	protected static int speedAnimationIndex; // 0x4
	protected static int altitudeAnimationIndex; // 0x8
	protected static int headingAnimationIndex; // 0xC
	protected int speedShakeIndex; // 0x6B0
	protected int altShakeIndex; // 0x6B4
	private float lastSpeed; // 0x6B8
	private float lastHealthFraction; // 0x6BC

	// Methods

	// RVA: 0x49F8E0 Offset: 0x49ECE0 VA: 0x18049F8E0 Slot: 198
	protected override float GetMainRotorScale() { }

	// RVA: 0x49F920 Offset: 0x49ED20 VA: 0x18049F920 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x49F9C0 Offset: 0x49EDC0 VA: 0x18049F9C0
	private bool PlayerIsInside(BasePlayer player) { }

	// RVA: 0x49F860 Offset: 0x49EC60 VA: 0x18049F860 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x4A03D0 Offset: 0x49F7D0 VA: 0x1804A03D0 Slot: 199
	public override void UpdateLayerIndicies() { }

	// RVA: 0x49FAF0 Offset: 0x49EEF0 VA: 0x18049FAF0 Slot: 197
	public override void UpdateAnimator() { }

	// RVA: 0x49FA40 Offset: 0x49EE40 VA: 0x18049FA40 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x49FE60 Offset: 0x49F260 VA: 0x18049FE60
	public void UpdateDamageEffects() { }

	// RVA: 0x4A0450 Offset: 0x49F850 VA: 0x1804A0450 Slot: 191
	protected override void WorkshopMode() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x4A0600 Offset: 0x49FA00 VA: 0x1804A0600
	public void .ctor() { }

	// RVA: 0x4A0560 Offset: 0x49F960 VA: 0x1804A0560
	private static void .cctor() { }

}

