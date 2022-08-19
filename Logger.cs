public class Logger : ILogger, ILogHandler // TypeDefIndex: 3458
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private ILogHandler <logHandler>k__BackingField; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private bool <logEnabled>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private LogType <filterLogType>k__BackingField; // 0x1C

	// Properties
	public ILogHandler logHandler { get; set; }
	public bool logEnabled { get; set; }
	public LogType filterLogType { get; set; }

	// Methods

	// RVA: 0x18E6000 Offset: 0x18E5400 VA: 0x1818E6000
	public void .ctor(ILogHandler logHandler) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 4
	public ILogHandler get_logHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0 Slot: 12
	public void set_logHandler(ILogHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0 Slot: 5
	public bool get_logEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2F0 Offset: 0x95A6F0 VA: 0x18095B2F0 Slot: 6
	public void set_logEnabled(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0 Slot: 13
	public LogType get_filterLogType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2E0 Offset: 0x95A6E0 VA: 0x18095B2E0 Slot: 14
	public void set_filterLogType(LogType value) { }

	// RVA: 0x18E5B70 Offset: 0x18E4F70 VA: 0x1818E5B70 Slot: 15
	public bool IsLogTypeAllowed(LogType logType) { }

	// RVA: 0x18E5A60 Offset: 0x18E4E60 VA: 0x1818E5A60
	private static string GetString(object message) { }

	// RVA: 0x18E5DB0 Offset: 0x18E51B0 VA: 0x1818E5DB0 Slot: 7
	public void Log(LogType logType, object message) { }

	// RVA: 0x18E5ED0 Offset: 0x18E52D0 VA: 0x1818E5ED0 Slot: 8
	public void Log(LogType logType, object message, Object context) { }

	// RVA: 0x18E5D10 Offset: 0x18E5110 VA: 0x1818E5D10 Slot: 9
	public void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: 0x18E5C70 Offset: 0x18E5070 VA: 0x1818E5C70 Slot: 10
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x18E5B90 Offset: 0x18E4F90 VA: 0x1818E5B90 Slot: 11
	public void LogException(Exception exception, Object context) { }

}

