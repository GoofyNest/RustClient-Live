public class Type3Message : MessageBase // TypeDefIndex: 1733
{
	private NtlmAuthLevel _level;
	private byte[] _challenge;
	private string _host;
	private string _domain;
	private string _username;
	private string _password;
	private Type2Message _type2;
	private byte[] _lm;
	private byte[] _nt;

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

