public abstract class TraceListener : MarshalByRefObject, IDisposable // TypeDefIndex: 2643
{	private int indentLevel; // 0x18
	private int indentSize; // 0x1C
	private TraceOptions traceOptions; // 0x20
	private bool needIndent; // 0x24
	private string listenerName; // 0x28
	private TraceFilter filter; // 0x30

	public virtual bool IsThreadSafe { get; }
	public int IndentLevel { set; }
	public int IndentSize { set; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public TraceFilter Filter { get; }
	protected bool NeedIndent { get; set; }
	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public TraceOptions TraceOutputOptions { get; }


	protected void .ctor(string name) { }

	public virtual bool get_IsThreadSafe() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual void Flush() { }

	public void set_IndentLevel(int value) { }

	public void set_IndentSize(int value) { }

	public TraceFilter get_Filter() { }

	protected bool get_NeedIndent() { }

	protected void set_NeedIndent(bool value) { }

	public TraceOptions get_TraceOutputOptions() { }

	public abstract void Write(string message);

	protected virtual void WriteIndent() { }

	public abstract void WriteLine(string message);

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message) { }

	private void WriteHeader(string source, TraceEventType eventType, int id) { }

	private void WriteFooter(TraceEventCache eventCache) { }

	internal bool IsEnabled(TraceOptions opts) { }

}

