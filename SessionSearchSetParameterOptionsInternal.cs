internal struct SessionSearchSetParameterOptionsInternal : ISettable<SessionSearchSetParameterOptions>, IDisposable // TypeDefIndex: 8601
{
	private int m_ApiVersion;
	private IntPtr m_Parameter;
	private ComparisonOp m_ComparisonOp;

	public Nullable<AttributeData> Parameter { set; }
	public ComparisonOp ComparisonOp { set; }


	public void set_Parameter(Nullable<AttributeData> value) { }

	public void set_ComparisonOp(ComparisonOp value) { }

	public void Set(ref SessionSearchSetParameterOptions other) { }

	public void Set(ref Nullable<SessionSearchSetParameterOptions> other) { }

	public void Dispose() { }

}

