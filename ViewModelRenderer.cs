public class ViewModelRenderer : MonoBehaviour // TypeDefIndex: 13203
{
	public List<Texture2D> cachedTextureRefs; 
	public List<ViewModelDrawEvent> opaqueEvents; 
	public List<ViewModelDrawEvent> transparentEvents; 
	public Matrix4x4 prevModelMatrix; 
	private Renderer viewModelRenderer; 


	private void OnEnable() { }

	private void OnDisable() { }

	public void AddDrawEvents() { }

	public void RemoveDrawEvents() { }

	[ContextMenu] 
	[ButtonAttribute] 
	public void CacheReferences() { }

	private void CacheTextures() { }

	private void DisableTextureStreaming() { }

	private void EnableTextureStreaming() { }

	public static int FindPassWithLightMode(Material material, string lightMode) { }

	public static int FindPassWithRenderType(Material material, string renderType) { }

	public static RenderType CategorizeMaterial(Material material, out int pass, out int grabPass) { }

	public void .ctor() { }

}

private sealed class ViewModelRenderer.<>c // TypeDefIndex: 13204
{
	public static readonly ViewModelRenderer.<>c <>9; 
	public static Comparison<ViewModelDrawEvent> <>9__9_0; 
	public static Comparison<ViewModelDrawEvent> <>9__9_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <CacheReferences>b__9_0(ViewModelDrawEvent a, ViewModelDrawEvent b) { }

	internal int <CacheReferences>b__9_1(ViewModelDrawEvent a, ViewModelDrawEvent b) { }

}

