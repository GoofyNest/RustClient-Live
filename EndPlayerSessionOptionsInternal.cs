internal struct EndPlayerSessionOptionsInternal : ISettable<EndPlayerSessionOptions>, IDisposable // TypeDefIndex: 9046
{
	private int m_ApiVersion; 
	private EndPlayerSessionOptionsAccountIdInternal m_AccountId; 

	public EndPlayerSessionOptionsAccountId AccountId { set; }


	public void set_AccountId(EndPlayerSessionOptionsAccountId value) { }

	public void Set(ref EndPlayerSessionOptions other) { }

	public void Set(ref Nullable<EndPlayerSessionOptions> other) { }

	public void Dispose() { }

}

