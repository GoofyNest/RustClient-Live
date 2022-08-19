public sealed class ObsoleteAttribute : Attribute // TypeDefIndex: 281
{	// Fields
	private string _message; // 0x10
	private bool _error; // 0x18

	// Properties
	public string Message { get; }

	// Methods

	// RVA: 0x167E570 Offset: 0x167D970 VA: 0x18167E570
	public void .ctor() { }

	// RVA: 0x167E530 Offset: 0x167D930 VA: 0x18167E530
	public void .ctor(string message) { }

	// RVA: 0x167E5A0 Offset: 0x167D9A0 VA: 0x18167E5A0
	public void .ctor(string message, bool error) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Message() { }

}

