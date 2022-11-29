public sealed class P2PInterface : Handle // TypeDefIndex: 8990
{
	public const int AcceptconnectionApiLatest = 1;
	public const int AddnotifyincomingpacketqueuefullApiLatest = 1;
	public const int AddnotifypeerconnectionclosedApiLatest = 1;
	public const int AddnotifypeerconnectionestablishedApiLatest = 1;
	public const int AddnotifypeerconnectioninterruptedApiLatest = 1;
	public const int AddnotifypeerconnectionrequestApiLatest = 1;
	public const int ClearpacketqueueApiLatest = 1;
	public const int CloseconnectionApiLatest = 1;
	public const int CloseconnectionsApiLatest = 1;
	public const int GetnattypeApiLatest = 1;
	public const int GetnextreceivedpacketsizeApiLatest = 2;
	public const int GetpacketqueueinfoApiLatest = 1;
	public const int GetportrangeApiLatest = 1;
	public const int GetrelaycontrolApiLatest = 1;
	public const int MaxConnections = 32;
	public const int MaxPacketSize = 1170;
	public const int MaxQueueSizeUnlimited = 0;
	public const int QuerynattypeApiLatest = 1;
	public const int ReceivepacketApiLatest = 2;
	public const int SendpacketApiLatest = 3;
	public const int SetpacketqueuesizeApiLatest = 1;
	public const int SetportrangeApiLatest = 1;
	public const int SetrelaycontrolApiLatest = 1;
	public const int SocketidApiLatest = 1;
	public const int SocketidSocketnameSize = 33;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result AcceptConnection(ref AcceptConnectionOptions options) { }

	public ulong AddNotifyIncomingPacketQueueFull(ref AddNotifyIncomingPacketQueueFullOptions options, object clientData, OnIncomingPacketQueueFullCallback incomingPacketQueueFullHandler) { }

	public ulong AddNotifyPeerConnectionClosed(ref AddNotifyPeerConnectionClosedOptions options, object clientData, OnRemoteConnectionClosedCallback connectionClosedHandler) { }

	public ulong AddNotifyPeerConnectionEstablished(ref AddNotifyPeerConnectionEstablishedOptions options, object clientData, OnPeerConnectionEstablishedCallback connectionEstablishedHandler) { }

	public ulong AddNotifyPeerConnectionInterrupted(ref AddNotifyPeerConnectionInterruptedOptions options, object clientData, OnPeerConnectionInterruptedCallback connectionInterruptedHandler) { }

	public ulong AddNotifyPeerConnectionRequest(ref AddNotifyPeerConnectionRequestOptions options, object clientData, OnIncomingConnectionRequestCallback connectionRequestHandler) { }

	public Result ClearPacketQueue(ref ClearPacketQueueOptions options) { }

	public Result CloseConnection(ref CloseConnectionOptions options) { }

	public Result CloseConnections(ref CloseConnectionsOptions options) { }

	public Result GetNATType(ref GetNATTypeOptions options, out NATType outNATType) { }

	public Result GetNextReceivedPacketSize(ref GetNextReceivedPacketSizeOptions options, out uint outPacketSizeBytes) { }

	public Result GetPacketQueueInfo(ref GetPacketQueueInfoOptions options, out PacketQueueInfo outPacketQueueInfo) { }

	public Result GetPortRange(ref GetPortRangeOptions options, out ushort outPort, out ushort outNumAdditionalPortsToTry) { }

	public Result GetRelayControl(ref GetRelayControlOptions options, out RelayControl outRelayControl) { }

	public void QueryNATType(ref QueryNATTypeOptions options, object clientData, OnQueryNATTypeCompleteCallback completionDelegate) { }

	public Result ReceivePacket(ref ReceivePacketOptions options, out ProductUserId outPeerId, out SocketId outSocketId, out byte outChannel, ArraySegment<byte> outData, out uint outBytesWritten) { }

	public void RemoveNotifyIncomingPacketQueueFull(ulong notificationId) { }

	public void RemoveNotifyPeerConnectionClosed(ulong notificationId) { }

	public void RemoveNotifyPeerConnectionEstablished(ulong notificationId) { }

	public void RemoveNotifyPeerConnectionInterrupted(ulong notificationId) { }

	public void RemoveNotifyPeerConnectionRequest(ulong notificationId) { }

	public Result SendPacket(ref SendPacketOptions options) { }

	public Result SetPacketQueueSize(ref SetPacketQueueSizeOptions options) { }

	public Result SetPortRange(ref SetPortRangeOptions options) { }

	public Result SetRelayControl(ref SetRelayControlOptions options) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnIncomingConnectionRequestCallbackInternalImplementation(ref OnIncomingConnectionRequestInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnIncomingPacketQueueFullCallbackInternalImplementation(ref OnIncomingPacketQueueFullInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnPeerConnectionEstablishedCallbackInternalImplementation(ref OnPeerConnectionEstablishedInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnPeerConnectionInterruptedCallbackInternalImplementation(ref OnPeerConnectionInterruptedInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryNATTypeCompleteCallbackInternalImplementation(ref OnQueryNATTypeCompleteInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnRemoteConnectionClosedCallbackInternalImplementation(ref OnRemoteConnectionClosedInfoInternal data) { }

}

