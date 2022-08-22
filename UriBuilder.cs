public class UriBuilder // TypeDefIndex: 2564
{	private bool _changed; // 0x10
	private string _fragment; // 0x18
	private string _host; // 0x20
	private string _password; // 0x28
	private string _path; // 0x30
	private int _port; // 0x38
	private string _query; // 0x40
	private string _scheme; // 0x48
	private string _schemeDelimiter; // 0x50
	private Uri _uri; // 0x58
	private string _username; // 0x60

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

