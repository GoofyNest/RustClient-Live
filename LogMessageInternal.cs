internal struct LogMessageInternal : IGettable<LogMessage>, ISettable<LogMessage>, IDisposable // TypeDefIndex: 9011
{
	private IntPtr m_Category; 
	private IntPtr m_Message; 
	private LogLevel m_Level; 

	public Utf8String Category { get; set; }
	public Utf8String Message { get; set; }
	public LogLevel Level { get; set; }


	public Utf8String get_Category() { }

	public void set_Category(Utf8String value) { }

	public Utf8String get_Message() { }

	public void set_Message(Utf8String value) { }

	public LogLevel get_Level() { }

	public void set_Level(LogLevel value) { }

	public void Set(ref LogMessage other) { }

	public void Set(ref Nullable<LogMessage> other) { }

	public void Dispose() { }

	public void Get(out LogMessage output) { }

}

