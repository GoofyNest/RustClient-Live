public class ImageEffectComposite : MonoBehaviour // TypeDefIndex: 8004
{
	public RenderTextureFormat format; 
	public RenderTextureReadWrite readWrite; 
	private List<ImageEffectLayer> layers; 
	private Comparison<ImageEffectLayer> layerSort; 
	private List<IImageEffect> effects; 
	private bool sorted; 


	public void Add(ImageEffectLayer effect) { }

	public void Remove(ImageEffectLayer effect) { }

	[ImageEffectTransformsToLDR] 
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	public void .ctor() { }

}

private sealed class ImageEffectComposite.<>c // TypeDefIndex: 8005
{
	public static readonly ImageEffectComposite.<>c <>9; 
	public static Comparison<ImageEffectLayer> <>9__9_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <.ctor>b__9_0(ImageEffectLayer x, ImageEffectLayer y) { }

}

