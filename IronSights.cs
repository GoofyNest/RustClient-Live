public class IronSights : MonoBehaviour // TypeDefIndex: 13190
{
	public bool Enabled; 
	[HeaderAttribute] 
	public IronsightAimPoint aimPoint; 
	public float fieldOfViewOffset; 
	public float zoomFactor; 
	[HeaderAttribute] 
	public float introSpeed; 
	public AnimationCurve introCurve; 
	public float outroSpeed; 
	public AnimationCurve outroCurve; 
	[HeaderAttribute] 
	public SoundDefinition upSound; 
	public SoundDefinition downSound; 
	[HeaderAttribute] 
	public IronSightOverride ironsightsOverride; 
	public bool processUltrawideOffset; 
	private Animator animator; 
	private int param_ironsightstrength; 
	private int param_ironsightsEnabled; 
	private float delta; 
	private float rawDelta; 
	private float maxDelta; 
	private Vector3 positionOffset; 
	private Quaternion rotationOffset; 
	private AnimationCurve currentCurve; 


	public void OnEnable() { }

	public void Update() { }

	public void UpdateIronsights(ref CachedTransform<BaseViewModel> vm, Camera cam) { }

	private float GetUltrawideOffset() { }

	public void SetIronsightsEnabled(bool b) { }

	public void SetEnabled(bool val) { }

	public float GetFOVOffset(float fFOV) { }

	public float GetDelta() { }

	public void .ctor() { }

}

