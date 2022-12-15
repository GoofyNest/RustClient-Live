public class SocketAddress // TypeDefIndex: 2895
{
	internal int m_Size;
	internal byte[] m_Buffer;
	private bool m_changed;
	private int m_hash;

	public AddressFamily Family { get; }
	public int Size { get; }
	public byte Item { get; }


	public AddressFamily get_Family() { }

	public int get_Size() { }

	public byte get_Item(int offset) { }

	public void .ctor(AddressFamily family, int size) { }

	internal void .ctor(IPAddress ipAddress) { }

	internal void .ctor(IPAddress ipaddress, int port) { }

	internal IPAddress GetIPAddress() { }

	internal IPEndPoint GetIPEndPoint() { }

	public override bool Equals(object comparand) { }

	public override int GetHashCode() { }

	public override string ToString() { }

}

public class SocketException : Win32Exception // TypeDefIndex: 3038
{
	private EndPoint m_EndPoint;

	public override string Message { get; }
	public SocketError SocketErrorCode { get; }


	private static int WSAGetLastError_internal() { }

	public void .ctor() { }

	internal void .ctor(int error, string message) { }

	public void .ctor(int errorCode) { }

	internal void .ctor(SocketError socketError) { }

	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override string get_Message() { }

	public SocketError get_SocketErrorCode() { }

}

public class Socket : IDisposable // TypeDefIndex: 3047
{
	private static object s_InternalSyncObject;
	internal static bool s_SupportsIPv4;
	internal static bool s_SupportsIPv6;
	internal static bool s_OSSupportsIPv6;
	internal static bool s_Initialized;
	private static bool s_LoggingEnabled;
	private bool is_closed;
	private bool is_listening;
	private bool useOverlappedIO;
	private int linger_timeout;
	private AddressFamily addressFamily;
	private SocketType socketType;
	private ProtocolType protocolType;
	internal SafeSocketHandle m_Handle;
	internal EndPoint seed_endpoint;
	internal SemaphoreSlim ReadSem;
	internal SemaphoreSlim WriteSem;
	internal bool is_blocking;
	internal bool is_bound;
	internal bool is_connected;
	private int m_IntCleanedUp;
	internal bool connect_in_progress;
	private static AsyncCallback AcceptAsyncCallback;
	private static IOAsyncCallback BeginAcceptCallback;
	private static IOAsyncCallback BeginAcceptReceiveCallback;
	private static AsyncCallback ConnectAsyncCallback;
	private static IOAsyncCallback BeginConnectCallback;
	private static AsyncCallback DisconnectAsyncCallback;
	private static IOAsyncCallback BeginDisconnectCallback;
	private static AsyncCallback ReceiveAsyncCallback;
	private static IOAsyncCallback BeginReceiveCallback;
	private static IOAsyncCallback BeginReceiveGenericCallback;
	private static AsyncCallback ReceiveFromAsyncCallback;
	private static IOAsyncCallback BeginReceiveFromCallback;
	private static AsyncCallback SendAsyncCallback;
	private static IOAsyncCallback BeginSendGenericCallback;
	private static AsyncCallback SendToAsyncCallback;

	[ObsoleteAttribute]
	public static bool SupportsIPv4 { get; }
	public static bool OSSupportsIPv4 { get; }
	[ObsoleteAttribute]
	public static bool SupportsIPv6 { get; }
	public static bool OSSupportsIPv6 { get; }
	public IntPtr Handle { get; }
	public AddressFamily AddressFamily { get; }
	public SocketType SocketType { get; }
	public ProtocolType ProtocolType { get; }
	public bool ExclusiveAddressUse { set; }
	public int ReceiveTimeout { set; }
	public int SendTimeout { set; }
	public bool DontFragment { set; }
	public bool DualMode { get; set; }
	private bool IsDualMode { get; }
	private static object InternalSyncObject { get; }
	internal bool CleanedUp { get; }
	public int Available { get; }
	public bool IsBound { get; }
	public EndPoint LocalEndPoint { get; }
	public bool Blocking { get; set; }
	public bool Connected { get; }
	public bool NoDelay { set; }
	public EndPoint RemoteEndPoint { get; }
	internal static int FamilyHint { get; }


	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	public static bool get_SupportsIPv4() { }

	public static bool get_OSSupportsIPv4() { }

	public static bool get_SupportsIPv6() { }

	public static bool get_OSSupportsIPv6() { }

	public IntPtr get_Handle() { }

	public AddressFamily get_AddressFamily() { }

	public SocketType get_SocketType() { }

	public ProtocolType get_ProtocolType() { }

	public void set_ExclusiveAddressUse(bool value) { }

	public void set_ReceiveTimeout(int value) { }

	public void set_SendTimeout(int value) { }

	public void set_DontFragment(bool value) { }

	public bool get_DualMode() { }

	public void set_DualMode(bool value) { }

	private bool get_IsDualMode() { }

	public int Send(byte[] buffer, int size, SocketFlags socketFlags) { }

	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	public int Receive(byte[] buffer) { }

	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	public int EndSend(IAsyncResult asyncResult) { }

	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	public int EndReceive(IAsyncResult asyncResult) { }

	private static object get_InternalSyncObject() { }

	internal bool get_CleanedUp() { }

	internal static void InitializeSockets() { }

	public void Dispose() { }

	protected override void Finalize() { }

	internal void InternalShutdown(SocketShutdown how) { }

	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	private void SocketDefaults() { }

	private IntPtr Socket_internal(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	public int get_Available() { }

	private static int Available_internal(SafeSocketHandle safeHandle, out int error) { }

	private static int Available_internal(IntPtr socket, out int error) { }

	public bool get_IsBound() { }

	public EndPoint get_LocalEndPoint() { }

	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	private static SocketAddress LocalEndPoint_internal(IntPtr socket, int family, out int error) { }

	public bool get_Blocking() { }

	public void set_Blocking(bool value) { }

	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	internal static void Blocking_internal(IntPtr socket, bool block, out int error) { }

	public bool get_Connected() { }

	public void set_NoDelay(bool value) { }

	public EndPoint get_RemoteEndPoint() { }

	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	private static SocketAddress RemoteEndPoint_internal(IntPtr socket, int family, out int error) { }

	public bool Poll(int microSeconds, SelectMode mode) { }

	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) { }

	private static bool Poll_internal(IntPtr socket, SelectMode mode, int timeout, out int error) { }

	public Socket Accept() { }

	internal void Accept(Socket acceptSocket) { }

	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	public Socket EndAccept(IAsyncResult asyncResult) { }

	public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	private static IntPtr Accept_internal(IntPtr sock, out int error, bool blocking) { }

	public void Bind(EndPoint localEP) { }

	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) { }

	private static void Bind_internal(IntPtr sock, SocketAddress sa, out int error) { }

	public void Listen(int backlog) { }

	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) { }

	private static void Listen_internal(IntPtr sock, int backlog, out int error) { }

	public void Connect(EndPoint remoteEP) { }

	private static void BeginMConnect(SocketAsyncResult sockares) { }

	private static void BeginSConnect(SocketAsyncResult sockares) { }

	public void EndConnect(IAsyncResult asyncResult) { }

	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	private static void Connect_internal(IntPtr sock, SocketAddress sa, out int error, bool blocking) { }

	public void Disconnect(bool reuseSocket) { }

	public void EndDisconnect(IAsyncResult asyncResult) { }

	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	private static void Disconnect_internal(IntPtr sock, bool reuse, out int error) { }

	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliantAttribute]
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	private static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Receive_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Receive_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	internal int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	public IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state) { }

	public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint) { }

	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	private static int ReceiveFrom_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliantAttribute]
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	private static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Send_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	private static int Send_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	public IAsyncResult BeginSendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state) { }

	private static void BeginSendToCallback(SocketAsyncResult sockares, int sent_so_far) { }

	public int EndSendTo(IAsyncResult asyncResult) { }

	private static int SendTo_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	private static int SendTo_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	private static void GetSocketOption_obj_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue) { }

	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	private static void SetSocketOption_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error) { }

	private static int IOControl_internal(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error) { }

	public void Close() { }

	public void Close(int timeout) { }

	internal static void Close_internal(IntPtr socket, out int error) { }

	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	internal static void Shutdown_internal(IntPtr socket, SocketShutdown how, out int error) { }

	protected virtual void Dispose(bool disposing) { }

	private void Linger(IntPtr handle) { }

	private void ThrowIfDisposedAndClosed() { }

	private void ThrowIfBufferNull(byte[] buffer) { }

	private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size) { }

	private void ThrowIfUdp() { }

	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	internal static void cancel_blocking_socket_operation(Thread thread) { }

	internal static int get_FamilyHint() { }

	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	private static void .cctor() { }

}

private struct Socket.WSABUF // TypeDefIndex: 3048
{
	public int len;
	public IntPtr buf;

}

private sealed class Socket.<>c // TypeDefIndex: 3049
{
	public static readonly Socket.<>c <>9;
	public static IOAsyncCallback <>9__241_0;
	public static IOAsyncCallback <>9__253_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal void <BeginSend>

	internal void <BeginSendTo>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

}

private sealed class Socket.<>c__DisplayClass242_0 // TypeDefIndex: 3050
{
	public int sent_so_far;


	public void .ctor() { }

	internal void <BeginSendCallback>

}

private sealed class Socket.<>c__DisplayClass254_0 // TypeDefIndex: 3051
{
	public int sent_so_far;


	public void .ctor() { }

	internal void <BeginSendToCallback>

}

private sealed class Socket.<>c__DisplayClass298_0 // TypeDefIndex: 3052
{
	public Socket <>4__this;
	public IOSelectorJob job;
	public IntPtr handle;


	public void .ctor() { }

	internal void <QueueIOSelectorJob>

}

public enum SocketError // TypeDefIndex: 3053
{
	public int value__;
	public const SocketError Success = 0;
	public const SocketError SocketError = -1;
	public const SocketError Interrupted = 10004;
	public const SocketError AccessDenied = 10013;
	public const SocketError Fault = 10014;
	public const SocketError InvalidArgument = 10022;
	public const SocketError TooManyOpenSockets = 10024;
	public const SocketError WouldBlock = 10035;
	public const SocketError InProgress = 10036;
	public const SocketError AlreadyInProgress = 10037;
	public const SocketError NotSocket = 10038;
	public const SocketError DestinationAddressRequired = 10039;
	public const SocketError MessageSize = 10040;
	public const SocketError ProtocolType = 10041;
	public const SocketError ProtocolOption = 10042;
	public const SocketError ProtocolNotSupported = 10043;
	public const SocketError SocketNotSupported = 10044;
	public const SocketError OperationNotSupported = 10045;
	public const SocketError ProtocolFamilyNotSupported = 10046;
	public const SocketError AddressFamilyNotSupported = 10047;
	public const SocketError AddressAlreadyInUse = 10048;
	public const SocketError AddressNotAvailable = 10049;
	public const SocketError NetworkDown = 10050;
	public const SocketError NetworkUnreachable = 10051;
	public const SocketError NetworkReset = 10052;
	public const SocketError ConnectionAborted = 10053;
	public const SocketError ConnectionReset = 10054;
	public const SocketError NoBufferSpaceAvailable = 10055;
	public const SocketError IsConnected = 10056;
	public const SocketError NotConnected = 10057;
	public const SocketError Shutdown = 10058;
	public const SocketError TimedOut = 10060;
	public const SocketError ConnectionRefused = 10061;
	public const SocketError HostDown = 10064;
	public const SocketError HostUnreachable = 10065;
	public const SocketError ProcessLimit = 10067;
	public const SocketError SystemNotReady = 10091;
	public const SocketError VersionNotSupported = 10092;
	public const SocketError NotInitialized = 10093;
	public const SocketError Disconnecting = 10101;
	public const SocketError TypeNotFound = 10109;
	public const SocketError HostNotFound = 11001;
	public const SocketError TryAgain = 11002;
	public const SocketError NoRecovery = 11003;
	public const SocketError NoData = 11004;
	public const SocketError IOPending = 997;
	public const SocketError OperationAborted = 995;

}

public enum SocketFlags // TypeDefIndex: 3054
{
	public int value__;
	public const SocketFlags None = 0;
	public const SocketFlags OutOfBand = 1;
	public const SocketFlags Peek = 2;
	public const SocketFlags DontRoute = 4;
	public const SocketFlags MaxIOVectorLength = 16;
	public const SocketFlags Truncated = 256;
	public const SocketFlags ControlDataTruncated = 512;
	public const SocketFlags Broadcast = 1024;
	public const SocketFlags Multicast = 2048;
	public const SocketFlags Partial = 32768;

}

public enum SocketOptionLevel // TypeDefIndex: 3055
{
	public int value__;
	public const SocketOptionLevel Socket = 65535;
	public const SocketOptionLevel IP = 0;
	public const SocketOptionLevel IPv6 = 41;
	public const SocketOptionLevel Tcp = 6;
	public const SocketOptionLevel Udp = 17;

}

public enum SocketOptionName // TypeDefIndex: 3056
{
	public int value__;
	public const SocketOptionName Debug = 1;
	public const SocketOptionName AcceptConnection = 2;
	public const SocketOptionName ReuseAddress = 4;
	public const SocketOptionName KeepAlive = 8;
	public const SocketOptionName DontRoute = 16;
	public const SocketOptionName Broadcast = 32;
	public const SocketOptionName UseLoopback = 64;
	public const SocketOptionName Linger = 128;
	public const SocketOptionName OutOfBandInline = 256;
	public const SocketOptionName DontLinger = -129;
	public const SocketOptionName ExclusiveAddressUse = -5;
	public const SocketOptionName SendBuffer = 4097;
	public const SocketOptionName ReceiveBuffer = 4098;
	public const SocketOptionName SendLowWater = 4099;
	public const SocketOptionName ReceiveLowWater = 4100;
	public const SocketOptionName SendTimeout = 4101;
	public const SocketOptionName ReceiveTimeout = 4102;
	public const SocketOptionName Error = 4103;
	public const SocketOptionName Type = 4104;
	public const SocketOptionName ReuseUnicastPort = 12295;
	public const SocketOptionName MaxConnections = 2147483647;
	public const SocketOptionName IPOptions = 1;
	public const SocketOptionName HeaderIncluded = 2;
	public const SocketOptionName TypeOfService = 3;
	public const SocketOptionName IpTimeToLive = 4;
	public const SocketOptionName MulticastInterface = 9;
	public const SocketOptionName MulticastTimeToLive = 10;
	public const SocketOptionName MulticastLoopback = 11;
	public const SocketOptionName AddMembership = 12;
	public const SocketOptionName DropMembership = 13;
	public const SocketOptionName DontFragment = 14;
	public const SocketOptionName AddSourceMembership = 15;
	public const SocketOptionName DropSourceMembership = 16;
	public const SocketOptionName BlockSource = 17;
	public const SocketOptionName UnblockSource = 18;
	public const SocketOptionName PacketInformation = 19;
	public const SocketOptionName HopLimit = 21;
	public const SocketOptionName IPProtectionLevel = 23;
	public const SocketOptionName IPv6Only = 27;
	public const SocketOptionName NoDelay = 1;
	public const SocketOptionName BsdUrgent = 2;
	public const SocketOptionName Expedited = 2;
	public const SocketOptionName NoChecksum = 1;
	public const SocketOptionName ChecksumCoverage = 20;
	public const SocketOptionName UpdateAcceptContext = 28683;
	public const SocketOptionName UpdateConnectContext = 28688;

}

public enum SocketShutdown // TypeDefIndex: 3057
{
	public int value__;
	public const SocketShutdown Receive = 0;
	public const SocketShutdown Send = 1;
	public const SocketShutdown Both = 2;

}

public enum SocketType // TypeDefIndex: 3058
{
	public int value__;
	public const SocketType Stream = 1;
	public const SocketType Dgram = 2;
	public const SocketType Raw = 3;
	public const SocketType Rdm = 4;
	public const SocketType Seqpacket = 5;
	public const SocketType Unknown = -1;

}

public class SocketAsyncEventArgs : EventArgs // TypeDefIndex: 3063
{
	internal int in_progress;
	internal EndPoint remote_ep;
	internal Socket current_socket;
	[CompilerGeneratedAttribute]
	private Socket <AcceptSocket>k__BackingField;
	[CompilerGeneratedAttribute]
	private int <BytesTransferred>k__BackingField;
	[CompilerGeneratedAttribute]
	private SocketError <SocketError>k__BackingField;
	[CompilerGeneratedAttribute]
	private EventHandler<SocketAsyncEventArgs> Completed;

	public Socket AcceptSocket { get; set; }
	internal int BytesTransferred { set; }
	public SocketError SocketError { set; }


	[CompilerGeneratedAttribute]
	public Socket get_AcceptSocket() { }

	[CompilerGeneratedAttribute]
	public void set_AcceptSocket(Socket value) { }

	[CompilerGeneratedAttribute]
	internal void set_BytesTransferred(int value) { }

	[CompilerGeneratedAttribute]
	public void set_SocketError(SocketError value) { }

	internal void Complete() { }

	protected virtual void OnCompleted(SocketAsyncEventArgs e) { }

}

internal sealed class SocketAsyncResult : IOAsyncResult // TypeDefIndex: 3064
{
	public Socket socket;
	public SocketOperation operation;
	private Exception DelayedException;
	public EndPoint EndPoint;
	public byte[] Buffer;
	public int Offset;
	public int Size;
	public SocketFlags SockFlags;
	public Socket AcceptSocket;
	public IPAddress[] Addresses;
	public int Port;
	public IList<ArraySegment<byte>> Buffers;
	public bool ReuseSocket;
	public int CurrentAddress;
	public Socket AcceptedSocket;
	public int Total;
	internal int error;
	public int EndCalled;

	public IntPtr Handle { get; }
	public SocketError ErrorCode { get; }


	public IntPtr get_Handle() { }

	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	public SocketError get_ErrorCode() { }

	public void CheckIfThrowDelayedException() { }

	internal override void CompleteDisposed() { }

	public void Complete() { }

	public void Complete(bool synch) { }

	public void Complete(int total) { }

	public void Complete(Exception e, bool synch) { }

	public void Complete(Exception e) { }

	public void Complete(Socket s) { }

	public void Complete(Socket s, int total) { }

}

private sealed class SocketAsyncResult.<>c // TypeDefIndex: 3065
{
	public static readonly SocketAsyncResult.<>c <>9;
	public static WaitCallback <>9__27_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal void <Complete>

}

internal enum SocketOperation // TypeDefIndex: 3066
{
	public int value__;
	public const SocketOperation Accept = 0;
	public const SocketOperation Connect = 1;
	public const SocketOperation Receive = 2;
	public const SocketOperation ReceiveFrom = 3;
	public const SocketOperation Send = 4;
	public const SocketOperation SendTo = 5;
	public const SocketOperation RecvJustCallback = 6;
	public const SocketOperation SendJustCallback = 7;
	public const SocketOperation Disconnect = 8;
	public const SocketOperation AcceptReceive = 9;
	public const SocketOperation ReceiveGeneric = 10;
	public const SocketOperation SendGeneric = 11;

}

public sealed class SocketElement : ConfigurationElement // TypeDefIndex: 3180
{
	protected override ConfigurationPropertyCollection Properties { get; }


	public void .ctor() { }

	protected override ConfigurationPropertyCollection get_Properties() { }

}

public class SocketManager // TypeDefIndex: 5188
{
	[CompilerGeneratedAttribute]
	private ISocketManager <Interface>k__BackingField;
	public HashSet<Connection> Connecting;
	public HashSet<Connection> Connected;
	[CompilerGeneratedAttribute]
	private Socket <Socket>k__BackingField;
	internal HSteamNetPollGroup pollGroup;

	public ISocketManager Interface { get; set; }
	public Socket Socket { get; set; }


	[CompilerGeneratedAttribute]
	public ISocketManager get_Interface() { }

	[CompilerGeneratedAttribute]
	public void set_Interface(ISocketManager value) { }

	[CompilerGeneratedAttribute]
	public Socket get_Socket() { }

	[CompilerGeneratedAttribute]
	internal void set_Socket(Socket value) { }

	public override string ToString() { }

	internal void Initialize() { }

	public bool Close() { }

	public virtual void OnConnectionChanged(Connection connection, ConnectionInfo info) { }

	public virtual void OnConnecting(Connection connection, ConnectionInfo info) { }

	public virtual void OnConnected(Connection connection, ConnectionInfo info) { }

	public virtual void OnDisconnected(Connection connection, ConnectionInfo info) { }

	public int Receive(int bufferSize = 32, bool receiveToEnd = True) { }

	internal void ReceiveMessage(IntPtr msgPtr) { }

	public virtual void OnMessage(Connection connection, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel) { }

	public void .ctor() { }

}

public struct Socket // TypeDefIndex: 5555
{
	internal uint Id;


	public override string ToString() { }

	public static Socket op_Implicit(uint value) { }

	public bool Close() { }

}

public class SocketWrapper : ISocket // TypeDefIndex: 6963
{
	private static readonly byte[] keepAliveValues;
	private readonly Socket _socket;
	private CancellationTokenSource _tokenSource;
	private TaskFactory _taskFactory;
	[CompilerGeneratedAttribute]
	private Stream <Stream>k__BackingField;

	public IPAddress RemoteIpAddress { get; }
	public int RemotePort { get; }
	public bool Connected { get; }
	public Stream Stream { get; set; }
	public bool NoDelay { set; }
	public EndPoint LocalEndPoint { get; }


	public IPAddress get_RemoteIpAddress() { }

	public int get_RemotePort() { }

	private static void .cctor() { }

	public void .ctor(Socket socket) { }

	public Task Authenticate(X509Certificate2 certificate, SslProtocols enabledSslProtocols, Action callback, Action<Exception> error) { }

	public void Listen(int backlog) { }

	public void Bind(EndPoint endPoint) { }

	public bool get_Connected() { }

	[CompilerGeneratedAttribute]
	public Stream get_Stream() { }

	[CompilerGeneratedAttribute]
	private void set_Stream(Stream value) { }

	public void set_NoDelay(bool value) { }

	public EndPoint get_LocalEndPoint() { }

	public Task<ISocket> Accept(Action<ISocket> callback, Action<Exception> error) { }

	public void Dispose() { }

	public void Close() { }

}

private sealed class SocketWrapper.<>c__DisplayClass12_0 // TypeDefIndex: 6964
{
	public SslStream ssl;
	public X509Certificate2 certificate;
	public SslProtocols enabledSslProtocols;
	public Action callback;
	public Action<Exception> error;


	public void .ctor() { }

	internal IAsyncResult <Authenticate>

	internal void <Authenticate>

	internal void <Authenticate>

	internal void <Authenticate>

}

private sealed class SocketWrapper.<>c__DisplayClass26_0 // TypeDefIndex: 6965
{
	public SocketWrapper <>4__this;
	public Action<ISocket> callback;
	public Action<Exception> error;


	public void .ctor() { }

	internal ISocket <Accept>

	internal void <Accept>

	internal void <Accept>

	internal void <Accept>

}

public struct SocketId // TypeDefIndex: 9011
{
	[CompilerGeneratedAttribute]
	private string <SocketName>k__BackingField;

	public string SocketName { get; set; }


	[CompilerGeneratedAttribute]
	public string get_SocketName() { }

	[CompilerGeneratedAttribute]
	public void set_SocketName(string value) { }

	internal void Set(ref SocketIdInternal other) { }

}

internal struct SocketIdInternal : IGettable<SocketId>, ISettable<SocketId>, IDisposable // TypeDefIndex: 9012
{
	private int m_ApiVersion;
	private byte[] m_SocketName;

	public string SocketName { get; set; }


	public string get_SocketName() { }

	public void set_SocketName(string value) { }

	public void Set(ref SocketId other) { }

	public void Set(ref Nullable<SocketId> other) { }

	public void Dispose() { }

	public void Get(out SocketId output) { }

}

public class SocketHandle : PrefabAttribute // TypeDefIndex: 10825
{

	protected override Type GetIndexedType() { }

	internal void AdjustTarget(ref Construction.Target target, float maxplaceDistance) { }

	public void .ctor() { }

}

public class SocketMod : PrefabAttribute // TypeDefIndex: 10826
{
	public Socket_Base baseSocket;
	public Translate.Phrase FailedPhrase;


	public virtual bool DoCheck(Construction.Placement place) { }

	public virtual void ModifyPlacement(Construction.Placement place) { }

	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

public class SocketMod_AngleCheck : SocketMod // TypeDefIndex: 10827
{
	public bool wantsAngle;
	public Vector3 worldNormal;
	public float withinDegrees;
	public static Translate.Phrase ErrorPhrase;


	private void OnDrawGizmosSelected() { }

	public override bool DoCheck(Construction.Placement place) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class SocketMod_AreaCheck : SocketMod // TypeDefIndex: 10828
{
	public Bounds bounds;
	public LayerMask layerMask;
	public bool wantsInside;


	private void OnDrawGizmosSelected() { }

	public static bool IsInArea(Vector3 position, Quaternion rotation, Bounds bounds, LayerMask layerMask, BaseEntity entity) { }

	public bool DoCheck(Vector3 position, Quaternion rotation, BaseEntity entity) { }

	public override bool DoCheck(Construction.Placement place) { }

	public void .ctor() { }

}

public class SocketMod_Attraction : SocketMod // TypeDefIndex: 10829
{
	public float outerRadius;
	public float innerRadius;
	public string groupName;
	public bool lockRotation;
	public bool ignoreRotationForRadiusCheck;
	public static TimeSince LastSnap;


	private void OnDrawGizmosSelected() { }

	public override bool DoCheck(Construction.Placement place) { }

	public override void ModifyPlacement(Construction.Placement place) { }

	public void .ctor() { }

}

public class SocketMod_BuildingBlock : SocketMod // TypeDefIndex: 10830
{
	public float sphereRadius;
	public LayerMask layerMask;
	public QueryTriggerInteraction queryTriggers;
	public bool wantsCollide;


	private void OnDrawGizmosSelected() { }

	public override bool DoCheck(Construction.Placement place) { }

	public void .ctor() { }

}

public class SocketMod_EntityCheck : SocketMod // TypeDefIndex: 10831
{
	public float sphereRadius;
	public LayerMask layerMask;
	public QueryTriggerInteraction queryTriggers;
	public BaseEntity[] entityTypes;
	public bool wantsCollide;


	private void OnDrawGizmosSelected() { }

	public override bool DoCheck(Construction.Placement place) { }

	public void .ctor() { }

}

private sealed class SocketMod_EntityCheck.<>c__DisplayClass6_0 // TypeDefIndex: 10832
{
	public BaseEntity ent;


	public void .ctor() { }

	internal bool <DoCheck>

}

public class SocketMod_EntityType : SocketMod // TypeDefIndex: 10833
{
	public float sphereRadius;
	public LayerMask layerMask;
	public QueryTriggerInteraction queryTriggers;
	public BaseEntity searchType;
	public bool wantsCollide;


	private void OnDrawGizmosSelected() { }

	public override bool DoCheck(Construction.Placement place) { }

	public void .ctor() { }

}

public class SocketMod_HotSpot : SocketMod // TypeDefIndex: 10834
{
	public float spotSize;


	private void OnDrawGizmos() { }

	public override void ModifyPlacement(Construction.Placement place) { }

	public void .ctor() { }

}

public class SocketMod_InWater : SocketMod // TypeDefIndex: 10835
{
	public bool wantsInWater;
	public static Translate.Phrase WantsWaterPhrase;
	public static Translate.Phrase NoWaterPhrase;


	private void OnDrawGizmosSelected() { }

	public override bool DoCheck(Construction.Placement place) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class SocketMod_PhysicMaterial : SocketMod // TypeDefIndex: 10836
{
	public PhysicMaterial[] ValidMaterials;
	private PhysicMaterial foundMaterial;


	public override bool DoCheck(Construction.Placement place) { }

	public void .ctor() { }

}

public class SocketMod_PlantCheck : SocketMod // TypeDefIndex: 10837
{
	public float sphereRadius;
	public LayerMask layerMask;
	public QueryTriggerInteraction queryTriggers;
	public bool wantsCollide;


	private void OnDrawGizmosSelected() { }

	public override bool DoCheck(Construction.Placement place) { }

	public void .ctor() { }

}

public class SocketMod_SphereCheck : SocketMod // TypeDefIndex: 10838
{
	public float sphereRadius;
	public LayerMask layerMask;
	public bool wantsCollide;
	public static Translate.Phrase Error_WantsCollideConstruction;
	public static Translate.Phrase Error_DoesNotWantCollideConstruction;


	private void OnDrawGizmosSelected() { }

	public override bool DoCheck(Construction.Placement place) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class SocketMod_TerrainCheck : SocketMod // TypeDefIndex: 10839
{
	public bool wantsInTerrain;


	private void OnDrawGizmos() { }

	public static bool IsInTerrain(Vector3 vPoint) { }

	public override bool DoCheck(Construction.Placement place) { }

	public void .ctor() { }

}

public class SocketMod_WaterDepth : SocketMod // TypeDefIndex: 10840
{
	public float MinimumWaterDepth;
	public float MaximumWaterDepth;
	public bool AllowWaterVolumes;
	public static Translate.Phrase TooDeepPhrase;
	public static Translate.Phrase TooShallowPhrase;


	public override bool DoCheck(Construction.Placement place) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class Socket_Base : PrefabAttribute // TypeDefIndex: 10841
{
	public bool male;
	public bool maleDummy;
	public bool female;
	public bool femaleDummy;
	public bool femaleNoStability;
	public bool monogamous;
	public Vector3 position;
	public Quaternion rotation;
	public Vector3 selectSize;
	public Vector3 selectCenter;
	[ReadOnlyAttribute]
	public string socketName;
	public SocketMod[] socketMods;
	public Socket_Base.OccupiedSocketCheck[] checkOccupiedSockets;


	public Vector3 GetSelectPivot(Vector3 position, Quaternion rotation) { }

	public OBB GetSelectBounds(Vector3 position, Quaternion rotation) { }

	protected override Type GetIndexedType() { }

	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public virtual bool TestTarget(Construction.Target target) { }

	public virtual bool IsCompatible(Socket_Base socket) { }

	public virtual bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation) { }

	public virtual Construction.Placement DoPlacement(Construction.Target target) { }

	public virtual bool CheckSocketMods(Construction.Placement placement) { }

	public void .ctor() { }

}

public class Socket_Base.OccupiedSocketCheck // TypeDefIndex: 10842
{
	public Socket_Base Socket;
	public bool FemaleDummy;


	public void .ctor() { }

}

public class Socket_Free : Socket_Base // TypeDefIndex: 10843
{
	public Vector3 idealPlacementNormal;
	public bool useTargetNormal;
	public bool blendAimAngle;


	private void OnDrawGizmosSelected() { }

	public override bool TestTarget(Construction.Target target) { }

	public override Construction.Placement DoPlacement(Construction.Target target) { }

	public void .ctor() { }

}

public class Socket_Specific : Socket_Base // TypeDefIndex: 10844
{
	public bool useFemaleRotation;
	public string targetSocketName;


	private void OnDrawGizmos() { }

	public override bool TestTarget(Construction.Target target) { }

	public override Construction.Placement DoPlacement(Construction.Target target) { }

	public void .ctor() { }

}

public class Socket_Specific_Female : Socket_Base // TypeDefIndex: 10845
{
	public int rotationDegrees;
	public int rotationOffset;
	public string[] allowedMaleSockets;


	private void OnDrawGizmos() { }

	private void OnDrawGizmosSelected() { }

	public bool CanAccept(Socket_Specific socket) { }

	public void .ctor() { }

}

public class Socket_Terrain : Socket_Base // TypeDefIndex: 10846
{
	public float placementHeight;
	public bool alignToNormal;


	private void OnDrawGizmos() { }

	public override bool TestTarget(Construction.Target target) { }

	public override Construction.Placement DoPlacement(Construction.Target target) { }

	public void .ctor() { }

}

