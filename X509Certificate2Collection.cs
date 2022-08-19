public class X509Certificate2Collection : X509CertificateCollection // TypeDefIndex: 2815
{	// Fields
	private static string[] newline_split; // 0x2B0AC0C

	// Properties
	public X509Certificate2 Item { get; }

	// Methods

	// RVA: 0x118D150 Offset: 0x118C550 VA: 0x18118D150
	public void .ctor() { }

	// RVA: 0x118D160 Offset: 0x118C560 VA: 0x18118D160
	public void .ctor(X509Certificate2Collection certificates) { }

	// RVA: 0x118D200 Offset: 0x118C600 VA: 0x18118D200
	public X509Certificate2 get_Item(int index) { }

	// RVA: 0x118BE00 Offset: 0x118B200 VA: 0x18118BE00
	public int Add(X509Certificate2 certificate) { }

	[MonoTODOAttribute] // RVA: 0xAFFD0 Offset: 0xAF3D0 VA: 0x1800AFFD0
	// RVA: 0x118BD60 Offset: 0x118B160 VA: 0x18118BD60
	public void AddRange(X509Certificate2Collection certificates) { }

	// RVA: 0x118BEA0 Offset: 0x118B2A0 VA: 0x18118BEA0
	public bool Contains(X509Certificate2 certificate) { }

	[MonoTODOAttribute] // RVA: 0xB0050 Offset: 0xAF450 VA: 0x1800B0050
	// RVA: 0x118C100 Offset: 0x118B500 VA: 0x18118C100
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	// RVA: 0x118D030 Offset: 0x118C430 VA: 0x18118D030
	public X509Certificate2Enumerator GetEnumerator() { }

	// RVA: 0x118D090 Offset: 0x118C490 VA: 0x18118D090
	private static void .cctor() { }

}

