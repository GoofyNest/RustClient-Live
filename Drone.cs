public class Drone : RemoteControlEntity // TypeDefIndex: 8689
{	[HeaderAttribute] // RVA: 0xBB770 Offset: 0xBAB70 VA: 0x1800BB770
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

	public override bool RequiresMouse { get; }


	public override bool get_RequiresMouse() { }

	protected override void ClientInit(Entity info) { }

	protected override void DoClientDestroy() { }

	private void PlayMovementStopSound() { }

	private void UpdateSounds() { }

	private void SetMovementLoopSound(SoundDefinition targetDef) { }

	public void .ctor() { }

}

private struct Drone.DroneInputState // TypeDefIndex: 8690
{	public Vector3 movement; // 0x0
	public float throttle; // 0xC
	public float pitch; // 0x10
	public float yaw; // 0x14


	public void Reset() { }

}

