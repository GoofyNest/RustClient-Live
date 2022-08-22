public class PreloadedCassetteContent : ScriptableObject // TypeDefIndex: 9451
{	public SoundDefinition[] ShortTapeContent; // 0x18
	public SoundDefinition[] MediumTapeContent; // 0x20
	public SoundDefinition[] LongTapeContent; // 0x28


	public SoundDefinition GetSoundContent(int index, PreloadedCassetteContent.PreloadType type) { }

	private SoundDefinition GetDefinition(int index, SoundDefinition[] array) { }

	public SoundDefinition GetSoundContent(uint id) { }

	public void .ctor() { }

}

public enum PreloadedCassetteContent.PreloadType // TypeDefIndex: 9452
{	public int value__; // 0x0
	public const PreloadedCassetteContent.PreloadType Short = 0;
	public const PreloadedCassetteContent.PreloadType Medium = 1;
	public const PreloadedCassetteContent.PreloadType Long = 2;

}

