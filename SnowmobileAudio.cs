public class SnowmobileAudio : GroundVehicleAudio // TypeDefIndex: 9756
{	// Fields
	[HeaderAttribute] // RVA: 0x87C50 Offset: 0x87050 VA: 0x180087C50
	[SerializeField] // RVA: 0x87C50 Offset: 0x87050 VA: 0x180087C50
	private EngineAudioSet engineAudioSet; // 0x98
	[HeaderAttribute] // RVA: 0x8FCF0 Offset: 0x8F0F0 VA: 0x18008FCF0
	[SerializeField] // RVA: 0x8FCF0 Offset: 0x8F0F0 VA: 0x18008FCF0
	private AnimationCurve skiGainCurve; // 0xA0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition skiSlideSoundDef; // 0xA8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition skiSlideSnowSoundDef; // 0xB0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition skiSlideSandSoundDef; // 0xB8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition skiSlideGrassSoundDef; // 0xC0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition skiSlideWaterSoundDef; // 0xC8
	[HeaderAttribute] // RVA: 0x90260 Offset: 0x8F660 VA: 0x180090260
	[SerializeField] // RVA: 0x90260 Offset: 0x8F660 VA: 0x180090260
	private AnimationCurve movementGainCurve; // 0xD0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition movementLoopDef; // 0xD8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition suspensionLurchSoundDef; // 0xE0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float suspensionLurchMinExtensionDelta; // 0xE8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float suspensionLurchMinTimeBetweenSounds; // 0xEC
	private Snowmobile snowmobile; // 0xF0
	private Sound movementLoop; // 0xF8
	private SoundModulation.Modulator movementGainMod; // 0x100
	private Dictionary<VehicleChassisVisuals.ClientWheelData<Snowmobile>, float> prevWheelExtensionPercent; // 0x108
	private Dictionary<VehicleChassisVisuals.ClientWheelData<Snowmobile>, bool> wheelWasGrounded; // 0x110
	private Dictionary<VehicleChassisVisuals.ClientWheelData<Snowmobile>, float> lastSuspensionSoundPlayed; // 0x118

	// Properties
	protected override EngineAudioSet EngineAudioSet { get; set; }

	// Methods

	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0 Slot: 4
	protected override EngineAudioSet get_EngineAudioSet() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	protected override void set_EngineAudioSet(EngineAudioSet value) { }

	// RVA: 0x5CAE90 Offset: 0x5CA290 VA: 0x1805CAE90 Slot: 6
	protected override void Awake() { }

	// RVA: 0x5CAF30 Offset: 0x5CA330 VA: 0x1805CAF30 Slot: 7
	public override void ClientTick() { }

	// RVA: 0x5CB3E0 Offset: 0x5CA7E0 VA: 0x1805CB3E0
	private void UpdateMovementLoop(float speedRatio) { }

	// RVA: 0x5CB170 Offset: 0x5CA570 VA: 0x1805CB170
	private void StopMovementLoop() { }

	// RVA: 0x5CB600 Offset: 0x5CAA00 VA: 0x1805CB600
	private void UpdateSkiSound(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData, float speedRatio) { }

	// RVA: 0x5CB300 Offset: 0x5CA700 VA: 0x1805CB300
	public void StopSkiAudio() { }

	// RVA: 0x5CB230 Offset: 0x5CA630 VA: 0x1805CB230
	public void StopSkiAudio(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData) { }

	// RVA: 0x5CB9F0 Offset: 0x5CADF0 VA: 0x1805CB9F0
	private void UpdateSuspensionSounds() { }

	// RVA: 0x5CB150 Offset: 0x5CA550 VA: 0x1805CB150 Slot: 8
	public override void OnClientTickStopped() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 9
	protected override int GetNumEngines() { }

	// RVA: 0x5CBD40 Offset: 0x5CB140 VA: 0x1805CBD40
	public void .ctor() { }

}

