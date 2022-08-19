public class SocketAddress // TypeDefIndex: 2895
{	// Fields
	internal int m_Size; // 0x10
	internal byte[] m_Buffer; // 0x18
	private bool m_changed; // 0x20
	private int m_hash; // 0x24

	// Properties
	public AddressFamily Family { get; }
	public int Size { get; }
	public byte Item { get; }

	// Methods

	// RVA: 0xFFC040 Offset: 0xFFB440 VA: 0x180FFC040
	public AddressFamily get_Family() { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_Size() { }

	// RVA: 0xFFC0A0 Offset: 0xFFB4A0 VA: 0x180FFC0A0
	public byte get_Item(int offset) { }

	// RVA: 0xFFBAE0 Offset: 0xFFAEE0 VA: 0x180FFBAE0
	public void .ctor(AddressFamily family, int size) { }

	// RVA: 0xFFBC00 Offset: 0xFFB000 VA: 0x180FFBC00
	internal void .ctor(IPAddress ipAddress) { }

	// RVA: 0xFFBA60 Offset: 0xFFAE60 VA: 0x180FFBA60
	internal void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0xFFB300 Offset: 0xFFA700 VA: 0x180FFB300
	internal IPAddress GetIPAddress() { }

	// RVA: 0xFFB590 Offset: 0xFFA990 VA: 0x180FFB590
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0xFFB060 Offset: 0xFFA460 VA: 0x180FFB060 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0xFFB190 Offset: 0xFFA590 VA: 0x180FFB190 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFFB650 Offset: 0xFFAA50 VA: 0x180FFB650 Slot: 3
	public override string ToString() { }

}

public class SocketException : Win32Exception // TypeDefIndex: 3038
{	// Fields
	private EndPoint m_EndPoint; // 0x90

	// Properties
	public override string Message { get; }
	public SocketError SocketErrorCode { get; }

	// Methods

	// RVA: 0xFFC6B0 Offset: 0xFFBAB0 VA: 0x180FFC6B0
	private static int WSAGetLastError_internal() { }

	// RVA: 0xFFC870 Offset: 0xFFBC70 VA: 0x180FFC870
	public void .ctor() { }

	// RVA: 0xFFC800 Offset: 0xFFBC00 VA: 0x180FFC800
	internal void .ctor(int error, string message) { }

	// RVA: 0xFFC6C0 Offset: 0xFFBAC0 VA: 0x180FFC6C0
	public void .ctor(int errorCode) { }

	// RVA: 0xFFC720 Offset: 0xFFBB20 VA: 0x180FFC720
	internal void .ctor(SocketError socketError) { }

	// RVA: 0xFFC780 Offset: 0xFFBB80 VA: 0x180FFC780
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0xFFC8E0 Offset: 0xFFBCE0 VA: 0x180FFC8E0 Slot: 5
	public override string get_Message() { }

	// RVA: 0x5A44D0 Offset: 0x5A38D0 VA: 0x1805A44D0
	public SocketError get_SocketErrorCode() { }

}

public class Socket : IDisposable // TypeDefIndex: 3047
{	// Fields
	private static object s_InternalSyncObject; // 0x0
	internal static bool s_SupportsIPv4; // 0x8
	internal static bool s_SupportsIPv6; // 0x9
	internal static bool s_OSSupportsIPv6; // 0xA
	internal static bool s_Initialized; // 0xB
	private static bool s_LoggingEnabled; // 0xC
	private bool is_closed; // 0x10
	private bool is_listening; // 0x11
	private bool useOverlappedIO; // 0x12
	private int linger_timeout; // 0x14
	private AddressFamily addressFamily; // 0x18
	private SocketType socketType; // 0x1C
	private ProtocolType protocolType; // 0x20
	internal SafeSocketHandle m_Handle; // 0x28
	internal EndPoint seed_endpoint; // 0x30
	internal SemaphoreSlim ReadSem; // 0x38
	internal SemaphoreSlim WriteSem; // 0x40
	internal bool is_blocking; // 0x48
	internal bool is_bound; // 0x49
	internal bool is_connected; // 0x4A
	private int m_IntCleanedUp; // 0x4C
	internal bool connect_in_progress; // 0x50
	private static AsyncCallback AcceptAsyncCallback; // 0x10
	private static IOAsyncCallback BeginAcceptCallback; // 0x18
	private static IOAsyncCallback BeginAcceptReceiveCallback; // 0x20
	private static AsyncCallback ConnectAsyncCallback; // 0x28
	private static IOAsyncCallback BeginConnectCallback; // 0x30
	private static AsyncCallback DisconnectAsyncCallback; // 0x38
	private static IOAsyncCallback BeginDisconnectCallback; // 0x40
	private static AsyncCallback ReceiveAsyncCallback; // 0x48
	private static IOAsyncCallback BeginReceiveCallback; // 0x50
	private static IOAsyncCallback BeginReceiveGenericCallback; // 0x58
	private static AsyncCallback ReceiveFromAsyncCallback; // 0x60
	private static IOAsyncCallback BeginReceiveFromCallback; // 0x68
	private static AsyncCallback SendAsyncCallback; // 0x70
	private static IOAsyncCallback BeginSendGenericCallback; // 0x78
	private static AsyncCallback SendToAsyncCallback; // 0x80

	// Properties
	[ObsoleteAttribute] // RVA: 0xB9AB0 Offset: 0xB8EB0 VA: 0x1800B9AB0
	public static bool SupportsIPv4 { get; }
	public static bool OSSupportsIPv4 { get; }
	[ObsoleteAttribute] // RVA: 0xB9B30 Offset: 0xB8F30 VA: 0x1800B9B30
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

	// Methods

	// RVA: 0x1004330 Offset: 0x1003730 VA: 0x181004330
	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x1004DD0 Offset: 0x10041D0 VA: 0x181004DD0
	public static bool get_SupportsIPv4() { }

	// RVA: 0x1004BF0 Offset: 0x1003FF0 VA: 0x181004BF0
	public static bool get_OSSupportsIPv4() { }

	// RVA: 0x1004E40 Offset: 0x1004240 VA: 0x181004E40
	public static bool get_SupportsIPv6() { }

	// RVA: 0x1004C60 Offset: 0x1004060 VA: 0x181004C60
	public static bool get_OSSupportsIPv6() { }

	// RVA: 0x95E3A0 Offset: 0x95D7A0 VA: 0x18095E3A0
	public IntPtr get_Handle() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0
	public SocketType get_SocketType() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public ProtocolType get_ProtocolType() { }

	// RVA: 0x10050B0 Offset: 0x10044B0 VA: 0x1810050B0
	public void set_ExclusiveAddressUse(bool value) { }

	// RVA: 0x10051E0 Offset: 0x10045E0 VA: 0x1810051E0
	public void set_ReceiveTimeout(int value) { }

	// RVA: 0x1005280 Offset: 0x1004680 VA: 0x181005280
	public void set_SendTimeout(int value) { }

	// RVA: 0x1004F70 Offset: 0x1004370 VA: 0x181004F70
	public void set_DontFragment(bool value) { }

	// RVA: 0x1004710 Offset: 0x1003B10 VA: 0x181004710
	public bool get_DualMode() { }

	// RVA: 0x1005010 Offset: 0x1004410 VA: 0x181005010
	public void set_DualMode(bool value) { }

	// RVA: 0x1004A30 Offset: 0x1003E30 VA: 0x181004A30
	private bool get_IsDualMode() { }

	// RVA: 0x10029B0 Offset: 0x1001DB0 VA: 0x1810029B0
	public int Send(byte[] buffer, int size, SocketFlags socketFlags) { }

	// RVA: 0x1002910 Offset: 0x1001D10 VA: 0x181002910
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x1002B90 Offset: 0x1001F90 VA: 0x181002B90
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x1001F50 Offset: 0x1001350 VA: 0x181001F50
	public int Receive(byte[] buffer) { }

	// RVA: 0x1001F90 Offset: 0x1001390 VA: 0x181001F90
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x1001880 Offset: 0x1000C80 VA: 0x181001880
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x1000250 Offset: 0xFFF650 VA: 0x181000250
	public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x1003270 Offset: 0x1002670 VA: 0x181003270
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0xFFE360 Offset: 0xFFD760 VA: 0x180FFE360
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0xFFFC90 Offset: 0xFFF090 VA: 0x180FFFC90
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0xFFD5A0 Offset: 0xFFC9A0 VA: 0x180FFD5A0
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0xFFF9E0 Offset: 0xFFEDE0 VA: 0x180FFF9E0
	public int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x1004930 Offset: 0x1003D30 VA: 0x181004930
	private static object get_InternalSyncObject() { }

	// RVA: 0x1004700 Offset: 0x1003B00 VA: 0x181004700
	internal bool get_CleanedUp() { }

	// RVA: 0x1000530 Offset: 0xFFF930 VA: 0x181000530
	internal static void InitializeSockets() { }

	// RVA: 0xFFF480 Offset: 0xFFE880 VA: 0x180FFF480 Slot: 4
	public void Dispose() { }

	// RVA: 0xA47AB0 Offset: 0xA46EB0 VA: 0x180A47AB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1000940 Offset: 0xFFFD40 VA: 0x181000940
	internal void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x1004220 Offset: 0x1003620 VA: 0x181004220
	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x1003740 Offset: 0x1002B40 VA: 0x181003740
	private void SocketDefaults() { }

	// RVA: 0x1003910 Offset: 0x1002D10 VA: 0x181003910
	private IntPtr Socket_internal(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	// RVA: 0x1004650 Offset: 0x1003A50 VA: 0x181004650
	public int get_Available() { }

	// RVA: 0xFFCD50 Offset: 0xFFC150 VA: 0x180FFCD50
	private static int Available_internal(SafeSocketHandle safeHandle, out int error) { }

	// RVA: 0xFFCE70 Offset: 0xFFC270 VA: 0x180FFCE70
	private static int Available_internal(IntPtr socket, out int error) { }

	// RVA: 0xB9D230 Offset: 0xB9C630 VA: 0x180B9D230
	public bool get_IsBound() { }

	// RVA: 0x1004B00 Offset: 0x1003F00 VA: 0x181004B00
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x1000DB0 Offset: 0x10001B0 VA: 0x181000DB0
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x1000EE0 Offset: 0x10002E0 VA: 0x181000EE0
	private static SocketAddress LocalEndPoint_internal(IntPtr socket, int family, out int error) { }

	// RVA: 0x4B9270 Offset: 0x4B8670 VA: 0x1804B9270
	public bool get_Blocking() { }

	// RVA: 0x1004EB0 Offset: 0x10042B0 VA: 0x181004EB0
	public void set_Blocking(bool value) { }

	// RVA: 0xFFE980 Offset: 0xFFDD80 VA: 0x180FFE980
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	// RVA: 0xFFEAA0 Offset: 0xFFDEA0 VA: 0x180FFEAA0
	internal static void Blocking_internal(IntPtr socket, bool block, out int error) { }

	// RVA: 0xB9D220 Offset: 0xB9C620 VA: 0x180B9D220
	public bool get_Connected() { }

	// RVA: 0x1005150 Offset: 0x1004550 VA: 0x181005150
	public void set_NoDelay(bool value) { }

	// RVA: 0x1004CD0 Offset: 0x10040D0 VA: 0x181004CD0
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x10021D0 Offset: 0x10015D0 VA: 0x1810021D0
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x10021C0 Offset: 0x10015C0 VA: 0x1810021C0
	private static SocketAddress RemoteEndPoint_internal(IntPtr socket, int family, out int error) { }

	// RVA: 0x1001040 Offset: 0x1000440 VA: 0x181001040
	public bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x1000F00 Offset: 0x1000300 VA: 0x181000F00
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x1000EF0 Offset: 0x10002F0 VA: 0x181000EF0
	private static bool Poll_internal(IntPtr socket, SelectMode mode, int timeout, out int error) { }

	// RVA: 0xFFCC00 Offset: 0xFFC000 VA: 0x180FFCC00
	public Socket Accept() { }

	// RVA: 0xFFCAC0 Offset: 0xFFBEC0 VA: 0x180FFCAC0
	internal void Accept(Socket acceptSocket) { }

	// RVA: 0xFFCE80 Offset: 0xFFC280 VA: 0x180FFCE80
	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	// RVA: 0xFFF5D0 Offset: 0xFFE9D0 VA: 0x180FFF5D0
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0xFFF4F0 Offset: 0xFFE8F0 VA: 0x180FFF4F0
	public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0xFFC980 Offset: 0xFFBD80 VA: 0x180FFC980
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	// RVA: 0xFFC970 Offset: 0xFFBD70 VA: 0x180FFC970
	private static IntPtr Accept_internal(IntPtr sock, out int error, bool blocking) { }

	// RVA: 0xFFE800 Offset: 0xFFDC00 VA: 0x180FFE800
	public void Bind(EndPoint localEP) { }

	// RVA: 0xFFE6D0 Offset: 0xFFDAD0 VA: 0x180FFE6D0
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) { }

	// RVA: 0xFFE7F0 Offset: 0xFFDBF0 VA: 0x180FFE7F0
	private static void Bind_internal(IntPtr sock, SocketAddress sa, out int error) { }

	// RVA: 0x1000CB0 Offset: 0x10000B0 VA: 0x181000CB0
	public void Listen(int backlog) { }

	// RVA: 0x1000B90 Offset: 0xFFFF90 VA: 0x181000B90
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) { }

	// RVA: 0x1000B80 Offset: 0xFFFF80 VA: 0x181000B80
	private static void Listen_internal(IntPtr sock, int backlog, out int error) { }

	// RVA: 0xFFECD0 Offset: 0xFFE0D0 VA: 0x180FFECD0
	public void Connect(EndPoint remoteEP) { }

	// RVA: 0xFFD010 Offset: 0xFFC410 VA: 0x180FFD010
	private static void BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0xFFD7B0 Offset: 0xFFCBB0 VA: 0x180FFD7B0
	private static void BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0xFFF690 Offset: 0xFFEA90 VA: 0x180FFF690
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0xFFEBB0 Offset: 0xFFDFB0 VA: 0x180FFEBB0
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0xFFEBA0 Offset: 0xFFDFA0 VA: 0x180FFEBA0
	private static void Connect_internal(IntPtr sock, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0xFFF1D0 Offset: 0xFFE5D0 VA: 0x180FFF1D0
	public void Disconnect(bool reuseSocket) { }

	// RVA: 0xFFF740 Offset: 0xFFEB40 VA: 0x180FFF740
	public void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0xFFF0A0 Offset: 0xFFE4A0 VA: 0x180FFF0A0
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	// RVA: 0xFFF1C0 Offset: 0xFFE5C0 VA: 0x180FFF1C0
	private static void Disconnect_internal(IntPtr sock, bool reuse, out int error) { }

	// RVA: 0x1001DE0 Offset: 0x10011E0 VA: 0x181001DE0
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1001920 Offset: 0x1000D20 VA: 0x181001920
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0xFFD3A0 Offset: 0xFFC7A0 VA: 0x180FFD3A0
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0xFFF900 Offset: 0xFFED00 VA: 0x180FFF900
	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x1001720 Offset: 0x1000B20 VA: 0x181001720
	private static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1001860 Offset: 0x1000C60 VA: 0x181001860
	private static int Receive_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x10015E0 Offset: 0x10009E0 VA: 0x1810015E0
	private static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1001870 Offset: 0x1000C70 VA: 0x181001870
	private static int Receive_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1001440 Offset: 0x1000840 VA: 0x181001440
	internal int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	// RVA: 0xFFD150 Offset: 0xFFC550 VA: 0x180FFD150
	public IAsyncResult BeginReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0xFFF7F0 Offset: 0xFFEBF0 VA: 0x180FFF7F0
	public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint) { }

	// RVA: 0x10012F0 Offset: 0x10006F0 VA: 0x1810012F0
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x10012E0 Offset: 0x10006E0 VA: 0x1810012E0
	private static int ReceiveFrom_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x10029E0 Offset: 0x1001DE0 VA: 0x1810029E0
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x1002D80 Offset: 0x1002180 VA: 0x181002D80
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0xFFE440 Offset: 0xFFD840 VA: 0x180FFE440
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0xFFDCE0 Offset: 0xFFD0E0 VA: 0x180FFDCE0
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0xFFFBB0 Offset: 0xFFEFB0 VA: 0x180FFFBB0
	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x10027B0 Offset: 0x1001BB0 VA: 0x1810027B0
	private static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1002900 Offset: 0x1001D00 VA: 0x181002900
	private static int Send_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1002670 Offset: 0x1001A70 VA: 0x181002670
	private static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x10028F0 Offset: 0x1001CF0 VA: 0x1810028F0
	private static int Send_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1002460 Offset: 0x1001860 VA: 0x181002460
	public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0xFFE0F0 Offset: 0xFFD4F0 VA: 0x180FFE0F0
	public IAsyncResult BeginSendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0xFFDF30 Offset: 0xFFD330 VA: 0x180FFDF30
	private static void BeginSendToCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0xFFFB00 Offset: 0xFFEF00 VA: 0x180FFFB00
	public int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x1002300 Offset: 0x1001700 VA: 0x181002300
	private static int SendTo_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1002450 Offset: 0x1001850 VA: 0x181002450
	private static int SendTo_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0xFFFDB0 Offset: 0xFFF1B0 VA: 0x180FFFDB0
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0xFFFFB0 Offset: 0xFFF3B0 VA: 0x180FFFFB0
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0xFFFFA0 Offset: 0xFFF3A0 VA: 0x180FFFFA0
	private static void GetSocketOption_obj_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x10034D0 Offset: 0x10028D0 VA: 0x1810034D0
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue) { }

	// RVA: 0x10034F0 Offset: 0x10028F0 VA: 0x1810034F0
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x1003370 Offset: 0x1002770 VA: 0x181003370
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x10034C0 Offset: 0x10028C0 VA: 0x1810034C0
	private static void SetSocketOption_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x10003C0 Offset: 0xFFF7C0 VA: 0x1810003C0
	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x10000F0 Offset: 0xFFF4F0 VA: 0x1810000F0
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x1000240 Offset: 0xFFF640 VA: 0x181000240
	private static int IOControl_internal(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0xFFEB30 Offset: 0xFFDF30 VA: 0x180FFEB30
	public void Close() { }

	// RVA: 0xFFEAC0 Offset: 0xFFDEC0 VA: 0x180FFEAC0
	public void Close(int timeout) { }

	// RVA: 0xFFEAB0 Offset: 0xFFDEB0 VA: 0x180FFEAB0
	internal static void Close_internal(IntPtr socket, out int error) { }

	// RVA: 0x1003610 Offset: 0x1002A10 VA: 0x181003610
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	// RVA: 0x1003730 Offset: 0x1002B30 VA: 0x181003730
	internal static void Shutdown_internal(IntPtr socket, SocketShutdown how, out int error) { }

	// RVA: 0xFFF2C0 Offset: 0xFFE6C0 VA: 0x180FFF2C0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1000A10 Offset: 0xFFFE10 VA: 0x181000A10
	private void Linger(IntPtr handle) { }

	// RVA: 0x1003AD0 Offset: 0x1002ED0 VA: 0x181003AD0
	private void ThrowIfDisposedAndClosed() { }

	// RVA: 0x1003920 Offset: 0x1002D20 VA: 0x181003920
	private void ThrowIfBufferNull(byte[] buffer) { }

	// RVA: 0x1003980 Offset: 0x1002D80 VA: 0x181003980
	private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size) { }

	// RVA: 0x1003B70 Offset: 0x1002F70 VA: 0x181003B70
	private void ThrowIfUdp() { }

	// RVA: 0x1003BD0 Offset: 0x1002FD0 VA: 0x181003BD0
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x10011B0 Offset: 0x10005B0 VA: 0x1810011B0
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x1002050 Offset: 0x1001450 VA: 0x181002050
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x1004640 Offset: 0x1003A40 VA: 0x181004640
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x10047D0 Offset: 0x1003BD0 VA: 0x1810047D0
	internal static int get_FamilyHint() { }

	// RVA: 0xFE2550 Offset: 0xFE1950 VA: 0x180FE2550
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x10009C0 Offset: 0xFFFDC0 VA: 0x1810009C0
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x1003D00 Offset: 0x1003100 VA: 0x181003D00
	private static void .cctor() { }

}

private struct Socket.WSABUF // TypeDefIndex: 3048
{	// Fields
	public int len; // 0x0
	public IntPtr buf; // 0x8

}

private sealed class Socket.<>c // TypeDefIndex: 3049
{	// Fields
	public static readonly Socket.<>c <>9; // 0x0
	public static IOAsyncCallback <>9__241_0; // 0x8
	public static IOAsyncCallback <>9__253_0; // 0x10

	// Methods

	// RVA: 0x10098B0 Offset: 0x1008CB0 VA: 0x1810098B0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1007600 Offset: 0x1006A00 VA: 0x181007600
	internal void <BeginSend>b__241_0(IOAsyncResult s) { }

	// RVA: 0x1007580 Offset: 0x1006980 VA: 0x181007580
	internal void <BeginSendTo>b__253_0(IOAsyncResult s) { }

	// RVA: 0x10076F0 Offset: 0x1006AF0 VA: 0x1810076F0
	internal void <.cctor>b__309_0(IAsyncResult ares) { }

	// RVA: 0x1008450 Offset: 0x1007850 VA: 0x181008450
	internal void <.cctor>b__309_1(IOAsyncResult ares) { }

	// RVA: 0x1008540 Offset: 0x1007940 VA: 0x181008540
	internal void <.cctor>b__309_2(IOAsyncResult ares) { }

	// RVA: 0x10086E0 Offset: 0x1007AE0 VA: 0x1810086E0
	internal void <.cctor>b__309_3(IAsyncResult ares) { }

	// RVA: 0x1008970 Offset: 0x1007D70 VA: 0x181008970
	internal void <.cctor>b__309_4(IOAsyncResult ares) { }

	// RVA: 0x1008C40 Offset: 0x1008040 VA: 0x181008C40
	internal void <.cctor>b__309_5(IAsyncResult ares) { }

	// RVA: 0x1008ED0 Offset: 0x10082D0 VA: 0x181008ED0
	internal void <.cctor>b__309_6(IOAsyncResult ares) { }

	// RVA: 0x1009070 Offset: 0x1008470 VA: 0x181009070
	internal void <.cctor>b__309_7(IAsyncResult ares) { }

	// RVA: 0x1009280 Offset: 0x1008680 VA: 0x181009280
	internal void <.cctor>b__309_8(IOAsyncResult ares) { }

	// RVA: 0x1009400 Offset: 0x1008800 VA: 0x181009400
	internal void <.cctor>b__309_9(IOAsyncResult ares) { }

	// RVA: 0x1007A30 Offset: 0x1006E30 VA: 0x181007A30
	internal void <.cctor>b__309_10(IAsyncResult ares) { }

	// RVA: 0x1007C40 Offset: 0x1007040 VA: 0x181007C40
	internal void <.cctor>b__309_11(IOAsyncResult ares) { }

	// RVA: 0x1007EE0 Offset: 0x10072E0 VA: 0x181007EE0
	internal void <.cctor>b__309_12(IAsyncResult ares) { }

	// RVA: 0x10080F0 Offset: 0x10074F0 VA: 0x1810080F0
	internal void <.cctor>b__309_13(IOAsyncResult ares) { }

	// RVA: 0x1008240 Offset: 0x1007640 VA: 0x181008240
	internal void <.cctor>b__309_14(IAsyncResult ares) { }

}

private sealed class Socket.<>c__DisplayClass242_0 // TypeDefIndex: 3050
{	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x10096C0 Offset: 0x1008AC0 VA: 0x1810096C0
	internal void <BeginSendCallback>b__0(IOAsyncResult s) { }

}

private sealed class Socket.<>c__DisplayClass254_0 // TypeDefIndex: 3051
{	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1009750 Offset: 0x1008B50 VA: 0x181009750
	internal void <BeginSendToCallback>b__0(IOAsyncResult s) { }

}

private sealed class Socket.<>c__DisplayClass298_0 // TypeDefIndex: 3052
{	// Fields
	public Socket <>4__this; // 0x10
	public IOSelectorJob job; // 0x18
	public IntPtr handle; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x10097E0 Offset: 0x1008BE0 VA: 0x1810097E0
	internal void <QueueIOSelectorJob>b__0(Task t) { }

}

public enum SocketError // TypeDefIndex: 3053
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
	public const SocketOptionLevel Socket = 65535;
	public const SocketOptionLevel IP = 0;
	public const SocketOptionLevel IPv6 = 41;
	public const SocketOptionLevel Tcp = 6;
	public const SocketOptionLevel Udp = 17;

}

public enum SocketOptionName // TypeDefIndex: 3056
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
	public const SocketShutdown Receive = 0;
	public const SocketShutdown Send = 1;
	public const SocketShutdown Both = 2;

}

public enum SocketType // TypeDefIndex: 3058
{	// Fields
	public int value__; // 0x0
	public const SocketType Stream = 1;
	public const SocketType Dgram = 2;
	public const SocketType Raw = 3;
	public const SocketType Rdm = 4;
	public const SocketType Seqpacket = 5;
	public const SocketType Unknown = -1;

}

public class SocketAsyncEventArgs : EventArgs // TypeDefIndex: 3063
{	// Fields
	internal int in_progress; // 0x10
	internal EndPoint remote_ep; // 0x18
	internal Socket current_socket; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Socket <AcceptSocket>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <BytesTransferred>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SocketError <SocketError>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventHandler<SocketAsyncEventArgs> Completed; // 0x38

	// Properties
	public Socket AcceptSocket { get; set; }
	internal int BytesTransferred { set; }
	public SocketError SocketError { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public Socket get_AcceptSocket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	public void set_AcceptSocket(Socket value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA17E80 Offset: 0xA17280 VA: 0x180A17E80
	internal void set_BytesTransferred(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD6ED70 Offset: 0xD6E170 VA: 0x180D6ED70
	public void set_SocketError(SocketError value) { }

	// RVA: 0xFFC140 Offset: 0xFFB540 VA: 0x180FFC140
	internal void Complete() { }

	// RVA: 0xFFC160 Offset: 0xFFB560 VA: 0x180FFC160 Slot: 4
	protected virtual void OnCompleted(SocketAsyncEventArgs e) { }

}

internal sealed class SocketAsyncResult : IOAsyncResult // TypeDefIndex: 3064
{	// Fields
	public Socket socket; // 0x30
	public SocketOperation operation; // 0x38
	private Exception DelayedException; // 0x40
	public EndPoint EndPoint; // 0x48
	public byte[] Buffer; // 0x50
	public int Offset; // 0x58
	public int Size; // 0x5C
	public SocketFlags SockFlags; // 0x60
	public Socket AcceptSocket; // 0x68
	public IPAddress[] Addresses; // 0x70
	public int Port; // 0x78
	public IList<ArraySegment<byte>> Buffers; // 0x80
	public bool ReuseSocket; // 0x88
	public int CurrentAddress; // 0x8C
	public Socket AcceptedSocket; // 0x90
	public int Total; // 0x98
	internal int error; // 0x9C
	public int EndCalled; // 0xA0

	// Properties
	public IntPtr Handle { get; }
	public SocketError ErrorCode { get; }

	// Methods

	// RVA: 0xFFC660 Offset: 0xFFBA60 VA: 0x180FFC660
	public IntPtr get_Handle() { }

	// RVA: 0xFFC590 Offset: 0xFFB990 VA: 0x180FFC590
	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0xFFC5E0 Offset: 0xFFB9E0 VA: 0x180FFC5E0
	public SocketError get_ErrorCode() { }

	// RVA: 0xFFC1B0 Offset: 0xFFB5B0 VA: 0x180FFC1B0
	public void CheckIfThrowDelayedException() { }

	// RVA: 0xFFC280 Offset: 0xFFB680 VA: 0x180FFC280 Slot: 8
	internal override void CompleteDisposed() { }

	// RVA: 0xFFC340 Offset: 0xFFB740 VA: 0x180FFC340
	public void Complete() { }

	// RVA: 0xFFC330 Offset: 0xFFB730 VA: 0x180FFC330
	public void Complete(bool synch) { }

	// RVA: 0xFFC580 Offset: 0xFFB980 VA: 0x180FFC580
	public void Complete(int total) { }

	// RVA: 0xFFC290 Offset: 0xFFB690 VA: 0x180FFC290
	public void Complete(Exception e, bool synch) { }

	// RVA: 0xFFC2D0 Offset: 0xFFB6D0 VA: 0x180FFC2D0
	public void Complete(Exception e) { }

	// RVA: 0xFFC300 Offset: 0xFFB700 VA: 0x180FFC300
	public void Complete(Socket s) { }

	// RVA: 0xFFC540 Offset: 0xFFB940 VA: 0x180FFC540
	public void Complete(Socket s, int total) { }

}

private sealed class SocketAsyncResult.<>c // TypeDefIndex: 3065
{	// Fields
	public static readonly SocketAsyncResult.<>c <>9; // 0x0
	public static WaitCallback <>9__27_0; // 0x8

	// Methods

	// RVA: 0x1009850 Offset: 0x1008C50 VA: 0x181009850
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1007680 Offset: 0x1006A80 VA: 0x181007680
	internal void <Complete>b__27_0(object state) { }

}

internal enum SocketOperation // TypeDefIndex: 3066
{	// Fields
	public int value__; // 0x0
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
{	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x15644D0 Offset: 0x15638D0 VA: 0x1815644D0
	public void .ctor() { }

	// RVA: 0x1564500 Offset: 0x1563900 VA: 0x181564500 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

public class SocketManager // TypeDefIndex: 5182
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ISocketManager <Interface>k__BackingField; // 0x10
	public HashSet<Connection> Connecting; // 0x18
	public HashSet<Connection> Connected; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Socket <Socket>k__BackingField; // 0x28
	internal HSteamNetPollGroup pollGroup; // 0x2C

	// Properties
	public ISocketManager Interface { get; set; }
	public Socket Socket { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public ISocketManager get_Interface() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_Interface(ISocketManager value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	public Socket get_Socket() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8DF0 Offset: 0x7E81F0 VA: 0x1807E8DF0
	internal void set_Socket(Socket value) { }

	// RVA: 0xDDE930 Offset: 0xDDDD30 VA: 0x180DDE930 Slot: 3
	public override string ToString() { }

	// RVA: 0xDDDC50 Offset: 0xDDD050 VA: 0x180DDDC50
	internal void Initialize() { }

	// RVA: 0xDDDB40 Offset: 0xDDCF40 VA: 0x180DDDB40
	public bool Close() { }

	// RVA: 0xDDDF10 Offset: 0xDDD310 VA: 0x180DDDF10 Slot: 4
	public virtual void OnConnectionChanged(Connection connection, ConnectionInfo info) { }

	// RVA: 0xDDDE00 Offset: 0xDDD200 VA: 0x180DDDE00 Slot: 5
	public virtual void OnConnecting(Connection connection, ConnectionInfo info) { }

	// RVA: 0xDDDCC0 Offset: 0xDDD0C0 VA: 0x180DDDCC0 Slot: 6
	public virtual void OnConnected(Connection connection, ConnectionInfo info) { }

	// RVA: 0xDDE2C0 Offset: 0xDDD6C0 VA: 0x180DDE2C0 Slot: 7
	public virtual void OnDisconnected(Connection connection, ConnectionInfo info) { }

	// RVA: 0xDDE730 Offset: 0xDDDB30 VA: 0x180DDE730
	public int Receive(int bufferSize = 32, bool receiveToEnd = True) { }

	// RVA: 0xDDE570 Offset: 0xDDD970 VA: 0x180DDE570
	internal void ReceiveMessage(IntPtr msgPtr) { }

	// RVA: 0xDDE3E0 Offset: 0xDDD7E0 VA: 0x180DDE3E0 Slot: 8
	public virtual void OnMessage(Connection connection, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel) { }

	// RVA: 0xDDE950 Offset: 0xDDDD50 VA: 0x180DDE950
	public void .ctor() { }

}

public struct Socket // TypeDefIndex: 5547
{	// Fields
	internal uint Id; // 0x0

	// Methods

	// RVA: 0x1D7B50 Offset: 0x1D6F50 VA: 0x1801D7B50 Slot: 3
	public override string ToString() { }

	// RVA: 0x6BFDB0 Offset: 0x6BF1B0 VA: 0x1806BFDB0
	public static Socket op_Implicit(uint value) { }

	// RVA: 0x1D8690 Offset: 0x1D7A90 VA: 0x1801D8690
	public bool Close() { }

}

public class SocketWrapper : ISocket // TypeDefIndex: 6921
{	// Fields
	private static readonly byte[] keepAliveValues; // 0x0
	private readonly Socket _socket; // 0x10
	private CancellationTokenSource _tokenSource; // 0x18
	private TaskFactory _taskFactory; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Stream <Stream>k__BackingField; // 0x28

	// Properties
	public IPAddress RemoteIpAddress { get; }
	public int RemotePort { get; }
	public bool Connected { get; }
	public Stream Stream { get; set; }
	public bool NoDelay { set; }
	public EndPoint LocalEndPoint { get; }

	// Methods

	// RVA: 0x22037E0 Offset: 0x2202BE0 VA: 0x1822037E0 Slot: 5
	public IPAddress get_RemoteIpAddress() { }

	// RVA: 0x2203870 Offset: 0x2202C70 VA: 0x182203870 Slot: 6
	public int get_RemotePort() { }

	// RVA: 0x2203520 Offset: 0x2202920 VA: 0x182203520
	private static void .cctor() { }

	// RVA: 0x2203620 Offset: 0x2202A20 VA: 0x182203620
	public void .ctor(Socket socket) { }

	// RVA: 0x22030E0 Offset: 0x22024E0 VA: 0x1822030E0 Slot: 11
	public Task Authenticate(X509Certificate2 certificate, SslProtocols enabledSslProtocols, Action callback, Action<Exception> error) { }

	// RVA: 0x2203500 Offset: 0x2202900 VA: 0x182203500 Slot: 15
	public void Listen(int backlog) { }

	// RVA: 0x2203430 Offset: 0x2202830 VA: 0x182203430 Slot: 14
	public void Bind(EndPoint endPoint) { }

	// RVA: 0x22037A0 Offset: 0x2202BA0 VA: 0x1822037A0 Slot: 4
	public bool get_Connected() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 7
	public Stream get_Stream() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	private void set_Stream(Stream value) { }

	// RVA: 0x2203900 Offset: 0x2202D00 VA: 0x182203900 Slot: 8
	public void set_NoDelay(bool value) { }

	// RVA: 0x22037C0 Offset: 0x2202BC0 VA: 0x1822037C0 Slot: 9
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x2202EE0 Offset: 0x22022E0 VA: 0x182202EE0 Slot: 10
	public Task<ISocket> Accept(Action<ISocket> callback, Action<Exception> error) { }

	// RVA: 0x22034B0 Offset: 0x22028B0 VA: 0x1822034B0 Slot: 12
	public void Dispose() { }

	// RVA: 0x2203450 Offset: 0x2202850 VA: 0x182203450 Slot: 13
	public void Close() { }

}

private sealed class SocketWrapper.<>c__DisplayClass12_0 // TypeDefIndex: 6922
{	// Fields
	public SslStream ssl; // 0x10
	public X509Certificate2 certificate; // 0x18
	public SslProtocols enabledSslProtocols; // 0x20
	public Action callback; // 0x28
	public Action<Exception> error; // 0x30

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x2203C80 Offset: 0x2203080 VA: 0x182203C80
	internal IAsyncResult <Authenticate>b__0(AsyncCallback cb, object s) { }

	// RVA: 0x2203CD0 Offset: 0x22030D0 VA: 0x182203CD0
	internal void <Authenticate>b__1(Task t) { }

	// RVA: 0x2203CF0 Offset: 0x22030F0 VA: 0x182203CF0
	internal void <Authenticate>b__2(Task t) { }

	// RVA: 0x2203D60 Offset: 0x2203160 VA: 0x182203D60
	internal void <Authenticate>b__3(Task t) { }

}

private sealed class SocketWrapper.<>c__DisplayClass26_0 // TypeDefIndex: 6923
{	// Fields
	public SocketWrapper <>4__this; // 0x10
	public Action<ISocket> callback; // 0x18
	public Action<Exception> error; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x2203DD0 Offset: 0x22031D0 VA: 0x182203DD0
	internal ISocket <Accept>b__0(IAsyncResult r) { }

	// RVA: 0x2203E90 Offset: 0x2203290 VA: 0x182203E90
	internal void <Accept>b__1(Task<ISocket> t) { }

	// RVA: 0x2203F00 Offset: 0x2203300 VA: 0x182203F00
	internal void <Accept>b__2(Task t) { }

	// RVA: 0x2203F70 Offset: 0x2203370 VA: 0x182203F70
	internal void <Accept>b__3(Task<ISocket> t) { }

}

public class SocketHandle : PrefabAttribute // TypeDefIndex: 9088
{	// Methods

	// RVA: 0x5D0D40 Offset: 0x5D0140 VA: 0x1805D0D40 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x5D0B60 Offset: 0x5CFF60 VA: 0x1805D0B60
	internal void AdjustTarget(ref Construction.Target target, float maxplaceDistance) { }

	// RVA: 0x5D0DA0 Offset: 0x5D01A0 VA: 0x1805D0DA0
	public void .ctor() { }

}

public class SocketMod : PrefabAttribute // TypeDefIndex: 9089
{	// Fields
	public Socket_Base baseSocket; // 0x98
	public Translate.Phrase FailedPhrase; // 0xA0

	// Methods

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 8
	public virtual bool DoCheck(Construction.Placement place) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	public virtual void ModifyPlacement(Construction.Placement place) { }

	// RVA: 0x5D4010 Offset: 0x5D3410 VA: 0x1805D4010 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x5D4C20 Offset: 0x5D4020 VA: 0x1805D4C20
	public void .ctor() { }

}

public class SocketMod_AngleCheck : SocketMod // TypeDefIndex: 9090
{	// Fields
	public bool wantsAngle; // 0xA8
	public Vector3 worldNormal; // 0xAC
	public float withinDegrees; // 0xB8
	public static Translate.Phrase ErrorPhrase; // 0x0

	// Methods

	// RVA: 0x5D1130 Offset: 0x5D0530 VA: 0x1805D1130
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5D0E00 Offset: 0x5D0200 VA: 0x1805D0E00 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5D12D0 Offset: 0x5D06D0 VA: 0x1805D12D0
	public void .ctor() { }

	// RVA: 0x5D1260 Offset: 0x5D0660 VA: 0x1805D1260
	private static void .cctor() { }

}

public class SocketMod_AreaCheck : SocketMod // TypeDefIndex: 9091
{	// Fields
	public Bounds bounds; // 0xA8
	public LayerMask layerMask; // 0xC0
	public bool wantsInside; // 0xC4

	// Methods

	// RVA: 0x5D1B70 Offset: 0x5D0F70 VA: 0x1805D1B70
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5D1A40 Offset: 0x5D0E40 VA: 0x1805D1A40
	public static bool IsInArea(Vector3 position, Quaternion rotation, Bounds bounds, LayerMask layerMask) { }

	// RVA: 0x5D1390 Offset: 0x5D0790 VA: 0x1805D1390
	public bool DoCheck(Vector3 position, Quaternion rotation) { }

	// RVA: 0x5D15E0 Offset: 0x5D09E0 VA: 0x1805D15E0 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5D1C90 Offset: 0x5D1090 VA: 0x1805D1C90
	public void .ctor() { }

}

public class SocketMod_Attraction : SocketMod // TypeDefIndex: 9092
{	// Fields
	public float outerRadius; // 0xA8
	public float innerRadius; // 0xAC
	public string groupName; // 0xB0
	public bool lockRotation; // 0xB8
	public bool ignoreRotationForRadiusCheck; // 0xB9
	public static TimeSince LastSnap; // 0x0

	// Methods

	// RVA: 0x5D2E50 Offset: 0x5D2250 VA: 0x1805D2E50
	private void OnDrawGizmosSelected() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5D1DE0 Offset: 0x5D11E0 VA: 0x1805D1DE0 Slot: 9
	public override void ModifyPlacement(Construction.Placement place) { }

	// RVA: 0x5D3010 Offset: 0x5D2410 VA: 0x1805D3010
	public void .ctor() { }

}

public class SocketMod_BuildingBlock : SocketMod // TypeDefIndex: 9093
{	// Fields
	public float sphereRadius; // 0xA8
	public LayerMask layerMask; // 0xAC
	public QueryTriggerInteraction queryTriggers; // 0xB0
	public bool wantsCollide; // 0xB4

	// Methods

	// RVA: 0x5D3370 Offset: 0x5D2770 VA: 0x1805D3370
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5D30B0 Offset: 0x5D24B0 VA: 0x1805D30B0 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5D34D0 Offset: 0x5D28D0 VA: 0x1805D34D0
	public void .ctor() { }

}

public class SocketMod_EntityCheck : SocketMod // TypeDefIndex: 9094
{	// Fields
	public float sphereRadius; // 0xA8
	public LayerMask layerMask; // 0xAC
	public QueryTriggerInteraction queryTriggers; // 0xB0
	public BaseEntity[] entityTypes; // 0xB8
	public bool wantsCollide; // 0xC0

	// Methods

	// RVA: 0x5D3950 Offset: 0x5D2D50 VA: 0x1805D3950
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5D3530 Offset: 0x5D2930 VA: 0x1805D3530 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5D34D0 Offset: 0x5D28D0 VA: 0x1805D34D0
	public void .ctor() { }

}

private sealed class SocketMod_EntityCheck.<>c__DisplayClass6_0 // TypeDefIndex: 9095
{	// Fields
	public BaseEntity ent; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5DDFA0 Offset: 0x5DD3A0 VA: 0x1805DDFA0
	internal bool <DoCheck>b__0(BaseEntity x) { }

}

public class SocketMod_EntityType : SocketMod // TypeDefIndex: 9096
{	// Fields
	public float sphereRadius; // 0xA8
	public LayerMask layerMask; // 0xAC
	public QueryTriggerInteraction queryTriggers; // 0xB0
	public BaseEntity searchType; // 0xB8
	public bool wantsCollide; // 0xC0

	// Methods

	// RVA: 0x5D3EB0 Offset: 0x5D32B0 VA: 0x1805D3EB0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5D3AB0 Offset: 0x5D2EB0 VA: 0x1805D3AB0 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5D34D0 Offset: 0x5D28D0 VA: 0x1805D34D0
	public void .ctor() { }

}

public class SocketMod_HotSpot : SocketMod // TypeDefIndex: 9097
{	// Fields
	public float spotSize; // 0xA8

	// Methods

	// RVA: 0x5D41B0 Offset: 0x5D35B0 VA: 0x1805D41B0
	private void OnDrawGizmos() { }

	// RVA: 0x5D4070 Offset: 0x5D3470 VA: 0x1805D4070 Slot: 9
	public override void ModifyPlacement(Construction.Placement place) { }

	// RVA: 0x5D4300 Offset: 0x5D3700 VA: 0x1805D4300
	public void .ctor() { }

}

public class SocketMod_InWater : SocketMod // TypeDefIndex: 9098
{	// Fields
	public bool wantsInWater; // 0xA8
	public static Translate.Phrase WantsWaterPhrase; // 0x0
	public static Translate.Phrase NoWaterPhrase; // 0x8

	// Methods

	// RVA: 0x5D4750 Offset: 0x5D3B50 VA: 0x1805D4750
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5D4360 Offset: 0x5D3760 VA: 0x1805D4360 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5D4900 Offset: 0x5D3D00 VA: 0x1805D4900
	public void .ctor() { }

	// RVA: 0x5D4850 Offset: 0x5D3C50 VA: 0x1805D4850
	private static void .cctor() { }

}

public class SocketMod_PhysicMaterial : SocketMod // TypeDefIndex: 9099
{	// Fields
	public PhysicMaterial[] ValidMaterials; // 0xA8
	private PhysicMaterial foundMaterial; // 0xB0

	// Methods

	// RVA: 0x5D4960 Offset: 0x5D3D60 VA: 0x1805D4960 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5D4C20 Offset: 0x5D4020 VA: 0x1805D4C20
	public void .ctor() { }

}

public class SocketMod_PlantCheck : SocketMod // TypeDefIndex: 9100
{	// Fields
	public float sphereRadius; // 0xA8
	public LayerMask layerMask; // 0xAC
	public QueryTriggerInteraction queryTriggers; // 0xB0
	public bool wantsCollide; // 0xB4

	// Methods

	// RVA: 0x5D50B0 Offset: 0x5D44B0 VA: 0x1805D50B0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5D4C80 Offset: 0x5D4080 VA: 0x1805D4C80 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5D34D0 Offset: 0x5D28D0 VA: 0x1805D34D0
	public void .ctor() { }

}

public class SocketMod_SphereCheck : SocketMod // TypeDefIndex: 9101
{	// Fields
	public float sphereRadius; // 0xA8
	public LayerMask layerMask; // 0xAC
	public bool wantsCollide; // 0xB0
	public static Translate.Phrase Error_WantsCollideConstruction; // 0x0
	public static Translate.Phrase Error_DoesNotWantCollideConstruction; // 0x8

	// Methods

	// RVA: 0x5D5A60 Offset: 0x5D4E60 VA: 0x1805D5A60
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5D5210 Offset: 0x5D4610 VA: 0x1805D5210 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5D34D0 Offset: 0x5D28D0 VA: 0x1805D34D0
	public void .ctor() { }

	// RVA: 0x5D5BC0 Offset: 0x5D4FC0 VA: 0x1805D5BC0
	private static void .cctor() { }

}

public class SocketMod_TerrainCheck : SocketMod // TypeDefIndex: 9102
{	// Fields
	public bool wantsInTerrain; // 0xA8

	// Methods

	// RVA: 0x5D6200 Offset: 0x5D5600 VA: 0x1805D6200
	private void OnDrawGizmos() { }

	// RVA: 0x5D5EB0 Offset: 0x5D52B0 VA: 0x1805D5EB0
	public static bool IsInTerrain(Vector3 vPoint) { }

	// RVA: 0x5D5C70 Offset: 0x5D5070 VA: 0x1805D5C70 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5D4900 Offset: 0x5D3D00 VA: 0x1805D4900
	public void .ctor() { }

}

public class SocketMod_WaterDepth : SocketMod // TypeDefIndex: 9103
{	// Fields
	public float MinimumWaterDepth; // 0xA8
	public float MaximumWaterDepth; // 0xAC
	public bool AllowWaterVolumes; // 0xB0
	public static Translate.Phrase TooDeepPhrase; // 0x0
	public static Translate.Phrase TooShallowPhrase; // 0x8

	// Methods

	// RVA: 0x5D6360 Offset: 0x5D5760 VA: 0x1805D6360 Slot: 8
	public override bool DoCheck(Construction.Placement place) { }

	// RVA: 0x5D68D0 Offset: 0x5D5CD0 VA: 0x1805D68D0
	public void .ctor() { }

	// RVA: 0x5D6820 Offset: 0x5D5C20 VA: 0x1805D6820
	private static void .cctor() { }

}

public class Socket_Base : PrefabAttribute // TypeDefIndex: 9104
{	// Fields
	public bool male; // 0x98
	public bool maleDummy; // 0x99
	public bool female; // 0x9A
	public bool femaleDummy; // 0x9B
	public bool monogamous; // 0x9C
	public Vector3 position; // 0xA0
	public Quaternion rotation; // 0xAC
	public Vector3 selectSize; // 0xBC
	public Vector3 selectCenter; // 0xC8
	[ReadOnlyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public string socketName; // 0xD8
	public SocketMod[] socketMods; // 0xE0

	// Methods

	// RVA: 0x5D7100 Offset: 0x5D6500 VA: 0x1805D7100
	public Vector3 GetSelectPivot(Vector3 position, Quaternion rotation) { }

	// RVA: 0x5D6EE0 Offset: 0x5D62E0 VA: 0x1805D6EE0
	public OBB GetSelectBounds(Vector3 position, Quaternion rotation) { }

	// RVA: 0x5D6E80 Offset: 0x5D6280 VA: 0x1805D6E80 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x5D6940 Offset: 0x5D5D40 VA: 0x1805D6940 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x5D7310 Offset: 0x5D6710 VA: 0x1805D7310 Slot: 8
	public virtual bool TestTarget(Construction.Target target) { }

	// RVA: 0x5D7220 Offset: 0x5D6620 VA: 0x1805D7220 Slot: 9
	public virtual bool IsCompatible(Socket_Base socket) { }

	// RVA: 0x5D6AC0 Offset: 0x5D5EC0 VA: 0x1805D6AC0 Slot: 10
	public virtual bool CanConnect(Vector3 position, Quaternion rotation, Socket_Base socket, Vector3 socketPosition, Quaternion socketRotation) { }

	// RVA: 0x5D6C70 Offset: 0x5D6070 VA: 0x1805D6C70 Slot: 11
	public virtual Construction.Placement DoPlacement(Construction.Target target) { }

	// RVA: 0x5D6AE0 Offset: 0x5D5EE0 VA: 0x1805D6AE0 Slot: 12
	public virtual bool CheckSocketMods(Construction.Placement placement) { }

	// RVA: 0x5D7380 Offset: 0x5D6780 VA: 0x1805D7380
	public void .ctor() { }

}

public class Socket_Free : Socket_Base // TypeDefIndex: 9105
{	// Fields
	public Vector3 idealPlacementNormal; // 0xE8
	public bool useTargetNormal; // 0xF4
	public bool blendAimAngle; // 0xF5

	// Methods

	// RVA: 0x5D79F0 Offset: 0x5D6DF0 VA: 0x1805D79F0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5D7BE0 Offset: 0x5D6FE0 VA: 0x1805D7BE0 Slot: 8
	public override bool TestTarget(Construction.Target target) { }

	// RVA: 0x5D7460 Offset: 0x5D6860 VA: 0x1805D7460 Slot: 11
	public override Construction.Placement DoPlacement(Construction.Target target) { }

	// RVA: 0x5D7BF0 Offset: 0x5D6FF0 VA: 0x1805D7BF0
	public void .ctor() { }

}

public class Socket_Specific : Socket_Base // TypeDefIndex: 9106
{	// Fields
	public bool useFemaleRotation; // 0xE8
	public string targetSocketName; // 0xF0

	// Methods

	// RVA: 0x5D86E0 Offset: 0x5D7AE0 VA: 0x1805D86E0
	private void OnDrawGizmos() { }

	// RVA: 0x5D8990 Offset: 0x5D7D90 VA: 0x1805D8990 Slot: 8
	public override bool TestTarget(Construction.Target target) { }

	// RVA: 0x5D7C70 Offset: 0x5D7070 VA: 0x1805D7C70 Slot: 11
	public override Construction.Placement DoPlacement(Construction.Target target) { }

	// RVA: 0x5D8B20 Offset: 0x5D7F20 VA: 0x1805D8B20
	public void .ctor() { }

}

public class Socket_Specific_Female : Socket_Base // TypeDefIndex: 9107
{	// Fields
	public int rotationDegrees; // 0xE8
	public int rotationOffset; // 0xEC
	public string[] allowedMaleSockets; // 0xF0

	// Methods

	// RVA: 0x5D8420 Offset: 0x5D7820 VA: 0x1805D8420
	private void OnDrawGizmos() { }

	// RVA: 0x5D8370 Offset: 0x5D7770 VA: 0x1805D8370
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5D82E0 Offset: 0x5D76E0 VA: 0x1805D82E0
	public bool CanAccept(Socket_Specific socket) { }

	// RVA: 0x5D86D0 Offset: 0x5D7AD0 VA: 0x1805D86D0
	public void .ctor() { }

}

public class Socket_Terrain : Socket_Base // TypeDefIndex: 9108
{	// Fields
	public float placementHeight; // 0xE8
	public bool alignToNormal; // 0xEC

	// Methods

	// RVA: 0x5D8E30 Offset: 0x5D8230 VA: 0x1805D8E30
	private void OnDrawGizmos() { }

	// RVA: 0x5D7BE0 Offset: 0x5D6FE0 VA: 0x1805D7BE0 Slot: 8
	public override bool TestTarget(Construction.Target target) { }

	// RVA: 0x5D8B30 Offset: 0x5D7F30 VA: 0x1805D8B30 Slot: 11
	public override Construction.Placement DoPlacement(Construction.Target target) { }

	// RVA: 0x5D86D0 Offset: 0x5D7AD0 VA: 0x1805D86D0
	public void .ctor() { }

}

