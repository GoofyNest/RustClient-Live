public struct SpriteState : IEquatable<SpriteState> // TypeDefIndex: 5011
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sprite m_HighlightedSprite; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sprite m_PressedSprite; // 0x8
	[FormerlySerializedAsAttribute] // RVA: 0x7D360 Offset: 0x7C760 VA: 0x18007D360
	[SerializeField] // RVA: 0x7D360 Offset: 0x7C760 VA: 0x18007D360
	private Sprite m_SelectedSprite; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Sprite m_DisabledSprite; // 0x18

	// Properties
	public Sprite highlightedSprite { get; set; }
	public Sprite pressedSprite { get; set; }
	public Sprite selectedSprite { get; set; }
	public Sprite disabledSprite { get; set; }

	// Methods

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public Sprite get_highlightedSprite() { }

	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	public void set_highlightedSprite(Sprite value) { }

	// RVA: 0xF3DB0 Offset: 0xF31B0 VA: 0x1800F3DB0
	public Sprite get_pressedSprite() { }

	// RVA: 0xF1390 Offset: 0xF0790 VA: 0x1800F1390
	public void set_pressedSprite(Sprite value) { }

	// RVA: 0xF3DD0 Offset: 0xF31D0 VA: 0x1800F3DD0
	public Sprite get_selectedSprite() { }

	// RVA: 0xF1360 Offset: 0xF0760 VA: 0x1800F1360
	public void set_selectedSprite(Sprite value) { }

	// RVA: 0xF3DE0 Offset: 0xF31E0 VA: 0x1800F3DE0
	public Sprite get_disabledSprite() { }

	// RVA: 0xF1370 Offset: 0xF0770 VA: 0x1800F1370
	public void set_disabledSprite(Sprite value) { }

	// RVA: 0x238100 Offset: 0x237500 VA: 0x180238100 Slot: 4
	public bool Equals(SpriteState other) { }

}

