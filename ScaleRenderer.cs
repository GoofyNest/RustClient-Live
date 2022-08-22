public class ScaleRenderer : MonoBehaviour // TypeDefIndex: 9361
{	public bool useRandomScale; // 0x18
	public float scaleMin; // 0x1C
	public float scaleMax; // 0x20
	private float lastScale; // 0x24
	protected bool hasInitialValues; // 0x28
	public Renderer myRenderer; // 0x30


	private bool ScaleDifferent(float newScale) { }

	public void Start() { }

	public void SetScale(float scale) { }

	public virtual void SetScale_Internal(float scale) { }

	public virtual void SetRendererEnabled(bool isEnabled) { }

	public virtual void GatherInitialValues() { }

	public void .ctor() { }

}

