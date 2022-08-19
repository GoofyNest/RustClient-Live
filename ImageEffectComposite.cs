public class ImageEffectComposite : MonoBehaviour // TypeDefIndex: 8030
{	// Fields
	public RenderTextureFormat format; // 0x18
	public RenderTextureReadWrite readWrite; // 0x1C
	private List<ImageEffectLayer> layers; // 0x20
	private Comparison<ImageEffectLayer> layerSort; // 0x28
	private List<IImageEffect> effects; // 0x30
	private bool sorted; // 0x38

	// Methods

	// RVA: 0x1068050 Offset: 0x1067450 VA: 0x181068050
	public void Add(ImageEffectLayer effect) { }

	// RVA: 0x1068580 Offset: 0x1067980 VA: 0x181068580
	public void Remove(ImageEffectLayer effect) { }

	[ImageEffectTransformsToLDR] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10680B0 Offset: 0x10674B0 VA: 0x1810680B0
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	// RVA: 0x10685E0 Offset: 0x10679E0 VA: 0x1810685E0
	public void .ctor() { }

}

private sealed class ImageEffectComposite.<>c // TypeDefIndex: 8031
{	// Fields
	public static readonly ImageEffectComposite.<>c <>9; // 0x0
	public static Comparison<ImageEffectLayer> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x10754F0 Offset: 0x10748F0 VA: 0x1810754F0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1075070 Offset: 0x1074470 VA: 0x181075070
	internal int <.ctor>b__9_0(ImageEffectLayer x, ImageEffectLayer y) { }

}

