internal sealed class TokenizerStream // TypeDefIndex: 927
{
	private int m_countTokens; 
	private TokenizerShortBlock m_headTokens; 
	private TokenizerShortBlock m_lastTokens; 
	private TokenizerShortBlock m_currentTokens; 
	private int m_indexTokens; 
	private TokenizerStringBlock m_headStrings; 
	private TokenizerStringBlock m_currentStrings; 
	private int m_indexStrings; 


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

