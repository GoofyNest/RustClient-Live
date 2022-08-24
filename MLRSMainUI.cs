public class MLRSMainUI : MonoBehaviour // TypeDefIndex: 9723
{
	[SerializeField] 
	private bool isFullscreen; 
	[SerializeField] 
	private GameObject noAimingModuleModeGO; 
	[SerializeField] 
	private GameObject activeModeGO; 
	[SerializeField] 
	private MLRSAmmoUI noAimingModuleAmmoUI; 
	[SerializeField] 
	private MLRSAmmoUI activeAmmoUI; 
	[SerializeField] 
	private MLRSVelocityUI velocityUI; 
	[SerializeField] 
	private RustText titleText; 
	[SerializeField] 
	private RustText usernameText; 
	[SerializeField] 
	private TokenisedPhrase readyStatus; 
	[SerializeField] 
	private TokenisedPhrase realigningStatus; 
	[SerializeField] 
	private TokenisedPhrase firingStatus; 
	[SerializeField] 
	private RustText statusText; 
	[SerializeField] 
	private MapView mapView; 
	[SerializeField] 
	private ScrollRectEx mapScrollRect; 
	[SerializeField] 
	private ScrollRectZoom mapScrollRectZoom; 
	[SerializeField] 
	private RectTransform mapBaseRect; 
	[SerializeField] 
	private RectTransform minRangeCircle; 
	[SerializeField] 
	private RectTransform targetAimRect; 
	[SerializeField] 
	private RectTransform trueAimRect; 
	[SerializeField] 
	private UILineRenderer connectingLine; 
	[SerializeField] 
	private GameObject noTargetCirclePrefab; 
	[SerializeField] 
	private Transform noTargetCircleParent; 
	[SerializeField] 
	private SoundDefinition changeTargetSoundDef; 
	[SerializeField] 
	private SoundDefinition readyToFireSoundDef; 
	private MLRS mlrs; 
	private MLRSAmmoUI curAmmoUI; 
	private Nullable<bool> hadAimingModule; 
	private float world2MapScale; 
	private Vector3 mouseStartPos; 
	private bool wasReadyToFire; 
	private float lastReadyToFireSoundPlayed; 
	private float readyToFireSoundInterval; 


	public void Init(MLRS mlrs) { }

	protected void Start() { }

	protected void OnDisable() { }

	protected void Update() { }

	public string GetTitleText() { }

	public void SetTitleText(string text) { }

	public void CentreMap() { }

	private void ActiveUIUpdateTick() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] 
	private bool <ActiveUIUpdateTick>g__MouseIsOverTheMap|39_0() { }

}

