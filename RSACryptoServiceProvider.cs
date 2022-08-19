public sealed class RSACryptoServiceProvider : RSA // TypeDefIndex: 983
{	// Fields
	private static CspProviderFlags s_UseMachineKeyStore; // 0x0
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private RSAManaged rsa; // 0x30

	// Properties
	public static bool UseMachineKeyStore { get; }
	public override int KeySize { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x17B1AE0 Offset: 0x17B0EE0 VA: 0x1817B1AE0
	public static bool get_UseMachineKeyStore() { }

	// RVA: 0x17B18F0 Offset: 0x17B0CF0 VA: 0x1817B18F0
	public void .ctor() { }

	// RVA: 0x17B17C0 Offset: 0x17B0BC0 VA: 0x1817B17C0
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x17B1A50 Offset: 0x17B0E50 VA: 0x1817B1A50
	public void .ctor(int dwKeySize) { }

	// RVA: 0x17B1920 Offset: 0x17B0D20 VA: 0x1817B1920
	public void .ctor(int dwKeySize, CspParameters parameters) { }

	// RVA: 0x17B1230 Offset: 0x17B0630 VA: 0x1817B1230
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x17B1480 Offset: 0x17B0880 VA: 0x1817B1480
	private void Common(CspParameters p) { }

	// RVA: 0xA47AB0 Offset: 0xA46EB0 VA: 0x180A47AB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17B1A90 Offset: 0x17B0E90 VA: 0x1817B1A90 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x17B1AC0 Offset: 0x17B0EC0 VA: 0x1817B1AC0
	public bool get_PublicOnly() { }

	// RVA: 0x12A5360 Offset: 0x12A4760 VA: 0x1812A5360 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x17B1590 Offset: 0x17B0990 VA: 0x1817B1590 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x16FA6B0 Offset: 0x16F9AB0 VA: 0x1816FA6B0 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x16FA580 Offset: 0x16F9980 VA: 0x1816FA580 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17B1740 Offset: 0x17B0B40 VA: 0x1817B1740
	private void OnKeyGenerated(object sender, EventArgs e) { }

}

