internal struct WindowsRTCOptionsPlatformSpecificOptionsInternal : IGettable<WindowsRTCOptionsPlatformSpecificOptions>, ISettable<WindowsRTCOptionsPlatformSpecificOptions>, IDisposable // TypeDefIndex: 9878
{
	private int m_ApiVersion; 
	private IntPtr m_XAudio29DllPath; 

	public Utf8String XAudio29DllPath { get; set; }


	public Utf8String get_XAudio29DllPath() { }

	public void set_XAudio29DllPath(Utf8String value) { }

	public void Set(ref WindowsRTCOptionsPlatformSpecificOptions other) { }

	public void Set(ref Nullable<WindowsRTCOptionsPlatformSpecificOptions> other) { }

	public void Dispose() { }

	public void Get(out WindowsRTCOptionsPlatformSpecificOptions output) { }

}

