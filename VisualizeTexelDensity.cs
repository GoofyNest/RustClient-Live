public class VisualizeTexelDensity : MonoBehaviour // TypeDefIndex: 11529
{
	public Shader shader; 
	public string shaderTag; 
	[RangeAttribute] 
	public int texelsPerMeter; 
	[RangeAttribute] 
	public float overlayOpacity; 
	public bool showHUD; 
	private Camera mainCamera; 
	private bool initialized; 
	private int screenWidth; 
	private int screenHeight; 
	private Camera texelDensityCamera; 
	private RenderTexture texelDensityRT; 
	private Texture texelDensityGradTex; 
	private Material texelDensityOverlayMat; 
	private static VisualizeTexelDensity instance; 

	public static VisualizeTexelDensity Instance { get; }


	public static VisualizeTexelDensity get_Instance() { }

	private void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void LoadResources() { }

	private void SafeDestroyViewTexelDensity() { }

	private void SafeDestroyViewTexelDensityRT() { }

	private void UpdateViewTexelDensity(bool screenResized) { }

	private bool CheckScreenResized(int width, int height) { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void DrawGUIText(float x, float y, Vector2 size, string text, GUIStyle fontStyle) { }

	private void OnGUI() { }

	public void .ctor() { }

	private static void .cctor() { }

}

