public class MaterialColorLerp : MonoBehaviour, IClientComponent // TypeDefIndex: 9638
{	// Fields
	public Color startColor; // 0x18
	public Color endColor; // 0x28
	public Color currentColor; // 0x38
	public float delta; // 0x48
	private static MaterialPropertyBlock materialPropertyBlock; // 0x0
	private bool initialized; // 0x4C
	private float lerpStartTime; // 0x50
	private List<Renderer> cachedRenderers; // 0x58

	// Methods

	// RVA: 0x955AF0 Offset: 0x954EF0 VA: 0x180955AF0
	public void OnEnable() { }

	// RVA: 0x955AF0 Offset: 0x954EF0 VA: 0x180955AF0
	private void Init() { }

	// RVA: 0x955B90 Offset: 0x954F90 VA: 0x180955B90
	public void SetColorScale(float scale) { }

	// RVA: 0x955EF0 Offset: 0x9552F0 VA: 0x180955EF0
	public void Update() { }

	// RVA: 0x955B30 Offset: 0x954F30 VA: 0x180955B30
	public void RefreshRenderers() { }

	// RVA: 0x955C40 Offset: 0x955040 VA: 0x180955C40
	private void UpdateMaterials(Color final) { }

	// RVA: 0x956040 Offset: 0x955440 VA: 0x180956040
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

