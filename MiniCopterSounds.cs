public class MiniCopterSounds : MonoBehaviour, IClientComponent // TypeDefIndex: 8294
{	// Fields
	public MiniCopter miniCopter; // 0x18
	public GameObject soundAttachPoint; // 0x20
	public SoundDefinition engineStartDef; // 0x28
	public SoundDefinition engineLoopDef; // 0x30
	public SoundDefinition engineStopDef; // 0x38
	public SoundDefinition rotorLoopDef; // 0x40
	public float engineStartFadeOutTime; // 0x48
	public float engineLoopFadeInTime; // 0x4C
	public float engineLoopFadeOutTime; // 0x50
	public float engineStopFadeOutTime; // 0x54
	public float rotorLoopFadeInTime; // 0x58
	public float rotorLoopFadeOutTime; // 0x5C
	public float enginePitchInterpRate; // 0x60
	public float rotorPitchInterpRate; // 0x64
	public float rotorGainInterpRate; // 0x68
	public float rotorStartStopPitchRateUp; // 0x6C
	public float rotorStartStopPitchRateDown; // 0x70
	public float rotorStartStopGainRateUp; // 0x74
	public float rotorStartStopGainRateDown; // 0x78
	public AnimationCurve engineUpDotPitchCurve; // 0x80
	public AnimationCurve rotorUpDotPitchCurve; // 0x88
	private float rotorStartStopPitchMult; // 0x90
	private float rotorStartStopGainMult; // 0x94
	private Sound engineStart; // 0x98
	private Sound engineStop; // 0xA0
	private Sound engineLoop; // 0xA8
	private SoundModulation.Modulator engineGain; // 0xB0
	private SoundModulation.Modulator enginePitch; // 0xB8
	private Sound rotorLoop; // 0xC0
	private SoundModulation.Modulator rotorGain; // 0xC8
	private SoundModulation.Modulator rotorPitch; // 0xD0
	private bool isOn; // 0xD8
	private bool wasOn; // 0xD9
	private bool isStartingUp; // 0xDA

	// Methods

	// RVA: 0x762B80 Offset: 0x761F80 VA: 0x180762B80
	private void Update() { }

	// RVA: 0x763810 Offset: 0x762C10 VA: 0x180763810
	public void .ctor() { }

}

