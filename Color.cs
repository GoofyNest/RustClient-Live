public struct Color : IEquatable<Color> // TypeDefIndex: 3460
{	// Fields
	public float r; // 0x0
	public float g; // 0x4
	public float b; // 0x8
	public float a; // 0xC

	// Properties
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

	// Methods

	// RVA: 0xF2CA0 Offset: 0xF20A0 VA: 0x1800F2CA0
	public void .ctor(float r, float g, float b, float a) { }

	// RVA: 0x212F90 Offset: 0x212390 VA: 0x180212F90
	public void .ctor(float r, float g, float b) { }

	// RVA: 0x212F80 Offset: 0x212380 VA: 0x180212F80 Slot: 3
	public override string ToString() { }

	// RVA: 0x212EE0 Offset: 0x2122E0 VA: 0x180212EE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x212D90 Offset: 0x212190 VA: 0x180212D90 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x212E70 Offset: 0x212270 VA: 0x180212E70 Slot: 4
	public bool Equals(Color other) { }

	// RVA: 0x181F7F0 Offset: 0x181EBF0 VA: 0x18181F7F0
	public static Color op_Addition(Color a, Color b) { }

	// RVA: 0x181FBE0 Offset: 0x181EFE0 VA: 0x18181FBE0
	public static Color op_Subtraction(Color a, Color b) { }

	// RVA: 0x181FB50 Offset: 0x181EF50 VA: 0x18181FB50
	public static Color op_Multiply(Color a, Color b) { }

	// RVA: 0x181FBA0 Offset: 0x181EFA0 VA: 0x18181FBA0
	public static Color op_Multiply(Color a, float b) { }

	// RVA: 0x181FB10 Offset: 0x181EF10 VA: 0x18181FB10
	public static Color op_Multiply(float b, Color a) { }

	// RVA: 0x181F840 Offset: 0x181EC40 VA: 0x18181F840
	public static Color op_Division(Color a, float b) { }

	// RVA: 0x181F860 Offset: 0x181EC60 VA: 0x18181F860
	public static bool op_Equality(Color lhs, Color rhs) { }

	// RVA: 0x181F9F0 Offset: 0x181EDF0 VA: 0x18181F9F0
	public static bool op_Inequality(Color lhs, Color rhs) { }

	// RVA: 0x181F000 Offset: 0x181E400 VA: 0x18181F000
	public static Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x212F40 Offset: 0x212340 VA: 0x180212F40
	internal Color RGBMultiplied(float multiplier) { }

	// RVA: 0x181F790 Offset: 0x181EB90 VA: 0x18181F790
	public static Color get_red() { }

	// RVA: 0x181F610 Offset: 0x181EA10 VA: 0x18181F610
	public static Color get_green() { }

	// RVA: 0x181F4A0 Offset: 0x181E8A0 VA: 0x18181F4A0
	public static Color get_blue() { }

	// RVA: 0x181F7B0 Offset: 0x181EBB0 VA: 0x18181F7B0
	public static Color get_white() { }

	// RVA: 0x181F480 Offset: 0x181E880 VA: 0x18181F480
	public static Color get_black() { }

	// RVA: 0x181F7D0 Offset: 0x181EBD0 VA: 0x18181F7D0
	public static Color get_yellow() { }

	// RVA: 0x181F4D0 Offset: 0x181E8D0 VA: 0x18181F4D0
	public static Color get_cyan() { }

	// RVA: 0x181F6F0 Offset: 0x181EAF0 VA: 0x18181F6F0
	public static Color get_magenta() { }

	// RVA: 0x181F5B0 Offset: 0x181E9B0 VA: 0x18181F5B0
	public static Color get_gray() { }

	// RVA: 0x181F5B0 Offset: 0x181E9B0 VA: 0x18181F5B0
	public static Color get_grey() { }

	// RVA: 0x181F4C0 Offset: 0x181E8C0 VA: 0x18181F4C0
	public static Color get_clear() { }

	// RVA: 0x213160 Offset: 0x212560 VA: 0x180213160
	public float get_grayscale() { }

	// RVA: 0x2131A0 Offset: 0x2125A0 VA: 0x1802131A0
	public Color get_linear() { }

	// RVA: 0x2130A0 Offset: 0x2124A0 VA: 0x1802130A0
	public Color get_gamma() { }

	// RVA: 0x2131C0 Offset: 0x2125C0 VA: 0x1802131C0
	public float get_maxColorComponent() { }

	// RVA: 0x181F990 Offset: 0x181ED90 VA: 0x18181F990
	public static Vector4 op_Implicit(Color c) { }

	// RVA: 0x181F950 Offset: 0x181ED50 VA: 0x18181F950
	public static Color op_Implicit(Vector4 v) { }

	// RVA: 0x212FB0 Offset: 0x2123B0 VA: 0x180212FB0
	public float get_Item(int index) { }

	// RVA: 0x181ECE0 Offset: 0x181E0E0 VA: 0x18181ECE0
	public static Color HSVToRGB(float H, float S, float V, bool hdr) { }

}

public struct Color // TypeDefIndex: 5552
{	// Fields
	public byte r; // 0x0
	public byte g; // 0x1
	public byte b; // 0x2
	public byte a; // 0x3

}

