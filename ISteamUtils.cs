internal class ISteamUtils : SteamInterface // TypeDefIndex: 5133
{	// Methods

	// RVA: 0xDD3400 Offset: 0xDD2800 VA: 0x180DD3400
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDDAB40 Offset: 0xDD9F40 VA: 0x180DDAB40
	internal static extern IntPtr SteamAPI_SteamUtils_v010() { }

	// RVA: 0xDDAB40 Offset: 0xDD9F40 VA: 0x180DDAB40 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDDAAD0 Offset: 0xDD9ED0 VA: 0x180DDAAD0
	internal static extern IntPtr SteamAPI_SteamGameServerUtils_v010() { }

	// RVA: 0xDDAAD0 Offset: 0xDD9ED0 VA: 0x180DDAAD0 Slot: 5
	public override IntPtr GetServerInterfacePointer() { }

	// RVA: 0xDDAF10 Offset: 0xDDA310 VA: 0x180DDAF10
	private static extern Utf8StringPointer _GetIPCountry(IntPtr self) { }

	// RVA: 0xDDA8E0 Offset: 0xDD9CE0 VA: 0x180DDA8E0
	internal string GetIPCountry() { }

	// RVA: 0xDDB040 Offset: 0xDDA440 VA: 0x180DDB040
	private static extern bool _GetImageSize(IntPtr self, int iImage, ref uint pnWidth, ref uint pnHeight) { }

	// RVA: 0xDDAA20 Offset: 0xDD9E20 VA: 0x180DDAA20
	internal bool GetImageSize(int iImage, ref uint pnWidth, ref uint pnHeight) { }

	// RVA: 0xDDAF90 Offset: 0xDDA390 VA: 0x180DDAF90
	private static extern bool _GetImageRGBA(IntPtr self, int iImage, [In] [Out] byte[] pubDest, int nDestBufferSize) { }

	// RVA: 0xDDA970 Offset: 0xDD9D70 VA: 0x180DDA970
	internal bool GetImageRGBA(int iImage, [In] [Out] byte[] pubDest, int nDestBufferSize) { }

	// RVA: 0xDDB180 Offset: 0xDDA580 VA: 0x180DDB180
	private static extern bool _IsAPICallCompleted(IntPtr self, SteamAPICall_t hSteamAPICall, ref bool pbFailed) { }

	// RVA: 0xDDAC40 Offset: 0xDDA040 VA: 0x180DDAC40
	internal bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, ref bool pbFailed) { }

	// RVA: 0xDDAE40 Offset: 0xDDA240 VA: 0x180DDAE40
	private static extern bool _GetAPICallResult(IntPtr self, SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

	// RVA: 0xDDA810 Offset: 0xDD9C10 VA: 0x180DDA810
	internal bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, ref bool pbFailed) { }

	// RVA: 0xDDB220 Offset: 0xDDA620 VA: 0x180DDB220
	private static extern bool _IsOverlayEnabled(IntPtr self) { }

	// RVA: 0xDDACE0 Offset: 0xDDA0E0 VA: 0x180DDACE0
	internal bool IsOverlayEnabled() { }

	// RVA: 0xDDB0F0 Offset: 0xDDA4F0 VA: 0x180DDB0F0
	private static extern bool _InitFilterText(IntPtr self, uint unFilterOptions) { }

	// RVA: 0xDDABB0 Offset: 0xDD9FB0 VA: 0x180DDABB0
	internal bool InitFilterText(uint unFilterOptions) { }

	// RVA: 0xDDAD60 Offset: 0xDDA160 VA: 0x180DDAD60
	private static extern int _FilterText(IntPtr self, TextFilteringContext eContext, SteamId sourceSteamID, string pchInputMessage, IntPtr pchOutFilteredText, uint nByteSizeOutFilteredText) { }

	// RVA: 0xDDA600 Offset: 0xDD9A00 VA: 0x180DDA600
	internal int FilterText(TextFilteringContext eContext, SteamId sourceSteamID, string pchInputMessage, out string pchOutFilteredText) { }

}

