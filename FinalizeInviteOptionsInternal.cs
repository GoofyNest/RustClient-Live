internal struct FinalizeInviteOptionsInternal : ISettable<FinalizeInviteOptions>, IDisposable // TypeDefIndex: 9529
{
	private int m_ApiVersion; 
	private IntPtr m_TargetUserId; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_CustomInviteId; 
	private Result m_ProcessingResult; 

	public ProductUserId TargetUserId { set; }
	public ProductUserId LocalUserId { set; }
	public Utf8String CustomInviteId { set; }
	public Result ProcessingResult { set; }


	public void set_TargetUserId(ProductUserId value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void set_CustomInviteId(Utf8String value) { }

	public void set_ProcessingResult(Result value) { }

	public void Set(ref FinalizeInviteOptions other) { }

	public void Set(ref Nullable<FinalizeInviteOptions> other) { }

	public void Dispose() { }

}

