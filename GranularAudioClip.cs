public class GranularAudioClip : MonoBehaviour // TypeDefIndex: 8994
{	public AudioClip sourceClip; // 0x18
	private float[] sourceAudioData; // 0x20
	private int sourceChannels; // 0x28
	public AudioClip granularClip; // 0x30
	public int sampleRate; // 0x38
	public float sourceTime; // 0x3C
	public float sourceTimeVariation; // 0x40
	public float grainAttack; // 0x44
	public float grainSustain; // 0x48
	public float grainRelease; // 0x4C
	public float grainFrequency; // 0x50
	public int grainAttackSamples; // 0x54
	public int grainSustainSamples; // 0x58
	public int grainReleaseSamples; // 0x5C
	public int grainFrequencySamples; // 0x60
	public int samplesUntilNextGrain; // 0x64
	public List<GranularAudioClip.Grain> grains; // 0x68
	private Random random; // 0x70
	private bool inited; // 0x78


	private void Update() { }

	private void RefreshCachedData() { }

	private void InitAudioClip() { }

	private void OnAudioRead(float[] data) { }

	private void SpawnGrain() { }

	private void CleanupFinishedGrains() { }

	public void .ctor() { }

}

public class GranularAudioClip.Grain // TypeDefIndex: 8995
{	private float[] sourceData; // 0x10
	private int sourceDataLength; // 0x18
	private int startSample; // 0x1C
	private int currentSample; // 0x20
	private int attackTimeSamples; // 0x24
	private int sustainTimeSamples; // 0x28
	private int releaseTimeSamples; // 0x2C
	private float gain; // 0x30
	private float gainPerSampleAttack; // 0x34
	private float gainPerSampleRelease; // 0x38
	private int attackEndSample; // 0x3C
	private int releaseStartSample; // 0x40
	private int endSample; // 0x44

	public bool finished { get; }


	public bool get_finished() { }

	public void Init(float[] source, int start, int attack, int sustain, int release) { }

	public float GetSample() { }

	public void .ctor() { }

}

