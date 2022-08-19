public class SoundDefinition : ScriptableObject // TypeDefIndex: 9026
{	// Fields
	public GameObjectRef template; // 0x18
	[HorizontalAttribute] // RVA: 0xC8DE0 Offset: 0xC81E0 VA: 0x1800C8DE0
	public List<WeightedAudioClip> weightedAudioClips; // 0x20
	public List<SoundDefinition.DistanceAudioClipList> distanceAudioClips; // 0x28
	public SoundClass soundClass; // 0x30
	public bool defaultToFirstPerson; // 0x38
	public bool loop; // 0x39
	public bool randomizeStartPosition; // 0x3A
	public bool useHighQualityFades; // 0x3B
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float volume; // 0x3C
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float volumeVariation; // 0x40
	[RangeAttribute] // RVA: 0xCDF10 Offset: 0xCD310 VA: 0x1800CDF10
	public float pitch; // 0x44
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float pitchVariation; // 0x48
	[HeaderAttribute] // RVA: 0xCE0A0 Offset: 0xCD4A0 VA: 0x1800CE0A0
	public bool dontVoiceLimit; // 0x4C
	public int globalVoiceMaxCount; // 0x50
	public int localVoiceMaxCount; // 0x54
	public float localVoiceRange; // 0x58
	public float voiceLimitFadeOutTime; // 0x5C
	public float localVoiceDebounceTime; // 0x60
	[HeaderAttribute] // RVA: 0xCD6A0 Offset: 0xCCAA0 VA: 0x1800CD6A0
	public bool forceOccludedPlayback; // 0x64
	[HeaderAttribute] // RVA: 0xCF5F0 Offset: 0xCE9F0 VA: 0x1800CF5F0
	public bool enableDoppler; // 0x65
	public float dopplerAmount; // 0x68
	public float dopplerScale; // 0x6C
	public float dopplerAdjustmentRate; // 0x70
	[HeaderAttribute] // RVA: 0xCF810 Offset: 0xCEC10 VA: 0x1800CF810
	public AnimationCurve falloffCurve; // 0x78
	public bool useCustomFalloffCurve; // 0x80
	public AnimationCurve spatialBlendCurve; // 0x88
	public bool useCustomSpatialBlendCurve; // 0x90
	public AnimationCurve spreadCurve; // 0x98
	public bool useCustomSpreadCurve; // 0xA0

	// Properties
	public float maxDistance { get; }

	// Methods

	// RVA: 0xA70700 Offset: 0xA6FB00 VA: 0x180A70700
	public float get_maxDistance() { }

	// RVA: 0xA70310 Offset: 0xA6F710 VA: 0x180A70310
	public float GetLength() { }

	// RVA: 0xA705C0 Offset: 0xA6F9C0 VA: 0x180A705C0
	public Sound Play() { }

	// RVA: 0xA70580 Offset: 0xA6F980 VA: 0x180A70580
	public Sound Play(GameObject forGameObject) { }

	// RVA: 0xA701D0 Offset: 0xA6F5D0 VA: 0x180A701D0
	public AudioClip GetClip() { }

	// RVA: 0xA70600 Offset: 0xA6FA00 VA: 0x180A70600
	public void .ctor() { }

}

public class SoundDefinition.DistanceAudioClipList // TypeDefIndex: 9027
{	// Fields
	public int distance; // 0x10
	[HorizontalAttribute] // RVA: 0xC8DE0 Offset: 0xC81E0 VA: 0x1800C8DE0
	public List<WeightedAudioClip> audioClips; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

