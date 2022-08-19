public class RendererBatch : MonoBehaviour, IClientComponent // TypeDefIndex: 9915
{
// Namespace: 
public class RendererBatch : MonoBehaviour, IClientComponent // TypeDefIndex: 9915
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform <BatchTransform>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshRenderer <BatchRenderer>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshFilter <BatchFilter>k__BackingField; // 0x28
	private bool disabled; // 0x30
	private RendererGroup batchGroup; // 0x38
	private MeshRendererInstance batchInstance; // 0x40

	// Properties
	public Transform BatchTransform { get; set; }
	public MeshRenderer BatchRenderer { get; set; }
	public MeshFilter BatchFilter { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Transform get_BatchTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_BatchTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public MeshRenderer get_BatchRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_BatchRenderer(MeshRenderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public MeshFilter get_BatchFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	public void set_BatchFilter(MeshFilter value) { }

	// RVA: 0x92CED0 Offset: 0x92C2D0 VA: 0x18092CED0
	protected void OnEnable() { }

	// RVA: 0x92CE60 Offset: 0x92C260 VA: 0x18092CE60
	protected void OnDisable() { }

	// RVA: 0x92C8A0 Offset: 0x92BCA0 VA: 0x18092C8A0
	public void Add() { }

	// RVA: 0x92CFA0 Offset: 0x92C3A0 VA: 0x18092CFA0
	public void Remove() { }

	// RVA: 0x92CF80 Offset: 0x92C380 VA: 0x18092CF80
	public void Refresh() { }

	// RVA: 0x92C730 Offset: 0x92BB30 VA: 0x18092C730
	public void AddBatch(RendererGroup batchGroup) { }

	// RVA: 0x92D0F0 Offset: 0x92C4F0 VA: 0x18092D0F0
	public void WorkshopMode() { }

	// RVA: 0x92D0D0 Offset: 0x92C4D0 VA: 0x18092D0D0
	public void Toggle(bool state) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

