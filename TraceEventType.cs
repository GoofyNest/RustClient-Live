public enum TraceEventType // TypeDefIndex: 2639
{
	public int value__; 
public const TraceEventType Critical = 1;
public const TraceEventType Error = 2;
public const TraceEventType Warning = 4;
public const TraceEventType Information = 8;
public const TraceEventType Verbose = 16;
	[EditorBrowsableAttribute] 
public const TraceEventType Start = 256;
	[EditorBrowsableAttribute] 
public const TraceEventType Stop = 512;
	[EditorBrowsableAttribute] 
public const TraceEventType Suspend = 1024;
	[EditorBrowsableAttribute] 
public const TraceEventType Resume = 2048;
	[EditorBrowsableAttribute] 
public const TraceEventType Transfer = 4096;

}

