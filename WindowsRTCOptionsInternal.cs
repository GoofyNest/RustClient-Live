internal struct WindowsRTCOptionsInternal : IGettable<WindowsRTCOptions>, ISettable<WindowsRTCOptions>, IDisposable // TypeDefIndex: 9889
{
	private int m_ApiVersion;
	private IntPtr m_PlatformSpecificOptions;

	public Nullable<WindowsRTCOptionsPlatformSpecificOptions> PlatformSpecificOptions { get; set; }


	public Nullable<WindowsRTCOptionsPlatformSpecificOptions> get_PlatformSpecificOptions() { }

	public void set_PlatformSpecificOptions(Nullable<WindowsRTCOptionsPlatformSpecificOptions> value) { }

	public void Set(ref WindowsRTCOptions other) { }

	public void Set(ref Nullable<WindowsRTCOptions> other) { }

	public void Dispose() { }

	public void Get(out WindowsRTCOptions output) { }

}

