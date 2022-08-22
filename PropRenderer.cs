public class PropRenderer : MonoBehaviour, IClientComponent // TypeDefIndex: 6623
{	public bool HideLowLods; // 0x18
	public bool HideUnskinnable; // 0x19
	public bool Outline; // 0x1A
	[HeaderAttribute] // RVA: 0xBB980 Offset: 0xBAD80 VA: 0x1800BB980
	public Vector3 Rotation; // 0x1C
	public Vector3 PostRotation; // 0x28
	[HeaderAttribute] // RVA: 0xBBA30 Offset: 0xBAE30 VA: 0x1800BBA30
	public Vector3 PositionalTweak; // 0x34
	[HeaderAttribute] // RVA: 0x71D40 Offset: 0x71140 VA: 0x180071D40
	public float FieldOfView; // 0x40
	public Vector3 LookDirection; // 0x44
	public Vector3 UpDirection; // 0x50


	public void DebugAlign() { }

	public void PositionCamera(Camera cam) { }

	public void PreRender() { }

	public void PostRender() { }

	[ContextMenu] // RVA: 0xBBBD0 Offset: 0xBAFD0 VA: 0x1800BBBD0
	public void CreateIcon() { }

	[ContextMenu] // RVA: 0xBBC40 Offset: 0xBB040 VA: 0x1800BBC40
	public void CreateRender() { }

	private static float DefaultLightIntensityScale(float intensity) { }

	public void CreateScreenshot(string filename, int width, int height, int SuperSampleSize = 1, PropRenderer.LightIntensityScale lightIntensityScale) { }

	public static bool RenderScreenshot(GameObject prefab, string filename, int width, int height, int SuperSampleSize = 1) { }

	public void .ctor() { }

}

public sealed class PropRenderer.LightIntensityScale : MulticastDelegate // TypeDefIndex: 6624
{
	public void .ctor(object object, IntPtr method) { }

	public virtual float Invoke(float intensity) { }

	public virtual IAsyncResult BeginInvoke(float intensity, AsyncCallback callback, object object) { }

	public virtual float EndInvoke(IAsyncResult result) { }

}

