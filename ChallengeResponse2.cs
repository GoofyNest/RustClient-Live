public static class ChallengeResponse2 // TypeDefIndex: 1726
{	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0x1AAC2C0 Offset: 0x1AAB6C0 VA: 0x181AAC2C0
	private static byte[] Compute_LM(string password, byte[] challenge) { }

	// RVA: 0x1AAC5B0 Offset: 0x1AAB9B0 VA: 0x181AAC5B0
	private static byte[] Compute_NTLM_Password(string password) { }

	// RVA: 0x1AAC6C0 Offset: 0x1AABAC0 VA: 0x181AAC6C0
	private static byte[] Compute_NTLM(string password, byte[] challenge) { }

	// RVA: 0x1AAC730 Offset: 0x1AABB30 VA: 0x181AAC730
	private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1AAC960 Offset: 0x1AABD60 VA: 0x181AAC960
	private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	// RVA: 0x1AACDE0 Offset: 0x1AAC1E0 VA: 0x181AACDE0
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1AAD010 Offset: 0x1AAC410 VA: 0x181AAD010
	private static byte[] GetResponse(byte[] challenge, byte[] pwd) { }

	// RVA: 0x1AAD3B0 Offset: 0x1AAC7B0 VA: 0x181AAD3B0
	private static byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x1AAD240 Offset: 0x1AAC640 VA: 0x181AAD240
	private static byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1AAD730 Offset: 0x1AACB30 VA: 0x181AAD730
	private static void .cctor() { }

}

