public class SignPanel : MonoBehaviour, IImageReceiver // TypeDefIndex: 8817
{	public RawImage Image; // 0x18
	public RectTransform ImageContainer; // 0x20
	public RustText DisabledSignsMessage; // 0x28
	private Item _item; // 0x30
	private Texture2D _texture; // 0x38


	public void OnItem(Item item) { }

	public void OnImageLoaded(Texture2D texture) { }

	public static void SizeImageBasedOnTexture(Texture2D tex, RectTransform imageContainer) { }

	public void OnDestroy() { }

	public void .ctor() { }

}

