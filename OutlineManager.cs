public class OutlineManager : MonoBehaviour, IClientComponent // TypeDefIndex: 10092
{
	public static Material blurMat; 
	public List<OutlineObject> objectsToRender; 
	public float blurAmount; 
	public Material glowSolidMaterial; 
	public Material blendGlowMaterial; 
	public static float worldModelDistance; 
	private float nextUpdateTime; 


	private void BlurCreate() { }

	private void BlurDestroy() { }

	public static void BlurRT(RenderTexture myRT, float radius, int passNum) { }

	public void OnEnable() { }

	public void OnDestroy() { }

	public void Update() { }

	public void UpdateOutlines() { }

	public void ClearOutlines() { }

	public void CleanupOutlines() { }

	[ImageEffectOpaque] 
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

	private static void .cctor() { }

}

