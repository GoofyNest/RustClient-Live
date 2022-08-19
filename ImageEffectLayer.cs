public class ImageEffectLayer : FacepunchBehaviour // TypeDefIndex: 8032
{	// Fields
	protected int sortOrder; // 0x18
	private IImageEffect[] effects; // 0x20
	internal bool _layerEnabled; // 0x28

	// Properties
	public int SortOrder { get; }
	public IImageEffect[] Effects { get; }
	public bool layerEnabled { get; set; }

	// Methods

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_SortOrder() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public IImageEffect[] get_Effects() { }

	// RVA: 0x1068840 Offset: 0x1067C40 VA: 0x181068840 Slot: 4
	public virtual void Start() { }

	// RVA: 0x1068750 Offset: 0x1067B50 VA: 0x181068750 Slot: 5
	public virtual void OnDisable() { }

	// RVA: 0x9775C0 Offset: 0x9769C0 VA: 0x1809775C0
	public bool get_layerEnabled() { }

	// RVA: 0x10689E0 Offset: 0x1067DE0 VA: 0x1810689E0
	public void set_layerEnabled(bool value) { }

	// RVA: 0x10689D0 Offset: 0x1067DD0 VA: 0x1810689D0
	public void .ctor() { }

}

