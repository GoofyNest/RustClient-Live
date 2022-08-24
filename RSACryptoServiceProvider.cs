public sealed class RSACryptoServiceProvider : RSA // TypeDefIndex: 983
{
	private static CspProviderFlags s_UseMachineKeyStore; 
	private KeyPairPersistence store; 
	private bool persistKey; 
	private bool persisted; 
	private bool privateKeyExportable; 
	private bool m_disposed; 
	private RSAManaged rsa; 

	public static bool UseMachineKeyStore { get; }
	public override int KeySize { get; }
	[ComVisibleAttribute] 
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

