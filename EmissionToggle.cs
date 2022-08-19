public class EmissionToggle : MonoBehaviour, IClientComponent // TypeDefIndex: 9343
{	// Fields
	private Color emissionColor; // 0x18
	public Renderer[] targetRenderers; // 0x28
	public int materialIndex; // 0x30
	private bool inited; // 0x34
	private Nullable<float> emissionPercent; // 0x38
	private static MaterialPropertyBlock block; // 0x0
	private static int emissionColorID; // 0x8

	// Methods

	// RVA: 0x8B13D0 Offset: 0x8B07D0 VA: 0x1808B13D0
	public void OnEnable() { }

	// RVA: 0x8B1170 Offset: 0x8B0570 VA: 0x1808B1170
	private void Init() { }

	// RVA: 0x8B13E0 Offset: 0x8B07E0 VA: 0x1808B13E0
	public void SetEmissionEnabled(bool on) { }

	// RVA: 0x8B1410 Offset: 0x8B0810 VA: 0x1808B1410
	public void SetEmission(float percent) { }

	// RVA: 0x8B1670 Offset: 0x8B0A70 VA: 0x1808B1670
	public void .ctor() { }

	// RVA: 0x8B1620 Offset: 0x8B0A20 VA: 0x1808B1620
	private static void .cctor() { }

}

