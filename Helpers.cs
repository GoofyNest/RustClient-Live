internal static class Helpers // TypeDefIndex: 5254
{	// Fields
	private static byte[][] BufferPool; // 0x0
	private static int BufferPoolIndex; // 0x8

	// Methods

	// RVA: 0x1280110 Offset: 0x127F510 VA: 0x181280110
	public static Helpers.Memory TakeMemory() { }

	// RVA: 0x127FCD0 Offset: 0x127F0D0 VA: 0x18127FCD0
	public static byte[] TakeBuffer(int minSize) { }

	// RVA: 0x127FC10 Offset: 0x127F010 VA: 0x18127FC10
	internal static string MemoryToString(IntPtr ptr) { }

	// RVA: 0x1280160 Offset: 0x127F560 VA: 0x181280160
	private static void .cctor() { }

}

internal struct Helpers.Memory : IDisposable // TypeDefIndex: 5255
{	// Fields
	private static readonly Queue<IntPtr> BufferBag; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IntPtr <Ptr>k__BackingField; // 0x0

	// Properties
	public IntPtr Ptr { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public IntPtr get_Ptr() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D2D40 Offset: 0x1D2140 VA: 0x1801D2D40
	private void set_Ptr(IntPtr value) { }

	// RVA: 0x1288200 Offset: 0x1287600 VA: 0x181288200
	public static IntPtr op_Implicit(in Helpers.Memory m) { }

	// RVA: 0x1287FD0 Offset: 0x12873D0 VA: 0x181287FD0
	internal static Helpers.Memory Take() { }

	// RVA: 0x1D2F50 Offset: 0x1D2350 VA: 0x1801D2F50 Slot: 4
	public void Dispose() { }

	// RVA: 0x12881A0 Offset: 0x12875A0 VA: 0x1812881A0
	private static void .cctor() { }

}

