namespace BasitBirHesapMakinesi
{
	internal class Program
	{
		static void Main(string[] args)
		{
			

			
			Console.WriteLine("İşlem seçiniz : [ + | - | * | / ] Çıkış yapmak için boş geçiniz");

			double firstNum, secondNum, result = 0;
			string mathOp;



			Console.WriteLine("Sayi 1 : ");
			firstNum = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Sayi 2 : ");
			secondNum = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("işlem: ");
			mathOp = Console.ReadLine();

			if (mathOp != string.Empty)
			{

				switch (mathOp)
				{
					case "+":

						result = firstNum + secondNum;
						Console.WriteLine("toplam:" + result);
						break;

					case "-":

						result = firstNum - secondNum;
						Console.WriteLine("Fark: {0}", result);
						break;

					case "*":

						result = firstNum * secondNum;
						Console.WriteLine($"Çarpım: {result}");
						break;

					case "/":

						result = firstNum / secondNum;
						Console.WriteLine($"Bölüm : {result}");
						break;
					default:
						break;
				}
			}
			else
			{
				Console.WriteLine("İşlem yapılmadı..");

			}
		}
	}
}