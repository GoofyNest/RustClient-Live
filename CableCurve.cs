public class CableCurve // TypeDefIndex: 11733
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
	public bool regenPoints { get; set; }
	public Vector2 start { get; set; }
	public Vector2 end { get; set; }
	public float slack { get; set; }
	public int steps { get; set; }
	public Vector2 midPoint { get; }

	// Methods

	// RVA: 0x9775C0 Offset: 0x9769C0 VA: 0x1809775C0
	public bool get_regenPoints() { }

	// RVA: 0x9775D0 Offset: 0x9769D0 VA: 0x1809775D0
	public void set_regenPoints(bool value) { }

	// RVA: 0x11CFBD0 Offset: 0x11CEFD0 VA: 0x1811CFBD0
	public Vector2 get_start() { }

	// RVA: 0x11CFD00 Offset: 0x11CF100 VA: 0x1811CFD00
	public void set_start(Vector2 value) { }

	// RVA: 0x11CF950 Offset: 0x11CED50 VA: 0x1811CF950
	public Vector2 get_end() { }

	// RVA: 0x11CFBF0 Offset: 0x11CEFF0 VA: 0x1811CFBF0
	public void set_end(Vector2 value) { }

	// RVA: 0x772400 Offset: 0x771800 VA: 0x180772400
	public float get_slack() { }

	// RVA: 0x11CFC80 Offset: 0x11CF080 VA: 0x1811CFC80
	public void set_slack(float value) { }

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	public int get_steps() { }

	// RVA: 0x11CFD90 Offset: 0x11CF190 VA: 0x1811CFD90
	public void set_steps(int value) { }

	// RVA: 0x11CF970 Offset: 0x11CED70 VA: 0x1811CF970
	public Vector2 get_midPoint() { }

	// RVA: 0x11CF790 Offset: 0x11CEB90 VA: 0x1811CF790
	public void .ctor() { }

	// RVA: 0x11CF8A0 Offset: 0x11CECA0 VA: 0x1811CF8A0
	public void .ctor(Vector2[] inputPoints) { }

	// RVA: 0x11CF630 Offset: 0x11CEA30 VA: 0x1811CF630
	public void .ctor(List<Vector2> inputPoints) { }

	// RVA: 0x11CF700 Offset: 0x11CEB00 VA: 0x1811CF700
	public void .ctor(CableCurve v) { }

	// RVA: 0x11CEF60 Offset: 0x11CE360 VA: 0x1811CEF60
	public Vector2[] Points() { }

	// RVA: 0x11CF540 Offset: 0x11CE940 VA: 0x1811CF540
	private static void .cctor() { }

}

