public class ImageEffectLayer : FacepunchBehaviour // TypeDefIndex: 8032
{	protected int sortOrder; // 0x18
	private IImageEffect[] effects; // 0x20
	internal bool _layerEnabled; // 0x28

	public int SortOrder { get; }
	public IImageEffect[] Effects { get; }
	public bool layerEnabled { get; set; }


	public int get_SortOrder() { }

	public IImageEffect[] get_Effects() { }

	public virtual void Start() { }

	public virtual void OnDisable() { }

	public bool get_layerEnabled() { }

	public void set_layerEnabled(bool value) { }

	public void .ctor() { }

}

