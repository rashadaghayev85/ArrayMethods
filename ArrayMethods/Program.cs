#region class tasks practice
//int[,] nums = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 } };
//Console.WriteLine(nums.Rank);
//Console.WriteLine(nums[1,2]);
//int[,,] nums = { { { 3, 5 }, { 4, 6 }, { 7, 8 } }, { { 13, 15 }, { 14, 26 }, { 27,28 } }, { { 33, 35 }, { 44, 46 }, { 57, 58 } } };

//Console.WriteLine(nums[1,2,1]);

//string[] names = { "Hacixan", "Reshad", "Ilqar", "Behruz", "Kamran" };
//var datas=names.Reverse().ToArray();
//Console.WriteLine(datas[datas.Length-1]);


//int[] nums = { 1, 2, 3, 4, 5 };
//Array.Sort(nums);

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}



//int[] arr3 = { 1, 2, 3 };
//Array.Resize(ref arr3, 5);
//arr3[3] = 200;
//Console.WriteLine(arr3[3]);


//int[] arr3 = { 1, 2, 3 };
//Array.Resize(ref arr3, 5);
//Console.WriteLine(arr3[3]);

//string [] arrrr = { "1", "2", "3" };
//Array.Resize(ref arrrr, 5);
//Console.WriteLine(arrrr[3]);

//int[] arr1 = { 1, 2, 3 };
//int[] arr2 = { 4, 5 };
//Array.Resize(ref arr2,5);
//arr1.CopyTo(arr2, 2);
//foreach (int item in arr2)
//{
//    Console.WriteLine(item);
//}


//int[] arr = { 1, 2, 3 };
//Array.Resize(ref arr, 1);
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}


//var data = Array.Find(names, m => m == "Reshad");
//Console.WriteLine(data);


using System.Runtime.CompilerServices;

string[] names = { "Hacixan", "Reshad", "Ilqar", "Behruz", "Kamran","Reshad" };
//var data = Array.FindAll(names, m => m == "Reshad");
//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}


//var data = Array.FindIndex(names, m => m == "Reshad");
//Console.WriteLine(data);

//var data = Array.FindLastIndex(names, m => m == "Reshad");

//Console.WriteLine(data);

//var data=names.FirstOrDefault();
//Console.WriteLine(data);

//var data=names.LastOrDefault();
//Console.WriteLine(data);

//var data=names.FirstOrDefault(m=>m=="Kamran");
//Console.WriteLine(data);

//var data = names.All(m => m == "Reshad");
//Console.WriteLine(data);

//var data = names.Any(m => m == "Reshad");
//Console.WriteLine(data);



//var data = Array.Exists(names, m => m == "Reshad");
//Console.WriteLine(data);

//var datas=names.Where(m=>m=="Reshad").ToArray();   
//foreach(var item in datas)
//{
//    Console.WriteLine(item);
//}

//var datas = names.OrderBy(m => m);
//foreach (var item in datas)
//{
//    Console.WriteLine(item);
//}



//bool CheckAllData(string[] datas)
//{
//    int count = 0;
//    for (int i = 0; i < names.Length; i++)
//    {
//        if (names[i] == "Reshad") ;
//        {
//            count++;
//        }
//    }
//    if (count == names.Length)
//    {
//      return true;
//    }
//    else
//    {
//        return false;
//    }

//}
//Console.WriteLine(CheckAllData(names));

//DateTime date=DateTime.Now;
//Console.WriteLine(date);

//DateTime date = DateTime.Now.AddDays(10);
//Console.WriteLine(date);

//DateTime birthday = new DateTime(2002,05,25);
//Console.WriteLine(birthday.Day);

//DateTime birthday = new DateTime(2002,05,25);
//Console.WriteLine(birthday.Date);


//DateOnly date= new DateOnly(2002,05,25);
//Console.WriteLine(date);

//var date=DateTime.Now;
//Console.WriteLine(date.ToString("dddd,dd MMMM,yyyy"));


var currentYear = DateTime.Now.Year;
DateTime birthday = new DateTime(2002, 05, 35);
var birthdayYear = birthday.Year;
Console.WriteLine(currentYear - birthdayYear);

#endregion


#region Homework
//2. Method yazirsiz, Method stringden ibaret array ve char qebul edir. Method arrayin icerisinde gelen chardan ne qederdirse onlarin sayini geriye qaytarsin.
int CountInnData(char symbol,params string[] arr)
{
    int count = 0;
    string test = "";
    for (int i = 0; i < arr.Length; i++)
    { 
          test = arr[i];
        test.ToCharArray();
        for (int j = 0; j < test.Length; j++)
        {
            if (test[j] == symbol)
            {
                count++;
            }
        }
       
    }
    return count;
}
//Console.WriteLine(CountInnData('s',"salam","Rashad","Aghayev"));
#endregion