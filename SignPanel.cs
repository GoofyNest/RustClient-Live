public class SignPanel : MonoBehaviour, IImageReceiver // TypeDefIndex: 8817
{	// Fields
	public RawImage Image; // 0x18
	public RectTransform ImageContainer; // 0x20
	public RustText DisabledSignsMessage; // 0x28
	private Item _item; // 0x30
	private Texture2D _texture; // 0x38

	// Methods

	// RVA: 0x5B3DF0 Offset: 0x5B31F0 VA: 0x1805B3DF0
	public void OnItem(Item item) { }

	// RVA: 0x5B3D60 Offset: 0x5B3160 VA: 0x1805B3D60 Slot: 4
	public void OnImageLoaded(Texture2D texture) { }

	// RVA: 0x5B3FF0 Offset: 0x5B33F0 VA: 0x1805B3FF0
	public static void SizeImageBasedOnTexture(Texture2D tex, RectTransform imageContainer) { }

	// RVA: 0x5B3CB0 Offset: 0x5B30B0 VA: 0x1805B3CB0
	public void OnDestroy() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

