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
				
				var _sourceMapped74_1719 = this.Position;
				var _source74_1719 = _sourceMapped74_1719;
				var _range74_1719 = 2;
							
				Func<VirusSpreading.Human, bool> _predicate74_1719 = null;
				Func<VirusSpreading.Human, bool> _predicateMod74_1719 = new Func<VirusSpreading.Human, bool>(_it => 
				{
					if (_it?.ID == this.ID)
					{
						return false;
					} else if (_predicate74_1719 != null)
					{
						return _predicate74_1719.Invoke(_it);
					} else return true;
				});
				
				return _City._HumanEnvironment.Explore(_source74_1719 , _range74_1719, -1, _predicate74_1719).ToArray();
			}).Invoke();
			if(!Equals(nearHuman[0], null)) {
							{
							TargetDistance = new Func<double>(() => {
							var _target76_1789 = nearHuman[0];
							if (_target76_1789 == null) return 0.0;
							return Mars.Mathematics.Distance.Calculate(Mars.Mathematics.SpaceDistanceMetric.Chebyshev, this.Position.PositionArray, _target76_1789.Position.PositionArray);
							}).Invoke()
							;}
					;} ;
			if(!Equals(nearHuman[1], null)) {
							{
							TargetDistance2 = new Func<double>(() => {
							var _target78_1861 = nearHuman[1];
							if (_target78_1861 == null) return 0.0;
							return Mars.Mathematics.Distance.Calculate(Mars.Mathematics.SpaceDistanceMetric.Chebyshev, this.Position.PositionArray, _target78_1861.Position.PositionArray);
							}).Invoke()
							;}
					;} ;
			if(!Equals(nearHuman[2], null)) {
							{
							TargetDistance3 = new Func<double>(() => {
							var _target80_1933 = nearHuman[2];
							if (_target80_1933 == null) return 0.0;
							return Mars.Mathematics.Distance.Calculate(Mars.Mathematics.SpaceDistanceMetric.Chebyshev, this.Position.PositionArray, _target80_1933.Position.PositionArray);
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
												
												var _speed88_2222 = 1
											;
												
												var _entity88_2222 = this;
												
												Func<double[], bool> _predicate88_2222 = null;
												
												var _target88_2222 = new System.Tuple<double,double>(2 * this.Position.X - nearx,2 * this.Position.Y - neary);
												_City._HumanEnvironment.MoveTo(_entity88_2222,
													 _target88_2222.Item1, _target88_2222.Item2, 
													_speed88_2222, 
													_predicate88_2222);
												
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
																
																var _speed100_2625 = 1
															;
																
																var _entity100_2625 = this;
																
																Func<double[], bool> _predicate100_2625 = null;
																
																var _target100_2625 = new System.Tuple<double,double>(2 * this.Position.X - ax,2 * this.Position.Y - ay);
																_City._HumanEnvironment.MoveTo(_entity100_2625,
																	 _target100_2625.Item1, _target100_2625.Item2, 
																	_speed100_2625, 
																	_predicate100_2625);
																
																return new Tuple<double, double>(Position.X, Position.Y);
															}).Invoke()
															;}
													;} else {
															{
															new System.Func<Tuple<double,double>>(() => {
																
																var _speed104_2689 = 2
															;
																
																var _entity104_2689 = this;
																
																Func<double[], bool> _predicate104_2689 = null;
																
																var _target104_2689 = new System.Tuple<int,int>(_Random.Next(city.DimensionX()
																),
																_Random.Next(city.DimensionY()
																)
																);
																_City._HumanEnvironment.MoveTo(_entity104_2689,
																	 _target104_2689.Item1, _target104_2689.Item2, 
																	_speed104_2689, 
																	_predicate104_2689);
																
																return new Tuple<double, double>(Position.X, Position.Y);
															}).Invoke()
															;}
														;}
										;}
							;}
					;} else {
							{
							new System.Func<Tuple<double,double>>(() => {
								
								var _speed108_2774 = _Random.Next(100)
							;
								
								var _entity108_2774 = this;
								
								Func<double[], bool> _predicate108_2774 = null;
								
								var _target108_2774 = new System.Tuple<int,int>(_Random.Next(city.DimensionX()
								),
								_Random.Next(city.DimensionY()
								)
								);
								_City._HumanEnvironment.MoveTo(_entity108_2774,
									 _target108_2774.Item1, _target108_2774.Item2, 
									_speed108_2774, 
									_predicate108_2774);
								
								return new Tuple<double, double>(Position.X, Position.Y);
							}).Invoke()
							;}
						;}
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
							return CalcInfected(Neighbor,RandomValue,80)
							;}
					;} ;
			if(Distance <= 1) {
							{
							return CalcInfected(Neighbor,RandomValue,60)
							;}
					;} ;
			if(Distance <= 1.5) {
							{
							return CalcInfected(Neighbor,RandomValue,40)
							;}
					;} ;
			if(Distance <= 2) {
							{
							return CalcInfected(Neighbor,RandomValue,20)
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
							Ticks++
							;}
					;} ;
			if(!Immune) {
							{
							if(Energy - _Random.Next(Energy)
							 <= 2) {
											{
											new System.Action(() => {
												var _target168_4117 = this;
												if (_target168_4117 != null) {
													_City._KillHuman(_target168_4117, _target168_4117._executionFrequency);
												}
											}).Invoke()
											;}
									;} ;
							if(Energy <= 0) {
											{
											new System.Action(() => {
												var _target171_4155 = this;
												if (_target171_4155 != null) {
													_City._KillHuman(_target171_4155, _target171_4155._executionFrequency);
												}
											}).Invoke()
											;}
									;} else {
											{
											Energy--
											;}
										;};
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
				var _target183_4370 = this;
				if (_target183_4370 != null) {
					_City._KillHuman(_target183_4370, _target183_4370._executionFrequency);
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
		int Government_announce_date
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
			_City._HumanEnvironment.Insert(this);
			_register(_layer, this, freq);
			_isAlive = true;
			_executionFrequency = freq;
			{
			new System.Func<System.Tuple<double,double>>(() => {
				
				var _taget35_899 = new System.Tuple<int,int>(_Random.Next(city.DimensionX()
				),
				_Random.Next(city.DimensionY()
				)
				);
				
				var _object35_899 = this;
				
				_City._HumanEnvironment.PosAt(_object35_899, 
					_taget35_899.Item1, _taget35_899.Item2
				);
				return new Tuple<double, double>(Position.X, Position.Y);
			}).Invoke();
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
						;}
			;}
		}
		
		public void Tick()
		{
			{ if (!_isAlive) return; }
			{
			Move();
			if(Equals(Infected, true)) {
							{
							VirusSpreading.Human[] Neighbors = new System.Func<VirusSpreading.Human[]>(() => {
								
								var _sourceMapped51_1202 = this.Position;
								var _source51_1202 = _sourceMapped51_1202;
								var _range51_1202 = 2;
											
								Func<VirusSpreading.Human, bool> _predicate51_1202 = null;
								Func<VirusSpreading.Human, bool> _predicateMod51_1202 = new Func<VirusSpreading.Human, bool>(_it => 
								{
									if (_it?.ID == this.ID)
									{
										return false;
									} else if (_predicate51_1202 != null)
									{
										return _predicate51_1202.Invoke(_it);
									} else return true;
								});
								
								return _City._HumanEnvironment.Explore(_source51_1202 , _range51_1202, -1, _predicate51_1202).ToArray();
							}).Invoke();
							if(!Equals(Neighbors[0], null)) {
											{
											foreach ( var Neighbor in Neighbors ) {
														{
														if(Equals(Neighbor.IsInfected()
														, false) && Equals(Neighbor.IsImmune()
														, false)) {
																		{
																		Infect(Neighbor,new Func<double>(() => {
																		var _target57_1488 = (Neighbor);
																		if (_target57_1488 == null) return 0.0;
																		return Mars.Mathematics.Distance.Calculate(Mars.Mathematics.SpaceDistanceMetric.Chebyshev, this.Position.PositionArray, _target57_1488.Position.PositionArray);
																		}).Invoke())
																		;}
																;} 
														;}
													}
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
