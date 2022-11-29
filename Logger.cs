public class Logger : ILogger, ILogHandler // TypeDefIndex: 3459
{
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private ILogHandler <logHandler>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private bool <logEnabled>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private LogType <filterLogType>k__BackingField; 

	public ILogHandler logHandler { get; set; }
	public bool logEnabled { get; set; }
	public LogType filterLogType { get; set; }


	public void .ctor(ILogHandler logHandler) { }

	[CompilerGeneratedAttribute] 
	public ILogHandler get_logHandler() { }

	[CompilerGeneratedAttribute] 
	public void set_logHandler(ILogHandler value) { }

	[CompilerGeneratedAttribute] 
	public bool get_logEnabled() { }

	[CompilerGeneratedAttribute] 
	public void set_logEnabled(bool value) { }

	[CompilerGeneratedAttribute] 
	public LogType get_filterLogType() { }

	[CompilerGeneratedAttribute] 
	public void set_filterLogType(LogType value) { }

	public bool IsLogTypeAllowed(LogType logType) { }

	private static string GetString(object message) { }

	public void Log(LogType logType, object message) { }

	public void Log(LogType logType, object message, Object context) { }

	public void LogFormat(LogType logType, string format, object[] args) { }

	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	public void LogException(Exception exception, Object context) { }

}

