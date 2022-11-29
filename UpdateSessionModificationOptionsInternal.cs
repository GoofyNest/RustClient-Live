internal struct UpdateSessionModificationOptionsInternal : ISettable<UpdateSessionModificationOptions>, IDisposable // TypeDefIndex: 8616
{
	private int m_ApiVersion; 
	private IntPtr m_SessionName; 

	public Utf8String SessionName { set; }


	public void set_SessionName(Utf8String value) { }

	public void Set(ref UpdateSessionModificationOptions other) { }

	public void Set(ref Nullable<UpdateSessionModificationOptions> other) { }

	public void Dispose() { }

}

