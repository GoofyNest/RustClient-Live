public class PropRenderer : MonoBehaviour, IClientComponent // TypeDefIndex: 6635
{
	public bool HideLowLods;
	public bool HideUnskinnable;
	public bool Outline;
	[HeaderAttribute]
	public Vector3 Rotation;
	public Vector3 PostRotation;
	[HeaderAttribute]
	public Vector3 PositionalTweak;
	[HeaderAttribute]
	public float FieldOfView;
	public Vector3 LookDirection;
	public Vector3 UpDirection;
	public GameObject[] HideDuringRender;


	public void DebugAlign() { }

	public void PositionCamera(Camera cam) { }

	public void PreRender() { }

	public void PostRender() { }

	[ContextMenu]
	public void CreateIcon() { }

	[ContextMenu]
	public void CreateRender() { }

	private static float DefaultLightIntensityScale(float intensity) { }

	public void CreateScreenshot(string filename, int width, int height, int SuperSampleSize = 1, PropRenderer.LightIntensityScale lightIntensityScale) { }

	public static bool RenderScreenshot(GameObject prefab, string filename, int width, int height, int SuperSampleSize = 1) { }

	public void .ctor() { }

}

public sealed class PropRenderer.LightIntensityScale : MulticastDelegate // TypeDefIndex: 6636
{

	public void .ctor(object object, IntPtr method) { }

	public virtual float Invoke(float intensity) { }

	public virtual IAsyncResult BeginInvoke(float intensity, AsyncCallback callback, object object) { }

	public virtual float EndInvoke(IAsyncResult result) { }

}

