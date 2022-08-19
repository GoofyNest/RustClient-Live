public class X509Chain : IDisposable // TypeDefIndex: 2822
{	// Fields
	private X509ChainImpl impl; // 0x10

	// Properties
	internal X509ChainImpl Impl { get; }
	public X509ChainPolicy ChainPolicy { get; set; }
	public X509ChainStatus[] ChainStatus { get; }

	// Methods

	// RVA: 0x14DC5E0 Offset: 0x14DB9E0 VA: 0x1814DC5E0
	internal X509ChainImpl get_Impl() { }

	// RVA: 0x14DC370 Offset: 0x14DB770 VA: 0x1814DC370
	public void .ctor() { }

	// RVA: 0x14DC220 Offset: 0x14DB620 VA: 0x1814DC220
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x14DC4C0 Offset: 0x14DB8C0 VA: 0x1814DC4C0
	public X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x14DC650 Offset: 0x14DBA50 VA: 0x1814DC650
	public void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0x14DC550 Offset: 0x14DB950 VA: 0x1814DC550
	public X509ChainStatus[] get_ChainStatus() { }

	[MonoTODOAttribute] // RVA: 0xB0590 Offset: 0xAF990 VA: 0x1800B0590
	// RVA: 0x14DBF00 Offset: 0x14DB300 VA: 0x1814DBF00
	public bool Build(X509Certificate2 certificate) { }

	// RVA: 0x14DBFA0 Offset: 0x14DB3A0 VA: 0x1814DBFA0
	public static X509Chain Create() { }

	// RVA: 0x14DC1B0 Offset: 0x14DB5B0 VA: 0x1814DC1B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x14DC120 Offset: 0x14DB520 VA: 0x1814DC120 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xA47AB0 Offset: 0xA46EB0 VA: 0x180A47AB0 Slot: 1
	protected override void Finalize() { }

}

