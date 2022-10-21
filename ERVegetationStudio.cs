public class ERVegetationStudio : ScriptableObject // TypeDefIndex: 13236
{

	public static bool VegetationStudio() { }

	public static bool VegetationStudioPro() { }

	public static void CreateVegetationMaskLine(GameObject go, float grassPerimeter, float plantPerimeter, float treePerimeter, float objectPerimeter, float largeObjectPerimeter) { }

	public static void UpdateVegetationMaskLine(GameObject go, ERVSData[] vsData, float grassPerimeter, float plantPerimeter, float treePerimeter, float objectPerimeter, float largeObjectPerimeter) { }

	public static void UpdateHeightmap(Bounds bounds) { }

	public static void RemoveVegetationMaskLine(GameObject go) { }

	public static void CreateBiomeArea(GameObject go, float distance, float blendDistance, float noise) { }

	public static void UpdateBiomeArea(GameObject go, ERVSData[] vsData, float distance, float blendDistance, float noise) { }

	public static void RemoveBiomeArea(GameObject go) { }

	public void .ctor() { }

}

