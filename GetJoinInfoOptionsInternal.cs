internal struct GetJoinInfoOptionsInternal : ISettable<GetJoinInfoOptions>, IDisposable // TypeDefIndex: 8832
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_TargetUserId;

	public EpicAccountId LocalUserId { set; }
	public EpicAccountId TargetUserId { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void Set(ref GetJoinInfoOptions other) { }

	public void Set(ref Nullable<GetJoinInfoOptions> other) { }

	public void Dispose() { }

}

