public sealed class DSACryptoServiceProvider : DSA // TypeDefIndex: 1005
{
	private KeyPairPersistence store;
	private bool persistKey;
	private bool persisted;
	private bool privateKeyExportable;
	private bool m_disposed;
	private DSAManaged dsa;
	private static bool useMachineKeyStore;

	public override int KeySize { get; }
	[ComVisibleAttribute]
	public bool PublicOnly { get; }


	public void .ctor() { }

	public void .ctor(int dwKeySize) { }

	private void Common(int dwKeySize, bool parameters) { }

	protected override void Finalize() { }

	public override int get_KeySize() { }

	public bool get_PublicOnly() { }

	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	public override void ImportParameters(DSAParameters parameters) { }

	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	protected override void Dispose(bool disposing) { }

	private void OnKeyGenerated(object sender, EventArgs e) { }

}

