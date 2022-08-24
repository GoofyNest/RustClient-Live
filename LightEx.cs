public class LightEx : UpdateBehaviour, IClientComponent // TypeDefIndex: 9195
{
	public bool alterColor; 
	public float colorTimeScale; 
	public Color colorA; 
	public Color colorB; 
	public AnimationCurve blendCurve; 
	public bool loopColor; 
	public bool alterIntensity; 
	public float intensityTimeScale; 
	public AnimationCurve intenseCurve; 
	public float intensityCurveScale; 
	public bool loopIntensity; 
	public bool randomOffset; 
	public float randomIntensityStartScale; 
	private float initialRange; 
	private Color initialColor; 
	private float initialIntensity; 
	private Light lightComponent; 
	private bool canToggleLight; 
	private float time; 
	private LightLOD lightLOD; 


protected void Awake() { }

protected override void OnEnable() { }

protected override void OnDisable() { }

public override void DeltaUpdate(float deltaTime) { }

protected void OnValidate() { }

public static bool CheckConflict(GameObject go) { }

public void .ctor() { }

}

