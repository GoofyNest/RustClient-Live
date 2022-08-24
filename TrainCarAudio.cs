public class TrainCarAudio : MonoBehaviour // TypeDefIndex: 9767
{
	[SerializeField] 
	private TrainCar trainCar; 
	[SerializeField] 
	private SoundDefinition movementStartDef; 
	[SerializeField] 
	private SoundDefinition movementStopDef; 
	[SerializeField] 
	private SoundDefinition movementLoopDef; 
	[SerializeField] 
	private AnimationCurve movementLoopGainCurve; 
	[SerializeField] 
	private float movementChangeOneshotDebounce; 
	private Sound movementLoop; 
	private SoundModulation.Modulator movementLoopGain; 
	[SerializeField] 
	private SoundDefinition turnLoopDef; 
	private Sound turnLoop; 
	[SerializeField] 
	private SoundDefinition trackClatterLoopDef; 
	[SerializeField] 
	private AnimationCurve trackClatterGainCurve; 
	[SerializeField] 
	private AnimationCurve trackClatterPitchCurve; 
	private Sound trackClatterLoop; 
	private SoundModulation.Modulator trackClatterGain; 
	private SoundModulation.Modulator trackClatterPitch; 
	private float lastMovementChangeOneshot; 


	public void UpdateTick() { }

	public void StopAll() { }

	private void StopMovementLoops() { }

	private void StopTurnLoops() { }

	public void .ctor() { }

}

