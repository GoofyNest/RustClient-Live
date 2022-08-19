public static class DefaultControls // TypeDefIndex: 4917
{	// Fields
	private static DefaultControls.IFactoryControls m_CurrentFactory; // 0x0
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Vector2 s_ImageElementSize; // 0x18
	private static Color s_DefaultSelectableColor; // 0x20
	private static Color s_PanelColor; // 0x30
	private static Color s_TextColor; // 0x40

	// Properties
	public static DefaultControls.IFactoryControls factory { get; }

	// Methods

	// RVA: 0x10BA5A0 Offset: 0x10B99A0 VA: 0x1810BA5A0
	public static DefaultControls.IFactoryControls get_factory() { }

	// RVA: 0x10B9F20 Offset: 0x10B9320 VA: 0x1810B9F20
	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	// RVA: 0x10BA030 Offset: 0x10B9430 VA: 0x1810BA030
	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	// RVA: 0x10BA120 Offset: 0x10B9520 VA: 0x1810BA120
	private static void SetDefaultTextValues(Text lbl) { }

	// RVA: 0xC4AE10 Offset: 0xC4A210 VA: 0x180C4AE10
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x10BA290 Offset: 0x10B9690 VA: 0x1810BA290
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x10BA1B0 Offset: 0x10B95B0 VA: 0x1810BA1B0
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x10B7A00 Offset: 0x10B6E00 VA: 0x1810B7A00
	public static GameObject CreatePanel(DefaultControls.Resources resources) { }

	// RVA: 0x10B5590 Offset: 0x10B4990 VA: 0x1810B5590
	public static GameObject CreateButton(DefaultControls.Resources resources) { }

	// RVA: 0x10B94F0 Offset: 0x10B88F0 VA: 0x1810B94F0
	public static GameObject CreateText(DefaultControls.Resources resources) { }

	// RVA: 0x10B7190 Offset: 0x10B6590 VA: 0x1810B7190
	public static GameObject CreateImage(DefaultControls.Resources resources) { }

	// RVA: 0x10B7C60 Offset: 0x10B7060 VA: 0x1810B7C60
	public static GameObject CreateRawImage(DefaultControls.Resources resources) { }

	// RVA: 0x10B8B50 Offset: 0x10B7F50 VA: 0x1810B8B50
	public static GameObject CreateSlider(DefaultControls.Resources resources) { }

	// RVA: 0x10B85D0 Offset: 0x10B79D0 VA: 0x1810B85D0
	public static GameObject CreateScrollbar(DefaultControls.Resources resources) { }

	// RVA: 0x10B96F0 Offset: 0x10B8AF0 VA: 0x1810B96F0
	public static GameObject CreateToggle(DefaultControls.Resources resources) { }

	// RVA: 0x10B72C0 Offset: 0x10B66C0 VA: 0x1810B72C0
	public static GameObject CreateInputField(DefaultControls.Resources resources) { }

	// RVA: 0x10B5A40 Offset: 0x10B4E40 VA: 0x1810B5A40
	public static GameObject CreateDropdown(DefaultControls.Resources resources) { }

	// RVA: 0x10B7D90 Offset: 0x10B7190 VA: 0x1810B7D90
	public static GameObject CreateScrollView(DefaultControls.Resources resources) { }

	// RVA: 0x10BA380 Offset: 0x10B9780 VA: 0x1810BA380
	private static void .cctor() { }

}

private class DefaultControls.DefaultRuntimeFactory : DefaultControls.IFactoryControls // TypeDefIndex: 4919
{	// Fields
	public static DefaultControls.IFactoryControls Default; // 0x12990

	// Methods

	// RVA: 0x10BA600 Offset: 0x10B9A00 VA: 0x1810BA600 Slot: 4
	public GameObject CreateGameObject(string name, Type[] components) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x10BA670 Offset: 0x10B9A70 VA: 0x1810BA670
	private static void .cctor() { }

}

public struct DefaultControls.Resources // TypeDefIndex: 4920
{	// Fields
	public Sprite standard; // 0x0
	public Sprite background; // 0x8
	public Sprite inputField; // 0x10
	public Sprite knob; // 0x18
	public Sprite checkmark; // 0x20
	public Sprite dropdown; // 0x28
	public Sprite mask; // 0x30

}

