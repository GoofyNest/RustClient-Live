internal abstract class X509ChainImpl : IDisposable // TypeDefIndex: 2826
{	// Properties
	public abstract bool IsValid { get; }
	public abstract X509ChainPolicy ChainPolicy { get; set; }
	public abstract X509ChainStatus[] ChainStatus { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509ChainPolicy get_ChainPolicy();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_ChainPolicy(X509ChainPolicy value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract X509ChainStatus[] get_ChainStatus();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool Build(X509Certificate2 certificate);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Reset();

	// RVA: 0x14DB6B0 Offset: 0x14DAAB0 VA: 0x1814DB6B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 11
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x14DB720 Offset: 0x14DAB20 VA: 0x1814DB720 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

