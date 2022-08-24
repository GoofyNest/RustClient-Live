public class RendererBatch : MonoBehaviour, IClientComponent // TypeDefIndex: 9915
{

public class RendererBatch : MonoBehaviour, IClientComponent 
	[CompilerGeneratedAttribute] 
	private Transform <BatchTransform>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private MeshRenderer <BatchRenderer>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private MeshFilter <BatchFilter>k__BackingField; 
	private bool disabled; 
	private RendererGroup batchGroup; 
	private MeshRendererInstance batchInstance; 

	public Transform BatchTransform { get; set; }
	public MeshRenderer BatchRenderer { get; set; }
	public MeshFilter BatchFilter { get; set; }


	[CompilerGeneratedAttribute] 
	public Transform get_BatchTransform() { }

	[CompilerGeneratedAttribute] 
	public void set_BatchTransform(Transform value) { }

	[CompilerGeneratedAttribute] 
	public MeshRenderer get_BatchRenderer() { }

	[CompilerGeneratedAttribute] 
	public void set_BatchRenderer(MeshRenderer value) { }

	[CompilerGeneratedAttribute] 
	public MeshFilter get_BatchFilter() { }

	[CompilerGeneratedAttribute] 
	public void set_BatchFilter(MeshFilter value) { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void Add() { }

	public void Remove() { }

	public void Refresh() { }

	public void AddBatch(RendererGroup batchGroup) { }

	public void WorkshopMode() { }

	public void Toggle(bool state) { }

	public void .ctor() { }

}

