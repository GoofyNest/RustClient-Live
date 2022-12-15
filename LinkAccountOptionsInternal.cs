internal struct LinkAccountOptionsInternal : ISettable<LinkAccountOptions>, IDisposable // TypeDefIndex: 9596
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_ContinuanceToken;

	public ProductUserId LocalUserId { set; }
	public ContinuanceToken ContinuanceToken { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_ContinuanceToken(ContinuanceToken value) { }

	public void Set(ref LinkAccountOptions other) { }

	public void Set(ref Nullable<LinkAccountOptions> other) { }

	public void Dispose() { }

}

internal struct LinkAccountOptionsInternal : ISettable<LinkAccountOptions>, IDisposable // TypeDefIndex: 9672
{
	private int m_ApiVersion;
	private LinkAccountFlags m_LinkAccountFlags;
	private IntPtr m_ContinuanceToken;
	private IntPtr m_LocalUserId;

	public LinkAccountFlags LinkAccountFlags { set; }
	public ContinuanceToken ContinuanceToken { set; }
	public EpicAccountId LocalUserId { set; }


	public void set_LinkAccountFlags(LinkAccountFlags value) { }

	public void set_ContinuanceToken(ContinuanceToken value) { }

	public void set_LocalUserId(EpicAccountId value) { }

	public void Set(ref LinkAccountOptions other) { }

	public void Set(ref Nullable<LinkAccountOptions> other) { }

	public void Dispose() { }

}

