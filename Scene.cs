public struct Scene // TypeDefIndex: 3655
{
	[SerializeField] 
	private int m_Handle; 

public int handle { get; }
public string name { get; }
public bool isLoaded { get; }
public int buildIndex { get; }
public int rootCount { get; }


	[StaticAccessorAttribute] 
private static bool IsValidInternal(int sceneHandle) { }

	[StaticAccessorAttribute] 
private static string GetNameInternal(int sceneHandle) { }

	[StaticAccessorAttribute] 
private static bool GetIsLoadedInternal(int sceneHandle) { }

	[StaticAccessorAttribute] 
private static int GetBuildIndexInternal(int sceneHandle) { }

	[StaticAccessorAttribute] 
private static int GetRootCountInternal(int sceneHandle) { }

	[StaticAccessorAttribute] 
private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

public int get_handle() { }

public bool IsValid() { }

public string get_name() { }

public bool get_isLoaded() { }

public int get_buildIndex() { }

public int get_rootCount() { }

public GameObject[] GetRootGameObjects() { }

public void GetRootGameObjects(List<GameObject> rootGameObjects) { }

public override int GetHashCode() { }

public override bool Equals(object other) { }

}

