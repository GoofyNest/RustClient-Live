public class Crosshair : BaseMonoBehaviour // TypeDefIndex: 10843
{	public static bool Enabled; // 0x0
	public Image Image; // 0x18
	public RectTransform reticleTransform; // 0x20
	public CanvasGroup reticleAlpha; // 0x28
	public RectTransform hitNotifyMarker; // 0x30
	public CanvasGroup hitNotifyAlpha; // 0x38
	public static Crosshair instance; // 0x8
	public static float lastHitTime; // 0x10
	public float crosshairAlpha; // 0x40
	internal RectTransform rectTransform; // 0x48
	public float aimconeMultiplier; // 0x50
	public float aimconeLerpSpeed; // 0x54
	private Vector2 hitNotifyStartSize; // 0x58
	private Vector2 originalReticleSize; // 0x60
	public GameObjectRef pointsSplashEffect; // 0x68
	internal int activePoints; // 0x70


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

