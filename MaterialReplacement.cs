public class MaterialReplacement : MonoBehaviour // TypeDefIndex: 6584
{
	private bool initialized; 
	public Material[] Default; 
	public Material[] Override; 
	public Renderer Renderer; 


public static void ReplaceRecursive(GameObject go, Material mat) { }

public static void ReplaceRecursive(GameObject obj, Material[] find, Material[] replace) { }

public static void Prepare(GameObject go) { }

private static bool MaterialsContainAny(Material[] source, Material[] find) { }

public static void Reset(GameObject go) { }

private void Init() { }

private void Replace(Material mat) { }

private void Replace(Material find, Material replace) { }

private void Replace(Material[] find, Material[] replace) { }

private void Revert() { }

public void .ctor() { }

}

