internal struct UpdateSessionOptionsInternal : ISettable<UpdateSessionOptions>, IDisposable // TypeDefIndex: 8622
{
	private int m_ApiVersion;
	private IntPtr m_SessionModificationHandle;

	public SessionModification SessionModificationHandle { set; }


	public void set_SessionModificationHandle(SessionModification value) { }

	public void Set(ref UpdateSessionOptions other) { }

	public void Set(ref Nullable<UpdateSessionOptions> other) { }

	public void Dispose() { }

}

