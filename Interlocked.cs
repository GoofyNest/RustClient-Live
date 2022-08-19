public static class Interlocked // TypeDefIndex: 824
{	// Methods

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x148F4D0 Offset: 0x148E8D0 VA: 0x18148F4D0
	public static int CompareExchange(ref int location1, int value, int comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x148F4B0 Offset: 0x148E8B0 VA: 0x18148F4B0
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x148F4C0 Offset: 0x148E8C0 VA: 0x18148F4C0
	public static object CompareExchange(ref object location1, object value, object comparand) { }

	// RVA: 0x148F490 Offset: 0x148E890 VA: 0x18148F490
	public static float CompareExchange(ref float location1, float value, float comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x148F4E0 Offset: 0x148E8E0 VA: 0x18148F4E0
	public static int Decrement(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x148F540 Offset: 0x148E940 VA: 0x18148F540
	public static int Increment(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x148F550 Offset: 0x148E950 VA: 0x18148F550
	public static long Increment(ref long location) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x148F530 Offset: 0x148E930 VA: 0x18148F530
	public static int Exchange(ref int location1, int value) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x148F500 Offset: 0x148E900 VA: 0x18148F500
	public static object Exchange(ref object location1, object value) { }

	// RVA: 0x148F510 Offset: 0x148E910 VA: 0x18148F510
	public static float Exchange(ref float location1, float value) { }

	// RVA: 0x148F480 Offset: 0x148E880 VA: 0x18148F480
	public static long CompareExchange(ref long location1, long value, long comparand) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x148F480 Offset: 0x148E880 VA: 0x18148F480
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand) { }

	// RVA: 0x148F4A0 Offset: 0x148E8A0 VA: 0x18148F4A0
	public static double CompareExchange(ref double location1, double value, double comparand) { }

	[ComVisibleAttribute] // RVA: 0xBB4E0 Offset: 0xBA8E0 VA: 0x1800BB4E0
	[ReliabilityContractAttribute] // RVA: 0xBB4E0 Offset: 0xBA8E0 VA: 0x1800BB4E0
	// RVA: -1 Offset: -1
	public static T CompareExchange<T>(ref T location1, T value, T comparand) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.CompareExchange<object>
	*/

	// RVA: 0x148F4F0 Offset: 0x148E8F0 VA: 0x18148F4F0
	public static long Exchange(ref long location1, long value) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x148F4F0 Offset: 0x148E8F0 VA: 0x18148F4F0
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) { }

	// RVA: 0x148F520 Offset: 0x148E920 VA: 0x18148F520
	public static double Exchange(ref double location1, double value) { }

	[ComVisibleAttribute] // RVA: 0xBB4E0 Offset: 0xBA8E0 VA: 0x1800BB4E0
	[ReliabilityContractAttribute] // RVA: 0xBB4E0 Offset: 0xBA8E0 VA: 0x1800BB4E0
	// RVA: -1 Offset: -1
	public static T Exchange<T>(ref T location1, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.Exchange<object>
	*/

	// RVA: 0x148F570 Offset: 0x148E970 VA: 0x18148F570
	public static long Read(ref long location) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x148F470 Offset: 0x148E870 VA: 0x18148F470
	public static int Add(ref int location1, int value) { }

	// RVA: 0x148F560 Offset: 0x148E960 VA: 0x18148F560
	public static void MemoryBarrier() { }

}

