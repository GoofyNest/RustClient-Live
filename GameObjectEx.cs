public static class GameObjectEx // TypeDefIndex: 11697
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9DC1B0 Offset: 0x9DB5B0 VA: 0x1809DC1B0
	public static BaseEntity ToBaseEntity(GameObject go) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9DC470 Offset: 0x9DB870 VA: 0x1809DC470
	public static BaseEntity ToBaseEntity(Collider collider) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9DC1E0 Offset: 0x9DB5E0 VA: 0x1809DC1E0
	public static BaseEntity ToBaseEntity(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9DC060 Offset: 0x9DB460 VA: 0x1809DC060
	public static bool IsOnLayer(GameObject go, Layer rustLayer) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9DC060 Offset: 0x9DB460 VA: 0x1809DC060
	public static bool IsOnLayer(GameObject go, int layer) { }

	// RVA: 0x9DBF30 Offset: 0x9DB330 VA: 0x1809DBF30
	private static IEntity GetEntityFromRegistry(Transform transform) { }

	// RVA: 0x9DBE30 Offset: 0x9DB230 VA: 0x1809DBE30
	private static IEntity GetEntityFromComponent(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9DC0F0 Offset: 0x9DB4F0 VA: 0x1809DC0F0
	public static void SetHierarchyGroup(GameObject obj, string strRoot, bool groupActive = True, bool persistant = False) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static bool HasComponent<T>(GameObject obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEDCB0 Offset: 0xBED0B0 VA: 0x180BEDCB0
	|-GameObjectEx.HasComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static void SetChildComponentsEnabled<T>(GameObject gameObject, bool enabled) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E7740 Offset: 0x5E6B40 VA: 0x1805E7740
	|-GameObjectEx.SetChildComponentsEnabled<object>
	|-GameObjectEx.SetChildComponentsEnabled<TMP_Text>
	*/

}

