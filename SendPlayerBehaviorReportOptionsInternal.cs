internal struct SendPlayerBehaviorReportOptionsInternal : ISettable<SendPlayerBehaviorReportOptions>, IDisposable // TypeDefIndex: 8595
{
	private int m_ApiVersion; 
	private IntPtr m_ReporterUserId; 
	private IntPtr m_ReportedUserId; 
	private PlayerReportsCategory m_Category; 
	private IntPtr m_Message; 
	private IntPtr m_Context; 

	public ProductUserId ReporterUserId { set; }
	public ProductUserId ReportedUserId { set; }
	public PlayerReportsCategory Category { set; }
	public Utf8String Message { set; }
	public Utf8String Context { set; }


	public void set_ReporterUserId(ProductUserId value) { }

	public void set_ReportedUserId(ProductUserId value) { }

	public void set_Category(PlayerReportsCategory value) { }

	public void set_Message(Utf8String value) { }

	public void set_Context(Utf8String value) { }

	public void Set(ref SendPlayerBehaviorReportOptions other) { }

	public void Set(ref Nullable<SendPlayerBehaviorReportOptions> other) { }

	public void Dispose() { }

}

