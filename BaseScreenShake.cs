public abstract class BaseScreenShake : MonoBehaviour // TypeDefIndex: 9364
{	// Fields
	public static List<BaseScreenShake> list; // 0x0
	internal static float punchFadeScale; // 0x8
	internal static float bobScale; // 0xC
	internal static float animPunchMagnitude; // 0x10
	public float length; // 0x18
	internal float timeTaken; // 0x1C
	private int currentFrame; // 0x20

	// Methods

	// RVA: 0x90A780 Offset: 0x909B80 VA: 0x18090A780
	public static void Apply(Camera cam, BaseViewModel vm) { }

	// RVA: 0x90B410 Offset: 0x90A810 VA: 0x18090B410
	protected void OnEnable() { }

	// RVA: 0x90B360 Offset: 0x90A760 VA: 0x18090B360
	protected void OnDisable() { }

	// RVA: 0x90B4A0 Offset: 0x90A8A0 VA: 0x18090B4A0
	public void Run(ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Setup();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm);

	// RVA: 0x90B630 Offset: 0x90AA30 VA: 0x18090B630
	protected void .ctor() { }

	// RVA: 0x90B590 Offset: 0x90A990 VA: 0x18090B590
	private static void .cctor() { }

}

