public class TrainEngineAudio : TrainCarAudio // TypeDefIndex: 11524
{
	[SerializeField]
	private TrainEngine trainEngine;
	[SerializeField]
	private Transform cockpitSoundPosition;
	[SerializeField]
	private Transform hornSoundPosition;
	[HeaderAttribute]
	[SerializeField]
	private SoundDefinition engineStartSound;
	[SerializeField]
	private SoundDefinition engineStopSound;
	[SerializeField]
	private SoundDefinition engineActiveLoopDef;
	[SerializeField]
	private AnimationCurve engineActiveLoopPitchCurve;
	[SerializeField]
	private float engineActiveLoopChangeSpeed;
	private Sound engineActiveLoop;
	private SoundModulation.Modulator engineActiveLoopPitch;
	[SerializeField]
	private BlendedLoopEngineSound engineLoops;
	[SerializeField]
	private TrainEngineAudio.EngineReflection[] engineReflections;
	[SerializeField]
	private LayerMask reflectionLayerMask;
	[SerializeField]
	private float reflectionMaxDistance;
	[SerializeField]
	private float reflectionGainChangeSpeed;
	[SerializeField]
	private float reflectionPositionChangeSpeed;
	[SerializeField]
	private float reflectionRayOffset;
	[HeaderAttribute]
	[SerializeField]
	private SoundDefinition hornLoop;
	[SerializeField]
	private SoundDefinition hornStart;
	[HeaderAttribute]
	[SerializeField]
	private SoundDefinition lightsToggleSound;
	[SerializeField]
	private SoundDefinition proximityAlertDef;
	private Sound proximityAlertSound;
	[SerializeField]
	private SoundDefinition damagedLoopDef;
	private Sound damagedLoop;
	[SerializeField]
	private SoundDefinition changeThrottleDef;
	[SerializeField]
	private SoundDefinition changeCouplingDef;
	[SerializeField]
	private SoundDefinition unloadableStartDef;
	[SerializeField]
	private SoundDefinition unloadableEndDef;
	[SerializeField]
	private GameObject bellObject;
	[SerializeField]
	private SoundDefinition bellRingDef;
	[SerializeField]
	private SoundPlayer brakeSound;
	private Nullable<VehicleEngineController.EngineState<TrainEngine>> engineState;
	private Sound activeHorn;


	public override void UpdateTick() { }

	public override void StopAll() { }

	public void PlayDamageSounds() { }

	public void StopDamageSounds() { }

	public void PlayThrottleSwitchSound() { }

	public void PlayCouplingChangedBeep() { }

	public void PlayLinedUpToUnloadBeep() { }

	public void PlayUnLinedUpToUnloadBeep() { }

	public void PlayBellDing() { }

	public void SetForEngineState(VehicleEngineController.EngineState<TrainEngine> newState) { }

	public void PlayLightsToggleSound() { }

	public void SetBrakeSound(bool braking) { }

	public void SetHornState(bool on) { }

	private void StopEngineSounds(bool withinEngineSoundDist) { }

	private void StartEngineSounds(bool withinEngineSoundDist) { }

	public void .ctor() { }

}

public class TrainEngineAudio.EngineReflection // TypeDefIndex: 11525
{
	public Vector3 direction;
	public Vector3 offset;
	public SoundDefinition soundDef;
	public Sound sound;
	public SoundModulation.Modulator pitchMod;
	public SoundModulation.Modulator gainMod;
	public float distance;


	public void .ctor() { }

}

