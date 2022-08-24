public static class Volatile // TypeDefIndex: 836
{

	[ReliabilityContractAttribute] 
public static bool Read(ref bool location) { }

	[ReliabilityContractAttribute] 
public static int Read(ref int location) { }

	[ReliabilityContractAttribute] 
public static T Read<T>(ref T location) { }
/* GenericInstMethod :
|
|-Volatile.Read<object>
*/

	[ReliabilityContractAttribute] 
public static void Write(ref bool location, bool value) { }

	[ReliabilityContractAttribute] 
public static void Write(ref int location, int value) { }

	[ReliabilityContractAttribute] 
public static void Write<T>(ref T location, T value) { }
/* GenericInstMethod :
|
|-Volatile.Write<object>
*/

}

