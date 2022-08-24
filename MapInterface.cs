public class MapInterface : SingletonComponent<MapInterface> // TypeDefIndex: 10951
{
	public static bool IsOpen; 
	public Image cameraPositon; 
	public ScrollRectEx scrollRect; 
	public Toggle showGridToggle; 
	public Button FocusButton; 
	public CanvasGroup CanvasGroup; 
	public SoundDefinition PlaceMarkerSound; 
	public SoundDefinition ClearMarkerSound; 
	public MapView View; 
	public Color[] PointOfInterestColours; 
	public Sprite[] PointOfInterestSprites; 
	public bool DebugStayOpen; 
	private PointerEventData pointerData; 
	private List<RaycastResult> rayResults; 
	public static float LastOpened; 
	private NeedsCursor NeedsCursor; 
	private NeedsMouseButtons NeedsMouseButtons; 
	private NeedsMouseWheel NeedsMouseWheel; 
	private Vector3 rmbStartPos; 
	private float rmbStartTime; 
	internal static MapEntity lastActiveMap; 

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

