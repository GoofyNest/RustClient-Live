public class ScrapTransportHelicopter : MiniCopter // TypeDefIndex: 8295
{
	public Transform searchlightEye; 
	public BoxCollider parentTriggerCollider; 
	[HeaderAttribute] 
	public ParticleSystemContainer tailDamageLight; 
	public ParticleSystemContainer tailDamageHeavy; 
	public ParticleSystemContainer mainEngineDamageLight; 
	public ParticleSystemContainer mainEngineDamageHeavy; 
	public ParticleSystemContainer cockpitSparks; 
	public Transform tailDamageLightEffects; 
	public Transform mainEngineDamageLightEffects; 
	public SoundDefinition damagedFireSoundDef; 
	public SoundDefinition damagedFireTailSoundDef; 
	public SoundDefinition damagedSparksSoundDef; 
	private Sound damagedFireSound; 
	private Sound damagedFireTailSound; 
	private Sound damagedSparksSound; 
	public float pilotRotorScale; 
	public float compassOffset; 
	[ServerVar] 
	public static float population; 
	protected static int speedAnimationIndex; 
	protected static int altitudeAnimationIndex; 
	protected static int headingAnimationIndex; 
	protected int speedShakeIndex; 
	protected int altShakeIndex; 
	private float lastSpeed; 
	private float lastHealthFraction; 


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

