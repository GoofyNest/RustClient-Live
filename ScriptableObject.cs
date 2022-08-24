public class ScriptableObject : Object // TypeDefIndex: 3523
{

public void .ctor() { }

public static ScriptableObject CreateInstance(Type type) { }

public static T CreateInstance<T>() { }
/* GenericInstMethod :
|
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

	[NativeMethodAttribute] 
private static void CreateScriptableObject(ScriptableObject self) { }

	[FreeFunctionAttribute] 
internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

}

