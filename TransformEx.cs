public static class TransformEx // TypeDefIndex: 5624
{

	[ExtensionAttribute]
	public static Transform FindChildRecursive(Transform transform, string name) { }

	[ExtensionAttribute]
	public static T GetOrAddComponent<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-TransformEx.GetOrAddComponent<EntityCollisionMessage>
	|-TransformEx.GetOrAddComponent<MaterialReplacement>
	|-TransformEx.GetOrAddComponent<DDraw>
	|-TransformEx.GetOrAddComponent<object>
	*/

	[ExtensionAttribute]
	public static void DestroyAllChildren(Transform transform, bool immediate = False) { }

}

public static class TransformEx // TypeDefIndex: 13513
{

	[ExtensionAttribute]
	public static string GetRecursiveName(Transform transform, string strEndName = "") { }

	[ExtensionAttribute]
	public static void RemoveComponent<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-TransformEx.RemoveComponent<EntityCollisionMessage>
	|-TransformEx.RemoveComponent<object>
	*/

	[ExtensionAttribute]
	public static void RetireAllChildren(Transform transform, GameManager gameManager) { }

	[ExtensionAttribute]
	public static List<Transform> GetChildren(Transform transform) { }

	[ExtensionAttribute]
	public static void OrderChildren(Transform tx, Func<Transform, object> selector) { }

	[ExtensionAttribute]
	public static List<Transform> GetAllChildren(Transform transform) { }

	[ExtensionAttribute]
	public static void AddAllChildren(Transform transform, List<Transform> list) { }

	[ExtensionAttribute]
	public static Transform[] GetChildrenWithTag(Transform transform, string strTag) { }

	[ExtensionAttribute]
	public static void Identity(GameObject go) { }

	[ExtensionAttribute]
	public static GameObject CreateChild(GameObject go) { }

	[ExtensionAttribute]
	public static GameObject InstantiateChild(GameObject go, GameObject prefab) { }

	[ExtensionAttribute]
	public static void SetLayerRecursive(GameObject go, int Layer) { }

	[ExtensionAttribute]
	public static bool DropToGround(Transform transform, bool alignToNormal = False, float fRange = 100) { }

	[ExtensionAttribute]
	public static bool GetGroundInfo(Transform transform, out Vector3 pos, out Vector3 normal, float range = 100) { }

	[ExtensionAttribute]
	public static bool GetGroundInfoTerrainOnly(Transform transform, out Vector3 pos, out Vector3 normal, float range = 100) { }

	[ExtensionAttribute]
	public static Bounds WorkoutRenderBounds(Transform tx) { }

	[ExtensionAttribute]
	public static List<T> GetSiblings<T>(Transform transform, bool includeSelf = False) { }
	/* GenericInstMethod :
	|
	|-TransformEx.GetSiblings<object>
	*/

	[ExtensionAttribute]
	public static void DestroyChildren(Transform transform) { }

	[ExtensionAttribute]
	public static void SetChildrenActive(Transform transform, bool b) { }

	[ExtensionAttribute]
	public static Transform ActiveChild(Transform transform, string name, bool bDisableOthers) { }

	[ExtensionAttribute]
	public static T GetComponentInChildrenIncludeDisabled<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-TransformEx.GetComponentInChildrenIncludeDisabled<object>
	*/

	[ExtensionAttribute]
	public static bool HasComponentInChildrenIncludeDisabled<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-TransformEx.HasComponentInChildrenIncludeDisabled<object>
	*/

	[ExtensionAttribute]
	public static void SetHierarchyGroup(Transform transform, string strRoot, bool groupActive = True, bool persistant = False) { }

	[ExtensionAttribute]
	public static Bounds GetBounds(Transform transform, bool includeRenderers = True, bool includeColliders = True, bool includeInactive = True) { }

}

private sealed class TransformEx.<>c__DisplayClass7_0 // TypeDefIndex: 13514
{
	public string strTag;


	public void .ctor() { }

	internal bool <GetChildrenWithTag>

}

