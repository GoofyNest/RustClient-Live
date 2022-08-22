internal struct ColorTween : ITweenValue // TypeDefIndex: 5039
{	private ColorTween.ColorTweenCallback m_Target; // 0x0
	private Color m_StartColor; // 0x8
	private Color m_TargetColor; // 0x18
	private ColorTween.ColorTweenMode m_TweenMode; // 0x28
	private float m_Duration; // 0x2C
	private bool m_IgnoreTimeScale; // 0x30

	public Color startColor { get; set; }
	public Color targetColor { get; set; }
	public ColorTween.ColorTweenMode tweenMode { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }


	public Color get_startColor() { }

	public void set_startColor(Color value) { }

	public Color get_targetColor() { }

	public void set_targetColor(Color value) { }

	public ColorTween.ColorTweenMode get_tweenMode() { }

	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	public float get_duration() { }

	public void set_duration(float value) { }

	public bool get_ignoreTimeScale() { }

	public void set_ignoreTimeScale(bool value) { }

	public void TweenValue(float floatPercentage) { }

	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	public bool GetIgnoreTimescale() { }

	public float GetDuration() { }

	public bool ValidTarget() { }

}

public enum ColorTween.ColorTweenMode // TypeDefIndex: 5040
{	public int value__; // 0x0
	public const ColorTween.ColorTweenMode All = 0;
	public const ColorTween.ColorTweenMode RGB = 1;
	public const ColorTween.ColorTweenMode Alpha = 2;

}

public class ColorTween.ColorTweenCallback : UnityEvent<Color> // TypeDefIndex: 5041
{
	public void .ctor() { }

}

internal struct ColorTween : ITweenValue // TypeDefIndex: 6750
{	private ColorTween.ColorTweenCallback m_Target; // 0x0
	private Color m_StartColor; // 0x8
	private Color m_TargetColor; // 0x18
	private ColorTween.ColorTweenMode m_TweenMode; // 0x28
	private float m_Duration; // 0x2C
	private bool m_IgnoreTimeScale; // 0x30

	public Color startColor { get; set; }
	public Color targetColor { get; set; }
	public ColorTween.ColorTweenMode tweenMode { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }


	public Color get_startColor() { }

	public void set_startColor(Color value) { }

	public Color get_targetColor() { }

	public void set_targetColor(Color value) { }

	public ColorTween.ColorTweenMode get_tweenMode() { }

	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	public float get_duration() { }

	public void set_duration(float value) { }

	public bool get_ignoreTimeScale() { }

	public void set_ignoreTimeScale(bool value) { }

	public void TweenValue(float floatPercentage) { }

	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	public bool GetIgnoreTimescale() { }

	public float GetDuration() { }

	public bool ValidTarget() { }

}

public enum ColorTween.ColorTweenMode // TypeDefIndex: 6751
{	public int value__; // 0x0
	public const ColorTween.ColorTweenMode All = 0;
	public const ColorTween.ColorTweenMode RGB = 1;
	public const ColorTween.ColorTweenMode Alpha = 2;

}

public class ColorTween.ColorTweenCallback : UnityEvent<Color> // TypeDefIndex: 6752
{
	public void .ctor() { }

}

