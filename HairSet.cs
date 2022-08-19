public class HairSet : ScriptableObject // TypeDefIndex: 10732
{	// Fields
	public HairSet.MeshReplace[] MeshReplacements; // 0x18

	// Methods

	// RVA: 0x74E600 Offset: 0x74DA00 VA: 0x18074E600
	public void Process(PlayerModelHair playerModelHair, HairDyeCollection dyeCollection, HairDye dye, MaterialPropertyBlock block) { }

	// RVA: 0x74E450 Offset: 0x74D850 VA: 0x18074E450
	public void ProcessMorphs(GameObject obj, int blendShapeIndex = -1) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public class HairSet.MeshReplace // TypeDefIndex: 10733
{	// Fields
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string FindName; // 0x10
	public Mesh Find; // 0x18
	public Mesh[] ReplaceShapes; // 0x20

	// Methods

	// RVA: 0x762940 Offset: 0x761D40 VA: 0x180762940
	public bool Test(string materialName) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

