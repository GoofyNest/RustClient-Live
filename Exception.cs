public class Exception : ISerializable, _Exception // TypeDefIndex: 218
{	// Fields
	[OptionalFieldAttribute] // RVA: 0x7B530 Offset: 0x7A930 VA: 0x18007B530
	private static object s_EDILock; // 0x0
	private string _className; // 0x10
	internal string _message; // 0x18
	private IDictionary _data; // 0x20
	private Exception _innerException; // 0x28
	private string _helpURL; // 0x30
	private object _stackTrace; // 0x38
	private string _stackTraceString; // 0x40
	private string _remoteStackTraceString; // 0x48
	private int _remoteStackIndex; // 0x50
	private object _dynamicMethods; // 0x58
	internal int _HResult; // 0x60
	private string _source; // 0x68
	[OptionalFieldAttribute] // RVA: 0x7B5F0 Offset: 0x7A9F0 VA: 0x18007B5F0
	private SafeSerializationManager _safeSerializationManager; // 0x70
	internal StackTrace[] captured_traces; // 0x78
	private IntPtr[] native_trace_ips; // 0x80
	private const int _COMPlusExceptionCode = -532462766;

	// Properties
	public virtual string Message { get; }
	public virtual IDictionary Data { get; }
	public Exception InnerException { get; }
	public virtual string StackTrace { get; }
	public virtual string Source { get; }
	public int HResult { get; set; }

	// Methods

	// RVA: 0x10D7560 Offset: 0x10D6960 VA: 0x1810D7560
	private void Init() { }

	// RVA: 0x10D7BA0 Offset: 0x10D6FA0 VA: 0x1810D7BA0
	public void .ctor() { }

	// RVA: 0x10D7C20 Offset: 0x10D7020 VA: 0x1810D7C20
	public void .ctor(string message) { }

	// RVA: 0x10D7BC0 Offset: 0x10D6FC0 VA: 0x1810D7BC0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x10D7C60 Offset: 0x10D7060 VA: 0x1810D7C60
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10D8070 Offset: 0x10D7470 VA: 0x1810D8070 Slot: 5
	public virtual string get_Message() { }

	// RVA: 0x10D7FE0 Offset: 0x10D73E0 VA: 0x1810D7FE0 Slot: 6
	public virtual IDictionary get_Data() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	private static bool IsImmutableAgileException(Exception e) { }

	// RVA: 0x10D6FC0 Offset: 0x10D63C0 VA: 0x1810D6FC0
	private string GetClassName() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 7
	public Exception get_InnerException() { }

	// RVA: 0x10D82C0 Offset: 0x10D76C0 VA: 0x1810D82C0 Slot: 8
	public virtual string get_StackTrace() { }

	// RVA: 0x10D7470 Offset: 0x10D6870 VA: 0x1810D7470
	private string GetStackTrace(bool needFileInfo) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCA0 Offset: 0x58D0A0 VA: 0x18058DCA0
	internal void SetErrorCode(int hr) { }

	// RVA: 0x10D8180 Offset: 0x10D7580 VA: 0x1810D8180 Slot: 9
	public virtual string get_Source() { }

	// RVA: 0x10D7B30 Offset: 0x10D6F30 VA: 0x1810D7B30 Slot: 3
	public override string ToString() { }

	// RVA: 0x10D7740 Offset: 0x10D6B40 VA: 0x1810D7740
	private string ToString(bool needFileLineInfo, bool needMessage) { }

	// RVA: 0x10D7060 Offset: 0x10D6460 VA: 0x1810D7060 Slot: 10
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[OnDeserializedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10D75F0 Offset: 0x10D69F0 VA: 0x1810D75F0
	private void OnDeserialized(StreamingContext context) { }

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) { }

	// RVA: 0x10D7690 Offset: 0x10D6A90 VA: 0x1810D7690
	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) { }

	// RVA: 0x58DC10 Offset: 0x58D010 VA: 0x18058DC10
	public int get_HResult() { }

	// RVA: 0x58DCA0 Offset: 0x58D0A0 VA: 0x18058DCA0
	protected void set_HResult(int value) { }

	// RVA: 0x10D7550 Offset: 0x10D6950 VA: 0x1810D7550 Slot: 11
	public Type GetType() { }

	// RVA: 0x10D7010 Offset: 0x10D6410 VA: 0x1810D7010
	internal static string GetMessageFromNativeResources(Exception.ExceptionMessageKind kind) { }

	// RVA: 0x10D6EE0 Offset: 0x10D62E0 VA: 0x1810D6EE0
	internal Exception FixRemotingException() { }

	// RVA: 0x10D7680 Offset: 0x10D6A80 VA: 0x1810D7680
	internal static void ReportUnhandledException(Exception exception) { }

	// RVA: 0x10D7B40 Offset: 0x10D6F40 VA: 0x1810D7B40
	private static void .cctor() { }

}

internal enum Exception.ExceptionMessageKind // TypeDefIndex: 219
{	// Fields
	public int value__; // 0x0
	public const Exception.ExceptionMessageKind ThreadAbort = 1;
	public const Exception.ExceptionMessageKind ThreadInterrupted = 2;
	public const Exception.ExceptionMessageKind OutOfMemory = 3;

}

