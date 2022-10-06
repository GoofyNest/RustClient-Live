public static class ScreenCapture // TypeDefIndex: 4561
{

[NativeHeaderAttribute] 
public static class ScreenCapture

	public static void CaptureScreenshot(string filename, int superSize) { }

	private static void CaptureScreenshot(string filename, int superSize, ScreenCapture.StereoScreenCaptureMode CaptureMode) { }

}

public enum ScreenCapture.StereoScreenCaptureMode // TypeDefIndex: 4562
{
	public int value__; 
	public const ScreenCapture.StereoScreenCaptureMode LeftEye = 1;
	public const ScreenCapture.StereoScreenCaptureMode RightEye = 2;
	public const ScreenCapture.StereoScreenCaptureMode BothEyes = 3;

}

