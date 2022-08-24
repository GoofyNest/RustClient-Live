internal class Lease : MarshalByRefObject, ILease // TypeDefIndex: 1165
{
	private DateTime _leaseExpireTime; 
	private LeaseState _currentState; 
	private TimeSpan _initialLeaseTime; 
	private TimeSpan _renewOnCallTime; 
	private TimeSpan _sponsorshipTimeout; 
	private ArrayList _sponsors; 
	private Queue _renewingSponsors; 
	private Lease.RenewalDelegate _renewalDelegate; 

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

