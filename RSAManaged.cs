internal class RSAManaged : RSA // TypeDefIndex: 75
{	// Fields
	private bool isCRTpossible; // 0x20
	private bool keyBlinding; // 0x21
	private bool keypairGenerated; // 0x22
	private bool m_disposed; // 0x23
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1751440 Offset: 0x1750840 VA: 0x181751440
	public void .ctor(int keySize) { }

	// RVA: 0xA47AB0 Offset: 0xA46EB0 VA: 0x180A47AB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1750180 Offset: 0x174F580 VA: 0x181750180
	private void GenerateKeyPair() { }

	// RVA: 0x1751600 Offset: 0x1750A00 VA: 0x181751600 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x17516B0 Offset: 0x1750AB0 VA: 0x1817516B0
	public bool get_PublicOnly() { }

	// RVA: 0x174FBF0 Offset: 0x174EFF0 VA: 0x18174FBF0 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x174FD10 Offset: 0x174F110 VA: 0x18174FD10 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x17505B0 Offset: 0x174F9B0 VA: 0x1817505B0 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x174F8D0 Offset: 0x174ECD0 VA: 0x18174F8D0 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1751560 Offset: 0x1750960 VA: 0x181751560
	public void add_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1751760 Offset: 0x1750B60 VA: 0x181751760
	public void remove_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	// RVA: 0x1750C80 Offset: 0x1750080 VA: 0x181750C80 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0x1750500 Offset: 0x174F900 VA: 0x181750500
	private byte[] GetPaddedValue(BigInteger value, int length) { }

}

public sealed class RSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 76
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x110BDC0 Offset: 0x110B1C0 VA: 0x18110BDC0 Slot: 12
	public virtual void Invoke(object sender, EventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class RSAManaged : RSA // TypeDefIndex: 1761
{	// Fields
	private bool isCRTpossible; // 0x20
	private bool keypairGenerated; // 0x21
	private bool m_disposed; // 0x22
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1ABE1B0 Offset: 0x1ABD5B0 VA: 0x181ABE1B0
	private void GenerateKeyPair() { }

	// RVA: 0x1ABEF50 Offset: 0x1ABE350 VA: 0x181ABEF50
	public bool get_PublicOnly() { }

	// RVA: 0x1ABDD40 Offset: 0x1ABD140 VA: 0x181ABDD40 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1ABE820 Offset: 0x1ABDC20 VA: 0x181ABE820 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x1ABE770 Offset: 0x1ABDB70 VA: 0x181ABE770
	private byte[] GetPaddedValue(BigInteger value, int length) { }

}

public sealed class RSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 1762
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, EventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

