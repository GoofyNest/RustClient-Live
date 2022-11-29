public struct SpriteState : IEquatable<SpriteState> // TypeDefIndex: 5017
{
	[SerializeField] 
	private Sprite m_HighlightedSprite; 
	[SerializeField] 
	private Sprite m_PressedSprite; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private Sprite m_SelectedSprite; 
	[SerializeField] 
	private Sprite m_DisabledSprite; 

	public Sprite highlightedSprite { get; set; }
	public Sprite pressedSprite { get; set; }
	public Sprite selectedSprite { get; set; }
	public Sprite disabledSprite { get; set; }


	public Sprite get_highlightedSprite() { }

	public void set_highlightedSprite(Sprite value) { }

	public Sprite get_pressedSprite() { }

	public void set_pressedSprite(Sprite value) { }

	public Sprite get_selectedSprite() { }

	public void set_selectedSprite(Sprite value) { }

	public Sprite get_disabledSprite() { }

	public void set_disabledSprite(Sprite value) { }

	public bool Equals(SpriteState other) { }

}

