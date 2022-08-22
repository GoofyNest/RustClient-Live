public sealed class Resources // TypeDefIndex: 3490
{
	internal static T[] ConvertObjects<T>(Object[] rawObjects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A9DE80 Offset: 0x1A9D280 VA: 0x181A9DE80
	|-Resources.ConvertObjects<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xB45B0 Offset: 0xB39B0 VA: 0x1800B45B0
	[TypeInferenceRuleAttribute] // RVA: 0xB45B0 Offset: 0xB39B0 VA: 0x1800B45B0
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	public static T[] FindObjectsOfTypeAll<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA2BB0 Offset: 0x1AA1FB0 VA: 0x181AA2BB0
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
	|-RVA: 0x14C0350 Offset: 0x14BF750 VA: 0x1814C0350
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

	[TypeInferenceRuleAttribute] // RVA: 0xB46D0 Offset: 0xB3AD0 VA: 0x1800B46D0
	[FreeFunctionAttribute] // RVA: 0xB46D0 Offset: 0xB3AD0 VA: 0x1800B46D0
	[NativeThrowsAttribute] // RVA: 0xB46D0 Offset: 0xB3AD0 VA: 0x1800B46D0
	public static Object Load(string path, Type systemTypeInstance) { }

	[FreeFunctionAttribute] // RVA: 0xB48C0 Offset: 0xB3CC0 VA: 0x1800B48C0
	[NativeThrowsAttribute] // RVA: 0xB48C0 Offset: 0xB3CC0 VA: 0x1800B48C0
	public static Object[] LoadAll(string path, Type systemTypeInstance) { }

	public static T[] LoadAll<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA2C30 Offset: 0x1AA2030 VA: 0x181AA2C30
	|-Resources.LoadAll<Config>
	|-Resources.LoadAll<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xB4C40 Offset: 0xB4040 VA: 0x1800B4C40
	[TypeInferenceRuleAttribute] // RVA: 0xB4C40 Offset: 0xB4040 VA: 0x1800B4C40
	public static Object GetBuiltinResource(Type type, string path) { }

	public static T GetBuiltinResource<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C0290 Offset: 0x14BF690 VA: 0x1814C0290
	|-Resources.GetBuiltinResource<Font>
	|-Resources.GetBuiltinResource<object>
	*/

	[FreeFunctionAttribute] // RVA: 0xB6380 Offset: 0xB5780 VA: 0x1800B6380
	public static void UnloadAsset(Object assetToUnload) { }

	[FreeFunctionAttribute] // RVA: 0xB6540 Offset: 0xB5940 VA: 0x1800B6540
	public static AsyncOperation UnloadUnusedAssets() { }

}

