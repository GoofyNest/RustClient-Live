public sealed class ExceptionDispatchInfo // TypeDefIndex: 1265
{
// Namespace: System.Runtime.ExceptionServices
public sealed class ExceptionDispatchInfo // TypeDefIndex: 1265
	// Fields
	private Exception m_Exception; // 0x10
	private object m_stackTrace; // 0x18

	// Properties
	internal object BinaryStackTraceArray { get; }
	public Exception SourceException { get; }

	// Methods

	// RVA: 0xFE1200 Offset: 0xFE0600 VA: 0x180FE1200
	private void .ctor(Exception exception) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal object get_BinaryStackTraceArray() { }

	// RVA: 0xFE0FC0 Offset: 0xFE03C0 VA: 0x180FE0FC0
	public static ExceptionDispatchInfo Capture(Exception source) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Exception get_SourceException() { }

	// RVA: 0xFE1190 Offset: 0xFE0590 VA: 0x180FE1190
	public void Throw() { }

}

