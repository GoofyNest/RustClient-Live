public class MailAddress // TypeDefIndex: 3037
{	// Fields
	private string address; // 0x10
	private string displayName; // 0x18
	private string host; // 0x20
	private string user; // 0x28
	private string to_string; // 0x30

	// Properties
	public string Address { get; }
	public string DisplayName { get; }

	// Methods

	// RVA: 0x13410E0 Offset: 0x13404E0 VA: 0x1813410E0
	public void .ctor(string address) { }

	// RVA: 0x1340FF0 Offset: 0x13403F0 VA: 0x181340FF0
	public void .ctor(string address, string displayName) { }

	[MonoTODOAttribute] // RVA: 0xB9810 Offset: 0xB8C10 VA: 0x1800B9810
	// RVA: 0x1340F00 Offset: 0x1340300 VA: 0x181340F00
	public void .ctor(string address, string displayName, Encoding displayNameEncoding) { }

	// RVA: 0x1340AF0 Offset: 0x133FEF0 VA: 0x181340AF0
	private void ParseAddress(string address) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Address() { }

	// RVA: 0x13411B0 Offset: 0x13405B0 VA: 0x1813411B0
	public string get_DisplayName() { }

	// RVA: 0x1340A40 Offset: 0x133FE40 VA: 0x181340A40 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1340AB0 Offset: 0x133FEB0 VA: 0x181340AB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1340E50 Offset: 0x1340250 VA: 0x181340E50 Slot: 3
	public override string ToString() { }

	// RVA: 0x13409F0 Offset: 0x133FDF0 VA: 0x1813409F0
	private static FormatException CreateFormatException() { }

}

