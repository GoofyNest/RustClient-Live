public class SoundModulation : MonoBehaviour, IClientComponent // TypeDefIndex: 9035
{	private const int parameterCount = 4;
	private Sound sound; // 0x18
	public List<List<SoundModulation.Modulator>> modulators; // 0x20
	private List<float> modulationValues; // 0x28


	protected void Awake() { }

	public void Init() { }

	public void CalculateValues() { }

	public void ApplyModulations(AudioSource source) { }

	public SoundModulation.Modulator CreateModulator(SoundModulation.Parameter param) { }

	public void AddModulator(SoundModulation.Modulator mod) { }

	public void RemoveModulator(SoundModulation.Modulator mod) { }

	public float ModulationValue(SoundModulation.Parameter param) { }

	public void .ctor() { }

}

public enum SoundModulation.Parameter // TypeDefIndex: 9036
{	public int value__; // 0x0
	public const SoundModulation.Parameter Gain = 0;
	public const SoundModulation.Parameter Pitch = 1;
	public const SoundModulation.Parameter Spread = 2;
	public const SoundModulation.Parameter MaxDistance = 3;

}

public class SoundModulation.Modulator // TypeDefIndex: 9037
{	public SoundModulation.Parameter param; // 0x10
	public float value; // 0x14


	public void .ctor() { }

}

