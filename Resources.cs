public sealed class Resources // TypeDefIndex: 3493
{

	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-Resources.ConvertObjects<object>
	*/

	[TypeInferenceRuleAttribute]
	[FreeFunctionAttribute]
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	public static T[] FindObjectsOfTypeAll<T>() { }
	/* GenericInstMethod :
	|
	|-Resources.FindObjectsOfTypeAll<LocalizeText>
	|-Resources.FindObjectsOfTypeAll<RustText>
	|-Resources.FindObjectsOfTypeAll<Cubemap>
	|-Resources.FindObjectsOfTypeAll<Material>
	|-Resources.FindObjectsOfTypeAll<Shader>
	|-Resources.FindObjectsOfTypeAll<object>
	*/

	public static Object Load(string path) { }

	public static T Load<T>(string path) { }
	/* GenericInstMethod :
	|
	|-Resources.Load<GameModeManifest>
	|-Resources.Load<MissionManifest>
	|-Resources.Load<TMP_ColorGradient>
	|-Resources.Load<TMP_FontAsset>
	|-Resources.Load<TMP_Settings>
	|-Resources.Load<TrainWagonLootData>
	|-Resources.Load<UnderwearManifest>
	|-Resources.Load<GUISkin>
	|-Resources.Load<GameObject>
	|-Resources.Load<Material>
	|-Resources.Load<TextAsset>
	|-Resources.Load<Texture2D>
	|-Resources.Load<WorldSplineSharedData>
	|-Resources.Load<object>
	*/

	[TypeInferenceRuleAttribute]
	[FreeFunctionAttribute]
	[NativeThrowsAttribute]
	public static Object Load(string path, Type systemTypeInstance) { }

	[FreeFunctionAttribute]
	[NativeThrowsAttribute]
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	public static T[] LoadAll<T>(string path) { }
	/* GenericInstMethod :
	|
	|-Resources.LoadAll<Config>
	|-Resources.LoadAll<object>
	*/

	[FreeFunctionAttribute]
	[TypeInferenceRuleAttribute]
	public static Object GetBuiltinResource(Type type, string path) { }

	public static T GetBuiltinResource<T>(string path) { }
	/* GenericInstMethod :
	|
	|-Resources.GetBuiltinResource<Font>
	|-Resources.GetBuiltinResource<object>
	*/

	[FreeFunctionAttribute]
	public static void UnloadAsset(Object assetToUnload) { }

	[FreeFunctionAttribute]
	public static AsyncOperation UnloadUnusedAssets() { }

}

