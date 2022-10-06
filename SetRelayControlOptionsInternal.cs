internal struct SetRelayControlOptionsInternal : ISettable<SetRelayControlOptions>, IDisposable // TypeDefIndex: 8996
{
	private int m_ApiVersion; 
	private RelayControl m_RelayControl; 

	public RelayControl RelayControl { set; }


	public void set_RelayControl(RelayControl value) { }

	public void Set(ref SetRelayControlOptions other) { }

	public void Set(ref Nullable<SetRelayControlOptions> other) { }

	public void Dispose() { }

}

