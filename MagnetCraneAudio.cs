public class MagnetCraneAudio : MonoBehaviour // TypeDefIndex: 11467
{
	public MagnetCrane crane; 
	[HeaderAttribute] 
	public SoundDefinition engineStartSoundDef; 
	public SoundDefinition engineStopSoundDef; 
	public BlendedLoopEngineSound engineLoops; 
	public SoundDefinition cabinRotationStartDef; 
	public SoundDefinition cabinRotationStopDef; 
	public SoundDefinition cabinRotationLoopDef; 
	private Sound cabinRotationLoop; 
	public SoundDefinition turningLoopDef; 
	private Sound turningLoop; 
	public SoundDefinition trackMovementLoopDef; 
	private Sound trackMovementLoop; 
	private SoundModulation.Modulator trackGainMod; 
	private SoundModulation.Modulator trackPitchMod; 
	public SoundDefinition armMovementLoopDef; 
	public SoundDefinition armMovementStartDef; 
	public SoundDefinition armMovementStopDef; 
	private Sound armMovementLoop01; 
	private SoundModulation.Modulator armMovementLoop01PitchMod; 
	public GameObject arm01SoundPosition; 
	public GameObject arm02SoundPosition; 
	private Sound armMovementLoop02; 
	private SoundModulation.Modulator armMovementLoop02PitchMod; 
	private bool wasEngineOn; 
	private Vector3 lastForward; 
	private float lastCabinYaw; 
	private float lastArm01; 
	private float lastArm02; 
	private float arm01Speed; 
	private float arm02Speed; 
	private float cabinYawSpeed; 
	private const float MIN_TIME_BETWEEN_ONESHOTS = 0,5;
	private TimeSince timeSinceLastCabinSound; 
	private TimeSince timeSinceLastArmSound; 


	protected void Awake() { }

	public void ClientTick() { }

	public void OnClientTickStopped() { }

	private void TryPlayOneshot(SoundDefinition soundDef, GameObject targetParent, ref TimeSince timeSinceLast) { }

	private void StopAll() { }

	public void .ctor() { }

}

