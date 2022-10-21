internal struct LobbySearchSetParameterOptionsInternal : ISettable<LobbySearchSetParameterOptions>, IDisposable // TypeDefIndex: 9192
{
	private int m_ApiVersion; 
	private IntPtr m_Parameter; 
	private ComparisonOp m_ComparisonOp; 

	public Nullable<AttributeData> Parameter { set; }
	public ComparisonOp ComparisonOp { set; }


	public void set_Parameter(Nullable<AttributeData> value) { }

	public void set_ComparisonOp(ComparisonOp value) { }

	public void Set(ref LobbySearchSetParameterOptions other) { }

	public void Set(ref Nullable<LobbySearchSetParameterOptions> other) { }

	public void Dispose() { }

}

