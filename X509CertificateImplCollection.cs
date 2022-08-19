internal class X509CertificateImplCollection : IDisposable // TypeDefIndex: 2821
{	// Fields
	private List<X509CertificateImpl> list; // 0x10

	// Properties
	public int Count { get; }
	public X509CertificateImpl Item { get; }

	// Methods

	// RVA: 0x14D5160 Offset: 0x14D4560 VA: 0x1814D5160
	public void .ctor() { }

	// RVA: 0x14D4FD0 Offset: 0x14D43D0 VA: 0x1814D4FD0
	private void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0x14D51D0 Offset: 0x14D45D0 VA: 0x1814D51D0
	public int get_Count() { }

	// RVA: 0x14D5210 Offset: 0x14D4610 VA: 0x1814D5210
	public X509CertificateImpl get_Item(int index) { }

	// RVA: 0x14D4D30 Offset: 0x14D4130 VA: 0x1814D4D30
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	// RVA: 0x14D4DC0 Offset: 0x14D41C0 VA: 0x1814D4DC0
	public X509CertificateImplCollection Clone() { }

	// RVA: 0x14D4F60 Offset: 0x14D4360 VA: 0x1814D4F60 Slot: 4
	public void Dispose() { }

	// RVA: 0x14D4E20 Offset: 0x14D4220 VA: 0x1814D4E20 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xA47AB0 Offset: 0xA46EB0 VA: 0x180A47AB0 Slot: 1
	protected override void Finalize() { }

}

