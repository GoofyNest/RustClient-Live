public static class DLSS // TypeDefIndex: 8224
{	// Methods

	// RVA: 0x1066B40 Offset: 0x1065F40 VA: 0x181066B40
	public static extern bool InitDLSS() { }

	// RVA: 0x1066AD0 Offset: 0x1065ED0 VA: 0x181066AD0
	public static extern IntPtr GetRenderEventFunc() { }

	// RVA: 0x1066BB0 Offset: 0x1065FB0 VA: 0x181066BB0
	public static extern bool InitializeFeatures(uint optimalWidth, uint optimalHeight, uint displayWidth, uint displayHeight, int isHDR, bool lowResMotionVectors, bool depthInverted, float depthScale, NVSDK_NGX_PerfQuality_Value quality) { }

	// RVA: 0x1066CA0 Offset: 0x10660A0 VA: 0x181066CA0
	public static extern bool QueryOptimalSettings(uint displayWidth, uint displayHeight, NVSDK_NGX_PerfQuality_Value quality, ref DlSSRecommendedSettings outRecommendedSettings) { }

	// RVA: 0x1066D40 Offset: 0x1066140 VA: 0x181066D40
	public static extern bool ReleaseFeatures() { }

	// RVA: 0x1066DB0 Offset: 0x10661B0 VA: 0x181066DB0
	public static extern void ShutdownDLSS() { }

}

