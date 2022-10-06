public static class IParticleSystemJobExtensions // TypeDefIndex: 4550
{

	[ExtensionAttribute] 
	public static JobHandle Schedule<T>(T jobData, ParticleSystem ps, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-IParticleSystemJobExtensions.Schedule<ParticleSystemIK.ParticleSystemIKJob>
	*/

	private static JobsUtility.JobScheduleParameters CreateScheduleParams<T>(ref T jobData, ParticleSystem ps, JobHandle dependsOn, IntPtr jobReflectionData) { }
	/* GenericInstMethod :
	|
	|-IParticleSystemJobExtensions.CreateScheduleParams<ParticleSystemIK.ParticleSystemIKJob>
	*/

}

