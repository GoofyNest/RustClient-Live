public class SoundDefinition : ScriptableObject // TypeDefIndex: 10698
{
	public GameObjectRef template; 
	[HorizontalAttribute] 
	public List<WeightedAudioClip> weightedAudioClips; 
	public List<SoundDefinition.DistanceAudioClipList> distanceAudioClips; 
	public SoundClass soundClass; 
	public bool defaultToFirstPerson; 
	public bool loop; 
	public bool randomizeStartPosition; 
	public bool useHighQualityFades; 
	[RangeAttribute] 
	public float volume; 
	[RangeAttribute] 
	public float volumeVariation; 
	[RangeAttribute] 
	public float pitch; 
	[RangeAttribute] 
	public float pitchVariation; 
	[HeaderAttribute] 
	public bool dontVoiceLimit; 
	public int globalVoiceMaxCount; 
	public int localVoiceMaxCount; 
	public float localVoiceRange; 
	public float voiceLimitFadeOutTime; 
	public float localVoiceDebounceTime; 
	[HeaderAttribute] 
	public bool forceOccludedPlayback; 
	[HeaderAttribute] 
	public bool enableDoppler; 
	public float dopplerAmount; 
	public float dopplerScale; 
	public float dopplerAdjustmentRate; 
	[HeaderAttribute] 
	public AnimationCurve falloffCurve; 
	public bool useCustomFalloffCurve; 
	public AnimationCurve spatialBlendCurve; 
	public bool useCustomSpatialBlendCurve; 
	public AnimationCurve spreadCurve; 
	public bool useCustomSpreadCurve; 

	public float maxDistance { get; }


	public float get_maxDistance() { }

	public float GetLength() { }

	public Sound Play() { }

	public Sound Play(GameObject forGameObject) { }

	public AudioClip GetClip() { }

	public void .ctor() { }

}

public class SoundDefinition.DistanceAudioClipList // TypeDefIndex: 10699
{
	public int distance; 
	[HorizontalAttribute] 
	public List<WeightedAudioClip> audioClips; 


	public void .ctor() { }

}

