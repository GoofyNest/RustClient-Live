public class SnowmobileAudio : GroundVehicleAudio // TypeDefIndex: 9756
{
	[HeaderAttribute] 
	[SerializeField] 
	private EngineAudioSet engineAudioSet; 
	[HeaderAttribute] 
	[SerializeField] 
	private AnimationCurve skiGainCurve; 
	[SerializeField] 
	private SoundDefinition skiSlideSoundDef; 
	[SerializeField] 
	private SoundDefinition skiSlideSnowSoundDef; 
	[SerializeField] 
	private SoundDefinition skiSlideSandSoundDef; 
	[SerializeField] 
	private SoundDefinition skiSlideGrassSoundDef; 
	[SerializeField] 
	private SoundDefinition skiSlideWaterSoundDef; 
	[HeaderAttribute] 
	[SerializeField] 
	private AnimationCurve movementGainCurve; 
	[SerializeField] 
	private SoundDefinition movementLoopDef; 
	[SerializeField] 
	private SoundDefinition suspensionLurchSoundDef; 
	[SerializeField] 
	private float suspensionLurchMinExtensionDelta; 
	[SerializeField] 
	private float suspensionLurchMinTimeBetweenSounds; 
	private Snowmobile snowmobile; 
	private Sound movementLoop; 
	private SoundModulation.Modulator movementGainMod; 
	private Dictionary<VehicleChassisVisuals.ClientWheelData<Snowmobile>, float> prevWheelExtensionPercent; 
	private Dictionary<VehicleChassisVisuals.ClientWheelData<Snowmobile>, bool> wheelWasGrounded; 
	private Dictionary<VehicleChassisVisuals.ClientWheelData<Snowmobile>, float> lastSuspensionSoundPlayed; 

	protected override EngineAudioSet EngineAudioSet { get; set; }


	protected override EngineAudioSet get_EngineAudioSet() { }

	protected override void set_EngineAudioSet(EngineAudioSet value) { }

	protected override void Awake() { }

	public override void ClientTick() { }

	private void UpdateMovementLoop(float speedRatio) { }

	private void StopMovementLoop() { }

	private void UpdateSkiSound(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData, float speedRatio) { }

	public void StopSkiAudio() { }

	public void StopSkiAudio(VehicleChassisVisuals.ClientWheelData<Snowmobile> wheelData) { }

	private void UpdateSuspensionSounds() { }

	public override void OnClientTickStopped() { }

	protected override int GetNumEngines() { }

	public void .ctor() { }

}

