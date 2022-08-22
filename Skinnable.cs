public class Skinnable : ScriptableObject // TypeDefIndex: 7715
{
[CreateAssetMenuAttribute] // RVA: 0xC6F40 Offset: 0xC6340 VA: 0x1800C6F40
public class Skinnable : ScriptableObject // TypeDefIndex: 7715
	public string Name; // 0x18
	public string ItemName; // 0x20
	public GameObject EntityPrefab; // 0x28
	public string EntityPrefabName; // 0x30
	public GameObject ViewmodelPrefab; // 0x38
	public string ViewmodelPrefabName; // 0x40
	public Mesh[] MeshDownloads; // 0x48
	public string[] MeshDownloadPaths; // 0x50
	public Category Category; // 0x58
	public bool HideInWorkshopUpload; // 0x5C
	public Skinnable.Group[] Groups; // 0x60
	public static Skinnable[] All; // 0x0
	private Material[] _sourceMaterials; // 0x68

	public Material[] SourceMaterials { get; }


	public static Skinnable FindForItem(string itemType) { }

	public static Skinnable FindForEntity(string entityName) { }

	public Material[] get_SourceMaterials() { }

	public void .ctor() { }

}

public class Skinnable.Group // TypeDefIndex: 7716
{	public string Name; // 0x10
	public Material Material; // 0x18
	public int MaxTextureSize; // 0x20


	public void .ctor() { }

}

private sealed class Skinnable.<>c__DisplayClass13_0 // TypeDefIndex: 7717
{	public string itemType; // 0x10


	public void .ctor() { }

	internal bool <FindForItem>b__0(Skinnable x) { }

}

private sealed class Skinnable.<>c__DisplayClass14_0 // TypeDefIndex: 7718
{	public string entityName; // 0x10


	public void .ctor() { }

	internal bool <FindForEntity>b__0(Skinnable x) { }

}

