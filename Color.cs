public struct Color : IEquatable<Color> // TypeDefIndex: 3461
{
	public float r;
	public float g;
	public float b;
	public float a;

	public static Color red { get; }
	public static Color green { get; }
	public static Color blue { get; }
	public static Color white { get; }
	public static Color black { get; }
	public static Color yellow { get; }
	public static Color cyan { get; }
	public static Color magenta { get; }
	public static Color gray { get; }
	public static Color grey { get; }
	public static Color clear { get; }
	public float grayscale { get; }
	public Color linear { get; }
	public Color gamma { get; }
	public float maxColorComponent { get; }
	public float Item { get; }


	public void .ctor(float r, float g, float b, float a) { }

	public void .ctor(float r, float g, float b) { }

	public override string ToString() { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(Color other) { }

	public static Color op_Addition(Color a, Color b) { }

	public static Color op_Subtraction(Color a, Color b) { }

	public static Color op_Multiply(Color a, Color b) { }

	public static Color op_Multiply(Color a, float b) { }

	public static Color op_Multiply(float b, Color a) { }

	public static Color op_Division(Color a, float b) { }

	public static bool op_Equality(Color lhs, Color rhs) { }

	public static bool op_Inequality(Color lhs, Color rhs) { }

	public static Color Lerp(Color a, Color b, float t) { }

	internal Color RGBMultiplied(float multiplier) { }

	public static Color get_red() { }

	public static Color get_green() { }

	public static Color get_blue() { }

	public static Color get_white() { }

	public static Color get_black() { }

	public static Color get_yellow() { }

	public static Color get_cyan() { }

	public static Color get_magenta() { }

	public static Color get_gray() { }

	public static Color get_grey() { }

	public static Color get_clear() { }

	public float get_grayscale() { }

	public Color get_linear() { }

	public Color get_gamma() { }

	public float get_maxColorComponent() { }

	public static Vector4 op_Implicit(Color c) { }

	public static Color op_Implicit(Vector4 v) { }

	public float get_Item(int index) { }

	public static Color HSVToRGB(float H, float S, float V, bool hdr) { }

}

public struct Color // TypeDefIndex: 5560
{
	public byte r;
	public byte g;
	public byte b;
	public byte a;

}

