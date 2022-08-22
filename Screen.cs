public sealed class Screen // TypeDefIndex: 3386
{	public static int width { get; }
	public static int height { get; }
	public static float dpi { get; }
	public static Resolution currentResolution { get; }
	public static bool fullScreen { get; }
	public static Resolution[] resolutions { get; }


	[NativeMethodAttribute] // RVA: 0x83720 Offset: 0x82B20 VA: 0x180083720
	public static int get_width() { }

	[NativeMethodAttribute] // RVA: 0x838B0 Offset: 0x82CB0 VA: 0x1800838B0
	public static int get_height() { }

	[NativeNameAttribute] // RVA: 0x83930 Offset: 0x82D30 VA: 0x180083930
	public static float get_dpi() { }

	public static Resolution get_currentResolution() { }

	[NativeNameAttribute] // RVA: 0x83AA0 Offset: 0x82EA0 VA: 0x180083AA0
	public static bool get_fullScreen() { }

	[NativeNameAttribute] // RVA: 0x83B90 Offset: 0x82F90 VA: 0x180083B90
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate) { }

	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode) { }

	[FreeFunctionAttribute] // RVA: 0x83D50 Offset: 0x83150 VA: 0x180083D50
	public static Resolution[] get_resolutions() { }

	private static void get_currentResolution_Injected(out Resolution ret) { }

}

