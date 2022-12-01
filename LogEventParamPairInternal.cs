internal struct LogEventParamPairInternal : IGettable<LogEventParamPair>, ISettable<LogEventParamPair>, IDisposable // TypeDefIndex: 9768
{
	private LogEventParamPairParamValueInternal m_ParamValue;

	public LogEventParamPairParamValue ParamValue { get; set; }


	public LogEventParamPairParamValue get_ParamValue() { }

	public void set_ParamValue(LogEventParamPairParamValue value) { }

	public void Set(ref LogEventParamPair other) { }

	public void Set(ref Nullable<LogEventParamPair> other) { }

	public void Dispose() { }

	public void Get(out LogEventParamPair output) { }

}

