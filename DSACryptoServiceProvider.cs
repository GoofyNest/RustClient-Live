public sealed class DSACryptoServiceProvider : DSA // TypeDefIndex: 1005
{	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private DSAManaged dsa; // 0x30
	private static bool useMachineKeyStore; // 0x0

	public override int KeySize { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
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

