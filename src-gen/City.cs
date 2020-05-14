namespace VirusSpreading {
	using System;
	using System.Linq;
	using System.Collections.Generic;
	// Pragma and ReSharper disable all warnings for generated code
	#pragma warning disable 162
	#pragma warning disable 219
	#pragma warning disable 169
	[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalse")]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "UnusedParameter.Local")]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "PossibleInvalidOperationException")]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "ExpressionIsAlwaysNull")]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "MemberInitializerValueIgnored")]
	[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantCheckBeforeAssignment")]
	public class City : Mars.Components.Layers.AbstractLayer {
		private static readonly Mars.Common.Logging.ILogger _Logger = 
					Mars.Common.Logging.LoggerFactory.GetLogger(typeof(City));
		private readonly System.Random _Random = new System.Random();
		public Mars.Interfaces.Layer.UnregisterAgent _Unregister { get; set; }
		public Mars.Interfaces.Layer.RegisterAgent _Register { get; set; }
		public Mars.Mathematics.SpaceDistanceMetric _DistanceMetric { get; set; } = Mars.Mathematics.SpaceDistanceMetric.Euclidean;
		private int _dimensionX, _dimensionY;
		public int DimensionX() => _dimensionX;
		public int DimensionY() => _dimensionY;
		public System.Collections.Concurrent.ConcurrentDictionary<Mars.Interfaces.Environment.Position, string> 
			_StringCity { get; set; }
		public System.Collections.Concurrent.ConcurrentDictionary<Mars.Interfaces.Environment.Position, double> 
			_RealCity { get; set; }
		
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public string GetStringValue(int x, int y) => GetStringValue((double)x, y);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public string GetStringValue(double x, double y) =>
			_StringCity.TryGetValue(Mars.Interfaces.Environment.Position.CreatePosition(x, y), out var value) ? value : null;
		
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public int GetIntegerValue(int x, int y) => GetIntegerValue((double)x, y);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public int GetIntegerValue(double x, double y) =>
					_RealCity.TryGetValue(Mars.Interfaces.Environment.Position.CreatePosition(x, y), out var value) ? Convert.ToInt32(value) : 0;
		
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double GetRealValue(int x, int y) => GetRealValue((double)x, y);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double GetRealValue(double x, double y) =>
			_RealCity.TryGetValue(Mars.Interfaces.Environment.Position.CreatePosition(x, y), out var value) ? value : 0;
		
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void SetStringValue(int x, int y, string value) => SetStringValue((double)x, y, value);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void SetStringValue(double x, double y, string value)
		{
			if (value != null)
				_StringCity.AddOrUpdate(Mars.Interfaces.Environment.Position.CreatePosition(x, y), value,
					(position, s) => value);
		}
		
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void SetIntegerValue(double x, double y, int value) => SetRealValue(x, y, value);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void SetIntegerValue(int x, int y, int value) => SetRealValue((double)x, y, value);
		
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void SetRealValue(int x, int y, double value) => SetRealValue((double)x, y, value);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void SetRealValue(double x, double y, double value)
		{
			if (Math.Abs(value) > 0.000000001)
				_RealCity.AddOrUpdate(Mars.Interfaces.Environment.Position.CreatePosition(x, y), value,
					(position, s) => value);
		}
		
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		private void _InitGrid(Mars.Interfaces.Layer.Initialization.TInitData initData)
		{
			if (initData.LayerInitConfig != null && !string.IsNullOrEmpty(initData.LayerInitConfig.File))
			{
				var table = Mars.Common.IO.Csv.CsvReader.MapData(initData.LayerInitConfig.File, null, false);
				
				var xMaxIndex = table.Columns.Count;
				int yMaxIndex = table.Rows.Count - 1;
		
				_dimensionX = table.Columns.Count;
				_dimensionY = table.Rows.Count;
				foreach (System.Data.DataRow tableRow in table.Rows)
				{
					for (int x = 0; x < xMaxIndex; x++)
					{
						var value = tableRow[x].ToString();
						if (double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture,
							out var result))
							SetRealValue(x, yMaxIndex, result);
						else
							SetStringValue(x, yMaxIndex, value);
					}
					yMaxIndex --;
				}
			}
		}
		
		public Mars.Components.Environments.SpatialHashEnvironment<Human> _HumanEnvironment { get; set; }
		public System.Collections.Generic.IDictionary<System.Guid, Human> _HumanAgents { get; set; }
		
		public City _City => this;
		public City city => this;
		public City (
		double dimensionX = 100, double dimensionY = 100, int cellSize = 1
				) {
			_dimensionX = Convert.ToInt32(dimensionX); _dimensionY = Convert.ToInt32(dimensionY);
			_StringCity = new System.Collections.Concurrent.ConcurrentDictionary<Mars.Interfaces.Environment.Position, string>();
			_RealCity = new System.Collections.Concurrent.ConcurrentDictionary<Mars.Interfaces.Environment.Position, double>();
		}
		
		public override bool InitLayer(
			Mars.Interfaces.Layer.Initialization.TInitData initData, 
			Mars.Interfaces.Layer.RegisterAgent regHandle, 
			Mars.Interfaces.Layer.UnregisterAgent unregHandle)
		{
			base.InitLayer(initData, regHandle, unregHandle);
			this._Register = regHandle;
			this._Unregister = unregHandle;
			
			_InitGrid(initData);
			this._HumanEnvironment = new Mars.Components.Environments.SpatialHashEnvironment<Human>(_dimensionX, _dimensionY, true);
			
			_HumanAgents = Mars.Components.Services.AgentManager.SpawnAgents<Human>(
			initData.AgentInitConfigs.First(config => config.Type == typeof(Human)),
			regHandle, unregHandle, 
			new System.Collections.Generic.List<Mars.Interfaces.Layer.ILayer> { this });
			
			return true;
		}
		
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public VirusSpreading.Human _SpawnHuman(double xcor = 0, double ycor = 0, int freq = 1) {
			var id = System.Guid.NewGuid();
			var agent = new VirusSpreading.Human(id, this, _Register, _Unregister,
			_HumanEnvironment,
			default(int), 
			default(int), 
			default(int), 
			default(int)
		, 	xcor, ycor, freq);
			_HumanAgents.Add(id, agent);
			return agent;
		}
		
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void _KillHuman(VirusSpreading.Human target, int executionFrequency = 1)
		{
			target._isAlive = false;
			_HumanEnvironment.Remove(target);
			_Unregister(this, target, target._executionFrequency);
			_HumanAgents.Remove(target.ID);
		}
	}
}
