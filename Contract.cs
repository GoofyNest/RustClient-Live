public static class Contract // TypeDefIndex: 1505
{

	[ReliabilityContractAttribute] 
	public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate) { }
	/* GenericInstMethod :
	|
	|-Contract.ForAll<object>
	|-Contract.ForAll<Type>
	*/

}

