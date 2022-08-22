public class MLRSAudio : MonoBehaviour // TypeDefIndex: 9722
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MLRS mlrs; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform pitchTransform; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform yawTransform; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float pitchDeltaSmoothRate; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float yawDeltaSmoothRate; // 0x34
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float pitchDeltaThreshold; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float yawDeltaThreshold; // 0x3C
	private float lastPitch; // 0x40
	private float lastYaw; // 0x44
	private float pitchDelta; // 0x48
	private float yawDelta; // 0x4C
	public SoundDefinition turretMovementStartDef; // 0x50
	public SoundDefinition turretMovementLoopDef; // 0x58
	public SoundDefinition turretMovementStopDef; // 0x60
	private Sound turretMovementLoop; // 0x68


	private void Awake() { }

	private void Update() { }

	private void UpdateTurretMovementSounds() { }

	public void .ctor() { }

}

