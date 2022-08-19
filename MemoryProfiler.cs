public sealed class MemoryProfiler // TypeDefIndex: 3584
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static Action<string, bool> m_SnapshotFinished; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static Action<MetaData> createMetaData; // 0x10

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18EE240 Offset: 0x18ED640 VA: 0x1818EE240
	private static void add_m_SnapshotFinished(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18EE3A0 Offset: 0x18ED7A0 VA: 0x1818EE3A0
	private static void remove_m_SnapshotFinished(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18EE190 Offset: 0x18ED590 VA: 0x1818EE190
	private static void add_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18EE2F0 Offset: 0x18ED6F0 VA: 0x1818EE2F0
	private static void remove_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value) { }

	[StaticAccessorAttribute] // RVA: 0xD7350 Offset: 0xD6750 VA: 0x1800D7350
	[NativeMethodAttribute] // RVA: 0xD7350 Offset: 0xD6750 VA: 0x1800D7350
	[NativeConditionalAttribute] // RVA: 0xD7350 Offset: 0xD6750 VA: 0x1800D7350
	// RVA: 0x18EDDA0 Offset: 0x18ED1A0 VA: 0x1818EDDA0
	private static void StartOperation(uint captureFlag, bool requestScreenshot, string path) { }

	// RVA: 0x18EDE00 Offset: 0x18ED200 VA: 0x1818EDE00
	public static void TakeSnapshot(string path, Action<string, bool> finishCallback, CaptureFlags captureFlags = 3) { }

	// RVA: 0x18EDE20 Offset: 0x18ED220 VA: 0x1818EDE20
	public static void TakeSnapshot(string path, Action<string, bool> finishCallback, Action<string, bool, DebugScreenCapture> screenshotCallback, CaptureFlags captureFlags = 3) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18ED950 Offset: 0x18ECD50 VA: 0x1818ED950
	private static byte[] PrepareMetadata() { }

	// RVA: 0x18EE040 Offset: 0x18ED440 VA: 0x1818EE040
	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	// RVA: 0x18EE0F0 Offset: 0x18ED4F0 VA: 0x1818EE0F0
	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18ED8D0 Offset: 0x18ECCD0 VA: 0x1818ED8D0
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18EDC90 Offset: 0x18ED090 VA: 0x1818EDC90
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }

}

