public class StackFrame // TypeDefIndex: 1502
{	// Fields
	public const int OFFSET_UNKNOWN = -1;
	private int ilOffset; // 0x10
	private int nativeOffset; // 0x14
	private long methodAddress; // 0x18
	private uint methodIndex; // 0x20
	private MethodBase methodBase; // 0x28
	private string fileName; // 0x30
	private int lineNumber; // 0x38
	private int columnNumber; // 0x3C
	private string internalMethodName; // 0x40

	// Methods

	// RVA: 0xD81110 Offset: 0xD80510 VA: 0x180D81110
	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column) { }

	// RVA: 0xD81010 Offset: 0xD80410 VA: 0x180D81010
	public void .ctor() { }

	// RVA: 0xD81080 Offset: 0xD80480 VA: 0x180D81080
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70 Slot: 4
	public virtual int GetFileLineNumber() { }

	// RVA: 0x5FC790 Offset: 0x5FBB90 VA: 0x1805FC790 Slot: 5
	public virtual int GetFileColumnNumber() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 6
	public virtual string GetFileName() { }

	// RVA: 0xD80DE0 Offset: 0xD801E0 VA: 0x180D80DE0
	internal string GetSecureFileName() { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480 Slot: 7
	public virtual int GetILOffset() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 8
	public virtual MethodBase GetMethod() { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230 Slot: 9
	public virtual int GetNativeOffset() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal long GetMethodAddress() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	internal uint GetMethodIndex() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	internal string GetInternalMethodName() { }

	// RVA: 0xD80E50 Offset: 0xD80250 VA: 0x180D80E50 Slot: 3
	public override string ToString() { }

}

