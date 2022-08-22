public class Authorization // TypeDefIndex: 2870
{	private string m_Message; // 0x10
	private bool m_Complete; // 0x18
	internal string ModuleAuthenticationType; // 0x20

	public string Message { get; }
	public bool Complete { get; }


	public void .ctor(string token) { }

	public void .ctor(string token, bool finished) { }

	public string get_Message() { }

	public bool get_Complete() { }

}

