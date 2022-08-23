public static class ComponentEx // TypeDefIndex: 11694
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static T Instantiate<T>(T component) { }
	/* GenericInstMethod :
	|
	|-ComponentEx.Instantiate<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static bool HasComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-ComponentEx.HasComponent<IndependentScale>
	|-ComponentEx.HasComponent<object>
	*/

}

