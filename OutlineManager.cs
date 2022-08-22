public class OutlineManager : MonoBehaviour, IClientComponent // TypeDefIndex: 10092
{	public static Material blurMat; // 0x0
	public List<OutlineObject> objectsToRender; // 0x18
	public float blurAmount; // 0x20
	public Material glowSolidMaterial; // 0x28
	public Material blendGlowMaterial; // 0x30
	public static float worldModelDistance; // 0x8
	private float nextUpdateTime; // 0x38


	private void BlurCreate() { }

	private void BlurDestroy() { }

	public static void BlurRT(RenderTexture myRT, float radius, int passNum) { }

	public void OnEnable() { }

	public void OnDestroy() { }

	public void Update() { }

	public void UpdateOutlines() { }

	public void ClearOutlines() { }

	public void CleanupOutlines() { }

	[ImageEffectOpaque] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

	private static void .cctor() { }

}

