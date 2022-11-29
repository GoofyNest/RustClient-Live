internal struct SessionSearchRemoveParameterOptionsInternal : ISettable<SessionSearchRemoveParameterOptions>, IDisposable // TypeDefIndex: 8595
{
	private int m_ApiVersion; 
	private IntPtr m_Key; 
	private ComparisonOp m_ComparisonOp; 

	public Utf8String Key { set; }
	public ComparisonOp ComparisonOp { set; }


	public void set_Key(Utf8String value) { }

	public void set_ComparisonOp(ComparisonOp value) { }

	public void Set(ref SessionSearchRemoveParameterOptions other) { }

	public void Set(ref Nullable<SessionSearchRemoveParameterOptions> other) { }

	public void Dispose() { }

}

