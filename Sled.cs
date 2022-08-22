public class Sled : BaseVehicle, INotifyTrigger // TypeDefIndex: 8836
{	private const BaseEntity.Flags BrakeOn = 128;
	private const BaseEntity.Flags OnSnow = 256;
	private const BaseEntity.Flags IsGrounded = 512;
	private const BaseEntity.Flags OnSand = 1024;
	public PhysicMaterial BrakeMaterial; // 0x3B8
	public PhysicMaterial SnowMaterial; // 0x3C0
	public PhysicMaterial NonSnowMaterial; // 0x3C8
	public Transform CentreOfMassTransform; // 0x3D0
	public Collider[] PhysicsMaterialTargets; // 0x3D8
	public float InitialForceCutoff; // 0x3E0
	public float InitialForceIncreaseRate; // 0x3E4
	public float TurnForce; // 0x3E8
	public float DirectionMatchForce; // 0x3EC
	public float VerticalAdjustmentForce; // 0x3F0
	public float VerticalAdjustmentAngleThreshold; // 0x3F4
	public float NudgeCooldown; // 0x3F8
	public float NudgeForce; // 0x3FC
	public float MaxNudgeVelocity; // 0x400
	public const float DecayFrequency = 60;
	public float DecayAmount; // 0x404
	public ParticleSystemContainer TrailEffects; // 0x408
	public SoundDefinition enterSnowSoundDef; // 0x410
	public SoundDefinition snowSlideLoopSoundDef; // 0x418
	public SoundDefinition dirtSlideLoopSoundDef; // 0x420
	public AnimationCurve movementLoopGainCurve; // 0x428
	public AnimationCurve movementLoopPitchCurve; // 0x430
	private Sound movementLoopSound; // 0x438
	private SoundModulation.Modulator movementLoopGain; // 0x440
	private SoundModulation.Modulator movementLoopPitch; // 0x448
	private float speed; // 0x450
	private PhysicsEffects physEffects; // 0x458
	private bool shouldShowHelp; // 0x460
	private TimeSince showHelpTime; // 0x464

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

