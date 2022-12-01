public abstract class Graph : MonoBehaviour // TypeDefIndex: 12708
{
	public Material Material;
	public int Resolution;
	public Vector2 ScreenFill;
	public Vector2 ScreenOrigin;
	public Vector2 Pivot;
	public Rect Area;
	internal float CurrentValue;
	private int index;
	private float[] values;
	private float max;


	protected abstract float GetValue();

	protected abstract Color GetColor(float value);

	protected Vector3 GetVertex(float x, float y) { }

	protected void Update() { }

	protected void OnGUI() { }

	protected void .ctor() { }

}

