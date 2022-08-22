public struct FaceInfo // TypeDefIndex: 4109
{
[UsedByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
[Serializable]
public struct FaceInfo // TypeDefIndex: 4109
	[NativeNameAttribute] // RVA: 0x83860 Offset: 0x82C60 VA: 0x180083860
	[SerializeField] // RVA: 0x83860 Offset: 0x82C60 VA: 0x180083860
	private string m_FamilyName; // 0x0
	[SerializeField] // RVA: 0x83960 Offset: 0x82D60 VA: 0x180083960
	[NativeNameAttribute] // RVA: 0x83960 Offset: 0x82D60 VA: 0x180083960
	private string m_StyleName; // 0x8
	[NativeNameAttribute] // RVA: 0x83B40 Offset: 0x82F40 VA: 0x180083B40
	[SerializeField] // RVA: 0x83B40 Offset: 0x82F40 VA: 0x180083B40
	private int m_PointSize; // 0x10
	[SerializeField] // RVA: 0x83C70 Offset: 0x83070 VA: 0x180083C70
	[NativeNameAttribute] // RVA: 0x83C70 Offset: 0x83070 VA: 0x180083C70
	private float m_Scale; // 0x14
	[SerializeField] // RVA: 0x83D80 Offset: 0x83180 VA: 0x180083D80
	[NativeNameAttribute] // RVA: 0x83D80 Offset: 0x83180 VA: 0x180083D80
	private float m_LineHeight; // 0x18
	[NativeNameAttribute] // RVA: 0x83E90 Offset: 0x83290 VA: 0x180083E90
	[SerializeField] // RVA: 0x83E90 Offset: 0x83290 VA: 0x180083E90
	private float m_AscentLine; // 0x1C
	[NativeNameAttribute] // RVA: 0x842B0 Offset: 0x836B0 VA: 0x1800842B0
	[SerializeField] // RVA: 0x842B0 Offset: 0x836B0 VA: 0x1800842B0
	private float m_CapLine; // 0x20
	[SerializeField] // RVA: 0x84340 Offset: 0x83740 VA: 0x180084340
	[NativeNameAttribute] // RVA: 0x84340 Offset: 0x83740 VA: 0x180084340
	private float m_MeanLine; // 0x24
	[SerializeField] // RVA: 0x84430 Offset: 0x83830 VA: 0x180084430
	[NativeNameAttribute] // RVA: 0x84430 Offset: 0x83830 VA: 0x180084430
	private float m_Baseline; // 0x28
	[SerializeField] // RVA: 0x84640 Offset: 0x83A40 VA: 0x180084640
	[NativeNameAttribute] // RVA: 0x84640 Offset: 0x83A40 VA: 0x180084640
	private float m_DescentLine; // 0x2C
	[NativeNameAttribute] // RVA: 0x84710 Offset: 0x83B10 VA: 0x180084710
	[SerializeField] // RVA: 0x84710 Offset: 0x83B10 VA: 0x180084710
	private float m_SuperscriptOffset; // 0x30
	[NativeNameAttribute] // RVA: 0x848D0 Offset: 0x83CD0 VA: 0x1800848D0
	[SerializeField] // RVA: 0x848D0 Offset: 0x83CD0 VA: 0x1800848D0
	private float m_SuperscriptSize; // 0x34
	[SerializeField] // RVA: 0x84A40 Offset: 0x83E40 VA: 0x180084A40
	[NativeNameAttribute] // RVA: 0x84A40 Offset: 0x83E40 VA: 0x180084A40
	private float m_SubscriptOffset; // 0x38
	[SerializeField] // RVA: 0x84D60 Offset: 0x84160 VA: 0x180084D60
	[NativeNameAttribute] // RVA: 0x84D60 Offset: 0x84160 VA: 0x180084D60
	private float m_SubscriptSize; // 0x3C
	[SerializeField] // RVA: 0x84E80 Offset: 0x84280 VA: 0x180084E80
	[NativeNameAttribute] // RVA: 0x84E80 Offset: 0x84280 VA: 0x180084E80
	private float m_UnderlineOffset; // 0x40
	[NativeNameAttribute] // RVA: 0x85170 Offset: 0x84570 VA: 0x180085170
	[SerializeField] // RVA: 0x85170 Offset: 0x84570 VA: 0x180085170
	private float m_UnderlineThickness; // 0x44
	[SerializeField] // RVA: 0x852F0 Offset: 0x846F0 VA: 0x1800852F0
	[NativeNameAttribute] // RVA: 0x852F0 Offset: 0x846F0 VA: 0x1800852F0
	private float m_StrikethroughOffset; // 0x48
	[SerializeField] // RVA: 0x85530 Offset: 0x84930 VA: 0x180085530
	[NativeNameAttribute] // RVA: 0x85530 Offset: 0x84930 VA: 0x180085530
	private float m_StrikethroughThickness; // 0x4C
	[NativeNameAttribute] // RVA: 0x85660 Offset: 0x84A60 VA: 0x180085660
	[SerializeField] // RVA: 0x85660 Offset: 0x84A60 VA: 0x180085660
	private float m_TabWidth; // 0x50

	public string familyName { set; }
	public string styleName { set; }
	public int pointSize { get; set; }
	public float scale { get; set; }
	public float lineHeight { get; set; }
	public float ascentLine { get; set; }
	public float capLine { get; set; }
	public float meanLine { set; }
	public float baseline { get; set; }
	public float descentLine { get; set; }
	public float superscriptOffset { get; set; }
	public float superscriptSize { get; set; }
	public float subscriptOffset { get; set; }
	public float subscriptSize { get; set; }
	public float underlineOffset { get; set; }
	public float underlineThickness { get; set; }
	public float strikethroughOffset { get; set; }
	public float strikethroughThickness { set; }
	public float tabWidth { get; set; }


	public void set_familyName(string value) { }

	public void set_styleName(string value) { }

	public int get_pointSize() { }

	public void set_pointSize(int value) { }

	public float get_scale() { }

	public void set_scale(float value) { }

	public float get_lineHeight() { }

	public void set_lineHeight(float value) { }

	public float get_ascentLine() { }

	public void set_ascentLine(float value) { }

	public float get_capLine() { }

	public void set_capLine(float value) { }

	public void set_meanLine(float value) { }

	public float get_baseline() { }

	public void set_baseline(float value) { }

	public float get_descentLine() { }

	public void set_descentLine(float value) { }

	public float get_superscriptOffset() { }

	public void set_superscriptOffset(float value) { }

	public float get_superscriptSize() { }

	public void set_superscriptSize(float value) { }

	public float get_subscriptOffset() { }

	public void set_subscriptOffset(float value) { }

	public float get_subscriptSize() { }

	public void set_subscriptSize(float value) { }

	public float get_underlineOffset() { }

	public void set_underlineOffset(float value) { }

	public float get_underlineThickness() { }

	public void set_underlineThickness(float value) { }

	public float get_strikethroughOffset() { }

	public void set_strikethroughOffset(float value) { }

	public void set_strikethroughThickness(float value) { }

	public float get_tabWidth() { }

	public void set_tabWidth(float value) { }

}

public class FaceInfo_Legacy // TypeDefIndex: 6762
{	public string Name; // 0x10
	public float PointSize; // 0x18
	public float Scale; // 0x1C
	public int CharacterCount; // 0x20
	public float LineHeight; // 0x24
	public float Baseline; // 0x28
	public float Ascender; // 0x2C
	public float CapHeight; // 0x30
	public float Descender; // 0x34
	public float CenterLine; // 0x38
	public float SuperscriptOffset; // 0x3C
	public float SubscriptOffset; // 0x40
	public float SubSize; // 0x44
	public float Underline; // 0x48
	public float UnderlineThickness; // 0x4C
	public float strikethrough; // 0x50
	public float strikethroughThickness; // 0x54
	public float TabWidth; // 0x58
	public float Padding; // 0x5C
	public float AtlasWidth; // 0x60
	public float AtlasHeight; // 0x64


	public void .ctor() { }

}

