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
	public class Human : Mars.Interfaces.Agent.IMarsDslAgent {
		private static readonly Mars.Common.Logging.ILogger _Logger = 
					Mars.Common.Logging.LoggerFactory.GetLogger(typeof(Human));
		private readonly System.Random _Random = new System.Random();
		private string __Rule
			 = "";
		public string Rule { 
			get { return __Rule; }
			set{
				if(__Rule != value) __Rule = value;
			}
		}
		private int __Energy
			 = default(int);
		public int Energy { 
			get { return __Energy; }
			set{
				if(__Energy != value) __Energy = value;
			}
		}
		private bool __Infected
			 = false;
		public bool Infected { 
			get { return __Infected; }
			set{
				if(__Infected != value) __Infected = value;
			}
		}
		private bool __Immune
			 = false;
		public bool Immune { 
			get { return __Immune; }
			set{
				if(__Immune != value) __Immune = value;
			}
		}
		private bool __Obedient
			 = false;
		public bool Obedient { 
			get { return __Obedient; }
			set{
				if(__Obedient != value) __Obedient = value;
			}
		}
		private bool __Vulnerable
			 = false;
		public bool Vulnerable { 
			get { return __Vulnerable; }
			set{
				if(__Vulnerable != value) __Vulnerable = value;
			}
		}
		private int __Ticks
			 = default(int);
		public int Ticks { 
			get { return __Ticks; }
			set{
				if(__Ticks != value) __Ticks = value;
			}
		}
		private int __LossTicks
			 = default(int);
		public int LossTicks { 
			get { return __LossTicks; }
			set{
				if(__LossTicks != value) __LossTicks = value;
			}
		}
		private int __R0
			 = default(int);
		public int R0 { 
			get { return __R0; }
			set{
				if(__R0 != value) __R0 = value;
			}
		}
		private bool __DeadTick
			 = false;
		public bool DeadTick { 
			get { return __DeadTick; }
			set{
				if(__DeadTick != value) __DeadTick = value;
			}
		}
		private int __Human_gain_by_age
			 = default(int);
		public int Human_gain_by_age { 
			get { return __Human_gain_by_age; }
			set{
				if(__Human_gain_by_age != value) __Human_gain_by_age = value;
			}
		}
		private int __Vulnerable_class_ratio
			 = default(int);
		public int Vulnerable_class_ratio { 
			get { return __Vulnerable_class_ratio; }
			set{
				if(__Vulnerable_class_ratio != value) __Vulnerable_class_ratio = value;
			}
		}
		private int __Obey_ratio
			 = default(int);
		public int Obey_ratio { 
			get { return __Obey_ratio; }
			set{
				if(__Obey_ratio != value) __Obey_ratio = value;
			}
		}
		private int __Government_announce_date
			 = default(int);
		public int Government_announce_date { 
			get { return __Government_announce_date; }
			set{
				if(__Government_announce_date != value) __Government_announce_date = value;
			}
		}
		private int __Initial_infected_rate
			 = default(int);
		public int Initial_infected_rate { 
			get { return __Initial_infected_rate; }
			set{
				if(__Initial_infected_rate != value) __Initial_infected_rate = value;
			}
		}
		private int __Infection_rate1
			 = default(int);
		internal int Infection_rate1 { 
			get { return __Infection_rate1; }
			set{
				if(__Infection_rate1 != value) __Infection_rate1 = value;
			}
		}
		private int __Infection_rate2
			 = default(int);
		internal int Infection_rate2 { 
			get { return __Infection_rate2; }
			set{
				if(__Infection_rate2 != value) __Infection_rate2 = value;
			}
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void RandomMove() 
		{
			{
			new System.Func<Tuple<double,double>>(() => {
				
				var _speed89_2383 = _Random.Next(100)
			;
				
				var _entity89_2383 = this;
				
				Func<double[], bool> _predicate89_2383 = null;
				
				var _target89_2383 = new System.Tuple<int,int>(_Random.Next(city.DimensionX()
				),
				_Random.Next(city.DimensionY()
				)
				);
				_City._HumanEnvironment.MoveTo(_entity89_2383,
					 _target89_2383.Item1, _target89_2383.Item2, 
					_speed89_2383, 
					_predicate89_2383);
				
				return new Tuple<double, double>(Position.X, Position.Y);
			}).Invoke()
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual bool Infect(VirusSpreading.Human Neighbor, double Distance) 
		{
			{
			int RandomValue = _Random.Next(100);
			if(Distance <= 1) {
							{
							return CalcInfected(Neighbor,RandomValue,Infection_rate1)
							;}
					;} ;
			if(Distance <= 2) {
							{
							return CalcInfected(Neighbor,RandomValue,Infection_rate2)
							;}
					;} 
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual bool CalcInfected(VirusSpreading.Human Neighbor, double RandomValue, double ComparedTo) 
		{
			{
			if(RandomValue < ComparedTo) {
							{
							Neighbor.SetInfected(true);
							R0++;
							return true
							;}
					;} else {
							{
							return false
							;}
						;}
			;}
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Recover() 
		{
			{
			if(Infected) {
							{
							Infected = false;
							Immune = true
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Loss() 
		{
			{
			if(Infected) {
							{
							LossTicks++;
							if(Equals(LossTicks % 24, 0)) {
											{
											Energy--;
											if(Vulnerable) {
															{
															if(_Random.Next(100)
															 < 20) {
																			{
																			Energy = Energy - _Random.Next(4)
																			;}
																	;} 
															;}
													;} else {
															{
															if(_Random.Next(100)
															 < 5) {
																			{
																			Energy = Energy - _Random.Next(2)
																			;}
																	;} 
															;}
														;};
											if(Energy < 1) {
															{
															DeadTick = true;
															new System.Action(() => {
																var _target139_3579 = this;
																if (_target139_3579 != null) {
																	_City._KillHuman(_target139_3579, _target139_3579._executionFrequency);
																}
															}).Invoke()
															;}
													;} 
											;}
									;} ;
							if(LossTicks / 24 >= 15 && Energy > 0 && _Random.Next(100)
							 < 10) {
											{
											Recover()
											;}
									;} 
							;}
					;} 
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public bool IsInfected() {
			{
			return Infected
					;
			}
			
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public bool IsImmune() {
			{
			return Immune
					;
			}
			
			return default(bool);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void SetInfected(
		bool Bool) {
			{
			Infected = Bool
					;
			}
			
			return;
		}
		internal bool _isAlive;
		internal int _executionFrequency;
		
		public VirusSpreading.City _Layer_ => _City;
		public VirusSpreading.City _City { get; set; }
		public VirusSpreading.City city => _City;
		public Mars.Components.Environments.SpatialHashEnvironment<Human> _HumanEnvironment { get; set; }
		
		[Mars.Interfaces.LIFECapabilities.PublishForMappingInMars]
		public Human (
		System.Guid _id,
		VirusSpreading.City _layer,
		Mars.Interfaces.Layer.RegisterAgent _register,
		Mars.Interfaces.Layer.UnregisterAgent _unregister,
		Mars.Components.Environments.SpatialHashEnvironment<Human> _HumanEnvironment,
		int Human_gain_by_age,
		int Vulnerable_class_ratio,
		int Obey_ratio,
		int Government_announce_date,
		int Initial_infected_rate,
		int Infection_rate1,
		int Infection_rate2
	,	double xcor = 0, double ycor = 0, int freq = 1)
		{
			_City = _layer;
			ID = _id;
			Position = Mars.Interfaces.Environment.Position.CreatePosition(xcor, ycor);
			_Random = new System.Random(ID.GetHashCode());
			this.Human_gain_by_age = Human_gain_by_age;
			this.Vulnerable_class_ratio = Vulnerable_class_ratio;
			this.Obey_ratio = Obey_ratio;
			this.Government_announce_date = Government_announce_date;
			this.Initial_infected_rate = Initial_infected_rate;
			this.Infection_rate1 = Infection_rate1;
			this.Infection_rate2 = Infection_rate2;
			_City._HumanEnvironment.Insert(this);
			_register(_layer, this, freq);
			_isAlive = true;
			_executionFrequency = freq;
			{
			new System.Func<System.Tuple<double,double>>(() => {
				
				var _taget35_1049 = new System.Tuple<int,int>(_Random.Next(city.DimensionX()
				),
				_Random.Next(city.DimensionY()
				)
				);
				
				var _object35_1049 = this;
				
				_City._HumanEnvironment.PosAt(_object35_1049, 
					_taget35_1049.Item1, _taget35_1049.Item2
				);
				return new Tuple<double, double>(Position.X, Position.Y);
			}).Invoke();
			R0 = 0;
			Ticks = 0;
			LossTicks = 0;
			int Class = _Random.Next(100);
			if(Class < Vulnerable_class_ratio) {
							{
							Energy = _Random.Next(Human_gain_by_age);
							Vulnerable = true
							;}
					;} else {
							{
							Energy = _Random.Next(Human_gain_by_age)
							 + 40
							;}
						;};
			int infect = _Random.Next(100);
			if(infect < Initial_infected_rate) {
							{
							Infected = true
							;}
					;} 
			;}
		}
		
		public void Tick()
		{
			{ if (!_isAlive) return; }
			{
			Ticks++;
			if(Equals(Obedient, false)) {
							{
							RandomMove()
							;}
					;} ;
			if(Equals(Infected, true)) {
							{
							VirusSpreading.Human NearestHuman = new Func<VirusSpreading.Human>(() => {
								Func<VirusSpreading.Human, bool> _predicate62_1572 = null;
								Func<VirusSpreading.Human, bool> _predicateMod62_1572 = new Func<VirusSpreading.Human, bool>(_it => 
								{
									if (_it?.ID == this.ID)
									{
										return false;
									} else if (_predicate62_1572 != null)
									{
										return _predicate62_1572.Invoke(_it);
									} else return true;
								});
								
								const int _range62_1572 = -1;
								var _source62_1572 = this.Position;
								
								return _City._HumanEnvironment.Explore(_source62_1572, _range62_1572, 1, _predicateMod62_1572)?.FirstOrDefault();
							}).Invoke();
							if(!Equals(NearestHuman, null)) {
											{
											double NearestDistance = new Func<double>(() => {
											var _target64_1645 = (NearestHuman);
											if (_target64_1645 == null) return 0.0;
											return Mars.Mathematics.Distance.Calculate(Mars.Mathematics.SpaceDistanceMetric.Chebyshev, this.Position.PositionArray, _target64_1645.Position.PositionArray);
											}).Invoke();
											if(NearestDistance <= 2) {
															{
															VirusSpreading.Human[] Neighbors = new System.Func<VirusSpreading.Human[]>(() => {
																
																var _sourceMapped66_1776 = this.Position;
																var _source66_1776 = _sourceMapped66_1776;
																var _range66_1776 = 2;
																			
																Func<VirusSpreading.Human, bool> _predicate66_1776 = null;
																Func<VirusSpreading.Human, bool> _predicateMod66_1776 = new Func<VirusSpreading.Human, bool>(_it => 
																{
																	if (_it?.ID == this.ID)
																	{
																		return false;
																	} else if (_predicate66_1776 != null)
																	{
																		return _predicate66_1776.Invoke(_it);
																	} else return true;
																});
																
																return _City._HumanEnvironment.Explore(_source66_1776 , _range66_1776, -1, _predicate66_1776).ToArray();
															}).Invoke();
															foreach ( var Neighbor in Neighbors ) {
																		{
																		double NeighborDistance = new Func<double>(() => {
																		var _target68_1913 = (Neighbor);
																		if (_target68_1913 == null) return 0.0;
																		return Mars.Mathematics.Distance.Calculate(Mars.Mathematics.SpaceDistanceMetric.Chebyshev, this.Position.PositionArray, _target68_1913.Position.PositionArray);
																		}).Invoke();
																		if(NeighborDistance <= 2 && Equals(Neighbor.IsInfected()
																		, false) && Equals(Neighbor.IsImmune()
																		, false)) {
																						{
																						Infect(Neighbor,new Func<double>(() => {
																						var _target70_2110 = (Neighbor);
																						if (_target70_2110 == null) return 0.0;
																						return Mars.Mathematics.Distance.Calculate(Mars.Mathematics.SpaceDistanceMetric.Chebyshev, this.Position.PositionArray, _target70_2110.Position.PositionArray);
																						}).Invoke())
																						;}
																				;} 
																		;}
																	}
															;}
													;} 
											;}
									;} 
							;}
					;} ;
			Loss();
			if(Equals(Ticks, Government_announce_date)) {
							{
							int Obey = _Random.Next(100);
							if(Obey < Obey_ratio) {
											{
											Obedient = true
											;}
									;} 
							;}
					;} 
			;}
		}
		
		public System.Guid ID { get; }
		public Mars.Interfaces.Environment.Position Position { get; set; }
		public bool Equals(Human other) => Equals(ID, other.ID);
		public override int GetHashCode() => ID.GetHashCode();
	}
}
