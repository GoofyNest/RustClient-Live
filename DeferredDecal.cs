public class DeferredDecal : MonoBehaviour // TypeDefIndex: 12327
{
	public Mesh mesh; 
	public Material material; 
	public DeferredDecalQueue queue; 
	public bool applyImmediately; 
	[CompilerGeneratedAttribute] 
	private bool <IsDecalEnabled>k__BackingField; 
	private bool cached; 
	private Matrix4x4 localToWorldMatrix; 

	public bool IsDecalEnabled { get; set; }
	public Matrix4x4 matrix { get; }


	[CompilerGeneratedAttribute] 
	public bool get_IsDecalEnabled() { }

	[CompilerGeneratedAttribute] 
	private void set_IsDecalEnabled(bool value) { }

	public Matrix4x4 get_matrix() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void DisableDecal() { }

	public void EnableDecal() { }

	public void .ctor() { }

}

