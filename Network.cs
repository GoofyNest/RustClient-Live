internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem // TypeDefIndex: 815
{	// Fields
	private WaitCallback callback; // 0x10
	private ExecutionContext context; // 0x18
	private object state; // 0x20
	internal static ContextCallback ccb; // 0x0

	// Methods

	// RVA: 0x1492A10 Offset: 0x1491E10 VA: 0x181492A10
	private static void .cctor() { }

	// RVA: 0x1492A90 Offset: 0x1491E90 VA: 0x181492A90
	internal void .ctor(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark) { }

	// RVA: 0x14928B0 Offset: 0x1491CB0 VA: 0x1814928B0 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x14929A0 Offset: 0x1491DA0 VA: 0x1814929A0
	private static void WaitCallback_Context(object state) { }

}

public class ProxyAttribute : Attribute // TypeDefIndex: 1159
{	// Methods

	// RVA: 0x147D3C0 Offset: 0x147C7C0 VA: 0x18147D3C0 Slot: 7
	public virtual MarshalByRefObject CreateInstance(Type serverType) { }

	// RVA: 0x147D4D0 Offset: 0x147C8D0 VA: 0x18147D4D0 Slot: 8
	public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext) { }

}

public class Queue : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1413
{	// Fields
	private object[] _array; // 0x10
	private int _head; // 0x18
	private int _tail; // 0x1C
	private int _size; // 0x20
	private int _growFactor; // 0x24
	private int _version; // 0x28
	private object _syncRoot; // 0x30

	// Properties
	public virtual int Count { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x14627A0 Offset: 0x1461BA0 VA: 0x1814627A0
	public void .ctor() { }

	// RVA: 0x14623E0 Offset: 0x14617E0 VA: 0x1814623E0
	public void .ctor(int capacity) { }

	// RVA: 0x14625E0 Offset: 0x14619E0 VA: 0x1814625E0
	public void .ctor(int capacity, float growFactor) { }

	// RVA: 0x14623F0 Offset: 0x14617F0 VA: 0x1814623F0
	public void .ctor(ICollection col) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x1461AE0 Offset: 0x1460EE0 VA: 0x181461AE0 Slot: 10
	public virtual object Clone() { }

	// RVA: 0x14627C0 Offset: 0x1461BC0 VA: 0x1814627C0 Slot: 11
	public virtual object get_SyncRoot() { }

	// RVA: 0x1461A80 Offset: 0x1460E80 VA: 0x181461A80 Slot: 12
	public virtual void Clear() { }

	// RVA: 0x1461BD0 Offset: 0x1460FD0 VA: 0x181461BD0 Slot: 13
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x1461ED0 Offset: 0x14612D0 VA: 0x181461ED0 Slot: 14
	public virtual void Enqueue(object obj) { }

	// RVA: 0x14620D0 Offset: 0x14614D0 VA: 0x1814620D0 Slot: 15
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1461DD0 Offset: 0x14611D0 VA: 0x181461DD0 Slot: 16
	public virtual object Dequeue() { }

	// RVA: 0x1462180 Offset: 0x1461580 VA: 0x181462180 Slot: 17
	public virtual object Peek() { }

	// RVA: 0x1462090 Offset: 0x1461490 VA: 0x181462090
	internal object GetElement(int i) { }

	// RVA: 0x1462320 Offset: 0x1461720 VA: 0x181462320 Slot: 18
	public virtual object[] ToArray() { }

	// RVA: 0x1462240 Offset: 0x1461640 VA: 0x181462240
	private void SetCapacity(int capacity) { }

}

private class Queue.QueueEnumerator : IEnumerator, ICloneable // TypeDefIndex: 1414
{	// Fields
	private Queue _q; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x1461930 Offset: 0x1460D30 VA: 0x181461930
	internal void .ctor(Queue q) { }

	// RVA: 0xD6C080 Offset: 0xD6B480 VA: 0x180D6C080 Slot: 7
	public object Clone() { }

	// RVA: 0x1461770 Offset: 0x1460B70 VA: 0x181461770 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x14619B0 Offset: 0x1460DB0 VA: 0x1814619B0 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x1461880 Offset: 0x1460C80 VA: 0x181461880 Slot: 10
	public virtual void Reset() { }

}

public class NetworkCredential : ICredentials // TypeDefIndex: 2893
{	// Fields
	private string m_domain; // 0x10
	private string m_userName; // 0x18
	private SecureString m_password; // 0x20

	// Properties
	public string UserName { get; set; }
	public string Password { get; set; }
	public string Domain { get; set; }

	// Methods

	// RVA: 0x1342C00 Offset: 0x1342000 VA: 0x181342C00
	public void .ctor(string userName, string password) { }

	// RVA: 0x1342D00 Offset: 0x1342100 VA: 0x181342D00
	public void .ctor(string userName, string password, string domain) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_UserName() { }

	// RVA: 0x1342E70 Offset: 0x1342270 VA: 0x181342E70
	public void set_UserName(string value) { }

	// RVA: 0x1342BF0 Offset: 0x1341FF0 VA: 0x181342BF0
	public string get_Password() { }

	// RVA: 0x1342E40 Offset: 0x1342240 VA: 0x181342E40
	public void set_Password(string value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Domain() { }

	// RVA: 0x1342DE0 Offset: 0x13421E0 VA: 0x181342DE0
	public void set_Domain(string value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal string InternalGetUserName() { }

	// RVA: 0x1342BF0 Offset: 0x1341FF0 VA: 0x181342BF0
	internal string InternalGetPassword() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal string InternalGetDomain() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 4
	public NetworkCredential GetCredential(Uri uri, string authType) { }

}

internal class NetRes // TypeDefIndex: 2921
{	// Methods

	// RVA: 0x1342B40 Offset: 0x1341F40 VA: 0x181342B40
	public static string GetWebStatusString(string Res, WebExceptionStatus Status) { }

	// RVA: 0x1342AE0 Offset: 0x1341EE0 VA: 0x181342AE0
	public static string GetWebStatusString(WebExceptionStatus Status) { }

}

public class NetworkStream : Stream // TypeDefIndex: 3044
{
// Namespace: System.Net.Sockets
public class NetworkStream : Stream // TypeDefIndex: 3044
	// Fields
	private Socket m_StreamSocket; // 0x28
	private bool m_Readable; // 0x30
	private bool m_Writeable; // 0x31
	private bool m_OwnsSocket; // 0x32
	private int m_CloseTimeout; // 0x34
	private bool m_CleanedUp; // 0x38
	private int m_CurrentReadTimeout; // 0x3C
	private int m_CurrentWriteTimeout; // 0x40

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0xFF60A0 Offset: 0xFF54A0 VA: 0x180FF60A0
	public void .ctor(Socket socket) { }

	// RVA: 0xFF5FD0 Offset: 0xFF53D0 VA: 0x180FF5FD0
	public void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x8298F0 Offset: 0x828CF0 VA: 0x1808298F0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xFF6160 Offset: 0xFF5560 VA: 0x180FF6160 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xFF6250 Offset: 0xFF5650 VA: 0x180FF6250 Slot: 13
	public override int get_ReadTimeout() { }

	// RVA: 0xFF62E0 Offset: 0xFF56E0 VA: 0x180FF62E0 Slot: 14
	public override int get_WriteTimeout() { }

	// RVA: 0xFF6170 Offset: 0xFF5570 VA: 0x180FF6170 Slot: 10
	public override long get_Length() { }

	// RVA: 0xFF61E0 Offset: 0xFF55E0 VA: 0x180FF61E0 Slot: 11
	public override long get_Position() { }

	// RVA: 0xFF6370 Offset: 0xFF5770 VA: 0x180FF6370 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0xFF5B40 Offset: 0xFF4F40 VA: 0x180FF5B40 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xFF5620 Offset: 0xFF4A20 VA: 0x180FF5620
	internal void InitNetworkStream(Socket socket, FileAccess Access) { }

	// RVA: 0xFF5790 Offset: 0xFF4B90 VA: 0x180FF5790 Slot: 27
	public override int Read([In] [Out] byte[] buffer, int offset, int size) { }

	// RVA: 0xFF5C20 Offset: 0xFF5020 VA: 0x180FF5C20 Slot: 29
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0xFF4F40 Offset: 0xFF4340 VA: 0x180FF4F40 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0xFF5580 Offset: 0xFF4980 VA: 0x180FF5580 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xFF47C0 Offset: 0xFF3BC0 VA: 0x180FF47C0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0xFF5020 Offset: 0xFF4420 VA: 0x180FF5020 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0xFF4B80 Offset: 0xFF3F80 VA: 0x180FF4B80 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0xFF52D0 Offset: 0xFF46D0 VA: 0x180FF52D0 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 18
	public override void Flush() { }

	// RVA: 0xFF5BB0 Offset: 0xFF4FB0 VA: 0x180FF5BB0 Slot: 26
	public override void SetLength(long value) { }

}

public class NetworkInformationException : Win32Exception // TypeDefIndex: 3074
{	// Methods

	// RVA: 0x1342ED0 Offset: 0x13422D0 VA: 0x181342ED0
	public void .ctor() { }

	// RVA: 0x1342F60 Offset: 0x1342360 VA: 0x181342F60
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

public enum NetworkInterfaceComponent // TypeDefIndex: 3075
{	// Fields
	public int value__; // 0x0
	public const NetworkInterfaceComponent IPv4 = 0;
	public const NetworkInterfaceComponent IPv6 = 1;

}

public enum NetBiosNodeType // TypeDefIndex: 3076
{	// Fields
	public int value__; // 0x0
	public const NetBiosNodeType Unknown = 0;
	public const NetBiosNodeType Broadcast = 1;
	public const NetBiosNodeType Peer2Peer = 2;
	public const NetBiosNodeType Mixed = 4;
	public const NetBiosNodeType Hybrid = 8;

}

public class Queue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 3118
{	// Fields
	private T[] _array; // 0x0
	private int _head; // 0x0
	private int _tail; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0
	private object _syncRoot; // 0x0
	private const int MinimumGrow = 4;
	private const int GrowFactor = 200;

	// Properties
	public int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1953800 Offset: 0x1952C00 VA: 0x181953800
	|-Queue<BaseEntity>..ctor
	|-Queue<DeferredAction>..ctor
	|-Queue<RCon.Command>..ctor
	|-Queue<QueuedStream.WriteData>..ctor
	|-Queue<CFNetwork.GetProxyData>..ctor
	|-Queue<OccludeeState>..ctor
	|-Queue<OcclusionCulling.Cell>..ctor
	|-Queue<int>..ctor
	|-Queue<IntPtr>..ctor
	|-Queue<object>..ctor
	|-Queue<string>..ctor
	|-Queue<ulong>..ctor
	|-Queue<WeakReference>..ctor
	|-Queue<AsyncGPUReadbackRequest>..ctor
	|-Queue<Transform>..ctor
	|-Queue<EventDispatcher.EventRecord>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1953940 Offset: 0x1952D40 VA: 0x181953940
	|-Queue<RCon.Command>..ctor
	|
	|-RVA: 0x1953A30 Offset: 0x1952E30 VA: 0x181953A30
	|-Queue<int>..ctor
	|
	|-RVA: 0x1953D00 Offset: 0x1953100 VA: 0x181953D00
	|-Queue<IntPtr>..ctor
	|
	|-RVA: 0x1953DF0 Offset: 0x19531F0 VA: 0x181953DF0
	|-Queue<object>..ctor
	|-Queue<string>..ctor
	|-Queue<Renderer>..ctor
	|
	|-RVA: 0x1953C10 Offset: 0x1953010 VA: 0x181953C10
	|-Queue<ulong>..ctor
	|
	|-RVA: 0x1953850 Offset: 0x1952C50 VA: 0x181953850
	|-Queue<AsyncGPUReadbackRequest>..ctor
	|
	|-RVA: 0x1953B20 Offset: 0x1952F20 VA: 0x181953B20
	|-Queue<EventDispatcher.EventRecord>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	|-Queue<BaseEntity>.get_Count
	|-Queue<DeferredAction>.get_Count
	|-Queue<RCon.Command>.get_Count
	|-Queue<QueuedStream.WriteData>.get_Count
	|-Queue<CFNetwork.GetProxyData>.get_Count
	|-Queue<OccludeeState>.get_Count
	|-Queue<OcclusionCulling.Cell>.get_Count
	|-Queue<int>.get_Count
	|-Queue<IntPtr>.get_Count
	|-Queue<object>.get_Count
	|-Queue<string>.get_Count
	|-Queue<ulong>.get_Count
	|-Queue<WeakReference>.get_Count
	|-Queue<Renderer>.get_Count
	|-Queue<AsyncGPUReadbackRequest>.get_Count
	|-Queue<Transform>.get_Count
	|-Queue<EventDispatcher.EventRecord>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1953410 Offset: 0x1952810 VA: 0x181953410
	|-Queue<RCon.Command>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1953330 Offset: 0x1952730 VA: 0x181953330
	|-Queue<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x19533A0 Offset: 0x19527A0 VA: 0x1819533A0
	|-Queue<IntPtr>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x19534F0 Offset: 0x19528F0 VA: 0x1819534F0
	|-Queue<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1953480 Offset: 0x1952880 VA: 0x181953480
	|-Queue<ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1953250 Offset: 0x1952650 VA: 0x181953250
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x19532C0 Offset: 0x19526C0 VA: 0x1819532C0
	|-Queue<EventDispatcher.EventRecord>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1950FA0 Offset: 0x19503A0 VA: 0x181950FA0
	|-Queue<BaseEntity>.Clear
	|-Queue<RCon.Command>.Clear
	|-Queue<object>.Clear
	|-Queue<string>.Clear
	|-Queue<EventDispatcher.EventRecord>.Clear
	|
	|-RVA: 0x1950F80 Offset: 0x1950380 VA: 0x181950F80
	|-Queue<int>.Clear
	|-Queue<IntPtr>.Clear
	|-Queue<ulong>.Clear
	|-Queue<AsyncGPUReadbackRequest>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1952D30 Offset: 0x1952130 VA: 0x181952D30
	|-Queue<RCon.Command>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1952AA0 Offset: 0x1951EA0 VA: 0x181952AA0
	|-Queue<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x19522F0 Offset: 0x19516F0 VA: 0x1819522F0
	|-Queue<IntPtr>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1952060 Offset: 0x1951460 VA: 0x181952060
	|-Queue<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1952810 Offset: 0x1951C10 VA: 0x181952810
	|-Queue<ulong>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1952FC0 Offset: 0x19523C0 VA: 0x181952FC0
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1952580 Offset: 0x1951980 VA: 0x181952580
	|-Queue<EventDispatcher.EventRecord>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1951570 Offset: 0x1950970 VA: 0x181951570
	|-Queue<BaseEntity>.Enqueue
	|-Queue<DeferredAction>.Enqueue
	|-Queue<QueuedStream.WriteData>.Enqueue
	|-Queue<CFNetwork.GetProxyData>.Enqueue
	|-Queue<OccludeeState>.Enqueue
	|-Queue<OcclusionCulling.Cell>.Enqueue
	|-Queue<object>.Enqueue
	|-Queue<string>.Enqueue
	|-Queue<WeakReference>.Enqueue
	|-Queue<Renderer>.Enqueue
	|-Queue<Transform>.Enqueue
	|
	|-RVA: 0x19517C0 Offset: 0x1950BC0 VA: 0x1819517C0
	|-Queue<RCon.Command>.Enqueue
	|
	|-RVA: 0x19518B0 Offset: 0x1950CB0 VA: 0x1819518B0
	|-Queue<int>.Enqueue
	|
	|-RVA: 0x1951640 Offset: 0x1950A40 VA: 0x181951640
	|-Queue<IntPtr>.Enqueue
	|-Queue<ulong>.Enqueue
	|
	|-RVA: 0x19514B0 Offset: 0x19508B0 VA: 0x1819514B0
	|-Queue<AsyncGPUReadbackRequest>.Enqueue
	|
	|-RVA: 0x19516F0 Offset: 0x1950AF0 VA: 0x1819516F0
	|-Queue<EventDispatcher.EventRecord>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public Queue.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1951960 Offset: 0x1950D60 VA: 0x181951960
	|-Queue<string>.GetEnumerator
	|-Queue<IntPtr>.GetEnumerator
	|-Queue<object>.GetEnumerator
	|-Queue<ulong>.GetEnumerator
	|
	|-RVA: 0x1951A10 Offset: 0x1950E10 VA: 0x181951A10
	|-Queue<RCon.Command>.GetEnumerator
	|
	|-RVA: 0x1951A80 Offset: 0x1950E80 VA: 0x181951A80
	|-Queue<int>.GetEnumerator
	|
	|-RVA: 0x19519B0 Offset: 0x1950DB0 VA: 0x1819519B0
	|-Queue<AsyncGPUReadbackRequest>.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1951F90 Offset: 0x1951390 VA: 0x181951F90
	|-Queue<RCon.Command>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1951EF0 Offset: 0x19512F0 VA: 0x181951EF0
	|-Queue<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1951E50 Offset: 0x1951250 VA: 0x181951E50
	|-Queue<IntPtr>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<ulong>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x1951DB0 Offset: 0x19511B0 VA: 0x181951DB0
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1951F90 Offset: 0x1951390 VA: 0x181951F90
	|-Queue<RCon.Command>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1951EF0 Offset: 0x19512F0 VA: 0x181951EF0
	|-Queue<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1951E50 Offset: 0x1951250 VA: 0x181951E50
	|-Queue<IntPtr>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<object>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1951DB0 Offset: 0x19511B0 VA: 0x181951DB0
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19510E0 Offset: 0x19504E0 VA: 0x1819510E0
	|-Queue<BaseEntity>.Dequeue
	|-Queue<DeferredAction>.Dequeue
	|-Queue<QueuedStream.WriteData>.Dequeue
	|-Queue<OccludeeState>.Dequeue
	|-Queue<OcclusionCulling.Cell>.Dequeue
	|-Queue<string>.Dequeue
	|-Queue<WeakReference>.Dequeue
	|-Queue<Renderer>.Dequeue
	|-Queue<Transform>.Dequeue
	|-Queue<CFNetwork.GetProxyData>.Dequeue
	|-Queue<object>.Dequeue
	|
	|-RVA: 0x1951240 Offset: 0x1950640 VA: 0x181951240
	|-Queue<RCon.Command>.Dequeue
	|
	|-RVA: 0x1951370 Offset: 0x1950770 VA: 0x181951370
	|-Queue<int>.Dequeue
	|
	|-RVA: 0x19511A0 Offset: 0x19505A0 VA: 0x1819511A0
	|-Queue<IntPtr>.Dequeue
	|-Queue<ulong>.Dequeue
	|
	|-RVA: 0x1951400 Offset: 0x1950800 VA: 0x181951400
	|-Queue<AsyncGPUReadbackRequest>.Dequeue
	|
	|-RVA: 0x1951010 Offset: 0x1950410 VA: 0x181951010
	|-Queue<EventDispatcher.EventRecord>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1951BE0 Offset: 0x1950FE0 VA: 0x181951BE0
	|-Queue<ulong>.Peek
	|-Queue<IntPtr>.Peek
	|-Queue<object>.Peek
	|
	|-RVA: 0x1951B60 Offset: 0x1950F60 VA: 0x181951B60
	|-Queue<AsyncGPUReadbackRequest>.Peek
	|-Queue<EventDispatcher.EventRecord>.Peek
	|
	|-RVA: 0x1951C40 Offset: 0x1951040 VA: 0x181951C40
	|-Queue<RCon.Command>.Peek
	|
	|-RVA: 0x1951B00 Offset: 0x1950F00 VA: 0x181951B00
	|-Queue<int>.Peek
	*/

	// RVA: -1 Offset: -1
	private void SetCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1951CD0 Offset: 0x19510D0 VA: 0x181951CD0
	|-Queue<RCon.Command>.SetCapacity
	|-Queue<int>.SetCapacity
	|-Queue<IntPtr>.SetCapacity
	|-Queue<object>.SetCapacity
	|-Queue<ulong>.SetCapacity
	|-Queue<AsyncGPUReadbackRequest>.SetCapacity
	|-Queue<EventDispatcher.EventRecord>.SetCapacity
	*/

	// RVA: -1 Offset: -1
	private void MoveNext(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1951AD0 Offset: 0x1950ED0 VA: 0x181951AD0
	|-Queue<RCon.Command>.MoveNext
	|-Queue<int>.MoveNext
	|-Queue<IntPtr>.MoveNext
	|-Queue<object>.MoveNext
	|-Queue<ulong>.MoveNext
	|-Queue<AsyncGPUReadbackRequest>.MoveNext
	|-Queue<EventDispatcher.EventRecord>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void ThrowForEmptyQueue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19535C0 Offset: 0x19529C0 VA: 0x1819535C0
	|-Queue<RCon.Command>.ThrowForEmptyQueue
	|
	|-RVA: 0x1953620 Offset: 0x1952A20 VA: 0x181953620
	|-Queue<int>.ThrowForEmptyQueue
	|
	|-RVA: 0x1953560 Offset: 0x1952960 VA: 0x181953560
	|-Queue<IntPtr>.ThrowForEmptyQueue
	|
	|-RVA: 0x19536E0 Offset: 0x1952AE0 VA: 0x1819536E0
	|-Queue<object>.ThrowForEmptyQueue
	|
	|-RVA: 0x1953740 Offset: 0x1952B40 VA: 0x181953740
	|-Queue<ulong>.ThrowForEmptyQueue
	|
	|-RVA: 0x1953680 Offset: 0x1952A80 VA: 0x181953680
	|-Queue<AsyncGPUReadbackRequest>.ThrowForEmptyQueue
	|
	|-RVA: 0x19537A0 Offset: 0x1952BA0 VA: 0x1819537A0
	|-Queue<EventDispatcher.EventRecord>.ThrowForEmptyQueue
	*/

}

public struct Queue.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 3119
{	// Fields
	private readonly Queue<T> _q; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _currentElement; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Queue<T> q) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x220490 Offset: 0x21F890 VA: 0x180220490
	|-Queue.Enumerator<RCon.Command>..ctor
	|
	|-RVA: 0x2205F0 Offset: 0x21F9F0 VA: 0x1802205F0
	|-Queue.Enumerator<int>..ctor
	|
	|-RVA: 0x2205A0 Offset: 0x21F9A0 VA: 0x1802205A0
	|-Queue.Enumerator<IntPtr>..ctor
	|-Queue.Enumerator<object>..ctor
	|-Queue.Enumerator<ulong>..ctor
	|
	|-RVA: 0x220440 Offset: 0x21F840 VA: 0x180220440
	|-Queue.Enumerator<AsyncGPUReadbackRequest>..ctor
	|-Queue.Enumerator<EventDispatcher.EventRecord>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21EA10 Offset: 0x21DE10 VA: 0x18021EA10
	|-Queue.Enumerator<RCon.Command>.Dispose
	|
	|-RVA: 0x21EA00 Offset: 0x21DE00 VA: 0x18021EA00
	|-Queue.Enumerator<int>.Dispose
	|
	|-RVA: 0x21E990 Offset: 0x21DD90 VA: 0x18021E990
	|-Queue.Enumerator<IntPtr>.Dispose
	|-Queue.Enumerator<object>.Dispose
	|-Queue.Enumerator<string>.Dispose
	|-Queue.Enumerator<ulong>.Dispose
	|
	|-RVA: 0x21E940 Offset: 0x21DD40 VA: 0x18021E940
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.Dispose
	|-Queue.Enumerator<EventDispatcher.EventRecord>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21ED30 Offset: 0x21E130 VA: 0x18021ED30
	|-Queue.Enumerator<RCon.Command>.MoveNext
	|
	|-RVA: 0x21EC50 Offset: 0x21E050 VA: 0x18021EC50
	|-Queue.Enumerator<int>.MoveNext
	|
	|-RVA: 0x21EEF0 Offset: 0x21E2F0 VA: 0x18021EEF0
	|-Queue.Enumerator<IntPtr>.MoveNext
	|
	|-RVA: 0x21EA30 Offset: 0x21DE30 VA: 0x18021EA30
	|-Queue.Enumerator<object>.MoveNext
	|-Queue.Enumerator<string>.MoveNext
	|
	|-RVA: 0x21F030 Offset: 0x21E430 VA: 0x18021F030
	|-Queue.Enumerator<ulong>.MoveNext
	|
	|-RVA: 0x21EB60 Offset: 0x21DF60 VA: 0x18021EB60
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.MoveNext
	|
	|-RVA: 0x21F110 Offset: 0x21E510 VA: 0x18021F110
	|-Queue.Enumerator<EventDispatcher.EventRecord>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x220650 Offset: 0x21FA50 VA: 0x180220650
	|-Queue.Enumerator<string>.get_Current
	|-Queue.Enumerator<object>.get_Current
	|
	|-RVA: 0x220840 Offset: 0x21FC40 VA: 0x180220840
	|-Queue.Enumerator<RCon.Command>.get_Current
	|
	|-RVA: 0x2207A0 Offset: 0x21FBA0 VA: 0x1802207A0
	|-Queue.Enumerator<int>.get_Current
	|
	|-RVA: 0x2206E0 Offset: 0x21FAE0 VA: 0x1802206E0
	|-Queue.Enumerator<IntPtr>.get_Current
	|
	|-RVA: 0x220690 Offset: 0x21FA90 VA: 0x180220690
	|-Queue.Enumerator<ulong>.get_Current
	|
	|-RVA: 0x220720 Offset: 0x21FB20 VA: 0x180220720
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.get_Current
	|
	|-RVA: 0x220760 Offset: 0x21FB60 VA: 0x180220760
	|-Queue.Enumerator<EventDispatcher.EventRecord>.get_Current
	*/

	// RVA: -1 Offset: -1
	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x220330 Offset: 0x21F730 VA: 0x180220330
	|-Queue.Enumerator<RCon.Command>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x220300 Offset: 0x21F700 VA: 0x180220300
	|-Queue.Enumerator<int>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x220360 Offset: 0x21F760 VA: 0x180220360
	|-Queue.Enumerator<IntPtr>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x220320 Offset: 0x21F720 VA: 0x180220320
	|-Queue.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x220350 Offset: 0x21F750 VA: 0x180220350
	|-Queue.Enumerator<ulong>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x220340 Offset: 0x21F740 VA: 0x180220340
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.ThrowEnumerationNotStartedOrEnded
	|
	|-RVA: 0x220310 Offset: 0x21F710 VA: 0x180220310
	|-Queue.Enumerator<EventDispatcher.EventRecord>.ThrowEnumerationNotStartedOrEnded
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x220230 Offset: 0x21F630 VA: 0x180220230
	|-Queue.Enumerator<RCon.Command>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21FEF0 Offset: 0x21F2F0 VA: 0x18021FEF0
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2200C0 Offset: 0x21F4C0 VA: 0x1802200C0
	|-Queue.Enumerator<IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x220050 Offset: 0x21F450 VA: 0x180220050
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21FFA0 Offset: 0x21F3A0 VA: 0x18021FFA0
	|-Queue.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21FE40 Offset: 0x21F240 VA: 0x18021FE40
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x220180 Offset: 0x21F580 VA: 0x180220180
	|-Queue.Enumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21F7D0 Offset: 0x21EBD0 VA: 0x18021F7D0
	|-Queue.Enumerator<RCon.Command>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21F8E0 Offset: 0x21ECE0 VA: 0x18021F8E0
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21F860 Offset: 0x21EC60 VA: 0x18021F860
	|-Queue.Enumerator<IntPtr>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21F9E0 Offset: 0x21EDE0 VA: 0x18021F9E0
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21FBA0 Offset: 0x21EFA0 VA: 0x18021FBA0
	|-Queue.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21F960 Offset: 0x21ED60 VA: 0x18021F960
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21FAC0 Offset: 0x21EEC0 VA: 0x18021FAC0
	|-Queue.Enumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.Reset
	*/

}

public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection // TypeDefIndex: 3170
{
// Namespace: System.Net.Configuration
[ConfigurationCollectionAttribute] // RVA: 0xC0F60 Offset: 0xC0360 VA: 0x1800C0F60
[DefaultMemberAttribute] // RVA: 0xC0F60 Offset: 0xC0360 VA: 0x1800C0F60
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection // TypeDefIndex: 3170
	// Methods

	// RVA: 0x154D870 Offset: 0x154CC70 VA: 0x18154D870
	public void .ctor() { }

}

public sealed class ConnectionManagementSection : ConfigurationSection // TypeDefIndex: 3171
{	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x154D8A0 Offset: 0x154CCA0 VA: 0x18154D8A0
	public void .ctor() { }

	// RVA: 0x154D8D0 Offset: 0x154CCD0 VA: 0x18154D8D0 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

public sealed class ProxyElement : ConfigurationElement // TypeDefIndex: 3173
{	// Properties
	protected override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x1563A60 Offset: 0x1562E60 VA: 0x181563A60
	public void .ctor() { }

	// RVA: 0x1563A90 Offset: 0x1562E90 VA: 0x181563A90 Slot: 4
	protected override ConfigurationPropertyCollection get_Properties() { }

}

public sealed class NetSectionGroup : ConfigurationSectionGroup // TypeDefIndex: 3176
{	// Methods

	// RVA: 0x15638E0 Offset: 0x1562CE0 VA: 0x1815638E0
	public void .ctor() { }

}

public enum NetworkReachability // TypeDefIndex: 3358
{	// Fields
	public int value__; // 0x0
	public const NetworkReachability NotReachable = 0;
	public const NetworkReachability ReachableViaCarrierDataNetwork = 1;
	public const NetworkReachability ReachableViaLocalAreaNetwork = 2;

}

internal enum ConnectionChangeType // TypeDefIndex: 4143
{	// Fields
	public uint value__; // 0x0
	public const ConnectionChangeType Connected = 0;
	public const ConnectionChangeType Disconnected = 1;
	public const ConnectionChangeType ConfigChange = 2;

}

public enum ConnectionState // TypeDefIndex: 4173
{	// Fields
	public int value__; // 0x0
	public const ConnectionState Closed = 0;
	public const ConnectionState Open = 1;
	public const ConnectionState Connecting = 2;
	public const ConnectionState Executing = 4;
	public const ConnectionState Fetching = 8;
	public const ConnectionState Broken = 16;

}

public enum ConnectionState // TypeDefIndex: 5169
{	// Fields
	public int value__; // 0x0
	public const ConnectionState None = 0;
	public const ConnectionState Connecting = 1;
	public const ConnectionState FindingRoute = 2;
	public const ConnectionState Connected = 3;
	public const ConnectionState ClosedByPeer = 4;
	public const ConnectionState ProblemDetectedLocally = 5;
	public const ConnectionState FinWait = -1;
	public const ConnectionState Linger = -2;
	public const ConnectionState Dead = -3;

}

internal enum NetConfigScope // TypeDefIndex: 5170
{	// Fields
	public int value__; // 0x0
	public const NetConfigScope Global = 1;
	public const NetConfigScope SocketsInterface = 2;
	public const NetConfigScope ListenSocket = 3;
	public const NetConfigScope Connection = 4;

}

internal enum NetConfigType // TypeDefIndex: 5171
{	// Fields
	public int value__; // 0x0
	public const NetConfigType Int32 = 1;
	public const NetConfigType Int64 = 2;
	public const NetConfigType Float = 3;
	public const NetConfigType String = 4;
	public const NetConfigType Ptr = 5;

}

internal enum NetConfig // TypeDefIndex: 5172
{	// Fields
	public int value__; // 0x0
	public const NetConfig Invalid = 0;
	public const NetConfig TimeoutInitial = 24;
	public const NetConfig TimeoutConnected = 25;
	public const NetConfig SendBufferSize = 9;
	public const NetConfig ConnectionUserData = 40;
	public const NetConfig SendRateMin = 10;
	public const NetConfig SendRateMax = 11;
	public const NetConfig NagleTime = 12;
	public const NetConfig IP_AllowWithoutAuth = 23;
	public const NetConfig MTU_PacketSize = 32;
	public const NetConfig MTU_DataSize = 33;
	public const NetConfig Unencrypted = 34;
	public const NetConfig SymmetricConnect = 37;
	public const NetConfig LocalVirtualPort = 38;
	public const NetConfig DualWifi_Enable = 39;
	public const NetConfig EnableDiagnosticsUI = 46;
	public const NetConfig FakePacketLoss_Send = 2;
	public const NetConfig FakePacketLoss_Recv = 3;
	public const NetConfig FakePacketLag_Send = 4;
	public const NetConfig FakePacketLag_Recv = 5;
	public const NetConfig FakePacketReorder_Send = 6;
	public const NetConfig FakePacketReorder_Recv = 7;
	public const NetConfig FakePacketReorder_Time = 8;
	public const NetConfig FakePacketDup_Send = 26;
	public const NetConfig FakePacketDup_Recv = 27;
	public const NetConfig FakePacketDup_TimeMax = 28;
	public const NetConfig PacketTraceMaxBytes = 41;
	public const NetConfig FakeRateLimit_Send_Rate = 42;
	public const NetConfig FakeRateLimit_Send_Burst = 43;
	public const NetConfig FakeRateLimit_Recv_Rate = 44;
	public const NetConfig FakeRateLimit_Recv_Burst = 45;
	public const NetConfig Callback_ConnectionStatusChanged = 201;
	public const NetConfig Callback_AuthStatusChanged = 202;
	public const NetConfig Callback_RelayNetworkStatusChanged = 203;
	public const NetConfig Callback_MessagesSessionRequest = 204;
	public const NetConfig Callback_MessagesSessionFailed = 205;
	public const NetConfig Callback_CreateConnectionSignaling = 206;
	public const NetConfig Callback_FakeIPResult = 207;
	public const NetConfig P2P_STUN_ServerList = 103;
	public const NetConfig P2P_Transport_ICE_Enable = 104;
	public const NetConfig P2P_Transport_ICE_Penalty = 105;
	public const NetConfig P2P_Transport_SDR_Penalty = 106;
	public const NetConfig SDRClient_ConsecutitivePingTimeoutsFailInitial = 19;
	public const NetConfig SDRClient_ConsecutitivePingTimeoutsFail = 20;
	public const NetConfig SDRClient_MinPingsBeforePingAccurate = 21;
	public const NetConfig SDRClient_SingleSocket = 22;
	public const NetConfig SDRClient_ForceRelayCluster = 29;
	public const NetConfig SDRClient_DebugTicketAddress = 30;
	public const NetConfig SDRClient_ForceProxyAddr = 31;
	public const NetConfig SDRClient_FakeClusterPing = 36;
	public const NetConfig LogLevel_AckRTT = 13;
	public const NetConfig LogLevel_PacketDecode = 14;
	public const NetConfig LogLevel_Message = 15;
	public const NetConfig LogLevel_PacketGaps = 16;
	public const NetConfig LogLevel_P2PRendezvous = 17;
	public const NetConfig LogLevel_SDRRelayPings = 18;
	public const NetConfig DELETED_EnumerateDevVars = 35;

}

internal enum NetConfigResult // TypeDefIndex: 5173
{	// Fields
	public int value__; // 0x0
	public const NetConfigResult BadValue = -1;
	public const NetConfigResult BadScopeObj = -2;
	public const NetConfigResult BufferTooSmall = -3;
	public const NetConfigResult OK = 1;
	public const NetConfigResult OKInherited = 2;

}

public enum NetDebugOutput // TypeDefIndex: 5174
{	// Fields
	public int value__; // 0x0
	public const NetDebugOutput None = 0;
	public const NetDebugOutput Bug = 1;
	public const NetDebugOutput Error = 2;
	public const NetDebugOutput Important = 3;
	public const NetDebugOutput Warning = 4;
	public const NetDebugOutput Msg = 5;
	public const NetDebugOutput Verbose = 6;
	public const NetDebugOutput Debug = 7;
	public const NetDebugOutput Everything = 8;

}

public class ConnectionManager // TypeDefIndex: 5178
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IConnectionManager <Interface>k__BackingField; // 0x10
	public Connection Connection; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ConnectionInfo <ConnectionInfo>k__BackingField; // 0x20
	public bool Connected; // 0x2D8
	public bool Connecting; // 0x2D9

	// Properties
	public IConnectionManager Interface { get; set; }
	internal ConnectionInfo ConnectionInfo { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public IConnectionManager get_Interface() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_Interface(IConnectionManager value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1369820 Offset: 0x1368C20 VA: 0x181369820
	internal void set_ConnectionInfo(ConnectionInfo value) { }

	// RVA: 0x1368E80 Offset: 0x1368280 VA: 0x181368E80
	public void Close(bool linger = False, int reasonCode = 0, string debugString = "Closing Connection") { }

	// RVA: 0x13697F0 Offset: 0x1368BF0 VA: 0x1813697F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1369080 Offset: 0x1368480 VA: 0x181369080 Slot: 4
	public virtual void OnConnectionChanged(ConnectionInfo info) { }

	// RVA: 0x1368F90 Offset: 0x1368390 VA: 0x181368F90 Slot: 5
	public virtual void OnConnecting(ConnectionInfo info) { }

	// RVA: 0x1368EA0 Offset: 0x13682A0 VA: 0x181368EA0 Slot: 6
	public virtual void OnConnected(ConnectionInfo info) { }

	// RVA: 0x1369370 Offset: 0x1368770 VA: 0x181369370 Slot: 7
	public virtual void OnDisconnected(ConnectionInfo info) { }

	// RVA: 0x1369620 Offset: 0x1368A20 VA: 0x181369620
	public int Receive(int bufferSize = 32, bool receiveToEnd = True) { }

	// RVA: 0x1369550 Offset: 0x1368950 VA: 0x181369550
	internal void ReceiveMessage(ref NetMsg* msg) { }

	// RVA: 0x1369460 Offset: 0x1368860 VA: 0x181369460 Slot: 8
	public virtual void OnMessage(IntPtr data, int size, long messageNum, long recvTime, int channel) { }

	// RVA: 0x1369810 Offset: 0x1368C10 VA: 0x181369810
	public void .ctor() { }

}

internal sealed class NetDebugFunc : MulticastDelegate // TypeDefIndex: 5179
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xDDD820 Offset: 0xDDCC20 VA: 0x180DDD820 Slot: 12
	public virtual void Invoke([In] NetDebugOutput nType, [In] IntPtr pszMsg) { }

	// RVA: 0xDDD790 Offset: 0xDDCB90 VA: 0x180DDD790 Slot: 13
	public virtual IAsyncResult BeginInvoke([In] NetDebugOutput nType, [In] IntPtr pszMsg, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal struct NetKeyValue // TypeDefIndex: 5507
{	// Fields
	internal NetConfig Value; // 0x0
	internal NetConfigType DataType; // 0x4
	internal long Int64Value; // 0x8
	internal int Int32Value; // 0x8
	internal float FloatValue; // 0x8
	internal IntPtr PointerValue; // 0x8

}

public struct NetIdentity // TypeDefIndex: 5508
{	// Fields
	internal NetIdentity.IdentityType type; // 0x0
	internal int size; // 0x4
	internal ulong steamid; // 0x8
	internal NetAddress netaddress; // 0x8

	// Methods

	// RVA: 0x1EBE50 Offset: 0x1EB250 VA: 0x1801EBE50 Slot: 3
	public override string ToString() { }

}

internal enum NetIdentity.IdentityType // TypeDefIndex: 5509
{	// Fields
	public int value__; // 0x0
	public const NetIdentity.IdentityType Invalid = 0;
	public const NetIdentity.IdentityType IPAddress = 1;
	public const NetIdentity.IdentityType GenericString = 2;
	public const NetIdentity.IdentityType GenericBytes = 3;
	public const NetIdentity.IdentityType SteamID = 16;

}

public struct NetAddress // TypeDefIndex: 5510
{	// Fields
	internal NetAddress.IPV4 ip; // 0x0
	internal ushort port; // 0x10

	// Properties
	public static NetAddress Cleared { get; }

	// Methods

	// RVA: 0x136F730 Offset: 0x136EB30 VA: 0x18136F730
	internal static extern void InternalClear(ref NetAddress self) { }

	// RVA: 0x136F7B0 Offset: 0x136EBB0 VA: 0x18136F7B0
	internal static extern void InternalSetIPv4(ref NetAddress self, uint nIP, ushort nPort) { }

	// RVA: 0x136F850 Offset: 0x136EC50 VA: 0x18136F850
	internal static extern void InternalToString(ref NetAddress self, IntPtr buf, uint cbBuf, bool bWithPort) { }

	// RVA: 0x136F280 Offset: 0x136E680 VA: 0x18136F280
	public static NetAddress AnyIp(ushort port) { }

	// RVA: 0x136F330 Offset: 0x136E730 VA: 0x18136F330
	public static NetAddress From(string addrStr, ushort port) { }

	// RVA: 0x136F550 Offset: 0x136E950 VA: 0x18136F550
	public static NetAddress From(IPAddress address, ushort port) { }

	// RVA: 0x136FAE0 Offset: 0x136EEE0 VA: 0x18136FAE0
	public static NetAddress get_Cleared() { }

	// RVA: 0x1EBE40 Offset: 0x1EB240 VA: 0x1801EBE40 Slot: 3
	public override string ToString() { }

}

internal struct NetAddress.IPV4 // TypeDefIndex: 5511
{	// Fields
	internal ulong m_8zeros; // 0x0
	internal ushort m_0000; // 0x8
	internal ushort m_ffff; // 0xA
	internal byte ip0; // 0xC
	internal byte ip1; // 0xD
	internal byte ip2; // 0xE
	internal byte ip3; // 0xF

}

internal struct NetMsg // TypeDefIndex: 5512
{	// Fields
	internal IntPtr DataPtr; // 0x0
	internal int DataSize; // 0x8
	internal Connection Connection; // 0xC
	internal NetIdentity Identity; // 0x10
	internal long ConnectionUserData; // 0x98
	internal long RecvTime; // 0xA0
	internal long MessageNumber; // 0xA8
	internal IntPtr FreeDataPtr; // 0xB0
	internal IntPtr ReleasePtr; // 0xB8
	internal int Channel; // 0xC0
	internal SendType Flags; // 0xC4
	internal long UserData; // 0xC8
	internal ushort IdxLane; // 0xD0
	internal ushort _pad1__; // 0xD2

	// Methods

	// RVA: 0x136FB70 Offset: 0x136EF70 VA: 0x18136FB70
	internal static extern void InternalRelease(NetMsg* self) { }

}

public struct Connection : IEquatable<Connection> // TypeDefIndex: 5543
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <Id>k__BackingField; // 0x0

	// Properties
	public uint Id { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public uint get_Id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3A80 Offset: 0xF2E80 VA: 0x1800F3A80
	public void set_Id(uint value) { }

	// RVA: 0x1E4EF0 Offset: 0x1E42F0 VA: 0x1801E4EF0 Slot: 4
	public bool Equals(Connection other) { }

	// RVA: 0x1E4F00 Offset: 0x1E4300 VA: 0x1801E4F00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E4F80 Offset: 0x1E4380 VA: 0x1801E4F80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D2FD0 Offset: 0x1D23D0 VA: 0x1801D2FD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x6BFDB0 Offset: 0x6BF1B0 VA: 0x1806BFDB0
	public static Connection op_Implicit(uint value) { }

	// RVA: 0x6BFDB0 Offset: 0x6BF1B0 VA: 0x1806BFDB0
	public static uint op_Implicit(Connection value) { }

	// RVA: 0x1E4D40 Offset: 0x1E4140 VA: 0x1801E4D40
	public Result Accept() { }

	// RVA: 0x1E4DB0 Offset: 0x1E41B0 VA: 0x1801E4DB0
	public bool Close(bool linger = False, int reasonCode = 0, string debugString = "Closing Connection") { }

	// RVA: 0x1E5040 Offset: 0x1E4440 VA: 0x1801E5040
	public Result SendMessage(IntPtr ptr, int size, SendType sendType = 8, ushort laneIndex = 0) { }

	// RVA: 0x1E4E60 Offset: 0x1E4260 VA: 0x1801E4E60
	public string DetailedStatus() { }

	// RVA: 0x1E4FA0 Offset: 0x1E43A0 VA: 0x1801E4FA0
	public ConnectionStatus QuickStatus() { }

	// RVA: 0x1E4DC0 Offset: 0x1E41C0 VA: 0x1801E4DC0
	public Result ConfigureConnectionLanes(int[] lanePriorities, ushort[] laneWeights) { }

}

public struct ConnectionInfo // TypeDefIndex: 5544
{	// Fields
	internal NetIdentity identity; // 0x0
	internal long userData; // 0x88
	internal Socket listenSocket; // 0x90
	internal NetAddress address; // 0x94
	internal ushort pad; // 0xA6
	internal SteamNetworkingPOPID popRemote; // 0xA8
	internal SteamNetworkingPOPID popRelay; // 0xAC
	internal ConnectionState state; // 0xB0
	internal int endReason; // 0xB4
	internal string endDebug; // 0xB8
	internal string connectionDescription; // 0xC0

	// Properties
	public ConnectionState State { get; }
	public NetAddress Address { get; }

	// Methods

	// RVA: 0xFD260 Offset: 0xFC660 VA: 0x1800FD260
	public ConnectionState get_State() { }

	// RVA: 0x1E4660 Offset: 0x1E3A60 VA: 0x1801E4660
	public NetAddress get_Address() { }

}

public struct ConnectionLaneStatus // TypeDefIndex: 5545
{	// Fields
	internal int cbPendingUnreliable; // 0x0
	internal int cbPendingReliable; // 0x4
	internal int cbSentUnackedReliable; // 0x8
	internal int _reservePad1; // 0xC
	internal long ecQueueTime; // 0x10
	internal uint[] reserved; // 0x18

}

public struct ConnectionStatus // TypeDefIndex: 5546
{	// Fields
	internal ConnectionState state; // 0x0
	internal int ping; // 0x4
	internal float connectionQualityLocal; // 0x8
	internal float connectionQualityRemote; // 0xC
	internal float outPacketsPerSec; // 0x10
	internal float outBytesPerSec; // 0x14
	internal float inPacketsPerSec; // 0x18
	internal float inBytesPerSec; // 0x1C
	internal int sendRateBytesPerSecond; // 0x20
	internal int cbPendingUnreliable; // 0x24
	internal int cbPendingReliable; // 0x28
	internal int cbSentUnackedReliable; // 0x2C
	internal long ecQueueTime; // 0x30
	internal uint[] reserved; // 0x38

	// Properties
	public int Ping { get; }
	public float OutBytesPerSec { get; }
	public float InBytesPerSec { get; }
	public float ConnectionQualityLocal { get; }
	public int PendingUnreliable { get; }
	public int PendingReliable { get; }

	// Methods

	// RVA: 0x14B670 Offset: 0x14AA70 VA: 0x18014B670
	public int get_Ping() { }

	// RVA: 0x1E4AA0 Offset: 0x1E3EA0 VA: 0x1801E4AA0
	public float get_OutBytesPerSec() { }

	// RVA: 0x1E4A90 Offset: 0x1E3E90 VA: 0x1801E4A90
	public float get_InBytesPerSec() { }

	// RVA: 0x116F40 Offset: 0x116340 VA: 0x180116F40
	public float get_ConnectionQualityLocal() { }

	// RVA: 0x1E4AB0 Offset: 0x1E3EB0 VA: 0x1801E4AB0
	public int get_PendingUnreliable() { }

	// RVA: 0xF3DC0 Offset: 0xF31C0 VA: 0x1800F3DC0
	public int get_PendingReliable() { }

}

public class Connection // TypeDefIndex: 6682
{	// Fields
	private static MemoryStream reusableStream; // 0x0
	protected MemoryStream recordStream; // 0x10
	protected BinaryWriter recordWriter; // 0x18
	protected Stopwatch recordTime; // 0x20
	protected string recordFilename; // 0x28
	protected IDemoHeader recordHeader; // 0x30
	public Connection.State state; // 0x38
	public bool active; // 0x3C
	public bool connected; // 0x3D
	public uint authLevel; // 0x40
	public uint encryptionLevel; // 0x44
	public bool decryptIncoming; // 0x48
	public bool encryptOutgoing; // 0x49
	public bool trusted; // 0x4A
	public bool rejected; // 0x4B
	public string authStatus; // 0x50
	public byte[] token; // 0x58
	public bool hasRequestedWorld; // 0x60
	public ulong guid; // 0x68
	public ulong userid; // 0x70
	public ulong ownerid; // 0x78
	public string username; // 0x80
	public string os; // 0x88
	public uint protocol; // 0x90
	private TimeAverageValueData[] packetsPerSecond; // 0x98
	public double connectionTime; // 0xA0
	public string ipaddress; // 0xA8
	public MonoBehaviour player; // 0xB0
	public Connection.Validation validate; // 0xB8
	public Connection.ClientInfo info; // 0xC0

	// Properties
	public TimeSpan RecordTimeElapsed { get; }
	public string RecordFilename { get; }
	public int RecordFilesize { get; }
	public bool IsRecording { get; }
	public bool isAuthenticated { get; }

	// Methods

	// RVA: 0x22091D0 Offset: 0x22085D0 VA: 0x1822091D0
	public TimeSpan get_RecordTimeElapsed() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_RecordFilename() { }

	// RVA: 0xBC4350 Offset: 0xBC3750 VA: 0x180BC4350
	public int get_RecordFilesize() { }

	// RVA: 0x2208AC0 Offset: 0x2207EC0 VA: 0x182208AC0
	public bool StartRecording(string targetFilename, IDemoHeader header) { }

	// RVA: 0x2208BD0 Offset: 0x2207FD0 VA: 0x182208BD0
	public void StopRecording() { }

	// RVA: 0x793940 Offset: 0x792D40 VA: 0x180793940
	public bool get_IsRecording() { }

	// RVA: 0x22085C0 Offset: 0x22079C0 VA: 0x1822085C0
	public void RecordPacket(byte packetId, IProto proto) { }

	// RVA: 0x2208840 Offset: 0x2207C40 VA: 0x182208840
	public void RecordPacket(Stream stream) { }

	// RVA: 0x2208520 Offset: 0x2207920 VA: 0x182208520 Slot: 4
	public virtual void OnDisconnected() { }

	// RVA: 0x2209250 Offset: 0x2208650 VA: 0x182209250
	public bool get_isAuthenticated() { }

	// RVA: 0x2208A40 Offset: 0x2207E40 VA: 0x182208A40
	public void ResetPacketsPerSecond() { }

	// RVA: 0x22083B0 Offset: 0x22077B0 VA: 0x1822083B0
	public void AddPacketsPerSecond(Message.Type message) { }

	// RVA: 0x2208360 Offset: 0x2207760 VA: 0x182208360
	public void AddPacketsPerSecond(int index = 0) { }

	// RVA: 0x2208460 Offset: 0x2207860 VA: 0x182208460
	public ulong GetPacketsPerSecond(Message.Type message) { }

	// RVA: 0x2208400 Offset: 0x2207800 VA: 0x182208400
	public ulong GetPacketsPerSecond(int index = 0) { }

	// RVA: 0x22084C0 Offset: 0x22078C0 VA: 0x1822084C0
	public float GetSecondsConnected() { }

	// RVA: 0x2208F90 Offset: 0x2208390 VA: 0x182208F90 Slot: 3
	public override string ToString() { }

	// RVA: 0x2209070 Offset: 0x2208470 VA: 0x182209070
	public void .ctor() { }

	// RVA: 0x2209010 Offset: 0x2208410 VA: 0x182209010
	private static void .cctor() { }

}

public enum Connection.State // TypeDefIndex: 6683
{	// Fields
	public int value__; // 0x0
	public const Connection.State Unconnected = 0;
	public const Connection.State Connecting = 1;
	public const Connection.State InQueue = 2;
	public const Connection.State Welcoming = 3;
	public const Connection.State Connected = 4;
	public const Connection.State Disconnected = 5;

}

public struct Connection.Validation // TypeDefIndex: 6684
{	// Fields
	public uint entityUpdates; // 0x0

}

public class Connection.ClientInfo // TypeDefIndex: 6685
{	// Fields
	public Dictionary<string, string> info; // 0x10

	// Methods

	// RVA: 0x2207BC0 Offset: 0x2206FC0 VA: 0x182207BC0
	public void Set(string k, string v) { }

	// RVA: 0x2207B40 Offset: 0x2206F40 VA: 0x182207B40
	public string GetString(string k, string def = "") { }

	// RVA: 0x22079E0 Offset: 0x2206DE0 VA: 0x1822079E0
	public float GetFloat(string k, float def = 0) { }

	// RVA: 0x2207A90 Offset: 0x2206E90 VA: 0x182207A90
	public int GetInt(string k, int def = 0) { }

	// RVA: 0x22078E0 Offset: 0x2206CE0 VA: 0x1822078E0
	public bool GetBool(string k, bool def = False) { }

	// RVA: 0x2207C30 Offset: 0x2207030 VA: 0x182207C30
	public void .ctor() { }

}

public class NetRead : Stream // TypeDefIndex: 6695
{	// Fields
	private MemoryStream _stream; // 0x28
	public byte[] Data; // 0x30
	public long _length; // 0x38
	public long _position; // 0x40
	private const int bufferSize = 1048576;
	private static byte[] byteBuffer; // 0x0
	private static char[] charBuffer; // 0x8

	// Properties
	public int Unread { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanSeek { get; }

	// Methods

	// RVA: 0x220AB60 Offset: 0x2209F60 VA: 0x18220AB60
	public MemoryStream GetStreamForDecryption() { }

	// RVA: 0x220AFF0 Offset: 0x220A3F0 VA: 0x18220AFF0
	public bool Start(IntPtr data, int length) { }

	// RVA: 0x220B900 Offset: 0x220AD00 VA: 0x18220B900
	public int get_Unread() { }

	// RVA: 0x220B500 Offset: 0x220A900 VA: 0x18220B500
	public string String(int maxLength = 256) { }

	// RVA: 0x220B3F0 Offset: 0x220A7F0 VA: 0x18220B3F0
	public string StringMultiLine(int maxLength = 2048) { }

	// RVA: 0x220B160 Offset: 0x220A560 VA: 0x18220B160
	private string StringInternal(int maxLength, bool allowNewLine) { }

	// RVA: 0x220B400 Offset: 0x220A800 VA: 0x18220B400
	public string StringRaw(uint maxLength = 1048576) { }

	// RVA: 0x220B510 Offset: 0x220A910 VA: 0x18220B510
	public bool TemporaryBytesWithSize(out byte[] buffer, out int size) { }

	// RVA: 0x220AA90 Offset: 0x2209E90 VA: 0x18220AA90
	public uint EntityID() { }

	// RVA: 0x220AA90 Offset: 0x2209E90 VA: 0x18220AA90
	public uint GroupID() { }

	// RVA: 0x220A930 Offset: 0x2209D30 VA: 0x18220A930
	public int BytesWithSize(byte[] buffer, uint maxLength = 4294967295) { }

	// RVA: 0x220A860 Offset: 0x2209C60 VA: 0x18220A860
	public byte[] BytesWithSize(uint maxSize = 10485760) { }

	// RVA: 0x220AE40 Offset: 0x220A240 VA: 0x18220AE40 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xC107D0 Offset: 0xC0FBD0 VA: 0x180C107D0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x220AD40 Offset: 0x220A140 VA: 0x18220AD40
	public byte PacketID() { }

	// RVA: 0x220A820 Offset: 0x2209C20 VA: 0x18220A820
	public bool Bit() { }

	// RVA: 0x220AD40 Offset: 0x220A140 VA: 0x18220AD40
	public byte UInt8() { }

	// RVA: 0x220B680 Offset: 0x220AA80 VA: 0x18220B680
	public ushort UInt16() { }

	// RVA: 0x220AA90 Offset: 0x2209E90 VA: 0x18220AA90
	public uint UInt32() { }

	// RVA: 0x220B6C0 Offset: 0x220AAC0 VA: 0x18220B6C0
	public ulong UInt64() { }

	// RVA: 0x220AD00 Offset: 0x220A100 VA: 0x18220AD00
	public sbyte Int8() { }

	// RVA: 0x220AC40 Offset: 0x220A040 VA: 0x18220AC40
	public short Int16() { }

	// RVA: 0x220AC80 Offset: 0x220A080 VA: 0x18220AC80
	public int Int32() { }

	// RVA: 0x220ACC0 Offset: 0x220A0C0 VA: 0x18220ACC0
	public long Int64() { }

	// RVA: 0x220AAD0 Offset: 0x2209ED0 VA: 0x18220AAD0
	public float Float() { }

	// RVA: 0x220AA50 Offset: 0x2209E50 VA: 0x18220AA50
	public double Double() { }

	// RVA: 0x220B700 Offset: 0x220AB00 VA: 0x18220B700
	public Vector3 Vector3() { }

	// RVA: 0x220AD80 Offset: 0x220A180 VA: 0x18220AD80
	public Quaternion Quaternion() { }

	// RVA: 0x220ADE0 Offset: 0x220A1E0 VA: 0x18220ADE0
	public Ray Ray() { }

	// RVA: 0x220A9F0 Offset: 0x2209DF0 VA: 0x18220A9F0
	public Color Color() { }

	// RVA: 0x220AEE0 Offset: 0x220A2E0 VA: 0x18220AEE0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 10
	public override long get_Length() { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440 Slot: 11
	public override long get_Position() { }

	// RVA: 0x21BBA00 Offset: 0x21BAE00 VA: 0x1821BBA00 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x220AF70 Offset: 0x220A370 VA: 0x18220AF70 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: -1 Offset: -1
	public T Read<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EC140 Offset: 0x5EB540 VA: 0x1805EC140
	|-NetRead.Read<byte>
	|-NetRead.Read<sbyte>
	|
	|-RVA: 0x5EC210 Offset: 0x5EB610 VA: 0x1805EC210
	|-NetRead.Read<double>
	|
	|-RVA: 0x5EC270 Offset: 0x5EB670 VA: 0x1805EC270
	|-NetRead.Read<short>
	|-NetRead.Read<ushort>
	|
	|-RVA: 0x5EC2D0 Offset: 0x5EB6D0 VA: 0x1805EC2D0
	|-NetRead.Read<int>
	|-NetRead.Read<uint>
	|
	|-RVA: 0x5EC330 Offset: 0x5EB730 VA: 0x1805EC330
	|-NetRead.Read<long>
	|-NetRead.Read<ulong>
	|
	|-RVA: 0x5EC420 Offset: 0x5EB820 VA: 0x1805EC420
	|-NetRead.Read<float>
	|
	|-RVA: 0x5EC1A0 Offset: 0x5EB5A0 VA: 0x1805EC1A0
	|-NetRead.Read<Color>
	|-NetRead.Read<Quaternion>
	|
	|-RVA: 0x5EC390 Offset: 0x5EB790 VA: 0x1805EC390
	|-NetRead.Read<Ray>
	|
	|-RVA: 0x5EC480 Offset: 0x5EB880 VA: 0x1805EC480
	|-NetRead.Read<Vector3>
	*/

	// RVA: 0x220AB10 Offset: 0x2209F10 VA: 0x18220AB10 Slot: 18
	public override void Flush() { }

	// RVA: 0x220B7B0 Offset: 0x220ABB0 VA: 0x18220B7B0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x220B760 Offset: 0x220AB60 VA: 0x18220B760 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x220B880 Offset: 0x220AC80 VA: 0x18220B880
	public void .ctor() { }

	// RVA: 0x220B800 Offset: 0x220AC00 VA: 0x18220B800
	private static void .cctor() { }

}

public class NetWrite : MemoryStream // TypeDefIndex: 6696
{	// Fields
	private static MemoryStream buffer; // 0x0
	private BaseNetwork netwrite; // 0x50
	private byte[] data; // 0x58
	private int position; // 0x60
	private int length; // 0x64

	// Properties
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x220CB90 Offset: 0x220BF90 VA: 0x18220CB90
	public void .ctor(BaseNetwork netwrite) { }

	// RVA: 0x220C530 Offset: 0x220B930 VA: 0x18220C530
	public void Shutdown() { }

	// RVA: 0x220C5B0 Offset: 0x220B9B0 VA: 0x18220C5B0
	public bool Start() { }

	// RVA: 0x220C490 Offset: 0x220B890 VA: 0x18220C490
	public void Send(SendInfo info) { }

	// RVA: 0x220C1E0 Offset: 0x220B5E0 VA: 0x18220C1E0
	public void PacketID(Message.Type val) { }

	// RVA: 0x220C950 Offset: 0x220BD50 VA: 0x18220C950
	public void UInt8(byte val) { }

	// RVA: 0x220C860 Offset: 0x220BC60 VA: 0x18220C860
	public void UInt16(ushort val) { }

	// RVA: 0x220C8B0 Offset: 0x220BCB0 VA: 0x18220C8B0
	public void UInt32(uint val) { }

	// RVA: 0x220C900 Offset: 0x220BD00 VA: 0x18220C900
	public void UInt64(ulong val) { }

	// RVA: 0x220C190 Offset: 0x220B590 VA: 0x18220C190
	public void Int8(sbyte val) { }

	// RVA: 0x220C0A0 Offset: 0x220B4A0 VA: 0x18220C0A0
	public void Int16(short val) { }

	// RVA: 0x220C0F0 Offset: 0x220B4F0 VA: 0x18220C0F0
	public void Int32(int val) { }

	// RVA: 0x220C140 Offset: 0x220B540 VA: 0x18220C140
	public void Int64(long val) { }

	// RVA: 0x220B950 Offset: 0x220AD50 VA: 0x18220B950
	public void Bool(bool val) { }

	// RVA: 0x220C050 Offset: 0x220B450 VA: 0x18220C050
	public void Float(float val) { }

	// RVA: 0x220BD30 Offset: 0x220B130 VA: 0x18220BD30
	public void Double(double val) { }

	// RVA: 0x220BBE0 Offset: 0x220AFE0 VA: 0x18220BBE0
	public void Bytes(byte[] val) { }

	// RVA: 0x220C5C0 Offset: 0x220B9C0 VA: 0x18220C5C0
	public void String(string val) { }

	// RVA: 0x220C9A0 Offset: 0x220BDA0 VA: 0x18220C9A0
	public void Vector3(in Vector3 obj) { }

	// RVA: 0x220BC20 Offset: 0x220B020 VA: 0x18220BC20
	public void Quaternion(in Quaternion obj) { }

	// RVA: 0x220C230 Offset: 0x220B630 VA: 0x18220C230
	public void Ray(in Ray obj) { }

	// RVA: 0x220BC20 Offset: 0x220B020 VA: 0x18220BC20
	public void Color(in Color obj) { }

	// RVA: 0x220C000 Offset: 0x220B400 VA: 0x18220C000
	public void EntityID(uint id) { }

	// RVA: 0x220C000 Offset: 0x220B400 VA: 0x18220C000
	public void GroupID(uint id) { }

	// RVA: 0x220B9B0 Offset: 0x220ADB0 VA: 0x18220B9B0
	public void BytesWithSize(MemoryStream val) { }

	// RVA: 0x220BA70 Offset: 0x220AE70 VA: 0x18220BA70
	public void BytesWithSize(byte[] b) { }

	// RVA: 0x220BA90 Offset: 0x220AE90 VA: 0x18220BA90
	public void BytesWithSize(byte[] b, int length) { }

	// RVA: -1 Offset: -1
	private void Write<T>(in T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15428E0 Offset: 0x1541CE0 VA: 0x1815428E0
	|-NetWrite.Write<byte>
	|-NetWrite.Write<sbyte>
	|
	|-RVA: 0x1542950 Offset: 0x1541D50 VA: 0x181542950
	|-NetWrite.Write<double>
	|-NetWrite.Write<long>
	|-NetWrite.Write<ulong>
	|
	|-RVA: 0x15429C0 Offset: 0x1541DC0 VA: 0x1815429C0
	|-NetWrite.Write<short>
	|-NetWrite.Write<ushort>
	|
	|-RVA: 0x1542A30 Offset: 0x1541E30 VA: 0x181542A30
	|-NetWrite.Write<int>
	|-NetWrite.Write<float>
	|-NetWrite.Write<uint>
	*/

	// RVA: 0x220BD80 Offset: 0x220B180 VA: 0x18220BD80
	private void EnsureCapacity(int spaceRequired) { }

	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340 Slot: 31
	public override byte[] GetBuffer() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0x220CC80 Offset: 0x220C080 VA: 0x18220CC80 Slot: 10
	public override long get_Length() { }

	// RVA: 0x220CC90 Offset: 0x220C090 VA: 0x18220CC90 Slot: 11
	public override long get_Position() { }

	// RVA: 0x220CCA0 Offset: 0x220C0A0 VA: 0x18220CCA0 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 18
	public override void Flush() { }

	// RVA: 0x220C330 Offset: 0x220B730 VA: 0x18220C330 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x220C2E0 Offset: 0x220B6E0 VA: 0x18220C2E0 Slot: 28
	public override int ReadByte() { }

	// RVA: 0x220CAC0 Offset: 0x220BEC0 VA: 0x18220CAC0 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x220CA70 Offset: 0x220BE70 VA: 0x18220CA70 Slot: 30
	public override void WriteByte(byte value) { }

	// RVA: 0x220C3F0 Offset: 0x220B7F0 VA: 0x18220C3F0 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x220C4E0 Offset: 0x220B8E0 VA: 0x18220C4E0 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x220CB30 Offset: 0x220BF30 VA: 0x18220CB30
	private static void .cctor() { }

}

public class Networkable : Pool.IPooled // TypeDefIndex: 6700
{	// Fields
	public uint ID; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Connection <connection>k__BackingField; // 0x18
	public Group group; // 0x20
	public Group secondaryGroup; // 0x28
	public Subscriber subscriber; // 0x30
	public NetworkHandler handler; // 0x38
	private bool updateSubscriptions; // 0x40
	internal Server sv; // 0x48
	internal Client cl; // 0x50

	// Properties
	public Connection connection { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Connection get_connection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_connection(Connection value) { }

	// RVA: 0x220CEF0 Offset: 0x220C2F0 VA: 0x18220CEF0
	public void Destroy() { }

	// RVA: 0x220CF20 Offset: 0x220C320 VA: 0x18220CF20 Slot: 4
	public void EnterPool() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public void LeavePool() { }

	// RVA: 0x220D240 Offset: 0x220C640 VA: 0x18220D240
	public void StartSubscriber() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void OnConnected(Connection c) { }

	// RVA: 0x220CFA0 Offset: 0x220C3A0 VA: 0x18220CFA0
	public void OnDisconnected() { }

	// RVA: 0x220CE60 Offset: 0x220C260 VA: 0x18220CE60
	public void CloseSubscriber() { }

	// RVA: 0x220DC00 Offset: 0x220D000 VA: 0x18220DC00
	public bool UpdateGroups(Vector3 position) { }

	// RVA: 0x220D380 Offset: 0x220C780 VA: 0x18220D380
	public bool SwitchGroup(Group newGroup) { }

	// RVA: 0x220CFD0 Offset: 0x220C3D0 VA: 0x18220CFD0
	internal void OnGroupTransition(Group oldGroup) { }

	// RVA: 0x220D160 Offset: 0x220C560 VA: 0x18220D160
	internal void OnSubscriptionChange() { }

	// RVA: 0x220DA90 Offset: 0x220CE90 VA: 0x18220DA90
	public bool SwitchSecondaryGroup(Group newGroup) { }

	// RVA: 0x220CCC0 Offset: 0x220C0C0 VA: 0x18220CCC0
	private void AddVisibleFromNear(Group additionalGroup, List<Group> groupsVisible) { }

	// RVA: 0x220E040 Offset: 0x220D440 VA: 0x18220E040
	public bool UpdateSubscriptions(int removeLimit, int addLimit) { }

	// RVA: 0x220DDA0 Offset: 0x220D1A0 VA: 0x18220DDA0
	public bool UpdateHighPrioritySubscriptions() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class QueuedStream : Stream // TypeDefIndex: 6916
{	// Fields
	private readonly Stream _stream; // 0x28
	private readonly Queue<QueuedStream.WriteData> _queue; // 0x30
	private int _pendingWrite; // 0x38
	private bool _disposed; // 0x3C

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x22028D0 Offset: 0x2201CD0 VA: 0x1822028D0
	public void .ctor(Stream stream) { }

	// RVA: 0xBA0070 Offset: 0xB9F470 VA: 0x180BA0070 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0xBA00A0 Offset: 0xB9F4A0 VA: 0x180BA00A0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0xBA00D0 Offset: 0xB9F4D0 VA: 0x180BA00D0 Slot: 9
	public override bool get_CanWrite() { }

	// RVA: 0xBA0100 Offset: 0xB9F500 VA: 0x180BA0100 Slot: 10
	public override long get_Length() { }

	// RVA: 0xBA0130 Offset: 0xB9F530 VA: 0x180BA0130 Slot: 11
	public override long get_Position() { }

	// RVA: 0xBA0160 Offset: 0xB9F560 VA: 0x180BA0160 Slot: 12
	public override void set_Position(long value) { }

	// RVA: 0xB9FED0 Offset: 0xB9F2D0 VA: 0x180B9FED0 Slot: 27
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0xB9FF00 Offset: 0xB9F300 VA: 0x180B9FF00 Slot: 25
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xB9FF30 Offset: 0xB9F330 VA: 0x180B9FF30 Slot: 26
	public override void SetLength(long value) { }

	// RVA: 0x2202870 Offset: 0x2201C70 VA: 0x182202870 Slot: 29
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0xB9FBC0 Offset: 0xB9EFC0 VA: 0x180B9FBC0 Slot: 19
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x22024B0 Offset: 0x22018B0 VA: 0x1822024B0 Slot: 22
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0xB9FD60 Offset: 0xB9F160 VA: 0x180B9FD60 Slot: 20
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x2202730 Offset: 0x2201B30 VA: 0x182202730 Slot: 23
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0xB9FE70 Offset: 0xB9F270 VA: 0x180B9FE70 Slot: 18
	public override void Flush() { }

	// RVA: 0x162FBC0 Offset: 0x162EFC0 VA: 0x18162FBC0 Slot: 16
	public override void Close() { }

	// RVA: 0x22026E0 Offset: 0x2201AE0 VA: 0x1822026E0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2202350 Offset: 0x2201750 VA: 0x182202350
	private IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, QueuedStream.WriteData queued) { }

}

private class QueuedStream.WriteData // TypeDefIndex: 6917
{	// Fields
	public readonly byte[] Buffer; // 0x10
	public readonly int Offset; // 0x18
	public readonly int Count; // 0x1C
	public readonly AsyncCallback Callback; // 0x20
	public readonly object State; // 0x28
	public readonly QueuedStream.QueuedWriteResult AsyncResult; // 0x30

	// Methods

	// RVA: 0x2207220 Offset: 0x2206620 VA: 0x182207220
	public void .ctor(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

}

private class QueuedStream.QueuedWriteResult : IAsyncResult // TypeDefIndex: 6918
{	// Fields
	private readonly object _state; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Exception <Exception>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IAsyncResult <ActualResult>k__BackingField; // 0x20

	// Properties
	public Exception Exception { get; set; }
	public IAsyncResult ActualResult { get; set; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(object state) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Exception get_Exception() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Exception(Exception value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public IAsyncResult get_ActualResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_ActualResult(IAsyncResult value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x2202980 Offset: 0x2201D80 VA: 0x182202980 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x22029E0 Offset: 0x2201DE0 VA: 0x1822029E0 Slot: 4
	public bool get_IsCompleted() { }

}

private sealed class QueuedStream.<>c__DisplayClass27_0 // TypeDefIndex: 6919
{	// Fields
	public QueuedStream.WriteData queued; // 0x10
	public QueuedStream <>4__this; // 0x18
	public AsyncCallback callback; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x2203FE0 Offset: 0x22033E0 VA: 0x182203FE0
	internal void <BeginWriteInternal>b__0(IAsyncResult ar) { }

}

public class NetGraph : SingletonComponent<NetGraph> // TypeDefIndex: 7075
{	// Fields
	public CanvasGroup group; // 0x18
	public GameObject rootPanel; // 0x20
	private NetGraphRow[] rows; // 0x28

	// Properties
	public bool Enabled { set; }

	// Methods

	// RVA: 0xFC1220 Offset: 0xFC0620 VA: 0x180FC1220
	public void Start() { }

	// RVA: 0xFC1680 Offset: 0xFC0A80 VA: 0x180FC1680
	public void set_Enabled(bool value) { }

	// RVA: 0xFC1270 Offset: 0xFC0670 VA: 0x180FC1270
	public void UpdateFrom(Stats incomingStats) { }

	// RVA: 0xFC1620 Offset: 0xFC0A20 VA: 0x180FC1620
	public void .ctor() { }

}

private sealed class NetGraph.<>c // TypeDefIndex: 7076
{	// Fields
	public static readonly NetGraph.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, Stats.Node>, long> <>9__6_0; // 0x8

	// Methods

	// RVA: 0xFD3EC0 Offset: 0xFD32C0 VA: 0x180FD3EC0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFD3360 Offset: 0xFD2760 VA: 0x180FD3360
	internal long <UpdateFrom>b__6_0(KeyValuePair<string, Stats.Node> y) { }

}

public class NetGraphItem : MonoBehaviour // TypeDefIndex: 7077
{	// Fields
	public CanvasGroup group; // 0x18
	public LayoutElement element; // 0x20
	public Text countTotal; // 0x28
	public Text label; // 0x30
	public Text bytes; // 0x38

	// Methods

	// RVA: 0xFC0B60 Offset: 0xFBFF60 VA: 0x180FC0B60
	internal void Hide() { }

	// RVA: 0xFC0BB0 Offset: 0xFBFFB0 VA: 0x180FC0BB0
	internal void UpdateFrom(KeyValuePair<string, Stats.Node> node) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class NetGraphRow : MonoBehaviour // TypeDefIndex: 7078
{	// Fields
	public CanvasGroup group; // 0x18
	public Text countTotal; // 0x20
	public Text countUnique; // 0x28
	public Text label; // 0x30
	public Text bytes; // 0x38
	public GameObject RowContainer; // 0x40
	public NetGraphItem[] Items; // 0x48
	public GameObject RowSpacer; // 0x50

	// Methods

	// RVA: 0xFC0D00 Offset: 0xFC0100 VA: 0x180FC0D00
	private void Awake() { }

	// RVA: 0x4D8AE0 Offset: 0x4D7EE0 VA: 0x1804D8AE0
	internal void Hide() { }

	// RVA: 0xFC0D50 Offset: 0xFC0150 VA: 0x180FC0D50
	internal void UpdateFrom(KeyValuePair<string, Stats.Node> node) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

private sealed class NetGraphRow.<>c // TypeDefIndex: 7079
{	// Fields
	public static readonly NetGraphRow.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, Stats.Node>, long> <>9__10_0; // 0x8

	// Methods

	// RVA: 0xFD3E60 Offset: 0xFD3260 VA: 0x180FD3E60
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFD3320 Offset: 0xFD2720 VA: 0x180FD3320
	internal long <UpdateFrom>b__10_0(KeyValuePair<string, Stats.Node> y) { }

}

internal sealed class NetProtect : INetProtect // TypeDefIndex: 7165
{	// Methods

	// RVA: 0x22E19D0 Offset: 0x22E0DD0 VA: 0x1822E19D0
	public void .ctor(IntPtr Instance) { }

	// RVA: 0x22E18D0 Offset: 0x22E0CD0 VA: 0x1822E18D0 Slot: 4
	public bool ProtectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

	// RVA: 0x22E1950 Offset: 0x22E0D50 VA: 0x1822E1950 Slot: 5
	public bool UnprotectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

}

public class Net // TypeDefIndex: 8228
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Client <cl>k__BackingField; // 0x0
	public static Client ClientNetwork; // 0x8
	public static DemoClient DemoClientNetwork; // 0x10

	// Properties
	public static Client cl { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x106C110 Offset: 0x106B510 VA: 0x18106C110
	public static Client get_cl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x106C150 Offset: 0x106B550 VA: 0x18106C150
	private static void set_cl(Client value) { }

	// RVA: 0x106BF00 Offset: 0x106B300 VA: 0x18106BF00
	public static void ClientInit(Client newclient) { }

	// RVA: 0x106BF90 Offset: 0x106B390 VA: 0x18106BF90
	public static void StartDemoPlayback(Reader demo) { }

	// RVA: 0x106C050 Offset: 0x106B450 VA: 0x18106C050
	public static void StopDemoPlayback() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class NetworkInfoGeneralText : MonoBehaviour // TypeDefIndex: 9285
{	// Fields
	public TextMeshProUGUI text; // 0x18

	// Methods

	// RVA: 0xA346B0 Offset: 0xA33AB0 VA: 0x180A346B0
	private void Update() { }

	// RVA: 0xA346B0 Offset: 0xA33AB0 VA: 0x180A346B0
	private void UpdateText() { }

	// RVA: 0xA34630 Offset: 0xA33A30 VA: 0x180A34630
	private static string ChannelStat(int window, int left) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public abstract class NetworkCryptography : INetworkCryptocraphy // TypeDefIndex: 10236
{	// Fields
	private MemoryStream buffer; // 0x10

	// Methods

	// RVA: 0x7CC6D0 Offset: 0x7CBAD0 VA: 0x1807CC6D0 Slot: 6
	public MemoryStream EncryptCopy(Connection connection, MemoryStream stream, int offset) { }

	// RVA: 0x7CC5A0 Offset: 0x7CB9A0 VA: 0x1807CC5A0 Slot: 7
	public MemoryStream DecryptCopy(Connection connection, MemoryStream stream, int offset) { }

	// RVA: 0x7CC7D0 Offset: 0x7CBBD0 VA: 0x1807CC7D0 Slot: 8
	public void Encrypt(Connection connection, MemoryStream stream, int offset) { }

	// RVA: 0x7CC6A0 Offset: 0x7CBAA0 VA: 0x1807CC6A0 Slot: 9
	public void Decrypt(Connection connection, MemoryStream stream, int offset) { }

	// RVA: 0x7CC800 Offset: 0x7CBC00 VA: 0x1807CC800 Slot: 4
	public bool IsEnabledIncoming(Connection connection) { }

	// RVA: 0x7CC820 Offset: 0x7CBC20 VA: 0x1807CC820 Slot: 5
	public bool IsEnabledOutgoing(Connection connection) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void EncryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void DecryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset);

	// RVA: 0x7CC530 Offset: 0x7CB930 VA: 0x1807CC530
	protected void .ctor() { }

}

public class NetworkCryptographyClient : NetworkCryptography // TypeDefIndex: 10237
{	// Methods

	// RVA: 0x7CC440 Offset: 0x7CB840 VA: 0x1807CC440 Slot: 10
	protected override void EncryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	// RVA: 0x7CC350 Offset: 0x7CB750 VA: 0x1807CC350 Slot: 11
	protected override void DecryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	// RVA: 0x7CC530 Offset: 0x7CB930 VA: 0x1807CC530
	public void .ctor() { }

}

public class NetworkVisibilityGrid : MonoBehaviour // TypeDefIndex: 10238
{	// Fields
	public int startID; // 0x18
	public int gridSize; // 0x1C
	public int cellCount; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xBF140 Offset: 0xBE540 VA: 0x1800BF140
	public int visibilityRadiusFar; // 0x24
	public int visibilityRadiusNear; // 0x28
	public float switchTolerance; // 0x2C

	// Methods

	// RVA: 0xA347B0 Offset: 0xA33BB0 VA: 0x180A347B0
	public void .ctor() { }

}

public class ConnectionAuth : MonoBehaviour // TypeDefIndex: 10708
{	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ConnectionQueue // TypeDefIndex: 10709
{	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class ConnectionScreen : SingletonComponent<ConnectionScreen> // TypeDefIndex: 11095
{	// Fields
	public Text statusText; // 0x18
	public GameObject disconnectButton; // 0x20
	public GameObject retryButton; // 0x28
	public ServerBrowserInfo browserInfo; // 0x30
	internal Nullable<ServerInfo> currentServer; // 0x38
	internal Dictionary<string, string> currentServerRules; // 0xB8

	// Methods

	// RVA: 0x2FBC70 Offset: 0x2FB070 VA: 0x1802FBC70
	public static void Show() { }

	// RVA: 0x2FBDB0 Offset: 0x2FB1B0 VA: 0x1802FBDB0
	public static void UpdateServer(ServerInfo server) { }

	// RVA: 0x2FB520 Offset: 0x2FA920 VA: 0x1802FB520
	public static void FailedWith(string str) { }

	// RVA: 0x2FB3A0 Offset: 0x2FA7A0 VA: 0x1802FB3A0
	public static void FailedWithException(Exception e) { }

	// RVA: 0x2FBB80 Offset: 0x2FAF80 VA: 0x1802FBB80
	public static void SetStatus(string status) { }

	// RVA: 0x2FB0F0 Offset: 0x2FA4F0 VA: 0x1802FB0F0
	public static void DisconnectReason(string str) { }

	// RVA: 0x2FBA10 Offset: 0x2FAE10 VA: 0x1802FBA10
	public void RetryConnection() { }

	[AsyncStateMachineAttribute] // RVA: 0x95F40 Offset: 0x95340 VA: 0x180095F40
	// RVA: 0x2FB680 Offset: 0x2FAA80 VA: 0x1802FB680
	public static void LoadServerInfo(string address, int port, bool addToHistory = False) { }

	[AsyncStateMachineAttribute] // RVA: 0x96080 Offset: 0x95480 VA: 0x180096080
	// RVA: 0x2FB780 Offset: 0x2FAB80 VA: 0x1802FB780
	private static void LoadServerRules() { }

	// RVA: 0x2FB820 Offset: 0x2FAC20 VA: 0x1802FB820
	private static void OnServerInfoChanged() { }

	// RVA: 0x2FC0F0 Offset: 0x2FB4F0 VA: 0x1802FC0F0
	public void .ctor() { }

}

private struct ConnectionScreen.<LoadServerInfo>d__13 : IAsyncStateMachine // TypeDefIndex: 11096
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public string address; // 0x28
	public int port; // 0x30
	public bool addToHistory; // 0x34
	private TaskAwaiter<Nullable<ServerInfo>> <>u__1; // 0x38

	// Methods

	// RVA: 0xF1410 Offset: 0xF0810 VA: 0x1800F1410 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ConnectionScreen.<LoadServerRules>d__14 : IAsyncStateMachine // TypeDefIndex: 11097
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x28

	// Methods

	// RVA: 0xF1430 Offset: 0xF0830 VA: 0x1800F1430 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class NetworkSleep : MonoBehaviour // TypeDefIndex: 11318
{	// Fields
	public static int totalBehavioursDisabled; // 0x0
	public static int totalCollidersDisabled; // 0x4
	public Behaviour[] behaviours; // 0x18
	public Collider[] colliders; // 0x20
	internal int BehavioursDisabled; // 0x28
	internal int CollidersDisabled; // 0x2C

	// Methods

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public static class NetworkWriteEx // TypeDefIndex: 11344
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static void WriteObject<T>(NetWrite write, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1542AA0 Offset: 0x1541EA0 VA: 0x181542AA0
	|-NetworkWriteEx.WriteObject<bool>
	|
	|-RVA: 0x15435B0 Offset: 0x15429B0 VA: 0x1815435B0
	|-NetworkWriteEx.WriteObject<byte>
	|
	|-RVA: 0x15440C0 Offset: 0x15434C0 VA: 0x1815440C0
	|-NetworkWriteEx.WriteObject<int>
	|
	|-RVA: 0x1544BC0 Offset: 0x1543FC0 VA: 0x181544BC0
	|-NetworkWriteEx.WriteObject<object>
	|
	|-RVA: 0x15455C0 Offset: 0x15449C0 VA: 0x1815455C0
	|-NetworkWriteEx.WriteObject<sbyte>
	|
	|-RVA: 0xCF6880 Offset: 0xCF5C80 VA: 0x180CF6880
	|-NetworkWriteEx.WriteObject<float>
	|
	|-RVA: 0xCF73B0 Offset: 0xCF67B0 VA: 0x180CF73B0
	|-NetworkWriteEx.WriteObject<uint>
	|
	|-RVA: 0xCF7EB0 Offset: 0xCF72B0 VA: 0x180CF7EB0
	|-NetworkWriteEx.WriteObject<ulong>
	|
	|-RVA: 0xCF5200 Offset: 0xCF4600 VA: 0x180CF5200
	|-NetworkWriteEx.WriteObject<Color>
	|
	|-RVA: 0xCF5CE0 Offset: 0xCF50E0 VA: 0x180CF5CE0
	|-NetworkWriteEx.WriteObject<Ray>
	|
	|-RVA: 0xCF89C0 Offset: 0xCF7DC0 VA: 0x180CF89C0
	|-NetworkWriteEx.WriteObject<Vector3>
	*/

}

public class NetworkedProperty<T> // TypeDefIndex: 11426
{	// Fields
	private T val; // 0x0
	private BaseEntity entity; // 0x0

	// Properties
	public T Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	|-NetworkedProperty<int>.get_Value
	|
	|-RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	|-NetworkedProperty<object>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD54730 Offset: 0xD53B30 VA: 0x180D54730
	|-NetworkedProperty<int>.set_Value
	|
	|-RVA: 0xD546B0 Offset: 0xD53AB0 VA: 0x180D546B0
	|-NetworkedProperty<object>.set_Value
	*/

	// RVA: -1 Offset: -1
	public void .ctor(BaseEntity entity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD545E0 Offset: 0xD539E0 VA: 0x180D545E0
	|-NetworkedProperty<int>..ctor
	|-NetworkedProperty<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public static T op_Implicit(NetworkedProperty<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD54620 Offset: 0xD53A20 VA: 0x180D54620
	|-NetworkedProperty<int>.op_Implicit
	|-NetworkedProperty<object>.op_Implicit
	*/

}

public sealed class ProxyArray : Variant, IEnumerable<Variant>, IEnumerable // TypeDefIndex: 11579
{	// Fields
	private readonly List<Variant> list; // 0x10

	// Properties
	public override Variant Item { get; set; }
	public int Count { get; }

	// Methods

	// RVA: 0x83F8C0 Offset: 0x83ECC0 VA: 0x18083F8C0
	public void .ctor() { }

	// RVA: 0x83F7C0 Offset: 0x83EBC0 VA: 0x18083F7C0 Slot: 42
	private IEnumerator<Variant> System.Collections.Generic.IEnumerable<TinyJSON.Variant>.GetEnumerator() { }

	// RVA: 0x83F840 Offset: 0x83EC40 VA: 0x18083F840 Slot: 43
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x83F560 Offset: 0x83E960 VA: 0x18083F560
	public void Add(Variant item) { }

	// RVA: 0x83F990 Offset: 0x83ED90 VA: 0x18083F990 Slot: 40
	public override Variant get_Item(int index) { }

	// RVA: 0x83F9F0 Offset: 0x83EDF0 VA: 0x18083F9F0 Slot: 41
	public override void set_Item(int index, Variant value) { }

	// RVA: 0x83F950 Offset: 0x83ED50 VA: 0x18083F950
	public int get_Count() { }

	// RVA: 0x83F5C0 Offset: 0x83E9C0 VA: 0x18083F5C0
	internal bool CanBeMultiRankArray(int[] rankLengths) { }

	// RVA: 0x83F5D0 Offset: 0x83E9D0 VA: 0x18083F5D0
	private bool CanBeMultiRankArray(int rank, int[] rankLengths) { }

}

public sealed class ProxyBoolean : Variant // TypeDefIndex: 11580
{	// Fields
	private readonly bool value; // 0x10

	// Methods

	// RVA: 0x83FAA0 Offset: 0x83EEA0 VA: 0x18083FAA0
	public void .ctor(bool value) { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20 Slot: 24
	public override bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x83FA60 Offset: 0x83EE60 VA: 0x18083FA60 Slot: 34
	public override string ToString(IFormatProvider provider) { }

}

public sealed class ProxyNumber : Variant // TypeDefIndex: 11581
{	// Fields
	private static readonly char[] floatingPointCharacters; // 0x0
	private readonly IConvertible value; // 0x10

	// Methods

	// RVA: 0x840980 Offset: 0x83FD80 VA: 0x180840980
	public void .ctor(IConvertible value) { }

	// RVA: 0x83FB10 Offset: 0x83EF10 VA: 0x18083FB10
	private static IConvertible Parse(string value) { }

	// RVA: 0x83FE40 Offset: 0x83F240 VA: 0x18083FE40 Slot: 24
	public override bool ToBoolean(IFormatProvider provider) { }

	// RVA: 0x83FF00 Offset: 0x83F300 VA: 0x18083FF00 Slot: 25
	public override byte ToByte(IFormatProvider provider) { }

	// RVA: 0x83FFC0 Offset: 0x83F3C0 VA: 0x18083FFC0 Slot: 26
	public override char ToChar(IFormatProvider provider) { }

	// RVA: 0x840080 Offset: 0x83F480 VA: 0x180840080 Slot: 27
	public override Decimal ToDecimal(IFormatProvider provider) { }

	// RVA: 0x840160 Offset: 0x83F560 VA: 0x180840160 Slot: 28
	public override double ToDouble(IFormatProvider provider) { }

	// RVA: 0x840220 Offset: 0x83F620 VA: 0x180840220 Slot: 29
	public override short ToInt16(IFormatProvider provider) { }

	// RVA: 0x8402E0 Offset: 0x83F6E0 VA: 0x1808402E0 Slot: 30
	public override int ToInt32(IFormatProvider provider) { }

	// RVA: 0x8403A0 Offset: 0x83F7A0 VA: 0x1808403A0 Slot: 31
	public override long ToInt64(IFormatProvider provider) { }

	// RVA: 0x840460 Offset: 0x83F860 VA: 0x180840460 Slot: 32
	public override sbyte ToSByte(IFormatProvider provider) { }

	// RVA: 0x840520 Offset: 0x83F920 VA: 0x180840520 Slot: 33
	public override float ToSingle(IFormatProvider provider) { }

	// RVA: 0x8405E0 Offset: 0x83F9E0 VA: 0x1808405E0 Slot: 34
	public override string ToString(IFormatProvider provider) { }

	// RVA: 0x8406A0 Offset: 0x83FAA0 VA: 0x1808406A0 Slot: 35
	public override ushort ToUInt16(IFormatProvider provider) { }

	// RVA: 0x840760 Offset: 0x83FB60 VA: 0x180840760 Slot: 36
	public override uint ToUInt32(IFormatProvider provider) { }

	// RVA: 0x840820 Offset: 0x83FC20 VA: 0x180840820 Slot: 37
	public override ulong ToUInt64(IFormatProvider provider) { }

	// RVA: 0x8408E0 Offset: 0x83FCE0 VA: 0x1808408E0
	private static void .cctor() { }

}

public sealed class ProxyObject : Variant, IEnumerable<KeyValuePair<string, Variant>>, IEnumerable // TypeDefIndex: 11582
{	// Fields
	public const string TypeHintKey = "@type";
	private readonly Dictionary<string, Variant> dict; // 0x10

	// Properties
	public string TypeHint { get; }
	public override Variant Item { get; set; }
	public int Count { get; }
	public Dictionary.KeyCollection<string, Variant> Keys { get; }
	public Dictionary.ValueCollection<string, Variant> Values { get; }

	// Methods

	// RVA: 0x840F40 Offset: 0x840340 VA: 0x180840F40
	public void .ctor() { }

	// RVA: 0x840DD0 Offset: 0x8401D0 VA: 0x180840DD0 Slot: 42
	private IEnumerator<KeyValuePair<string, Variant>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,TinyJSON.Variant>>.GetEnumerator() { }

	// RVA: 0x840E50 Offset: 0x840250 VA: 0x180840E50 Slot: 43
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x840D60 Offset: 0x840160 VA: 0x180840D60
	public void Add(string key, Variant item) { }

	// RVA: 0x840ED0 Offset: 0x8402D0 VA: 0x180840ED0
	public bool TryGetValue(string key, out Variant item) { }

	// RVA: 0x8410D0 Offset: 0x8404D0 VA: 0x1808410D0
	public string get_TypeHint() { }

	// RVA: 0x841020 Offset: 0x840420 VA: 0x180841020 Slot: 38
	public override Variant get_Item(string key) { }

	// RVA: 0x841200 Offset: 0x840600 VA: 0x180841200 Slot: 39
	public override void set_Item(string key, Variant value) { }

	// RVA: 0x840FD0 Offset: 0x8403D0 VA: 0x180840FD0
	public int get_Count() { }

	// RVA: 0x841080 Offset: 0x840480 VA: 0x180841080
	public Dictionary.KeyCollection<string, Variant> get_Keys() { }

	// RVA: 0x8411B0 Offset: 0x8405B0 VA: 0x1808411B0
	public Dictionary.ValueCollection<string, Variant> get_Values() { }

}

public sealed class ProxyString : Variant // TypeDefIndex: 11583
{	// Fields
	private readonly string value; // 0x10

	// Methods

	// RVA: 0x841270 Offset: 0x840670 VA: 0x180841270
	public void .ctor(string value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 34
	public override string ToString(IFormatProvider provider) { }

}

public class ConnectionLimiter // TypeDefIndex: 11641
{	// Fields
	private readonly object _sync; // 0x10
	private readonly Dictionary<IPAddress, int> _addressCounts; // 0x18
	private int _overallCount; // 0x20

	// Methods

	// RVA: 0x59D080 Offset: 0x59C480 VA: 0x18059D080
	public void .ctor() { }

	// RVA: 0x59CE60 Offset: 0x59C260 VA: 0x18059CE60
	public bool TryAdd(IPAddress address) { }

	// RVA: 0x59C770 Offset: 0x59BB70 VA: 0x18059C770
	public void Remove(IPAddress address) { }

	// RVA: 0x59C690 Offset: 0x59BA90 VA: 0x18059C690
	public void Clear() { }

	// RVA: 0x59C8D0 Offset: 0x59BCD0 VA: 0x18059C8D0 Slot: 3
	public override string ToString() { }

}

private sealed class ConnectionLimiter.<>c // TypeDefIndex: 11642
{	// Fields
	public static readonly ConnectionLimiter.<>c <>9; // 0x0
	public static Func<KeyValuePair<IPAddress, int>, int> <>9__7_0; // 0x8

	// Methods

	// RVA: 0x5A3640 Offset: 0x5A2A40 VA: 0x1805A3640
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5A3390 Offset: 0x5A2790 VA: 0x1805A3390
	internal int <ToString>b__7_0(KeyValuePair<IPAddress, int> t) { }

}

public static class NetworkPacketEx // TypeDefIndex: 11699
{
// Namespace: UnityEngine
[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public static class NetworkPacketEx // TypeDefIndex: 11699
	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9DC5B0 Offset: 0x9DB9B0 VA: 0x1809DC5B0
	public static BasePlayer Player(Message v) { }

}

public class Net : ConsoleSystem // TypeDefIndex: 11943
{	// Fields
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool visdebug; // 0x0
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool debug; // 0x1
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int visibilityRadiusFarOverride; // 0x4
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int visibilityRadiusNearOverride; // 0x8

	// Methods

	// RVA: 0x365910 Offset: 0x364D10 VA: 0x180365910
	public void .ctor() { }

	// RVA: 0x365890 Offset: 0x364C90 VA: 0x180365890
	private static void .cctor() { }

}

public class Netgraph : ConsoleSystem // TypeDefIndex: 11944
{	// Fields
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool enabled; // 0x0
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float updatespeed; // 0x4
	[ClientVar] // RVA: 0x89040 Offset: 0x88440 VA: 0x180089040
	public static string typefilter; // 0x8
	[ClientVar] // RVA: 0x89040 Offset: 0x88440 VA: 0x180089040
	public static string entityfilter; // 0x10

	// Methods

	// RVA: 0x365A50 Offset: 0x364E50 VA: 0x180365A50
	public void .ctor() { }

	// RVA: 0x3659B0 Offset: 0x364DB0 VA: 0x1803659B0
	private static void .cctor() { }

}

