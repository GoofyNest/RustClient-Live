public class MotionBlur : ImageEffectBase // TypeDefIndex: 8202
{
	public float blurAmount; 
	public bool extraBlur; 
	private RenderTexture accumTexture; 


	protected override void Start() { }

	protected override void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public sealed class MotionBlur : PostProcessEffectSettings // TypeDefIndex: 13542
{
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter shutterAngle; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public IntParameter sampleCount; 


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

