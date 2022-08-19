internal static class Native // TypeDefIndex: 4578
{	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F1490 Offset: 0x22F0890 VA: 0x1822F1490
	public static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F12D0 Offset: 0x22F06D0 VA: 0x1822F12D0
	public static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x22F13D0 Offset: 0x22F07D0 VA: 0x1822F13D0
	public static float YGNodeLayoutGetLeft(IntPtr node) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x22F1410 Offset: 0x22F0810 VA: 0x1822F1410
	public static float YGNodeLayoutGetTop(IntPtr node) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x22F1450 Offset: 0x22F0850 VA: 0x1822F1450
	public static float YGNodeLayoutGetWidth(IntPtr node) { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x22F1390 Offset: 0x22F0790 VA: 0x1822F1390
	public static float YGNodeLayoutGetHeight(IntPtr node) { }

}

public class Native // TypeDefIndex: 7323
{
// Namespace: Facepunch.Network.Raknet
[SuppressUnmanagedCodeSecurityAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public class Native // TypeDefIndex: 7323
	// Methods

	// RVA: 0x22C7E40 Offset: 0x22C7240 VA: 0x1822C7E40
	public static extern IntPtr NET_Create() { }

	// RVA: 0x22C7DC0 Offset: 0x22C71C0 VA: 0x1822C7DC0
	public static extern void NET_Close(IntPtr nw) { }

	// RVA: 0x22C8470 Offset: 0x22C7870 VA: 0x1822C8470
	public static extern int NET_StartClient(IntPtr nw, string hostName, int port, int retries, int retryDelay, int timeout) { }

	// RVA: 0x22C8550 Offset: 0x22C7950 VA: 0x1822C8550
	public static extern int NET_StartServer(IntPtr nw, string ip, int port, int maxConnections) { }

	// RVA: 0x22C82B0 Offset: 0x22C76B0 VA: 0x1822C82B0
	public static extern IntPtr NET_LastStartupError(IntPtr nw) { }

	// RVA: 0x22C80F0 Offset: 0x22C74F0 VA: 0x1822C80F0
	public static extern uint NET_GetReceiveBufferSize(IntPtr nw) { }

	// RVA: 0x22C8330 Offset: 0x22C7730 VA: 0x1822C8330
	public static extern bool NET_Receive(IntPtr nw) { }

	// RVA: 0x22C7610 Offset: 0x22C6A10 VA: 0x1822C7610
	public static extern ulong NETRCV_GUID(IntPtr nw) { }

	// RVA: 0x22C7590 Offset: 0x22C6990 VA: 0x1822C7590
	public static extern uint NETRCV_Address(IntPtr nw) { }

	// RVA: 0x22C7710 Offset: 0x22C6B10 VA: 0x1822C7710
	public static extern uint NETRCV_Port(IntPtr nw) { }

	// RVA: 0x22C7790 Offset: 0x22C6B90 VA: 0x1822C7790
	public static extern IntPtr NETRCV_RawData(IntPtr nw) { }

	// RVA: 0x22C7690 Offset: 0x22C6A90 VA: 0x1822C7690
	public static extern int NETRCV_LengthBits(IntPtr nw) { }

	// RVA: 0x22C7940 Offset: 0x22C6D40 VA: 0x1822C7940
	public static extern int NETRCV_UnreadBits(IntPtr nw) { }

	// RVA: 0x22C7810 Offset: 0x22C6C10 VA: 0x1822C7810
	public static extern bool NETRCV_ReadBytes(IntPtr nw, byte* data, int length) { }

	// RVA: 0x22C78B0 Offset: 0x22C6CB0 VA: 0x1822C78B0
	public static extern void NETRCV_SetReadPointer(IntPtr nw, int bitsOffset) { }

	// RVA: 0x22C7C10 Offset: 0x22C7010 VA: 0x1822C7C10
	public static extern void NETSND_Start(IntPtr nw) { }

	// RVA: 0x22C7C90 Offset: 0x22C7090 VA: 0x1822C7C90
	public static extern void NETSND_WriteBytes(IntPtr nw, byte* data, int length) { }

	// RVA: 0x22C7B90 Offset: 0x22C6F90 VA: 0x1822C7B90
	public static extern uint NETSND_Size(IntPtr nw) { }

	// RVA: 0x22C79C0 Offset: 0x22C6DC0 VA: 0x1822C79C0
	public static extern uint NETSND_Broadcast(IntPtr nw, int priority, int reliability, int channel) { }

	// RVA: 0x22C7AE0 Offset: 0x22C6EE0 VA: 0x1822C7AE0
	public static extern uint NETSND_Send(IntPtr nw, ulong connectionID, int priority, int reliability, int channel) { }

	// RVA: 0x22C7D30 Offset: 0x22C7130 VA: 0x1822C7D30
	public static extern void NET_CloseConnection(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22C7EB0 Offset: 0x22C72B0 VA: 0x1822C7EB0
	public static extern IntPtr NET_GetAddress(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22C8170 Offset: 0x22C7570 VA: 0x1822C8170
	public static extern IntPtr NET_GetStatisticsString(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22C8200 Offset: 0x22C7600 VA: 0x1822C8200
	public static extern bool NET_GetStatistics(IntPtr nw, ulong connectionID, ref Native.RaknetStats data, int dataLength) { }

	// RVA: 0x22C7F40 Offset: 0x22C7340 VA: 0x1822C7F40
	public static extern int NET_GetAveragePing(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22C7FD0 Offset: 0x22C73D0 VA: 0x1822C7FD0
	public static extern int NET_GetLastPing(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22C8060 Offset: 0x22C7460 VA: 0x1822C8060
	public static extern int NET_GetLowestPing(IntPtr nw, ulong connectionID) { }

	// RVA: 0x22C83B0 Offset: 0x22C77B0 VA: 0x1822C83B0
	public static extern void NET_SendMessage(IntPtr nw, byte* data, int length, uint adr, ushort port) { }

	// RVA: 0x22C7A60 Offset: 0x22C6E60 VA: 0x1822C7A60
	public static extern float NETSND_ReadCompressedFloat(IntPtr nw) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public enum Native.Metrics // TypeDefIndex: 7324
{	// Fields
	public int value__; // 0x0
	public const Native.Metrics USER_MESSAGE_BYTES_PUSHED = 0;
	public const Native.Metrics USER_MESSAGE_BYTES_SENT = 1;
	public const Native.Metrics USER_MESSAGE_BYTES_RESENT = 2;
	public const Native.Metrics USER_MESSAGE_BYTES_RECEIVED_PROCESSED = 3;
	public const Native.Metrics USER_MESSAGE_BYTES_RECEIVED_IGNORED = 4;
	public const Native.Metrics ACTUAL_BYTES_SENT = 5;
	public const Native.Metrics ACTUAL_BYTES_RECEIVED = 6;
	public const Native.Metrics RNS_PER_SECOND_METRICS_COUNT = 7;

}

public enum Native.PacketPriority // TypeDefIndex: 7325
{	// Fields
	public int value__; // 0x0
	public const Native.PacketPriority IMMEDIATE_PRIORITY = 0;
	public const Native.PacketPriority HIGH_PRIORITY = 1;
	public const Native.PacketPriority MEDIUM_PRIORITY = 2;
	public const Native.PacketPriority LOW_PRIORITY = 3;
	public const Native.PacketPriority NUMBER_OF_PRIORITIES = 4;

}

public struct Native.RaknetStats // TypeDefIndex: 7326
{	// Fields
	[FixedBufferAttribute] // RVA: 0x97220 Offset: 0x96620 VA: 0x180097220
	public Native.RaknetStats.<valueOverLastSecond>e__FixedBuffer valueOverLastSecond; // 0x0
	[FixedBufferAttribute] // RVA: 0x975A0 Offset: 0x969A0 VA: 0x1800975A0
	public Native.RaknetStats.<runningTotal>e__FixedBuffer runningTotal; // 0x38
	public ulong connectionStartTime; // 0x70
	public byte isLimitedByCongestionControl; // 0x78
	public ulong BPSLimitByCongestionControl; // 0x80
	public byte isLimitedByOutgoingBandwidthLimit; // 0x88
	public ulong BPSLimitByOutgoingBandwidthLimit; // 0x90
	[FixedBufferAttribute] // RVA: 0x97700 Offset: 0x96B00 VA: 0x180097700
	public Native.RaknetStats.<messageInSendBuffer>e__FixedBuffer messageInSendBuffer; // 0x98
	[FixedBufferAttribute] // RVA: 0x97830 Offset: 0x96C30 VA: 0x180097830
	public Native.RaknetStats.<bytesInSendBuffer>e__FixedBuffer bytesInSendBuffer; // 0xA8
	public uint messagesInResendBuffer; // 0xC8
	public ulong bytesInResendBuffer; // 0xD0
	public float packetlossLastSecond; // 0xD8
	public float packetlossTotal; // 0xDC

}

public struct Native.RaknetStats.<valueOverLastSecond>e__FixedBuffer // TypeDefIndex: 7327
{	// Fields
	public ulong FixedElementField; // 0x0

}

public struct Native.RaknetStats.<runningTotal>e__FixedBuffer // TypeDefIndex: 7328
{	// Fields
	public ulong FixedElementField; // 0x0

}

public struct Native.RaknetStats.<messageInSendBuffer>e__FixedBuffer // TypeDefIndex: 7329
{	// Fields
	public uint FixedElementField; // 0x0

}

public struct Native.RaknetStats.<bytesInSendBuffer>e__FixedBuffer // TypeDefIndex: 7330
{	// Fields
	public double FixedElementField; // 0x0

}

