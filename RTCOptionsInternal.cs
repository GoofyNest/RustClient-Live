internal struct RTCOptionsInternal : IGettable<RTCOptions>, ISettable<RTCOptions>, IDisposable // TypeDefIndex: 9879
{
	private int m_ApiVersion; 
	private IntPtr m_PlatformSpecificOptions; 

	public IntPtr PlatformSpecificOptions { get; set; }


	public IntPtr get_PlatformSpecificOptions() { }

	public void set_PlatformSpecificOptions(IntPtr value) { }

	public void Set(ref RTCOptions other) { }

	public void Set(ref Nullable<RTCOptions> other) { }

	public void Dispose() { }

	public void Get(out RTCOptions output) { }

}

