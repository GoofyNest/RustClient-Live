public class Exception : ISerializable, _Exception // TypeDefIndex: 218
{
	[OptionalFieldAttribute]
	private static object s_EDILock;
	private string _className;
	internal string _message;
	private IDictionary _data;
	private Exception _innerException;
	private string _helpURL;
	private object _stackTrace;
	private string _stackTraceString;
	private string _remoteStackTraceString;
	private int _remoteStackIndex;
	private object _dynamicMethods;
	internal int _HResult;
	private string _source;
	[OptionalFieldAttribute]
	private SafeSerializationManager _safeSerializationManager;
	internal StackTrace[] captured_traces;
	private IntPtr[] native_trace_ips;
	private const int _COMPlusExceptionCode = -532462766;

	public virtual string Message { get; }
	public virtual IDictionary Data { get; }
	public Exception InnerException { get; }
	public virtual string StackTrace { get; }
	public virtual string Source { get; }
	public int HResult { get; set; }


	private void Init() { }

	public void .ctor() { }

	public void .ctor(string message) { }

	public void .ctor(string message, Exception innerException) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public virtual string get_Message() { }

	public virtual IDictionary get_Data() { }

	private static bool IsImmutableAgileException(Exception e) { }

	private string GetClassName() { }

	public Exception get_InnerException() { }

	public virtual string get_StackTrace() { }

	private string GetStackTrace(bool needFileInfo) { }

	[FriendAccessAllowedAttribute]
	internal void SetErrorCode(int hr) { }

	public virtual string get_Source() { }

	public override string ToString() { }

	private string ToString(bool needFileLineInfo, bool needMessage) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[OnDeserializedAttribute]
	private void OnDeserialized(StreamingContext context) { }

	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) { }

	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) { }

	public int get_HResult() { }

	protected void set_HResult(int value) { }

	public Type GetType() { }

	internal static string GetMessageFromNativeResources(Exception.ExceptionMessageKind kind) { }

	internal Exception FixRemotingException() { }

	internal static void ReportUnhandledException(Exception exception) { }

	private static void .cctor() { }

}

internal enum Exception.ExceptionMessageKind // TypeDefIndex: 219
{
	public int value__;
	public const Exception.ExceptionMessageKind ThreadAbort = 1;
	public const Exception.ExceptionMessageKind ThreadInterrupted = 2;
	public const Exception.ExceptionMessageKind OutOfMemory = 3;

}

