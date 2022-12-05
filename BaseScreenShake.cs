public abstract class BaseScreenShake : MonoBehaviour // TypeDefIndex: 11106
{
	public static List<BaseScreenShake> list;
	internal static float punchFadeScale;
	internal static float bobScale;
	internal static float animPunchMagnitude;
	public float length;
	internal float timeTaken;
	private int currentFrame;


	public static void Apply(Camera cam, BaseViewModel vm) { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void Run(ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm) { }

	public abstract void Setup();

	public abstract void Run(float delta, ref CachedTransform<Camera> cam, ref CachedTransform<BaseViewModel> vm);

	protected void .ctor() { }

	private static void .cctor() { }

}

