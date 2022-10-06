public abstract class BaseTextEvent : MetaEvent // TypeDefIndex: 7538
{
	[CompilerGeneratedAttribute] 
	private string <Text>k__BackingField; 

	public string Text { get; set; }


	public void .ctor(MidiEventType eventType) { }

	public void .ctor(MidiEventType eventType, string text) { }

	[CompilerGeneratedAttribute] 
	public string get_Text() { }

	[CompilerGeneratedAttribute] 
	public void set_Text(string value) { }

	protected sealed override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

}

