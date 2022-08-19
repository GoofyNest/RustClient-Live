public class AggregateException : Exception // TypeDefIndex: 141
{	// Fields
	private ReadOnlyCollection<Exception> m_innerExceptions; // 0x88

	// Properties
	public ReadOnlyCollection<Exception> InnerExceptions { get; }

	// Methods

	// RVA: 0x157E900 Offset: 0x157DD00 VA: 0x18157E900
	public void .ctor() { }

	// RVA: 0x157E000 Offset: 0x157D400 VA: 0x18157E000
	public void .ctor(IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x157E3D0 Offset: 0x157D7D0 VA: 0x18157E3D0
	public void .ctor(Exception[] innerExceptions) { }

	// RVA: 0x157E9C0 Offset: 0x157DDC0 VA: 0x18157E9C0
	public void .ctor(string message, IEnumerable<Exception> innerExceptions) { }

	// RVA: 0x157E500 Offset: 0x157D900 VA: 0x18157E500
	public void .ctor(string message, Exception[] innerExceptions) { }

	// RVA: 0x157E0D0 Offset: 0x157D4D0 VA: 0x18157E0D0
	private void .ctor(string message, IList<Exception> innerExceptions) { }

	// RVA: 0x157E430 Offset: 0x157D830 VA: 0x18157E430
	internal void .ctor(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x157E320 Offset: 0x157D720 VA: 0x18157E320
	internal void .ctor(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x157E510 Offset: 0x157D910 VA: 0x18157E510
	private void .ctor(string message, IList<ExceptionDispatchInfo> innerExceptionInfos) { }

	// RVA: 0x157E770 Offset: 0x157DB70 VA: 0x18157E770
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x157DB20 Offset: 0x157CF20 VA: 0x18157DB20 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	public ReadOnlyCollection<Exception> get_InnerExceptions() { }

	// RVA: 0x157D930 Offset: 0x157CD30 VA: 0x18157D930
	public AggregateException Flatten() { }

	// RVA: 0x157DC60 Offset: 0x157D060 VA: 0x18157DC60 Slot: 3
	public override string ToString() { }

}

