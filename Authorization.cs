public class Authorization // TypeDefIndex: 2870
{
	private string m_Message; 
	private bool m_Complete; 
	internal string ModuleAuthenticationType; 

public string Message { get; }
public bool Complete { get; }


public void .ctor(string token) { }

public void .ctor(string token, bool finished) { }

public string get_Message() { }

public bool get_Complete() { }

}

