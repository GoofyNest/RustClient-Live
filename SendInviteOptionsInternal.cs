internal struct SendInviteOptionsInternal : ISettable<SendInviteOptions>, IDisposable // TypeDefIndex: 8536
{
	private int m_ApiVersion; 
	private IntPtr m_SessionName; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 

	public Utf8String SessionName { set; }
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }


	public void set_SessionName(Utf8String value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void set_TargetUserId(ProductUserId value) { }

	public void Set(ref SendInviteOptions other) { }

	public void Set(ref Nullable<SendInviteOptions> other) { }

	public void Dispose() { }

}

internal struct SendInviteOptionsInternal : ISettable<SendInviteOptions>, IDisposable // TypeDefIndex: 9258
{
	private int m_ApiVersion; 
	private IntPtr m_LobbyId; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 

	public Utf8String LobbyId { set; }
	public ProductUserId LocalUserId { set; }
	public ProductUserId TargetUserId { set; }


	public void set_LobbyId(Utf8String value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void set_TargetUserId(ProductUserId value) { }

	public void Set(ref SendInviteOptions other) { }

	public void Set(ref Nullable<SendInviteOptions> other) { }

	public void Dispose() { }

}

internal struct SendInviteOptionsInternal : ISettable<SendInviteOptions>, IDisposable // TypeDefIndex: 9407
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void Set(ref SendInviteOptions other) { }

	public void Set(ref Nullable<SendInviteOptions> other) { }

	public void Dispose() { }

}

