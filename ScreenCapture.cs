public static class ScreenCapture // TypeDefIndex: 4558
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x78350 Offset: 0x77750 VA: 0x180078350
public static class ScreenCapture // TypeDefIndex: 4558
	// Methods

	// RVA: 0x231DE30 Offset: 0x231D230 VA: 0x18231DE30
	public static void CaptureScreenshot(string filename, int superSize) { }

	// RVA: 0x231DE80 Offset: 0x231D280 VA: 0x18231DE80
	private static void CaptureScreenshot(string filename, int superSize, ScreenCapture.StereoScreenCaptureMode CaptureMode) { }

}

public enum ScreenCapture.StereoScreenCaptureMode // TypeDefIndex: 4559
{	// Fields
	public int value__; // 0x0
	public const ScreenCapture.StereoScreenCaptureMode LeftEye = 1;
	public const ScreenCapture.StereoScreenCaptureMode RightEye = 2;
	public const ScreenCapture.StereoScreenCaptureMode BothEyes = 3;

}

