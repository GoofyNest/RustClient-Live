public class ScriptableObject : Object // TypeDefIndex: 3523
{	// Methods

	// RVA: 0x19A9460 Offset: 0x19A8860 VA: 0x1819A9460
	public void .ctor() { }

	// RVA: 0x19AFB20 Offset: 0x19AEF20 VA: 0x1819AFB20
	public static ScriptableObject CreateInstance(Type type) { }

	// RVA: -1 Offset: -1
	public static T CreateInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C0560 Offset: 0x14BF960 VA: 0x1814C0560
	|-ScriptableObject.CreateInstance<EZSoftBoneMaterial>
	|-ScriptableObject.CreateInstance<ERDecal>
	|-ScriptableObject.CreateInstance<ERLocalGrid>
	|-ScriptableObject.CreateInstance<ERMarkerExt>
	|-ScriptableObject.CreateInstance<ERMaterial>
	|-ScriptableObject.CreateInstance<ERSOMarkerExt>
	|-ScriptableObject.CreateInstance<ERSORoadExt>
	|-ScriptableObject.CreateInstance<SelectedObject>
	|-ScriptableObject.CreateInstance<BurstClothMaterial>
	|-ScriptableObject.CreateInstance<ProtectionProperties>
	|-ScriptableObject.CreateInstance<TMP_FontAsset>
	|-ScriptableObject.CreateInstance<PostProcessProfile>
	|-ScriptableObject.CreateInstance<object>
	|-ScriptableObject.CreateInstance<PlayerConnection>
	*/

	[NativeMethodAttribute] // RVA: 0x90400 Offset: 0x8F800 VA: 0x180090400
	// RVA: 0x19AFBB0 Offset: 0x19AEFB0 VA: 0x1819AFBB0
	private static void CreateScriptableObject(ScriptableObject self) { }

	[FreeFunctionAttribute] // RVA: 0xC39A0 Offset: 0xC2DA0 VA: 0x1800C39A0
	// RVA: 0x19AFB60 Offset: 0x19AEF60 VA: 0x1819AFB60
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

}

