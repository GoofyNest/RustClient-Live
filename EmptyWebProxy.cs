internal sealed class EmptyWebProxy : IWebProxy // TypeDefIndex: 2932
{	// Fields
	private ICredentials m_credentials; // 0x10

	// Properties
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0 Slot: 4
	public Uri GetProxy(Uri uri) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 5
	public bool IsBypassed(Uri uri) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 6
	public ICredentials get_Credentials() { }

}

