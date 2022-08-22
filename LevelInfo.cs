public class LevelInfo : SingletonComponent<LevelInfo> // TypeDefIndex: 9961
{	public string shortName; // 0x18
	public string displayName; // 0x20
	[TextAreaAttribute] // RVA: 0x72060 Offset: 0x71460 VA: 0x180072060
	public string description; // 0x28
	[TooltipAttribute] // RVA: 0xAA7B0 Offset: 0xA9BB0 VA: 0x1800AA7B0
	public Texture2D image; // 0x30
	[SpaceAttribute] // RVA: 0xAA850 Offset: 0xA9C50 VA: 0x1800AA850
	[TooltipAttribute] // RVA: 0xAA850 Offset: 0xA9C50 VA: 0x1800AA850
	public int version; // 0x38


	public void .ctor() { }

}

