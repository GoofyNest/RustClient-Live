internal struct SetAudioInputSettingsOptionsInternal : ISettable<SetAudioInputSettingsOptions>, IDisposable // TypeDefIndex: 8699
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_DeviceId; 
	private float m_Volume; 
	private int m_PlatformAEC; 

	public ProductUserId LocalUserId { set; }
	public Utf8String DeviceId { set; }
	public float Volume { set; }
	public bool PlatformAEC { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_DeviceId(Utf8String value) { }

	public void set_Volume(float value) { }

	public void set_PlatformAEC(bool value) { }

	public void Set(ref SetAudioInputSettingsOptions other) { }

	public void Set(ref Nullable<SetAudioInputSettingsOptions> other) { }

	public void Dispose() { }

}

