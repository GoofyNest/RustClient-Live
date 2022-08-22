public sealed class LifetimeServices // TypeDefIndex: 1170
{	private static TimeSpan _leaseManagerPollTime; // 0x0
	private static TimeSpan _leaseTime; // 0x8
	private static TimeSpan _renewOnCallTime; // 0x10
	private static TimeSpan _sponsorshipTimeout; // 0x18
	private static LeaseManager _leaseManager; // 0x20

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

