internal sealed class TokenizerStream // TypeDefIndex: 927
{	// Fields
	private int m_countTokens; // 0x10
	private TokenizerShortBlock m_headTokens; // 0x18
	private TokenizerShortBlock m_lastTokens; // 0x20
	private TokenizerShortBlock m_currentTokens; // 0x28
	private int m_indexTokens; // 0x30
	private TokenizerStringBlock m_headStrings; // 0x38
	private TokenizerStringBlock m_currentStrings; // 0x40
	private int m_indexStrings; // 0x48

	// Methods

	// RVA: 0x18BE040 Offset: 0x18BD440 VA: 0x1818BE040
	internal void .ctor() { }

	// RVA: 0x18BDAA0 Offset: 0x18BCEA0 VA: 0x1818BDAA0
	internal void AddToken(short token) { }

	// RVA: 0x18BD920 Offset: 0x18BCD20 VA: 0x1818BD920
	internal void AddString(string str) { }

	// RVA: 0x18BDEE0 Offset: 0x18BD2E0 VA: 0x1818BDEE0
	internal void Reset() { }

	// RVA: 0x18BDBE0 Offset: 0x18BCFE0 VA: 0x1818BDBE0
	internal short GetNextFullToken() { }

	// RVA: 0x18BDD10 Offset: 0x18BD110 VA: 0x1818BDD10
	internal short GetNextToken() { }

	// RVA: 0x18BDC80 Offset: 0x18BD080 VA: 0x1818BDC80
	internal string GetNextString() { }

	// RVA: 0x18BDFC0 Offset: 0x18BD3C0 VA: 0x1818BDFC0
	internal void ThrowAwayNextString() { }

	// RVA: 0x18BDF30 Offset: 0x18BD330 VA: 0x1818BDF30
	internal void TagLastToken(short tag) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	internal int GetTokenCount() { }

	// RVA: 0x18BDDC0 Offset: 0x18BD1C0 VA: 0x1818BDDC0
	internal void GoToPosition(int position) { }

}

