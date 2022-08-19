public struct X509ChainStatus // TypeDefIndex: 2829
{	// Fields
	private X509ChainStatusFlags status; // 0x0
	private string info; // 0x8

	// Properties
	public X509ChainStatusFlags Status { get; set; }
	public string StatusInformation { set; }

	// Methods

	// RVA: 0x1F0B00 Offset: 0x1EFF00 VA: 0x1801F0B00
	internal void .ctor(X509ChainStatusFlags flag) { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public X509ChainStatusFlags get_Status() { }

	// RVA: 0xF3A80 Offset: 0xF2E80 VA: 0x1800F3A80
	public void set_Status(X509ChainStatusFlags value) { }

	// RVA: 0xF1390 Offset: 0xF0790 VA: 0x1800F1390
	public void set_StatusInformation(string value) { }

	// RVA: 0x14DBD50 Offset: 0x14DB150 VA: 0x1814DBD50
	internal static string GetInformation(X509ChainStatusFlags flags) { }

}

