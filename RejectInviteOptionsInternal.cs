internal struct RejectInviteOptionsInternal : ISettable<RejectInviteOptions>, IDisposable // TypeDefIndex: 8531
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_InviteId; 

	public ProductUserId LocalUserId { set; }
	public Utf8String InviteId { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_InviteId(Utf8String value) { }

	public void Set(ref RejectInviteOptions other) { }

	public void Set(ref Nullable<RejectInviteOptions> other) { }

	public void Dispose() { }

}

internal struct RejectInviteOptionsInternal : ISettable<RejectInviteOptions>, IDisposable // TypeDefIndex: 9253
{
	private int m_ApiVersion; 
	private IntPtr m_InviteId; 
	private IntPtr m_LocalUserId; 

	public Utf8String InviteId { set; }
	public ProductUserId LocalUserId { set; }


	public void set_InviteId(Utf8String value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref RejectInviteOptions other) { }

	public void Set(ref Nullable<RejectInviteOptions> other) { }

	public void Dispose() { }

}

internal struct RejectInviteOptionsInternal : ISettable<RejectInviteOptions>, IDisposable // TypeDefIndex: 9402
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void Set(ref RejectInviteOptions other) { }

	public void Set(ref Nullable<RejectInviteOptions> other) { }

	public void Dispose() { }

}

