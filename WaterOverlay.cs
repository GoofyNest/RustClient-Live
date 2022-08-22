public class WaterOverlay : MonoBehaviour, IClientComponent // TypeDefIndex: 9137
{	public PostProcessVolume postProcessVolume; // 0x18
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


	protected void Awake() { }

	protected void OnDestroy() { }

	private WaterOverlay.EffectParams GetEffectParams() { }

	private void SetEffectParams(WaterOverlay.EffectParams param) { }

	private void SetUnderwaterFogMaterials(bool fog) { }

	private void UpdateEffectState() { }

	protected void Update() { }

	public void .ctor() { }

}

public struct WaterOverlay.EffectParams // TypeDefIndex: 9138
{	public float scatterCoefficient; // 0x0
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


	private static void .cctor() { }

}

