internal struct SetDisplayPreferenceOptionsInternal : ISettable<SetDisplayPreferenceOptions>, IDisposable // TypeDefIndex: 8375
{
	private int m_ApiVersion;
	private NotificationLocation m_NotificationLocation;

	public NotificationLocation NotificationLocation { set; }


	public void set_NotificationLocation(NotificationLocation value) { }

	public void Set(ref SetDisplayPreferenceOptions other) { }

	public void Set(ref Nullable<SetDisplayPreferenceOptions> other) { }

	public void Dispose() { }

}

