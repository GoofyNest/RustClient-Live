internal struct GlyphPairAdjustmentRecord // TypeDefIndex: 4118
{
	[NativeNameAttribute] 
	[SerializeField] 
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; 
	[NativeNameAttribute] 
	[SerializeField] 
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; 

	public GlyphAdjustmentRecord firstAdjustmentRecord { get; }
	public GlyphAdjustmentRecord secondAdjustmentRecord { get; }


	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

}

