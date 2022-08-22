public class SlicedGranularAudioClip : MonoBehaviour, IClientComponent // TypeDefIndex: 9021
{	public AudioClip sourceClip; // 0x18
	public AudioClip granularClip; // 0x20
	public int sampleRate; // 0x28
	public float grainAttack; // 0x2C
	public float grainSustain; // 0x30
	public float grainRelease; // 0x34
	public float grainFrequency; // 0x38
	public int grainAttackSamples; // 0x3C
	public int grainSustainSamples; // 0x40
	public int grainReleaseSamples; // 0x44
	public int grainFrequencySamples; // 0x48
	public int samplesUntilNextGrain; // 0x4C
	public List<SlicedGranularAudioClip.Grain> grains; // 0x50
	public List<int> startPositions; // 0x58
	public int lastStartPositionIdx; // 0x60
	private float[] sourceAudioData; // 0x68
	private int sourceChannels; // 0x70
	private AudioSource source; // 0x78
	private bool audioDataLoaded; // 0x80
	private Random random; // 0x88


	private void Awake() { }

	private void Update() { }

	private void RefreshCachedData() { }

	private void InitAudioClip() { }

	private void OnAudioRead(float[] data) { }

	private void SpawnGrain() { }

	private void CleanupFinishedGrains() { }

	public void .ctor() { }

}

public class SlicedGranularAudioClip.Grain // TypeDefIndex: 9022
{	private float[] sourceData; // 0x10
	private int startSample; // 0x18
	private int currentSample; // 0x1C
	private int attackTimeSamples; // 0x20
	private int sustainTimeSamples; // 0x24
	private int releaseTimeSamples; // 0x28
	private float gain; // 0x2C
	private float gainPerSampleAttack; // 0x30
	private float gainPerSampleRelease; // 0x34
	private int attackEndSample; // 0x38
	private int releaseStartSample; // 0x3C
	private int endSample; // 0x40

	public bool finished { get; }


	public bool get_finished() { }

	public void Init(float[] source, int start, int attack, int sustain, int release) { }

	public float GetSample() { }

	public void FadeOut() { }

	public void .ctor() { }

}

