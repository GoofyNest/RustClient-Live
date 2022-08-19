public sealed class LifetimeServices // TypeDefIndex: 1170
{	// Fields
	private static TimeSpan _leaseManagerPollTime; // 0x0
	private static TimeSpan _leaseTime; // 0x8
	private static TimeSpan _renewOnCallTime; // 0x10
	private static TimeSpan _sponsorshipTimeout; // 0x18
	private static LeaseManager _leaseManager; // 0x20

	// Properties
	public static TimeSpan LeaseManagerPollTime { get; set; }
	public static TimeSpan LeaseTime { get; set; }
	public static TimeSpan RenewOnCallTime { get; set; }
	public static TimeSpan SponsorshipTimeout { get; set; }

	// Methods

	// RVA: 0x1474D00 Offset: 0x1474100 VA: 0x181474D00
	private static void .cctor() { }

	// RVA: 0x1474E50 Offset: 0x1474250 VA: 0x181474E50
	public static TimeSpan get_LeaseManagerPollTime() { }

	// RVA: 0x1474FD0 Offset: 0x14743D0 VA: 0x181474FD0
	public static void set_LeaseManagerPollTime(TimeSpan value) { }

	// RVA: 0x1474EB0 Offset: 0x14742B0 VA: 0x181474EB0
	public static TimeSpan get_LeaseTime() { }

	// RVA: 0x1475060 Offset: 0x1474460 VA: 0x181475060
	public static void set_LeaseTime(TimeSpan value) { }

	// RVA: 0x1474F10 Offset: 0x1474310 VA: 0x181474F10
	public static TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x14750C0 Offset: 0x14744C0 VA: 0x1814750C0
	public static void set_RenewOnCallTime(TimeSpan value) { }

	// RVA: 0x1474F70 Offset: 0x1474370 VA: 0x181474F70
	public static TimeSpan get_SponsorshipTimeout() { }

	// RVA: 0x1475120 Offset: 0x1474520 VA: 0x181475120
	public static void set_SponsorshipTimeout(TimeSpan value) { }

	// RVA: 0x1474C80 Offset: 0x1474080 VA: 0x181474C80
	internal static void TrackLifetime(ServerIdentity identity) { }

}

