public sealed class ExceptionDispatchInfo // TypeDefIndex: 1265
{

public sealed class ExceptionDispatchInfo
	private Exception m_Exception; 
	private object m_stackTrace; 

	internal object BinaryStackTraceArray { get; }
	public Exception SourceException { get; }


	private void .ctor(Exception exception) { }

	internal object get_BinaryStackTraceArray() { }

	public static ExceptionDispatchInfo Capture(Exception source) { }

	public Exception get_SourceException() { }

	public void Throw() { }

}

