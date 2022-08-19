public class SubmarineAudio : MonoBehaviour // TypeDefIndex: 9760
{	// Fields
	[HeaderAttribute] // RVA: 0x87C50 Offset: 0x87050 VA: 0x180087C50
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

	// Methods

	// RVA: 0x79E420 Offset: 0x79D820 VA: 0x18079E420
	protected void Awake() { }

	// RVA: 0x79F650 Offset: 0x79EA50 VA: 0x18079F650
	public void UpdateTick(BaseSubmarine submarine, bool playerIsInside, float speed, float curSubDepthY) { }

	// RVA: 0x79E470 Offset: 0x79D870 VA: 0x18079E470
	public void EndAllSounds() { }

	// RVA: 0x79E640 Offset: 0x79DA40 VA: 0x18079E640
	public void PlayEngineStartFailSound() { }

	// RVA: 0x79E520 Offset: 0x79D920 VA: 0x18079E520
	public void PlayAmmoFlagRaise() { }

	// RVA: 0x79E4D0 Offset: 0x79D8D0 VA: 0x18079E4D0
	public void PlayAmmoFlagLower() { }

	// RVA: 0x79E790 Offset: 0x79DB90 VA: 0x18079E790
	public void PlaySonarBlipSound() { }

	// RVA: 0x79E7E0 Offset: 0x79DBE0 VA: 0x18079E7E0
	public void PlayTorpedoFireFailedSound() { }

	// RVA: 0x7A01F0 Offset: 0x79F5F0 VA: 0x1807A01F0
	private bool WithinEngineSoundDistance() { }

	// RVA: 0x79E960 Offset: 0x79DD60 VA: 0x18079E960
	private void StartEngineSounds() { }

	// RVA: 0x79F110 Offset: 0x79E510 VA: 0x18079F110
	private void StopEngineSounds() { }

	// RVA: 0x79EC60 Offset: 0x79E060 VA: 0x18079EC60
	private void StartInteriorActiveAmbience() { }

	// RVA: 0x79F2F0 Offset: 0x79E6F0 VA: 0x18079F2F0
	private void StopInteriorActiveAmbience() { }

	// RVA: 0x79E830 Offset: 0x79DC30 VA: 0x18079E830
	private void StartClimbOrDiveSounds() { }

	// RVA: 0x79F060 Offset: 0x79E460 VA: 0x18079F060
	private void StopClimbOrDiveSounds() { }

	// RVA: 0x79E570 Offset: 0x79D970 VA: 0x18079E570
	private void PlayEmergeSubmergeSounds(float curSubDepthY) { }

	// RVA: 0x79E690 Offset: 0x79DA90 VA: 0x18079E690
	private void PlayInteriorSteeringSounds(BaseSubmarine submarine) { }

	// RVA: 0x79ED90 Offset: 0x79E190 VA: 0x18079ED90
	private void StartUnderwaterLoop(float waterFactor) { }

	// RVA: 0x79F3A0 Offset: 0x79E7A0 VA: 0x18079F3A0
	private void StopUnderwaterLoop() { }

	// RVA: 0x79F520 Offset: 0x79E920 VA: 0x18079F520
	private void UpdateSurfaceWaterSounds(float speed, float curSubDepthY) { }

	// RVA: 0x79EF00 Offset: 0x79E300 VA: 0x18079EF00
	private void StartUnderwaterMovementSounds() { }

	// RVA: 0x79F460 Offset: 0x79E860 VA: 0x18079F460
	private void StopUnderwaterMovementSounds() { }

	// RVA: 0x79EB30 Offset: 0x79DF30 VA: 0x18079EB30
	private void StartHeavyDamageSparkSound() { }

	// RVA: 0x79F240 Offset: 0x79E640 VA: 0x18079F240
	private void StopHeavyDamageSparkSound() { }

	// RVA: 0x7A02A0 Offset: 0x79F6A0 VA: 0x1807A02A0
	public void .ctor() { }

}

