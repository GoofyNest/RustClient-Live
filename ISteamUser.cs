internal class ISteamUser : SteamInterface // TypeDefIndex: 5131
{
	internal void .ctor(bool IsGameServer) { }

	internal static extern IntPtr SteamAPI_SteamUser_v021() { }

	public override IntPtr GetUserInterfacePointer() { }

	private static extern bool _BLoggedOn(IntPtr self) { }

	internal bool BLoggedOn() { }

	private static extern SteamId _GetSteamID(IntPtr self) { }

	internal SteamId GetSteamID() { }

	private static extern void _StartVoiceRecording(IntPtr self) { }

	internal void StartVoiceRecording() { }

	private static extern void _StopVoiceRecording(IntPtr self) { }

	internal void StopVoiceRecording() { }

	private static extern VoiceResult _GetAvailableVoice(IntPtr self, ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	internal VoiceResult GetAvailableVoice(ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	private static extern VoiceResult _GetVoice(IntPtr self, bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	internal VoiceResult GetVoice(bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	private static extern VoiceResult _DecompressVoice(IntPtr self, IntPtr pCompressed, uint cbCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate) { }

	internal VoiceResult DecompressVoice(IntPtr pCompressed, uint cbCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate) { }

	private static extern uint _GetVoiceOptimalSampleRate(IntPtr self) { }

	internal uint GetVoiceOptimalSampleRate() { }

	private static extern HAuthTicket _GetAuthSessionTicket(IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	internal HAuthTicket GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	private static extern void _CancelAuthTicket(IntPtr self, HAuthTicket hAuthTicket) { }

	internal void CancelAuthTicket(HAuthTicket hAuthTicket) { }

	private static extern SteamAPICall_t _RequestEncryptedAppTicket(IntPtr self, IntPtr pDataToInclude, int cbDataToInclude) { }

	internal CallResult<EncryptedAppTicketResponse_t> RequestEncryptedAppTicket(IntPtr pDataToInclude, int cbDataToInclude) { }

	private static extern bool _GetEncryptedAppTicket(IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	internal bool GetEncryptedAppTicket(IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	private static extern bool _BIsTwoFactorEnabled(IntPtr self) { }

	internal bool BIsTwoFactorEnabled() { }

}

