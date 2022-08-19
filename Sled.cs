public class Sled : BaseVehicle, INotifyTrigger // TypeDefIndex: 8836
{	// Fields
	private const BaseEntity.Flags BrakeOn = 128;
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

	// Properties
	public bool ShowHelpPrompt { get; }
	public override bool BlocksDoors { get; }

	// Methods

	// RVA: 0x5BFFC0 Offset: 0x5BF3C0 VA: 0x1805BFFC0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5C02F0 Offset: 0x5BF6F0 VA: 0x1805C02F0 Slot: 83
	public override void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x5BFF80 Offset: 0x5BF380 VA: 0x1805BFF80 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x5BFEC0 Offset: 0x5BF2C0 VA: 0x1805BFEC0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x5BFE30 Offset: 0x5BF230 VA: 0x1805BFE30 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x5C06A0 Offset: 0x5BFAA0 VA: 0x1805C06A0
	private void UpdateSounds() { }

	// RVA: 0x5C0420 Offset: 0x5BF820 VA: 0x1805C0420
	private void SetMovementLoopSound(SoundDefinition targetDef) { }

	// RVA: 0x5C0970 Offset: 0x5BFD70 VA: 0x1805C0970
	public bool get_ShowHelpPrompt() { }

	// RVA: 0x5BFDF0 Offset: 0x5BF1F0 VA: 0x1805BFDF0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 194
	public void OnObjects(TriggerNotify trigger) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 195
	public void OnEmpty() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 185
	public override bool get_BlocksDoors() { }

	// RVA: 0x5C0900 Offset: 0x5BFD00 VA: 0x1805C0900
	public void .ctor() { }

}

