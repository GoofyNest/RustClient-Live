internal class ISteamUser : SteamInterface // TypeDefIndex: 5131
{	// Methods

	// RVA: 0xDD3400 Offset: 0xDD2800 VA: 0x180DD3400
	internal void .ctor(bool IsGameServer) { }

	// RVA: 0xDD9A00 Offset: 0xDD8E00 VA: 0x180DD9A00
	internal static extern IntPtr SteamAPI_SteamUser_v021() { }

	// RVA: 0xDD9A00 Offset: 0xDD8E00 VA: 0x180DD9A00 Slot: 4
	public override IntPtr GetUserInterfacePointer() { }

	// RVA: 0xDD9E70 Offset: 0xDD9270 VA: 0x180DD9E70
	private static extern bool _BLoggedOn(IntPtr self) { }

	// RVA: 0xDD9590 Offset: 0xDD8990 VA: 0x180DD9590
	internal bool BLoggedOn() { }

	// RVA: 0xDDA260 Offset: 0xDD9660 VA: 0x180DDA260
	private static extern SteamId _GetSteamID(IntPtr self) { }

	// RVA: 0xDD9980 Offset: 0xDD8D80 VA: 0x180DD9980
	internal SteamId GetSteamID() { }

	// RVA: 0xDDA500 Offset: 0xDD9900 VA: 0x180DDA500
	private static extern void _StartVoiceRecording(IntPtr self) { }

	// RVA: 0xDD9CF0 Offset: 0xDD90F0 VA: 0x180DD9CF0
	internal void StartVoiceRecording() { }

	// RVA: 0xDDA580 Offset: 0xDD9980 VA: 0x180DDA580
	private static extern void _StopVoiceRecording(IntPtr self) { }

	// RVA: 0xDD9D70 Offset: 0xDD9170 VA: 0x180DD9D70
	internal void StopVoiceRecording() { }

	// RVA: 0xDDA100 Offset: 0xDD9500 VA: 0x180DDA100
	private static extern VoiceResult _GetAvailableVoice(IntPtr self, ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0xDD9820 Offset: 0xDD8C20 VA: 0x180DD9820
	internal VoiceResult GetAvailableVoice(ref uint pcbCompressed, ref uint pcbUncompressed_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0xDDA360 Offset: 0xDD9760 VA: 0x180DDA360
	private static extern VoiceResult _GetVoice(IntPtr self, bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0xDD9AF0 Offset: 0xDD8EF0 VA: 0x180DD9AF0
	internal VoiceResult GetVoice(bool bWantCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, bool bWantUncompressed_Deprecated, IntPtr pUncompressedDestBuffer_Deprecated, uint cbUncompressedDestBufferSize_Deprecated, ref uint nUncompressBytesWritten_Deprecated, uint nUncompressedVoiceDesiredSampleRate_Deprecated) { }

	// RVA: 0xDD9F80 Offset: 0xDD9380 VA: 0x180DD9F80
	private static extern VoiceResult _DecompressVoice(IntPtr self, IntPtr pCompressed, uint cbCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate) { }

	// RVA: 0xDD96A0 Offset: 0xDD8AA0 VA: 0x180DD96A0
	internal VoiceResult DecompressVoice(IntPtr pCompressed, uint cbCompressed, IntPtr pDestBuffer, uint cbDestBufferSize, ref uint nBytesWritten, uint nDesiredSampleRate) { }

	// RVA: 0xDDA2E0 Offset: 0xDD96E0 VA: 0x180DDA2E0
	private static extern uint _GetVoiceOptimalSampleRate(IntPtr self) { }

	// RVA: 0xDD9A70 Offset: 0xDD8E70 VA: 0x180DD9A70
	internal uint GetVoiceOptimalSampleRate() { }

	// RVA: 0xDDA050 Offset: 0xDD9450 VA: 0x180DDA050
	private static extern HAuthTicket _GetAuthSessionTicket(IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	// RVA: 0xDD9770 Offset: 0xDD8B70 VA: 0x180DD9770
	internal HAuthTicket GetAuthSessionTicket(IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	// RVA: 0xDD9EF0 Offset: 0xDD92F0 VA: 0x180DD9EF0
	private static extern void _CancelAuthTicket(IntPtr self, HAuthTicket hAuthTicket) { }

	// RVA: 0xDD9610 Offset: 0xDD8A10 VA: 0x180DD9610
	internal void CancelAuthTicket(HAuthTicket hAuthTicket) { }

	// RVA: 0xDDA460 Offset: 0xDD9860 VA: 0x180DDA460
	private static extern SteamAPICall_t _RequestEncryptedAppTicket(IntPtr self, IntPtr pDataToInclude, int cbDataToInclude) { }

	// RVA: 0xDD9BF0 Offset: 0xDD8FF0 VA: 0x180DD9BF0
	internal CallResult<EncryptedAppTicketResponse_t> RequestEncryptedAppTicket(IntPtr pDataToInclude, int cbDataToInclude) { }

	// RVA: 0xDDA1B0 Offset: 0xDD95B0 VA: 0x180DDA1B0
	private static extern bool _GetEncryptedAppTicket(IntPtr self, IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	// RVA: 0xDD98D0 Offset: 0xDD8CD0 VA: 0x180DD98D0
	internal bool GetEncryptedAppTicket(IntPtr pTicket, int cbMaxTicket, ref uint pcbTicket) { }

	// RVA: 0xDD9DF0 Offset: 0xDD91F0 VA: 0x180DD9DF0
	private static extern bool _BIsTwoFactorEnabled(IntPtr self) { }

	// RVA: 0xDD9510 Offset: 0xDD8910 VA: 0x180DD9510
	internal bool BIsTwoFactorEnabled() { }

}

