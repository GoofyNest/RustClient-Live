public class Skinnable : ScriptableObject // TypeDefIndex: 7715
{

[CreateAssetMenuAttribute] 
public class Skinnable : ScriptableObject 
	public string Name; 
	public string ItemName; 
	public GameObject EntityPrefab; 
	public string EntityPrefabName; 
	public GameObject ViewmodelPrefab; 
	public string ViewmodelPrefabName; 
	public Mesh[] MeshDownloads; 
	public string[] MeshDownloadPaths; 
	public Category Category; 
	public bool HideInWorkshopUpload; 
	public Skinnable.Group[] Groups; 
	public static Skinnable[] All; 
	private Material[] _sourceMaterials; 

public Material[] SourceMaterials { get; }


public static Skinnable FindForItem(string itemType) { }

public static Skinnable FindForEntity(string entityName) { }

public Material[] get_SourceMaterials() { }

public void .ctor() { }

}

public class Skinnable.Group // TypeDefIndex: 7716
{
	public string Name; 
	public Material Material; 
	public int MaxTextureSize; 


public void .ctor() { }

}

private sealed class Skinnable.<>c__DisplayClass13_0 // TypeDefIndex: 7717
{
	public string itemType; 


public void .ctor() { }

internal bool <FindForItem>b__0(Skinnable x) { }

}

private sealed class Skinnable.<>c__DisplayClass14_0 // TypeDefIndex: 7718
{
	public string entityName; 


public void .ctor() { }

internal bool <FindForEntity>b__0(Skinnable x) { }

}

