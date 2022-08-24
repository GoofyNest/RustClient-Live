public class SignPanel : MonoBehaviour, IImageReceiver // TypeDefIndex: 8817
{
	public RawImage Image; 
	public RectTransform ImageContainer; 
	public RustText DisabledSignsMessage; 
	private Item _item; 
	private Texture2D _texture; 


	public void OnItem(Item item) { }

	public void OnImageLoaded(Texture2D texture) { }

	public static void SizeImageBasedOnTexture(Texture2D tex, RectTransform imageContainer) { }

	public void OnDestroy() { }

	public void .ctor() { }

}

