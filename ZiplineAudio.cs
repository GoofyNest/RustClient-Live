public class ZiplineAudio : MonoBehaviour // TypeDefIndex: 8670
{
	public ZiplineMountable zipline; 
	public SoundDefinition movementLoopDef; 
	public SoundDefinition frictionLoopDef; 
	public SoundDefinition sparksLoopDef; 
	public AnimationCurve movementGainCurve; 
	public AnimationCurve movementPitchCurve; 
	public AnimationCurve frictionGainCurve; 
	public AnimationCurve sparksGainCurve; 
	private Sound movementLoop; 
	private SoundModulation.Modulator movementLoopGain; 
	private SoundModulation.Modulator movementLoopPitch; 
	private Sound frictionLoop; 
	private SoundModulation.Modulator frictionLoopGain; 
	private Sound sparksLoop; 
	private SoundModulation.Modulator sparksLoopGain; 
	private bool sparksActive; 


	private void Update() { }

	private void StartMovementLoop() { }

	private void StopMovementLoop() { }

	private void StartFrictionLoop() { }

	private void StopFrictionLoop() { }

	private void StartSparksLoop() { }

	private void StopSparksLoop() { }

	public void EnableSparksAudio(bool sparksEnabled) { }

	public void .ctor() { }

}

