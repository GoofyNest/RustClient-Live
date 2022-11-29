public class Shadow : BaseMeshEffect // TypeDefIndex: 5042
{
	[SerializeField] 
	private Color m_EffectColor; 
	[SerializeField] 
	private Vector2 m_EffectDistance; 
	[SerializeField] 
	private bool m_UseGraphicAlpha; 
	private const float kMaxEffectDistance = 600;

	public Color effectColor { get; set; }
	public Vector2 effectDistance { get; set; }
	public bool useGraphicAlpha { get; set; }


	protected void .ctor() { }

	public Color get_effectColor() { }

	public void set_effectColor(Color value) { }

	public Vector2 get_effectDistance() { }

	public void set_effectDistance(Vector2 value) { }

	public bool get_useGraphicAlpha() { }

	public void set_useGraphicAlpha(bool value) { }

	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	public override void ModifyMesh(VertexHelper vh) { }

}

