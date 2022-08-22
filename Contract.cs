public static class Contract // TypeDefIndex: 1505
{
	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEA070 Offset: 0xBE9470 VA: 0x180BEA070
	|-Contract.ForAll<object>
	|-Contract.ForAll<Type>
	*/

}

