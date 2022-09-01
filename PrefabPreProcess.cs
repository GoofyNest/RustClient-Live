public class PrefabPreProcess : IPrefabProcessor // TypeDefIndex: 9981
{
	public static Type[] clientsideOnlyTypes; 
	public static Type[] serversideOnlyTypes; 
	public bool isClientside; 
	public bool isServerside; 
	public bool isBundling; 
	internal Dictionary<string, GameObject> prefabList; 
	private List<Component> destroyList; 
	private List<GameObject> cleanupList; 


	public void .ctor(bool clientside, bool serverside, bool bundling = False) { }

	public GameObject Find(string strPrefab) { }

	public bool NeedsProcessing(GameObject go) { }

	public void ProcessObject(string name, GameObject go, bool resetLocalTransform = True) { }

	public void Process(string name, GameObject go) { }

	public void Invalidate(string name) { }

	public GameObject GetHierarchyGroup() { }

	public void AddPrefab(string name, GameObject go) { }

	private void DestroyComponents(Type t, GameObject go, bool client, bool server) { }

	private bool ShouldExclude(Transform transform) { }

	private bool HasComponents<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-PrefabPreProcess.HasComponents<IClientComponentEx>
	|-PrefabPreProcess.HasComponents<IEditorComponent>
	|-PrefabPreProcess.HasComponents<IPrefabPostProcess>
	|-PrefabPreProcess.HasComponents<IPrefabPreProcess>
	|-PrefabPreProcess.HasComponents<IServerComponentEx>
	|-PrefabPreProcess.HasComponents<object>
	*/

	private bool HasComponents(Transform transform, Type t) { }

	public List<T> FindComponents<T>(Transform transform) { }
	/* GenericInstMethod :
	|
	|-PrefabPreProcess.FindComponents<IClientComponentEx>
	|-PrefabPreProcess.FindComponents<IPrefabPostProcess>
	|-PrefabPreProcess.FindComponents<IPrefabPreProcess>
	|-PrefabPreProcess.FindComponents<IServerComponentEx>
	|-PrefabPreProcess.FindComponents<object>
	|-PrefabPreProcess.FindComponents<MeshCollider>
	|-PrefabPreProcess.FindComponents<Transform>
	*/

	public void FindComponents<T>(Transform transform, List<T> list) { }
	/* GenericInstMethod :
	|
	|-PrefabPreProcess.FindComponents<object>
	*/

	public List<Component> FindComponents(Transform transform, Type t) { }

	public void FindComponents(Transform transform, List<Component> list, Type t) { }

	public void RemoveComponent(Component c) { }

	public void RemoveComponents(GameObject gameObj) { }

	public void NominateForDeletion(GameObject gameObj) { }

	private void RunCleanupQueue() { }

	private void DoCleanup(GameObject go) { }

	private static void .cctor() { }

}

private sealed class PrefabPreProcess.<>c__DisplayClass8_0 // TypeDefIndex: 9982
{
	public PrefabPreProcess <>4__this; 
	public GameObject go; 


	public void .ctor() { }

	internal bool <NeedsProcessing>b__0(Type type) { }

	internal bool <NeedsProcessing>b__1(Type type) { }

}

