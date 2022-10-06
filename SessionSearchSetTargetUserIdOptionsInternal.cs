internal struct SessionSearchSetTargetUserIdOptionsInternal : ISettable<SessionSearchSetTargetUserIdOptions>, IDisposable // TypeDefIndex: 8593
{
	private int m_ApiVersion; 
	private IntPtr m_TargetUserId; 

	public ProductUserId TargetUserId { set; }


	public void set_TargetUserId(ProductUserId value) { }

	public void Set(ref SessionSearchSetTargetUserIdOptions other) { }

	public void Set(ref Nullable<SessionSearchSetTargetUserIdOptions> other) { }

	public void Dispose() { }

}

