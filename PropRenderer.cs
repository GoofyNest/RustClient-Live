public class PropRenderer : MonoBehaviour, IClientComponent // TypeDefIndex: 6623
{	// Fields
	public bool HideLowLods; // 0x18
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

	// Methods

	// RVA: 0x1BA5130 Offset: 0x1BA4530 VA: 0x181BA5130
	public void DebugAlign() { }

	// RVA: 0x1BA5200 Offset: 0x1BA4600 VA: 0x181BA5200
	public void PositionCamera(Camera cam) { }

	// RVA: 0x1BA5900 Offset: 0x1BA4D00 VA: 0x181BA5900
	public void PreRender() { }

	// RVA: 0x1BA5760 Offset: 0x1BA4B60 VA: 0x181BA5760
	public void PostRender() { }

	[ContextMenu] // RVA: 0xBBBD0 Offset: 0xBAFD0 VA: 0x1800BBBD0
	// RVA: 0x1BA4270 Offset: 0x1BA3670 VA: 0x181BA4270
	public void CreateIcon() { }

	[ContextMenu] // RVA: 0xBBC40 Offset: 0xBB040 VA: 0x1800BBC40
	// RVA: 0x1BA4570 Offset: 0x1BA3970 VA: 0x181BA4570
	public void CreateRender() { }

	// RVA: 0x1BA5190 Offset: 0x1BA4590 VA: 0x181BA5190
	private static float DefaultLightIntensityScale(float intensity) { }

	// RVA: 0x1BA4870 Offset: 0x1BA3C70 VA: 0x181BA4870
	public void CreateScreenshot(string filename, int width, int height, int SuperSampleSize = 1, PropRenderer.LightIntensityScale lightIntensityScale) { }

	// RVA: 0x1BA5CE0 Offset: 0x1BA50E0 VA: 0x181BA5CE0
	public static bool RenderScreenshot(GameObject prefab, string filename, int width, int height, int SuperSampleSize = 1) { }

	// RVA: 0x1BA5EB0 Offset: 0x1BA52B0 VA: 0x181BA5EB0
	public void .ctor() { }

}

public sealed class PropRenderer.LightIntensityScale : MulticastDelegate // TypeDefIndex: 6624
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19F6C20 Offset: 0x19F6020 VA: 0x1819F6C20 Slot: 12
	public virtual float Invoke(float intensity) { }

	// RVA: 0x1B9E120 Offset: 0x1B9D520 VA: 0x181B9E120 Slot: 13
	public virtual IAsyncResult BeginInvoke(float intensity, AsyncCallback callback, object object) { }

	// RVA: 0x19F3F10 Offset: 0x19F3310 VA: 0x1819F3F10 Slot: 14
	public virtual float EndInvoke(IAsyncResult result) { }

}

