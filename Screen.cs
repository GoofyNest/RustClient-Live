public sealed class Screen // TypeDefIndex: 3386
{	// Properties
	public static int width { get; }
	public static int height { get; }
	public static float dpi { get; }
	public static Resolution currentResolution { get; }
	public static bool fullScreen { get; }
	public static Resolution[] resolutions { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x83720 Offset: 0x82B20 VA: 0x180083720
	// RVA: 0x19AFAF0 Offset: 0x19AEEF0 VA: 0x1819AFAF0
	public static int get_width() { }

	[NativeMethodAttribute] // RVA: 0x838B0 Offset: 0x82CB0 VA: 0x1800838B0
	// RVA: 0x19AFA90 Offset: 0x19AEE90 VA: 0x1819AFA90
	public static int get_height() { }

	[NativeNameAttribute] // RVA: 0x83930 Offset: 0x82D30 VA: 0x180083930
	// RVA: 0x19AFA30 Offset: 0x19AEE30 VA: 0x1819AFA30
	public static float get_dpi() { }

	// RVA: 0x19AF9F0 Offset: 0x19AEDF0 VA: 0x1819AF9F0
	public static Resolution get_currentResolution() { }

	[NativeNameAttribute] // RVA: 0x83AA0 Offset: 0x82EA0 VA: 0x180083AA0
	// RVA: 0x19AFA60 Offset: 0x19AEE60 VA: 0x1819AFA60
	public static bool get_fullScreen() { }

	[NativeNameAttribute] // RVA: 0x83B90 Offset: 0x82F90 VA: 0x180083B90
	// RVA: 0x19AF8F0 Offset: 0x19AECF0 VA: 0x1819AF8F0
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate) { }

	// RVA: 0x19AF950 Offset: 0x19AED50 VA: 0x1819AF950
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode) { }

	[FreeFunctionAttribute] // RVA: 0x83D50 Offset: 0x83150 VA: 0x180083D50
	// RVA: 0x19AFAC0 Offset: 0x19AEEC0 VA: 0x1819AFAC0
	public static Resolution[] get_resolutions() { }

	// RVA: 0x19AF9B0 Offset: 0x19AEDB0 VA: 0x1819AF9B0
	private static void get_currentResolution_Injected(out Resolution ret) { }

}

