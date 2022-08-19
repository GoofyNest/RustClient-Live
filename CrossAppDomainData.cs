internal class CrossAppDomainData // TypeDefIndex: 1188
{	// Fields
	private object _ContextID; // 0x10
	private int _DomainID; // 0x18
	private string _processGuid; // 0x20

	// Properties
	internal int DomainID { get; }
	internal string ProcessID { get; }

	// Methods

	// RVA: 0xFDFFE0 Offset: 0xFDF3E0 VA: 0x180FDFFE0
	internal void .ctor(int domainId) { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	internal int get_DomainID() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal string get_ProcessID() { }

}

