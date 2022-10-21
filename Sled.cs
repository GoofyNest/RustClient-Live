public class Sled : BaseVehicle, INotifyTrigger // TypeDefIndex: 10547
{
	private const BaseEntity.Flags BrakeOn = 128;
	private const BaseEntity.Flags OnSnow = 256;
	private const BaseEntity.Flags IsGrounded = 512;
	private const BaseEntity.Flags OnSand = 1024;
	public PhysicMaterial BrakeMaterial; 
	public PhysicMaterial SnowMaterial; 
	public PhysicMaterial NonSnowMaterial; 
	public Transform CentreOfMassTransform; 
	public Collider[] PhysicsMaterialTargets; 
	public float InitialForceCutoff; 
	public float InitialForceIncreaseRate; 
	public float TurnForce; 
	public float DirectionMatchForce; 
	public float VerticalAdjustmentForce; 
	public float VerticalAdjustmentAngleThreshold; 
	public float NudgeCooldown; 
	public float NudgeForce; 
	public float MaxNudgeVelocity; 
	public const float DecayFrequency = 60;
	public float DecayAmount; 
	public ParticleSystemContainer TrailEffects; 
	public SoundDefinition enterSnowSoundDef; 
	public SoundDefinition snowSlideLoopSoundDef; 
	public SoundDefinition dirtSlideLoopSoundDef; 
	public AnimationCurve movementLoopGainCurve; 
	public AnimationCurve movementLoopPitchCurve; 
	private Sound movementLoopSound; 
	private SoundModulation.Modulator movementLoopGain; 
	private SoundModulation.Modulator movementLoopPitch; 
	private float speed; 
	private PhysicsEffects physEffects; 
	private bool shouldShowHelp; 
	private TimeSince showHelpTime; 

	public bool ShowHelpPrompt { get; }
	public override bool BlocksDoors { get; }


	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public override void ClientOnEnable() { }

	protected override void ClientInit(Entity info) { }

	private void UpdateSounds() { }

	private void SetMovementLoopSound(SoundDefinition targetDef) { }

	public bool get_ShowHelpPrompt() { }

	public override bool CanPickup(BasePlayer player) { }

	public void OnObjects(TriggerNotify trigger) { }

	public void OnEmpty() { }

	public override bool get_BlocksDoors() { }

	public void .ctor() { }

}

