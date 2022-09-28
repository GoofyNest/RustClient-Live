public static class Interlocked // TypeDefIndex: 824
{

	[ReliabilityContractAttribute] 
	public static int CompareExchange(ref int location1, int value, int comparand) { }

	[ReliabilityContractAttribute] 
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	[ReliabilityContractAttribute] 
	public static object CompareExchange(ref object location1, object value, object comparand) { }

	public static float CompareExchange(ref float location1, float value, float comparand) { }

	[ReliabilityContractAttribute] 
	public static int Decrement(ref int location) { }

	[ReliabilityContractAttribute] 
	public static int Increment(ref int location) { }

	[ReliabilityContractAttribute] 
	public static long Increment(ref long location) { }

	[ReliabilityContractAttribute] 
	public static int Exchange(ref int location1, int value) { }

	[ReliabilityContractAttribute] 
	public static object Exchange(ref object location1, object value) { }

	public static float Exchange(ref float location1, float value) { }

	public static long CompareExchange(ref long location1, long value, long comparand) { }

	[ReliabilityContractAttribute] 
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand) { }

	public static double CompareExchange(ref double location1, double value, double comparand) { }

	[ReliabilityContractAttribute] 
	[ComVisibleAttribute] 
	public static T CompareExchange<T>(ref T location1, T value, T comparand) { }
	/* GenericInstMethod :
	|
	|-Interlocked.CompareExchange<object>
	*/

	public static long Exchange(ref long location1, long value) { }

	[ReliabilityContractAttribute] 
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) { }

	public static double Exchange(ref double location1, double value) { }

	[ReliabilityContractAttribute] 
	[ComVisibleAttribute] 
	public static T Exchange<T>(ref T location1, T value) { }
	/* GenericInstMethod :
	|
	|-Interlocked.Exchange<object>
	*/

	public static long Read(ref long location) { }

	[ReliabilityContractAttribute] 
	public static int Add(ref int location1, int value) { }

	public static void MemoryBarrier() { }

}

