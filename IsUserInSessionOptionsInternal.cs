internal struct IsUserInSessionOptionsInternal : ISettable<IsUserInSessionOptions>, IDisposable // TypeDefIndex: 8451
{
	private int m_ApiVersion; 
	private IntPtr m_SessionName; 
	private IntPtr m_TargetUserId; 

	public Utf8String SessionName { set; }
	public ProductUserId TargetUserId { set; }


	public void set_SessionName(Utf8String value) { }

	public void set_TargetUserId(ProductUserId value) { }

	public void Set(ref IsUserInSessionOptions other) { }

	public void Set(ref Nullable<IsUserInSessionOptions> other) { }

	public void Dispose() { }

}

