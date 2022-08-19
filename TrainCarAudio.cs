public class TrainCarAudio : MonoBehaviour // TypeDefIndex: 9767
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TrainCar trainCar; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition movementStartDef; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition movementStopDef; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition movementLoopDef; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AnimationCurve movementLoopGainCurve; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float movementChangeOneshotDebounce; // 0x40
	private Sound movementLoop; // 0x48
	private SoundModulation.Modulator movementLoopGain; // 0x50
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition turnLoopDef; // 0x58
	private Sound turnLoop; // 0x60
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition trackClatterLoopDef; // 0x68
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AnimationCurve trackClatterGainCurve; // 0x70
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AnimationCurve trackClatterPitchCurve; // 0x78
	private Sound trackClatterLoop; // 0x80
	private SoundModulation.Modulator trackClatterGain; // 0x88
	private SoundModulation.Modulator trackClatterPitch; // 0x90
	private float lastMovementChangeOneshot; // 0x98

	// Methods

	// RVA: 0x9EA3A0 Offset: 0x9E97A0 VA: 0x1809EA3A0
	public void UpdateTick() { }

	// RVA: 0x9EA0F0 Offset: 0x9E94F0 VA: 0x1809EA0F0
	public void StopAll() { }

	// RVA: 0x9EA110 Offset: 0x9E9510 VA: 0x1809EA110
	private void StopMovementLoops() { }

	// RVA: 0x9EA300 Offset: 0x9E9700 VA: 0x1809EA300
	private void StopTurnLoops() { }

	// RVA: 0x9EA970 Offset: 0x9E9D70 VA: 0x1809EA970
	public void .ctor() { }

}

