using System;
namespace CalorieCalc
{
    public static class Progress
    {
		public static double sut;
		public static double et;
		public static double ekmek;
		public static double meyve;
		public static double sebze;
		public static double yag;
		//RES Objects
		public static double carb;
		public static double pro;
		public static double oil;
		//RES Calories
		public static double calcarb;
		public static double calpro;
		public static double caloil;
		//RES Percents
		public static double percarb;
		public static double perpro;
		public static double peroil;
		//Common
		public static int calorie;
		public static double caloriedb;
		public static double caloriedbV2;
		
		public static void calculate()
        {
			carb = sut * 9 + ekmek * 15 + meyve * 15 + sebze * 6;
			pro = sut * 6 + et * 6 + ekmek * 2 + sebze * 2;
			oil = sut * 6 + et * 5 + yag * 5;
			calcarb = carb * 4;
			calpro = pro * 4;
			caloil = oil * 9;
			caloriedb = calcarb + calpro + caloil;
			caloriedbV2 = caloriedb;
			if (caloriedbV2 == 0)
				caloriedbV2 = 999999999;
			calorie = Convert.ToInt32(Math.Round(caloriedb));
			percarb = Math.Round(((100 * calcarb) / caloriedbV2),1);
			perpro = Math.Round(((100 * calpro) / caloriedbV2),1);
			peroil = Math.Round(((100 * caloil) / caloriedbV2),1);
		}
		public static void sifirla()
        {
			sut = 0;
			et = 0;
			ekmek = 0;
			meyve = 0;
			sebze = 0;
		    yag = 0;
			calculate();
		}
        #region +1 Buttons
        public static void sut1()
        {
			sut += 1;
			calculate();
        }
		public static void et1()
		{
			et += 1;
			calculate();
		}
		public static void ekmek1()
		{
			ekmek += 1;
			calculate();
		}
		public static void meyve1()
		{
			meyve += 1;
			calculate();
		}
		public static void sebze1()
		{
			sebze += 1;
			calculate();
		}
		public static void yag1()
		{
			yag += 1;
			calculate();
		}
		#endregion
		#region +0.5 Buttons
		public static void sut5()
		{
			sut += 0.5;
			calculate();
		}
		public static void et5()
		{
			et += 0.5;
			calculate();
		}
		public static void ekmek5()
		{
			ekmek += 0.5;
			calculate();
		}
		public static void meyve5()
		{
			meyve += 0.5;
			calculate();
		}
		public static void sebze5()
		{
			sebze += 0.5;
			calculate();
		}
		public static void yag5()
		{
			yag += 0.5;
			calculate();
		}
		#endregion
		#region -1 Buttons
		public static void sut_1()
		{
			sut -= 1;
			calculate();
		}
		public static void et_1()
		{
			et -= 1;
			calculate();
		}
		public static void ekmek_1()
		{
			ekmek -= 1;
			calculate();
		}
		public static void meyve_1()
		{
			meyve -= 1;
			calculate();
		}
		public static void sebze_1()
		{
			sebze -= 1;
			calculate();
		}
		public static void yag_1()
		{
			yag -= 1;
			calculate();
		}
		#endregion
		#region -0.5 Buttons
		public static void sut_5()
		{
			sut -= 0.5;
			calculate();
		}
		public static void et_5()
		{
			et -= 0.5;
			calculate();
		}
		public static void ekmek_5()
		{
			ekmek -= 0.5;
			calculate();
		}
		public static void meyve_5()
		{
			meyve -= 0.5;
			calculate();
		}
		public static void sebze_5()
		{
			sebze -= 0.5;
			calculate();
		}
		public static void yag_5()
		{
			yag -= 0.5;
			calculate();
		}
		#endregion
	}
}
