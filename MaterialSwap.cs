public class MaterialSwap : MonoBehaviour, IClientComponent // TypeDefIndex: 11072
{
	public int materialIndex; 
	public Renderer myRenderer; 
	public Material OverrideMaterial; 
	private bool initialized; 
	private Material[] originalMaterials; 


	public void SetOverrideEnabled(bool on) { }

	public void .ctor() { }

}

