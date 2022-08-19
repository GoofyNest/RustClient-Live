public class Crosshair : BaseMonoBehaviour // TypeDefIndex: 10843
{	// Fields
	public static bool Enabled; // 0x0
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

	// Methods

	// RVA: 0x51F540 Offset: 0x51E940 VA: 0x18051F540
	private void Start() { }

	// RVA: 0x51E800 Offset: 0x51DC00 VA: 0x18051E800
	private void FixedUpdate() { }

	// RVA: 0x51F670 Offset: 0x51EA70 VA: 0x18051F670
	private void Update() { }

	// RVA: 0x51EEB0 Offset: 0x51E2B0 VA: 0x18051EEB0
	public void PointsEffect() { }

	// RVA: 0x51E6B0 Offset: 0x51DAB0 VA: 0x18051E6B0
	public void DoPointsSplash(int amount) { }

	// RVA: 0x51E6A0 Offset: 0x51DAA0 VA: 0x18051E6A0
	private void ClearPoints() { }

	// RVA: 0x51E880 Offset: 0x51DC80 VA: 0x18051E880
	public static void OnHit(bool wasKillShot = False) { }

	// RVA: 0x51EFA0 Offset: 0x51E3A0 VA: 0x18051EFA0
	private bool ShouldShowCrosshair() { }

	// RVA: 0x51FEF0 Offset: 0x51F2F0 VA: 0x18051FEF0
	public void .ctor() { }

	// RVA: 0x51FEA0 Offset: 0x51F2A0 VA: 0x18051FEA0
	private static void .cctor() { }

}

