internal class Lease : MarshalByRefObject, ILease // TypeDefIndex: 1165
{	// Fields
	private DateTime _leaseExpireTime; // 0x18
	private LeaseState _currentState; // 0x20
	private TimeSpan _initialLeaseTime; // 0x28
	private TimeSpan _renewOnCallTime; // 0x30
	private TimeSpan _sponsorshipTimeout; // 0x38
	private ArrayList _sponsors; // 0x40
	private Queue _renewingSponsors; // 0x48
	private Lease.RenewalDelegate _renewalDelegate; // 0x50

	// Properties
	public TimeSpan CurrentLeaseTime { get; }
	public LeaseState CurrentState { get; }
	public TimeSpan RenewOnCallTime { get; }

	// Methods

	// RVA: 0x1474A80 Offset: 0x1473E80 VA: 0x181474A80
	public void .ctor() { }

	// RVA: 0x1474C20 Offset: 0x1474020 VA: 0x181474C20 Slot: 6
	public TimeSpan get_CurrentLeaseTime() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170 Slot: 7
	public LeaseState get_CurrentState() { }

	// RVA: 0x1473F50 Offset: 0x1473350 VA: 0x181473F50
	public void Activate() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 8
	public TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x1474680 Offset: 0x1473A80 VA: 0x181474680 Slot: 9
	public TimeSpan Renew(TimeSpan renewalTime) { }

	// RVA: 0x1474760 Offset: 0x1473B60 VA: 0x181474760 Slot: 10
	public void Unregister(ISponsor obj) { }

	// RVA: 0x14748B0 Offset: 0x1473CB0 VA: 0x1814748B0
	internal void UpdateState() { }

	// RVA: 0x1473F60 Offset: 0x1473360 VA: 0x181473F60
	private void CheckNextSponsor() { }

	// RVA: 0x14741E0 Offset: 0x14735E0 VA: 0x1814741E0
	private void ProcessSponsorResponse(object state, bool timedOut) { }

}

private sealed class Lease.RenewalDelegate : MulticastDelegate // TypeDefIndex: 1166
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1486D40 Offset: 0x1486140 VA: 0x181486D40 Slot: 12
	public virtual TimeSpan Invoke(ILease lease) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, object object) { }

	// RVA: 0x121BE10 Offset: 0x121B210 VA: 0x18121BE10 Slot: 14
	public virtual TimeSpan EndInvoke(IAsyncResult result) { }

}

