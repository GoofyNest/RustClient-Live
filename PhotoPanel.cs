public class PhotoPanel : MonoBehaviour, IImageReceiver // TypeDefIndex: 8816
{	// Fields
	public RawImage Image; // 0x18
	public InputField Message; // 0x20
	private Item _item; // 0x28
	private Texture2D _texture; // 0x30

	// Methods

	// RVA: 0x8CE140 Offset: 0x8CD540 VA: 0x1808CE140
	public void OnItem(Item item) { }

	// RVA: 0x8CE0C0 Offset: 0x8CD4C0 VA: 0x1808CE0C0 Slot: 4
	public void OnImageLoaded(Texture2D texture) { }

	// RVA: 0x8CE210 Offset: 0x8CD610 VA: 0x1808CE210
	public void OnMessageChanged() { }

	// RVA: 0x8CE010 Offset: 0x8CD410 VA: 0x1808CE010
	public void OnDestroy() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

