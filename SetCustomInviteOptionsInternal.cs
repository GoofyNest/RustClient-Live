internal struct SetCustomInviteOptionsInternal : ISettable<SetCustomInviteOptions>, IDisposable // TypeDefIndex: 9549
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_Payload;

	public ProductUserId LocalUserId { set; }
	public Utf8String Payload { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_Payload(Utf8String value) { }

	public void Set(ref SetCustomInviteOptions other) { }

	public void Set(ref Nullable<SetCustomInviteOptions> other) { }

	public void Dispose() { }

}

