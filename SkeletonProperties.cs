public class SkeletonProperties : ScriptableObject // TypeDefIndex: 9981
{	// Fields
	public GameObject boneReference; // 0x18
	[BonePropertyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public SkeletonProperties.BoneProperty[] bones; // 0x20
	private Dictionary<uint, SkeletonProperties.BoneProperty> quickLookup; // 0x28

	// Methods

	// RVA: 0x5B7A30 Offset: 0x5B6E30 VA: 0x1805B7A30
	public void OnValidate() { }

	// RVA: 0x5B7490 Offset: 0x5B6890 VA: 0x1805B7490
	private void BuildDictionary() { }

	// RVA: 0x5B79B0 Offset: 0x5B6DB0 VA: 0x1805B79B0
	public SkeletonProperties.BoneProperty FindBone(uint id) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public class SkeletonProperties.BoneProperty // TypeDefIndex: 9982
{	// Fields
	public GameObject bone; // 0x10
	public Translate.Phrase name; // 0x18
	public HitArea area; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class SkeletonProperties.<>c__DisplayClass3_0 // TypeDefIndex: 9983
{	// Fields
	public Transform child; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5BE190 Offset: 0x5BD590 VA: 0x1805BE190
	internal bool <OnValidate>b__0(SkeletonProperties.BoneProperty x) { }

}

