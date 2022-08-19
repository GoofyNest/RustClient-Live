public sealed class Oid // TypeDefIndex: 2792
{	// Fields
	private string m_value; // 0x10
	private string m_friendlyName; // 0x18
	private OidGroup m_group; // 0x20

	// Properties
	public string Value { get; set; }
	public string FriendlyName { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1176ED0 Offset: 0x11762D0 VA: 0x181176ED0
	public void .ctor(string oid) { }

	// RVA: 0x1176F30 Offset: 0x1176330 VA: 0x181176F30
	internal void .ctor(string oid, OidGroup group, bool lookupFriendlyName) { }

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(string value, string friendlyName) { }

	// RVA: 0x1176FA0 Offset: 0x11763A0 VA: 0x181176FA0
	public void .ctor(Oid oid) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Value() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_Value(string value) { }

	// RVA: 0x1177040 Offset: 0x1176440 VA: 0x181177040
	public string get_FriendlyName() { }

}

