public class PreloadedCassetteContent : ScriptableObject // TypeDefIndex: 9451
{	// Fields
	public SoundDefinition[] ShortTapeContent; // 0x18
	public SoundDefinition[] MediumTapeContent; // 0x20
	public SoundDefinition[] LongTapeContent; // 0x28

	// Methods

	// RVA: 0x987380 Offset: 0x986780 VA: 0x180987380
	public SoundDefinition GetSoundContent(int index, PreloadedCassetteContent.PreloadType type) { }

	// RVA: 0x9872F0 Offset: 0x9866F0 VA: 0x1809872F0
	private SoundDefinition GetDefinition(int index, SoundDefinition[] array) { }

	// RVA: 0x987520 Offset: 0x986920 VA: 0x180987520
	public SoundDefinition GetSoundContent(uint id) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public enum PreloadedCassetteContent.PreloadType // TypeDefIndex: 9452
{	// Fields
	public int value__; // 0x0
	public const PreloadedCassetteContent.PreloadType Short = 0;
	public const PreloadedCassetteContent.PreloadType Medium = 1;
	public const PreloadedCassetteContent.PreloadType Long = 2;

}

