public class ChallengeResponse : IDisposable // TypeDefIndex: 1725
{	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private byte[] _challenge; // 0x18
	private byte[] _lmpwd; // 0x20
	private byte[] _ntpwd; // 0x28

	// Properties
	public string Password { set; }
	public byte[] Challenge { set; }
	public byte[] LM { get; }
	public byte[] NT { get; }

	// Methods

	// RVA: 0x1AAE1E0 Offset: 0x1AAD5E0 VA: 0x181AAE1E0
	public void .ctor() { }

	// RVA: 0x1AAE260 Offset: 0x1AAD660 VA: 0x181AAE260
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x1AAD900 Offset: 0x1AACD00 VA: 0x181AAD900 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AAE5B0 Offset: 0x1AAD9B0 VA: 0x181AAE5B0
	public void set_Password(string value) { }

	// RVA: 0x1AAE4B0 Offset: 0x1AAD8B0 VA: 0x181AAE4B0
	public void set_Challenge(byte[] value) { }

	// RVA: 0x1AAE3D0 Offset: 0x1AAD7D0 VA: 0x181AAE3D0
	public byte[] get_LM() { }

	// RVA: 0x1AAE440 Offset: 0x1AAD840 VA: 0x181AAE440
	public byte[] get_NT() { }

	// RVA: 0x1AAD7E0 Offset: 0x1AACBE0 VA: 0x181AAD7E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1AAD890 Offset: 0x1AACC90 VA: 0x181AAD890
	private void Dispose(bool disposing) { }

	// RVA: 0x1AADA40 Offset: 0x1AACE40 VA: 0x181AADA40
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x1AADDB0 Offset: 0x1AAD1B0 VA: 0x181AADDB0
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1AADC60 Offset: 0x1AAD060 VA: 0x181AADC60
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1AAE130 Offset: 0x1AAD530 VA: 0x181AAE130
	private static void .cctor() { }

}

