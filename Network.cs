internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem // TypeDefIndex: 815
{	private WaitCallback callback; // 0x10
	private ExecutionContext context; // 0x18
	private object state; // 0x20
	internal static ContextCallback ccb; // 0x0


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
{	private object[] _array; // 0x10
	private int _head; // 0x18
	private int _tail; // 0x1C
	private int _size; // 0x20
	private int _growFactor; // 0x24
	private int _version; // 0x28
	private object _syncRoot; // 0x30

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
{	private Queue _q; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object currentElement; // 0x20

	public virtual object Current { get; }


	internal void .ctor(Queue q) { }

	public object Clone() { }

	public virtual bool MoveNext() { }

	public virtual object get_Current() { }

	public virtual void Reset() { }

}

public class NetworkCredential : ICredentials // TypeDefIndex: 2893
{	private string m_domain; // 0x10
	private string m_userName; // 0x18
	private SecureString m_password; // 0x20

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
public class NetworkStream : Stream // TypeDefIndex: 3044
	private Socket m_StreamSocket; // 0x28
	private bool m_Readable; // 0x30
	private bool m_Writeable; // 0x31
	private bool m_OwnsSocket; // 0x32
	private int m_CloseTimeout; // 0x34
	private bool m_CleanedUp; // 0x38
	private int m_CurrentReadTimeout; // 0x3C
	private int m_CurrentWriteTimeout; // 0x40

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
{	public int value__; // 0x0
	public const NetworkInterfaceComponent IPv4 = 0;
	public const NetworkInterfaceComponent IPv6 = 1;

}

public enum NetBiosNodeType // TypeDefIndex: 3076
{	public int value__; // 0x0
	public const NetBiosNodeType Unknown = 0;
	public const NetBiosNodeType Broadcast = 1;
	public const NetBiosNodeType Peer2Peer = 2;
	public const NetBiosNodeType Mixed = 4;
	public const NetBiosNodeType Hybrid = 8;

}

public class Queue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 3118
{	private T[] _array; // 0x0
	private int _head; // 0x0
	private int _tail; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0
	private object _syncRoot; // 0x0
	private const int MinimumGrow = 4;
	private const int GrowFactor = 200;

	public int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }


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
{	private readonly Queue<T> _q; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _currentElement; // 0x0

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


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
[ConfigurationCollectionAttribute] // RVA: 0xC0F60 Offset: 0xC0360 VA: 0x1800C0F60
[DefaultMemberAttribute] // RVA: 0xC0F60 Offset: 0xC0360 VA: 0x1800C0F60
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection // TypeDefIndex: 3170

	public void .ctor() { }

}

public sealed class ConnectionManagementSection : ConfigurationSection // TypeDefIndex: 3171
{	protected override ConfigurationPropertyCollection Properties { get; }


	public void .ctor() { }

	protected override ConfigurationPropertyCollection get_Properties() { }

}

public sealed class ProxyElement : ConfigurationElement // TypeDefIndex: 3173
{	protected override ConfigurationPropertyCollection Properties { get; }


	public void .ctor() { }

	protected override ConfigurationPropertyCollection get_Properties() { }

}

public sealed class NetSectionGroup : ConfigurationSectionGroup // TypeDefIndex: 3176
{
	public void .ctor() { }

}

public enum NetworkReachability // TypeDefIndex: 3358
{	public int value__; // 0x0
	public const NetworkReachability NotReachable = 0;
	public const NetworkReachability ReachableViaCarrierDataNetwork = 1;
	public const NetworkReachability ReachableViaLocalAreaNetwork = 2;

}

internal enum ConnectionChangeType // TypeDefIndex: 4143
{	public uint value__; // 0x0
	public const ConnectionChangeType Connected = 0;
	public const ConnectionChangeType Disconnected = 1;
	public const ConnectionChangeType ConfigChange = 2;

}

public enum ConnectionState // TypeDefIndex: 4173
{	public int value__; // 0x0
	public const ConnectionState Closed = 0;
	public const ConnectionState Open = 1;
	public const ConnectionState Connecting = 2;
	public const ConnectionState Executing = 4;
	public const ConnectionState Fetching = 8;
	public const ConnectionState Broken = 16;

}

public enum ConnectionState // TypeDefIndex: 5169
{	public int value__; // 0x0
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
{	public int value__; // 0x0
	public const NetConfigScope Global = 1;
	public const NetConfigScope SocketsInterface = 2;
	public const NetConfigScope ListenSocket = 3;
	public const NetConfigScope Connection = 4;

}

internal enum NetConfigType // TypeDefIndex: 5171
{	public int value__; // 0x0
	public const NetConfigType Int32 = 1;
	public const NetConfigType Int64 = 2;
	public const NetConfigType Float = 3;
	public const NetConfigType String = 4;
	public const NetConfigType Ptr = 5;

}

internal enum NetConfig // TypeDefIndex: 5172
{	public int value__; // 0x0
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
{	public int value__; // 0x0
	public const NetConfigResult BadValue = -1;
	public const NetConfigResult BadScopeObj = -2;
	public const NetConfigResult BufferTooSmall = -3;
	public const NetConfigResult OK = 1;
	public const NetConfigResult OKInherited = 2;

}

public enum NetDebugOutput // TypeDefIndex: 5174
{	public int value__; // 0x0
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
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IConnectionManager <Interface>k__BackingField; // 0x10
	public Connection Connection; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ConnectionInfo <ConnectionInfo>k__BackingField; // 0x20
	public bool Connected; // 0x2D8
	public bool Connecting; // 0x2D9

	public IConnectionManager Interface { get; set; }
	internal ConnectionInfo ConnectionInfo { set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public IConnectionManager get_Interface() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Interface(IConnectionManager value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

internal sealed class NetDebugFunc : MulticastDelegate // TypeDefIndex: 5179
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke([In] NetDebugOutput nType, [In] IntPtr pszMsg) { }

	public virtual IAsyncResult BeginInvoke([In] NetDebugOutput nType, [In] IntPtr pszMsg, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

internal struct NetKeyValue // TypeDefIndex: 5507
{	internal NetConfig Value; // 0x0
	internal NetConfigType DataType; // 0x4
	internal long Int64Value; // 0x8
	internal int Int32Value; // 0x8
	internal float FloatValue; // 0x8
	internal IntPtr PointerValue; // 0x8

}

public struct NetIdentity // TypeDefIndex: 5508
{	internal NetIdentity.IdentityType type; // 0x0
	internal int size; // 0x4
	internal ulong steamid; // 0x8
	internal NetAddress netaddress; // 0x8


	public override string ToString() { }

}

internal enum NetIdentity.IdentityType // TypeDefIndex: 5509
{	public int value__; // 0x0
	public const NetIdentity.IdentityType Invalid = 0;
	public const NetIdentity.IdentityType IPAddress = 1;
	public const NetIdentity.IdentityType GenericString = 2;
	public const NetIdentity.IdentityType GenericBytes = 3;
	public const NetIdentity.IdentityType SteamID = 16;

}

public struct NetAddress // TypeDefIndex: 5510
{	internal NetAddress.IPV4 ip; // 0x0
	internal ushort port; // 0x10

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

internal struct NetAddress.IPV4 // TypeDefIndex: 5511
{	internal ulong m_8zeros; // 0x0
	internal ushort m_0000; // 0x8
	internal ushort m_ffff; // 0xA
	internal byte ip0; // 0xC
	internal byte ip1; // 0xD
	internal byte ip2; // 0xE
	internal byte ip3; // 0xF

}

internal struct NetMsg // TypeDefIndex: 5512
{	internal IntPtr DataPtr; // 0x0
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


	internal static extern void InternalRelease(NetMsg* self) { }

}

public struct Connection : IEquatable<Connection> // TypeDefIndex: 5543
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <Id>k__BackingField; // 0x0

	public uint Id { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public uint get_Id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	public string DetailedStatus() { }

	public ConnectionStatus QuickStatus() { }

	public Result ConfigureConnectionLanes(int[] lanePriorities, ushort[] laneWeights) { }

}

public struct ConnectionInfo // TypeDefIndex: 5544
{	internal NetIdentity identity; // 0x0
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

	public ConnectionState State { get; }
	public NetAddress Address { get; }


	public ConnectionState get_State() { }

	public NetAddress get_Address() { }

}

public struct ConnectionLaneStatus // TypeDefIndex: 5545
{	internal int cbPendingUnreliable; // 0x0
	internal int cbPendingReliable; // 0x4
	internal int cbSentUnackedReliable; // 0x8
	internal int _reservePad1; // 0xC
	internal long ecQueueTime; // 0x10
	internal uint[] reserved; // 0x18

}

public struct ConnectionStatus // TypeDefIndex: 5546
{	internal ConnectionState state; // 0x0
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

public class Connection // TypeDefIndex: 6682
{	private static MemoryStream reusableStream; // 0x0
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

public enum Connection.State // TypeDefIndex: 6683
{	public int value__; // 0x0
	public const Connection.State Unconnected = 0;
	public const Connection.State Connecting = 1;
	public const Connection.State InQueue = 2;
	public const Connection.State Welcoming = 3;
	public const Connection.State Connected = 4;
	public const Connection.State Disconnected = 5;

}

public struct Connection.Validation // TypeDefIndex: 6684
{	public uint entityUpdates; // 0x0

}

public class Connection.ClientInfo // TypeDefIndex: 6685
{	public Dictionary<string, string> info; // 0x10


	public void Set(string k, string v) { }

	public string GetString(string k, string def = "") { }

	public float GetFloat(string k, float def = 0) { }

	public int GetInt(string k, int def = 0) { }

	public bool GetBool(string k, bool def = False) { }

	public void .ctor() { }

}

public class NetRead : Stream // TypeDefIndex: 6695
{	private MemoryStream _stream; // 0x28
	public byte[] Data; // 0x30
	public long _length; // 0x38
	public long _position; // 0x40
	private const int bufferSize = 1048576;
	private static byte[] byteBuffer; // 0x0
	private static char[] charBuffer; // 0x8

	public int Unread { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanSeek { get; }


	public MemoryStream GetStreamForDecryption() { }

	public bool Start(IntPtr data, int length) { }

	public int get_Unread() { }

	public string String(int maxLength = 256) { }

	public string StringMultiLine(int maxLength = 2048) { }

	private string StringInternal(int maxLength, bool allowNewLine) { }

	public string StringRaw(uint maxLength = 1048576) { }

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

	public override void Flush() { }

	public override void Write(byte[] buffer, int offset, int count) { }

	public override void WriteByte(byte value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class NetWrite : MemoryStream // TypeDefIndex: 6696
{	private static MemoryStream buffer; // 0x0
	private BaseNetwork netwrite; // 0x50
	private byte[] data; // 0x58
	private int position; // 0x60
	private int length; // 0x64

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

public class Networkable : Pool.IPooled // TypeDefIndex: 6700
{	public uint ID; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Connection <connection>k__BackingField; // 0x18
	public Group group; // 0x20
	public Group secondaryGroup; // 0x28
	public Subscriber subscriber; // 0x30
	public NetworkHandler handler; // 0x38
	private bool updateSubscriptions; // 0x40
	internal Server sv; // 0x48
	internal Client cl; // 0x50

	public Connection connection { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Connection get_connection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

public class QueuedStream : Stream // TypeDefIndex: 6916
{	private readonly Stream _stream; // 0x28
	private readonly Queue<QueuedStream.WriteData> _queue; // 0x30
	private int _pendingWrite; // 0x38
	private bool _disposed; // 0x3C

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

private class QueuedStream.WriteData // TypeDefIndex: 6917
{	public readonly byte[] Buffer; // 0x10
	public readonly int Offset; // 0x18
	public readonly int Count; // 0x1C
	public readonly AsyncCallback Callback; // 0x20
	public readonly object State; // 0x28
	public readonly QueuedStream.QueuedWriteResult AsyncResult; // 0x30


	public void .ctor(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

}

private class QueuedStream.QueuedWriteResult : IAsyncResult // TypeDefIndex: 6918
{	private readonly object _state; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Exception <Exception>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IAsyncResult <ActualResult>k__BackingField; // 0x20

	public Exception Exception { get; set; }
	public IAsyncResult ActualResult { get; set; }
	public object AsyncState { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }


	public void .ctor(object state) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Exception get_Exception() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Exception(Exception value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public IAsyncResult get_ActualResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_ActualResult(IAsyncResult value) { }

	public object get_AsyncState() { }

	public WaitHandle get_AsyncWaitHandle() { }

	public bool get_CompletedSynchronously() { }

	public bool get_IsCompleted() { }

}

private sealed class QueuedStream.<>c__DisplayClass27_0 // TypeDefIndex: 6919
{	public QueuedStream.WriteData queued; // 0x10
	public QueuedStream <>4__this; // 0x18
	public AsyncCallback callback; // 0x20


	public void .ctor() { }

	internal void <BeginWriteInternal>b__0(IAsyncResult ar) { }

}

public class NetGraph : SingletonComponent<NetGraph> // TypeDefIndex: 7075
{	public CanvasGroup group; // 0x18
	public GameObject rootPanel; // 0x20
	private NetGraphRow[] rows; // 0x28

	public bool Enabled { set; }


	public void Start() { }

	public void set_Enabled(bool value) { }

	public void UpdateFrom(Stats incomingStats) { }

	public void .ctor() { }

}

private sealed class NetGraph.<>c // TypeDefIndex: 7076
{	public static readonly NetGraph.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, Stats.Node>, long> <>9__6_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal long <UpdateFrom>b__6_0(KeyValuePair<string, Stats.Node> y) { }

}

public class NetGraphItem : MonoBehaviour // TypeDefIndex: 7077
{	public CanvasGroup group; // 0x18
	public LayoutElement element; // 0x20
	public Text countTotal; // 0x28
	public Text label; // 0x30
	public Text bytes; // 0x38


	internal void Hide() { }

	internal void UpdateFrom(KeyValuePair<string, Stats.Node> node) { }

	public void .ctor() { }

}

public class NetGraphRow : MonoBehaviour // TypeDefIndex: 7078
{	public CanvasGroup group; // 0x18
	public Text countTotal; // 0x20
	public Text countUnique; // 0x28
	public Text label; // 0x30
	public Text bytes; // 0x38
	public GameObject RowContainer; // 0x40
	public NetGraphItem[] Items; // 0x48
	public GameObject RowSpacer; // 0x50


	private void Awake() { }

	internal void Hide() { }

	internal void UpdateFrom(KeyValuePair<string, Stats.Node> node) { }

	public void .ctor() { }

}

private sealed class NetGraphRow.<>c // TypeDefIndex: 7079
{	public static readonly NetGraphRow.<>c <>9; // 0x0
	public static Func<KeyValuePair<string, Stats.Node>, long> <>9__10_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal long <UpdateFrom>b__10_0(KeyValuePair<string, Stats.Node> y) { }

}

internal sealed class NetProtect : INetProtect // TypeDefIndex: 7165
{
	public void .ctor(IntPtr Instance) { }

	public bool ProtectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

	public bool UnprotectMessage(MemoryStream Input, long InputOffset, MemoryStream Output, long OutputOffset) { }

}

public class Net // TypeDefIndex: 8228
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Client <cl>k__BackingField; // 0x0
	public static Client ClientNetwork; // 0x8
	public static DemoClient DemoClientNetwork; // 0x10

	public static Client cl { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static Client get_cl() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void set_cl(Client value) { }

	public static void ClientInit(Client newclient) { }

	public static void StartDemoPlayback(Reader demo) { }

	public static void StopDemoPlayback() { }

	public void .ctor() { }

}

public class NetworkInfoGeneralText : MonoBehaviour // TypeDefIndex: 9285
{	public TextMeshProUGUI text; // 0x18


	private void Update() { }

	private void UpdateText() { }

	private static string ChannelStat(int window, int left) { }

	public void .ctor() { }

}

public abstract class NetworkCryptography : INetworkCryptocraphy // TypeDefIndex: 10236
{	private MemoryStream buffer; // 0x10


	public MemoryStream EncryptCopy(Connection connection, MemoryStream stream, int offset) { }

	public MemoryStream DecryptCopy(Connection connection, MemoryStream stream, int offset) { }

	public void Encrypt(Connection connection, MemoryStream stream, int offset) { }

	public void Decrypt(Connection connection, MemoryStream stream, int offset) { }

	public bool IsEnabledIncoming(Connection connection) { }

	public bool IsEnabledOutgoing(Connection connection) { }

	protected abstract void EncryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset);

	protected abstract void DecryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset);

	protected void .ctor() { }

}

public class NetworkCryptographyClient : NetworkCryptography // TypeDefIndex: 10237
{
	protected override void EncryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	protected override void DecryptionHandler(Connection connection, MemoryStream src, int srcOffset, MemoryStream dst, int dstOffset) { }

	public void .ctor() { }

}

public class NetworkVisibilityGrid : MonoBehaviour // TypeDefIndex: 10238
{	public int startID; // 0x18
	public int gridSize; // 0x1C
	public int cellCount; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xBF140 Offset: 0xBE540 VA: 0x1800BF140
	public int visibilityRadiusFar; // 0x24
	public int visibilityRadiusNear; // 0x28
	public float switchTolerance; // 0x2C


	public void .ctor() { }

}

public class ConnectionAuth : MonoBehaviour // TypeDefIndex: 10708
{
	public void .ctor() { }

}

public class ConnectionQueue // TypeDefIndex: 10709
{
	public void .ctor() { }

}

public class ConnectionScreen : SingletonComponent<ConnectionScreen> // TypeDefIndex: 11095
{	public Text statusText; // 0x18
	public GameObject disconnectButton; // 0x20
	public GameObject retryButton; // 0x28
	public ServerBrowserInfo browserInfo; // 0x30
	internal Nullable<ServerInfo> currentServer; // 0x38
	internal Dictionary<string, string> currentServerRules; // 0xB8


	public static void Show() { }

	public static void UpdateServer(ServerInfo server) { }

	public static void FailedWith(string str) { }

	public static void FailedWithException(Exception e) { }

	public static void SetStatus(string status) { }

	public static void DisconnectReason(string str) { }

	public void RetryConnection() { }

	[AsyncStateMachineAttribute] // RVA: 0x95F40 Offset: 0x95340 VA: 0x180095F40
	public static void LoadServerInfo(string address, int port, bool addToHistory = False) { }

	[AsyncStateMachineAttribute] // RVA: 0x96080 Offset: 0x95480 VA: 0x180096080
	private static void LoadServerRules() { }

	private static void OnServerInfoChanged() { }

	public void .ctor() { }

}

private struct ConnectionScreen.<LoadServerInfo>d__13 : IAsyncStateMachine // TypeDefIndex: 11096
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public string address; // 0x28
	public int port; // 0x30
	public bool addToHistory; // 0x34
	private TaskAwaiter<Nullable<ServerInfo>> <>u__1; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ConnectionScreen.<LoadServerRules>d__14 : IAsyncStateMachine // TypeDefIndex: 11097
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class NetworkSleep : MonoBehaviour // TypeDefIndex: 11318
{	public static int totalBehavioursDisabled; // 0x0
	public static int totalCollidersDisabled; // 0x4
	public Behaviour[] behaviours; // 0x18
	public Collider[] colliders; // 0x20
	internal int BehavioursDisabled; // 0x28
	internal int CollidersDisabled; // 0x2C


	public void .ctor() { }

	private static void .cctor() { }

}

public static class NetworkWriteEx // TypeDefIndex: 11344
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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
{	private T val; // 0x0
	private BaseEntity entity; // 0x0

	public T Value { get; set; }


	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	|-NetworkedProperty<int>.get_Value
	|
	|-RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	|-NetworkedProperty<object>.get_Value
	*/

	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD54730 Offset: 0xD53B30 VA: 0x180D54730
	|-NetworkedProperty<int>.set_Value
	|
	|-RVA: 0xD546B0 Offset: 0xD53AB0 VA: 0x180D546B0
	|-NetworkedProperty<object>.set_Value
	*/

	public void .ctor(BaseEntity entity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD545E0 Offset: 0xD539E0 VA: 0x180D545E0
	|-NetworkedProperty<int>..ctor
	|-NetworkedProperty<object>..ctor
	*/

	public static T op_Implicit(NetworkedProperty<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD54620 Offset: 0xD53A20 VA: 0x180D54620
	|-NetworkedProperty<int>.op_Implicit
	|-NetworkedProperty<object>.op_Implicit
	*/

}

public sealed class ProxyArray : Variant, IEnumerable<Variant>, IEnumerable // TypeDefIndex: 11579
{	private readonly List<Variant> list; // 0x10

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

public sealed class ProxyBoolean : Variant // TypeDefIndex: 11580
{	private readonly bool value; // 0x10


	public void .ctor(bool value) { }

	public override bool ToBoolean(IFormatProvider provider) { }

	public override string ToString(IFormatProvider provider) { }

}

public sealed class ProxyNumber : Variant // TypeDefIndex: 11581
{	private static readonly char[] floatingPointCharacters; // 0x0
	private readonly IConvertible value; // 0x10


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

public sealed class ProxyObject : Variant, IEnumerable<KeyValuePair<string, Variant>>, IEnumerable // TypeDefIndex: 11582
{	public const string TypeHintKey = "@type";
	private readonly Dictionary<string, Variant> dict; // 0x10

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

public sealed class ProxyString : Variant // TypeDefIndex: 11583
{	private readonly string value; // 0x10


	public void .ctor(string value) { }

	public override string ToString(IFormatProvider provider) { }

}

public class ConnectionLimiter // TypeDefIndex: 11641
{	private readonly object _sync; // 0x10
	private readonly Dictionary<IPAddress, int> _addressCounts; // 0x18
	private int _overallCount; // 0x20


	public void .ctor() { }

	public bool TryAdd(IPAddress address) { }

	public void Remove(IPAddress address) { }

	public void Clear() { }

	public override string ToString() { }

}

private sealed class ConnectionLimiter.<>c // TypeDefIndex: 11642
{	public static readonly ConnectionLimiter.<>c <>9; // 0x0
	public static Func<KeyValuePair<IPAddress, int>, int> <>9__7_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <ToString>b__7_0(KeyValuePair<IPAddress, int> t) { }

}

public static class NetworkPacketEx // TypeDefIndex: 11699
{
[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public static class NetworkPacketEx // TypeDefIndex: 11699

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static BasePlayer Player(Message v) { }

}

public class Net : ConsoleSystem // TypeDefIndex: 11943
{	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool visdebug; // 0x0
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool debug; // 0x1
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int visibilityRadiusFarOverride; // 0x4
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int visibilityRadiusNearOverride; // 0x8


	public void .ctor() { }

	private static void .cctor() { }

}

public class Netgraph : ConsoleSystem // TypeDefIndex: 11944
{	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool enabled; // 0x0
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float updatespeed; // 0x4
	[ClientVar] // RVA: 0x89040 Offset: 0x88440 VA: 0x180089040
	public static string typefilter; // 0x8
	[ClientVar] // RVA: 0x89040 Offset: 0x88440 VA: 0x180089040
	public static string entityfilter; // 0x10


	public void .ctor() { }

	private static void .cctor() { }

}

