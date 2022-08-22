public class MapInterface : SingletonComponent<MapInterface> // TypeDefIndex: 10951
{	public static bool IsOpen; // 0x0
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

	private static BasePlayer LocalPlayerEntity { get; }
	public static MapEntity localPlayerMap { get; }


	private static BasePlayer get_LocalPlayerEntity() { }

	public static void SetOpen(bool open) { }

	protected override void Awake() { }

	private void OnEnable() { }

	public void FollowPlayer() { }

	private void OnDisable() { }

	public static void ResetMap() { }

	private void Update() { }

	private void MarkerInput() { }

	public static MapEntity get_localPlayerMap() { }

	private void ForceOpen(bool open) { }

	public void GetPointOfInterestSettings(int index, out Sprite resultSprite, out Color resultColour) { }

	public void .ctor() { }

	private static void .cctor() { }

}

