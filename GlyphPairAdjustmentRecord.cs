internal struct GlyphPairAdjustmentRecord // TypeDefIndex: 4115
{	[NativeNameAttribute] // RVA: 0x891A0 Offset: 0x885A0 VA: 0x1800891A0
	[SerializeField] // RVA: 0x891A0 Offset: 0x885A0 VA: 0x1800891A0
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x0
	[NativeNameAttribute] // RVA: 0x89250 Offset: 0x88650 VA: 0x180089250
	[SerializeField] // RVA: 0x89250 Offset: 0x88650 VA: 0x180089250
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x14

	public GlyphAdjustmentRecord firstAdjustmentRecord { get; }
	public GlyphAdjustmentRecord secondAdjustmentRecord { get; }


	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

}

