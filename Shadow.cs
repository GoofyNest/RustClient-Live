public class Shadow : BaseMeshEffect // TypeDefIndex: 5036
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color m_EffectColor; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector2 m_EffectDistance; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_UseGraphicAlpha; // 0x38
	private const float kMaxEffectDistance = 600;

	// Properties
	public Color effectColor { get; set; }
	public Vector2 effectDistance { get; set; }
	public bool useGraphicAlpha { get; set; }

	// Methods

	// RVA: 0x1712010 Offset: 0x1711410 VA: 0x181712010
	protected void .ctor() { }

	// RVA: 0xD623A0 Offset: 0xD617A0 VA: 0x180D623A0
	public Color get_effectColor() { }

	// RVA: 0x171F940 Offset: 0x171ED40 VA: 0x18171F940
	public void set_effectColor(Color value) { }

	// RVA: 0xC10780 Offset: 0xC0FB80 VA: 0x180C10780
	public Vector2 get_effectDistance() { }

	// RVA: 0x171F9F0 Offset: 0x171EDF0 VA: 0x18171F9F0
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x8B1120 Offset: 0x8B0520 VA: 0x1808B1120
	public bool get_useGraphicAlpha() { }

	// RVA: 0x171FB50 Offset: 0x171EF50 VA: 0x18171FB50
	public void set_useGraphicAlpha(bool value) { }

	// RVA: 0x171F580 Offset: 0x171E980 VA: 0x18171F580
	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x171F810 Offset: 0x171EC10 VA: 0x18171F810
	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x171F820 Offset: 0x171EC20 VA: 0x18171F820 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }

}

