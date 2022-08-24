public class StackFrame // TypeDefIndex: 1502
{
	public const int OFFSET_UNKNOWN = -1;
	private int ilOffset; 
	private int nativeOffset; 
	private long methodAddress; 
	private uint methodIndex; 
	private MethodBase methodBase; 
	private string fileName; 
	private int lineNumber; 
	private int columnNumber; 
	private string internalMethodName; 


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

