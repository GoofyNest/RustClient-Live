public abstract class GroundVehicleAudio : MonoBehaviour, IClientComponent // TypeDefIndex: 9711
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected GroundVehicle groundVehicle; // 0x18
	[HeaderAttribute] // RVA: 0x87C50 Offset: 0x87050 VA: 0x180087C50
	[SerializeField] // RVA: 0x87C50 Offset: 0x87050 VA: 0x180087C50
	private SoundDefinition engineStartSound; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition engineStopSound; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition engineStartFailSound; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BlendedLoopEngineSound blendedEngineLoops; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float wheelRatioMultiplier; // 0x40
	[HeaderAttribute] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	[SerializeField] // RVA: 0x88380 Offset: 0x87780 VA: 0x180088380
	private SoundDefinition waterSplashSoundDef; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BlendedSoundLoops waterLoops; // 0x50
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float waterSoundsMaxSpeed; // 0x58
	[HeaderAttribute] // RVA: 0x88880 Offset: 0x87C80 VA: 0x180088880
	[SerializeField] // RVA: 0x88880 Offset: 0x87C80 VA: 0x180088880
	private SoundDefinition brakeSoundDef; // 0x60
	[HeaderAttribute] // RVA: 0x88AB0 Offset: 0x87EB0 VA: 0x180088AB0
	[SerializeField] // RVA: 0x88AB0 Offset: 0x87EB0 VA: 0x180088AB0
	private SoundDefinition lightsToggleSound; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <CameraDistance>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <inWater>k__BackingField; // 0x74
	private Sound brakeSound; // 0x78
	private bool wasInWater; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <engineRpm>k__BackingField; // 0x84
	private float engineRpmDamp; // 0x88
	private float wheelsRpm; // 0x8C
	private const float WHEELS_RPM_CHANGE_RATE_LIMIT = 400;
	private int gear; // 0x90
	private int prevGear; // 0x94

	protected float CameraDistance { get; set; }
	protected bool inWater { get; set; }
	protected abstract EngineAudioSet EngineAudioSet { get; set; }
	public float engineRpm { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected float get_CameraDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_CameraDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool get_inWater() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_inWater(bool value) { }

	protected abstract EngineAudioSet get_EngineAudioSet();

	protected abstract void set_EngineAudioSet(EngineAudioSet value);

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_engineRpm() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_engineRpm(float value) { }

	protected virtual void Awake() { }

	public virtual void ClientTick() { }

	public virtual void OnClientTickStopped() { }

	public void OnEngineStateChanged<T>(VehicleEngineController.EngineState<T> newState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1540AC0 Offset: 0x153FEC0 VA: 0x181540AC0
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

