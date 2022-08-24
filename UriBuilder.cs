public class UriBuilder // TypeDefIndex: 2564
{
	private bool _changed; 
	private string _fragment; 
	private string _host; 
	private string _password; 
	private string _path; 
	private int _port; 
	private string _query; 
	private string _scheme; 
	private string _schemeDelimiter; 
	private Uri _uri; 
	private string _username; 

public string Host { set; }
public string Path { set; }
public string Query { set; }
public string Scheme { set; }
public Uri Uri { get; }


public void .ctor() { }

public void .ctor(Uri uri) { }

private void Init(Uri uri) { }

public void set_Host(string value) { }

public void set_Path(string value) { }

public void set_Query(string value) { }

public void set_Scheme(string value) { }

public Uri get_Uri() { }

public override bool Equals(object rparam) { }

public override int GetHashCode() { }

private void SetFieldsFromUri(Uri uri) { }

public override string ToString() { }

}

