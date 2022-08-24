public class LightingOverride : MonoBehaviour // TypeDefIndex: 6634
{
	public bool overrideAmbientLight; 
	public AmbientMode ambientMode; 
	public Color ambientGroundColor; 
	public Color ambientEquatorColor; 
	public Color ambientLight; 
	public float ambientIntensity; 
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

