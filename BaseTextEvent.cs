public abstract class BaseTextEvent : MetaEvent // TypeDefIndex: 7531
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Text>k__BackingField; // 0x20

	// Properties
	public string Text { get; set; }

	// Methods

	// RVA: 0x1390B10 Offset: 0x138FF10 VA: 0x181390B10
	public void .ctor(MidiEventType eventType) { }

	// RVA: 0x1390B40 Offset: 0x138FF40 VA: 0x181390B40
	public void .ctor(MidiEventType eventType, string text) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_Text() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_Text(string value) { }

	// RVA: 0x13909D0 Offset: 0x138FDD0 VA: 0x1813909D0 Slot: 6
	protected sealed override void ReadContent(MidiReader reader, ReadingSettings settings, int size) { }

}

