internal sealed class TokenizerStream // TypeDefIndex: 927
{	private int m_countTokens; // 0x10
	private TokenizerShortBlock m_headTokens; // 0x18
	private TokenizerShortBlock m_lastTokens; // 0x20
	private TokenizerShortBlock m_currentTokens; // 0x28
	private int m_indexTokens; // 0x30
	private TokenizerStringBlock m_headStrings; // 0x38
	private TokenizerStringBlock m_currentStrings; // 0x40
	private int m_indexStrings; // 0x48


	internal void .ctor() { }

	internal void AddToken(short token) { }

	internal void AddString(string str) { }

	internal void Reset() { }

	internal short GetNextFullToken() { }

	internal short GetNextToken() { }

	internal string GetNextString() { }

	internal void ThrowAwayNextString() { }

	internal void TagLastToken(short tag) { }

	internal int GetTokenCount() { }

	internal void GoToPosition(int position) { }

}

