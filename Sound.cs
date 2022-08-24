public class Sound : MonoBehaviour, IClientComponent, IOnParentDestroying, IComparable<Sound>, ISoundBudgetedUpdate // TypeDefIndex: 9023
{
	public static float volumeExponent; 
	public SoundDefinition definition; 
	public SoundModifier[] modifiers; 
	public SoundSource soundSource; 
	public AudioSource[] audioSources; 
	[SerializeField] 
	private SoundFade _fade; 
	[SerializeField] 
	private SoundModulation _modulation; 
	[SerializeField] 
	private SoundOcclusion _occlusion; 
	private AudioSource audioSource; 
	private AudioSource distantAudioSource; 
	private Sound syncParent; 
	private Sound syncChild; 
	[CompilerGeneratedAttribute] 
	private float <initialMaxDistance>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <initialSpread>k__BackingField; 
	public bool playing; 
	public bool isFirstPerson; 
	[CompilerGeneratedAttribute] 
	private float <startTime>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <endTime>k__BackingField; 
	private List<WeightedAudioClip> closeClips; 
	private List<WeightedAudioClip> farClips; 
	private float distanceScale; 
	private int clipIndex; 
	private bool hasDistantSound; 
	private float length; 
	private int FrameUpdateIndex; 
	private Vector3 previousPosition; 
	private float previousPositionUpdateTime; 
	[CompilerGeneratedAttribute] 
	private float <basePitch>k__BackingField; 
	private int priorityModifier; 

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

	[CompilerGeneratedAttribute] 
	public float get_initialMaxDistance() { }

	[CompilerGeneratedAttribute] 
	private void set_initialMaxDistance(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_initialSpread() { }

	[CompilerGeneratedAttribute] 
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

	[CompilerGeneratedAttribute] 
	public float get_startTime() { }

	[CompilerGeneratedAttribute] 
	private void set_startTime(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_endTime() { }

	[CompilerGeneratedAttribute] 
	private void set_endTime(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_basePitch() { }

	[CompilerGeneratedAttribute] 
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

