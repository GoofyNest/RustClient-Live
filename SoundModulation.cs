public class SoundModulation : MonoBehaviour, IClientComponent // TypeDefIndex: 9035
{	// Fields
	private const int parameterCount = 4;
	private Sound sound; // 0x18
	public List<List<SoundModulation.Modulator>> modulators; // 0x20
	private List<float> modulationValues; // 0x28

	// Methods

	// RVA: 0xA74E30 Offset: 0xA74230 VA: 0x180A74E30
	protected void Awake() { }

	// RVA: 0xA75210 Offset: 0xA74610 VA: 0x180A75210
	public void Init() { }

	// RVA: 0xA74F10 Offset: 0xA74310 VA: 0x180A74F10
	public void CalculateValues() { }

	// RVA: 0xA74C30 Offset: 0xA74030 VA: 0x180A74C30
	public void ApplyModulations(AudioSource source) { }

	// RVA: 0xA75110 Offset: 0xA74510 VA: 0x180A75110
	public SoundModulation.Modulator CreateModulator(SoundModulation.Parameter param) { }

	// RVA: 0xA74B60 Offset: 0xA73F60 VA: 0x180A74B60
	public void AddModulator(SoundModulation.Modulator mod) { }

	// RVA: 0xA75390 Offset: 0xA74790 VA: 0x180A75390
	public void RemoveModulator(SoundModulation.Modulator mod) { }

	// RVA: 0xA752D0 Offset: 0xA746D0 VA: 0x180A752D0
	public float ModulationValue(SoundModulation.Parameter param) { }

	// RVA: 0xA75440 Offset: 0xA74840 VA: 0x180A75440
	public void .ctor() { }

}

public enum SoundModulation.Parameter // TypeDefIndex: 9036
{	// Fields
	public int value__; // 0x0
	public const SoundModulation.Parameter Gain = 0;
	public const SoundModulation.Parameter Pitch = 1;
	public const SoundModulation.Parameter Spread = 2;
	public const SoundModulation.Parameter MaxDistance = 3;

}

public class SoundModulation.Modulator // TypeDefIndex: 9037
{	// Fields
	public SoundModulation.Parameter param; // 0x10
	public float value; // 0x14

	// Methods

	// RVA: 0xA6FB00 Offset: 0xA6EF00 VA: 0x180A6FB00
	public void .ctor() { }

}

