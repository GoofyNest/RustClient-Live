public static class ComponentEx // TypeDefIndex: 11694
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static T Instantiate<T>(T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A41D0 Offset: 0x14A35D0 VA: 0x1814A41D0
	|-ComponentEx.Instantiate<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static bool HasComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBE9FA0 Offset: 0xBE93A0 VA: 0x180BE9FA0
	|-ComponentEx.HasComponent<IndependentScale>
	|-ComponentEx.HasComponent<object>
	*/

}

