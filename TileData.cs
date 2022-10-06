public struct TileData // TypeDefIndex: 4575
{
	private Sprite m_Sprite; 
	private Color m_Color; 
	private Matrix4x4 m_Transform; 
	private GameObject m_GameObject; 
	private TileFlags m_Flags; 
	private Tile.ColliderType m_ColliderType; 

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

