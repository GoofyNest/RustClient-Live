internal struct SetAudioOutputSettingsOptionsInternal : ISettable<SetAudioOutputSettingsOptions>, IDisposable // TypeDefIndex: 8667
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_DeviceId; 
	private float m_Volume; 

	public ProductUserId LocalUserId { set; }
	public Utf8String DeviceId { set; }
	public float Volume { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_DeviceId(Utf8String value) { }

	public void set_Volume(float value) { }

	public void Set(ref SetAudioOutputSettingsOptions other) { }

	public void Set(ref Nullable<SetAudioOutputSettingsOptions> other) { }

	public void Dispose() { }

}

