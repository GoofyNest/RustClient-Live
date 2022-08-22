public static class CameraEx // TypeDefIndex: 5612
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void FocusOnRenderer(Camera cam, GameObject obj, Vector3 lookDirection, Vector3 Up, int layerMask = -1) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void SaveScreenshot(Camera cam, string name, int width, int height, bool transparent, int SuperSampleSize, Nullable<Color> background) { }

}

public class CameraEx : MonoBehaviour // TypeDefIndex: 11198
{	public bool overrideAmbientLight; // 0x18
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


	private void OnPreRender() { }

	private void OnPostRender() { }

	public void .ctor() { }

}

