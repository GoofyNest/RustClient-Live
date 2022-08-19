public class PrefabPreProcess : IPrefabProcessor // TypeDefIndex: 9974
{	// Fields
	public static Type[] clientsideOnlyTypes; // 0x0
	public static Type[] serversideOnlyTypes; // 0x8
	public bool isClientside; // 0x10
	public bool isServerside; // 0x11
	public bool isBundling; // 0x12
	internal Dictionary<string, GameObject> prefabList; // 0x18
	private List<Component> destroyList; // 0x20
	private List<GameObject> cleanupList; // 0x28

	// Methods

	// RVA: 0x985AA0 Offset: 0x984EA0 VA: 0x180985AA0
	public void .ctor(bool clientside, bool serverside, bool bundling = False) { }

	// RVA: 0x982BE0 Offset: 0x981FE0 VA: 0x180982BE0
	public GameObject Find(string strPrefab) { }

	// RVA: 0x983120 Offset: 0x982520 VA: 0x180983120
	public bool NeedsProcessing(GameObject go) { }

	// RVA: 0x983420 Offset: 0x982820 VA: 0x180983420
	public void ProcessObject(string name, GameObject go, bool resetLocalTransform = True) { }

	// RVA: 0x9841D0 Offset: 0x9835D0 VA: 0x1809841D0
	public void Process(string name, GameObject go) { }

	// RVA: 0x983030 Offset: 0x982430 VA: 0x180983030
	public void Invalidate(string name) { }

	// RVA: 0x982CC0 Offset: 0x9820C0 VA: 0x180982CC0
	public GameObject GetHierarchyGroup() { }

	// RVA: 0x982460 Offset: 0x981860 VA: 0x180982460
	public void AddPrefab(string name, GameObject go) { }

	// RVA: 0x9824E0 Offset: 0x9818E0 VA: 0x1809824E0
	private void DestroyComponents(Type t, GameObject go, bool client, bool server) { }

	// RVA: 0x9848F0 Offset: 0x983CF0 VA: 0x1809848F0
	private bool ShouldExclude(Transform transform) { }

	// RVA: -1 Offset: -1
	private bool HasComponents<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258D30 Offset: 0x1258130 VA: 0x181258D30
	|-PrefabPreProcess.HasComponents<IClientComponentEx>
	|-PrefabPreProcess.HasComponents<IEditorComponent>
	|-PrefabPreProcess.HasComponents<IPrefabPostProcess>
	|-PrefabPreProcess.HasComponents<IPrefabPreProcess>
	|-PrefabPreProcess.HasComponents<IServerComponentEx>
	|-PrefabPreProcess.HasComponents<object>
	*/

	// RVA: 0x982DA0 Offset: 0x9821A0 VA: 0x180982DA0
	private bool HasComponents(Transform transform, Type t) { }

	// RVA: -1 Offset: -1
	public List<T> FindComponents<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12AA0B0 Offset: 0x12A94B0 VA: 0x1812AA0B0
	|-PrefabPreProcess.FindComponents<IClientComponentEx>
	|-PrefabPreProcess.FindComponents<IPrefabPostProcess>
	|-PrefabPreProcess.FindComponents<IPrefabPreProcess>
	|-PrefabPreProcess.FindComponents<IServerComponentEx>
	|-PrefabPreProcess.FindComponents<object>
	|-PrefabPreProcess.FindComponents<MeshCollider>
	|-PrefabPreProcess.FindComponents<Transform>
	*/

	// RVA: -1 Offset: -1
	public void FindComponents<T>(Transform transform, List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF9830 Offset: 0xCF8C30 VA: 0x180CF9830
	|-PrefabPreProcess.FindComponents<object>
	*/

	// RVA: 0x9828B0 Offset: 0x981CB0 VA: 0x1809828B0
	public List<Component> FindComponents(Transform transform, Type t) { }

	// RVA: 0x982940 Offset: 0x981D40 VA: 0x180982940
	public void FindComponents(Transform transform, List<Component> list, Type t) { }

	// RVA: 0x9843C0 Offset: 0x9837C0 VA: 0x1809843C0 Slot: 4
	public void RemoveComponent(Component c) { }

	// RVA: 0x984450 Offset: 0x983850 VA: 0x180984450
	public void RemoveComponents(GameObject gameObj) { }

	// RVA: 0x9833C0 Offset: 0x9827C0 VA: 0x1809833C0 Slot: 5
	public void NominateForDeletion(GameObject gameObj) { }

	// RVA: 0x984550 Offset: 0x983950 VA: 0x180984550
	private void RunCleanupQueue() { }

	// RVA: 0x982770 Offset: 0x981B70 VA: 0x180982770
	private void DoCleanup(GameObject go) { }

	// RVA: 0x984970 Offset: 0x983D70 VA: 0x180984970
	private static void .cctor() { }

}

private sealed class PrefabPreProcess.<>c__DisplayClass8_0 // TypeDefIndex: 9975
{	// Fields
	public PrefabPreProcess <>4__this; // 0x10
	public GameObject go; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x9893E0 Offset: 0x9887E0 VA: 0x1809893E0
	internal bool <NeedsProcessing>b__0(Type type) { }

	// RVA: 0x9893E0 Offset: 0x9887E0 VA: 0x1809893E0
	internal bool <NeedsProcessing>b__1(Type type) { }

}

