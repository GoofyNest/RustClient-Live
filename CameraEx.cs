public static class CameraEx // TypeDefIndex: 5612
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19845B0 Offset: 0x19839B0 VA: 0x1819845B0
	public static void FocusOnRenderer(Camera cam, GameObject obj, Vector3 lookDirection, Vector3 Up, int layerMask = -1) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1984F40 Offset: 0x1984340 VA: 0x181984F40
	public static void SaveScreenshot(Camera cam, string name, int width, int height, bool transparent, int SuperSampleSize, Nullable<Color> background) { }

}

public class CameraEx : MonoBehaviour // TypeDefIndex: 11198
{	// Fields
	public bool overrideAmbientLight; // 0x18
	public AmbientMode ambientMode; // 0x1C
	public Color ambientGroundColor; // 0x20
	public Color ambientEquatorColor; // 0x30
	public Color ambientLight; // 0x40
	public float ambientIntensity; // 0x50
	public ReflectionProbe reflectionProbe; // 0x58
	internal Color old_ambientLight; // 0x60
	internal Color old_ambientGroundColor; // 0x70
	internal Color old_ambientEquatorColor; // 0x80
	internal float old_ambientIntensity; // 0x90
	internal AmbientMode old_ambientMode; // 0x94
	public float aspect; // 0x98

	// Methods

	// RVA: 0x710240 Offset: 0x70F640 VA: 0x180710240
	private void OnPreRender() { }

	// RVA: 0x7101A0 Offset: 0x70F5A0 VA: 0x1807101A0
	private void OnPostRender() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

