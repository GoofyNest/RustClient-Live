public class ESPCanvas : MonoBehaviour // TypeDefIndex: 12001
{	[TooltipAttribute] // RVA: 0xCAEB0 Offset: 0xCA2B0 VA: 0x1800CAEB0
	public int MaxElements; // 0x18
	[TooltipAttribute] // RVA: 0xCAF50 Offset: 0xCA350 VA: 0x1800CAF50
	public float RefreshRate; // 0x1C
	[TooltipAttribute] // RVA: 0xCB090 Offset: 0xCA490 VA: 0x1800CB090
	public ESPPlayerInfo Source; // 0x20
	[TooltipAttribute] // RVA: 0xCB150 Offset: 0xCA550 VA: 0x1800CB150
	public float MaxDistance; // 0x28
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static float OverrideMaxDisplayDistance; // 0x0
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static bool DisableOcclusionChecks; // 0x4
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static bool ShowHealth; // 0x5
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static bool ColourCodeTeams; // 0x6
	protected ESPPlayerInfo[] Elements; // 0x30
	protected RealTimeSince timeSinceRefreshed; // 0x38
	private static int lastCheckedZoomFrame; // 0x8
	private static bool cachedUsingZoomItem; // 0xC


	public void Awake() { }

	public void Update() { }

	private bool StartWatching(BasePlayer entity) { }

	public bool ShouldShow(BasePlayer ent) { }

	public static bool IsUsingZoomItem() { }

	public void .ctor() { }

	private static void .cctor() { }

}

