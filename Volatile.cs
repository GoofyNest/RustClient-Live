public static class Volatile // TypeDefIndex: 836
{	// Methods

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1616C80 Offset: 0x1616080 VA: 0x181616C80
	public static bool Read(ref bool location) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1616CA0 Offset: 0x16160A0 VA: 0x181616CA0
	public static int Read(ref int location) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: -1 Offset: -1
	public static T Read<T>(ref T location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDBE60 Offset: 0xBDB260 VA: 0x180BDBE60
	|-Volatile.Read<object>
	*/

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1616CF0 Offset: 0x16160F0 VA: 0x181616CF0
	public static void Write(ref bool location, bool value) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1616CC0 Offset: 0x16160C0 VA: 0x181616CC0
	public static void Write(ref int location, int value) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: -1 Offset: -1
	public static void Write<T>(ref T location, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF048A0 Offset: 0xF03CA0 VA: 0x180F048A0
	|-Volatile.Write<object>
	*/

}

