public struct TileData // TypeDefIndex: 4572
{	// Fields
	private Sprite m_Sprite; // 0x0
	private Color m_Color; // 0x8
	private Matrix4x4 m_Transform; // 0x18
	private GameObject m_GameObject; // 0x58
	private TileFlags m_Flags; // 0x60
	private Tile.ColliderType m_ColliderType; // 0x64

	// Properties
	public Sprite sprite { set; }
	public Color color { set; }
	public Matrix4x4 transform { set; }
	public GameObject gameObject { set; }
	public TileFlags flags { set; }
	public Tile.ColliderType colliderType { set; }

	// Methods

	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	public void set_sprite(Sprite value) { }

	// RVA: 0x116D70 Offset: 0x116170 VA: 0x180116D70
	public void set_color(Color value) { }

	// RVA: 0x240B20 Offset: 0x23FF20 VA: 0x180240B20
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0xF38B0 Offset: 0xF2CB0 VA: 0x1800F38B0
	public void set_gameObject(GameObject value) { }

	// RVA: 0x23BFD0 Offset: 0x23B3D0 VA: 0x18023BFD0
	public void set_flags(TileFlags value) { }

	// RVA: 0x23BF20 Offset: 0x23B320 VA: 0x18023BF20
	public void set_colliderType(Tile.ColliderType value) { }

}

