public class Type1Message : MessageBase // TypeDefIndex: 1731
{	// Fields
	private string _host; // 0x18
	private string _domain; // 0x20

	// Properties
	public string Domain { set; }
	public string Host { set; }

	// Methods

	// RVA: 0x1ABFB10 Offset: 0x1ABEF10 VA: 0x181ABFB10
	public void .ctor() { }

	// RVA: 0x1ABFBA0 Offset: 0x1ABEFA0 VA: 0x181ABFBA0
	public void set_Domain(string value) { }

	// RVA: 0x1ABFC20 Offset: 0x1ABF020 VA: 0x181ABFC20
	public void set_Host(string value) { }

	// RVA: 0x1ABF660 Offset: 0x1ABEA60 VA: 0x181ABF660 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1ABF780 Offset: 0x1ABEB80 VA: 0x181ABF780 Slot: 5
	public override byte[] GetBytes() { }

}

