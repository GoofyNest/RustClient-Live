public class SkeletonProperties : ScriptableObject // TypeDefIndex: 9981
{	public GameObject boneReference; // 0x18
	[BonePropertyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public SkeletonProperties.BoneProperty[] bones; // 0x20
	private Dictionary<uint, SkeletonProperties.BoneProperty> quickLookup; // 0x28


	public void OnValidate() { }

	private void BuildDictionary() { }

	public SkeletonProperties.BoneProperty FindBone(uint id) { }

	public void .ctor() { }

}

public class SkeletonProperties.BoneProperty // TypeDefIndex: 9982
{	public GameObject bone; // 0x10
	public Translate.Phrase name; // 0x18
	public HitArea area; // 0x20


	public void .ctor() { }

}

private sealed class SkeletonProperties.<>c__DisplayClass3_0 // TypeDefIndex: 9983
{	public Transform child; // 0x10


	public void .ctor() { }

	internal bool <OnValidate>b__0(SkeletonProperties.BoneProperty x) { }

}

