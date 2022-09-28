public class ImageEffectLayer : FacepunchBehaviour // TypeDefIndex: 8006
{
	protected int sortOrder; 
	private IImageEffect[] effects; 
	internal bool _layerEnabled; 

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

