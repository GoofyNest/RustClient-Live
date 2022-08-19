public class ViewModelRenderer : MonoBehaviour // TypeDefIndex: 11449
{	// Fields
	public List<Texture2D> cachedTextureRefs; // 0x18
	public List<ViewModelDrawEvent> opaqueEvents; // 0x20
	public List<ViewModelDrawEvent> transparentEvents; // 0x28
	public Matrix4x4 prevModelMatrix; // 0x30
	private Renderer viewModelRenderer; // 0x70

	// Methods

	// RVA: 0x7D5260 Offset: 0x7D4660 VA: 0x1807D5260
	private void OnEnable() { }

	// RVA: 0x7D5250 Offset: 0x7D4650 VA: 0x1807D5250
	private void OnDisable() { }

	// RVA: 0x7D3CA0 Offset: 0x7D30A0 VA: 0x1807D3CA0
	public void AddDrawEvents() { }

	// RVA: 0x7D5270 Offset: 0x7D4670 VA: 0x1807D5270
	public void RemoveDrawEvents() { }

	[ContextMenu] // RVA: 0xB08B0 Offset: 0xAFCB0 VA: 0x1800B08B0
	[ButtonAttribute] // RVA: 0xB08B0 Offset: 0xAFCB0 VA: 0x1800B08B0
	// RVA: 0x7D3FD0 Offset: 0x7D33D0 VA: 0x1807D3FD0
	public void CacheReferences() { }

	// RVA: 0x7D4A90 Offset: 0x7D3E90 VA: 0x1807D4A90
	private void CacheTextures() { }

	// RVA: 0x7D4E30 Offset: 0x7D4230 VA: 0x1807D4E30
	private void DisableTextureStreaming() { }

	// RVA: 0x7D4F50 Offset: 0x7D4350 VA: 0x1807D4F50
	private void EnableTextureStreaming() { }

	// RVA: 0x7D5070 Offset: 0x7D4470 VA: 0x1807D5070
	public static int FindPassWithLightMode(Material material, string lightMode) { }

	// RVA: 0x7D5160 Offset: 0x7D4560 VA: 0x1807D5160
	public static int FindPassWithRenderType(Material material, string renderType) { }

	// RVA: 0x7D4CF0 Offset: 0x7D40F0 VA: 0x1807D4CF0
	public static RenderType CategorizeMaterial(Material material, out int pass, out int grabPass) { }

	// RVA: 0x7D5650 Offset: 0x7D4A50 VA: 0x1807D5650
	public void .ctor() { }

}

private sealed class ViewModelRenderer.<>c // TypeDefIndex: 11450
{	// Fields
	public static readonly ViewModelRenderer.<>c <>9; // 0x0
	public static Comparison<ViewModelDrawEvent> <>9__9_0; // 0x8
	public static Comparison<ViewModelDrawEvent> <>9__9_1; // 0x10

	// Methods

	// RVA: 0x7CFF00 Offset: 0x7CF300 VA: 0x1807CFF00
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7CFD20 Offset: 0x7CF120 VA: 0x1807CFD20
	internal int <CacheReferences>b__9_0(ViewModelDrawEvent a, ViewModelDrawEvent b) { }

	// RVA: 0x7CFD20 Offset: 0x7CF120 VA: 0x1807CFD20
	internal int <CacheReferences>b__9_1(ViewModelDrawEvent a, ViewModelDrawEvent b) { }

}

