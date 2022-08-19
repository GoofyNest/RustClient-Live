internal struct FloatTween : ITweenValue // TypeDefIndex: 5042
{	// Fields
	private FloatTween.FloatTweenCallback m_Target; // 0x0
	private float m_StartValue; // 0x8
	private float m_TargetValue; // 0xC
	private float m_Duration; // 0x10
	private bool m_IgnoreTimeScale; // 0x14

	// Properties
	public float startValue { get; set; }
	public float targetValue { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x116F40 Offset: 0x116340 VA: 0x180116F40
	public float get_startValue() { }

	// RVA: 0x116F80 Offset: 0x116380 VA: 0x180116F80
	public void set_startValue(float value) { }

	// RVA: 0x116F50 Offset: 0x116350 VA: 0x180116F50
	public float get_targetValue() { }

	// RVA: 0x116F90 Offset: 0x116390 VA: 0x180116F90
	public void set_targetValue(float value) { }

	// RVA: 0x1168F0 Offset: 0x115CF0 VA: 0x1801168F0 Slot: 6
	public float get_duration() { }

	// RVA: 0x116F60 Offset: 0x116360 VA: 0x180116F60
	public void set_duration(float value) { }

	// RVA: 0x116E80 Offset: 0x116280 VA: 0x180116E80 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x116F70 Offset: 0x116370 VA: 0x180116F70
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x19E490 Offset: 0x19D890 VA: 0x18019E490 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x19E480 Offset: 0x19D880 VA: 0x18019E480
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0x116E80 Offset: 0x116280 VA: 0x180116E80
	public bool GetIgnoreTimescale() { }

	// RVA: 0x1168F0 Offset: 0x115CF0 VA: 0x1801168F0
	public float GetDuration() { }

	// RVA: 0xF48A0 Offset: 0xF3CA0 VA: 0x1800F48A0 Slot: 7
	public bool ValidTarget() { }

}

public class FloatTween.FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 5043
{	// Methods

	// RVA: 0x10C0F50 Offset: 0x10C0350 VA: 0x1810C0F50
	public void .ctor() { }

}

internal struct FloatTween : ITweenValue // TypeDefIndex: 6753
{	// Fields
	private FloatTween.FloatTweenCallback m_Target; // 0x0
	private float m_StartValue; // 0x8
	private float m_TargetValue; // 0xC
	private float m_Duration; // 0x10
	private bool m_IgnoreTimeScale; // 0x14

	// Properties
	public float startValue { get; set; }
	public float targetValue { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x116F40 Offset: 0x116340 VA: 0x180116F40
	public float get_startValue() { }

	// RVA: 0x116F80 Offset: 0x116380 VA: 0x180116F80
	public void set_startValue(float value) { }

	// RVA: 0x116F50 Offset: 0x116350 VA: 0x180116F50
	public float get_targetValue() { }

	// RVA: 0x116F90 Offset: 0x116390 VA: 0x180116F90
	public void set_targetValue(float value) { }

	// RVA: 0x1168F0 Offset: 0x115CF0 VA: 0x1801168F0 Slot: 6
	public float get_duration() { }

	// RVA: 0x116F60 Offset: 0x116360 VA: 0x180116F60
	public void set_duration(float value) { }

	// RVA: 0x116E80 Offset: 0x116280 VA: 0x180116E80 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x116F70 Offset: 0x116370 VA: 0x180116F70
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x116E90 Offset: 0x116290 VA: 0x180116E90 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x116DD0 Offset: 0x1161D0 VA: 0x180116DD0
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0x116E80 Offset: 0x116280 VA: 0x180116E80
	public bool GetIgnoreTimescale() { }

	// RVA: 0x1168F0 Offset: 0x115CF0 VA: 0x1801168F0
	public float GetDuration() { }

	// RVA: 0xF48A0 Offset: 0xF3CA0 VA: 0x1800F48A0 Slot: 7
	public bool ValidTarget() { }

}

public class FloatTween.FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 6754
{	// Methods

	// RVA: 0xC44E60 Offset: 0xC44260 VA: 0x180C44E60
	public void .ctor() { }

}

