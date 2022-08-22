internal static class Helpers // TypeDefIndex: 5254
{	private static byte[][] BufferPool; // 0x0
	private static int BufferPoolIndex; // 0x8


	public static Helpers.Memory TakeMemory() { }

	public static byte[] TakeBuffer(int minSize) { }

	internal static string MemoryToString(IntPtr ptr) { }

	private static void .cctor() { }

}

internal struct Helpers.Memory : IDisposable // TypeDefIndex: 5255
{	private static readonly Queue<IntPtr> BufferBag; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IntPtr <Ptr>k__BackingField; // 0x0

	public IntPtr Ptr { get; set; }


	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public IntPtr get_Ptr() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Ptr(IntPtr value) { }

	public static IntPtr op_Implicit(in Helpers.Memory m) { }

	internal static Helpers.Memory Take() { }

	public void Dispose() { }

	private static void .cctor() { }

}

