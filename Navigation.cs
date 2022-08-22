public struct Navigation : IEquatable<Navigation> // TypeDefIndex: 4990
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Navigation.Mode m_Mode; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Selectable m_SelectOnUp; // 0x8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Selectable m_SelectOnDown; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Selectable m_SelectOnLeft; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Selectable m_SelectOnRight; // 0x20

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
{	public int value__; // 0x0
	public const Navigation.Mode None = 0;
	public const Navigation.Mode Horizontal = 1;
	public const Navigation.Mode Vertical = 2;
	public const Navigation.Mode Automatic = 3;
	public const Navigation.Mode Explicit = 4;

}

