public class Drone : RemoteControlEntity // TypeDefIndex: 8689
{	// Fields
	[HeaderAttribute] // RVA: 0xBB770 Offset: 0xBAB70 VA: 0x1800BB770
	public Rigidbody body; // 0x2B0
	public bool killInWater; // 0x2B8
	public bool enableGrounding; // 0x2B9
	public bool keepAboveTerrain; // 0x2BA
	public float groundTraceDist; // 0x2BC
	public float altitudeAcceleration; // 0x2C0
	public float movementAcceleration; // 0x2C4
	public float yawSpeed; // 0x2C8
	public float uprightSpeed; // 0x2CC
	public float uprightPrediction; // 0x2D0
	public float uprightDot; // 0x2D4
	public float leanWeight; // 0x2D8
	public float leanMaxVelocity; // 0x2DC
	public float hurtVelocityThreshold; // 0x2E0
	public float hurtDamagePower; // 0x2E4
	public float collisionDisableTime; // 0x2E8
	[HeaderAttribute] // RVA: 0x8CB00 Offset: 0x8BF00 VA: 0x18008CB00
	public SoundDefinition movementLoopSoundDef; // 0x2F0
	public SoundDefinition movementStartSoundDef; // 0x2F8
	public SoundDefinition movementStopSoundDef; // 0x300
	public AnimationCurve movementLoopPitchCurve; // 0x308
	private Sound movementLoopSound; // 0x310
	private SoundModulation.Modulator movementLoopPitch; // 0x318

	// Properties
	public override bool RequiresMouse { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 157
	public override bool get_RequiresMouse() { }

	// RVA: 0xAAC210 Offset: 0xAAB610 VA: 0x180AAC210 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xAAC2D0 Offset: 0xAAB6D0 VA: 0x180AAC2D0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0xAAC3A0 Offset: 0xAAB7A0 VA: 0x180AAC3A0
	private void PlayMovementStopSound() { }

	// RVA: 0xAAC760 Offset: 0xAABB60 VA: 0x180AAC760
	private void UpdateSounds() { }

	// RVA: 0xAAC4F0 Offset: 0xAAB8F0 VA: 0x180AAC4F0
	private void SetMovementLoopSound(SoundDefinition targetDef) { }

	// RVA: 0xAAC920 Offset: 0xAABD20 VA: 0x180AAC920
	public void .ctor() { }

}

private struct Drone.DroneInputState // TypeDefIndex: 8690
{	// Fields
	public Vector3 movement; // 0x0
	public float throttle; // 0xC
	public float pitch; // 0x10
	public float yaw; // 0x14

	// Methods

	// RVA: 0xFC3F0 Offset: 0xFB7F0 VA: 0x1800FC3F0
	public void Reset() { }

}

