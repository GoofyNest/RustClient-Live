internal struct RequestPermissionsOptionsInternal : ISettable<RequestPermissionsOptions>, IDisposable // TypeDefIndex: 9363
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private uint m_PermissionKeyCount; 
	private IntPtr m_PermissionKeys; 

	public ProductUserId LocalUserId { set; }
	public Utf8String[] PermissionKeys { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_PermissionKeys(Utf8String[] value) { }

	public void Set(ref RequestPermissionsOptions other) { }

	public void Set(ref Nullable<RequestPermissionsOptions> other) { }

	public void Dispose() { }

}

