public class SoundOcclusion : MonoBehaviour // TypeDefIndex: 10770
{
	public LayerMask occlusionLayerMask;
	[CompilerGeneratedAttribute]
	private bool <isOccluded>k__BackingField;
	private float occlusionAmount;
	private Sound sound;
	private OnePoleLowpassFilter lowpass;
	private SoundModulation.Modulator gainMod;
	private Vector3 soundOffset;
	private float lastOcclusionCheck;
	private float occlusionCheckInterval;
	private Ray ray;
	private List<RaycastHit> hits;

	public bool isOccluded { get; set; }


	[CompilerGeneratedAttribute]
	public bool get_isOccluded() { }

	[CompilerGeneratedAttribute]
	private void set_isOccluded(bool value) { }

	public void Awake() { }

	public void Init() { }

	public void UpdateOcclusion(bool lerp = False) { }

	public void DoOcclusionCheck() { }

	public void .ctor() { }

}

