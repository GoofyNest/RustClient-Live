public sealed class Screen // TypeDefIndex: 3386
{
public static int width { get; }
public static int height { get; }
public static float dpi { get; }
public static Resolution currentResolution { get; }
public static bool fullScreen { get; }
public static Resolution[] resolutions { get; }


	[NativeMethodAttribute] 
public static int get_width() { }

	[NativeMethodAttribute] 
public static int get_height() { }

	[NativeNameAttribute] 
public static float get_dpi() { }

public static Resolution get_currentResolution() { }

	[NativeNameAttribute] 
public static bool get_fullScreen() { }

	[NativeNameAttribute] 
public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate) { }

public static void SetResolution(int width, int height, FullScreenMode fullscreenMode) { }

	[FreeFunctionAttribute] 
public static Resolution[] get_resolutions() { }

private static void get_currentResolution_Injected(out Resolution ret) { }

}

