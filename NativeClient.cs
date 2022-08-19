internal static class NativeClient // TypeDefIndex: 7155
{	// Fields
	private static readonly string InterfaceVersion; // 0x0
	private static readonly NativeClient.INativeModule Module; // 0x8
	private static IntPtr Instance; // 0x10
	private static byte[] StaticMsgBuf; // 0x18
	private static NativeClient.CallbackProgress nogcOnProgress; // 0x20
	private static NativeClient.CallbackFinished nogcOnFinished; // 0x28
	private static NativeClient.CallbackIntegrity nogcOnIntegrityViolation; // 0x30
	private static NativeClient.CallbackHostValidation nogcOnHostValidation; // 0x38

	// Methods

	// RVA: 0x22E0DC0 Offset: 0x22E01C0 VA: 0x1822E0DC0
	private static void .cctor() { }

	// RVA: 0x22E07E0 Offset: 0x22DFBE0 VA: 0x1822E07E0
	public static bool IsStartedWithEasyAntiCheat() { }

	// RVA: 0x22E0530 Offset: 0x22DF930 VA: 0x1822E0530
	public static void Dispose() { }

	// RVA: 0x22E0600 Offset: 0x22DFA00 VA: 0x1822E0600
	public static void Initialize(NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation) { }

	// RVA: 0x22E04B0 Offset: 0x22DF8B0 VA: 0x1822E04B0
	public static void ConnectionReset() { }

	// RVA: 0x22E0A40 Offset: 0x22DFE40 VA: 0x1822E0A40
	public static bool PopNetworkMessage(out byte[] MessageBuffer, out int MessageLength) { }

	// RVA: 0x22E0CA0 Offset: 0x22E00A0 VA: 0x1822E0CA0
	public static void SetPlatformUserAuthTicket(string PlatformName, byte[] AuthTicket, int AuthTicketLength) { }

	// RVA: 0x22E0B80 Offset: 0x22DFF80 VA: 0x1822E0B80
	public static void PushNetworkMessage(byte[] MessageBuffer, int MessageLength) { }

	// RVA: 0x22E0920 Offset: 0x22DFD20 VA: 0x1822E0920
	public static void PollStatus() { }

	// RVA: 0x22E0840 Offset: 0x22DFC40 VA: 0x1822E0840
	public static IntPtr NetProtect() { }

}

public sealed class NativeClient.CallbackProgress : MulticastDelegate // TypeDefIndex: 7156
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22DFA70 Offset: 0x22DEE70 VA: 0x1822DFA70 Slot: 12
	public virtual uint Invoke(uint Progress, IntPtr CallbackParameter) { }

	// RVA: 0x22DF9E0 Offset: 0x22DEDE0 VA: 0x1822DF9E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(uint Progress, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0xB95EA0 Offset: 0xB952A0 VA: 0x180B95EA0 Slot: 14
	public virtual uint EndInvoke(IAsyncResult result) { }

}

public sealed class NativeClient.CallbackFinished : MulticastDelegate // TypeDefIndex: 7157
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x130AB90 Offset: 0x1309F90 VA: 0x18130AB90 Slot: 12
	public virtual void Invoke(LoadResult Result, string Message, IntPtr CallbackParameter) { }

	// RVA: 0x22DF110 Offset: 0x22DE510 VA: 0x1822DF110 Slot: 13
	public virtual IAsyncResult BeginInvoke(LoadResult Result, string Message, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class NativeClient.CallbackIntegrity : MulticastDelegate // TypeDefIndex: 7158
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22DF650 Offset: 0x22DEA50 VA: 0x1822DF650 Slot: 12
	public virtual uint Invoke(ClientIntegrityViolationType ViolationType, string ViolationCause, string DefaultMessage, IntPtr CallbackParameter) { }

	// RVA: 0x22DF5A0 Offset: 0x22DE9A0 VA: 0x1822DF5A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(ClientIntegrityViolationType ViolationType, string ViolationCause, string DefaultMessage, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0xB95EA0 Offset: 0xB952A0 VA: 0x180B95EA0 Slot: 14
	public virtual uint EndInvoke(IAsyncResult result) { }

}

public sealed class NativeClient.CallbackHostValidation : MulticastDelegate // TypeDefIndex: 7159
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22DF230 Offset: 0x22DE630 VA: 0x1822DF230 Slot: 12
	public virtual bool Invoke(HostValidationResult Result, string Message, IntPtr CallbackParameter) { }

	// RVA: 0x22DF1A0 Offset: 0x22DE5A0 VA: 0x1822DF1A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(HostValidationResult Result, string Message, IntPtr CallbackParameter, AsyncCallback callback, object object) { }

	// RVA: 0xFF1100 Offset: 0xFF0500 VA: 0x180FF1100 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

private sealed class NativeClient.UnityModule : NativeClient.INativeModule // TypeDefIndex: 7161
{	// Methods

	// RVA: 0x22E34B0 Offset: 0x22E28B0 VA: 0x1822E34B0
	private static extern IntPtr CreateGameClient(string InterfaceVersion) { }

	// RVA: 0x22E3770 Offset: 0x22E2B70 VA: 0x1822E3770
	private static extern void GameClient_Destroy(IntPtr Instance) { }

	// RVA: 0x22E37F0 Offset: 0x22E2BF0 VA: 0x1822E37F0
	private static extern void GameClient_Initialize(IntPtr Instance, NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, IntPtr CallbackParameter) { }

	// RVA: 0x22E36F0 Offset: 0x22E2AF0 VA: 0x1822E36F0
	private static extern void GameClient_ConnectionReset(IntPtr Instance) { }

	// RVA: 0x22E39F0 Offset: 0x22E2DF0 VA: 0x1822E39F0
	private static extern bool GameClient_PopNetworkMessage(IntPtr Instance, ref IntPtr MessageBuffer, out uint MessageLength) { }

	// RVA: 0x22E3A90 Offset: 0x22E2E90 VA: 0x1822E3A90
	private static extern void GameClient_PushNetworkMessage(IntPtr Instance, byte[] MessageBuffer, uint MessageLength) { }

	// RVA: 0x22E3B30 Offset: 0x22E2F30 VA: 0x1822E3B30
	private static extern void GameClient_SetPlatformUserAuthTicket(IntPtr Instance, string PlatformName, byte[] AuthTicket, uint AuthTicketLength) { }

	// RVA: 0x22E3930 Offset: 0x22E2D30 VA: 0x1822E3930
	private static extern void GameClient_PollStatus(IntPtr Instance, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation, IntPtr CallbackParameter) { }

	// RVA: 0x22E38B0 Offset: 0x22E2CB0 VA: 0x1822E38B0
	private static extern IntPtr GameClient_NetProtect(IntPtr Instance) { }

	// RVA: 0x22E3550 Offset: 0x22E2950 VA: 0x1822E3550 Slot: 4
	public IntPtr Create() { }

	// RVA: 0x22E3640 Offset: 0x22E2A40 VA: 0x1822E3640 Slot: 5
	public void Destroy(IntPtr Instance) { }

	// RVA: 0x22E3C00 Offset: 0x22E3000 VA: 0x1822E3C00 Slot: 6
	public void Initialize(IntPtr Instance, NativeClient.CallbackProgress OnProgress, NativeClient.CallbackFinished OnFinished, IntPtr CallbackParameter) { }

	// RVA: 0x22E3400 Offset: 0x22E2800 VA: 0x1822E3400 Slot: 7
	public void ConnectionReset(IntPtr Instance) { }

	// RVA: 0x22E3E90 Offset: 0x22E3290 VA: 0x1822E3E90 Slot: 8
	public bool PopNetworkMessage(IntPtr Instance, ref byte[] MessageBuffer, out int MessageLength) { }

	// RVA: 0x22E40C0 Offset: 0x22E34C0 VA: 0x1822E40C0 Slot: 9
	public void PushNetworkMessage(IntPtr Instance, byte[] Message, int MessageLength) { }

	// RVA: 0x22E4190 Offset: 0x22E3590 VA: 0x1822E4190 Slot: 11
	public void SetPlatformUserAuthTicket(IntPtr Instance, string PlatformName, byte[] AuthTicket, int AuthTicketLength) { }

	// RVA: 0x22E3DA0 Offset: 0x22E31A0 VA: 0x1822E3DA0 Slot: 10
	public void PollStatus(IntPtr Instance, NativeClient.CallbackIntegrity OnIntegrityViolation, NativeClient.CallbackHostValidation OnHostValidation, IntPtr CallbackParameter) { }

	// RVA: 0x22E3CF0 Offset: 0x22E30F0 VA: 0x1822E3CF0 Slot: 12
	public IntPtr NetProtect(IntPtr Instance) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

