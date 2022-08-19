internal static class BufferManager // TypeDefIndex: 5175
{	// Fields
	private static readonly Stack<BufferManager.ReferenceCounter> ReferenceCounterPool; // 0x0
	private static readonly Dictionary<int, Stack<IntPtr>> BufferPools; // 0x8
	private static readonly Dictionary<IntPtr, BufferManager.ReferenceCounter> ReferenceCounters; // 0x10
	private static readonly BufferManager.FreeFn FreeFunctionPin; // 0x18
	public static readonly IntPtr FreeFunctionPointer; // 0x20

	// Methods

	// RVA: 0x1366900 Offset: 0x1365D00 VA: 0x181366900
	public static IntPtr Get(int size, int referenceCount) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1366560 Offset: 0x1365960 VA: 0x181366560
	private static void Free(NetMsg* msg) { }

	// RVA: 0x1365D80 Offset: 0x1365180 VA: 0x181365D80
	private static BufferManager.ReferenceCounter AllocateReferenceCounter(IntPtr ptr, int size, int referenceCount) { }

	// RVA: 0x13663A0 Offset: 0x13657A0 VA: 0x1813663A0
	private static void FreeReferenceCounter(BufferManager.ReferenceCounter counter) { }

	// RVA: 0x1365B20 Offset: 0x1364F20 VA: 0x181365B20
	private static void AllocateBuffer(int minimumSize, out IntPtr ptr, out int size) { }

	// RVA: 0x1366040 Offset: 0x1365440 VA: 0x181366040
	private static void FreeBuffer(IntPtr ptr, int size) { }

	// RVA: 0x13668A0 Offset: 0x1365CA0 VA: 0x1813668A0
	private static int GetBucketSize(int size) { }

	// RVA: 0x1366840 Offset: 0x1365C40 VA: 0x181366840
	private static int GetBucketLimit(int size) { }

	// RVA: 0x1366B00 Offset: 0x1365F00 VA: 0x181366B00
	private static void .cctor() { }

}

private sealed class BufferManager.ReferenceCounter // TypeDefIndex: 5176
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IntPtr <Pointer>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Size>k__BackingField; // 0x18
	private int _count; // 0x1C

	// Properties
	private IntPtr Pointer { set; }
	public int Size { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1160 Offset: 0x8B0560 VA: 0x1808B1160
	private void set_Pointer(IntPtr value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_Size() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20
	private void set_Size(int value) { }

	// RVA: 0x13702B0 Offset: 0x136F6B0 VA: 0x1813702B0
	public void Set(IntPtr ptr, int size, int referenceCount) { }

	// RVA: 0x1370230 Offset: 0x136F630 VA: 0x181370230
	public bool Decrement() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class BufferManager.FreeFn : MulticastDelegate // TypeDefIndex: 5177
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x121BB50 Offset: 0x121AF50 VA: 0x18121BB50 Slot: 12
	public virtual void Invoke(NetMsg* msg) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(NetMsg* msg, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

