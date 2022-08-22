public class ZiplineAudio : MonoBehaviour // TypeDefIndex: 8670
{	public ZiplineMountable zipline; // 0x18
	public SoundDefinition movementLoopDef; // 0x20
	public SoundDefinition frictionLoopDef; // 0x28
	public SoundDefinition sparksLoopDef; // 0x30
	public AnimationCurve movementGainCurve; // 0x38
	public AnimationCurve movementPitchCurve; // 0x40
	public AnimationCurve frictionGainCurve; // 0x48
	public AnimationCurve sparksGainCurve; // 0x50
	private Sound movementLoop; // 0x58
	private SoundModulation.Modulator movementLoopGain; // 0x60
	private SoundModulation.Modulator movementLoopPitch; // 0x68
	private Sound frictionLoop; // 0x70
	private SoundModulation.Modulator frictionLoopGain; // 0x78
	private Sound sparksLoop; // 0x80
	private SoundModulation.Modulator sparksLoopGain; // 0x88
	private bool sparksActive; // 0x90


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

