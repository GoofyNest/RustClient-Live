public sealed class X500DistinguishedName : AsnEncodedData // TypeDefIndex: 2812
{	// Fields
	private string name; // 0x20
	private byte[] canonEncoding; // 0x28

	// Methods

	// RVA: 0x118AED0 Offset: 0x118A2D0 VA: 0x18118AED0
	public void .ctor(byte[] encodedDistinguishedName) { }

	// RVA: 0x118AC70 Offset: 0x118A070 VA: 0x18118AC70
	public string Decode(X500DistinguishedNameFlags flag) { }

	// RVA: 0x118AE00 Offset: 0x118A200 VA: 0x18118AE00 Slot: 5
	public override string Format(bool multiLine) { }

	// RVA: 0x118AE70 Offset: 0x118A270 VA: 0x18118AE70
	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

	// RVA: 0x118ABA0 Offset: 0x1189FA0 VA: 0x18118ABA0
	private void DecodeRawData() { }

	// RVA: 0x118A920 Offset: 0x1189D20 VA: 0x18118A920
	private static string Canonize(string s) { }

	// RVA: 0x118A6B0 Offset: 0x1189AB0 VA: 0x18118A6B0
	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }

}

