public class UnhandledExceptionEventArgs : EventArgs // TypeDefIndex: 330
{	// Fields
	private object _Exception; // 0x10
	private bool _IsTerminating; // 0x18

	// Properties
	public object ExceptionObject { get; }
	public bool IsTerminating { get; }

	// Methods

	// RVA: 0x2140CC0 Offset: 0x21400C0 VA: 0x182140CC0
	public void .ctor(object exception, bool isTerminating) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public object get_ExceptionObject() { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	public bool get_IsTerminating() { }

}

