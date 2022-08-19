public class OptionAttribute : Attribute // TypeDefIndex: 7028
{	// Fields
	public Icons Icon; // 0x10
	public Translate.Phrase Label; // 0x18
	public string Value; // 0x20
	public bool Default; // 0x28

	// Methods

	// RVA: 0xFC17F0 Offset: 0xFC0BF0 VA: 0x180FC17F0
	public void .ctor(string token, string english, string value, bool isdefault = False, Icons icon = 0) { }

	// RVA: 0xFC1740 Offset: 0xFC0B40 VA: 0x180FC1740
	public void .ctor(Icons icon, string value, bool isdefault = False) { }

	// RVA: 0xFC16D0 Offset: 0xFC0AD0 VA: 0x180FC16D0
	public Option GetOption() { }

}

