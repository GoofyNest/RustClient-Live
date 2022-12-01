internal struct PermissionStatusInternal : IGettable<PermissionStatus>, ISettable<PermissionStatus>, IDisposable // TypeDefIndex: 9351
{
	private int m_ApiVersion;
	private IntPtr m_Name;
	private KWSPermissionStatus m_Status;

	public Utf8String Name { get; set; }
	public KWSPermissionStatus Status { get; set; }


	public Utf8String get_Name() { }

	public void set_Name(Utf8String value) { }

	public KWSPermissionStatus get_Status() { }

	public void set_Status(KWSPermissionStatus value) { }

	public void Set(ref PermissionStatus other) { }

	public void Set(ref Nullable<PermissionStatus> other) { }

	public void Dispose() { }

	public void Get(out PermissionStatus output) { }

}

