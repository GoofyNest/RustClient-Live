internal class CookieTokenizer // TypeDefIndex: 2936
{	private bool m_eofCookie; // 0x10
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

	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }


	internal void .ctor(string tokenStream) { }

	internal bool get_EndOfCookie() { }

	internal void set_EndOfCookie(bool value) { }

	internal bool get_Eof() { }

	internal string get_Name() { }

	internal void set_Name(string value) { }

	internal bool get_Quoted() { }

	internal void set_Quoted(bool value) { }

	internal CookieToken get_Token() { }

	internal void set_Token(CookieToken value) { }

	internal string get_Value() { }

	internal void set_Value(string value) { }

	internal string Extract() { }

	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	internal void Reset() { }

	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	private static void .cctor() { }

}

private struct CookieTokenizer.RecognizedAttribute // TypeDefIndex: 2937
{	private string m_name; // 0x0
	private CookieToken m_token; // 0x8

	internal CookieToken Token { get; }


	internal void .ctor(string name, CookieToken token) { }

	internal CookieToken get_Token() { }

	internal bool IsEqualTo(string value) { }

}

