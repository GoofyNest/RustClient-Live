internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem // TypeDefIndex: 815
{
	private WaitCallback callback;
	private ExecutionContext context;
	private object state;
	internal static ContextCallback ccb;


	private static void .cctor() { }

	internal void .ctor(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark) { }

	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	private static void WaitCallback_Context(object state) { }

}

public class ProxyAttribute : Attribute // TypeDefIndex: 1159
{

	public virtual MarshalByRefObject CreateInstance(Type serverType) { }

	public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext) { }

}

public class Queue : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1413
{
	private object[] _array;
	private int _head;
	private int _tail;
	private int _size;
	private int _growFactor;
	private int _version;
	private object _syncRoot;

	public virtual int Count { get; }
	public virtual object SyncRoot { get; }


	public void .ctor() { }

	public void .ctor(int capacity) { }

	public void .ctor(int capacity, float growFactor) { }

	public void .ctor(ICollection col) { }

	public virtual int get_Count() { }

	public virtual object Clone() { }

	public virtual object get_SyncRoot() { }

	public virtual void Clear() { }

	public virtual void CopyTo(Array array, int index) { }

	public virtual void Enqueue(object obj) { }

	public virtual IEnumerator GetEnumerator() { }

	public virtual object Dequeue() { }

	public virtual object Peek() { }

	internal object GetElement(int i) { }

	public virtual object[] ToArray() { }

	private void SetCapacity(int capacity) { }

}

private class Queue.QueueEnumerator : IEnumerator, ICloneable // TypeDefIndex: 1414
{
	private Queue _q;
	private int _index;
	private int _version;
	private object currentElement;

	public virtual object Current { get; }


	internal void .ctor(Queue q) { }

	public object Clone() { }

	public virtual bool MoveNext() { }

	public virtual object get_Current() { }

	public virtual void Reset() { }

}

public class NetworkCredential : ICredentials // TypeDefIndex: 2893
{
	private string m_domain;
	private string m_userName;
	private SecureString m_password;

	public string UserName { get; set; }
	public string Password { get; set; }
	public string Domain { get; set; }


	public void .ctor(string userName, string password) { }

	public void .ctor(string userName, string password, string domain) { }

	public string get_UserName() { }

	public void set_UserName(string value) { }

	public string get_Password() { }

	public void set_Password(string value) { }

	public string get_Domain() { }

	public void set_Domain(string value) { }

	internal string InternalGetUserName() { }

	internal string InternalGetPassword() { }

	internal string InternalGetDomain() { }

	public NetworkCredential GetCredential(Uri uri, string authType) { }

}

internal class NetRes // TypeDefIndex: 2921
{

	public static string GetWebStatusString(string Res, WebExceptionStatus Status) { }

	public static string GetWebStatusString(WebExceptionStatus Status) { }

}

public class NetworkStream : Stream // TypeDefIndex: 3044
{

public class NetworkStream : Stream
	private Socket m_StreamSocket;
	private bool m_Readable;
	private bool m_Writeable;
	private bool m_OwnsSocket;
	private int m_CloseTimeout;
	private bool m_CleanedUp;
	private int m_CurrentReadTimeout;
	private int m_CurrentWriteTimeout;

	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; }
	public override int WriteTimeout { get; }
	public override long Length { get; }
	public override long Position { get; set; }


	public void .ctor(Socket socket) { }

	public void .ctor(Socket socket, bool ownsSocket) { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public override int get_ReadTimeout() { }

	public override int get_WriteTimeout() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	internal void InitNetworkStream(Socket socket, FileAccess Access) { }

	public override int Read([In] [Out] byte[] buffer, int offset, int size) { }

	public override void Write(byte[] buffer, int offset, int size) { }

	protected override void Dispose(bool disposing) { }

	protected override void Finalize() { }

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	public override int EndRead(IAsyncResult asyncResult) { }

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	public override void EndWrite(IAsyncResult asyncResult) { }

	public override void Flush() { }

	public override void SetLength(long value) { }

}

public class NetworkInformationException : Win32Exception // TypeDefIndex: 3074
{

	public void .ctor() { }

	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

public enum NetworkInterfaceComponent // TypeDefIndex: 3075
{
	public int value__;
	public const NetworkInterfaceComponent IPv4 = 0;
	public const NetworkInterfaceComponent IPv6 = 1;

}

public enum NetBiosNodeType // TypeDefIndex: 3076
{
	public int value__;
	public const NetBiosNodeType Unknown = 0;
	public const NetBiosNodeType Broadcast = 1;
	public const NetBiosNodeType Peer2Peer = 2;
	public const NetBiosNodeType Mixed = 4;
	public const NetBiosNodeType Hybrid = 8;

}

public class Queue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 3118
{
	private T[] _array;
	private int _head;
	private int _tail;
	private int _size;
	private int _version;
	private object _syncRoot;
	private const int MinimumGrow = 4;
	private const int GrowFactor = 200;

	public int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-Queue<BaseEntity.QueuedFileRequest>..ctor
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

	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-Queue<BaseEntity.QueuedFileRequest>..ctor
	|
	|-Queue<RCon.Command>..ctor
	|
	|-Queue<int>..ctor
	|
	|-Queue<IntPtr>..ctor
	|
	|-Queue<object>..ctor
	|-Queue<string>..ctor
	|-Queue<Renderer>..ctor
	|
	|-Queue<ulong>..ctor
	|
	|-Queue<AsyncGPUReadbackRequest>..ctor
	|
	|-Queue<EventDispatcher.EventRecord>..ctor
	*/

	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-Queue<BaseEntity.QueuedFileRequest>.get_Count
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

	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-Queue<BaseEntity.QueuedFileRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-Queue<RCon.Command>.System.Collections.ICollection.get_SyncRoot
	|
	|-Queue<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-Queue<IntPtr>.System.Collections.ICollection.get_SyncRoot
	|
	|-Queue<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-Queue<ulong>.System.Collections.ICollection.get_SyncRoot
	|
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.ICollection.get_SyncRoot
	|
	|-Queue<EventDispatcher.EventRecord>.System.Collections.ICollection.get_SyncRoot
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-Queue<BaseEntity.QueuedFileRequest>.Clear
	|-Queue<BaseEntity>.Clear
	|-Queue<RCon.Command>.Clear
	|-Queue<object>.Clear
	|-Queue<string>.Clear
	|-Queue<EventDispatcher.EventRecord>.Clear
	|
	|-Queue<int>.Clear
	|-Queue<IntPtr>.Clear
	|-Queue<ulong>.Clear
	|-Queue<AsyncGPUReadbackRequest>.Clear
	*/

	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-Queue<BaseEntity.QueuedFileRequest>.System.Collections.ICollection.CopyTo
	|
	|-Queue<RCon.Command>.System.Collections.ICollection.CopyTo
	|
	|-Queue<int>.System.Collections.ICollection.CopyTo
	|
	|-Queue<IntPtr>.System.Collections.ICollection.CopyTo
	|
	|-Queue<object>.System.Collections.ICollection.CopyTo
	|
	|-Queue<ulong>.System.Collections.ICollection.CopyTo
	|
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.ICollection.CopyTo
	|
	|-Queue<EventDispatcher.EventRecord>.System.Collections.ICollection.CopyTo
	*/

	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-Queue<BaseEntity.QueuedFileRequest>.Enqueue
	|
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
	|-Queue<RCon.Command>.Enqueue
	|
	|-Queue<int>.Enqueue
	|
	|-Queue<IntPtr>.Enqueue
	|-Queue<ulong>.Enqueue
	|
	|-Queue<AsyncGPUReadbackRequest>.Enqueue
	|
	|-Queue<EventDispatcher.EventRecord>.Enqueue
	*/

	public Queue.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-Queue<string>.GetEnumerator
	|-Queue<IntPtr>.GetEnumerator
	|-Queue<object>.GetEnumerator
	|-Queue<ulong>.GetEnumerator
	|
	|-Queue<BaseEntity.QueuedFileRequest>.GetEnumerator
	|
	|-Queue<RCon.Command>.GetEnumerator
	|
	|-Queue<int>.GetEnumerator
	|
	|-Queue<AsyncGPUReadbackRequest>.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.GetEnumerator
	*/

	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-Queue<BaseEntity.QueuedFileRequest>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-Queue<RCon.Command>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-Queue<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-Queue<IntPtr>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<ulong>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-Queue<BaseEntity.QueuedFileRequest>.System.Collections.IEnumerable.GetEnumerator
	|
	|-Queue<RCon.Command>.System.Collections.IEnumerable.GetEnumerator
	|
	|-Queue<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-Queue<IntPtr>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<object>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<ulong>.System.Collections.IEnumerable.GetEnumerator
	|
	|-Queue<AsyncGPUReadbackRequest>.System.Collections.IEnumerable.GetEnumerator
	|-Queue<EventDispatcher.EventRecord>.System.Collections.IEnumerable.GetEnumerator
	*/

	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-Queue<BaseEntity.QueuedFileRequest>.Dequeue
	|
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
	|-Queue<RCon.Command>.Dequeue
	|
	|-Queue<int>.Dequeue
	|
	|-Queue<IntPtr>.Dequeue
	|-Queue<ulong>.Dequeue
	|
	|-Queue<AsyncGPUReadbackRequest>.Dequeue
	|
	|-Queue<EventDispatcher.EventRecord>.Dequeue
	*/

	public T Peek() { }
	/* GenericInstMethod :
	|
	|-Queue<ulong>.Peek
	|-Queue<IntPtr>.Peek
	|-Queue<object>.Peek
	|
	|-Queue<AsyncGPUReadbackRequest>.Peek
	|-Queue<EventDispatcher.EventRecord>.Peek
	|
	|-Queue<BaseEntity.QueuedFileRequest>.Peek
	|
	|-Queue<RCon.Command>.Peek
	|
	|-Queue<int>.Peek
	*/

	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-Queue<BaseEntity.QueuedFileRequest>.Contains
	|
	|-Queue<RCon.Command>.Contains
	|
	|-Queue<int>.Contains
	|
	|-Queue<IntPtr>.Contains
	|-Queue<object>.Contains
	|-Queue<ulong>.Contains
	|
	|-Queue<AsyncGPUReadbackRequest>.Contains
	|-Queue<EventDispatcher.EventRecord>.Contains
	*/

	private void SetCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-Queue<BaseEntity.QueuedFileRequest>.SetCapacity
	|-Queue<RCon.Command>.SetCapacity
	|-Queue<int>.SetCapacity
	|-Queue<IntPtr>.SetCapacity
	|-Queue<object>.SetCapacity
	|-Queue<ulong>.SetCapacity
	|-Queue<AsyncGPUReadbackRequest>.SetCapacity
	|-Queue<EventDispatcher.EventRecord>.SetCapacity
	*/

	private void MoveNext(ref int index) { }
	/* GenericInstMethod :
	|
	|-Queue<BaseEntity.QueuedFileRequest>.MoveNext
	|-Queue<RCon.Command>.MoveNext
	|-Queue<int>.MoveNext
	|-Queue<IntPtr>.MoveNext
	|-Queue<object>.MoveNext
	|-Queue<ulong>.MoveNext
	|-Queue<AsyncGPUReadbackRequest>.MoveNext
	|-Queue<EventDispatcher.EventRecord>.MoveNext
	*/

	private void ThrowForEmptyQueue() { }
	/* GenericInstMethod :
	|
	|-Queue<BaseEntity.QueuedFileRequest>.ThrowForEmptyQueue
	|
	|-Queue<RCon.Command>.ThrowForEmptyQueue
	|
	|-Queue<int>.ThrowForEmptyQueue
	|
	|-Queue<IntPtr>.ThrowForEmptyQueue
	|
	|-Queue<object>.ThrowForEmptyQueue
	|
	|-Queue<ulong>.ThrowForEmptyQueue
	|
	|-Queue<AsyncGPUReadbackRequest>.ThrowForEmptyQueue
	|
	|-Queue<EventDispatcher.EventRecord>.ThrowForEmptyQueue
	*/

}

public struct Queue.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 3119
{
	private readonly Queue<T> _q;
	private readonly int _version;
	private int _index;
	private T _currentElement;

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(Queue<T> q) { }
	/* GenericInstMethod :
	|
	|-Queue.Enumerator<BaseEntity.QueuedFileRequest>..ctor
	|
	|-Queue.Enumerator<RCon.Command>..ctor
	|
	|-Queue.Enumerator<int>..ctor
	|
	|-Queue.Enumerator<IntPtr>..ctor
	|-Queue.Enumerator<object>..ctor
	|-Queue.Enumerator<ulong>..ctor
	|
	|-Queue.Enumerator<AsyncGPUReadbackRequest>..ctor
	|-Queue.Enumerator<EventDispatcher.EventRecord>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-Queue.Enumerator<BaseEntity.QueuedFileRequest>.Dispose
	|
	|-Queue.Enumerator<RCon.Command>.Dispose
	|
	|-Queue.Enumerator<int>.Dispose
	|
	|-Queue.Enumerator<IntPtr>.Dispose
	|-Queue.Enumerator<object>.Dispose
	|-Queue.Enumerator<string>.Dispose
	|-Queue.Enumerator<ulong>.Dispose
	|
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.Dispose
	|-Queue.Enumerator<EventDispatcher.EventRecord>.Dispose
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-Queue.Enumerator<BaseEntity.QueuedFileRequest>.MoveNext
	|
	|-Queue.Enumerator<RCon.Command>.MoveNext
	|
	|-Queue.Enumerator<int>.MoveNext
	|
	|-Queue.Enumerator<IntPtr>.MoveNext
	|
	|-Queue.Enumerator<object>.MoveNext
	|-Queue.Enumerator<string>.MoveNext
	|
	|-Queue.Enumerator<ulong>.MoveNext
	|
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.MoveNext
	|
	|-Queue.Enumerator<EventDispatcher.EventRecord>.MoveNext
	*/

	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-Queue.Enumerator<string>.get_Current
	|-Queue.Enumerator<object>.get_Current
	|
	|-Queue.Enumerator<BaseEntity.QueuedFileRequest>.get_Current
	|
	|-Queue.Enumerator<RCon.Command>.get_Current
	|
	|-Queue.Enumerator<int>.get_Current
	|
	|-Queue.Enumerator<IntPtr>.get_Current
	|
	|-Queue.Enumerator<ulong>.get_Current
	|
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.get_Current
	|
	|-Queue.Enumerator<EventDispatcher.EventRecord>.get_Current
	*/

	private void ThrowEnumerationNotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-Queue.Enumerator<BaseEntity.QueuedFileRequest>.ThrowEnumerationNotStartedOrEnded
	|
	|-Queue.Enumerator<RCon.Command>.ThrowEnumerationNotStartedOrEnded
	|
	|-Queue.Enumerator<int>.ThrowEnumerationNotStartedOrEnded
	|
	|-Queue.Enumerator<IntPtr>.ThrowEnumerationNotStartedOrEnded
	|
	|-Queue.Enumerator<object>.ThrowEnumerationNotStartedOrEnded
	|
	|-Queue.Enumerator<ulong>.ThrowEnumerationNotStartedOrEnded
	|
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.ThrowEnumerationNotStartedOrEnded
	|
	|-Queue.Enumerator<EventDispatcher.EventRecord>.ThrowEnumerationNotStartedOrEnded
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-Queue.Enumerator<BaseEntity.QueuedFileRequest>.System.Collections.IEnumerator.get_Current
	|
	|-Queue.Enumerator<RCon.Command>.System.Collections.IEnumerator.get_Current
	|
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-Queue.Enumerator<IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-Queue.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.System.Collections.IEnumerator.get_Current
	|
	|-Queue.Enumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.get_Current
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-Queue.Enumerator<BaseEntity.QueuedFileRequest>.System.Collections.IEnumerator.Reset
	|
	|-Queue.Enumerator<RCon.Command>.System.Collections.IEnumerator.Reset
	|
	|-Queue.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-Queue.Enumerator<IntPtr>.System.Collections.IEnumerator.Reset
	|
	|-Queue.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-Queue.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	|
	|-Queue.Enumerator<AsyncGPUReadbackRequest>.System.Collections.IEnumerator.Reset
	|
	|-Queue.Enumerator<EventDispatcher.EventRecord>.System.Collections.IEnumerator.Reset
	*/

}

public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection // TypeDefIndex: 3170
{

[ConfigurationCollectionAttribute]
[DefaultMemberAttribute]
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection

	public void .ctor() { }

}

public sealed class ConnectionManagementSection : ConfigurationSection // TypeDefIndex: 3171
{
	protected override ConfigurationPropertyCollection Properties { get; }


	public void .ctor() { }

	protected override ConfigurationPropertyCollection get_Properties() { }

}

public sealed class ProxyElement : ConfigurationElement // TypeDefIndex: 3173
{
	protected override ConfigurationPropertyCollection Properties { get; }


	public void .ctor() { }

	protected override ConfigurationPropertyCollection get_Properties() { }

}

public sealed class NetSectionGroup : ConfigurationSectionGroup // TypeDefIndex: 3176
{

	public void .ctor() { }

}

public enum NetworkReachability // TypeDefIndex: 3358
{
	public int value__;
	public const NetworkReachability NotReachable = 0;
	public const NetworkReachability ReachableViaCarrierDataNetwork = 1;
	public const NetworkReachability ReachableViaLocalAreaNetwork = 2;

}

internal enum ConnectionChangeType // TypeDefIndex: 4148
{
	public uint value__;
	public const ConnectionChangeType Connected = 0;
	public const ConnectionChangeType Disconnected = 1;
	public const ConnectionChangeType ConfigChange = 2;

}

public enum ConnectionState // TypeDefIndex: 4178
{
	public int value__;
	public const ConnectionState Closed = 0;
	public const ConnectionState Open = 1;
	public const ConnectionState Connecting = 2;
	public const ConnectionState Executing = 4;
	public const ConnectionState Fetching = 8;
	public const ConnectionState Broken = 16;

}

public enum ConnectionState // TypeDefIndex: 5175
{
	public int value__;
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

internal enum NetConfigScope // TypeDefIndex: 5176
{
	public int value__;
	public const NetConfigScope Global = 1;
	public const NetConfigScope SocketsInterface = 2;
	public const NetConfigScope ListenSocket = 3;
	public const NetConfigScope Connection = 4;

}

internal enum NetConfigType // TypeDefIndex: 5177
{
	public int value__;
	public const NetConfigType Int32 = 1;
	public const NetConfigType Int64 = 2;
	public const NetConfigType Float = 3;
	public const NetConfigType String = 4;
	public const NetConfigType Ptr = 5;

}

internal enum NetConfig // TypeDefIndex: 5178
{
	public int value__;
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
	public const NetConfig P2P_TURN_ServerList = 107;
	public const NetConfig P2P_TURN_UserList = 108;
	public const NetConfig P2P_TURN_PassList = 109;
	public const NetConfig P2P_Transport_ICE_Implementation = 110;
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

internal enum NetConfigResult // TypeDefIndex: 5179
{
	public int value__;
	public const NetConfigResult BadValue = -1;
	public const NetConfigResult BadScopeObj = -2;
	public const NetConfigResult BufferTooSmall = -3;
	public const NetConfigResult OK = 1;
	public const NetConfigResult OKInherited = 2;

}

public enum NetDebugOutput // TypeDefIndex: 5180
{
	public int value__;
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

public class ConnectionManager // TypeDefIndex: 5184
{
	[CompilerGeneratedAttribute]
	private IConnectionManager <Interface>k__BackingField;
	public Connection Connection;
	[CompilerGeneratedAttribute]
	private ConnectionInfo <ConnectionInfo>k__BackingField;
	public bool Connected;
	public bool Connecting;

	public IConnectionManager Interface { get; set; }
	internal ConnectionInfo ConnectionInfo { set; }


	[CompilerGeneratedAttribute]
	public IConnectionManager get_Interface() { }

	[CompilerGeneratedAttribute]
	public void set_Interface(IConnectionManager value) { }

	[CompilerGeneratedAttribute]
	internal void set_ConnectionInfo(ConnectionInfo value) { }

	public void Close(bool linger = False, int reasonCode = 0, string debugString = "Closing Connection") { }

	public override string ToString() { }

	public virtual void OnConnectionChanged(ConnectionInfo info) { }

	public virtual void OnConnecting(ConnectionInfo info) { }

	public virtual void OnConnected(ConnectionInfo info) { }

	public virtual void OnDisconnected(ConnectionInfo info) { }

	public int Receive(int bufferSize = 32, bool receiveToEnd = True) { }

	internal void ReceiveMessage(ref NetMsg* msg) { }

	public virtual void OnMessage(IntPtr data, int size, long messageNum, long recvTime, int channel) { }

	public void .ctor() { }

}

internal sealed class NetDebugFunc : MulticastDelegate // TypeDefIndex: 5185
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke([In] NetDebugOutput nType, [In] IntPtr pszMsg) { }

	public virtual IAsyncResult BeginInvoke([In] NetDebugOutput nType, [In] IntPtr pszMsg, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

internal struct NetKeyValue // TypeDefIndex: 5515
{
	internal NetConfig Value;
	internal NetConfigType DataType;
	internal long Int64Value;
	internal int Int32Value;
	internal float FloatValue;
	internal IntPtr PointerValue;

}

public struct NetIdentity // TypeDefIndex: 5516
{
	internal NetIdentity.IdentityType type;
	internal int size;
	internal ulong steamid;
	internal NetAddress netaddress;


	public override string ToString() { }

}

internal enum NetIdentity.IdentityType // TypeDefIndex: 5517
{
	public int value__;
	public const NetIdentity.IdentityType Invalid = 0;
	public const NetIdentity.IdentityType IPAddress = 1;
	public const NetIdentity.IdentityType GenericString = 2;
	public const NetIdentity.IdentityType GenericBytes = 3;
	public const NetIdentity.IdentityType SteamID = 16;

}

public struct NetAddress // TypeDefIndex: 5518
{
	internal NetAddress.IPV4 ip;
	internal ushort port;

	public static NetAddress Cleared { get; }


	internal static extern void InternalClear(ref NetAddress self) { }

	internal static extern void InternalSetIPv4(ref NetAddress self, uint nIP, ushort nPort) { }

	internal static extern void InternalToString(ref NetAddress self, IntPtr buf, uint cbBuf, bool bWithPort) { }

	public static NetAddress AnyIp(ushort port) { }

	public static NetAddress From(string addrStr, ushort port) { }

	public static NetAddress From(IPAddress address, ushort port) { }

	public static NetAddress get_Cleared() { }

	public override string ToString() { }

}

internal struct NetAddress.IPV4 // TypeDefIndex: 5519
{
	internal ulong m_8zeros;
	internal ushort m_0000;
	internal ushort m_ffff;
	internal byte ip0;
	internal byte ip1;
	internal byte ip2;
	internal byte ip3;

}

internal struct NetMsg // TypeDefIndex: 5520
{
	internal IntPtr DataPtr;
	internal int DataSize;
	internal Connection Connection;
	internal NetIdentity Identity;
	internal long ConnectionUserData;
	internal long RecvTime;
	internal long MessageNumber;
	internal IntPtr FreeDataPtr;
	internal IntPtr ReleasePtr;
	internal int Channel;
	internal SendType Flags;
	internal long UserData;
	internal ushort IdxLane;
	internal ushort _pad1__;


	internal static extern void InternalRelease(NetMsg* self) { }

}

public struct Connection : IEquatable<Connection> // TypeDefIndex: 5551
{
	[CompilerGeneratedAttribute]
	private uint <Id>k__BackingField;

	public uint Id { get; set; }


	[CompilerGeneratedAttribute]
	[IsReadOnlyAttribute]
	public uint get_Id() { }

	[CompilerGeneratedAttribute]
	public void set_Id(uint value) { }

	public bool Equals(Connection other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public static Connection op_Implicit(uint value) { }

	public static uint op_Implicit(Connection value) { }

	public Result Accept() { }

	public bool Close(bool linger = False, int reasonCode = 0, string debugString = "Closing Connection") { }

	public Result SendMessage(IntPtr ptr, int size, SendType sendType = 8, ushort laneIndex = 0) { }

	public Result Flush() { }

	public string DetailedStatus() { }

	public ConnectionStatus QuickStatus() { }

	public Result ConfigureConnectionLanes(int[] lanePriorities, ushort[] laneWeights) { }

}

public struct ConnectionInfo // TypeDefIndex: 5552
{
	internal NetIdentity identity;
	internal long userData;
	internal Socket listenSocket;
	internal NetAddress address;
	internal ushort pad;
	internal SteamNetworkingPOPID popRemote;
	internal SteamNetworkingPOPID popRelay;
	internal ConnectionState state;
	internal int endReason;
	internal string endDebug;
	internal string connectionDescription;

	public ConnectionState State { get; }
	public NetAddress Address { get; }


	public ConnectionState get_State() { }

	public NetAddress get_Address() { }

}

public struct ConnectionLaneStatus // TypeDefIndex: 5553
{
	internal int cbPendingUnreliable;
	internal int cbPendingReliable;
	internal int cbSentUnackedReliable;
	internal int _reservePad1;
	internal long ecQueueTime;
	internal uint[] reserved;

}

public struct ConnectionStatus // TypeDefIndex: 5554
{
	internal ConnectionState state;
	internal int ping;
	internal float connectionQualityLocal;
	internal float connectionQualityRemote;
	internal float outPacketsPerSec;
	internal float outBytesPerSec;
	internal float inPacketsPerSec;
	internal float inBytesPerSec;
	internal int sendRateBytesPerSecond;
	internal int cbPendingUnreliable;
	internal int cbPendingReliable;
	internal int cbSentUnackedReliable;
	internal long ecQueueTime;
	internal uint[] reserved;

	public int Ping { get; }
	public float OutBytesPerSec { get; }
	public float InBytesPerSec { get; }
	public float ConnectionQualityLocal { get; }
	public int PendingUnreliable { get; }
	public int PendingReliable { get; }


	public int get_Ping() { }

	public float get_OutBytesPerSec() { }

	public float get_InBytesPerSec() { }

	public float get_ConnectionQualityLocal() { }

	public int get_PendingUnreliable() { }

	public int get_PendingReliable() { }

}

public class Connection // TypeDefIndex: 6858
{
	private static MemoryStream reusableStream;
	protected MemoryStream recordStream;
	protected BinaryWriter recordWriter;
	protected Stopwatch recordTime;
	protected string recordFilename;
	protected IDemoHeader recordHeader;
	public Connection.State state;
	public bool active;
	public bool connected;
	public uint authLevel;
	public uint encryptionLevel;
	public bool decryptIncoming;
	public bool encryptOutgoing;
	public bool trusted;
	public bool rejected;
	public string authStatus;
	public byte[] token;
	public bool hasRequestedWorld;
	public ulong guid;
	public ulong userid;
	public ulong ownerid;
	public string username;
	public string os;
	public uint protocol;
	private TimeAverageValueData[] packetsPerSecond;
	public double connectionTime;
	public string ipaddress;
	public MonoBehaviour player;
	public Connection.Validation validate;
	public Connection.ClientInfo info;

	public TimeSpan RecordTimeElapsed { get; }
	public string RecordFilename { get; }
	public int RecordFilesize { get; }
	public bool IsRecording { get; }
	public bool isAuthenticated { get; }


	public TimeSpan get_RecordTimeElapsed() { }

	public string get_RecordFilename() { }

	public int get_RecordFilesize() { }

	public bool StartRecording(string targetFilename, IDemoHeader header) { }

	public void StopRecording() { }

	public bool get_IsRecording() { }

	public void RecordPacket(byte packetId, IProto proto) { }

	public void RecordPacket(Stream stream) { }

	public string IPAddressWithoutPort() { }

	public virtual void OnDisconnected() { }

	public bool get_isAuthenticated() { }

	public void ResetPacketsPerSecond() { }

	public void AddPacketsPerSecond(Message.Type message) { }

	public void AddPacketsPerSecond(int index = 0) { }

	public ulong GetPacketsPerSecond(Message.Type message) { }

	public ulong GetPacketsPerSecond(int index = 0) { }

	public float GetSecondsConnected() { }

	public override string ToString() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum Connection.State // TypeDefIndex: 6859
{
	public int value__;
	public const Connection.State Unconnected = 0;
	public const Connection.State Connecting = 1;
	public const Connection.State InQueue = 2;
	public const Connection.State Welcoming = 3;
	public const Connection.State Connected = 4;
	public const Connection.State Disconnected = 5;

}

public struct Connection.Validation // TypeDefIndex: 6860
{
	public uint entityUpdates;

}

public class Connection.ClientInfo // TypeDefIndex: 6861
{
	public Dictionary<string, string> info;


	public void Set(string k, string v) { }

	public string GetString(string k, string def = "") { }

	public float GetFloat(string k, float def = 0) { }

	public int GetInt(string k, int def = 0) { }

	public bool GetBool(string k, bool def = False) { }

	public void .ctor() { }

}

public class NetRead : Stream // TypeDefIndex: 6871
{
	public const int MaxPacketSize = 6291456;
	public const int MaxBufferSize = 8388608;
	public byte[] Data;
	public long _length;
	public long _position;
	private const int bufferSize = 8388608;
	private static byte[] byteBuffer;
	private static char[] charBuffer;

	public int Unread { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanSeek { get; }


	public bool Start(IntPtr data, int length) { }

	public int get_Unread() { }

	public string String(int maxLength = 256) { }

	public string StringMultiLine(int maxLength = 2048) { }

	private string StringInternal(int maxLength, bool allowNewLine) { }

	public string StringRaw(uint maxLength = 8388608) { }

	public bool TemporaryBytesWithSize(out byte[] buffer, out int size) { }

	public uint EntityID() { }

	public uint GroupID() { }

	public int BytesWithSize(byte[] buffer, uint maxLength = 4294967295) { }

	public byte[] BytesWithSize(uint maxSize = 10485760) { }

	public override int ReadByte() { }

	public override bool get_CanRead() { }

	public override bool get_CanWrite() { }

	public override void SetLength(long value) { }

	public byte PacketID() { }

	public bool Bit() { }

	public byte UInt8() { }

	public ushort UInt16() { }

	public uint UInt32() { }

	public ulong UInt64() { }

	public sbyte Int8() { }

	public short Int16() { }

	public int Int32() { }

	public long Int64() { }

	public float Float() { }

	public double Double() { }

	public Vector3 Vector3() { }

	public Quaternion Quaternion() { }

	public Ray Ray() { }

	public Color Color() { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

	public override bool get_CanSeek() { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public T Read<T>() { }
	/* GenericInstMethod :
	|
	|-NetRead.Read<byte>
	|-NetRead.Read<sbyte>
	|
	|-NetRead.Read<double>
	|
	|-NetRead.Read<short>
	|-NetRead.Read<ushort>
	|
	|-NetRead.Read<int>
	|-NetRead.Read<uint>
	|
	|-NetRead.Read<long>
	|-NetRead.Read<ulong>
	|
	|-NetRead.Read<float>
	|
	|-NetRead.Read<Color>
	|-NetRead.Read<Quaternion>
	|
	|-NetRead.Read<Ray>
	|
	|-NetRead.Read<Vector3>
	*/

	public override void Flush() { }

	public override void Write(byte[] buffer, int offset, int count) { }

	public override void WriteByte(byte value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class NetWrite : MemoryStream // TypeDefIndex: 6872
{
	private static MemoryStream buffer;
	private BaseNetwork netwrite;
	private byte[] data;
	private int position;
	private int length;

	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }


	public void .ctor(BaseNetwork netwrite) { }

	public void Shutdown() { }

	public bool Start() { }

	public void Send(SendInfo info) { }

	public void PacketID(Message.Type val) { }

	public void UInt8(byte val) { }

	public void UInt16(ushort val) { }

	public void UInt32(uint val) { }

	public void UInt64(ulong val) { }

	public void Int8(sbyte val) { }

	public void Int16(short val) { }

	public void Int32(int val) { }

	public void Int64(long val) { }

	public void Bool(bool val) { }

	public void Float(float val) { }

	public void Double(double val) { }

	public void Bytes(byte[] val) { }

	public void String(string val) { }

	public void Vector3(in Vector3 obj) { }

	public void Quaternion(in Quaternion obj) { }

	public void Ray(in Ray obj) { }

	public void Color(in Color obj) { }

	public void EntityID(uint id) { }

	public void GroupID(uint id) { }

	public void BytesWithSize(MemoryStream val) { }

	public void BytesWithSize(byte[] b) { }

	public void BytesWithSize(byte[] b, int length) { }

	private void Write<T>(in T val) { }
	/* GenericInstMethod :
	|
	|-NetWrite.Write<byte>
	|-NetWrite.Write<sbyte>
	|
	|-NetWrite.Write<double>
	|-NetWrite.Write<long>
	|-NetWrite.Write<ulong>
	|
	|-NetWrite.Write<short>
	|-NetWrite.Write<ushort>
	|
	|-NetWrite.Write<int>
	|-NetWrite.Write<float>
	|-NetWrite.Write<uint>
	*/

	private void EnsureCapacity(int spaceRequired) { }

	public override byte[] GetBuffer() { }

	public override bool get_CanSeek() { }

	public override bool get_CanRead() { }

	public override bool get_CanWrite() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

	public override void Flush() { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public override int ReadByte() { }

	public override void Write(byte[] buffer, int offset, int count) { }

	public override void WriteByte(byte value) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void SetLength(long value) { }

	private static void .cctor() { }

}

public class Networkable : Pool.IPooled // TypeDefIndex: 6876
{
	public uint ID;
	[CompilerGeneratedAttribute]
	private Connection <connection>k__BackingField;
	public Group group;
	public Group secondaryGroup;
	public Subscriber subscriber;
	public NetworkHandler handler;
	private bool updateSubscriptions;
	internal Server sv;
	internal Client cl;

	public Connection connection { get; set; }


	[CompilerGeneratedAttribute]
	public Connection get_connection() { }

	[CompilerGeneratedAttribute]
	private void set_connection(Connection value) { }

	public void Destroy() { }

	public void EnterPool() { }

	public void LeavePool() { }

	public void StartSubscriber() { }

	public void OnConnected(Connection c) { }

	public void OnDisconnected() { }

	public void CloseSubscriber() { }

	public bool UpdateGroups(Vector3 position) { }

	public bool SwitchGroup(Group newGroup) { }

	internal void OnGroupTransition(Group oldGroup) { }

	internal void OnSubscriptionChange() { }

	public bool SwitchSecondaryGroup(Group newGroup) { }

	private void AddVisibleFromNear(Group additionalGroup, List<Group> groupsVisible) { }

	public bool UpdateSubscriptions(int removeLimit, int addLimit) { }

	public bool UpdateHighPrioritySubscriptions() { }

	public void .ctor() { }

}

public class QueuedStream : Stream // TypeDefIndex: 6956
{
	private readonly Stream _stream;
	private readonly Queue<QueuedStream.WriteData> _queue;
	private int _pendingWrite;
	private bool _disposed;

	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }


	public void .ctor(Stream stream) { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override void set_Position(long value) { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void SetLength(long value) { }

	public override void Write(byte[] buffer, int offset, int count) { }

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	public override int EndRead(IAsyncResult asyncResult) { }

	public override void EndWrite(IAsyncResult asyncResult) { }

	public override void Flush() { }

	public override void Close() { }

	protected override void Dispose(bool disposing) { }

	private IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, QueuedStream.WriteData queued) { }

}

private class QueuedStream.WriteData // TypeDefIndex: 6957
{
	public readonly byte[] Buffer;
	public readonly int Offset;
	public readonly int Count;
	public readonly AsyncCallback Callback;
	public readonly object State;
	public readonly QueuedStream.QueuedWriteResult AsyncResult;


	public void .ctor(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

}

private class QueuedStream.QueuedWriteResult : IAsyncResult // TypeDefIndex: 6958
{
	private readonly object _state;
	[CompilerGeneratedAttribute]
	private Exception <Exception>k__BackingField;
	[CompilerGeneratedAttribute]
	private IAsyncResult <ActualResult>k__BackingField;

	public Exception Exception { get; set; }
	public IAsyncResult ActualResult { get; set; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }


	public void .ctor(object state) { }

	[CompilerGeneratedAttribute]
	public Exception get_Exception() { }

	[CompilerGeneratedAttribute]
	public void set_Exception(Exception value) { }

	[CompilerGeneratedAttribute]
	public IAsyncResult get_ActualResult() { }

	[CompilerGeneratedAttribute]
	public void set_ActualResult(IAsyncResult value) { }

	public object get_AsyncState() { }

	public WaitHandle get_AsyncWaitHandle() { }

	public bool get_CompletedSynchronously() { }

	public bool get_IsCompleted() { }

}

private sealed class QueuedStream.<>c__DisplayClass27_0 // TypeDefIndex: 6959
{
	public QueuedStream.WriteData queued;
	public QueuedStream <>4__this;
	public AsyncCallback callback;


	public void .ctor() { }

	internal void <BeginWriteInternal>

}

public class NetGraph : SingletonComponent<NetGraph> // TypeDefIndex: 7117
{
	public CanvasGroup group;
	public GameObject rootPanel;
	private NetGraphRow[] rows;

	public bool Enabled { set; }


	public void Start() { }

	public void set_Enabled(bool value) { }

	public void UpdateFrom(Stats incomingStats) { }

	public void .ctor() { }

}

private sealed class NetGraph.<>c // TypeDefIndex: 7118
{
	public static readonly NetGraph.<>c <>9;
	public static Func<KeyValuePair<string, Stats.Node>, long> <>9__6_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal long <UpdateFrom>

}

public class NetGraphItem : MonoBehaviour // TypeDefIndex: 7119
{
	public CanvasGroup group;
	public LayoutElement element;
	public Text countTotal;
	public Text label;
	public Text bytes;


	internal void Hide() { }

	internal void UpdateFrom(KeyValuePair<string, Stats.Node> node) { }

	public void .ctor() { }

}

public class NetGraphRow : MonoBehaviour // TypeDefIndex: 7120
{
	public CanvasGroup group;
	public Text countTotal;
	public Text countUnique;
	public Text label;
	public Text bytes;
	public GameObject RowContainer;
	public NetGraphItem[] Items;
	public GameObject RowSpacer;


	private void Awake() { }

	internal void Hide() { }

	internal void UpdateFrom(KeyValuePair<string, Stats.Node> node) { }

	public void .ctor() { }

}

private sealed class NetGraphRow.<>c // TypeDefIndex: 7121
{
	public static readonly NetGraphRow.<>c <>9;
	public static Func<KeyValuePair<string, Stats.Node>, long> <>9__10_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal long <UpdateFrom>

}

public class Net // TypeDefIndex: 8248
{
	[CompilerGeneratedAttribute]
	private static Client <cl>k__BackingField;
	public static Client ClientNetwork;
	public static DemoClient DemoClientNetwork;

	public static Client cl { get; set; }


	[CompilerGeneratedAttribute]
	public static Client get_cl() { }

	[CompilerGeneratedAttribute]
	private static void set_cl(Client value) { }

	public static void ClientInit(Client newclient) { }

	public static void StartDemoPlayback(Reader demo) { }

	public static void StopDemoPlayback() { }

	public void .ctor() { }

}

public enum ConnectionClosedReason // TypeDefIndex: 8954
{
	public int value__;
	public const ConnectionClosedReason Unknown = 0;
	public const ConnectionClosedReason ClosedByLocalUser = 1;
	public const ConnectionClosedReason ClosedByPeer = 2;
	public const ConnectionClosedReason TimedOut = 3;
	public const ConnectionClosedReason TooManyConnections = 4;
	public const ConnectionClosedReason InvalidMessage = 5;
	public const ConnectionClosedReason InvalidData = 6;
	public const ConnectionClosedReason ConnectionFailed = 7;
	public const ConnectionClosedReason ConnectionClosed = 8;
	public const ConnectionClosedReason NegotiationFailed = 9;
	public const ConnectionClosedReason UnexpectedError = 10;

}

public enum ConnectionEstablishedType // TypeDefIndex: 8955
{
	public int value__;
	public const ConnectionEstablishedType NewConnection = 0;
	public const ConnectionEstablishedType Reconnection = 1;

}

public enum NetworkConnectionType // TypeDefIndex: 8967
{
	public int value__;
	public const NetworkConnectionType NoConnection = 0;
	public const NetworkConnectionType DirectConnection = 1;
	public const NetworkConnectionType RelayedConnection = 2;

}

public enum NetworkStatus // TypeDefIndex: 9876
{
	public int value__;
	public const NetworkStatus Disabled = 0;
	public const NetworkStatus Offline = 1;
	public const NetworkStatus Online = 2;

}

public class NetworkInfoGeneralText : MonoBehaviour // TypeDefIndex: 11024
{
	public TextMeshProUGUI text;


	private void Update() { }

	private void UpdateText() { }

	private static string ChannelStat(int window, int left) { }

	public void .ctor() { }

}

public abstract class NetworkCryptography : INetworkCryptocraphy // TypeDefIndex: 11990
{
	private byte[] buffer;


	public ArraySegment<byte> EncryptCopy(Connection connection, ArraySegment<byte> data) { }

	public ArraySegment<byte> DecryptCopy(Connection connection, ArraySegment<byte> data) { }

	public void Encrypt(Connection connection, ref ArraySegment<byte> data) { }

	public void Decrypt(Connection connection, ref ArraySegment<byte> data) { }

	public bool IsEnabledIncoming(Connection connection) { }

	public bool IsEnabledOutgoing(Connection connection) { }

	protected abstract void EncryptionHandler(Connection connection, ArraySegment<byte> src, ref ArraySegment<byte> dst);

	protected abstract void DecryptionHandler(Connection connection, ArraySegment<byte> src, ref ArraySegment<byte> dst);

	protected void .ctor() { }

}

public class NetworkCryptographyClient : NetworkCryptography // TypeDefIndex: 11991
{

	protected override void EncryptionHandler(Connection connection, ArraySegment<byte> src, ref ArraySegment<byte> dst) { }

	protected override void DecryptionHandler(Connection connection, ArraySegment<byte> src, ref ArraySegment<byte> dst) { }

	public void .ctor() { }

}

public class NetworkVisibilityGrid : MonoBehaviour // TypeDefIndex: 11992
{
	public const int overworldLayer = 0;
	public const int cavesLayer = 1;
	public const int tunnelsLayer = 2;
	public const int dynamicDungeonsFirstLayer = 10;
	public int startID;
	public int gridSize;
	public int cellCount;
	[FormerlySerializedAsAttribute]
	public int visibilityRadiusFar;
	public int visibilityRadiusNear;
	public float switchTolerance;
	public float cavesThreshold;
	public float tunnelsThreshold;
	public float dynamicDungeonsThreshold;
	public float dynamicDungeonsInterval;


	public void .ctor() { }

}

public class ConnectionAuth : MonoBehaviour // TypeDefIndex: 12467
{

	public void .ctor() { }

}

public class ConnectionQueue // TypeDefIndex: 12468
{

	public void .ctor() { }

}

public class ConnectionScreen : SingletonComponent<ConnectionScreen> // TypeDefIndex: 12886
{
	public Text statusText;
	public GameObject disconnectButton;
	public GameObject retryButton;
	public ServerBrowserInfo browserInfo;
	internal Nullable<ServerInfo> currentServer;
	internal Dictionary<string, string> currentServerRules;


	public static void Show() { }

	public static void UpdateServer(ServerInfo server) { }

	public static void FailedWith(string str) { }

	public static void FailedWithException(Exception e) { }

	public static void SetStatus(string status) { }

	public static void DisconnectReason(string str) { }

	public void RetryConnection() { }

	[AsyncStateMachineAttribute]
	public static void LoadServerInfo(string address, int port, bool addToHistory = False) { }

	[AsyncStateMachineAttribute]
	private static void LoadServerRules() { }

	private static void OnServerInfoChanged() { }

	public void .ctor() { }

}

private struct ConnectionScreen.<LoadServerInfo>d__13 : IAsyncStateMachine // TypeDefIndex: 12887
{
	public int <>1__state;
	public AsyncVoidMethodBuilder <>t__builder;
	public string address;
	public int port;
	public bool addToHistory;
	private TaskAwaiter<Nullable<ServerInfo>> <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ConnectionScreen.<LoadServerRules>d__14 : IAsyncStateMachine // TypeDefIndex: 12888
{
	public int <>1__state;
	public AsyncVoidMethodBuilder <>t__builder;
	private TaskAwaiter<Dictionary<string, string>> <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class NetworkSleep : MonoBehaviour // TypeDefIndex: 13117
{
	public static int totalBehavioursDisabled;
	public static int totalCollidersDisabled;
	public Behaviour[] behaviours;
	public Collider[] colliders;
	internal int BehavioursDisabled;
	internal int CollidersDisabled;


	public void .ctor() { }

	private static void .cctor() { }

}

public static class NetworkWriteEx // TypeDefIndex: 13152
{

	[ExtensionAttribute]
	public static void WriteObject<T>(NetWrite write, T obj) { }
	/* GenericInstMethod :
	|
	|-NetworkWriteEx.WriteObject<bool>
	|
	|-NetworkWriteEx.WriteObject<byte>
	|
	|-NetworkWriteEx.WriteObject<int>
	|
	|-NetworkWriteEx.WriteObject<object>
	|
	|-NetworkWriteEx.WriteObject<sbyte>
	|
	|-NetworkWriteEx.WriteObject<float>
	|
	|-NetworkWriteEx.WriteObject<uint>
	|
	|-NetworkWriteEx.WriteObject<ulong>
	|
	|-NetworkWriteEx.WriteObject<Color>
	|
	|-NetworkWriteEx.WriteObject<Ray>
	|
	|-NetworkWriteEx.WriteObject<Vector3>
	*/

}

public class NetworkedProperty<T> // TypeDefIndex: 13233
{
	private T val;
	private BaseEntity entity;

	public T Value { get; set; }


	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-NetworkedProperty<int>.get_Value
	|
	|-NetworkedProperty<object>.get_Value
	*/

	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-NetworkedProperty<int>.set_Value
	|
	|-NetworkedProperty<object>.set_Value
	*/

	public void .ctor(BaseEntity entity) { }
	/* GenericInstMethod :
	|
	|-NetworkedProperty<int>..ctor
	|-NetworkedProperty<object>..ctor
	*/

	public static T op_Implicit(NetworkedProperty<T> value) { }
	/* GenericInstMethod :
	|
	|-NetworkedProperty<int>.op_Implicit
	|-NetworkedProperty<object>.op_Implicit
	*/

}

public sealed class ProxyArray : Variant, IEnumerable<Variant>, IEnumerable // TypeDefIndex: 13386
{
	private readonly List<Variant> list;

	public override Variant Item { get; set; }
	public int Count { get; }


	public void .ctor() { }

	private IEnumerator<Variant> System.Collections.Generic.IEnumerable<TinyJSON.Variant>.GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void Add(Variant item) { }

	public override Variant get_Item(int index) { }

	public override void set_Item(int index, Variant value) { }

	public int get_Count() { }

	internal bool CanBeMultiRankArray(int[] rankLengths) { }

	private bool CanBeMultiRankArray(int rank, int[] rankLengths) { }

}

public sealed class ProxyBoolean : Variant // TypeDefIndex: 13387
{
	private readonly bool value;


	public void .ctor(bool value) { }

	public override bool ToBoolean(IFormatProvider provider) { }

	public override string ToString(IFormatProvider provider) { }

}

public sealed class ProxyNumber : Variant // TypeDefIndex: 13388
{
	private static readonly char[] floatingPointCharacters;
	private readonly IConvertible value;


	public void .ctor(IConvertible value) { }

	private static IConvertible Parse(string value) { }

	public override bool ToBoolean(IFormatProvider provider) { }

	public override byte ToByte(IFormatProvider provider) { }

	public override char ToChar(IFormatProvider provider) { }

	public override Decimal ToDecimal(IFormatProvider provider) { }

	public override double ToDouble(IFormatProvider provider) { }

	public override short ToInt16(IFormatProvider provider) { }

	public override int ToInt32(IFormatProvider provider) { }

	public override long ToInt64(IFormatProvider provider) { }

	public override sbyte ToSByte(IFormatProvider provider) { }

	public override float ToSingle(IFormatProvider provider) { }

	public override string ToString(IFormatProvider provider) { }

	public override ushort ToUInt16(IFormatProvider provider) { }

	public override uint ToUInt32(IFormatProvider provider) { }

	public override ulong ToUInt64(IFormatProvider provider) { }

	private static void .cctor() { }

}

public sealed class ProxyObject : Variant, IEnumerable<KeyValuePair<string, Variant>>, IEnumerable // TypeDefIndex: 13389
{
	public const string TypeHintKey = "@type";
	private readonly Dictionary<string, Variant> dict;

	public string TypeHint { get; }
	public override Variant Item { get; set; }
	public int Count { get; }
	public Dictionary.KeyCollection<string, Variant> Keys { get; }
	public Dictionary.ValueCollection<string, Variant> Values { get; }


	public void .ctor() { }

	private IEnumerator<KeyValuePair<string, Variant>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,TinyJSON.Variant>>.GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void Add(string key, Variant item) { }

	public bool TryGetValue(string key, out Variant item) { }

	public string get_TypeHint() { }

	public override Variant get_Item(string key) { }

	public override void set_Item(string key, Variant value) { }

	public int get_Count() { }

	public Dictionary.KeyCollection<string, Variant> get_Keys() { }

	public Dictionary.ValueCollection<string, Variant> get_Values() { }

}

public sealed class ProxyString : Variant // TypeDefIndex: 13390
{
	private readonly string value;


	public void .ctor(string value) { }

	public override string ToString(IFormatProvider provider) { }

}

public class ConnectionLimiter // TypeDefIndex: 13449
{
	private readonly object _sync;
	private readonly Dictionary<IPAddress, int> _addressCounts;
	private int _overallCount;


	public void .ctor() { }

	public bool TryAdd(IPAddress address) { }

	public void Remove(IPAddress address) { }

	public void Clear() { }

	public override string ToString() { }

}

private sealed class ConnectionLimiter.<>c // TypeDefIndex: 13450
{
	public static readonly ConnectionLimiter.<>c <>9;
	public static Func<KeyValuePair<IPAddress, int>, int> <>9__7_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal int <ToString>

}

public static class NetworkPacketEx // TypeDefIndex: 13507
{

[ExtensionAttribute]
public static class NetworkPacketEx

	[ExtensionAttribute]
	public static BasePlayer Player(Message v) { }

}

public class Net : ConsoleSystem // TypeDefIndex: 13751
{
	[ServerVar]
	public static bool visdebug;
	[ClientVar]
	public static bool debug;
	[ServerVar]
	public static int visibilityRadiusFarOverride;
	[ServerVar]
	public static int visibilityRadiusNearOverride;


	public void .ctor() { }

	private static void .cctor() { }

}

public class Netgraph : ConsoleSystem // TypeDefIndex: 13752
{
	[ClientVar]
	public static bool enabled;
	[ClientVar]
	public static float updatespeed;
	[ClientVar]
	public static string typefilter;
	[ClientVar]
	public static string entityfilter;


	public void .ctor() { }

	private static void .cctor() { }

}

