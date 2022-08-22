public class Type3Message : MessageBase // TypeDefIndex: 1733
{	private NtlmAuthLevel _level; // 0x18
	private byte[] _challenge; // 0x20
	private string _host; // 0x28
	private string _domain; // 0x30
	private string _username; // 0x38
	private string _password; // 0x40
	private Type2Message _type2; // 0x48
	private byte[] _lm; // 0x50
	private byte[] _nt; // 0x58

	public string Domain { set; }
	public string Password { set; }
	public string Username { set; }


	public void .ctor(Type2Message type2) { }

	protected override void Finalize() { }

	public void set_Domain(string value) { }

	public void set_Password(string value) { }

	public void set_Username(string value) { }

	protected override void Decode(byte[] message) { }

	private string DecodeString(byte[] buffer, int offset, int len) { }

	private byte[] EncodeString(string text) { }

	public override byte[] GetBytes() { }

}

