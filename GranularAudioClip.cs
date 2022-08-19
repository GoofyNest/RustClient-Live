public class GranularAudioClip : MonoBehaviour // TypeDefIndex: 8994
{	// Fields
	public AudioClip sourceClip; // 0x18
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

	// Methods

	// RVA: 0xC835C0 Offset: 0xC829C0 VA: 0x180C835C0
	private void Update() { }

	// RVA: 0xC832C0 Offset: 0xC826C0 VA: 0x180C832C0
	private void RefreshCachedData() { }

	// RVA: 0xC82FC0 Offset: 0xC823C0 VA: 0x180C82FC0
	private void InitAudioClip() { }

	// RVA: 0xC83100 Offset: 0xC82500 VA: 0x180C83100
	private void OnAudioRead(float[] data) { }

	// RVA: 0xC833C0 Offset: 0xC827C0 VA: 0x180C833C0
	private void SpawnGrain() { }

	// RVA: 0xC82EB0 Offset: 0xC822B0 VA: 0x180C82EB0
	private void CleanupFinishedGrains() { }

	// RVA: 0xC83900 Offset: 0xC82D00 VA: 0x180C83900
	public void .ctor() { }

}

public class GranularAudioClip.Grain // TypeDefIndex: 8995
{	// Fields
	private float[] sourceData; // 0x10
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

	// Properties
	public bool finished { get; }

	// Methods

	// RVA: 0xC82EA0 Offset: 0xC822A0 VA: 0x180C82EA0
	public bool get_finished() { }

	// RVA: 0xC82DE0 Offset: 0xC821E0 VA: 0x180C82DE0
	public void Init(float[] source, int start, int attack, int sustain, int release) { }

	// RVA: 0xC82D40 Offset: 0xC82140 VA: 0x180C82D40
	public float GetSample() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

