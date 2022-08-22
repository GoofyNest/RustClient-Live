internal struct StyleValue // TypeDefIndex: 4726
{	public StylePropertyID id; // 0x0
	public StyleKeyword keyword; // 0x4
	public float number; // 0x8
	public Length length; // 0x8
	public Color color; // 0x8
	public GCHandle resource; // 0x8


	public static StyleValue Create(StylePropertyID id) { }

	public static StyleValue Create(StylePropertyID id, StyleKeyword keyword) { }

	public static StyleValue Create(StylePropertyID id, float number) { }

	public static StyleValue Create(StylePropertyID id, int number) { }

	public static StyleValue Create(StylePropertyID id, Color color) { }

}

