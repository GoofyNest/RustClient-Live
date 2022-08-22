public class PhotoPanel : MonoBehaviour, IImageReceiver // TypeDefIndex: 8816
{	public RawImage Image; // 0x18
	public InputField Message; // 0x20
	private Item _item; // 0x28
	private Texture2D _texture; // 0x30


	public void OnItem(Item item) { }

	public void OnImageLoaded(Texture2D texture) { }

	public void OnMessageChanged() { }

	public void OnDestroy() { }

	public void .ctor() { }

}

