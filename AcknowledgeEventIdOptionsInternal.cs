internal struct AcknowledgeEventIdOptionsInternal : ISettable<AcknowledgeEventIdOptions>, IDisposable // TypeDefIndex: 8321
{
	private int m_ApiVersion; 
	private ulong m_UiEventId; 
	private Result m_Result; 

	public ulong UiEventId { set; }
	public Result Result { set; }


	public void set_UiEventId(ulong value) { }

	public void set_Result(Result value) { }

	public void Set(ref AcknowledgeEventIdOptions other) { }

	public void Set(ref Nullable<AcknowledgeEventIdOptions> other) { }

	public void Dispose() { }

}

