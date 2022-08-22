public class ScrapTransportHelicopter : MiniCopter // TypeDefIndex: 8295
{	public Transform searchlightEye; // 0x630
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


	protected override float GetMainRotorScale() { }

	public override bool MountMenuVisible(BasePlayer player) { }

	private bool PlayerIsInside(BasePlayer player) { }

	protected override void ClientInit(Entity info) { }

	public override void UpdateLayerIndicies() { }

	public override void UpdateAnimator() { }

	public override void PostNetworkUpdate() { }

	public void UpdateDamageEffects() { }

	protected override void WorkshopMode() { }

	protected override bool CanPushNow(BasePlayer pusher) { }

	public void .ctor() { }

	private static void .cctor() { }

}

