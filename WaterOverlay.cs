public class WaterOverlay : MonoBehaviour, IClientComponent // TypeDefIndex: 9137
{	// Fields
	public PostProcessVolume postProcessVolume; // 0x18
	public WaterOverlay.EffectParams adminParams; // 0x20
	public WaterOverlay.EffectParams gogglesParams; // 0x40
	public WaterOverlay.EffectParams submarineParams; // 0x60
	public WaterOverlay.EffectParams underwaterLabParams; // 0x80
	public Material[] UnderwaterFogMaterials; // 0xA0
	private WaterOverlay.EffectParams startParams; // 0xA8
	private BlurOptimized blur; // 0xC8
	private Wiggle wiggle; // 0xD0
	private ChromaticAberration chromaticAberration; // 0xD8
	private GodRays godRays; // 0xE0

	// Methods

	// RVA: 0xC14C50 Offset: 0xC14050 VA: 0x180C14C50
	protected void Awake() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	protected void OnDestroy() { }

	// RVA: 0xC14EC0 Offset: 0xC142C0 VA: 0x180C14EC0
	private WaterOverlay.EffectParams GetEffectParams() { }

	// RVA: 0xC14FB0 Offset: 0xC143B0 VA: 0x180C14FB0
	private void SetEffectParams(WaterOverlay.EffectParams param) { }

	// RVA: 0xC15100 Offset: 0xC14500 VA: 0x180C15100
	private void SetUnderwaterFogMaterials(bool fog) { }

	// RVA: 0xC151A0 Offset: 0xC145A0 VA: 0x180C151A0
	private void UpdateEffectState() { }

	// RVA: 0xC15680 Offset: 0xC14A80 VA: 0x180C15680
	protected void Update() { }

	// RVA: 0xC158D0 Offset: 0xC14CD0 VA: 0x180C158D0
	public void .ctor() { }

}

public struct WaterOverlay.EffectParams // TypeDefIndex: 9138
{	// Fields
	public float scatterCoefficient; // 0x0
	public bool blur; // 0x4
	public float blurDistance; // 0x8
	public float blurSize; // 0xC
	public int blurIterations; // 0x10
	public bool wiggle; // 0x14
	public float wiggleSpeed; // 0x18
	public bool chromaticAberration; // 0x1C
	public bool godRays; // 0x1D
	public static WaterOverlay.EffectParams DefaultAdmin; // 0x0
	public static WaterOverlay.EffectParams DefaultGoggles; // 0x20
	public static WaterOverlay.EffectParams DefaultSubmarine; // 0x40
	public static WaterOverlay.EffectParams DefaultUnderwaterLab; // 0x60

	// Methods

	// RVA: 0xC0B180 Offset: 0xC0A580 VA: 0x180C0B180
	private static void .cctor() { }

}

