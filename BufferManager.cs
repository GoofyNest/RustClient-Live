internal static class BufferManager // TypeDefIndex: 5179
{
	private static readonly Stack<BufferManager.ReferenceCounter> ReferenceCounterPool; 
	private static readonly Dictionary<int, Stack<IntPtr>> BufferPools; 
	private static readonly Dictionary<IntPtr, BufferManager.ReferenceCounter> ReferenceCounters; 
	private static readonly BufferManager.FreeFn FreeFunctionPin; 
	public static readonly IntPtr FreeFunctionPointer; 


	public static IntPtr Get(int size, int referenceCount) { }

	[MonoPInvokeCallbackAttribute] 
	private static void Free(NetMsg* msg) { }

	private static BufferManager.ReferenceCounter AllocateReferenceCounter(IntPtr ptr, int size, int referenceCount) { }

	private static void FreeReferenceCounter(BufferManager.ReferenceCounter counter) { }

	private static void AllocateBuffer(int minimumSize, out IntPtr ptr, out int size) { }

	private static void FreeBuffer(IntPtr ptr, int size) { }

	private static int GetBucketSize(int size) { }

	private static int GetBucketLimit(int size) { }

	private static void .cctor() { }

}

private sealed class BufferManager.ReferenceCounter // TypeDefIndex: 5180
{
	[CompilerGeneratedAttribute] 
	private IntPtr <Pointer>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <Size>k__BackingField; 
	private int _count; 

	private IntPtr Pointer { set; }
	public int Size { get; set; }


	[CompilerGeneratedAttribute] 
	private void set_Pointer(IntPtr value) { }

	[CompilerGeneratedAttribute] 
	public int get_Size() { }

	[CompilerGeneratedAttribute] 
	private void set_Size(int value) { }

	public void Set(IntPtr ptr, int size, int referenceCount) { }

	public bool Decrement() { }

	public void .ctor() { }

}

private sealed class BufferManager.FreeFn : MulticastDelegate // TypeDefIndex: 5181
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(NetMsg* msg) { }

	public virtual IAsyncResult BeginInvoke(NetMsg* msg, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

