public class CacheControlHeaderValue : ICloneable // TypeDefIndex: 5759
{
	private List<NameValueHeaderValue> extensions; 
	private List<string> no_cache_headers; 
	private List<string> private_headers; 
	[CompilerGeneratedAttribute] 
	private Nullable<TimeSpan> <MaxAge>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <MaxStale>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<TimeSpan> <MaxStaleLimit>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<TimeSpan> <MinFresh>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <MustRevalidate>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <NoCache>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <NoStore>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <NoTransform>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <OnlyIfCached>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <Private>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <ProxyRevalidate>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <Public>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<TimeSpan> <SharedMaxAge>k__BackingField; 

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


public ICollection<NameValueHeaderValue> get_Extensions() { }

	[CompilerGeneratedAttribute] 
public Nullable<TimeSpan> get_MaxAge() { }

	[CompilerGeneratedAttribute] 
public void set_MaxAge(Nullable<TimeSpan> value) { }

	[CompilerGeneratedAttribute] 
public bool get_MaxStale() { }

	[CompilerGeneratedAttribute] 
public void set_MaxStale(bool value) { }

	[CompilerGeneratedAttribute] 
public Nullable<TimeSpan> get_MaxStaleLimit() { }

	[CompilerGeneratedAttribute] 
public void set_MaxStaleLimit(Nullable<TimeSpan> value) { }

	[CompilerGeneratedAttribute] 
public Nullable<TimeSpan> get_MinFresh() { }

	[CompilerGeneratedAttribute] 
public void set_MinFresh(Nullable<TimeSpan> value) { }

	[CompilerGeneratedAttribute] 
public bool get_MustRevalidate() { }

	[CompilerGeneratedAttribute] 
public void set_MustRevalidate(bool value) { }

	[CompilerGeneratedAttribute] 
public bool get_NoCache() { }

	[CompilerGeneratedAttribute] 
public void set_NoCache(bool value) { }

public ICollection<string> get_NoCacheHeaders() { }

	[CompilerGeneratedAttribute] 
public bool get_NoStore() { }

	[CompilerGeneratedAttribute] 
public void set_NoStore(bool value) { }

	[CompilerGeneratedAttribute] 
public bool get_NoTransform() { }

	[CompilerGeneratedAttribute] 
public void set_NoTransform(bool value) { }

	[CompilerGeneratedAttribute] 
public bool get_OnlyIfCached() { }

	[CompilerGeneratedAttribute] 
public void set_OnlyIfCached(bool value) { }

	[CompilerGeneratedAttribute] 
public bool get_Private() { }

	[CompilerGeneratedAttribute] 
public void set_Private(bool value) { }

public ICollection<string> get_PrivateHeaders() { }

	[CompilerGeneratedAttribute] 
public bool get_ProxyRevalidate() { }

	[CompilerGeneratedAttribute] 
public void set_ProxyRevalidate(bool value) { }

	[CompilerGeneratedAttribute] 
public bool get_Public() { }

	[CompilerGeneratedAttribute] 
public void set_Public(bool value) { }

	[CompilerGeneratedAttribute] 
public Nullable<TimeSpan> get_SharedMaxAge() { }

	[CompilerGeneratedAttribute] 
public void set_SharedMaxAge(Nullable<TimeSpan> value) { }

private object System.ICloneable.Clone() { }

public override bool Equals(object obj) { }

public override int GetHashCode() { }

public static bool TryParse(string input, out CacheControlHeaderValue parsedValue) { }

public override string ToString() { }

public void .ctor() { }

}

