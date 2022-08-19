public class BitUtility // TypeDefIndex: 4819
{	// Fields
	private const float float2byte = 255;
	private const float byte2float = 0,003921569;
	private const float float2short = 32766;
	private const float short2float = 3,051944E-05;

	// Methods

	// RVA: 0x2267700 Offset: 0x2266B00 VA: 0x182267700
	public static byte Float2Byte(float f) { }

	// RVA: 0x2267130 Offset: 0x2266530 VA: 0x182267130
	public static float Byte2Float(int b) { }

	// RVA: 0x2267730 Offset: 0x2266B30 VA: 0x182267730
	public static short Float2Short(float f) { }

	// RVA: 0x2267750 Offset: 0x2266B50 VA: 0x182267750
	public static float Short2Float(int b) { }

	// RVA: 0x2267360 Offset: 0x2266760 VA: 0x182267360
	public static Color32 EncodeFloat(float f) { }

	// RVA: 0x2267140 Offset: 0x2266540 VA: 0x182267140
	public static float DecodeFloat(Color32 c) { }

	// RVA: 0x22673B0 Offset: 0x22667B0 VA: 0x1822673B0
	public static Color32 EncodeInt(int i) { }

	// RVA: 0x2267170 Offset: 0x2266570 VA: 0x182267170
	public static int DecodeInt(Color32 c) { }

	// RVA: 0x2267520 Offset: 0x2266920 VA: 0x182267520
	public static Color32 EncodeShort(short i) { }

	// RVA: 0x2267290 Offset: 0x2266690 VA: 0x182267290
	public static short DecodeShort(Color32 c) { }

	// RVA: 0x2267400 Offset: 0x2266800 VA: 0x182267400
	public static Color EncodeNormal(Vector3 n) { }

	// RVA: 0x22671A0 Offset: 0x22665A0 VA: 0x1822671A0
	public static Vector3 DecodeNormal(Color c) { }

	// RVA: 0x2267640 Offset: 0x2266A40 VA: 0x182267640
	public static Color32 EncodeVector(Vector4 v) { }

	// RVA: 0x22672E0 Offset: 0x22666E0 VA: 0x1822672E0
	public static Vector4 DecodeVector(Color32 c) { }

	// RVA: 0x2267560 Offset: 0x2266960 VA: 0x182267560
	public static Color32 EncodeVector2i(Vector2i v) { }

	// RVA: 0x22672B0 Offset: 0x22666B0 VA: 0x1822672B0
	public static Vector2i DecodeVector2i(Color32 c) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

