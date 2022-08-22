public static class ChallengeResponse2 // TypeDefIndex: 1726
{	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8


	private static byte[] Compute_LM(string password, byte[] challenge) { }

	private static byte[] Compute_NTLM_Password(string password) { }

	private static byte[] Compute_NTLM(string password, byte[] challenge) { }

	private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm) { }

	private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) { }

	private static byte[] GetResponse(byte[] challenge, byte[] pwd) { }

	private static byte[] PrepareDESKey(byte[] key56bits, int position) { }

	private static byte[] PasswordToKey(string password, int position) { }

	private static void .cctor() { }

}

