public class OptionAttribute : Attribute // TypeDefIndex: 7063
{
	public Icons Icon; 
	public Translate.Phrase Label; 
	public string Value; 
	public bool Default; 


	public void .ctor(string token, string english, string value, bool isdefault = False, Icons icon = 0) { }

	public void .ctor(Icons icon, string value, bool isdefault = False) { }

	public Option GetOption() { }

}

