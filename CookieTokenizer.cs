internal class CookieTokenizer // TypeDefIndex: 2936
{	// Fields
	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties
	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }

	// Methods

	// RVA: 0x15535F0 Offset: 0x15529F0 VA: 0x1815535F0
	internal void .ctor(string tokenStream) { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	internal bool get_EndOfCookie() { }

	// RVA: 0x497E50 Offset: 0x497250 VA: 0x180497E50
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x1553640 Offset: 0x1552A40 VA: 0x181553640
	internal bool get_Eof() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal string get_Name() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	internal void set_Name(string value) { }

	// RVA: 0x9775C0 Offset: 0x9769C0 VA: 0x1809775C0
	internal bool get_Quoted() { }

	// RVA: 0x9775D0 Offset: 0x9769D0 VA: 0x1809775D0
	internal void set_Quoted(bool value) { }

	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	internal CookieToken get_Token() { }

	// RVA: 0xA17E80 Offset: 0xA17280 VA: 0x180A17E80
	internal void set_Token(CookieToken value) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	internal string get_Value() { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	internal void set_Value(string value) { }

	// RVA: 0x15528A0 Offset: 0x1551CA0 VA: 0x1815528A0
	internal string Extract() { }

	// RVA: 0x1552920 Offset: 0x1551D20 VA: 0x181552920
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x1552B90 Offset: 0x1551F90 VA: 0x181552B90
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x1552D40 Offset: 0x1552140 VA: 0x181552D40
	internal void Reset() { }

	// RVA: 0x1552DC0 Offset: 0x15521C0 VA: 0x181552DC0
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x1553050 Offset: 0x1552450 VA: 0x181553050
	private static void .cctor() { }

}

private struct CookieTokenizer.RecognizedAttribute // TypeDefIndex: 2937
{	// Fields
	private string m_name; // 0x0
	private CookieToken m_token; // 0x8

	// Properties
	internal CookieToken Token { get; }

	// Methods

	// RVA: 0xF9CD0 Offset: 0xF90D0 VA: 0x1800F9CD0
	internal void .ctor(string name, CookieToken token) { }

	// RVA: 0x122CA0 Offset: 0x1220A0 VA: 0x180122CA0
	internal CookieToken get_Token() { }

	// RVA: 0x1F22B0 Offset: 0x1F16B0 VA: 0x1801F22B0
	internal bool IsEqualTo(string value) { }

}

