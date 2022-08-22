public class ChallengeResponse : IDisposable // TypeDefIndex: 1725
{	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private byte[] _challenge; // 0x18
	private byte[] _lmpwd; // 0x20
	private byte[] _ntpwd; // 0x28

	public string Password { set; }
	public byte[] Challenge { set; }
	public byte[] LM { get; }
	public byte[] NT { get; }


	public void .ctor() { }

	public void .ctor(string password, byte[] challenge) { }

	protected override void Finalize() { }

	public void set_Password(string value) { }

	public void set_Challenge(byte[] value) { }

	public byte[] get_LM() { }

	public byte[] get_NT() { }

	public void Dispose() { }

	private void Dispose(bool disposing) { }

	private byte[] GetResponse(byte[] pwd) { }

	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	private byte[] PasswordToKey(string password, int position) { }

	private static void .cctor() { }

}

