internal class TermInfoReader // TypeDefIndex: 399
{	// Fields
	private short boolSize; // 0x10
	private short numSize; // 0x12
	private short strOffsets; // 0x14
	private byte[] buffer; // 0x18
	private int booleansOffset; // 0x20

	// Methods

	// RVA: 0x18BD6C0 Offset: 0x18BCAC0 VA: 0x1818BD6C0
	public void .ctor(string term, string filename) { }

	// RVA: 0x18BD600 Offset: 0x18BCA00 VA: 0x1818BD600
	public void .ctor(string term, byte[] buffer) { }

	// RVA: 0x18BD250 Offset: 0x18BC650 VA: 0x1818BD250
	private void ReadHeader(byte[] buffer, ref int position) { }

	// RVA: 0x18BD550 Offset: 0x18BC950 VA: 0x1818BD550
	private void ReadNames(byte[] buffer, ref int position) { }

	// RVA: 0x18BD180 Offset: 0x18BC580 VA: 0x1818BD180
	public int Get(TermInfoNumbers number) { }

	// RVA: 0x18BD010 Offset: 0x18BC410 VA: 0x1818BD010
	public string Get(TermInfoStrings tstr) { }

	// RVA: 0x18BCDF0 Offset: 0x18BC1F0 VA: 0x1818BCDF0
	public byte[] GetStringBytes(TermInfoStrings tstr) { }

	// RVA: 0x18BCCB0 Offset: 0x18BC0B0 VA: 0x1818BCCB0
	private short GetInt16(byte[] buffer, int offset) { }

	// RVA: 0x18BCF80 Offset: 0x18BC380 VA: 0x1818BCF80
	private string GetString(byte[] buffer, int offset) { }

	// RVA: 0x18BCD30 Offset: 0x18BC130 VA: 0x1818BCD30
	private byte[] GetStringBytes(byte[] buffer, int offset) { }

}

