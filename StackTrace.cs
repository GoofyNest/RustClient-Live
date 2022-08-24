public class StackTrace // TypeDefIndex: 1503
{
public const int METHODS_TO_SKIP = 0;
	private StackFrame[] frames; 
	private readonly StackTrace[] captured_traces; 
	private bool debug_info; 
	private static bool isAotidSet; 
	private static string aotid; 

public virtual int FrameCount { get; }


public void .ctor() { }

public void .ctor(bool fNeedFileInfo) { }

public void .ctor(int skipFrames, bool fNeedFileInfo) { }

private void init_frames(int skipFrames, bool fNeedFileInfo) { }

private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

public void .ctor(Exception e, bool fNeedFileInfo) { }

public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

public virtual int get_FrameCount() { }

public virtual StackFrame GetFrame(int index) { }

	[ComVisibleAttribute] 
public virtual StackFrame[] GetFrames() { }

private static string GetAotId() { }

private bool AddFrames(StringBuilder sb) { }

internal void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi) { }

public override string ToString() { }

internal string ToString(StackTrace.TraceFormat traceFormat) { }

}

internal enum StackTrace.TraceFormat // TypeDefIndex: 1504
{
	public int value__; 
public const StackTrace.TraceFormat Normal = 0;
public const StackTrace.TraceFormat TrailingNewLine = 1;
public const StackTrace.TraceFormat NoResourceLookup = 2;

}

