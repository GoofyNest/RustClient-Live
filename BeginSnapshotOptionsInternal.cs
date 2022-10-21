internal struct BeginSnapshotOptionsInternal : ISettable<BeginSnapshotOptions>, IDisposable // TypeDefIndex: 8792
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 

	public ProductUserId LocalUserId { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref BeginSnapshotOptions other) { }

	public void Set(ref Nullable<BeginSnapshotOptions> other) { }

	public void Dispose() { }

}

