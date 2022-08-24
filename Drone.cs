public class Drone : RemoteControlEntity // TypeDefIndex: 8689
{
	[HeaderAttribute] 
	public Rigidbody body; 
	public bool killInWater; 
	public bool enableGrounding; 
	public bool keepAboveTerrain; 
	public float groundTraceDist; 
	public float altitudeAcceleration; 
	public float movementAcceleration; 
	public float yawSpeed; 
	public float uprightSpeed; 
	public float uprightPrediction; 
	public float uprightDot; 
	public float leanWeight; 
	public float leanMaxVelocity; 
	public float hurtVelocityThreshold; 
	public float hurtDamagePower; 
	public float collisionDisableTime; 
	[HeaderAttribute] 
	public SoundDefinition movementLoopSoundDef; 
	public SoundDefinition movementStartSoundDef; 
	public SoundDefinition movementStopSoundDef; 
	public AnimationCurve movementLoopPitchCurve; 
	private Sound movementLoopSound; 
	private SoundModulation.Modulator movementLoopPitch; 

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
{
	public Vector3 movement; 
	public float throttle; 
	public float pitch; 
	public float yaw; 


public void Reset() { }

}

