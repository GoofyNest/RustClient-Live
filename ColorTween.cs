internal struct ColorTween : ITweenValue // TypeDefIndex: 5039
{	// Fields
	private ColorTween.ColorTweenCallback m_Target; // 0x0
	private Color m_StartColor; // 0x8
	private Color m_TargetColor; // 0x18
	private ColorTween.ColorTweenMode m_TweenMode; // 0x28
	private float m_Duration; // 0x2C
	private bool m_IgnoreTimeScale; // 0x30

	// Properties
	public Color startColor { get; set; }
	public Color targetColor { get; set; }
	public ColorTween.ColorTweenMode tweenMode { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x116D40 Offset: 0x116140 VA: 0x180116D40
	public Color get_startColor() { }

	// RVA: 0x116D70 Offset: 0x116170 VA: 0x180116D70
	public void set_startColor(Color value) { }

	// RVA: 0x116D50 Offset: 0x116150 VA: 0x180116D50
	public Color get_targetColor() { }

	// RVA: 0x116D80 Offset: 0x116180 VA: 0x180116D80
	public void set_targetColor(Color value) { }

	// RVA: 0xF3DC0 Offset: 0xF31C0 VA: 0x1800F3DC0
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0xF3DF0 Offset: 0xF31F0 VA: 0x1800F3DF0
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x116C20 Offset: 0x116020 VA: 0x180116C20 Slot: 6
	public float get_duration() { }

	// RVA: 0x116D60 Offset: 0x116160 VA: 0x180116D60
	public void set_duration(float value) { }

	// RVA: 0x116C30 Offset: 0x116030 VA: 0x180116C30 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0xF13F0 Offset: 0xF07F0 VA: 0x1800F13F0
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x19E380 Offset: 0x19D780 VA: 0x18019E380 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x19E2D0 Offset: 0x19D6D0 VA: 0x18019E2D0
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x116C30 Offset: 0x116030 VA: 0x180116C30
	public bool GetIgnoreTimescale() { }

	// RVA: 0x116C20 Offset: 0x116020 VA: 0x180116C20
	public float GetDuration() { }

	// RVA: 0xF48A0 Offset: 0xF3CA0 VA: 0x1800F48A0 Slot: 7
	public bool ValidTarget() { }

}

public enum ColorTween.ColorTweenMode // TypeDefIndex: 5040
{	// Fields
	public int value__; // 0x0
	public const ColorTween.ColorTweenMode All = 0;
	public const ColorTween.ColorTweenMode RGB = 1;
	public const ColorTween.ColorTweenMode Alpha = 2;

}

public class ColorTween.ColorTweenCallback : UnityEvent<Color> // TypeDefIndex: 5041
{	// Methods

	// RVA: 0x10B4EB0 Offset: 0x10B42B0 VA: 0x1810B4EB0
	public void .ctor() { }

}

internal struct ColorTween : ITweenValue // TypeDefIndex: 6750
{	// Fields
	private ColorTween.ColorTweenCallback m_Target; // 0x0
	private Color m_StartColor; // 0x8
	private Color m_TargetColor; // 0x18
	private ColorTween.ColorTweenMode m_TweenMode; // 0x28
	private float m_Duration; // 0x2C
	private bool m_IgnoreTimeScale; // 0x30

	// Properties
	public Color startColor { get; set; }
	public Color targetColor { get; set; }
	public ColorTween.ColorTweenMode tweenMode { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x116D40 Offset: 0x116140 VA: 0x180116D40
	public Color get_startColor() { }

	// RVA: 0x116D70 Offset: 0x116170 VA: 0x180116D70
	public void set_startColor(Color value) { }

	// RVA: 0x116D50 Offset: 0x116150 VA: 0x180116D50
	public Color get_targetColor() { }

	// RVA: 0x116D80 Offset: 0x116180 VA: 0x180116D80
	public void set_targetColor(Color value) { }

	// RVA: 0xF3DC0 Offset: 0xF31C0 VA: 0x1800F3DC0
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0xF3DF0 Offset: 0xF31F0 VA: 0x1800F3DF0
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x116C20 Offset: 0x116020 VA: 0x180116C20 Slot: 6
	public float get_duration() { }

	// RVA: 0x116D60 Offset: 0x116160 VA: 0x180116D60
	public void set_duration(float value) { }

	// RVA: 0x116C30 Offset: 0x116030 VA: 0x180116C30 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0xF13F0 Offset: 0xF07F0 VA: 0x1800F13F0
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x116C40 Offset: 0x116040 VA: 0x180116C40 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x116B70 Offset: 0x115F70 VA: 0x180116B70
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x116C30 Offset: 0x116030 VA: 0x180116C30
	public bool GetIgnoreTimescale() { }

	// RVA: 0x116C20 Offset: 0x116020 VA: 0x180116C20
	public float GetDuration() { }

	// RVA: 0xF48A0 Offset: 0xF3CA0 VA: 0x1800F48A0 Slot: 7
	public bool ValidTarget() { }

}

public enum ColorTween.ColorTweenMode // TypeDefIndex: 6751
{	// Fields
	public int value__; // 0x0
	public const ColorTween.ColorTweenMode All = 0;
	public const ColorTween.ColorTweenMode RGB = 1;
	public const ColorTween.ColorTweenMode Alpha = 2;

}

public class ColorTween.ColorTweenCallback : UnityEvent<Color> // TypeDefIndex: 6752
{	// Methods

	// RVA: 0xC44730 Offset: 0xC43B30 VA: 0x180C44730
	public void .ctor() { }

}

