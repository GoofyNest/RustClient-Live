public abstract class Graph : MonoBehaviour // TypeDefIndex: 10932
{	public Material Material; // 0x18
	public int Resolution; // 0x20
	public Vector2 ScreenFill; // 0x24
	public Vector2 ScreenOrigin; // 0x2C
	public Vector2 Pivot; // 0x34
	public Rect Area; // 0x3C
	internal float CurrentValue; // 0x4C
	private int index; // 0x50
	private float[] values; // 0x58
	private float max; // 0x60


	protected abstract float GetValue();

	protected abstract Color GetColor(float value);

	protected Vector3 GetVertex(float x, float y) { }

	protected void Update() { }

	protected void OnGUI() { }

	protected void .ctor() { }

}

