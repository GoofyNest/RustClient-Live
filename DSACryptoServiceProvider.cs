public sealed class DSACryptoServiceProvider : DSA // TypeDefIndex: 1005
{	// Fields
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private DSAManaged dsa; // 0x30
	private static bool useMachineKeyStore; // 0x0

	// Properties
	public override int KeySize { get; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x16FA7F0 Offset: 0x16F9BF0 VA: 0x1816FA7F0
	public void .ctor() { }

	// RVA: 0x16FA7B0 Offset: 0x16F9BB0 VA: 0x1816FA7B0
	public void .ctor(int dwKeySize) { }

	// RVA: 0x16FA340 Offset: 0x16F9740 VA: 0x1816FA340
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0xA47AB0 Offset: 0xA46EB0 VA: 0x180A47AB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x16FA820 Offset: 0x16F9C20 VA: 0x1816FA820 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x16FA850 Offset: 0x16F9C50 VA: 0x1816FA850
	public bool get_PublicOnly() { }

	// RVA: 0x16FA5D0 Offset: 0x16F99D0 VA: 0x1816FA5D0 Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x16FA6B0 Offset: 0x16F9AB0 VA: 0x1816FA6B0 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x16FA780 Offset: 0x16F9B80 VA: 0x1816FA780 Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x16FA580 Offset: 0x16F9980 VA: 0x1816FA580 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16FA700 Offset: 0x16F9B00 VA: 0x1816FA700
	private void OnKeyGenerated(object sender, EventArgs e) { }

}

