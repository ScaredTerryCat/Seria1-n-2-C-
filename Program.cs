using System;
class Program{
	public static double temaAnaliza(double eroare=0.01){
	double s=0,err=-1;
	double n=1;
	bool running=true;
	double t1,t2;
	t2=-1;
	while(running==true){
		t1=t2;
		t2=1/(n*n);
		s+=t2;
		if(n>=2){
			err=t2-t1;
			if(err<0){err*=-1;}
			if(err<=eroare){
				Console.WriteLine($"n={n}\tSuma={s}\teroare={err} < {eroare}");
				return s;
			}
		}
	n++;
	}
return -1;
	}
	public static void Main(string[] args){
		double sumaSeriei=temaAnaliza();
	}
}