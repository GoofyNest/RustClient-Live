public class SubmarineAudio : MonoBehaviour // TypeDefIndex: 9760
{	[HeaderAttribute] // RVA: 0x87C50 Offset: 0x87050 VA: 0x180087C50
	[SerializeField] // RVA: 0x87C50 Offset: 0x87050 VA: 0x180087C50
	private SoundDefinition engineStartSound; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition engineStopSound; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition engineStartFailSound; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition engineLoopSound; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AnimationCurve engineLoopPitchCurve; // 0x38
	[HeaderAttribute] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[SerializeField] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	private SoundDefinition underwaterLoopDef; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition underwaterMovementLoopDef; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BlendedSoundLoops surfaceWaterLoops; // 0x50
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float surfaceWaterSoundsMaxSpeed; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition waterEmergeSoundDef; // 0x60
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition waterSubmergeSoundDef; // 0x68
	[HeaderAttribute] // RVA: 0x93670 Offset: 0x92A70 VA: 0x180093670
	[SerializeField] // RVA: 0x93670 Offset: 0x92A70 VA: 0x180093670
	private SoundDefinition activeLoopDef; // 0x70
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition footPedalSoundDef; // 0x78
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform footPedalSoundPos; // 0x80
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition steeringWheelSoundDef; // 0x88
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform steeringWheelSoundPos; // 0x90
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition heavyDamageSparksDef; // 0x98
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform heavyDamageSparksPos; // 0xA0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition flagRaise; // 0xA8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition flagLower; // 0xB0
	[HeaderAttribute] // RVA: 0x93C50 Offset: 0x93050 VA: 0x180093C50
	[SerializeField] // RVA: 0x93C50 Offset: 0x93050 VA: 0x180093C50
	private SoundDefinition climbOrDiveLoopSound; // 0xB8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition sonarBlipSound; // 0xC0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition torpedoFailedSound; // 0xC8
	private Sound engineLoop; // 0xD0
	private SoundModulation.Modulator engineLoopPitchMod; // 0xD8
	private Sound activeLoop; // 0xE0
	private Sound heavyDamageSparksLoop; // 0xE8
	private Sound underwaterLoop; // 0xF0
	private SoundModulation.Modulator underwaterGainMod; // 0xF8
	private Sound underwaterMovementLoop; // 0x100
	private SoundModulation.Modulator underwaterMovementGainMod; // 0x108
	private Sound climbOrDiveLoop; // 0x110
	private float engineSoundMaxDistSqr; // 0x118
	private float previousWaterDepth; // 0x11C
	private float previousRudderInput; // 0x120
	private float previousThrottleInput; // 0x124


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

