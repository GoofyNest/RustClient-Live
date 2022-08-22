public class MLRSMainUI : MonoBehaviour // TypeDefIndex: 9723
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool isFullscreen; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject noAimingModuleModeGO; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject activeModeGO; // 0x28
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MLRSAmmoUI noAimingModuleAmmoUI; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MLRSAmmoUI activeAmmoUI; // 0x38
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MLRSVelocityUI velocityUI; // 0x40
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RustText titleText; // 0x48
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RustText usernameText; // 0x50
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TokenisedPhrase readyStatus; // 0x58
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TokenisedPhrase realigningStatus; // 0x60
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TokenisedPhrase firingStatus; // 0x68
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RustText statusText; // 0x70
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MapView mapView; // 0x78
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ScrollRectEx mapScrollRect; // 0x80
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ScrollRectZoom mapScrollRectZoom; // 0x88
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform mapBaseRect; // 0x90
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform minRangeCircle; // 0x98
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform targetAimRect; // 0xA0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RectTransform trueAimRect; // 0xA8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private UILineRenderer connectingLine; // 0xB0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject noTargetCirclePrefab; // 0xB8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform noTargetCircleParent; // 0xC0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition changeTargetSoundDef; // 0xC8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private SoundDefinition readyToFireSoundDef; // 0xD0
	private MLRS mlrs; // 0xD8
	private MLRSAmmoUI curAmmoUI; // 0xE0
	private Nullable<bool> hadAimingModule; // 0xE8
	private float world2MapScale; // 0xEC
	private Vector3 mouseStartPos; // 0xF0
	private bool wasReadyToFire; // 0xFC
	private float lastReadyToFireSoundPlayed; // 0x100
	private float readyToFireSoundInterval; // 0x104


	public void Init(MLRS mlrs) { }

	protected void Start() { }

	protected void OnDisable() { }

	protected void Update() { }

	public string GetTitleText() { }

	public void SetTitleText(string text) { }

	public void CentreMap() { }

	private void ActiveUIUpdateTick() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <ActiveUIUpdateTick>g__MouseIsOverTheMap|39_0() { }

}

