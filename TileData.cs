public struct TileData // TypeDefIndex: 4572
{	private Sprite m_Sprite; // 0x0
	private Color m_Color; // 0x8
	private Matrix4x4 m_Transform; // 0x18
	private GameObject m_GameObject; // 0x58
	private TileFlags m_Flags; // 0x60
	private Tile.ColliderType m_ColliderType; // 0x64

	public Sprite sprite { set; }
	public Color color { set; }
	public Matrix4x4 transform { set; }
	public GameObject gameObject { set; }
	public TileFlags flags { set; }
	public Tile.ColliderType colliderType { set; }


	public void set_sprite(Sprite value) { }

	public void set_color(Color value) { }

	public void set_transform(Matrix4x4 value) { }

	public void set_gameObject(GameObject value) { }

	public void set_flags(TileFlags value) { }

	public void set_colliderType(Tile.ColliderType value) { }

}

