internal class ISteamUtils : SteamInterface // TypeDefIndex: 5139
{

	internal void .ctor(bool IsGameServer) { }

	internal static extern IntPtr SteamAPI_SteamUtils_v010() { }

	public override IntPtr GetUserInterfacePointer() { }

	internal static extern IntPtr SteamAPI_SteamGameServerUtils_v010() { }

	public override IntPtr GetServerInterfacePointer() { }

	private static extern Utf8StringPointer _GetIPCountry(IntPtr self) { }

	internal string GetIPCountry() { }

	private static extern bool _GetImageSize(IntPtr self, int iImage, ref uint pnWidth, ref uint pnHeight) { }

	internal bool GetImageSize(int iImage, ref uint pnWidth, ref uint pnHeight) { }

	private static extern bool _GetImageRGBA(IntPtr self, int iImage, [In] [Out] byte[] pubDest, int nDestBufferSize) { }

	internal bool GetImageRGBA(int iImage, [In] [Out] byte[] pubDest, int nDestBufferSize) { }

	private static extern bool _IsAPICallCompleted(IntPtr self, SteamAPICall_t hSteamAPICall, ref bool pbFailed) { }

	internal bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, ref bool pbFailed) { }

	private static extern bool _GetAPICallResult(IntPtr self, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

	internal bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

	private static extern bool _IsOverlayEnabled(IntPtr self) { }

	internal bool IsOverlayEnabled() { }

	private static extern bool _InitFilterText(IntPtr self, uint unFilterOptions) { }

	internal bool InitFilterText(uint unFilterOptions) { }

	private static extern int _FilterText(IntPtr self, TextFilteringContext eContext, SteamId sourceSteamID, string pchInputMessage, IntPtr pchOutFilteredText, uint nByteSizeOutFilteredText) { }

	internal int FilterText(TextFilteringContext eContext, SteamId sourceSteamID, string pchInputMessage, out string pchOutFilteredText) { }

}

