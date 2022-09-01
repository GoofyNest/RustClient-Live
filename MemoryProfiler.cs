public sealed class MemoryProfiler // TypeDefIndex: 3584
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static Action<string, bool> m_SnapshotFinished; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private static Action<MetaData> createMetaData; 


	[CompilerGeneratedAttribute] 
	private static void add_m_SnapshotFinished(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] 
	private static void remove_m_SnapshotFinished(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] 
	private static void add_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value) { }

	[CompilerGeneratedAttribute] 
	private static void remove_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value) { }

	[StaticAccessorAttribute] 
	[NativeConditionalAttribute] 
	[NativeMethodAttribute] 
	private static void StartOperation(uint captureFlag, bool requestScreenshot, string path) { }

	public static void TakeSnapshot(string path, Action<string, bool> finishCallback, CaptureFlags captureFlags = 3) { }

	public static void TakeSnapshot(string path, Action<string, bool> finishCallback, Action<string, bool, DebugScreenCapture> screenshotCallback, CaptureFlags captureFlags = 3) { }

	[RequiredByNativeCodeAttribute] 
	private static byte[] PrepareMetadata() { }

	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

	[RequiredByNativeCodeAttribute] 
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCodeAttribute] 
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }

}

