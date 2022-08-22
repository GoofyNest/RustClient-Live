internal static class BufferManager // TypeDefIndex: 5175
{	private static readonly Stack<BufferManager.ReferenceCounter> ReferenceCounterPool; // 0x0
	private static readonly Dictionary<int, Stack<IntPtr>> BufferPools; // 0x8
	private static readonly Dictionary<IntPtr, BufferManager.ReferenceCounter> ReferenceCounters; // 0x10
	private static readonly BufferManager.FreeFn FreeFunctionPin; // 0x18
	public static readonly IntPtr FreeFunctionPointer; // 0x20


	public static IntPtr Get(int size, int referenceCount) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void Free(NetMsg* msg) { }

	private static BufferManager.ReferenceCounter AllocateReferenceCounter(IntPtr ptr, int size, int referenceCount) { }

	private static void FreeReferenceCounter(BufferManager.ReferenceCounter counter) { }

	private static void AllocateBuffer(int minimumSize, out IntPtr ptr, out int size) { }

	private static void FreeBuffer(IntPtr ptr, int size) { }

	private static int GetBucketSize(int size) { }

	private static int GetBucketLimit(int size) { }

	private static void .cctor() { }

}

private sealed class BufferManager.ReferenceCounter // TypeDefIndex: 5176
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IntPtr <Pointer>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Size>k__BackingField; // 0x18
	private int _count; // 0x1C

	private IntPtr Pointer { set; }
	public int Size { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Pointer(IntPtr value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_Size() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Size(int value) { }

	public void Set(IntPtr ptr, int size, int referenceCount) { }

	public bool Decrement() { }

	public void .ctor() { }

}

private sealed class BufferManager.FreeFn : MulticastDelegate // TypeDefIndex: 5177
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(NetMsg* msg) { }

	public virtual IAsyncResult BeginInvoke(NetMsg* msg, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

