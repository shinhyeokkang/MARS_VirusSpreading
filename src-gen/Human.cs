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
		private bool __obedient
			 = false;
		public bool obedient { 
			get { return __obedient; }
			set{
				if(__obedient != value) __obedient = value;
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
		private int __R0
			 = default(int);
		public int R0 { 
			get { return __R0; }
			set{
				if(__R0 != value) __R0 = value;
			}
		}
		private VirusSpreading.Human[] __nearHuman
			 = default(VirusSpreading.Human[]);
		internal VirusSpreading.Human[] nearHuman { 
			get { return __nearHuman; }
			set{
				if(__nearHuman != value) __nearHuman = value;
			}
		}
		private double __TargetDistance
			 = 10;
		internal double TargetDistance { 
			get { return __TargetDistance; }
			set{
				if(System.Math.Abs(__TargetDistance - value) > 0.0000001) __TargetDistance = value;
			}
		}
		private double __TargetDistance2
			 = 10;
		internal double TargetDistance2 { 
			get { return __TargetDistance2; }
			set{
				if(System.Math.Abs(__TargetDistance2 - value) > 0.0000001) __TargetDistance2 = value;
			}
		}
		private double __TargetDistance3
			 = 10;
		internal double TargetDistance3 { 
			get { return __TargetDistance3; }
			set{
				if(System.Math.Abs(__TargetDistance3 - value) > 0.0000001) __TargetDistance3 = value;
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
		private int __Infection_rate3
			 = default(int);
		internal int Infection_rate3 { 
			get { return __Infection_rate3; }
			set{
				if(__Infection_rate3 != value) __Infection_rate3 = value;
			}
		}
		private int __Infection_rate4
			 = default(int);
		internal int Infection_rate4 { 
			get { return __Infection_rate4; }
			set{
				if(__Infection_rate4 != value) __Infection_rate4 = value;
			}
		}
		private int __Obey
			 = default(int);
		internal int Obey { 
			get { return __Obey; }
			set{
				if(__Obey != value) __Obey = value;
			}
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void Move() 
		{
			{
			nearHuman = new System.Func<VirusSpreading.Human[]>(() => {
				
				var _sourceMapped100_2716 = this.Position;
				var _source100_2716 = _sourceMapped100_2716;
				var _range100_2716 = -1;
							
				Func<VirusSpreading.Human, bool> _predicate100_2716 = null;
				Func<VirusSpreading.Human, bool> _predicateMod100_2716 = new Func<VirusSpreading.Human, bool>(_it => 
				{
					if (_it?.ID == this.ID)
					{
						return false;
					} else if (_predicate100_2716 != null)
					{
						return _predicate100_2716.Invoke(_it);
					} else return true;
				});
				
				return _City._HumanEnvironment.Explore(_source100_2716 , _range100_2716, -1, _predicate100_2716).ToArray();
			}).Invoke();
			if(!Equals(nearHuman[0], null)) {
							{
							TargetDistance = new Func<double>(() => {
							var _target102_2783 = nearHuman[0];
							if (_target102_2783 == null) return 0.0;
							return Mars.Mathematics.Distance.Calculate(Mars.Mathematics.SpaceDistanceMetric.Chebyshev, this.Position.PositionArray, _target102_2783.Position.PositionArray);
							}).Invoke()
							;}
					;} ;
			if(!Equals(nearHuman[1], null)) {
							{
							TargetDistance2 = new Func<double>(() => {
							var _target106_2866 = nearHuman[1];
							if (_target106_2866 == null) return 0.0;
							return Mars.Mathematics.Distance.Calculate(Mars.Mathematics.SpaceDistanceMetric.Chebyshev, this.Position.PositionArray, _target106_2866.Position.PositionArray);
							}).Invoke()
							;}
					;} ;
			if(!Equals(nearHuman[2], null)) {
							{
							TargetDistance3 = new Func<double>(() => {
							var _target110_2949 = nearHuman[2];
							if (_target110_2949 == null) return 0.0;
							return Mars.Mathematics.Distance.Calculate(Mars.Mathematics.SpaceDistanceMetric.Chebyshev, this.Position.PositionArray, _target110_2949.Position.PositionArray);
							}).Invoke()
							;}
					;} ;
			if(Equals(obedient, true) && TargetDistance <= 2) {
							{
							Rule = "R3 - Social Distancing";
							double nearx = nearHuman[0].GetPositionX();
							double neary = nearHuman[0].GetPositionY();
							if(TargetDistance2 > 2) {
											{
											new System.Func<Tuple<double,double>>(() => {
												
												var _speed120_3255 = 1
											;
												
												var _entity120_3255 = this;
												
												Func<double[], bool> _predicate120_3255 = null;
												
												var _target120_3255 = new System.Tuple<double,double>(2 * this.Position.X - nearx,2 * this.Position.Y - neary);
												_City._HumanEnvironment.MoveTo(_entity120_3255,
													 _target120_3255.Item1, _target120_3255.Item2, 
													_speed120_3255, 
													_predicate120_3255);
												
												return new Tuple<double, double>(Position.X, Position.Y);
											}).Invoke()
											;}
									;} else {
											if(TargetDistance3 > 2) {
															{
															double nearx2 = nearHuman[1].GetPositionX();
															double neary2 = nearHuman[1].GetPositionY();
															double avoidx = Plus(nearx,nearx2);
															double avoidy = Plus(neary,neary2);
															double ax = Divide(avoidx);
															double ay = Divide(avoidy);
															new System.Func<Tuple<double,double>>(() => {
																
																var _speed132_3670 = 1
															;
																
																var _entity132_3670 = this;
																
																Func<double[], bool> _predicate132_3670 = null;
																
																var _target132_3670 = new System.Tuple<double,double>(2 * this.Position.X - ax,2 * this.Position.Y - ay);
																_City._HumanEnvironment.MoveTo(_entity132_3670,
																	 _target132_3670.Item1, _target132_3670.Item2, 
																	_speed132_3670, 
																	_predicate132_3670);
																
																return new Tuple<double, double>(Position.X, Position.Y);
															}).Invoke()
															;}
													;} else {
															{
															new System.Func<Tuple<double,double>>(() => {
																
																var _speed136_3738 = 2
															;
																
																var _entity136_3738 = this;
																
																Func<double[], bool> _predicate136_3738 = null;
																
																var _target136_3738 = new System.Tuple<int,int>(_Random.Next(city.DimensionX()
																),
																_Random.Next(city.DimensionY()
																)
																);
																_City._HumanEnvironment.MoveTo(_entity136_3738,
																	 _target136_3738.Item1, _target136_3738.Item2, 
																	_speed136_3738, 
																	_predicate136_3738);
																
																return new Tuple<double, double>(Position.X, Position.Y);
															}).Invoke()
															;}
														;}
										;}
							;}
					;} else {
							{
							RandomMove()
							;}
						;}
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual void RandomMove() 
		{
			{
			new System.Func<Tuple<double,double>>(() => {
				
				var _speed145_3876 = _Random.Next(100)
			;
				
				var _entity145_3876 = this;
				
				Func<double[], bool> _predicate145_3876 = null;
				
				var _target145_3876 = new System.Tuple<int,int>(_Random.Next(city.DimensionX()
				),
				_Random.Next(city.DimensionY()
				)
				);
				_City._HumanEnvironment.MoveTo(_entity145_3876,
					 _target145_3876.Item1, _target145_3876.Item2, 
					_speed145_3876, 
					_predicate145_3876);
				
				return new Tuple<double, double>(Position.X, Position.Y);
			}).Invoke()
			;}
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Divide(double a) 
		{
			{
			double x = a / 2;
			return x
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual double Plus(double a, double b) 
		{
			{
			double x = a + b;
			return x
			;}
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public virtual bool Infect(VirusSpreading.Human Neighbor, double Distance) 
		{
			{
			int RandomValue = _Random.Next(100);
			if(Distance <= 0.5) {
							{
							return CalcInfected(Neighbor,RandomValue,Infection_rate1)
							;}
					;} ;
			if(Distance <= 1) {
							{
							return CalcInfected(Neighbor,RandomValue,Infection_rate2)
							;}
					;} ;
			if(Distance <= 1.5) {
							{
							return CalcInfected(Neighbor,RandomValue,Infection_rate3)
							;}
					;} ;
			if(Distance <= 2) {
							{
							return CalcInfected(Neighbor,RandomValue,Infection_rate4)
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
		public virtual void recover() 
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
		public virtual void loss() 
		{
			{
			if(Infected) {
							{
							Ticks++;
							if(Equals(Ticks % 24, 0)) {
											{
											if(Energy - _Random.Next(Energy)
											 <= 2) {
															{
															new System.Action(() => {
																var _target203_5272 = this;
																if (_target203_5272 != null) {
																	_City._KillHuman(_target203_5272, _target203_5272._executionFrequency);
																}
															}).Invoke()
															;}
													;} ;
											if(Energy <= 0) {
															{
															new System.Action(() => {
																var _target206_5316 = this;
																if (_target206_5316 != null) {
																	_City._KillHuman(_target206_5316, _target206_5316._executionFrequency);
																}
															}).Invoke()
															;}
													;} else {
															{
															Energy--
															;}
														;}
											;}
									;} ;
							if(Ticks / 24 >= 15 && Energy > 0) {
											{
											recover()
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
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public void Killed() {
			{
			new System.Action(() => {
				var _target219_5525 = this;
				if (_target219_5525 != null) {
					_City._KillHuman(_target219_5525, _target219_5525._executionFrequency);
				}
			}).Invoke()
					;
			}
			
			return;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double GetPositionX() {
			{
			return this.Position.X
					;
			}
			
			return default(double);;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public double GetPositionY() {
			{
			return this.Position.Y
					;
			}
			
			return default(double);;
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
		int Infection_rate2,
		int Infection_rate3,
		int Infection_rate4
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
			this.Infection_rate3 = Infection_rate3;
			this.Infection_rate4 = Infection_rate4;
			_City._HumanEnvironment.Insert(this);
			_register(_layer, this, freq);
			_isAlive = true;
			_executionFrequency = freq;
			{
			new System.Func<System.Tuple<double,double>>(() => {
				
				var _taget42_1182 = new System.Tuple<int,int>(_Random.Next(city.DimensionX()
				),
				_Random.Next(city.DimensionY()
				)
				);
				
				var _object42_1182 = this;
				
				_City._HumanEnvironment.PosAt(_object42_1182, 
					_taget42_1182.Item1, _taget42_1182.Item2
				);
				return new Tuple<double, double>(Position.X, Position.Y);
			}).Invoke();
			R0 = 0;
			int Class = _Random.Next(100);
			if(Class < Vulnerable_class_ratio) {
							{
							Energy = _Random.Next(Human_gain_by_age)
							;}
					;} else {
							{
							Energy = _Random.Next(Human_gain_by_age)
							 + 15
							;}
						;};
			int infect = _Random.Next(100);
			if(infect <= Initial_infected_rate) {
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
							var _target64_1643 = (NearestHuman);
							if (_target64_1643 == null) return 0.0;
							return Mars.Mathematics.Distance.Calculate(Mars.Mathematics.SpaceDistanceMetric.Chebyshev, this.Position.PositionArray, _target64_1643.Position.PositionArray);
							}).Invoke();
							if(NearestDistance <= 2) {
											{
											Move()
											;}
									;} else {
											{
											RandomMove()
											;}
										;}
							;}
					;} ;
			if(Equals(Infected, true)) {
							{
							VirusSpreading.Human NearestHuman2 = new Func<VirusSpreading.Human>(() => {
								Func<VirusSpreading.Human, bool> _predicate74_1918 = null;
								Func<VirusSpreading.Human, bool> _predicateMod74_1918 = new Func<VirusSpreading.Human, bool>(_it => 
								{
									if (_it?.ID == this.ID)
									{
										return false;
									} else if (_predicate74_1918 != null)
									{
										return _predicate74_1918.Invoke(_it);
									} else return true;
								});
								
								const int _range74_1918 = -1;
								var _source74_1918 = this.Position;
								
								return _City._HumanEnvironment.Explore(_source74_1918, _range74_1918, 1, _predicateMod74_1918)?.FirstOrDefault();
							}).Invoke();
							if(!Equals(NearestHuman2, null)) {
											{
											double NearestDistance2 = new Func<double>(() => {
											var _target76_1993 = (NearestHuman2);
											if (_target76_1993 == null) return 0.0;
											return Mars.Mathematics.Distance.Calculate(Mars.Mathematics.SpaceDistanceMetric.Chebyshev, this.Position.PositionArray, _target76_1993.Position.PositionArray);
											}).Invoke();
											if(NearestDistance2 <= 2) {
															{
															VirusSpreading.Human[] Neighbors = new System.Func<VirusSpreading.Human[]>(() => {
																
																var _sourceMapped78_2126 = this.Position;
																var _source78_2126 = _sourceMapped78_2126;
																var _range78_2126 = 2;
																			
																Func<VirusSpreading.Human, bool> _predicate78_2126 = null;
																Func<VirusSpreading.Human, bool> _predicateMod78_2126 = new Func<VirusSpreading.Human, bool>(_it => 
																{
																	if (_it?.ID == this.ID)
																	{
																		return false;
																	} else if (_predicate78_2126 != null)
																	{
																		return _predicate78_2126.Invoke(_it);
																	} else return true;
																});
																
																return _City._HumanEnvironment.Explore(_source78_2126 , _range78_2126, -1, _predicate78_2126).ToArray();
															}).Invoke();
															foreach ( var Neighbor in Neighbors ) {
																		{
																		double NeighborDistance = new Func<double>(() => {
																		var _target80_2263 = (Neighbor);
																		if (_target80_2263 == null) return 0.0;
																		return Mars.Mathematics.Distance.Calculate(Mars.Mathematics.SpaceDistanceMetric.Chebyshev, this.Position.PositionArray, _target80_2263.Position.PositionArray);
																		}).Invoke();
																		if(NeighborDistance < 2 && Equals(Neighbor.IsInfected()
																		, false) && Equals(Neighbor.IsImmune()
																		, false)) {
																						{
																						Infect(Neighbor,new Func<double>(() => {
																						var _target82_2459 = (Neighbor);
																						if (_target82_2459 == null) return 0.0;
																						return Mars.Mathematics.Distance.Calculate(Mars.Mathematics.SpaceDistanceMetric.Chebyshev, this.Position.PositionArray, _target82_2459.Position.PositionArray);
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
			loss();
			if(Ticks / 24 >= Government_announce_date) {
							{
							if(Obey < Obey_ratio) {
											{
											obedient = true
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
