public class UriBuilder // TypeDefIndex: 2564
{	// Fields
	private bool _changed; // 0x10
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

	// Properties
	public string Host { set; }
	public string Path { set; }
	public string Query { set; }
	public string Scheme { set; }
	public Uri Uri { get; }

	// Methods

	// RVA: 0x22B1910 Offset: 0x22B0D10 VA: 0x1822B1910
	public void .ctor() { }

	// RVA: 0x22B1790 Offset: 0x22B0B90 VA: 0x1822B1790
	public void .ctor(Uri uri) { }

	// RVA: 0x22B0CD0 Offset: 0x22B00D0 VA: 0x1822B0CD0
	private void Init(Uri uri) { }

	// RVA: 0x22B1AE0 Offset: 0x22B0EE0 VA: 0x1822B1AE0
	public void set_Host(string value) { }

	// RVA: 0x22B1BB0 Offset: 0x22B0FB0 VA: 0x1822B1BB0
	public void set_Path(string value) { }

	// RVA: 0x22B1C60 Offset: 0x22B1060 VA: 0x1822B1C60
	public void set_Query(string value) { }

	// RVA: 0x22B1D00 Offset: 0x22B1100 VA: 0x1822B1D00
	public void set_Scheme(string value) { }

	// RVA: 0x22B1A40 Offset: 0x22B0E40 VA: 0x1822B1A40
	public Uri get_Uri() { }

	// RVA: 0x22B0C30 Offset: 0x22B0030 VA: 0x1822B0C30 Slot: 0
	public override bool Equals(object rparam) { }

	// RVA: 0x22B0CA0 Offset: 0x22B00A0 VA: 0x1822B0CA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x22B0EB0 Offset: 0x22B02B0 VA: 0x1822B0EB0
	private void SetFieldsFromUri(Uri uri) { }

	// RVA: 0x22B1070 Offset: 0x22B0470 VA: 0x1822B1070 Slot: 3
	public override string ToString() { }

}

