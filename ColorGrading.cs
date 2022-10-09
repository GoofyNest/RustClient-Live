public sealed class ColorGrading : PostProcessEffectSettings // TypeDefIndex: 13514
{
	[DisplayNameAttribute] 
	[TooltipAttribute] 
	public GradingModeParameter gradingMode; 
	[DisplayNameAttribute] 
	[TooltipAttribute] 
	public TextureParameter externalLut; 
	[DisplayNameAttribute] 
	[TooltipAttribute] 
	public TonemapperParameter tonemapper; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter toneCurveToeStrength; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter toneCurveToeLength; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter toneCurveShoulderStrength; 
	[DisplayNameAttribute] 
	[MinAttribute] 
	[TooltipAttribute] 
	public FloatParameter toneCurveShoulderLength; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter toneCurveShoulderAngle; 
	[DisplayNameAttribute] 
	[MinAttribute] 
	[TooltipAttribute] 
	public FloatParameter toneCurveGamma; 
	[DisplayNameAttribute] 
	[TooltipAttribute] 
	public TextureParameter ldrLut; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter ldrLutContribution; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter temperature; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter tint; 
	[DisplayNameAttribute] 
	[ColorUsageAttribute] 
	[TooltipAttribute] 
	public ColorParameter colorFilter; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter hueShift; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter saturation; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter brightness; 
	[DisplayNameAttribute] 
	[TooltipAttribute] 
	public FloatParameter postExposure; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter contrast; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter mixerRedOutRedIn; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter mixerRedOutGreenIn; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter mixerRedOutBlueIn; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter mixerGreenOutRedIn; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter mixerGreenOutGreenIn; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter mixerGreenOutBlueIn; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter mixerBlueOutRedIn; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter mixerBlueOutGreenIn; 
	[DisplayNameAttribute] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter mixerBlueOutBlueIn; 
	[DisplayNameAttribute] 
	[TooltipAttribute] 
	[TrackballAttribute] 
	public Vector4Parameter lift; 
	[DisplayNameAttribute] 
	[TooltipAttribute] 
	[TrackballAttribute] 
	public Vector4Parameter gamma; 
	[DisplayNameAttribute] 
	[TooltipAttribute] 
	[TrackballAttribute] 
	public Vector4Parameter gain; 
	public SplineParameter masterCurve; 
	public SplineParameter redCurve; 
	public SplineParameter greenCurve; 
	public SplineParameter blueCurve; 
	public SplineParameter hueVsHueCurve; 
	public SplineParameter hueVsSatCurve; 
	public SplineParameter satVsSatCurve; 
	public SplineParameter lumVsSatCurve; 


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

