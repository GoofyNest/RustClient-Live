public class CableCurve // TypeDefIndex: 11733
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2 m_start; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2 m_end; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float m_slack; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int m_steps; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_regen; // 0x28
	private static Vector2[] emptyCurve; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2[] points; // 0x30

	public bool regenPoints { get; set; }
	public Vector2 start { get; set; }
	public Vector2 end { get; set; }
	public float slack { get; set; }
	public int steps { get; set; }
	public Vector2 midPoint { get; }


	public bool get_regenPoints() { }

	public void set_regenPoints(bool value) { }

	public Vector2 get_start() { }

	public void set_start(Vector2 value) { }

	public Vector2 get_end() { }

	public void set_end(Vector2 value) { }

	public float get_slack() { }

	public void set_slack(float value) { }

	public int get_steps() { }

	public void set_steps(int value) { }

	public Vector2 get_midPoint() { }

	public void .ctor() { }

	public void .ctor(Vector2[] inputPoints) { }

	public void .ctor(List<Vector2> inputPoints) { }

	public void .ctor(CableCurve v) { }

	public Vector2[] Points() { }

	private static void .cctor() { }

}

