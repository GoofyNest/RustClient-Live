public struct RectInt : IEquatable<RectInt> // TypeDefIndex: 3377
{	// Fields
	private int m_XMin; // 0x0
	private int m_YMin; // 0x4
	private int m_Width; // 0x8
	private int m_Height; // 0xC

	// Properties
	public int x { get; }
	public int y { get; }
	public int width { get; }
	public int height { get; }
	public int xMin { get; set; }
	public int yMin { get; set; }
	public int xMax { get; set; }
	public int yMax { get; set; }

	// Methods

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500
	public int get_x() { }

	// RVA: 0x13A260 Offset: 0x139660 VA: 0x18013A260
	public int get_y() { }

	// RVA: 0x13AB80 Offset: 0x139F80 VA: 0x18013AB80
	public int get_width() { }

	// RVA: 0x221BF0 Offset: 0x220FF0 VA: 0x180221BF0
	public int get_height() { }

	// RVA: 0x221C70 Offset: 0x221070 VA: 0x180221C70
	public int get_xMin() { }

	// RVA: 0x221DD0 Offset: 0x2211D0 VA: 0x180221DD0
	public void set_xMin(int value) { }

	// RVA: 0x221D50 Offset: 0x221150 VA: 0x180221D50
	public int get_yMin() { }

	// RVA: 0x221E70 Offset: 0x221270 VA: 0x180221E70
	public void set_yMin(int value) { }

	// RVA: 0x221C00 Offset: 0x221000 VA: 0x180221C00
	public int get_xMax() { }

	// RVA: 0x221DC0 Offset: 0x2211C0 VA: 0x180221DC0
	public void set_xMax(int value) { }

	// RVA: 0x221CE0 Offset: 0x2210E0 VA: 0x180221CE0
	public int get_yMax() { }

	// RVA: 0x221E60 Offset: 0x221260 VA: 0x180221E60
	public void set_yMax(int value) { }

	// RVA: 0x221BE0 Offset: 0x220FE0 VA: 0x180221BE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x221B90 Offset: 0x220F90 VA: 0x180221B90 Slot: 4
	public bool Equals(RectInt other) { }

}

