internal static class Helpers // TypeDefIndex: 5254
{
	private static byte[][] BufferPool; 
	private static int BufferPoolIndex; 


	public static Helpers.Memory TakeMemory() { }

	public static byte[] TakeBuffer(int minSize) { }

	internal static string MemoryToString(IntPtr ptr) { }

	private static void .cctor() { }

}

internal struct Helpers.Memory : IDisposable // TypeDefIndex: 5255
{
	private static readonly Queue<IntPtr> BufferBag; 
	[CompilerGeneratedAttribute] 
	private IntPtr <Ptr>k__BackingField; 

	public IntPtr Ptr { get; set; }


	[IsReadOnlyAttribute] 
	[CompilerGeneratedAttribute] 
	public IntPtr get_Ptr() { }

	[CompilerGeneratedAttribute] 
	private void set_Ptr(IntPtr value) { }

	public static IntPtr op_Implicit(in Helpers.Memory m) { }

	internal static Helpers.Memory Take() { }

	public void Dispose() { }

	private static void .cctor() { }

}

