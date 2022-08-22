internal class Lease : MarshalByRefObject, ILease // TypeDefIndex: 1165
{	private DateTime _leaseExpireTime; // 0x18
	private LeaseState _currentState; // 0x20
	private TimeSpan _initialLeaseTime; // 0x28
	private TimeSpan _renewOnCallTime; // 0x30
	private TimeSpan _sponsorshipTimeout; // 0x38
	private ArrayList _sponsors; // 0x40
	private Queue _renewingSponsors; // 0x48
	private Lease.RenewalDelegate _renewalDelegate; // 0x50

	public TimeSpan CurrentLeaseTime { get; }
	public LeaseState CurrentState { get; }
	public TimeSpan RenewOnCallTime { get; }


	public void .ctor() { }

	public TimeSpan get_CurrentLeaseTime() { }

	public LeaseState get_CurrentState() { }

	public void Activate() { }

	public TimeSpan get_RenewOnCallTime() { }

	public TimeSpan Renew(TimeSpan renewalTime) { }

	public void Unregister(ISponsor obj) { }

	internal void UpdateState() { }

	private void CheckNextSponsor() { }

	private void ProcessSponsorResponse(object state, bool timedOut) { }

}

private sealed class Lease.RenewalDelegate : MulticastDelegate // TypeDefIndex: 1166
{
	public void .ctor(object object, IntPtr method) { }

	public virtual TimeSpan Invoke(ILease lease) { }

	public virtual IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, object object) { }

	public virtual TimeSpan EndInvoke(IAsyncResult result) { }

}

