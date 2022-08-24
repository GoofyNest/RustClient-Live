internal class DigestHeaderParser // TypeDefIndex: 2992
{

internal class DigestHeaderParser 
	private string header; 
	private int length; 
	private int pos; 
	private static string[] keywords; 
	private string[] values; 

public string Realm { get; }
public string Opaque { get; }
public string Nonce { get; }
public string Algorithm { get; }
public string QOP { get; }


public void .ctor(string header) { }

public string get_Realm() { }

public string get_Opaque() { }

public string get_Nonce() { }

public string get_Algorithm() { }

public string get_QOP() { }

public bool Parse() { }

private void SkipWhitespace() { }

private string GetKey() { }

private bool GetKeywordAndValue(out string key, out string value) { }

private static void .cctor() { }

}

