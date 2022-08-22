public abstract class BaseScreenShake : MonoBehaviour // TypeDefIndex: 9364
{	public static List<BaseScreenShake> list; // 0x0
	internal static float punchFadeScale; // 0x8
	internal static float bobScale; // 0xC
	internal static float animPunchMagnitude; // 0x10
	public float length; // 0x18
	internal float timeTaken; // 0x1C
	private int currentFrame; // 0x20


	public static void Apply(Camera cam, BaseViewModel vm) { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void Run(ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	public abstract void Setup();

	public abstract void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm);

	protected void .ctor() { }

	private static void .cctor() { }

}

