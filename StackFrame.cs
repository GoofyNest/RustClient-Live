public class StackFrame // TypeDefIndex: 1502
{	public const int OFFSET_UNKNOWN = -1;
	private int ilOffset; // 0x10
	private int nativeOffset; // 0x14
	private long methodAddress; // 0x18
	private uint methodIndex; // 0x20
	private MethodBase methodBase; // 0x28
	private string fileName; // 0x30
	private int lineNumber; // 0x38
	private int columnNumber; // 0x3C
	private string internalMethodName; // 0x40


	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column) { }

	public void .ctor() { }

	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	public virtual int GetFileLineNumber() { }

	public virtual int GetFileColumnNumber() { }

	public virtual string GetFileName() { }

	internal string GetSecureFileName() { }

	public virtual int GetILOffset() { }

	public virtual MethodBase GetMethod() { }

	public virtual int GetNativeOffset() { }

	internal long GetMethodAddress() { }

	internal uint GetMethodIndex() { }

	internal string GetInternalMethodName() { }

	public override string ToString() { }

}

