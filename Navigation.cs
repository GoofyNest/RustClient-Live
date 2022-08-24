public struct Navigation : IEquatable<Navigation> // TypeDefIndex: 4990
{
	[SerializeField] 
	private Navigation.Mode m_Mode; 
	[SerializeField] 
	private Selectable m_SelectOnUp; 
	[SerializeField] 
	private Selectable m_SelectOnDown; 
	[SerializeField] 
	private Selectable m_SelectOnLeft; 
	[SerializeField] 
	private Selectable m_SelectOnRight; 

	public Navigation.Mode mode { get; set; }
	public Selectable selectOnUp { get; set; }
	public Selectable selectOnDown { get; set; }
	public Selectable selectOnLeft { get; set; }
	public Selectable selectOnRight { get; set; }
	public static Navigation defaultNavigation { get; }


	public Navigation.Mode get_mode() { }

	public void set_mode(Navigation.Mode value) { }

	public Selectable get_selectOnUp() { }

	public void set_selectOnUp(Selectable value) { }

	public Selectable get_selectOnDown() { }

	public void set_selectOnDown(Selectable value) { }

	public Selectable get_selectOnLeft() { }

	public void set_selectOnLeft(Selectable value) { }

	public Selectable get_selectOnRight() { }

	public void set_selectOnRight(Selectable value) { }

	public static Navigation get_defaultNavigation() { }

	public bool Equals(Navigation other) { }

}

public enum Navigation.Mode // TypeDefIndex: 4991
{
	public int value__; 
	public const Navigation.Mode None = 0;
	public const Navigation.Mode Horizontal = 1;
	public const Navigation.Mode Vertical = 2;
	public const Navigation.Mode Automatic = 3;
	public const Navigation.Mode Explicit = 4;

}

