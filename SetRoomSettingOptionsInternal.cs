internal struct SetRoomSettingOptionsInternal : ISettable<SetRoomSettingOptions>, IDisposable // TypeDefIndex: 8799
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_RoomName;
	private IntPtr m_SettingName;
	private IntPtr m_SettingValue;

	public ProductUserId LocalUserId { set; }
	public Utf8String RoomName { set; }
	public Utf8String SettingName { set; }
	public Utf8String SettingValue { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_RoomName(Utf8String value) { }

	public void set_SettingName(Utf8String value) { }

	public void set_SettingValue(Utf8String value) { }

	public void Set(ref SetRoomSettingOptions other) { }

	public void Set(ref Nullable<SetRoomSettingOptions> other) { }

	public void Dispose() { }

}

