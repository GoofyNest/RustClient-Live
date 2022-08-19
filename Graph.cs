public abstract class Graph : MonoBehaviour // TypeDefIndex: 10932
{	// Fields
	public Material Material; // 0x18
	public int Resolution; // 0x20
	public Vector2 ScreenFill; // 0x24
	public Vector2 ScreenOrigin; // 0x2C
	public Vector2 Pivot; // 0x34
	public Rect Area; // 0x3C
	internal float CurrentValue; // 0x4C
	private int index; // 0x50
	private float[] values; // 0x58
	private float max; // 0x60

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract float GetValue();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract Color GetColor(float value);

	// RVA: 0xC839D0 Offset: 0xC82DD0 VA: 0x180C839D0
	protected Vector3 GetVertex(float x, float y) { }

	// RVA: 0xC83E70 Offset: 0xC83270 VA: 0x180C83E70
	protected void Update() { }

	// RVA: 0xC83A00 Offset: 0xC82E00 VA: 0x180C83A00
	protected void OnGUI() { }

	// RVA: 0xC84050 Offset: 0xC83450 VA: 0x180C84050
	protected void .ctor() { }

}

