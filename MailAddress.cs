public class MailAddress // TypeDefIndex: 3037
{
	private string address; 
	private string displayName; 
	private string host; 
	private string user; 
	private string to_string; 

public string Address { get; }
public string DisplayName { get; }


public void .ctor(string address) { }

public void .ctor(string address, string displayName) { }

	[MonoTODOAttribute] 
public void .ctor(string address, string displayName, Encoding displayNameEncoding) { }

private void ParseAddress(string address) { }

public string get_Address() { }

public string get_DisplayName() { }

public override bool Equals(object value) { }

public override int GetHashCode() { }

public override string ToString() { }

private static FormatException CreateFormatException() { }

}

