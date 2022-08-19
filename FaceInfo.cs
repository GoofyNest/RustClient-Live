public struct FaceInfo // TypeDefIndex: 4109
{
// Namespace: UnityEngine.TextCore
[UsedByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
[Serializable]
public struct FaceInfo // TypeDefIndex: 4109
	// Fields
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

	// Properties
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

	// Methods

	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	public void set_familyName(string value) { }

	// RVA: 0xF1390 Offset: 0xF0790 VA: 0x1800F1390
	public void set_styleName(string value) { }

	// RVA: 0x212180 Offset: 0x211580 VA: 0x180212180
	public int get_pointSize() { }

	// RVA: 0x1202F0 Offset: 0x11F6F0 VA: 0x1801202F0
	public void set_pointSize(int value) { }

	// RVA: 0x23D030 Offset: 0x23C430 VA: 0x18023D030
	public float get_scale() { }

	// RVA: 0x23D7A0 Offset: 0x23CBA0 VA: 0x18023D7A0
	public void set_scale(float value) { }

	// RVA: 0x23D6E0 Offset: 0x23CAE0 VA: 0x18023D6E0
	public float get_lineHeight() { }

	// RVA: 0x239430 Offset: 0x238830 VA: 0x180239430
	public void set_lineHeight(float value) { }

	// RVA: 0x239460 Offset: 0x238860 VA: 0x180239460
	public float get_ascentLine() { }

	// RVA: 0x2396C0 Offset: 0x238AC0 VA: 0x1802396C0
	public void set_ascentLine(float value) { }

	// RVA: 0x23D6C0 Offset: 0x23CAC0 VA: 0x18023D6C0
	public float get_capLine() { }

	// RVA: 0x23D780 Offset: 0x23CB80 VA: 0x18023D780
	public void set_capLine(float value) { }

	// RVA: 0x23D790 Offset: 0x23CB90 VA: 0x18023D790
	public void set_meanLine(float value) { }

	// RVA: 0x23D6B0 Offset: 0x23CAB0 VA: 0x18023D6B0
	public float get_baseline() { }

	// RVA: 0x23D770 Offset: 0x23CB70 VA: 0x18023D770
	public void set_baseline(float value) { }

	// RVA: 0x23D6D0 Offset: 0x23CAD0 VA: 0x18023D6D0
	public float get_descentLine() { }

	// RVA: 0x116D60 Offset: 0x116160 VA: 0x180116D60
	public void set_descentLine(float value) { }

	// RVA: 0x23D720 Offset: 0x23CB20 VA: 0x18023D720
	public float get_superscriptOffset() { }

	// RVA: 0x23D7F0 Offset: 0x23CBF0 VA: 0x18023D7F0
	public void set_superscriptOffset(float value) { }

	// RVA: 0x23D730 Offset: 0x23CB30 VA: 0x18023D730
	public float get_superscriptSize() { }

	// RVA: 0x23D800 Offset: 0x23CC00 VA: 0x18023D800
	public void set_superscriptSize(float value) { }

	// RVA: 0x23D700 Offset: 0x23CB00 VA: 0x18023D700
	public float get_subscriptOffset() { }

	// RVA: 0x23D7D0 Offset: 0x23CBD0 VA: 0x18023D7D0
	public void set_subscriptOffset(float value) { }

	// RVA: 0x23D710 Offset: 0x23CB10 VA: 0x18023D710
	public float get_subscriptSize() { }

	// RVA: 0x23D7E0 Offset: 0x23CBE0 VA: 0x18023D7E0
	public void set_subscriptSize(float value) { }

	// RVA: 0x23D750 Offset: 0x23CB50 VA: 0x18023D750
	public float get_underlineOffset() { }

	// RVA: 0x23D810 Offset: 0x23CC10 VA: 0x18023D810
	public void set_underlineOffset(float value) { }

	// RVA: 0x23D760 Offset: 0x23CB60 VA: 0x18023D760
	public float get_underlineThickness() { }

	// RVA: 0x23D820 Offset: 0x23CC20 VA: 0x18023D820
	public void set_underlineThickness(float value) { }

	// RVA: 0x23D6F0 Offset: 0x23CAF0 VA: 0x18023D6F0
	public float get_strikethroughOffset() { }

	// RVA: 0x23D7B0 Offset: 0x23CBB0 VA: 0x18023D7B0
	public void set_strikethroughOffset(float value) { }

	// RVA: 0x23D7C0 Offset: 0x23CBC0 VA: 0x18023D7C0
	public void set_strikethroughThickness(float value) { }

	// RVA: 0x23D740 Offset: 0x23CB40 VA: 0x18023D740
	public float get_tabWidth() { }

	// RVA: 0x19E260 Offset: 0x19D660 VA: 0x18019E260
	public void set_tabWidth(float value) { }

}

public class FaceInfo_Legacy // TypeDefIndex: 6762
{	// Fields
	public string Name; // 0x10
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

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

