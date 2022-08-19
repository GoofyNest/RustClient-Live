internal sealed class DebugLogHandler : ILogHandler // TypeDefIndex: 3370
{	// Methods

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1822B80 Offset: 0x1821F80 VA: 0x181822B80
	internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj) { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1822B30 Offset: 0x1821F30 VA: 0x181822B30
	internal static void Internal_LogException(Exception exception, Object obj) { }

	// RVA: 0x1822C80 Offset: 0x1822080 VA: 0x181822C80 Slot: 4
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x1822BE0 Offset: 0x1821FE0 VA: 0x181822BE0 Slot: 5
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

