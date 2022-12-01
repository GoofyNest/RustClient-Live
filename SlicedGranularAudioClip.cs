public class SlicedGranularAudioClip : MonoBehaviour, IClientComponent // TypeDefIndex: 10752
{
	public AudioClip sourceClip;
	public AudioClip granularClip;
	public int sampleRate;
	public float grainAttack;
	public float grainSustain;
	public float grainRelease;
	public float grainFrequency;
	public int grainAttackSamples;
	public int grainSustainSamples;
	public int grainReleaseSamples;
	public int grainFrequencySamples;
	public int samplesUntilNextGrain;
	public List<SlicedGranularAudioClip.Grain> grains;
	public List<int> startPositions;
	public int lastStartPositionIdx;
	private float[] sourceAudioData;
	private int sourceChannels;
	private AudioSource source;
	private bool audioDataLoaded;
	private Random random;


	private void Awake() { }

	private void Update() { }

	private void RefreshCachedData() { }

	private void InitAudioClip() { }

	private void OnAudioRead(float[] data) { }

	private void SpawnGrain() { }

	private void CleanupFinishedGrains() { }

	public void .ctor() { }

}

public class SlicedGranularAudioClip.Grain // TypeDefIndex: 10753
{
	private float[] sourceData;
	private int startSample;
	private int currentSample;
	private int attackTimeSamples;
	private int sustainTimeSamples;
	private int releaseTimeSamples;
	private float gain;
	private float gainPerSampleAttack;
	private float gainPerSampleRelease;
	private int attackEndSample;
	private int releaseStartSample;
	private int endSample;

	public bool finished { get; }


	public bool get_finished() { }

	public void Init(float[] source, int start, int attack, int sustain, int release) { }

	public float GetSample() { }

	public void FadeOut() { }

	public void .ctor() { }

}

