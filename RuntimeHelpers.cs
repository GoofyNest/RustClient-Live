public static class RuntimeHelpers // TypeDefIndex: 1317
{
	public static int OffsetToStringData { get; }


	private static void InitializeArray(Array array, IntPtr fldHandle) { }

	public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle) { }

	public static int get_OffsetToStringData() { }

	public static int GetHashCode(object o) { }

	[ReliabilityContractAttribute] 
	[MonoTODOAttribute] 
	public static void PrepareConstrainedRegions() { }

	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RCon.Command>
	|
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Connection>
	|
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<int, int>>
	|
	|-RuntimeHelpers.IsReferenceOrContainsReferences<int>
	|
	|-RuntimeHelpers.IsReferenceOrContainsReferences<long>
	|
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IntPtr>
	|
	|-RuntimeHelpers.IsReferenceOrContainsReferences<object>
	|
	|-RuntimeHelpers.IsReferenceOrContainsReferences<uint>
	|
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ulong>
	|
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SequenceNode.SequenceConstructPosContext>
	|
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Matrix4x4>
	|
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AsyncGPUReadbackRequest>
	|
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EventDispatcher.DispatchContext>
	|
	|-RuntimeHelpers.IsReferenceOrContainsReferences<EventDispatcher.EventRecord>
	|
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector2>
	|
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector3>
	*/

}

