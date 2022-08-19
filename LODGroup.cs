public class LODGroup : Component // TypeDefIndex: 3441
{	// Properties
	public Vector3 localReferencePoint { get; set; }
	public float size { get; set; }
	public LODFadeMode fadeMode { get; set; }
	public bool animateCrossFading { get; set; }
	public bool enabled { get; set; }

	// Methods

	// RVA: 0x18E4990 Offset: 0x18E3D90 VA: 0x1818E4990
	public Vector3 get_localReferencePoint() { }

	// RVA: 0x18E4B50 Offset: 0x18E3F50 VA: 0x1818E4B50
	public void set_localReferencePoint(Vector3 value) { }

	// RVA: 0x18E49E0 Offset: 0x18E3DE0 VA: 0x1818E49E0
	public float get_size() { }

	// RVA: 0x18E4BA0 Offset: 0x18E3FA0 VA: 0x1818E4BA0
	public void set_size(float value) { }

	// RVA: 0x18E4900 Offset: 0x18E3D00 VA: 0x1818E4900
	public LODFadeMode get_fadeMode() { }

	// RVA: 0x18E4AC0 Offset: 0x18E3EC0 VA: 0x1818E4AC0
	public void set_fadeMode(LODFadeMode value) { }

	// RVA: 0x18E4880 Offset: 0x18E3C80 VA: 0x1818E4880
	public bool get_animateCrossFading() { }

	// RVA: 0x18E4A20 Offset: 0x18E3E20 VA: 0x1818E4A20
	public void set_animateCrossFading(bool value) { }

	// RVA: 0x18E48C0 Offset: 0x18E3CC0 VA: 0x1818E48C0
	public bool get_enabled() { }

	// RVA: 0x18E4A70 Offset: 0x18E3E70 VA: 0x1818E4A70
	public void set_enabled(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x96E30 Offset: 0x96230 VA: 0x180096E30
	// RVA: 0x18E47F0 Offset: 0x18E3BF0 VA: 0x1818E47F0
	public void RecalculateBounds() { }

	[FreeFunctionAttribute] // RVA: 0x96F90 Offset: 0x96390 VA: 0x180096F90
	// RVA: 0x18E47B0 Offset: 0x18E3BB0 VA: 0x1818E47B0
	public LOD[] GetLODs() { }

	[FreeFunctionAttribute] // RVA: 0x970C0 Offset: 0x964C0 VA: 0x1800970C0
	// RVA: 0x18E4830 Offset: 0x18E3C30 VA: 0x1818E4830
	public void SetLODs(LOD[] lods) { }

	// RVA: 0x18E4940 Offset: 0x18E3D40 VA: 0x1818E4940
	private void get_localReferencePoint_Injected(out Vector3 ret) { }

	// RVA: 0x18E4B00 Offset: 0x18E3F00 VA: 0x1818E4B00
	private void set_localReferencePoint_Injected(ref Vector3 value) { }

}

