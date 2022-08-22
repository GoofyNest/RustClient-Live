public class EmissionToggle : MonoBehaviour, IClientComponent // TypeDefIndex: 9343
{	private Color emissionColor; // 0x18
	public Renderer[] targetRenderers; // 0x28
	public int materialIndex; // 0x30
	private bool inited; // 0x34
	private Nullable<float> emissionPercent; // 0x38
	private static MaterialPropertyBlock block; // 0x0
	private static int emissionColorID; // 0x8


	public void OnEnable() { }

	private void Init() { }

	public void SetEmissionEnabled(bool on) { }

	public void SetEmission(float percent) { }

	public void .ctor() { }

	private static void .cctor() { }

}

