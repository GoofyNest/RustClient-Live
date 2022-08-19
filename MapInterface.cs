public class MapInterface : SingletonComponent<MapInterface> // TypeDefIndex: 10951
{	// Fields
	public static bool IsOpen; // 0x0
	public Image cameraPositon; // 0x18
	public ScrollRectEx scrollRect; // 0x20
	public Toggle showGridToggle; // 0x28
	public Button FocusButton; // 0x30
	public CanvasGroup CanvasGroup; // 0x38
	public SoundDefinition PlaceMarkerSound; // 0x40
	public SoundDefinition ClearMarkerSound; // 0x48
	public MapView View; // 0x50
	public Color[] PointOfInterestColours; // 0x58
	public Sprite[] PointOfInterestSprites; // 0x60
	public bool DebugStayOpen; // 0x68
	private PointerEventData pointerData; // 0x70
	private List<RaycastResult> rayResults; // 0x78
	public static float LastOpened; // 0x4
	private NeedsCursor NeedsCursor; // 0x80
	private NeedsMouseButtons NeedsMouseButtons; // 0x88
	private NeedsMouseWheel NeedsMouseWheel; // 0x90
	private Vector3 rmbStartPos; // 0x98
	private float rmbStartTime; // 0xA4
	internal static MapEntity lastActiveMap; // 0x8

	// Properties
	private static BasePlayer LocalPlayerEntity { get; }
	public static MapEntity localPlayerMap { get; }

	// Methods

	// RVA: 0x57ECF0 Offset: 0x57E0F0 VA: 0x18057ECF0
	private static BasePlayer get_LocalPlayerEntity() { }

	// RVA: 0x57E7B0 Offset: 0x57DBB0 VA: 0x18057E7B0
	public static void SetOpen(bool open) { }

	// RVA: 0x57D880 Offset: 0x57CC80 VA: 0x18057D880 Slot: 6
	protected override void Awake() { }

	// RVA: 0x57E640 Offset: 0x57DA40 VA: 0x18057E640
	private void OnEnable() { }

	// RVA: 0x57D920 Offset: 0x57CD20 VA: 0x18057D920
	public void FollowPlayer() { }

	// RVA: 0x57E560 Offset: 0x57D960 VA: 0x18057E560
	private void OnDisable() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void ResetMap() { }

	// RVA: 0x57E890 Offset: 0x57DC90 VA: 0x18057E890
	private void Update() { }

	// RVA: 0x57DF70 Offset: 0x57D370 VA: 0x18057DF70
	private void MarkerInput() { }

	// RVA: 0x57EDE0 Offset: 0x57E1E0 VA: 0x18057EDE0
	public static MapEntity get_localPlayerMap() { }

	// RVA: 0x57D960 Offset: 0x57CD60 VA: 0x18057D960
	private void ForceOpen(bool open) { }

	// RVA: 0x57DED0 Offset: 0x57D2D0 VA: 0x18057DED0
	public void GetPointOfInterestSettings(int index, out Sprite resultSprite, out Color resultColour) { }

	// RVA: 0x57EC60 Offset: 0x57E060 VA: 0x18057EC60
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

