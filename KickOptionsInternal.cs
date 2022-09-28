internal struct KickOptionsInternal : ISettable<KickOptions>, IDisposable // TypeDefIndex: 8697
{
	private int m_ApiVersion; 
	private IntPtr m_RoomName; 
	private IntPtr m_TargetUserId; 

	public Utf8String RoomName { set; }
	public ProductUserId TargetUserId { set; }


	public void set_RoomName(Utf8String value) { }

	public void set_TargetUserId(ProductUserId value) { }

	public void Set(ref KickOptions other) { }

	public void Set(ref Nullable<KickOptions> other) { }

	public void Dispose() { }

}

