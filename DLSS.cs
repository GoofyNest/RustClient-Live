public static class DLSS // TypeDefIndex: 8224
{
	public static extern bool InitDLSS() { }

	public static extern IntPtr GetRenderEventFunc() { }

	public static extern bool InitializeFeatures(uint optimalWidth, uint optimalHeight, uint displayWidth, uint displayHeight, int isHDR, bool lowResMotionVectors, bool depthInverted, float depthScale, NVSDK_NGX_PerfQuality_Value quality) { }

	public static extern bool QueryOptimalSettings(uint displayWidth, uint displayHeight, NVSDK_NGX_PerfQuality_Value quality, ref DlSSRecommendedSettings outRecommendedSettings) { }

	public static extern bool ReleaseFeatures() { }

	public static extern void ShutdownDLSS() { }

}

