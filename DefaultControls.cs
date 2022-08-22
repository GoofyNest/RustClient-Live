public static class DefaultControls // TypeDefIndex: 4917
{	private static DefaultControls.IFactoryControls m_CurrentFactory; // 0x0
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Vector2 s_ImageElementSize; // 0x18
	private static Color s_DefaultSelectableColor; // 0x20
	private static Color s_PanelColor; // 0x30
	private static Color s_TextColor; // 0x40

	public static DefaultControls.IFactoryControls factory { get; }


	public static DefaultControls.IFactoryControls get_factory() { }

	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	private static void SetDefaultTextValues(Text lbl) { }

	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	private static void SetLayerRecursively(GameObject go, int layer) { }

	public static GameObject CreatePanel(DefaultControls.Resources resources) { }

	public static GameObject CreateButton(DefaultControls.Resources resources) { }

	public static GameObject CreateText(DefaultControls.Resources resources) { }

	public static GameObject CreateImage(DefaultControls.Resources resources) { }

	public static GameObject CreateRawImage(DefaultControls.Resources resources) { }

	public static GameObject CreateSlider(DefaultControls.Resources resources) { }

	public static GameObject CreateScrollbar(DefaultControls.Resources resources) { }

	public static GameObject CreateToggle(DefaultControls.Resources resources) { }

	public static GameObject CreateInputField(DefaultControls.Resources resources) { }

	public static GameObject CreateDropdown(DefaultControls.Resources resources) { }

	public static GameObject CreateScrollView(DefaultControls.Resources resources) { }

	private static void .cctor() { }

}

private class DefaultControls.DefaultRuntimeFactory : DefaultControls.IFactoryControls // TypeDefIndex: 4919
{	public static DefaultControls.IFactoryControls Default; // 0x12990


	public GameObject CreateGameObject(string name, Type[] components) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct DefaultControls.Resources // TypeDefIndex: 4920
{	public Sprite standard; // 0x0
	public Sprite background; // 0x8
	public Sprite inputField; // 0x10
	public Sprite knob; // 0x18
	public Sprite checkmark; // 0x20
	public Sprite dropdown; // 0x28
	public Sprite mask; // 0x30

}

