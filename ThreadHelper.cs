internal class ThreadHelper // TypeDefIndex: 800
{	// Fields
	private Delegate _start; // 0x10
	private object _startArg; // 0x18
	private ExecutionContext _executionContext; // 0x20
	internal static ContextCallback _ccb; // 0x0

	// Methods

	// RVA: 0x1605400 Offset: 0x1604800 VA: 0x181605400
	private static void .cctor() { }

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	internal void .ctor(Delegate start) { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	internal void SetExecutionContextHelper(ExecutionContext ec) { }

	// RVA: 0x1605100 Offset: 0x1604500 VA: 0x181605100
	private static void ThreadStart_Context(object state) { }

	// RVA: 0x1605200 Offset: 0x1604600 VA: 0x181605200
	internal void ThreadStart(object obj) { }

	// RVA: 0x1605310 Offset: 0x1604710 VA: 0x181605310
	internal void ThreadStart() { }

}

