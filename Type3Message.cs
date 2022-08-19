public class Type3Message : MessageBase // TypeDefIndex: 1733
{	// Fields
	private NtlmAuthLevel _level; // 0x18
	private byte[] _challenge; // 0x20
	private string _host; // 0x28
	private string _domain; // 0x30
	private string _username; // 0x38
	private string _password; // 0x40
	private Type2Message _type2; // 0x48
	private byte[] _lm; // 0x50
	private byte[] _nt; // 0x58

	// Properties
	public string Domain { set; }
	public string Password { set; }
	public string Username { set; }

	// Methods

	// RVA: 0x1AC1180 Offset: 0x1AC0580 VA: 0x181AC1180
	public void .ctor(Type2Message type2) { }

	// RVA: 0x1AC0560 Offset: 0x1ABF960 VA: 0x181AC0560 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AC13D0 Offset: 0x1AC07D0 VA: 0x181AC13D0
	public void set_Domain(string value) { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	public void set_Password(string value) { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_Username(string value) { }

	// RVA: 0x1AC0210 Offset: 0x1ABF610 VA: 0x181AC0210 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1AC01A0 Offset: 0x1ABF5A0 VA: 0x181AC01A0
	private string DecodeString(byte[] buffer, int offset, int len) { }

	// RVA: 0x1AC04D0 Offset: 0x1ABF8D0 VA: 0x181AC04D0
	private byte[] EncodeString(string text) { }

	// RVA: 0x1AC0630 Offset: 0x1ABFA30 VA: 0x181AC0630 Slot: 5
	public override byte[] GetBytes() { }

}

