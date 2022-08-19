internal class DigestHeaderParser // TypeDefIndex: 2992
{
// Namespace: System.Net
internal class DigestHeaderParser // TypeDefIndex: 2992
	// Fields
	private string header; // 0x10
	private int length; // 0x18
	private int pos; // 0x1C
	private static string[] keywords; // 0x0
	private string[] values; // 0x20

	// Properties
	public string Realm { get; }
	public string Opaque { get; }
	public string Nonce { get; }
	public string Algorithm { get; }
	public string QOP { get; }

	// Methods

	// RVA: 0x155AC40 Offset: 0x155A040 VA: 0x18155AC40
	public void .ctor(string header) { }

	// RVA: 0x155AE00 Offset: 0x155A200 VA: 0x18155AE00
	public string get_Realm() { }

	// RVA: 0x155AD80 Offset: 0x155A180 VA: 0x18155AD80
	public string get_Opaque() { }

	// RVA: 0x155AD40 Offset: 0x155A140 VA: 0x18155AD40
	public string get_Nonce() { }

	// RVA: 0x155AD00 Offset: 0x155A100 VA: 0x18155AD00
	public string get_Algorithm() { }

	// RVA: 0x155ADC0 Offset: 0x155A1C0 VA: 0x18155ADC0
	public string get_QOP() { }

	// RVA: 0x155A730 Offset: 0x1559B30 VA: 0x18155A730
	public bool Parse() { }

	// RVA: 0x155A970 Offset: 0x1559D70 VA: 0x18155A970
	private void SkipWhitespace() { }

	// RVA: 0x155A440 Offset: 0x1559840 VA: 0x18155A440
	private string GetKey() { }

	// RVA: 0x155A4D0 Offset: 0x15598D0 VA: 0x18155A4D0
	private bool GetKeywordAndValue(out string key, out string value) { }

	// RVA: 0x155A9E0 Offset: 0x1559DE0 VA: 0x18155A9E0
	private static void .cctor() { }

}

