public abstract class GroundVehicleAudio : MonoBehaviour, IClientComponent // TypeDefIndex: 9711
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
	protected float CameraDistance { get; set; }
	protected bool inWater { get; set; }
	protected abstract EngineAudioSet EngineAudioSet { get; set; }
	public float engineRpm { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC10 Offset: 0x5DC010 VA: 0x1805DCC10
	protected float get_CameraDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCDF0 Offset: 0x5DC1F0 VA: 0x1805DCDF0
	private void set_CameraDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC86150 Offset: 0xC85550 VA: 0x180C86150
	protected bool get_inWater() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC86170 Offset: 0xC85570 VA: 0x180C86170
	private void set_inWater(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract EngineAudioSet get_EngineAudioSet();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void set_EngineAudioSet(EngineAudioSet value);

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC86140 Offset: 0xC85540 VA: 0x180C86140
	public float get_engineRpm() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC86160 Offset: 0xC85560 VA: 0x180C86160
	private void set_engineRpm(float value) { }

	// RVA: 0xC852A0 Offset: 0xC846A0 VA: 0x180C852A0 Slot: 6
	protected virtual void Awake() { }

	// RVA: 0xC852D0 Offset: 0xC846D0 VA: 0x180C852D0 Slot: 7
	public virtual void ClientTick() { }

	// RVA: 0xC85830 Offset: 0xC84C30 VA: 0x180C85830 Slot: 8
	public virtual void OnClientTickStopped() { }

	// RVA: -1 Offset: -1
	public void OnEngineStateChanged<T>(VehicleEngineController.EngineState<T> newState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1540AC0 Offset: 0x153FEC0 VA: 0x181540AC0
	|-GroundVehicleAudio.OnEngineStateChanged<GroundVehicle>
	|-GroundVehicleAudio.OnEngineStateChanged<object>
	*/

	// RVA: 0xC858E0 Offset: 0xC84CE0 VA: 0x180C858E0
	public void PlayLightsToggleSound() { }

	// RVA: 0xC85890 Offset: 0xC84C90 VA: 0x180C85890
	public void PlayEngineStartFailSound() { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract int GetNumEngines();

	// RVA: 0xC85930 Offset: 0xC84D30 VA: 0x180C85930
	private void StartEngineSounds() { }

	// RVA: 0xC85AC0 Offset: 0xC84EC0 VA: 0x180C85AC0
	private void StopEngineSounds() { }

	// RVA: 0xC85F40 Offset: 0xC85340 VA: 0x180C85F40
	private void UpdateWaterSounds() { }

	// RVA: 0xC85CE0 Offset: 0xC850E0 VA: 0x180C85CE0
	private void UpdateEngineSounds() { }

	// RVA: 0xC85800 Offset: 0xC84C00 VA: 0x180C85800
	private float GetWheelRPM() { }

	// RVA: 0xC85400 Offset: 0xC84800 VA: 0x180C85400
	private float GetEngineRPM() { }

	// RVA: 0xC85AF0 Offset: 0xC84EF0 VA: 0x180C85AF0
	private void UpdateBrakeSounds() { }

	// RVA: 0xC85A20 Offset: 0xC84E20 VA: 0x180C85A20
	private void StopBrakeSound() { }

	// RVA: 0xC852A0 Offset: 0xC846A0 VA: 0x180C852A0
	private void StopWaterSounds() { }

	// RVA: 0xC86120 Offset: 0xC85520 VA: 0x180C86120
	protected void .ctor() { }

}

