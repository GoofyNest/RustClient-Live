public class StackTrace // TypeDefIndex: 1503
{	// Fields
	public const int METHODS_TO_SKIP = 0;
	private StackFrame[] frames; // 0x10
	private readonly StackTrace[] captured_traces; // 0x18
	private bool debug_info; // 0x20
	private static bool isAotidSet; // 0x0
	private static string aotid; // 0x8

	// Properties
	public virtual int FrameCount { get; }

	// Methods

	// RVA: 0xD81E80 Offset: 0xD81280 VA: 0x180D81E80
	public void .ctor() { }

	// RVA: 0xD81EF0 Offset: 0xD812F0 VA: 0x180D81EF0
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0xD81EB0 Offset: 0xD812B0 VA: 0x180D81EB0
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0xD81F50 Offset: 0xD81350 VA: 0x180D81F50
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0xD81F40 Offset: 0xD81340 VA: 0x180D81F40
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0xD81CD0 Offset: 0xD810D0 VA: 0x180D81CD0
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0xD81D80 Offset: 0xD81180 VA: 0x180D81D80
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0xD81F30 Offset: 0xD81330 VA: 0x180D81F30 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0xD816A0 Offset: 0xD80AA0 VA: 0x180D816A0 Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 6
	public virtual StackFrame[] GetFrames() { }

	// RVA: 0xD815A0 Offset: 0xD809A0 VA: 0x180D815A0
	private static string GetAotId() { }

	// RVA: 0xD81120 Offset: 0xD80520 VA: 0x180D81120
	private bool AddFrames(StringBuilder sb) { }

	// RVA: 0xD81710 Offset: 0xD80B10 VA: 0x180D81710
	internal void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi) { }

	// RVA: 0xD81BB0 Offset: 0xD80FB0 VA: 0x180D81BB0 Slot: 3
	public override string ToString() { }

	// RVA: 0xD81B90 Offset: 0xD80F90 VA: 0x180D81B90
	internal string ToString(StackTrace.TraceFormat traceFormat) { }

}

internal enum StackTrace.TraceFormat // TypeDefIndex: 1504
{	// Fields
	public int value__; // 0x0
	public const StackTrace.TraceFormat Normal = 0;
	public const StackTrace.TraceFormat TrailingNewLine = 1;
	public const StackTrace.TraceFormat NoResourceLookup = 2;

}

