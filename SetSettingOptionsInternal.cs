internal struct SetSettingOptionsInternal : ISettable<SetSettingOptions>, IDisposable // TypeDefIndex: 8801
{
	private int m_ApiVersion;
	private IntPtr m_SettingName;
	private IntPtr m_SettingValue;

	public Utf8String SettingName { set; }
	public Utf8String SettingValue { set; }


	public void set_SettingName(Utf8String value) { }

	public void set_SettingValue(Utf8String value) { }

	public void Set(ref SetSettingOptions other) { }

	public void Set(ref Nullable<SetSettingOptions> other) { }

	public void Dispose() { }

}

