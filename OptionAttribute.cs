public class OptionAttribute : Attribute // TypeDefIndex: 7028
{	public Icons Icon; // 0x10
	public Translate.Phrase Label; // 0x18
	public string Value; // 0x20
	public bool Default; // 0x28


	public void .ctor(string token, string english, string value, bool isdefault = False, Icons icon = 0) { }

	public void .ctor(Icons icon, string value, bool isdefault = False) { }

	public Option GetOption() { }

}

