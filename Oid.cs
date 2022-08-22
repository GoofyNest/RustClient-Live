public sealed class Oid // TypeDefIndex: 2792
{	private string m_value; // 0x10
	private string m_friendlyName; // 0x18
	private OidGroup m_group; // 0x20

	public string Value { get; set; }
	public string FriendlyName { get; }


	public void .ctor() { }

	public void .ctor(string oid) { }

	internal void .ctor(string oid, OidGroup group, bool lookupFriendlyName) { }

	public void .ctor(string value, string friendlyName) { }

	public void .ctor(Oid oid) { }

	public string get_Value() { }

	public void set_Value(string value) { }

	public string get_FriendlyName() { }

}

