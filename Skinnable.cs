public class Skinnable : ScriptableObject // TypeDefIndex: 7715
{
// Namespace: 
[CreateAssetMenuAttribute] // RVA: 0xC6F40 Offset: 0xC6340 VA: 0x1800C6F40
public class Skinnable : ScriptableObject // TypeDefIndex: 7715
	// Fields
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

	// Properties
	public Material[] SourceMaterials { get; }

	// Methods

	// RVA: 0xE892D0 Offset: 0xE886D0 VA: 0x180E892D0
	public static Skinnable FindForItem(string itemType) { }

	// RVA: 0xE89210 Offset: 0xE88610 VA: 0x180E89210
	public static Skinnable FindForEntity(string entityName) { }

	// RVA: 0xE89390 Offset: 0xE88790 VA: 0x180E89390
	public Material[] get_SourceMaterials() { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public class Skinnable.Group // TypeDefIndex: 7716
{	// Fields
	public string Name; // 0x10
	public Material Material; // 0x18
	public int MaxTextureSize; // 0x20

	// Methods

	// RVA: 0xE86F80 Offset: 0xE86380 VA: 0x180E86F80
	public void .ctor() { }

}

private sealed class Skinnable.<>c__DisplayClass13_0 // TypeDefIndex: 7717
{	// Fields
	public string itemType; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xE940F0 Offset: 0xE934F0 VA: 0x180E940F0
	internal bool <FindForItem>b__0(Skinnable x) { }

}

private sealed class Skinnable.<>c__DisplayClass14_0 // TypeDefIndex: 7718
{	// Fields
	public string entityName; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xE94160 Offset: 0xE93560 VA: 0x180E94160
	internal bool <FindForEntity>b__0(Skinnable x) { }

}

