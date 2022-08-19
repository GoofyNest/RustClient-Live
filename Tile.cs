public class Tile : TileBase // TypeDefIndex: 4566
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sprite m_Sprite; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color m_Color; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Matrix4x4 m_Transform; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject m_InstancedGameObject; // 0x70
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TileFlags m_Flags; // 0x78
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Tile.ColliderType m_ColliderType; // 0x7C

	// Properties
	public Sprite sprite { get; set; }
	public Color color { get; set; }
	public Matrix4x4 transform { get; set; }
	public GameObject gameObject { get; set; }
	public TileFlags flags { get; set; }
	public Tile.ColliderType colliderType { get; set; }

	// Methods

	// RVA: 0x1818770 Offset: 0x1817B70 VA: 0x181818770
	public Sprite get_sprite() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_sprite(Sprite value) { }

	// RVA: 0x231A030 Offset: 0x2319430 VA: 0x18231A030
	public Color get_color() { }

	// RVA: 0x1091460 Offset: 0x1090860 VA: 0x181091460
	public void set_color(Color value) { }

	// RVA: 0x231A050 Offset: 0x2319450 VA: 0x18231A050
	public Matrix4x4 get_transform() { }

	// RVA: 0x231A080 Offset: 0x2319480 VA: 0x18231A080
	public void set_transform(Matrix4x4 value) { }

	// RVA: 0x1A69A70 Offset: 0x1A68E70 VA: 0x181A69A70
	public GameObject get_gameObject() { }

	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	public void set_gameObject(GameObject value) { }

	// RVA: 0x231A040 Offset: 0x2319440 VA: 0x18231A040
	public TileFlags get_flags() { }

	// RVA: 0xB24460 Offset: 0xB23860 VA: 0x180B24460
	public void set_flags(TileFlags value) { }

	// RVA: 0x231A020 Offset: 0x2319420 VA: 0x18231A020
	public Tile.ColliderType get_colliderType() { }

	// RVA: 0x1444F10 Offset: 0x1444310 VA: 0x181444F10
	public void set_colliderType(Tile.ColliderType value) { }

	// RVA: 0x2319F10 Offset: 0x2319310 VA: 0x182319F10 Slot: 5
	public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x2319F80 Offset: 0x2319380 VA: 0x182319F80
	public void .ctor() { }

}

public enum Tile.ColliderType // TypeDefIndex: 4567
{	// Fields
	public int value__; // 0x0
	public const Tile.ColliderType None = 0;
	public const Tile.ColliderType Sprite = 1;
	public const Tile.ColliderType Grid = 2;

}

