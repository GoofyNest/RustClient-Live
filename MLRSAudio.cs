public class MLRSAudio : MonoBehaviour // TypeDefIndex: 11458
{
	[SerializeField] 
	private MLRS mlrs; 
	[SerializeField] 
	private Transform pitchTransform; 
	[SerializeField] 
	private Transform yawTransform; 
	[SerializeField] 
	private float pitchDeltaSmoothRate; 
	[SerializeField] 
	private float yawDeltaSmoothRate; 
	[SerializeField] 
	private float pitchDeltaThreshold; 
	[SerializeField] 
	private float yawDeltaThreshold; 
	private float lastPitch; 
	private float lastYaw; 
	private float pitchDelta; 
	private float yawDelta; 
	public SoundDefinition turretMovementStartDef; 
	public SoundDefinition turretMovementLoopDef; 
	public SoundDefinition turretMovementStopDef; 
	private Sound turretMovementLoop; 


	private void Awake() { }

	private void Update() { }

	private void UpdateTurretMovementSounds() { }

	public void .ctor() { }

}

