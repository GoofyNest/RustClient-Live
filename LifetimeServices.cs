public sealed class LifetimeServices // TypeDefIndex: 1170
{
	private static TimeSpan _leaseManagerPollTime; 
	private static TimeSpan _leaseTime; 
	private static TimeSpan _renewOnCallTime; 
	private static TimeSpan _sponsorshipTimeout; 
	private static LeaseManager _leaseManager; 

public static TimeSpan LeaseManagerPollTime { get; set; }
public static TimeSpan LeaseTime { get; set; }
public static TimeSpan RenewOnCallTime { get; set; }
public static TimeSpan SponsorshipTimeout { get; set; }


private static void .cctor() { }

public static TimeSpan get_LeaseManagerPollTime() { }

public static void set_LeaseManagerPollTime(TimeSpan value) { }

public static TimeSpan get_LeaseTime() { }

public static void set_LeaseTime(TimeSpan value) { }

public static TimeSpan get_RenewOnCallTime() { }

public static void set_RenewOnCallTime(TimeSpan value) { }

public static TimeSpan get_SponsorshipTimeout() { }

public static void set_SponsorshipTimeout(TimeSpan value) { }

internal static void TrackLifetime(ServerIdentity identity) { }

}

