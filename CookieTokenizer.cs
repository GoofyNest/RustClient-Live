internal class CookieTokenizer // TypeDefIndex: 2936
{
	private bool m_eofCookie; 
	private int m_index; 
	private int m_length; 
	private string m_name; 
	private bool m_quoted; 
	private int m_start; 
	private CookieToken m_token; 
	private int m_tokenLength; 
	private string m_tokenStream; 
	private string m_value; 
	private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes; 
	private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes; 

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
{
	private string m_name; 
	private CookieToken m_token; 

internal CookieToken Token { get; }


internal void .ctor(string name, CookieToken token) { }

internal CookieToken get_Token() { }

internal bool IsEqualTo(string value) { }

}

