public sealed class ExceptionDispatchInfo // TypeDefIndex: 1265
{
public sealed class ExceptionDispatchInfo // TypeDefIndex: 1265
	private Exception m_Exception; // 0x10
	private object m_stackTrace; // 0x18

	internal object BinaryStackTraceArray { get; }
	public Exception SourceException { get; }


	private void .ctor(Exception exception) { }

	internal object get_BinaryStackTraceArray() { }

	public static ExceptionDispatchInfo Capture(Exception source) { }

	public Exception get_SourceException() { }

	public void Throw() { }

}

