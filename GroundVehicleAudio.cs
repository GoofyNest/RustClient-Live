public abstract class GroundVehicleAudio : MonoBehaviour, IClientComponent // TypeDefIndex: 11433
{
	[SerializeField] 
	protected GroundVehicle groundVehicle; 
	[HeaderAttribute] 
	[SerializeField] 
	private SoundDefinition engineStartSound; 
	[SerializeField] 
	private SoundDefinition engineStopSound; 
	[SerializeField] 
	private SoundDefinition engineStartFailSound; 
	[SerializeField] 
	private BlendedLoopEngineSound blendedEngineLoops; 
	[SerializeField] 
	private float wheelRatioMultiplier; 
	[HeaderAttribute] 
	[SerializeField] 
	private SoundDefinition waterSplashSoundDef; 
	[SerializeField] 
	private BlendedSoundLoops waterLoops; 
	[SerializeField] 
	private float waterSoundsMaxSpeed; 
	[HeaderAttribute] 
	[SerializeField] 
	private SoundDefinition brakeSoundDef; 
	[HeaderAttribute] 
	[SerializeField] 
	private SoundDefinition lightsToggleSound; 
	[CompilerGeneratedAttribute] 
	private float <CameraDistance>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <inWater>k__BackingField; 
	private Sound brakeSound; 
	private bool wasInWater; 
	[CompilerGeneratedAttribute] 
	private float <engineRpm>k__BackingField; 
	private float engineRpmDamp; 
	private float wheelsRpm; 
	private const float WHEELS_RPM_CHANGE_RATE_LIMIT = 400;
	private int gear; 
	private int prevGear; 

	protected float CameraDistance { get; set; }
	protected bool inWater { get; set; }
	protected abstract EngineAudioSet EngineAudioSet { get; set; }
	public float engineRpm { get; set; }


	[CompilerGeneratedAttribute] 
	protected float get_CameraDistance() { }

	[CompilerGeneratedAttribute] 
	private void set_CameraDistance(float value) { }

	[CompilerGeneratedAttribute] 
	protected bool get_inWater() { }

	[CompilerGeneratedAttribute] 
	private void set_inWater(bool value) { }

	protected abstract EngineAudioSet get_EngineAudioSet();

	protected abstract void set_EngineAudioSet(EngineAudioSet value);

	[CompilerGeneratedAttribute] 
	public float get_engineRpm() { }

	[CompilerGeneratedAttribute] 
	private void set_engineRpm(float value) { }

	protected virtual void Awake() { }

	public virtual void ClientTick() { }

	public virtual void OnClientTickStopped() { }

	public void OnEngineStateChanged<T>(VehicleEngineController.EngineState<T> newState) { }
	/* GenericInstMethod :
	|
	|-GroundVehicleAudio.OnEngineStateChanged<GroundVehicle>
	|-GroundVehicleAudio.OnEngineStateChanged<object>
	*/

	public void PlayLightsToggleSound() { }

	public void PlayEngineStartFailSound() { }

	protected abstract int GetNumEngines();

	private void StartEngineSounds() { }

	private void StopEngineSounds() { }

	private void UpdateWaterSounds() { }

	private void UpdateEngineSounds() { }

	private float GetWheelRPM() { }

	private float GetEngineRPM() { }

	private void UpdateBrakeSounds() { }

	private void StopBrakeSound() { }

	private void StopWaterSounds() { }

	protected void .ctor() { }

}

