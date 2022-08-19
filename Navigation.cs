public struct Navigation : IEquatable<Navigation> // TypeDefIndex: 4990
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Navigation.Mode m_Mode; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Selectable m_SelectOnUp; // 0x8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Selectable m_SelectOnDown; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Selectable m_SelectOnLeft; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Selectable m_SelectOnRight; // 0x20

	// Properties
	public Navigation.Mode mode { get; set; }
	public Selectable selectOnUp { get; set; }
	public Selectable selectOnDown { get; set; }
	public Selectable selectOnLeft { get; set; }
	public Selectable selectOnRight { get; set; }
	public static Navigation defaultNavigation { get; }

	// Methods

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public Navigation.Mode get_mode() { }

	// RVA: 0xF3A80 Offset: 0xF2E80 VA: 0x1800F3A80
	public void set_mode(Navigation.Mode value) { }

	// RVA: 0xF3DB0 Offset: 0xF31B0 VA: 0x1800F3DB0
	public Selectable get_selectOnUp() { }

	// RVA: 0xF1390 Offset: 0xF0790 VA: 0x1800F1390
	public void set_selectOnUp(Selectable value) { }

	// RVA: 0xF3DD0 Offset: 0xF31D0 VA: 0x1800F3DD0
	public Selectable get_selectOnDown() { }

	// RVA: 0xF1360 Offset: 0xF0760 VA: 0x1800F1360
	public void set_selectOnDown(Selectable value) { }

	// RVA: 0xF3DE0 Offset: 0xF31E0 VA: 0x1800F3DE0
	public Selectable get_selectOnLeft() { }

	// RVA: 0xF1370 Offset: 0xF0770 VA: 0x1800F1370
	public void set_selectOnLeft(Selectable value) { }

	// RVA: 0xF3860 Offset: 0xF2C60 VA: 0x1800F3860
	public Selectable get_selectOnRight() { }

	// RVA: 0xF13D0 Offset: 0xF07D0 VA: 0x1800F13D0
	public void set_selectOnRight(Selectable value) { }

	// RVA: 0x1711C70 Offset: 0x1711070 VA: 0x181711C70
	public static Navigation get_defaultNavigation() { }

	// RVA: 0x2076F0 Offset: 0x206AF0 VA: 0x1802076F0 Slot: 4
	public bool Equals(Navigation other) { }

}

public enum Navigation.Mode // TypeDefIndex: 4991
{	// Fields
	public int value__; // 0x0
	public const Navigation.Mode None = 0;
	public const Navigation.Mode Horizontal = 1;
	public const Navigation.Mode Vertical = 2;
	public const Navigation.Mode Automatic = 3;
	public const Navigation.Mode Explicit = 4;

}

