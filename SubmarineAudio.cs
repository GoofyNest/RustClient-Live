public class SubmarineAudio : MonoBehaviour // TypeDefIndex: 11496
{
	[HeaderAttribute] 
	[SerializeField] 
	private SoundDefinition engineStartSound; 
	[SerializeField] 
	private SoundDefinition engineStopSound; 
	[SerializeField] 
	private SoundDefinition engineStartFailSound; 
	[SerializeField] 
	private SoundDefinition engineLoopSound; 
	[SerializeField] 
	private AnimationCurve engineLoopPitchCurve; 
	[HeaderAttribute] 
	[SerializeField] 
	private SoundDefinition underwaterLoopDef; 
	[SerializeField] 
	private SoundDefinition underwaterMovementLoopDef; 
	[SerializeField] 
	private BlendedSoundLoops surfaceWaterLoops; 
	[SerializeField] 
	private float surfaceWaterSoundsMaxSpeed; 
	[SerializeField] 
	private SoundDefinition waterEmergeSoundDef; 
	[SerializeField] 
	private SoundDefinition waterSubmergeSoundDef; 
	[HeaderAttribute] 
	[SerializeField] 
	private SoundDefinition activeLoopDef; 
	[SerializeField] 
	private SoundDefinition footPedalSoundDef; 
	[SerializeField] 
	private Transform footPedalSoundPos; 
	[SerializeField] 
	private SoundDefinition steeringWheelSoundDef; 
	[SerializeField] 
	private Transform steeringWheelSoundPos; 
	[SerializeField] 
	private SoundDefinition heavyDamageSparksDef; 
	[SerializeField] 
	private Transform heavyDamageSparksPos; 
	[SerializeField] 
	private SoundDefinition flagRaise; 
	[SerializeField] 
	private SoundDefinition flagLower; 
	[HeaderAttribute] 
	[SerializeField] 
	private SoundDefinition climbOrDiveLoopSound; 
	[SerializeField] 
	private SoundDefinition sonarBlipSound; 
	[SerializeField] 
	private SoundDefinition torpedoFailedSound; 
	private Sound engineLoop; 
	private SoundModulation.Modulator engineLoopPitchMod; 
	private Sound activeLoop; 
	private Sound heavyDamageSparksLoop; 
	private Sound underwaterLoop; 
	private SoundModulation.Modulator underwaterGainMod; 
	private Sound underwaterMovementLoop; 
	private SoundModulation.Modulator underwaterMovementGainMod; 
	private Sound climbOrDiveLoop; 
	private float engineSoundMaxDistSqr; 
	private float previousWaterDepth; 
	private float previousRudderInput; 
	private float previousThrottleInput; 


	protected void Awake() { }

	public void UpdateTick(BaseSubmarine submarine, bool playerIsInside, float speed, float curSubDepthY) { }

	public void EndAllSounds() { }

	public void PlayEngineStartFailSound() { }

	public void PlayAmmoFlagRaise() { }

	public void PlayAmmoFlagLower() { }

	public void PlaySonarBlipSound() { }

	public void PlayTorpedoFireFailedSound() { }

	private bool WithinEngineSoundDistance() { }

	private void StartEngineSounds() { }

	private void StopEngineSounds() { }

	private void StartInteriorActiveAmbience() { }

	private void StopInteriorActiveAmbience() { }

	private void StartClimbOrDiveSounds() { }

	private void StopClimbOrDiveSounds() { }

	private void PlayEmergeSubmergeSounds(float curSubDepthY) { }

	private void PlayInteriorSteeringSounds(BaseSubmarine submarine) { }

	private void StartUnderwaterLoop(float waterFactor) { }

	private void StopUnderwaterLoop() { }

	private void UpdateSurfaceWaterSounds(float speed, float curSubDepthY) { }

	private void StartUnderwaterMovementSounds() { }

	private void StopUnderwaterMovementSounds() { }

	private void StartHeavyDamageSparkSound() { }

	private void StopHeavyDamageSparkSound() { }

	public void .ctor() { }

}

