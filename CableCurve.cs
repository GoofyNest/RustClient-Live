public class CableCurve // TypeDefIndex: 13525
{
	[SerializeField] 
	private Vector2 m_start; 
	[SerializeField] 
	private Vector2 m_end; 
	[SerializeField] 
	private float m_slack; 
	[SerializeField] 
	private int m_steps; 
	[SerializeField] 
	private bool m_regen; 
	private static Vector2[] emptyCurve; 
	[SerializeField] 
	private Vector2[] points; 

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

