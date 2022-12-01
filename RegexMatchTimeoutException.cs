public class RegexMatchTimeoutException : TimeoutException, ISerializable // TypeDefIndex: 2624
{
	private string regexInput;
	private string regexPattern;
	private TimeSpan matchTimeout;


	public void .ctor(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	public void .ctor() { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	private void Init() { }

	private void Init(string input, string pattern, TimeSpan timeout) { }

}

