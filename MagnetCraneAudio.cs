public class MagnetCraneAudio : MonoBehaviour // TypeDefIndex: 9731
{	public MagnetCrane crane; // 0x18
	[HeaderAttribute] // RVA: 0x8D650 Offset: 0x8CA50 VA: 0x18008D650
	public SoundDefinition engineStartSoundDef; // 0x20
	public SoundDefinition engineStopSoundDef; // 0x28
	public BlendedLoopEngineSound engineLoops; // 0x30
	public SoundDefinition cabinRotationStartDef; // 0x38
	public SoundDefinition cabinRotationStopDef; // 0x40
	public SoundDefinition cabinRotationLoopDef; // 0x48
	private Sound cabinRotationLoop; // 0x50
	public SoundDefinition turningLoopDef; // 0x58
	private Sound turningLoop; // 0x60
	public SoundDefinition trackMovementLoopDef; // 0x68
	private Sound trackMovementLoop; // 0x70
	private SoundModulation.Modulator trackGainMod; // 0x78
	private SoundModulation.Modulator trackPitchMod; // 0x80
	public SoundDefinition armMovementLoopDef; // 0x88
	public SoundDefinition armMovementStartDef; // 0x90
	public SoundDefinition armMovementStopDef; // 0x98
	private Sound armMovementLoop01; // 0xA0
	private SoundModulation.Modulator armMovementLoop01PitchMod; // 0xA8
	public GameObject arm01SoundPosition; // 0xB0
	public GameObject arm02SoundPosition; // 0xB8
	private Sound armMovementLoop02; // 0xC0
	private SoundModulation.Modulator armMovementLoop02PitchMod; // 0xC8
	private bool wasEngineOn; // 0xD0
	private Vector3 lastForward; // 0xD4
	private float lastCabinYaw; // 0xE0
	private float lastArm01; // 0xE4
	private float lastArm02; // 0xE8
	private float arm01Speed; // 0xEC
	private float arm02Speed; // 0xF0
	private float cabinYawSpeed; // 0xF4
	private const float MIN_TIME_BETWEEN_ONESHOTS = 0,5;
	private TimeSince timeSinceLastCabinSound; // 0xF8
	private TimeSince timeSinceLastArmSound; // 0xFC


	protected void Awake() { }

	public void ClientTick() { }

	public void OnClientTickStopped() { }

	private void TryPlayOneshot(SoundDefinition soundDef, GameObject targetParent, ref TimeSince timeSinceLast) { }

	private void StopAll() { }

	public void .ctor() { }

}

