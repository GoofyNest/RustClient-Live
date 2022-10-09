public static class CameraEx // TypeDefIndex: 5616
{

	[ExtensionAttribute] 
	public static void FocusOnRenderer(Camera cam, GameObject obj, Vector3 lookDirection, Vector3 Up, int layerMask = -1) { }

	[ExtensionAttribute] 
	public static void SaveScreenshot(Camera cam, string name, int width, int height, bool transparent, int SuperSampleSize, Nullable<Color> background) { }

}

public class CameraEx : MonoBehaviour // TypeDefIndex: 12939
{
	public bool overrideAmbientLight; 
	public AmbientMode ambientMode; 
	public Color ambientGroundColor; 
	public Color ambientEquatorColor; 
	public Color ambientLight; 
	public float ambientIntensity; 
	public ReflectionProbe reflectionProbe; 
	internal Color old_ambientLight; 
	internal Color old_ambientGroundColor; 
	internal Color old_ambientEquatorColor; 
	internal float old_ambientIntensity; 
	internal AmbientMode old_ambientMode; 
	public float aspect; 


	private void OnPreRender() { }

	private void OnPostRender() { }

	public void .ctor() { }

}

