internal struct PrePresentOptionsInternal : IGettable<PrePresentOptions>, ISettable<PrePresentOptions>, IDisposable // TypeDefIndex: 8369
{
	private int m_ApiVersion;
	private IntPtr m_PlatformSpecificData;

	public IntPtr PlatformSpecificData { get; set; }


	public IntPtr get_PlatformSpecificData() { }

	public void set_PlatformSpecificData(IntPtr value) { }

	public void Set(ref PrePresentOptions other) { }

	public void Set(ref Nullable<PrePresentOptions> other) { }

	public void Dispose() { }

	public void Get(out PrePresentOptions output) { }

}

