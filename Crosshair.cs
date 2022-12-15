public class Crosshair : BaseMonoBehaviour // TypeDefIndex: 12622
{
	public static bool Enabled;
	public Image Image;
	public RectTransform reticleTransform;
	public CanvasGroup reticleAlpha;
	public RectTransform hitNotifyMarker;
	public CanvasGroup hitNotifyAlpha;
	public static Crosshair instance;
	public static float lastHitTime;
	public float crosshairAlpha;
	internal RectTransform rectTransform;
	public float aimconeMultiplier;
	public float aimconeLerpSpeed;
	private Vector2 hitNotifyStartSize;
	private Vector2 originalReticleSize;
	public GameObjectRef pointsSplashEffect;
	internal int activePoints;


	private void Start() { }

	private void FixedUpdate() { }

	private void Update() { }

	public void PointsEffect() { }

	public void DoPointsSplash(int amount) { }

	private void ClearPoints() { }

	public static void OnHit(bool wasKillShot = False) { }

	private bool ShouldShowCrosshair() { }

	public void .ctor() { }

	private static void .cctor() { }

}

