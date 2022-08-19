public static class LazyInitializer // TypeDefIndex: 757
{	// Methods

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDB6E0 Offset: 0xBDAAE0 VA: 0x180BDB6E0
	|-LazyInitializer.EnsureInitialized<object>
	|-LazyInitializer.EnsureInitialized<ManualResetEvent>
	|-LazyInitializer.EnsureInitialized<SemaphoreSlim>
	|-LazyInitializer.EnsureInitialized<Task.ContingentProperties>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDB620 Offset: 0xBDAA20 VA: 0x180BDB620
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

}

