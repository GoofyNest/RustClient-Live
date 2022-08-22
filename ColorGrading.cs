public sealed class ColorGrading : PostProcessEffectSettings // TypeDefIndex: 11773
{	[DisplayNameAttribute] // RVA: 0xECCF0 Offset: 0xEC0F0 VA: 0x1800ECCF0
	[TooltipAttribute] // RVA: 0xECCF0 Offset: 0xEC0F0 VA: 0x1800ECCF0
	public GradingModeParameter gradingMode; // 0x30
	[DisplayNameAttribute] // RVA: 0xECFB0 Offset: 0xEC3B0 VA: 0x1800ECFB0
	[TooltipAttribute] // RVA: 0xECFB0 Offset: 0xEC3B0 VA: 0x1800ECFB0
	public TextureParameter externalLut; // 0x38
	[DisplayNameAttribute] // RVA: 0xED160 Offset: 0xEC560 VA: 0x1800ED160
	[TooltipAttribute] // RVA: 0xED160 Offset: 0xEC560 VA: 0x1800ED160
	public TonemapperParameter tonemapper; // 0x40
	[DisplayNameAttribute] // RVA: 0xED2B0 Offset: 0xEC6B0 VA: 0x1800ED2B0
	[RangeAttribute] // RVA: 0xED2B0 Offset: 0xEC6B0 VA: 0x1800ED2B0
	[TooltipAttribute] // RVA: 0xED2B0 Offset: 0xEC6B0 VA: 0x1800ED2B0
	public FloatParameter toneCurveToeStrength; // 0x48
	[DisplayNameAttribute] // RVA: 0xED450 Offset: 0xEC850 VA: 0x1800ED450
	[RangeAttribute] // RVA: 0xED450 Offset: 0xEC850 VA: 0x1800ED450
	[TooltipAttribute] // RVA: 0xED450 Offset: 0xEC850 VA: 0x1800ED450
	public FloatParameter toneCurveToeLength; // 0x50
	[DisplayNameAttribute] // RVA: 0xED700 Offset: 0xECB00 VA: 0x1800ED700
	[RangeAttribute] // RVA: 0xED700 Offset: 0xECB00 VA: 0x1800ED700
	[TooltipAttribute] // RVA: 0xED700 Offset: 0xECB00 VA: 0x1800ED700
	public FloatParameter toneCurveShoulderStrength; // 0x58
	[DisplayNameAttribute] // RVA: 0xED8C0 Offset: 0xECCC0 VA: 0x1800ED8C0
	[MinAttribute] // RVA: 0xED8C0 Offset: 0xECCC0 VA: 0x1800ED8C0
	[TooltipAttribute] // RVA: 0xED8C0 Offset: 0xECCC0 VA: 0x1800ED8C0
	public FloatParameter toneCurveShoulderLength; // 0x60
	[DisplayNameAttribute] // RVA: 0xEDAE0 Offset: 0xECEE0 VA: 0x1800EDAE0
	[RangeAttribute] // RVA: 0xEDAE0 Offset: 0xECEE0 VA: 0x1800EDAE0
	[TooltipAttribute] // RVA: 0xEDAE0 Offset: 0xECEE0 VA: 0x1800EDAE0
	public FloatParameter toneCurveShoulderAngle; // 0x68
	[DisplayNameAttribute] // RVA: 0xEDBF0 Offset: 0xECFF0 VA: 0x1800EDBF0
	[MinAttribute] // RVA: 0xEDBF0 Offset: 0xECFF0 VA: 0x1800EDBF0
	[TooltipAttribute] // RVA: 0xEDBF0 Offset: 0xECFF0 VA: 0x1800EDBF0
	public FloatParameter toneCurveGamma; // 0x70
	[DisplayNameAttribute] // RVA: 0xEDD80 Offset: 0xED180 VA: 0x1800EDD80
	[TooltipAttribute] // RVA: 0xEDD80 Offset: 0xED180 VA: 0x1800EDD80
	public TextureParameter ldrLut; // 0x78
	[DisplayNameAttribute] // RVA: 0xEDFC0 Offset: 0xED3C0 VA: 0x1800EDFC0
	[RangeAttribute] // RVA: 0xEDFC0 Offset: 0xED3C0 VA: 0x1800EDFC0
	[TooltipAttribute] // RVA: 0xEDFC0 Offset: 0xED3C0 VA: 0x1800EDFC0
	public FloatParameter ldrLutContribution; // 0x80
	[DisplayNameAttribute] // RVA: 0xEE3D0 Offset: 0xED7D0 VA: 0x1800EE3D0
	[RangeAttribute] // RVA: 0xEE3D0 Offset: 0xED7D0 VA: 0x1800EE3D0
	[TooltipAttribute] // RVA: 0xEE3D0 Offset: 0xED7D0 VA: 0x1800EE3D0
	public FloatParameter temperature; // 0x88
	[DisplayNameAttribute] // RVA: 0xEE570 Offset: 0xED970 VA: 0x1800EE570
	[RangeAttribute] // RVA: 0xEE570 Offset: 0xED970 VA: 0x1800EE570
	[TooltipAttribute] // RVA: 0xEE570 Offset: 0xED970 VA: 0x1800EE570
	public FloatParameter tint; // 0x90
	[DisplayNameAttribute] // RVA: 0xEE710 Offset: 0xEDB10 VA: 0x1800EE710
	[ColorUsageAttribute] // RVA: 0xEE710 Offset: 0xEDB10 VA: 0x1800EE710
	[TooltipAttribute] // RVA: 0xEE710 Offset: 0xEDB10 VA: 0x1800EE710
	public ColorParameter colorFilter; // 0x98
	[DisplayNameAttribute] // RVA: 0xEE9F0 Offset: 0xEDDF0 VA: 0x1800EE9F0
	[RangeAttribute] // RVA: 0xEE9F0 Offset: 0xEDDF0 VA: 0x1800EE9F0
	[TooltipAttribute] // RVA: 0xEE9F0 Offset: 0xEDDF0 VA: 0x1800EE9F0
	public FloatParameter hueShift; // 0xA0
	[DisplayNameAttribute] // RVA: 0xEECA0 Offset: 0xEE0A0 VA: 0x1800EECA0
	[RangeAttribute] // RVA: 0xEECA0 Offset: 0xEE0A0 VA: 0x1800EECA0
	[TooltipAttribute] // RVA: 0xEECA0 Offset: 0xEE0A0 VA: 0x1800EECA0
	public FloatParameter saturation; // 0xA8
	[DisplayNameAttribute] // RVA: 0xEF000 Offset: 0xEE400 VA: 0x1800EF000
	[RangeAttribute] // RVA: 0xEF000 Offset: 0xEE400 VA: 0x1800EF000
	[TooltipAttribute] // RVA: 0xEF000 Offset: 0xEE400 VA: 0x1800EF000
	public FloatParameter brightness; // 0xB0
	[DisplayNameAttribute] // RVA: 0xEF400 Offset: 0xEE800 VA: 0x1800EF400
	[TooltipAttribute] // RVA: 0xEF400 Offset: 0xEE800 VA: 0x1800EF400
	public FloatParameter postExposure; // 0xB8
	[DisplayNameAttribute] // RVA: 0xEF630 Offset: 0xEEA30 VA: 0x1800EF630
	[RangeAttribute] // RVA: 0xEF630 Offset: 0xEEA30 VA: 0x1800EF630
	[TooltipAttribute] // RVA: 0xEF630 Offset: 0xEEA30 VA: 0x1800EF630
	public FloatParameter contrast; // 0xC0
	[DisplayNameAttribute] // RVA: 0xEF8A0 Offset: 0xEECA0 VA: 0x1800EF8A0
	[RangeAttribute] // RVA: 0xEF8A0 Offset: 0xEECA0 VA: 0x1800EF8A0
	[TooltipAttribute] // RVA: 0xEF8A0 Offset: 0xEECA0 VA: 0x1800EF8A0
	public FloatParameter mixerRedOutRedIn; // 0xC8
	[DisplayNameAttribute] // RVA: 0xEFAB0 Offset: 0xEEEB0 VA: 0x1800EFAB0
	[RangeAttribute] // RVA: 0xEFAB0 Offset: 0xEEEB0 VA: 0x1800EFAB0
	[TooltipAttribute] // RVA: 0xEFAB0 Offset: 0xEEEB0 VA: 0x1800EFAB0
	public FloatParameter mixerRedOutGreenIn; // 0xD0
	[DisplayNameAttribute] // RVA: 0xEFC90 Offset: 0xEF090 VA: 0x1800EFC90
	[RangeAttribute] // RVA: 0xEFC90 Offset: 0xEF090 VA: 0x1800EFC90
	[TooltipAttribute] // RVA: 0xEFC90 Offset: 0xEF090 VA: 0x1800EFC90
	public FloatParameter mixerRedOutBlueIn; // 0xD8
	[DisplayNameAttribute] // RVA: 0xEF8A0 Offset: 0xEECA0 VA: 0x1800EF8A0
	[RangeAttribute] // RVA: 0xEF8A0 Offset: 0xEECA0 VA: 0x1800EF8A0
	[TooltipAttribute] // RVA: 0xEF8A0 Offset: 0xEECA0 VA: 0x1800EF8A0
	public FloatParameter mixerGreenOutRedIn; // 0xE0
	[DisplayNameAttribute] // RVA: 0xEFAB0 Offset: 0xEEEB0 VA: 0x1800EFAB0
	[RangeAttribute] // RVA: 0xEFAB0 Offset: 0xEEEB0 VA: 0x1800EFAB0
	[TooltipAttribute] // RVA: 0xEFAB0 Offset: 0xEEEB0 VA: 0x1800EFAB0
	public FloatParameter mixerGreenOutGreenIn; // 0xE8
	[DisplayNameAttribute] // RVA: 0xEFC90 Offset: 0xEF090 VA: 0x1800EFC90
	[RangeAttribute] // RVA: 0xEFC90 Offset: 0xEF090 VA: 0x1800EFC90
	[TooltipAttribute] // RVA: 0xEFC90 Offset: 0xEF090 VA: 0x1800EFC90
	public FloatParameter mixerGreenOutBlueIn; // 0xF0
	[DisplayNameAttribute] // RVA: 0xEF8A0 Offset: 0xEECA0 VA: 0x1800EF8A0
	[RangeAttribute] // RVA: 0xEF8A0 Offset: 0xEECA0 VA: 0x1800EF8A0
	[TooltipAttribute] // RVA: 0xEF8A0 Offset: 0xEECA0 VA: 0x1800EF8A0
	public FloatParameter mixerBlueOutRedIn; // 0xF8
	[DisplayNameAttribute] // RVA: 0xEFAB0 Offset: 0xEEEB0 VA: 0x1800EFAB0
	[RangeAttribute] // RVA: 0xEFAB0 Offset: 0xEEEB0 VA: 0x1800EFAB0
	[TooltipAttribute] // RVA: 0xEFAB0 Offset: 0xEEEB0 VA: 0x1800EFAB0
	public FloatParameter mixerBlueOutGreenIn; // 0x100
	[DisplayNameAttribute] // RVA: 0xEFC90 Offset: 0xEF090 VA: 0x1800EFC90
	[RangeAttribute] // RVA: 0xEFC90 Offset: 0xEF090 VA: 0x1800EFC90
	[TooltipAttribute] // RVA: 0xEFC90 Offset: 0xEF090 VA: 0x1800EFC90
	public FloatParameter mixerBlueOutBlueIn; // 0x108
	[DisplayNameAttribute] // RVA: 0xF0550 Offset: 0xEF950 VA: 0x1800F0550
	[TooltipAttribute] // RVA: 0xF0550 Offset: 0xEF950 VA: 0x1800F0550
	[TrackballAttribute] // RVA: 0xF0550 Offset: 0xEF950 VA: 0x1800F0550
	public Vector4Parameter lift; // 0x110
	[DisplayNameAttribute] // RVA: 0xF0820 Offset: 0xEFC20 VA: 0x1800F0820
	[TooltipAttribute] // RVA: 0xF0820 Offset: 0xEFC20 VA: 0x1800F0820
	[TrackballAttribute] // RVA: 0xF0820 Offset: 0xEFC20 VA: 0x1800F0820
	public Vector4Parameter gamma; // 0x118
	[DisplayNameAttribute] // RVA: 0xF0A90 Offset: 0xEFE90 VA: 0x1800F0A90
	[TooltipAttribute] // RVA: 0xF0A90 Offset: 0xEFE90 VA: 0x1800F0A90
	[TrackballAttribute] // RVA: 0xF0A90 Offset: 0xEFE90 VA: 0x1800F0A90
	public Vector4Parameter gain; // 0x120
	public SplineParameter masterCurve; // 0x128
	public SplineParameter redCurve; // 0x130
	public SplineParameter greenCurve; // 0x138
	public SplineParameter blueCurve; // 0x140
	public SplineParameter hueVsHueCurve; // 0x148
	public SplineParameter hueVsSatCurve; // 0x150
	public SplineParameter satVsSatCurve; // 0x158
	public SplineParameter lumVsSatCurve; // 0x160


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

