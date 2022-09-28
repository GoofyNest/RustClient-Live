public class SoundClass : ScriptableObject // TypeDefIndex: 10696
{
	[HeaderAttribute] 
	public AudioMixerGroup output; 
	public AudioMixerGroup firstPersonOutput; 
	[HeaderAttribute] 
	public bool enableOcclusion; 
	public bool playIfOccluded; 
	public float occlusionGain; 
	[TooltipAttribute] 
	public AudioMixerGroup occludedOutput; 
	[HeaderAttribute] 
	public int globalVoiceMaxCount; 
	public int priority; 
	public List<SoundDefinition> definitions; 


	public void .ctor() { }

}

