public class X509ChainElement // TypeDefIndex: 2823
{	// Fields
	private X509Certificate2 certificate; // 0x10
	private X509ChainStatus[] status; // 0x18
	private string info; // 0x20
	private X509ChainStatusFlags compressed_status_flags; // 0x28

	// Properties
	public X509Certificate2 Certificate { get; }
	public X509ChainStatus[] ChainElementStatus { get; }
	internal X509ChainStatusFlags StatusFlags { get; set; }

	// Methods

	// RVA: 0x14D7FC0 Offset: 0x14D73C0 VA: 0x1814D7FC0
	internal void .ctor(X509Certificate2 certificate) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public X509Certificate2 get_Certificate() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public X509ChainStatus[] get_ChainElementStatus() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	internal X509ChainStatusFlags get_StatusFlags() { }

	// RVA: 0x7E8DF0 Offset: 0x7E81F0 VA: 0x1807E8DF0
	internal void set_StatusFlags(X509ChainStatusFlags value) { }

	// RVA: 0x14D5920 Offset: 0x14D4D20 VA: 0x1814D5920
	private int Count(X509ChainStatusFlags flags) { }

	// RVA: 0x14D5950 Offset: 0x14D4D50 VA: 0x1814D5950
	private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	// RVA: 0x14D59F0 Offset: 0x14D4DF0 VA: 0x1814D59F0
	internal void UncompressFlags() { }

}

