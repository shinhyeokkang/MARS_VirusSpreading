public static class Program {
	public static void Main(string[] args) {
		if (args != null && System.Linq.Enumerable.Any(args, s => s.Equals("-l")))
		{
			Mars.Common.Logging.LoggerFactory.SetLogLevel(Mars.Common.Logging.Enums.LogLevel.Info);
			Mars.Common.Logging.LoggerFactory.ActivateConsoleLogging();
		}
		var description = new Mars.Core.ModelContainer.Entities.ModelDescription();
		description.AddLayer<MyVirusSpreading.City>();
		description.AddLayer<VirusSpreading.City>();
		description.AddLayer<corona.city>();
		description.AddAgent<MyVirusSpreading.Human, MyVirusSpreading.City>();
		description.AddAgent<VirusSpreading.Human, VirusSpreading.City>();
		description.AddAgent<corona.Human, corona.city>();
		var task = Mars.Core.SimulationStarter.SimulationStarter.Start(description, args);
		var loopResults = task.Run();
		System.Console.WriteLine($"Simulation execution finished after {loopResults.Iterations} steps");
	}
}
