internal struct LocalRTCOptionsInternal : IGettable<LocalRTCOptions>, ISettable<LocalRTCOptions>, IDisposable // TypeDefIndex: 9198
{
	private int m_ApiVersion; 
	private uint m_Flags; 
	private int m_UseManualAudioInput; 
	private int m_UseManualAudioOutput; 
	private int m_LocalAudioDeviceInputStartsMuted; 

	public uint Flags { get; set; }
	public bool UseManualAudioInput { get; set; }
	public bool UseManualAudioOutput { get; set; }
	public bool LocalAudioDeviceInputStartsMuted { get; set; }


	public uint get_Flags() { }

	public void set_Flags(uint value) { }

	public bool get_UseManualAudioInput() { }

	public void set_UseManualAudioInput(bool value) { }

	public bool get_UseManualAudioOutput() { }

	public void set_UseManualAudioOutput(bool value) { }

	public bool get_LocalAudioDeviceInputStartsMuted() { }

	public void set_LocalAudioDeviceInputStartsMuted(bool value) { }

	public void Set(ref LocalRTCOptions other) { }

	public void Set(ref Nullable<LocalRTCOptions> other) { }

	public void Dispose() { }

	public void Get(out LocalRTCOptions output) { }

}

