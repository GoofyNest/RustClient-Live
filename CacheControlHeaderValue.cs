public class CacheControlHeaderValue : ICloneable // TypeDefIndex: 5759
{	// Fields
	private List<NameValueHeaderValue> extensions; // 0x10
	private List<string> no_cache_headers; // 0x18
	private List<string> private_headers; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<TimeSpan> <MaxAge>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <MaxStale>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<TimeSpan> <MaxStaleLimit>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<TimeSpan> <MinFresh>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <MustRevalidate>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <NoCache>k__BackingField; // 0x61
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <NoStore>k__BackingField; // 0x62
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <NoTransform>k__BackingField; // 0x63
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <OnlyIfCached>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Private>k__BackingField; // 0x65
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <ProxyRevalidate>k__BackingField; // 0x66
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Public>k__BackingField; // 0x67
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<TimeSpan> <SharedMaxAge>k__BackingField; // 0x68

	// Properties
	public ICollection<NameValueHeaderValue> Extensions { get; }
	public Nullable<TimeSpan> MaxAge { get; set; }
	public bool MaxStale { get; set; }
	public Nullable<TimeSpan> MaxStaleLimit { get; set; }
	public Nullable<TimeSpan> MinFresh { get; set; }
	public bool MustRevalidate { get; set; }
	public bool NoCache { get; set; }
	public ICollection<string> NoCacheHeaders { get; }
	public bool NoStore { get; set; }
	public bool NoTransform { get; set; }
	public bool OnlyIfCached { get; set; }
	public bool Private { get; set; }
	public ICollection<string> PrivateHeaders { get; }
	public bool ProxyRevalidate { get; set; }
	public bool Public { get; set; }
	public Nullable<TimeSpan> SharedMaxAge { get; set; }

	// Methods

	// RVA: 0x10812B0 Offset: 0x10806B0 VA: 0x1810812B0
	public ICollection<NameValueHeaderValue> get_Extensions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0C9B0 Offset: 0xB0BDB0 VA: 0x180B0C9B0
	public Nullable<TimeSpan> get_MaxAge() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1081470 Offset: 0x1080870 VA: 0x181081470
	public void set_MaxAge(Nullable<TimeSpan> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1120 Offset: 0x8B0520 VA: 0x1808B1120
	public bool get_MaxStale() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x78BED0 Offset: 0x78B2D0 VA: 0x18078BED0
	public void set_MaxStale(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1081320 Offset: 0x1080720 VA: 0x181081320
	public Nullable<TimeSpan> get_MaxStaleLimit() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1081480 Offset: 0x1080880 VA: 0x181081480
	public void set_MaxStaleLimit(Nullable<TimeSpan> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1058C50 Offset: 0x1058050 VA: 0x181058C50
	public Nullable<TimeSpan> get_MinFresh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1081490 Offset: 0x1080890 VA: 0x181081490
	public void set_MinFresh(Nullable<TimeSpan> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2DBD0 Offset: 0xA2CFD0 VA: 0x180A2DBD0
	public bool get_MustRevalidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x70AFB0 Offset: 0x70A3B0 VA: 0x18070AFB0
	public void set_MustRevalidate(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10813A0 Offset: 0x10807A0 VA: 0x1810813A0
	public bool get_NoCache() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10814A0 Offset: 0x10808A0 VA: 0x1810814A0
	public void set_NoCache(bool value) { }

	// RVA: 0x1081330 Offset: 0x1080730 VA: 0x181081330
	public ICollection<string> get_NoCacheHeaders() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10813B0 Offset: 0x10807B0 VA: 0x1810813B0
	public bool get_NoStore() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10814B0 Offset: 0x10808B0 VA: 0x1810814B0
	public void set_NoStore(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10813C0 Offset: 0x10807C0 VA: 0x1810813C0
	public bool get_NoTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10814C0 Offset: 0x10808C0 VA: 0x1810814C0
	public void set_NoTransform(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7AC260 Offset: 0x7AB660 VA: 0x1807AC260
	public bool get_OnlyIfCached() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10814D0 Offset: 0x10808D0 VA: 0x1810814D0
	public void set_OnlyIfCached(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7AC250 Offset: 0x7AB650 VA: 0x1807AC250
	public bool get_Private() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10814E0 Offset: 0x10808E0 VA: 0x1810814E0
	public void set_Private(bool value) { }

	// RVA: 0x10813D0 Offset: 0x10807D0 VA: 0x1810813D0
	public ICollection<string> get_PrivateHeaders() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1081440 Offset: 0x1080840 VA: 0x181081440
	public bool get_ProxyRevalidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10814F0 Offset: 0x10808F0 VA: 0x1810814F0
	public void set_ProxyRevalidate(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1081450 Offset: 0x1080850 VA: 0x181081450
	public bool get_Public() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1081500 Offset: 0x1080900 VA: 0x181081500
	public void set_Public(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1081460 Offset: 0x1080860 VA: 0x181081460
	public Nullable<TimeSpan> get_SharedMaxAge() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1081510 Offset: 0x1080910 VA: 0x181081510
	public void set_SharedMaxAge(Nullable<TimeSpan> value) { }

	// RVA: 0x107FD30 Offset: 0x107F130 VA: 0x18107FD30 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x107F800 Offset: 0x107EC00 VA: 0x18107F800 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x107FB00 Offset: 0x107EF00 VA: 0x18107FB00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10807D0 Offset: 0x107FBD0 VA: 0x1810807D0
	public static bool TryParse(string input, out CacheControlHeaderValue parsedValue) { }

	// RVA: 0x10801C0 Offset: 0x107F5C0 VA: 0x1810801C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

