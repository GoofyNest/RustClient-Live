public class UnhandledExceptionEventArgs : EventArgs // TypeDefIndex: 330
{
	private object _Exception;
	private bool _IsTerminating;

	public object ExceptionObject { get; }
	public bool IsTerminating { get; }


	public void .ctor(object exception, bool isTerminating) { }

	[ReliabilityContractAttribute]
	public object get_ExceptionObject() { }

	[ReliabilityContractAttribute]
	public bool get_IsTerminating() { }

}

