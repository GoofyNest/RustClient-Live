internal struct ModIdentifierInternal : IGettable<ModIdentifier>, ISettable<ModIdentifier>, IDisposable // TypeDefIndex: 9025
{
	private int m_ApiVersion;
	private IntPtr m_NamespaceId;
	private IntPtr m_ItemId;
	private IntPtr m_ArtifactId;
	private IntPtr m_Title;
	private IntPtr m_Version;

	public Utf8String NamespaceId { get; set; }
	public Utf8String ItemId { get; set; }
	public Utf8String ArtifactId { get; set; }
	public Utf8String Title { get; set; }
	public Utf8String Version { get; set; }


	public Utf8String get_NamespaceId() { }

	public void set_NamespaceId(Utf8String value) { }

	public Utf8String get_ItemId() { }

	public void set_ItemId(Utf8String value) { }

	public Utf8String get_ArtifactId() { }

	public void set_ArtifactId(Utf8String value) { }

	public Utf8String get_Title() { }

	public void set_Title(Utf8String value) { }

	public Utf8String get_Version() { }

	public void set_Version(Utf8String value) { }

	public void Set(ref ModIdentifier other) { }

	public void Set(ref Nullable<ModIdentifier> other) { }

	public void Dispose() { }

	public void Get(out ModIdentifier output) { }

}

