public class BaseViewModel : MonoBehaviour // TypeDefIndex: 11432
{	// Fields
	public static bool HideViewmodel; // 0x0
	public static BaseViewModel GestureModel; // 0x8
	public static List<BaseViewModel> ActiveModels; // 0x10
	[HeaderAttribute] // RVA: 0xB0530 Offset: 0xAF930 VA: 0x1800B0530
	public LazyAimProperties lazyaimRegular; // 0x18
	public LazyAimProperties lazyaimIronsights; // 0x20
	public Transform pivot; // 0x28
	public bool useViewModelCamera; // 0x30
	public bool wantsHeldItemFlags; // 0x31
	public GameObject[] hideSightMeshes; // 0x38
	public bool isGestureViewModel; // 0x40
	public Transform MuzzlePoint; // 0x48
	[HeaderAttribute] // RVA: 0x7F400 Offset: 0x7E800 VA: 0x18007F400
	public SubsurfaceProfile subsurfaceProfile; // 0x50
	internal Animator animator; // 0x58
	internal AnimationEvents animationEvent; // 0x60
	internal IronSights ironSights; // 0x68
	internal ViewmodelSway sway; // 0x70
	internal ViewmodelLower lower; // 0x78
	internal ViewmodelBob bob; // 0x80
	internal ViewmodelPunch punch; // 0x88
	internal ViewmodelAspectOffset aspectOffset; // 0x90
	internal ViewmodelMountedAnchor mountedAnchor; // 0x98
	internal Model model; // 0xA0
	internal static bool gestureHide; // 0x18
	internal static TimeSince gestureHideTime; // 0x1C
	private static GestureCollection gestureCollection; // 0x20
	private Skeleton Skeleton; // 0xA8
	private GameObject Clothing; // 0xB0
	private bool workshopMode; // 0xB8

	// Properties
	public static BaseViewModel ActiveModel { get; }
	public static bool UsingViewModelCamera { get; }

	// Methods

	// RVA: 0x9192D0 Offset: 0x9186D0 VA: 0x1809192D0
	public static BaseViewModel get_ActiveModel() { }

	// RVA: 0x919480 Offset: 0x918880 VA: 0x180919480
	public static bool get_UsingViewModelCamera() { }

	// RVA: 0x917210 Offset: 0x916610 VA: 0x180917210
	public bool IsOK() { }

	// RVA: 0x918320 Offset: 0x917720 VA: 0x180918320
	public void PreDestroy() { }

	// RVA: 0x917F70 Offset: 0x917370 VA: 0x180917F70
	private void OnEnable() { }

	// RVA: 0x917E00 Offset: 0x917200 VA: 0x180917E00
	private void OnDisable() { }

	// RVA: 0x9164C0 Offset: 0x9158C0 VA: 0x1809164C0
	private void Awake() { }

	// RVA: 0x918F70 Offset: 0x918370 VA: 0x180918F70
	public void UpdateRenderersAndSkin(BasePlayer forPlayer) { }

	// RVA: 0x917DF0 Offset: 0x9171F0 VA: 0x180917DF0
	public void OnClothingChanged(BasePlayer player) { }

	// RVA: 0x9190B0 Offset: 0x9184B0 VA: 0x1809190B0
	private void UpdateRenderers(BasePlayer forPlayer) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void AddHandsModel() { }

	// RVA: 0x918CB0 Offset: 0x9180B0 VA: 0x180918CB0
	private void UpdateClothingModels(BasePlayer player) { }

	// RVA: 0x916410 Offset: 0x915810 VA: 0x180916410
	private void AddClothing(ViewmodelClothing clothing, Item item) { }

	// RVA: 0x9186E0 Offset: 0x917AE0 VA: 0x1809186E0
	private void SetSkinColor(Color skinColor) { }

	// RVA: 0x917270 Offset: 0x916670 VA: 0x180917270
	public void OnCameraPositionChanged(Camera cam) { }

	// RVA: 0x917280 Offset: 0x916680 VA: 0x180917280
	public void OnCameraPositionChanged(Camera cam, BasePlayer player) { }

	// RVA: 0x9170F0 Offset: 0x9164F0 VA: 0x1809170F0
	public LazyAimProperties GetLazyAim() { }

	// RVA: 0x916BD0 Offset: 0x915FD0 VA: 0x180916BD0
	private Quaternion GetGestureRotationOffset(out Vector3 offset) { }

	// RVA: 0x918820 Offset: 0x917C20 VA: 0x180918820
	public static void ToggleGestureHide(bool state) { }

	// RVA: 0x9188E0 Offset: 0x917CE0 VA: 0x1809188E0
	public void TriggerAdmire() { }

	// RVA: 0x9189D0 Offset: 0x917DD0 VA: 0x1809189D0
	public void TriggerAttack() { }

	// RVA: 0x918990 Offset: 0x917D90 VA: 0x180918990
	public void TriggerAttack2() { }

	// RVA: 0x918B10 Offset: 0x917F10 VA: 0x180918B10
	public void TriggerReady() { }

	// RVA: 0x918A10 Offset: 0x917E10 VA: 0x180918A10
	public void TriggerCancel() { }

	// RVA: 0x918A50 Offset: 0x917E50 VA: 0x180918A50
	public void TriggerDeploy() { }

	// RVA: 0x918B50 Offset: 0x917F50 VA: 0x180918B50
	public void TriggerReload() { }

	// RVA: 0x918AD0 Offset: 0x917ED0 VA: 0x180918AD0
	public void TriggerHolster() { }

	// RVA: 0x918A90 Offset: 0x917E90 VA: 0x180918A90
	public void TriggerEmpty() { }

	// RVA: 0x918B90 Offset: 0x917F90 VA: 0x180918B90
	public void Trigger(string name) { }

	// RVA: 0x918C20 Offset: 0x918020 VA: 0x180918C20
	public void Trigger(int hash) { }

	// RVA: 0x9183D0 Offset: 0x9177D0 VA: 0x1809183D0
	public void ResetTrigger(string name) { }

	// RVA: 0x918340 Offset: 0x917740 VA: 0x180918340
	public void ResetTrigger(int hash) { }

	// RVA: 0x918500 Offset: 0x917900 VA: 0x180918500
	public void SetBool(string name, bool bState) { }

	// RVA: 0x918460 Offset: 0x917860 VA: 0x180918460
	public void SetBool(int hash, bool bState) { }

	// RVA: 0x9185A0 Offset: 0x9179A0 VA: 0x1809185A0
	public void SetFloat(string name, float fAmount) { }

	// RVA: 0x918640 Offset: 0x917A40 VA: 0x180918640
	public void SetFloat(int hash, float fAmount) { }

	// RVA: 0x918160 Offset: 0x917560 VA: 0x180918160
	public void Play(string anim, int layer = 0) { }

	// RVA: 0x916A70 Offset: 0x915E70 VA: 0x180916A70
	public void CrossFade(string anim, float fade) { }

	// RVA: 0x917190 Offset: 0x916590 VA: 0x180917190
	public void HideSightMeshes(bool bHide) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	public virtual void OnDeployedNoSkin() { }

	// RVA: 0x9191E0 Offset: 0x9185E0 VA: 0x1809191E0
	public void WorkshopMode() { }

	// RVA: 0x9192C0 Offset: 0x9186C0 VA: 0x1809192C0
	public void .ctor() { }

	// RVA: 0x9191F0 Offset: 0x9185F0 VA: 0x1809191F0
	private static void .cctor() { }

}

