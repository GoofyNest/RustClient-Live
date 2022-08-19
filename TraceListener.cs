public abstract class TraceListener : MarshalByRefObject, IDisposable // TypeDefIndex: 2643
{	// Fields
	private int indentLevel; // 0x18
	private int indentSize; // 0x1C
	private TraceOptions traceOptions; // 0x20
	private bool needIndent; // 0x24
	private string listenerName; // 0x28
	private TraceFilter filter; // 0x30

	// Properties
	public virtual bool IsThreadSafe { get; }
	public int IndentLevel { set; }
	public int IndentSize { set; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public TraceFilter Filter { get; }
	protected bool NeedIndent { get; set; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public TraceOptions TraceOutputOptions { get; }

	// Methods

	// RVA: 0x1733120 Offset: 0x1732520 VA: 0x181733120
	protected void .ctor(string name) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 7
	public virtual bool get_IsThreadSafe() { }

	// RVA: 0x1732640 Offset: 0x1731A40 VA: 0x181732640 Slot: 6
	public void Dispose() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	public virtual void Flush() { }

	// RVA: 0x1733160 Offset: 0x1732560 VA: 0x181733160
	public void set_IndentLevel(int value) { }

	// RVA: 0x1733180 Offset: 0x1732580 VA: 0x181733180
	public void set_IndentSize(int value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public TraceFilter get_Filter() { }

	// RVA: 0x7723F0 Offset: 0x7717F0 VA: 0x1807723F0
	protected bool get_NeedIndent() { }

	// RVA: 0x772430 Offset: 0x771830 VA: 0x180772430
	protected void set_NeedIndent(bool value) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public TraceOptions get_TraceOutputOptions() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Write(string message);

	// RVA: 0x1733070 Offset: 0x1732470 VA: 0x181733070 Slot: 11
	protected virtual void WriteIndent() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void WriteLine(string message);

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x17326C0 Offset: 0x1731AC0 VA: 0x1817326C0 Slot: 13
	public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message) { }

	// RVA: 0x1732F50 Offset: 0x1732350 VA: 0x181732F50
	private void WriteHeader(string source, TraceEventType eventType, int id) { }

	// RVA: 0x1732870 Offset: 0x1731C70 VA: 0x181732870
	private void WriteFooter(TraceEventCache eventCache) { }

	// RVA: 0x17326B0 Offset: 0x1731AB0 VA: 0x1817326B0
	internal bool IsEnabled(TraceOptions opts) { }

}

