public class SlicedGranularAudioClip : MonoBehaviour, IClientComponent // TypeDefIndex: 9021
{	// Fields
	public AudioClip sourceClip; // 0x18
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

	// Methods

	// RVA: 0x5C39C0 Offset: 0x5C2DC0 VA: 0x1805C39C0
	private void Awake() { }

	// RVA: 0x5C41B0 Offset: 0x5C35B0 VA: 0x1805C41B0
	private void Update() { }

	// RVA: 0x5C3F10 Offset: 0x5C3310 VA: 0x1805C3F10
	private void RefreshCachedData() { }

	// RVA: 0x5C3C10 Offset: 0x5C3010 VA: 0x1805C3C10
	private void InitAudioClip() { }

	// RVA: 0x5C3D50 Offset: 0x5C3150 VA: 0x1805C3D50
	private void OnAudioRead(float[] data) { }

	// RVA: 0x5C3FF0 Offset: 0x5C33F0 VA: 0x1805C3FF0
	private void SpawnGrain() { }

	// RVA: 0x5C3B00 Offset: 0x5C2F00 VA: 0x1805C3B00
	private void CleanupFinishedGrains() { }

	// RVA: 0x5C4550 Offset: 0x5C3950 VA: 0x1805C4550
	public void .ctor() { }

}

public class SlicedGranularAudioClip.Grain // TypeDefIndex: 9022
{	// Fields
	private float[] sourceData; // 0x10
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

	// Properties
	public bool finished { get; }

	// Methods

	// RVA: 0x5BE730 Offset: 0x5BDB30 VA: 0x1805BE730
	public bool get_finished() { }

	// RVA: 0x5BE690 Offset: 0x5BDA90 VA: 0x1805BE690
	public void Init(float[] source, int start, int attack, int sustain, int release) { }

	// RVA: 0x5BE5D0 Offset: 0x5BD9D0 VA: 0x1805BE5D0
	public float GetSample() { }

	// RVA: 0x5BE5C0 Offset: 0x5BD9C0 VA: 0x1805BE5C0
	public void FadeOut() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

