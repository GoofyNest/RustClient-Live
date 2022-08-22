public class ImageEffectComposite : MonoBehaviour // TypeDefIndex: 8030
{	public RenderTextureFormat format; // 0x18
	public RenderTextureReadWrite readWrite; // 0x1C
	private List<ImageEffectLayer> layers; // 0x20
	private Comparison<ImageEffectLayer> layerSort; // 0x28
	private List<IImageEffect> effects; // 0x30
	private bool sorted; // 0x38


	public void Add(ImageEffectLayer effect) { }

	public void Remove(ImageEffectLayer effect) { }

	[ImageEffectTransformsToLDR] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	public void .ctor() { }

}

private sealed class ImageEffectComposite.<>c // TypeDefIndex: 8031
{	public static readonly ImageEffectComposite.<>c <>9; // 0x0
	public static Comparison<ImageEffectLayer> <>9__9_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <.ctor>b__9_0(ImageEffectLayer x, ImageEffectLayer y) { }

}

