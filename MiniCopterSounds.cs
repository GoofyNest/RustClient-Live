public class MiniCopterSounds : MonoBehaviour, IClientComponent // TypeDefIndex: 10012
{
	public MiniCopter miniCopter;
	public GameObject soundAttachPoint;
	public SoundDefinition engineStartDef;
	public SoundDefinition engineLoopDef;
	public SoundDefinition engineStopDef;
	public SoundDefinition rotorLoopDef;
	public float engineStartFadeOutTime;
	public float engineLoopFadeInTime;
	public float engineLoopFadeOutTime;
	public float engineStopFadeOutTime;
	public float rotorLoopFadeInTime;
	public float rotorLoopFadeOutTime;
	public float enginePitchInterpRate;
	public float rotorPitchInterpRate;
	public float rotorGainInterpRate;
	public float rotorStartStopPitchRateUp;
	public float rotorStartStopPitchRateDown;
	public float rotorStartStopGainRateUp;
	public float rotorStartStopGainRateDown;
	public AnimationCurve engineUpDotPitchCurve;
	public AnimationCurve rotorUpDotPitchCurve;
	private float rotorStartStopPitchMult;
	private float rotorStartStopGainMult;
	private Sound engineStart;
	private Sound engineStop;
	private Sound engineLoop;
	private SoundModulation.Modulator engineGain;
	private SoundModulation.Modulator enginePitch;
	private Sound rotorLoop;
	private SoundModulation.Modulator rotorGain;
	private SoundModulation.Modulator rotorPitch;
	private bool isOn;
	private bool wasOn;
	private bool isStartingUp;


	private void Update() { }

	public void .ctor() { }

}

