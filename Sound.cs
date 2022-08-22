public class Sound : MonoBehaviour, IClientComponent, IOnParentDestroying, IComparable<Sound>, ISoundBudgetedUpdate // TypeDefIndex: 9023
{	public static float volumeExponent; // 0x0
	public SoundDefinition definition; // 0x18
	public SoundModifier[] modifiers; // 0x20
	public SoundSource soundSource; // 0x28
	public AudioSource[] audioSources; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundFade _fade; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundModulation _modulation; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundOcclusion _occlusion; // 0x48
	private AudioSource audioSource; // 0x50
	private AudioSource distantAudioSource; // 0x58
	private Sound syncParent; // 0x60
	private Sound syncChild; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <initialMaxDistance>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <initialSpread>k__BackingField; // 0x74
	public bool playing; // 0x78
	public bool isFirstPerson; // 0x79
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <startTime>k__BackingField; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <endTime>k__BackingField; // 0x80
	private List<WeightedAudioClip> closeClips; // 0x88
	private List<WeightedAudioClip> farClips; // 0x90
	private float distanceScale; // 0x98
	private int clipIndex; // 0x9C
	private bool hasDistantSound; // 0xA0
	private float length; // 0xA4
	private int FrameUpdateIndex; // 0xA8
	private Vector3 previousPosition; // 0xAC
	private float previousPositionUpdateTime; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <basePitch>k__BackingField; // 0xBC
	private int priorityModifier; // 0xC0

	public SoundFade fade { get; }
	public SoundModulation modulation { get; }
	public SoundOcclusion occlusion { get; }
	public float initialMaxDistance { get; set; }
	public float initialSpread { get; set; }
	public float audioSourceVolue { get; }
	public bool isAudioSourcePlaying { get; }
	public AudioClip audioClip { get; set; }
	public AudioClip distantAudioClip { get; set; }
	public int timeSamples { get; set; }
	public float pan { get; set; }
	public float maxDistance { get; }
	public float startTime { get; set; }
	public float endTime { get; set; }
	public float basePitch { get; set; }


	public SoundFade get_fade() { }

	public SoundModulation get_modulation() { }

	public SoundOcclusion get_occlusion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_initialMaxDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_initialMaxDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_initialSpread() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_initialSpread(float value) { }

	public float get_audioSourceVolue() { }

	public bool get_isAudioSourcePlaying() { }

	public AudioClip get_audioClip() { }

	public void set_audioClip(AudioClip value) { }

	public AudioClip get_distantAudioClip() { }

	public void set_distantAudioClip(AudioClip value) { }

	public int get_timeSamples() { }

	public void set_timeSamples(int value) { }

	public float get_pan() { }

	public void set_pan(float value) { }

	public float get_maxDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_startTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_startTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_endTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_endTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_basePitch() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_basePitch(float value) { }

	protected void Awake() { }

	public void Init(SoundSource source, float cameraDistance = 0) { }

	private void InitAudioSource(AudioSource source) { }

	private void OnDisable() { }

	public void DoUpdate() { }

	public void DoDoppler() { }

	public void DoDistantCrossfade() { }

	private void SetDistantVolumes() { }

	public void ApplyModulations() { }

	public void ApplyModifications() { }

	public void MakeThirdPerson() { }

	public void MakeThirdPerson(AudioSource source) { }

	public void MakeFirstPerson() { }

	public void MakeFirstPerson(AudioSource source) { }

	public float GetLength() { }

	public void CalcLength() { }

	public int CompareTo(Sound other) { }

	public void Play() { }

	public void PlayAudioSources() { }

	public void PlayAudioSource(AudioSource source) { }

	public void SyncTo(Sound other) { }

	public void StopSyncing() { }

	public void Stop() { }

	public void Pause() { }

	public void UnPause() { }

	public void SetPlaybackPercent(float percent) { }

	public void RecycleAfterPlaying() { }

	public void StopAndRecycle(float delay = 0) { }

	public void SetClipIndex(int i) { }

	public void FadeInAndPlay(float time) { }

	public void FadeOutAndRecycle(float time) { }

	public bool isOutputVolumeAudible() { }

	public void DisconnectFromParent() { }

	public void OnParentDestroying() { }

	public void SetCustomFalloffCurve(AnimationCurve curve) { }

	public void SetCustomSpatialBlendCurve(AnimationCurve curve) { }

	public void SetCustomSpreadCurve(AnimationCurve curve) { }

	public bool IsSyncedToParent() { }

	private void UpdatePriority(float distance) { }

	public void SetPriorityModifier(int priority) { }

	public void .ctor() { }

	private static void .cctor() { }

}

