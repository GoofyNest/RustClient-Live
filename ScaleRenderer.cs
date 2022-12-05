public class ScaleRenderer : MonoBehaviour // TypeDefIndex: 11103
{
	public bool useRandomScale;
	public float scaleMin;
	public float scaleMax;
	private float lastScale;
	protected bool hasInitialValues;
	public Renderer myRenderer;


	private bool ScaleDifferent(float newScale) { }

	public void Start() { }

	public void SetScale(float scale) { }

	public virtual void SetScale_Internal(float scale) { }

	public virtual void SetRendererEnabled(bool isEnabled) { }

	public virtual void GatherInitialValues() { }

	public void .ctor() { }

}

