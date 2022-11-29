internal struct ParticipantMetadataInternal : IGettable<ParticipantMetadata>, ISettable<ParticipantMetadata>, IDisposable // TypeDefIndex: 8789
{
	private int m_ApiVersion; 
	private IntPtr m_Key; 
	private IntPtr m_Value; 

	public Utf8String Key { get; set; }
	public Utf8String Value { get; set; }


	public Utf8String get_Key() { }

	public void set_Key(Utf8String value) { }

	public Utf8String get_Value() { }

	public void set_Value(Utf8String value) { }

	public void Set(ref ParticipantMetadata other) { }

	public void Set(ref Nullable<ParticipantMetadata> other) { }

	public void Dispose() { }

	public void Get(out ParticipantMetadata output) { }

}

