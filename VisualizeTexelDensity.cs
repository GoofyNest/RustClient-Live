public class VisualizeTexelDensity : MonoBehaviour // TypeDefIndex: 11529
{	// Fields
	public Shader shader; // 0x18
	public string shaderTag; // 0x20
	[RangeAttribute] // RVA: 0xBE1C0 Offset: 0xBD5C0 VA: 0x1800BE1C0
	public int texelsPerMeter; // 0x28
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float overlayOpacity; // 0x2C
	public bool showHUD; // 0x30
	private Camera mainCamera; // 0x38
	private bool initialized; // 0x40
	private int screenWidth; // 0x44
	private int screenHeight; // 0x48
	private Camera texelDensityCamera; // 0x50
	private RenderTexture texelDensityRT; // 0x58
	private Texture texelDensityGradTex; // 0x60
	private Material texelDensityOverlayMat; // 0x68
	private static VisualizeTexelDensity instance; // 0x0

	// Properties
	public static VisualizeTexelDensity Instance { get; }

	// Methods

	// RVA: 0x7DFA80 Offset: 0x7DEE80 VA: 0x1807DFA80
	public static VisualizeTexelDensity get_Instance() { }

	// RVA: 0x7DE3F0 Offset: 0x7DD7F0 VA: 0x1807DE3F0
	private void Awake() { }

	// RVA: 0x7DE9B0 Offset: 0x7DDDB0 VA: 0x1807DE9B0
	private void OnEnable() { }

	// RVA: 0x7DE930 Offset: 0x7DDD30 VA: 0x1807DE930
	private void OnDisable() { }

	// RVA: 0x7DE7D0 Offset: 0x7DDBD0 VA: 0x1807DE7D0
	private void LoadResources() { }

	// RVA: 0x7DF2E0 Offset: 0x7DE6E0 VA: 0x1807DF2E0
	private void SafeDestroyViewTexelDensity() { }

	// RVA: 0x7DF1F0 Offset: 0x7DE5F0 VA: 0x1807DF1F0
	private void SafeDestroyViewTexelDensityRT() { }

	// RVA: 0x7DF470 Offset: 0x7DE870 VA: 0x1807DF470
	private void UpdateViewTexelDensity(bool screenResized) { }

	// RVA: 0x7DE470 Offset: 0x7DD870 VA: 0x1807DE470
	private bool CheckScreenResized(int width, int height) { }

	// RVA: 0x7DF080 Offset: 0x7DE480 VA: 0x1807DF080
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x7DE490 Offset: 0x7DD890 VA: 0x1807DE490
	private void DrawGUIText(float x, float y, Vector2 size, string text, GUIStyle fontStyle) { }

	// RVA: 0x7DEB70 Offset: 0x7DDF70 VA: 0x1807DEB70
	private void OnGUI() { }

	// RVA: 0x7DFA20 Offset: 0x7DEE20 VA: 0x1807DFA20
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

