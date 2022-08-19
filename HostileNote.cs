public class HostileNote : MonoBehaviour, IClientComponent // TypeDefIndex: 10933
{	// Fields
	public CanvasGroup warnGroup; // 0x18
	public CanvasGroup group; // 0x20
	public CanvasGroup timerGroup; // 0x28
	public CanvasGroup smallWarning; // 0x30
	public Text timerText; // 0x38
	public Text smallWarningText; // 0x40
	public static float unhostileTime; // 0x0
	public static float weaponDrawnDuration; // 0x4
	public Color warnColor; // 0x48
	public Color hostileColor; // 0x58
	public float requireDistanceToSafeZone; // 0x68
	private TimeSince nextMonumentUpdate; // 0x6C
	private bool isNearSafeZone; // 0x70
	private double lastHostileTimeStringUpdate; // 0x78
	private double lastWeaponDrawnStringUpdate; // 0x80
	private string hostileTimeLeftString; // 0x88

	// Methods

	// RVA: 0x75BFE0 Offset: 0x75B3E0 VA: 0x18075BFE0
	public void Update() { }

	// RVA: 0x75CC70 Offset: 0x75C070 VA: 0x18075CC70
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

