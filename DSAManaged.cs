internal class DSAManaged : DSA // TypeDefIndex: 78
{	// Fields
	private bool keypairGenerated; // 0x20
	private bool m_disposed; // 0x21
	private BigInteger p; // 0x28
	private BigInteger q; // 0x30
	private BigInteger g; // 0x38
	private BigInteger x; // 0x40
	private BigInteger y; // 0x48
	private BigInteger j; // 0x50
	private BigInteger seed; // 0x58
	private int counter; // 0x60
	private bool j_missing; // 0x64
	private RandomNumberGenerator rng; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private DSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x70

	// Properties
	private RandomNumberGenerator Random { get; }
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x17422A0 Offset: 0x17416A0 VA: 0x1817422A0
	public void .ctor(int dwKeySize) { }

	// RVA: 0xA47AB0 Offset: 0xA46EB0 VA: 0x180A47AB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1741820 Offset: 0x1740C20 VA: 0x181741820
	private void Generate() { }

	// RVA: 0x1740E50 Offset: 0x1740250 VA: 0x181740E50
	private void GenerateKeyPair() { }

	// RVA: 0x1742430 Offset: 0x1741830 VA: 0x181742430
	private void add(byte[] a, byte[] b, int value) { }

	// RVA: 0x1740F80 Offset: 0x1740380 VA: 0x181740F80
	private void GenerateParams(int keyLength) { }

	// RVA: 0x1742580 Offset: 0x1741980 VA: 0x181742580
	private RandomNumberGenerator get_Random() { }

	// RVA: 0x17424E0 Offset: 0x17418E0 VA: 0x1817424E0 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1742510 Offset: 0x1741910 VA: 0x181742510
	public bool get_PublicOnly() { }

	// RVA: 0x1741D70 Offset: 0x1741170 VA: 0x181741D70
	private byte[] NormalizeArray(byte[] array) { }

	// RVA: 0x1740A20 Offset: 0x173FE20 VA: 0x181740A20 Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x1741980 Offset: 0x1740D80 VA: 0x181741980 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x1741E20 Offset: 0x1741220 VA: 0x181741E20 Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x1740760 Offset: 0x173FB60 VA: 0x181740760 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1742390 Offset: 0x1741790 VA: 0x181742390
	public void add_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x17425C0 Offset: 0x17419C0 VA: 0x1817425C0
	public void remove_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

}

public sealed class DSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 79
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

