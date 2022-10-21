public static class GameObjectEx // TypeDefIndex: 13451
{

	[ExtensionAttribute] 
	public static BaseEntity ToBaseEntity(GameObject go) { }

	[ExtensionAttribute] 
	public static BaseEntity ToBaseEntity(Collider collider) { }

	[ExtensionAttribute] 
	public static BaseEntity ToBaseEntity(Transform transform) { }

	[ExtensionAttribute] 
	public static bool IsOnLayer(GameObject go, Layer rustLayer) { }

	[ExtensionAttribute] 
	public static bool IsOnLayer(GameObject go, int layer) { }

	private static IEntity GetEntityFromRegistry(Transform transform) { }

	private static IEntity GetEntityFromComponent(Transform transform) { }

	[ExtensionAttribute] 
	public static void SetHierarchyGroup(GameObject obj, string strRoot, bool groupActive = True, bool persistant = False) { }

	[ExtensionAttribute] 
	public static bool HasComponent<T>(GameObject obj) { }
	/* GenericInstMethod :
	|
	|-GameObjectEx.HasComponent<object>
	*/

	[ExtensionAttribute] 
	public static void SetChildComponentsEnabled<T>(GameObject gameObject, bool enabled) { }
	/* GenericInstMethod :
	|
	|-GameObjectEx.SetChildComponentsEnabled<object>
	|-GameObjectEx.SetChildComponentsEnabled<TMP_Text>
	*/

}

