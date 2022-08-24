public class AggregateException : Exception // TypeDefIndex: 141
{
	private ReadOnlyCollection<Exception> m_innerExceptions; 

	public ReadOnlyCollection<Exception> InnerExceptions { get; }


	public void .ctor() { }

	public void .ctor(IEnumerable<Exception> innerExceptions) { }

	public void .ctor(Exception[] innerExceptions) { }

	public void .ctor(string message, IEnumerable<Exception> innerExceptions) { }

	public void .ctor(string message, Exception[] innerExceptions) { }

	private void .ctor(string message, IList<Exception> innerExceptions) { }

	internal void .ctor(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	internal void .ctor(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	private void .ctor(string message, IList<ExceptionDispatchInfo> innerExceptionInfos) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public ReadOnlyCollection<Exception> get_InnerExceptions() { }

	public AggregateException Flatten() { }

	public override string ToString() { }

}

