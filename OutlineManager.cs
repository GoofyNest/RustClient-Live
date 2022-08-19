public class OutlineManager : MonoBehaviour, IClientComponent // TypeDefIndex: 10092
{	// Fields
	public static Material blurMat; // 0x0
	public List<OutlineObject> objectsToRender; // 0x18
	public float blurAmount; // 0x20
	public Material glowSolidMaterial; // 0x28
	public Material blendGlowMaterial; // 0x30
	public static float worldModelDistance; // 0x8
	private float nextUpdateTime; // 0x38

	// Methods

	// RVA: 0xA4BC80 Offset: 0xA4B080 VA: 0x180A4BC80
	private void BlurCreate() { }

	// RVA: 0xA4BDA0 Offset: 0xA4B1A0 VA: 0x180A4BDA0
	private void BlurDestroy() { }

	// RVA: 0xA4BE40 Offset: 0xA4B240 VA: 0x180A4BE40
	public static void BlurRT(RenderTexture myRT, float radius, int passNum) { }

	// RVA: 0xA4BC80 Offset: 0xA4B080 VA: 0x180A4BC80
	public void OnEnable() { }

	// RVA: 0xA4C240 Offset: 0xA4B640 VA: 0x180A4C240
	public void OnDestroy() { }

	// RVA: 0xA4D0D0 Offset: 0xA4C4D0 VA: 0x180A4D0D0
	public void Update() { }

	// RVA: 0xA4CC30 Offset: 0xA4C030 VA: 0x180A4CC30
	public void UpdateOutlines() { }

	// RVA: 0xA4C1F0 Offset: 0xA4B5F0 VA: 0x180A4C1F0
	public void ClearOutlines() { }

	// RVA: 0xA4C0C0 Offset: 0xA4B4C0 VA: 0x180A4C0C0
	public void CleanupOutlines() { }

	[ImageEffectOpaque] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA4C340 Offset: 0xA4B740 VA: 0x180A4C340
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0xA4D120 Offset: 0xA4C520 VA: 0x180A4D120
	public void .ctor() { }

	// RVA: 0xA4D0E0 Offset: 0xA4C4E0 VA: 0x180A4D0E0
	private static void .cctor() { }

}

