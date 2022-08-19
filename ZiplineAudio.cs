public class ZiplineAudio : MonoBehaviour // TypeDefIndex: 8670
{	// Fields
	public ZiplineMountable zipline; // 0x18
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

	// Methods

	// RVA: 0x1A93F60 Offset: 0x1A93360 VA: 0x181A93F60
	private void Update() { }

	// RVA: 0x1A93A70 Offset: 0x1A92E70 VA: 0x181A93A70
	private void StartMovementLoop() { }

	// RVA: 0x1A93DE0 Offset: 0x1A931E0 VA: 0x181A93DE0
	private void StopMovementLoop() { }

	// RVA: 0x1A93930 Offset: 0x1A92D30 VA: 0x181A93930
	private void StartFrictionLoop() { }

	// RVA: 0x1A93D30 Offset: 0x1A93130 VA: 0x181A93D30
	private void StopFrictionLoop() { }

	// RVA: 0x1A93BE0 Offset: 0x1A92FE0 VA: 0x181A93BE0
	private void StartSparksLoop() { }

	// RVA: 0x1A93EA0 Offset: 0x1A932A0 VA: 0x181A93EA0
	private void StopSparksLoop() { }

	// RVA: 0x1183080 Offset: 0x1182480 VA: 0x181183080
	public void EnableSparksAudio(bool sparksEnabled) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

