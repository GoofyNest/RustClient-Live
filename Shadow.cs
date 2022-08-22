public class Shadow : BaseMeshEffect // TypeDefIndex: 5036
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color m_EffectColor; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2 m_EffectDistance; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_UseGraphicAlpha; // 0x38
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

