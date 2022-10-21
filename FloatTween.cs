internal struct FloatTween : ITweenValue // TypeDefIndex: 5046
{
	private FloatTween.FloatTweenCallback m_Target; 
	private float m_StartValue; 
	private float m_TargetValue; 
	private float m_Duration; 
	private bool m_IgnoreTimeScale; 

	public float startValue { get; set; }
	public float targetValue { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }


	public float get_startValue() { }

	public void set_startValue(float value) { }

	public float get_targetValue() { }

	public void set_targetValue(float value) { }

	public float get_duration() { }

	public void set_duration(float value) { }

	public bool get_ignoreTimeScale() { }

	public void set_ignoreTimeScale(bool value) { }

	public void TweenValue(float floatPercentage) { }

	public void AddOnChangedCallback(UnityAction<float> callback) { }

	public bool GetIgnoreTimescale() { }

	public float GetDuration() { }

	public bool ValidTarget() { }

}

public class FloatTween.FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 5047
{

	public void .ctor() { }

}

internal struct FloatTween : ITweenValue // TypeDefIndex: 6689
{
	private FloatTween.FloatTweenCallback m_Target; 
	private float m_StartValue; 
	private float m_TargetValue; 
	private float m_Duration; 
	private bool m_IgnoreTimeScale; 

	public float startValue { get; set; }
	public float targetValue { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }


	public float get_startValue() { }

	public void set_startValue(float value) { }

	public float get_targetValue() { }

	public void set_targetValue(float value) { }

	public float get_duration() { }

	public void set_duration(float value) { }

	public bool get_ignoreTimeScale() { }

	public void set_ignoreTimeScale(bool value) { }

	public void TweenValue(float floatPercentage) { }

	public void AddOnChangedCallback(UnityAction<float> callback) { }

	public bool GetIgnoreTimescale() { }

	public float GetDuration() { }

	public bool ValidTarget() { }

}

public class FloatTween.FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 6690
{

	public void .ctor() { }

}

