public static class TransformEx // TypeDefIndex: 5615
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x199F8F0 Offset: 0x199ECF0 VA: 0x18199F8F0
	public static Transform FindChildRecursive(Transform transform, string name) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static T GetOrAddComponent<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EDCD0 Offset: 0x5ED0D0 VA: 0x1805EDCD0
	|-TransformEx.GetOrAddComponent<EntityCollisionMessage>
	|-TransformEx.GetOrAddComponent<MaterialReplacement>
	|-TransformEx.GetOrAddComponent<DDraw>
	|-TransformEx.GetOrAddComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x199F7D0 Offset: 0x199EBD0 VA: 0x18199F7D0
	public static void DestroyAllChildren(Transform transform, bool immediate = False) { }

}

public static class TransformEx // TypeDefIndex: 11704
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E1570 Offset: 0x11E0970 VA: 0x1811E1570
	public static string GetRecursiveName(Transform transform, string strEndName = "") { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static void RemoveComponent<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EDD90 Offset: 0x5ED190 VA: 0x1805EDD90
	|-TransformEx.RemoveComponent<EntityCollisionMessage>
	|-TransformEx.RemoveComponent<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E19B0 Offset: 0x11E0DB0 VA: 0x1811E19B0
	public static void RetireAllChildren(Transform transform, GameManager gameManager) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E1420 Offset: 0x11E0820 VA: 0x1811E1420
	public static List<Transform> GetChildren(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E1810 Offset: 0x11E0C10 VA: 0x1811E1810
	public static void OrderChildren(Transform tx, Func<Transform, object> selector) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E0960 Offset: 0x11DFD60 VA: 0x1811E0960
	public static List<Transform> GetAllChildren(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E05A0 Offset: 0x11DF9A0 VA: 0x1811E05A0
	public static void AddAllChildren(Transform transform, List<Transform> list) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E12E0 Offset: 0x11E06E0 VA: 0x1811E12E0
	public static Transform[] GetChildrenWithTag(Transform transform, string strTag) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E1650 Offset: 0x11E0A50 VA: 0x1811E1650
	public static void Identity(GameObject go) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E0680 Offset: 0x11DFA80 VA: 0x1811E0680
	public static GameObject CreateChild(GameObject go) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E1790 Offset: 0x11E0B90 VA: 0x1811E1790
	public static GameObject InstantiateChild(GameObject go, GameObject prefab) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E1E70 Offset: 0x11E1270 VA: 0x1811E1E70
	public static void SetLayerRecursive(GameObject go, int Layer) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E07D0 Offset: 0x11DFBD0 VA: 0x1811E07D0
	public static bool DropToGround(Transform transform, bool alignToNormal = False, float fRange = 100) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E14E0 Offset: 0x11E08E0 VA: 0x1811E14E0
	public static bool GetGroundInfo(Transform transform, out Vector3 pos, out Vector3 normal, float range = 100) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E1470 Offset: 0x11E0870 VA: 0x1811E1470
	public static bool GetGroundInfoTerrainOnly(Transform transform, out Vector3 pos, out Vector3 normal, float range = 100) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E1F30 Offset: 0x11E1330 VA: 0x1811E1F30
	public static Bounds WorkoutRenderBounds(Transform tx) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static List<T> GetSiblings<T>(Transform transform, bool includeSelf = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12BD920 Offset: 0x12BCD20 VA: 0x1812BD920
	|-TransformEx.GetSiblings<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E0720 Offset: 0x11DFB20 VA: 0x1811E0720
	public static void DestroyChildren(Transform transform) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E1D30 Offset: 0x11E1130 VA: 0x1811E1D30
	public static void SetChildrenActive(Transform transform, bool b) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E04A0 Offset: 0x11DF8A0 VA: 0x1811E04A0
	public static Transform ActiveChild(Transform transform, string name, bool bDisableOthers) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static T GetComponentInChildrenIncludeDisabled<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C0D80 Offset: 0x14C0180 VA: 0x1814C0D80
	|-TransformEx.GetComponentInChildrenIncludeDisabled<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static bool HasComponentInChildrenIncludeDisabled<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEFB20 Offset: 0xBEEF20 VA: 0x180BEFB20
	|-TransformEx.HasComponentInChildrenIncludeDisabled<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E1DC0 Offset: 0x11E11C0 VA: 0x1811E1DC0
	public static void SetHierarchyGroup(Transform transform, string strRoot, bool groupActive = True, bool persistant = False) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x11E0A00 Offset: 0x11DFE00 VA: 0x1811E0A00
	public static Bounds GetBounds(Transform transform, bool includeRenderers = True, bool includeColliders = True, bool includeInactive = True) { }

}

private sealed class TransformEx.<>c__DisplayClass7_0 // TypeDefIndex: 11705
{	// Fields
	public string strTag; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x11E2260 Offset: 0x11E1660 VA: 0x1811E2260
	internal bool <GetChildrenWithTag>b__0(Transform x) { }

}

