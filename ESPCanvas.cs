public class ESPCanvas : MonoBehaviour // TypeDefIndex: 13794
{
	[TooltipAttribute] 
	public int MaxElements; 
	[TooltipAttribute] 
	public float RefreshRate; 
	[TooltipAttribute] 
	public ESPPlayerInfo Source; 
	[TooltipAttribute] 
	public float MaxDistance; 
	[ClientVar] 
	public static float OverrideMaxDisplayDistance; 
	[ClientVar] 
	public static bool DisableOcclusionChecks; 
	[ClientVar] 
	public static bool ShowHealth; 
	[ClientVar] 
	public static bool ColourCodeTeams; 
	protected ESPPlayerInfo[] Elements; 
	protected RealTimeSince timeSinceRefreshed; 
	private static int lastCheckedZoomFrame; 
	private static bool cachedUsingZoomItem; 


	public void Awake() { }

	public void Update() { }

	private bool StartWatching(BasePlayer entity) { }

	public bool ShouldShow(BasePlayer ent) { }

	public static bool IsUsingZoomItem() { }

	public void .ctor() { }

	private static void .cctor() { }

}

