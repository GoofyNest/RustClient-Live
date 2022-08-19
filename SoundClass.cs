public class SoundClass : ScriptableObject // TypeDefIndex: 9024
{	// Fields
	[HeaderAttribute] // RVA: 0xCD5F0 Offset: 0xCC9F0 VA: 0x1800CD5F0
	public AudioMixerGroup output; // 0x18
	public AudioMixerGroup firstPersonOutput; // 0x20
	[HeaderAttribute] // RVA: 0xCD6A0 Offset: 0xCCAA0 VA: 0x1800CD6A0
	public bool enableOcclusion; // 0x28
	public bool playIfOccluded; // 0x29
	public float occlusionGain; // 0x2C
	[TooltipAttribute] // RVA: 0xCD890 Offset: 0xCCC90 VA: 0x1800CD890
	public AudioMixerGroup occludedOutput; // 0x30
	[HeaderAttribute] // RVA: 0xCD970 Offset: 0xCCD70 VA: 0x1800CD970
	public int globalVoiceMaxCount; // 0x38
	public int priority; // 0x3C
	public List<SoundDefinition> definitions; // 0x40

	// Methods

	// RVA: 0xA70140 Offset: 0xA6F540 VA: 0x180A70140
	public void .ctor() { }

}

