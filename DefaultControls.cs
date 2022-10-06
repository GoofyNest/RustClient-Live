public static class DefaultControls // TypeDefIndex: 4921
{
	private static DefaultControls.IFactoryControls m_CurrentFactory; 
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; 
	private static Vector2 s_ThinElementSize; 
	private static Vector2 s_ImageElementSize; 
	private static Color s_DefaultSelectableColor; 
	private static Color s_PanelColor; 
	private static Color s_TextColor; 

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

private class DefaultControls.DefaultRuntimeFactory : DefaultControls.IFactoryControls // TypeDefIndex: 4923
{
	public static DefaultControls.IFactoryControls Default; 


	public GameObject CreateGameObject(string name, Type[] components) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct DefaultControls.Resources // TypeDefIndex: 4924
{
	public Sprite standard; 
	public Sprite background; 
	public Sprite inputField; 
	public Sprite knob; 
	public Sprite checkmark; 
	public Sprite dropdown; 
	public Sprite mask; 

}

