internal struct CatalogReleaseInternal : IGettable<CatalogRelease>, ISettable<CatalogRelease>, IDisposable // TypeDefIndex: 9413
{
	private int m_ApiVersion; 
	private uint m_CompatibleAppIdCount; 
	private IntPtr m_CompatibleAppIds; 
	private uint m_CompatiblePlatformCount; 
	private IntPtr m_CompatiblePlatforms; 
	private IntPtr m_ReleaseNote; 

	public Utf8String[] CompatibleAppIds { get; set; }
	public Utf8String[] CompatiblePlatforms { get; set; }
	public Utf8String ReleaseNote { get; set; }


	public Utf8String[] get_CompatibleAppIds() { }

	public void set_CompatibleAppIds(Utf8String[] value) { }

	public Utf8String[] get_CompatiblePlatforms() { }

	public void set_CompatiblePlatforms(Utf8String[] value) { }

	public Utf8String get_ReleaseNote() { }

	public void set_ReleaseNote(Utf8String value) { }

	public void Set(ref CatalogRelease other) { }

	public void Set(ref Nullable<CatalogRelease> other) { }

	public void Dispose() { }

	public void Get(out CatalogRelease output) { }

}

