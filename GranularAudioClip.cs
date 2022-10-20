public class GranularAudioClip : MonoBehaviour // TypeDefIndex: 10709
{
	public AudioClip sourceClip; 
	private float[] sourceAudioData; 
	private int sourceChannels; 
	public AudioClip granularClip; 
	public int sampleRate; 
	public float sourceTime; 
	public float sourceTimeVariation; 
	public float grainAttack; 
	public float grainSustain; 
	public float grainRelease; 
	public float grainFrequency; 
	public int grainAttackSamples; 
	public int grainSustainSamples; 
	public int grainReleaseSamples; 
	public int grainFrequencySamples; 
	public int samplesUntilNextGrain; 
	public List<GranularAudioClip.Grain> grains; 
	private Random random; 
	private bool inited; 


	private void Update() { }

	private void RefreshCachedData() { }

	private void InitAudioClip() { }

	private void OnAudioRead(float[] data) { }

	private void SpawnGrain() { }

	private void CleanupFinishedGrains() { }

	public void .ctor() { }

}

public class GranularAudioClip.Grain // TypeDefIndex: 10710
{
	private float[] sourceData; 
	private int sourceDataLength; 
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

	public void .ctor() { }

}

