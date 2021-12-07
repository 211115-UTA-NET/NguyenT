namespace SampleNamespace
{
//Class declaration
    abstract class WorkPay
    {
    	protected int _HoursWorked = 40;
	    protected double _PayRate = 18.00;
	    //accessModifier modifier returnType methodName(parameters)
	    public abstract void AbstractMethod();
	    public abstract int HoursWorked { get; }
	    public abstract double PayRate { get; }
    }
	class WorkPayRaise : WorkPay
		{
			public override void AbstractMethod()
			{
	    		_HoursWorked += 5;
				_PayRate += 2.25;
			}
			public override int HoursWorked
			{
				get
				{ 
					return _HoursWorked + 10;
				}
			}
		public override double PayRate
		{
			get
			{
				return _PayRate + 5.50;
			}
		}
	}
}