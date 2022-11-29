internal struct InitializeOptionsInternal : ISettable<InitializeOptions>, IDisposable // TypeDefIndex: 9871
{
	private int m_ApiVersion; 
	private IntPtr m_AllocateMemoryFunction; 
	private IntPtr m_ReallocateMemoryFunction; 
	private IntPtr m_ReleaseMemoryFunction; 
	private IntPtr m_ProductName; 
	private IntPtr m_ProductVersion; 
	private IntPtr m_Reserved; 
	private IntPtr m_SystemInitializeOptions; 
	private IntPtr m_OverrideThreadAffinity; 

	public IntPtr AllocateMemoryFunction { set; }
	public IntPtr ReallocateMemoryFunction { set; }
	public IntPtr ReleaseMemoryFunction { set; }
	public Utf8String ProductName { set; }
	public Utf8String ProductVersion { set; }
	public IntPtr SystemInitializeOptions { set; }
	public Nullable<InitializeThreadAffinity> OverrideThreadAffinity { set; }


	public void set_AllocateMemoryFunction(IntPtr value) { }

	public void set_ReallocateMemoryFunction(IntPtr value) { }

	public void set_ReleaseMemoryFunction(IntPtr value) { }

	public void set_ProductName(Utf8String value) { }

	public void set_ProductVersion(Utf8String value) { }

	public void set_SystemInitializeOptions(IntPtr value) { }

	public void set_OverrideThreadAffinity(Nullable<InitializeThreadAffinity> value) { }

	public void Set(ref InitializeOptions other) { }

	public void Set(ref Nullable<InitializeOptions> other) { }

	public void Dispose() { }

}

