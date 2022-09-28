public class PreloadedCassetteContent : ScriptableObject // TypeDefIndex: 11123
{
	public SoundDefinition[] ShortTapeContent; 
	public SoundDefinition[] MediumTapeContent; 
	public SoundDefinition[] LongTapeContent; 


	public SoundDefinition GetSoundContent(int index, PreloadedCassetteContent.PreloadType type) { }

	private SoundDefinition GetDefinition(int index, SoundDefinition[] array) { }

	public SoundDefinition GetSoundContent(uint id) { }

	public void .ctor() { }

}

public enum PreloadedCassetteContent.PreloadType // TypeDefIndex: 11124
{
	public int value__; 
	public const PreloadedCassetteContent.PreloadType Short = 0;
	public const PreloadedCassetteContent.PreloadType Medium = 1;
	public const PreloadedCassetteContent.PreloadType Long = 2;

}

