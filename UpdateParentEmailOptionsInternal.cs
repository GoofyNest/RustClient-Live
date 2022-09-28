internal struct UpdateParentEmailOptionsInternal : ISettable<UpdateParentEmailOptions>, IDisposable // TypeDefIndex: 9323
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_ParentEmail; 

	public ProductUserId LocalUserId { set; }
	public Utf8String ParentEmail { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_ParentEmail(Utf8String value) { }

	public void Set(ref UpdateParentEmailOptions other) { }

	public void Set(ref Nullable<UpdateParentEmailOptions> other) { }

	public void Dispose() { }

}

