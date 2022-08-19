public class Sound : MonoBehaviour, IClientComponent, IOnParentDestroying, IComparable<Sound>, ISoundBudgetedUpdate // TypeDefIndex: 9023
{	// Fields
	public static float volumeExponent; // 0x0
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

	// Properties
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

	// Methods

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public SoundFade get_fade() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public SoundModulation get_modulation() { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public SoundOcclusion get_occlusion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC10 Offset: 0x5DC010 VA: 0x1805DCC10
	public float get_initialMaxDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCDF0 Offset: 0x5DC1F0 VA: 0x1805DCDF0
	private void set_initialMaxDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC20 Offset: 0x5DC020 VA: 0x1805DCC20
	public float get_initialSpread() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCE00 Offset: 0x5DC200 VA: 0x1805DCE00
	private void set_initialSpread(float value) { }

	// RVA: 0x5DCBA0 Offset: 0x5DBFA0 VA: 0x1805DCBA0
	public float get_audioSourceVolue() { }

	// RVA: 0x5DCC30 Offset: 0x5DC030 VA: 0x1805DCC30
	public bool get_isAudioSourcePlaying() { }

	// RVA: 0x5DCB80 Offset: 0x5DBF80 VA: 0x1805DCB80
	public AudioClip get_audioClip() { }

	// RVA: 0x5DCD90 Offset: 0x5DC190 VA: 0x1805DCD90
	public void set_audioClip(AudioClip value) { }

	// RVA: 0x5DCBD0 Offset: 0x5DBFD0 VA: 0x1805DCBD0
	public AudioClip get_distantAudioClip() { }

	// RVA: 0x5DCDC0 Offset: 0x5DC1C0 VA: 0x1805DCDC0
	public void set_distantAudioClip(AudioClip value) { }

	// RVA: 0x5DCCE0 Offset: 0x5DC0E0 VA: 0x1805DCCE0
	public int get_timeSamples() { }

	// RVA: 0x5DCE60 Offset: 0x5DC260 VA: 0x1805DCE60
	public void set_timeSamples(int value) { }

	// RVA: 0x5DCCB0 Offset: 0x5DC0B0 VA: 0x1805DCCB0
	public float get_pan() { }

	// RVA: 0x5DCE10 Offset: 0x5DC210 VA: 0x1805DCE10
	public void set_pan(float value) { }

	// RVA: 0x5DCC80 Offset: 0x5DC080 VA: 0x1805DCC80
	public float get_maxDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCCD0 Offset: 0x5DC0D0 VA: 0x1805DCCD0
	public float get_startTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x51B550 Offset: 0x51A950 VA: 0x18051B550
	private void set_startTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCBF0 Offset: 0x5DBFF0 VA: 0x1805DCBF0
	public float get_endTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCDE0 Offset: 0x5DC1E0 VA: 0x1805DCDE0
	private void set_endTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCBC0 Offset: 0x5DBFC0 VA: 0x1805DCBC0
	public float get_basePitch() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCDB0 Offset: 0x5DC1B0 VA: 0x1805DCDB0
	private void set_basePitch(float value) { }

	// RVA: 0x5D9780 Offset: 0x5D8B80 VA: 0x1805D9780
	protected void Awake() { }

	// RVA: 0x5DB020 Offset: 0x5DA420 VA: 0x1805DB020
	public void Init(SoundSource source, float cameraDistance = 0) { }

	// RVA: 0x5DAE60 Offset: 0x5DA260 VA: 0x1805DAE60
	private void InitAudioSource(AudioSource source) { }

	// RVA: 0x5DB690 Offset: 0x5DAA90 VA: 0x1805DB690
	private void OnDisable() { }

	// RVA: 0x5DA8E0 Offset: 0x5D9CE0 VA: 0x1805DA8E0 Slot: 6
	public void DoUpdate() { }

	// RVA: 0x5DA4C0 Offset: 0x5D98C0 VA: 0x1805DA4C0
	public void DoDoppler() { }

	// RVA: 0x5D9DA0 Offset: 0x5D91A0 VA: 0x1805D9DA0
	public void DoDistantCrossfade() { }

	// RVA: 0x5DC210 Offset: 0x5DB610 VA: 0x1805DC210
	private void SetDistantVolumes() { }

	// RVA: 0x5D9630 Offset: 0x5D8A30 VA: 0x1805D9630
	public void ApplyModulations() { }

	// RVA: 0x5D9500 Offset: 0x5D8900 VA: 0x1805D9500
	public void ApplyModifications() { }

	// RVA: 0x5DB5E0 Offset: 0x5DA9E0 VA: 0x1805DB5E0
	public void MakeThirdPerson() { }

	// RVA: 0x5DB580 Offset: 0x5DA980 VA: 0x1805DB580
	public void MakeThirdPerson(AudioSource source) { }

	// RVA: 0x5DB540 Offset: 0x5DA940 VA: 0x1805DB540
	public void MakeFirstPerson() { }

	// RVA: 0x5DB440 Offset: 0x5DA840 VA: 0x1805DB440
	public void MakeFirstPerson(AudioSource source) { }

	// RVA: 0x5DAE50 Offset: 0x5DA250 VA: 0x1805DAE50
	public float GetLength() { }

	// RVA: 0x5D9810 Offset: 0x5D8C10 VA: 0x1805D9810
	public void CalcLength() { }

	// RVA: 0x5D9CB0 Offset: 0x5D90B0 VA: 0x1805D9CB0 Slot: 5
	public int CompareTo(Sound other) { }

	// RVA: 0x5DBAC0 Offset: 0x5DAEC0 VA: 0x1805DBAC0
	public void Play() { }

	// RVA: 0x5DB920 Offset: 0x5DAD20 VA: 0x1805DB920
	public void PlayAudioSources() { }

	// RVA: 0x5DB890 Offset: 0x5DAC90 VA: 0x1805DB890
	public void PlayAudioSource(AudioSource source) { }

	// RVA: 0x5DC7A0 Offset: 0x5DBBA0 VA: 0x1805DC7A0
	public void SyncTo(Sound other) { }

	// RVA: 0x5DC540 Offset: 0x5DB940 VA: 0x1805DC540
	public void StopSyncing() { }

	// RVA: 0x5DC650 Offset: 0x5DBA50 VA: 0x1805DC650
	public void Stop() { }

	// RVA: 0x5DB840 Offset: 0x5DAC40 VA: 0x1805DB840
	public void Pause() { }

	// RVA: 0x5DC7F0 Offset: 0x5DBBF0 VA: 0x1805DC7F0
	public void UnPause() { }

	// RVA: 0x5DC3B0 Offset: 0x5DB7B0 VA: 0x1805DC3B0
	public void SetPlaybackPercent(float percent) { }

	// RVA: 0x5DBE50 Offset: 0x5DB250 VA: 0x1805DBE50
	public void RecycleAfterPlaying() { }

	// RVA: 0x5DC510 Offset: 0x5DB910 VA: 0x1805DC510
	public void StopAndRecycle(float delay = 0) { }

	// RVA: 0x5DBE70 Offset: 0x5DB270 VA: 0x1805DBE70
	public void SetClipIndex(int i) { }

	// RVA: 0x5DAD50 Offset: 0x5DA150 VA: 0x1805DAD50
	public void FadeInAndPlay(float time) { }

	// RVA: 0x5DAD80 Offset: 0x5DA180 VA: 0x1805DAD80
	public void FadeOutAndRecycle(float time) { }

	// RVA: 0x5DCD00 Offset: 0x5DC100 VA: 0x1805DCD00
	public bool isOutputVolumeAudible() { }

	// RVA: 0x5D9CF0 Offset: 0x5D90F0 VA: 0x1805D9CF0
	public void DisconnectFromParent() { }

	// RVA: 0x5DB700 Offset: 0x5DAB00 VA: 0x1805DB700 Slot: 4
	public void OnParentDestroying() { }

	// RVA: 0x5DBE80 Offset: 0x5DB280 VA: 0x1805DBE80
	public void SetCustomFalloffCurve(AnimationCurve curve) { }

	// RVA: 0x5DBFB0 Offset: 0x5DB3B0 VA: 0x1805DBFB0
	public void SetCustomSpatialBlendCurve(AnimationCurve curve) { }

	// RVA: 0x5DC0E0 Offset: 0x5DB4E0 VA: 0x1805DC0E0
	public void SetCustomSpreadCurve(AnimationCurve curve) { }

	// RVA: 0x5DB3E0 Offset: 0x5DA7E0 VA: 0x1805DB3E0 Slot: 7
	public bool IsSyncedToParent() { }

	// RVA: 0x5DC840 Offset: 0x5DBC40 VA: 0x1805DC840
	private void UpdatePriority(float distance) { }

	// RVA: 0x5DC450 Offset: 0x5DB850 VA: 0x1805DC450
	public void SetPriorityModifier(int priority) { }

	// RVA: 0x5DCAC0 Offset: 0x5DBEC0 VA: 0x1805DCAC0
	public void .ctor() { }

	// RVA: 0x5DCA40 Offset: 0x5DBE40 VA: 0x1805DCA40
	private static void .cctor() { }

}

