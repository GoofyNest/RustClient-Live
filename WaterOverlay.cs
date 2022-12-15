public class WaterOverlay : MonoBehaviour, IClientComponent // TypeDefIndex: 10880
{
	public PostProcessVolume postProcessVolume;
	public WaterOverlay.EffectParams adminParams;
	public WaterOverlay.EffectParams gogglesParams;
	public WaterOverlay.EffectParams submarineParams;
	public WaterOverlay.EffectParams underwaterLabParams;
	public Material[] UnderwaterFogMaterials;
	private WaterOverlay.EffectParams startParams;
	private BlurOptimized blur;
	private Wiggle wiggle;
	private ChromaticAberration chromaticAberration;
	private GodRays godRays;


	protected void Awake() { }

	protected void OnDestroy() { }

	private WaterOverlay.EffectParams GetEffectParams() { }

	private void SetEffectParams(WaterOverlay.EffectParams param) { }

	private void SetUnderwaterFogMaterials(bool fog) { }

	private void UpdateEffectState() { }

	protected void Update() { }

	public void .ctor() { }

}

public struct WaterOverlay.EffectParams // TypeDefIndex: 10881
{
	public float scatterCoefficient;
	public bool blur;
	public float blurDistance;
	public float blurSize;
	public int blurIterations;
	public bool wiggle;
	public float wiggleSpeed;
	public bool chromaticAberration;
	public bool godRays;
	public static WaterOverlay.EffectParams DefaultAdmin;
	public static WaterOverlay.EffectParams DefaultGoggles;
	public static WaterOverlay.EffectParams DefaultSubmarine;
	public static WaterOverlay.EffectParams DefaultUnderwaterLab;


	private static void .cctor() { }

}

