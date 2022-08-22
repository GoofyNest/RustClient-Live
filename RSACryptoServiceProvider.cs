public sealed class RSACryptoServiceProvider : RSA // TypeDefIndex: 983
{	private static CspProviderFlags s_UseMachineKeyStore; // 0x0
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private RSAManaged rsa; // 0x30

	public static bool UseMachineKeyStore { get; }
	public override int KeySize { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public bool PublicOnly { get; }


	public static bool get_UseMachineKeyStore() { }

	public void .ctor() { }

	public void .ctor(CspParameters parameters) { }

	public void .ctor(int dwKeySize) { }

	public void .ctor(int dwKeySize, CspParameters parameters) { }

	private void Common(int dwKeySize, bool parameters) { }

	private void Common(CspParameters p) { }

	protected override void Finalize() { }

	public override int get_KeySize() { }

	public bool get_PublicOnly() { }

	public override byte[] EncryptValue(byte[] rgb) { }

	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	public override void ImportParameters(RSAParameters parameters) { }

	protected override void Dispose(bool disposing) { }

	private void OnKeyGenerated(object sender, EventArgs e) { }

}

