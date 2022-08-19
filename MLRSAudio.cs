public class MLRSAudio : MonoBehaviour // TypeDefIndex: 9722
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Methods

	// RVA: 0x56BF80 Offset: 0x56B380 VA: 0x18056BF80
	private void Awake() { }

	// RVA: 0x56C360 Offset: 0x56B760 VA: 0x18056C360
	private void Update() { }

	// RVA: 0x56BFD0 Offset: 0x56B3D0 VA: 0x18056BFD0
	private void UpdateTurretMovementSounds() { }

	// RVA: 0x56C370 Offset: 0x56B770 VA: 0x18056C370
	public void .ctor() { }

}

