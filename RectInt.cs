public struct RectInt : IEquatable<RectInt> // TypeDefIndex: 3377
{	private int m_XMin; // 0x0
	private int m_YMin; // 0x4
	private int m_Width; // 0x8
	private int m_Height; // 0xC

	public int x { get; }
	public int y { get; }
	public int width { get; }
	public int height { get; }
	public int xMin { get; set; }
	public int yMin { get; set; }
	public int xMax { get; set; }
	public int yMax { get; set; }


	public int get_x() { }

	public int get_y() { }

	public int get_width() { }

	public int get_height() { }

	public int get_xMin() { }

	public void set_xMin(int value) { }

	public int get_yMin() { }

	public void set_yMin(int value) { }

	public int get_xMax() { }

	public void set_xMax(int value) { }

	public int get_yMax() { }

	public void set_yMax(int value) { }

	public override string ToString() { }

	public bool Equals(RectInt other) { }

}

