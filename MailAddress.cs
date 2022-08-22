public class MailAddress // TypeDefIndex: 3037
{	private string address; // 0x10
	private string displayName; // 0x18
	private string host; // 0x20
	private string user; // 0x28
	private string to_string; // 0x30

	public string Address { get; }
	public string DisplayName { get; }


	public void .ctor(string address) { }

	public void .ctor(string address, string displayName) { }

	[MonoTODOAttribute] // RVA: 0xB9810 Offset: 0xB8C10 VA: 0x1800B9810
	public void .ctor(string address, string displayName, Encoding displayNameEncoding) { }

	private void ParseAddress(string address) { }

	public string get_Address() { }

	public string get_DisplayName() { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	private static FormatException CreateFormatException() { }

}

