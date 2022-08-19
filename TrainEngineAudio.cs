public class TrainEngineAudio : MonoBehaviour // TypeDefIndex: 9771
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TrainEngine trainEngine; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform cockpitSoundPosition; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform hornSoundPosition; // 0x28
	[HeaderAttribute] // RVA: 0x87C50 Offset: 0x87050 VA: 0x180087C50
	[SerializeField] // RVA: 0x87C50 Offset: 0x87050 VA: 0x180087C50
	private SoundDefinition engineStartSound; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition engineStopSound; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition engineActiveLoopDef; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AnimationCurve engineActiveLoopPitchCurve; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float engineActiveLoopChangeSpeed; // 0x50
	private Sound engineActiveLoop; // 0x58
	private SoundModulation.Modulator engineActiveLoopPitch; // 0x60
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BlendedLoopEngineSound engineLoops; // 0x68
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TrainEngineAudio.EngineReflection[] engineReflections; // 0x70
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private LayerMask reflectionLayerMask; // 0x78
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float reflectionMaxDistance; // 0x7C
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float reflectionGainChangeSpeed; // 0x80
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float reflectionPositionChangeSpeed; // 0x84
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float reflectionRayOffset; // 0x88
	[HeaderAttribute] // RVA: 0x967C0 Offset: 0x95BC0 VA: 0x1800967C0
	[SerializeField] // RVA: 0x967C0 Offset: 0x95BC0 VA: 0x1800967C0
	private SoundDefinition hornLoop; // 0x90
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition hornStart; // 0x98
	[HeaderAttribute] // RVA: 0x93C50 Offset: 0x93050 VA: 0x180093C50
	[SerializeField] // RVA: 0x93C50 Offset: 0x93050 VA: 0x180093C50
	private SoundDefinition lightsToggleSound; // 0xA0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition proximityAlertDef; // 0xA8
	private Sound proximityAlertSound; // 0xB0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition movementStartDef; // 0xB8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition movementStopDef; // 0xC0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition movementLoopDef; // 0xC8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AnimationCurve movementLoopGainCurve; // 0xD0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float movementChangeOneshotDebounce; // 0xD8
	private Sound movementLoop; // 0xE0
	private SoundModulation.Modulator movementLoopGain; // 0xE8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition turnLoopDef; // 0xF0
	private Sound turnLoop; // 0xF8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition trackClatterLoopDef; // 0x100
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AnimationCurve trackClatterGainCurve; // 0x108
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AnimationCurve trackClatterPitchCurve; // 0x110
	private Sound trackClatterLoop; // 0x118
	private SoundModulation.Modulator trackClatterGain; // 0x120
	private SoundModulation.Modulator trackClatterPitch; // 0x128
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition damagedLoopDef; // 0x130
	private Sound damagedLoop; // 0x138
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition changeThrottleDef; // 0x140
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition changeCouplingDef; // 0x148
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition unloadableStartDef; // 0x150
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition unloadableEndDef; // 0x158
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundPlayer brakeSound; // 0x160
	private Nullable<VehicleEngineController.EngineState<TrainEngine>> engineState; // 0x168
	private float lastMovementChangeOneshot; // 0x170
	private Sound activeHorn; // 0x178

	// Methods

	// RVA: 0x9F0DB0 Offset: 0x9F01B0 VA: 0x1809F0DB0
	public void UpdateTick() { }

	// RVA: 0x9F07A0 Offset: 0x9EFBA0 VA: 0x1809F07A0
	public void StopAll() { }

	// RVA: 0x9EFEE0 Offset: 0x9EF2E0 VA: 0x1809EFEE0
	public void PlayDamageSounds() { }

	// RVA: 0x9F08A0 Offset: 0x9EFCA0 VA: 0x1809F08A0
	public void StopDamageSounds() { }

	// RVA: 0x9F00D0 Offset: 0x9EF4D0 VA: 0x1809F00D0
	public void PlayThrottleSwitchSound() { }

	// RVA: 0x9EFE80 Offset: 0x9EF280 VA: 0x1809EFE80
	public void PlayCouplingChangedBeep() { }

	// RVA: 0x9F0070 Offset: 0x9EF470 VA: 0x1809F0070
	public void PlayLinedUpToUnloadBeep() { }

	// RVA: 0x9F0130 Offset: 0x9EF530 VA: 0x1809F0130
	public void PlayUnLinedUpToUnloadBeep() { }

	// RVA: 0x9F0200 Offset: 0x9EF600 VA: 0x1809F0200
	public void SetForEngineState(VehicleEngineController.EngineState<TrainEngine> newState) { }

	// RVA: 0x9F0010 Offset: 0x9EF410 VA: 0x1809F0010
	public void PlayLightsToggleSound() { }

	// RVA: 0x9F0190 Offset: 0x9EF590 VA: 0x1809F0190
	public void SetBrakeSound(bool braking) { }

	// RVA: 0x9F03A0 Offset: 0x9EF7A0 VA: 0x1809F03A0
	public void SetHornState(bool on) { }

	// RVA: 0x9F0AF0 Offset: 0x9EFEF0 VA: 0x1809F0AF0
	private void StopMovementLoops() { }

	// RVA: 0x9F0D00 Offset: 0x9F0100 VA: 0x1809F0D00
	private void StopTurnLoops() { }

	// RVA: 0x9F0950 Offset: 0x9EFD50 VA: 0x1809F0950
	private void StopEngineSounds(bool withinEngineSoundDist) { }

	// RVA: 0x9F05F0 Offset: 0x9EF9F0 VA: 0x1809F05F0
	private void StartEngineSounds(bool withinEngineSoundDist) { }

	// RVA: 0x9F1E90 Offset: 0x9F1290 VA: 0x1809F1E90
	public void .ctor() { }

}

public class TrainEngineAudio.EngineReflection // TypeDefIndex: 9772
{	// Fields
	public Vector3 direction; // 0x10
	public Vector3 offset; // 0x1C
	public SoundDefinition soundDef; // 0x28
	public Sound sound; // 0x30
	public SoundModulation.Modulator pitchMod; // 0x38
	public SoundModulation.Modulator gainMod; // 0x40
	public float distance; // 0x48

	// Methods

	// RVA: 0x9E6F40 Offset: 0x9E6340 VA: 0x1809E6F40
	public void .ctor() { }

}

