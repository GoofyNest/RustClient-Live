public class HostileNote : MonoBehaviour, IClientComponent // TypeDefIndex: 10933
{
	public CanvasGroup warnGroup; 
	public CanvasGroup group; 
	public CanvasGroup timerGroup; 
	public CanvasGroup smallWarning; 
	public Text timerText; 
	public Text smallWarningText; 
	public static float unhostileTime; 
	public static float weaponDrawnDuration; 
	public Color warnColor; 
	public Color hostileColor; 
	public float requireDistanceToSafeZone; 
	private TimeSince nextMonumentUpdate; 
	private bool isNearSafeZone; 
	private double lastHostileTimeStringUpdate; 
	private double lastWeaponDrawnStringUpdate; 
	private string hostileTimeLeftString; 


	public void Update() { }

	public void .ctor() { }

	private static void .cctor() { }

}

