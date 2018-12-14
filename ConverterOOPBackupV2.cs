using System;
//Cent to inches
//Inches to cent
//Grams to ounces
//Onces to grams
//Litres to pints
//Pints to litres

//////////////////////welcome message/////////////////////////////
public class Converter {

  public Converter()
  {
    MeasureOne = "Welcome to the converter program.";
  }
  
  public Converter(string measureOne)
  {
    MeasureOne = measureOne;
  }

  public string MeasureOne   { get; }


  public override string ToString()
  {
    return MeasureOne;
  }
}
//////////////////////end of welcome message////////////////////////
  
/////////////////////centimetres to inches///////////////////////////////
public class ConvertOne 
{
  public ConvertOne()
  {
    Centtoinch = "0.3937008";
  }

  public ConvertOne(string centtoinch)
  {                                   //make new string with var data
    Centtoinch = centtoinch;
  }

  public string Centtoinch   { get; }


  public override string ToString()
  {
    return Centtoinch;
  }

 // Remove line below when done testing
 // public double realCentInch = 0.3937008; 


}
///////////////////////end of centimetres to inches////////////////////////////

/////////////////////////Inches to centimetres///////////////////////////
public class ConvertTwo
{
  public ConvertTwo()
  {
    Inchtocent = "2.54";
  }

  public ConvertTwo(string inchtocent)
  {                                   //make new string with var data
    Inchtocent = inchtocent;
  }

  public string Inchtocent  { get; }

  public override string ToString()
  {
    return Inchtocent;
  }

}
///////////////////////////end of inches to centimetres////////////////////////

/////////////////////////Grams to ounces///////////////////////////
public class ConvertThree
{
  public ConvertThree()
  {
    Gramtoounce = "0.03527396";
  }

  public ConvertThree(string gramtoounce)
  {                                   //make new string with var data
    Gramtoounce = gramtoounce;
  }

  public string Gramtoounce  { get; }

  public override string ToString()
  {
    return Gramtoounce;
  }

}
///////////////////////////End of Grams to ounces////////////////////////

/////////////////////////Ounces to grams///////////////////////////
public class ConvertFour
{
  public ConvertFour()
  {
    Ouncetogram = "28.34952";
  }

  public ConvertFour(string ouncetogram)
  {                                   //make new string with var data
    Ouncetogram = ouncetogram;
  }

  public string Ouncetogram  { get; }

  public override string ToString()
  {
    return Ouncetogram;
  }

}
///////////////////////////End of Ounces to grams////////////////////////

/////////////////////////Litres to pints///////////////////////////
public class ConvertFive
{
  public ConvertFive()
  {
    Litrestopints = "2.113376";
  }

  public ConvertFive(string litrestopints)
  {                                   //make new string with var data
    Litrestopints = litrestopints;
  }

  public string Litrestopints  { get; }

  public override string ToString()
  {
    return Litrestopints;
  }

}
///////////////////////////End of Litres to pints////////////////////////

/////////////////////////Pints to Litres/////////////////////////////////
public class ConvertSix
{
  public ConvertSix()
  {
    Pintstolitres = "0.4731765";
  }

  public ConvertSix(string pintstolitres)
  {                                   //make new string with var data
    Pintstolitres = pintstolitres;
  }

  public string Pintstolitres  { get; }

  public override string ToString()
  {
    return Pintstolitres;
  }

}
///////////////////////////End of Pints to Litres////////////////////////

class testConverter 
{
  static void Main()
  {
   // var Measure1 = new Converter();
   // Console.WriteLine(Measure1.MeasureOne);

 

   var Measure2 = new Converter();
   var CentI = new ConvertOne();
   var InchC = new ConvertTwo();
   var GramO = new ConvertThree();
   var OGram = new ConvertFour();
   var LPints = new ConvertFive();
   var PLitres = new ConvertSix();

    // Remove if needed?
    /*
    int NewCent;
    NewCent = Convert.ToInt32(CentI);
    */
    //

   // Console.WriteLine(Measure2.MeasureOne);

    Console.WriteLine(Measure2);
    Console.WriteLine("\nOption 1: Cent to inches rate is:");
    Console.WriteLine(CentI);

    Console.WriteLine("\nOption 2: Inches to cent rate is:");
    Console.WriteLine(InchC);

    Console.WriteLine("\nOption 3: Grams to ounces rate is:");
    Console.WriteLine(GramO);

    Console.WriteLine("\nOption 4: Ounce to gram rate is:");
    Console.WriteLine(OGram);

    Console.WriteLine("\nOption 5: Litres to pint rate is:");
    Console.WriteLine(LPints);

    Console.WriteLine("\nOption 6: Pints to litres rate is:");
    Console.WriteLine(PLitres);

    /*
    Console.WriteLine("\nPlease press enter, then type a option's number then press enter again.");
    Console.ReadKey();
    */

    Console.WriteLine("\nPlease enter the number of which option you would like to choose: ");

////////////////choice logic/////////////////////////////
    double choice;
    choice = Convert.ToDouble(Console.ReadLine());
    /*
    Console.WriteLine("\nYour choice is:", choice);
    Console.ReadLine();
    */

    if (choice == 1) // Centremeters to Inches
    {
      //line below is a test to see if certain classes can be called within this if statement :)
      //Console.WriteLine(CentI);

      Console.WriteLine("\nYou have choosen option 1.");
      Console.WriteLine("\nPlease enter a number of centremeters you wish to convert to inches below: ");
      double MyConvert;
      MyConvert = Convert.ToDouble(Console.ReadLine());
      
      /* Calling class to use number for conversion
      double LocalCentToInch = Convert.ToDouble(CentI);
      double YourAnswer = MyConvert * LocalCentToInch;
      */
      //Ignore these lines just testing type converison and failing
      //Console.WriteLine(CentI);
      //Console.WriteLine(CentI.ToDouble());
      /*
      double LocalCentToInch;
      LocalCentToInch = Convert.ToInt32(CentI);
      Console.WriteLine(LocalCentToInch);
      */
      

      double YourAnswer = MyConvert * 0.3937008;
      Console.WriteLine("\nYour answer is:");
      Console.WriteLine(YourAnswer);
      
    }

    else if (choice == 2) 
    {
      Console.WriteLine("\nYou have choosen option 2.");
      Console.WriteLine("\nPlease enter a number of inches you wish to convert to centremeters below: ");
      double MyConvert;
      MyConvert = Convert.ToDouble(Console.ReadLine());
	  
	   double YourAnswer = MyConvert * 2.54;
      Console.WriteLine("\nYour answer is:");
      Console.WriteLine(YourAnswer);
	  Console.WriteLine("\nPress enter to exit...");
	  Console.ReadLine();
    }

    else if (choice == 3)
    {
      Console.WriteLine("\nYou have choosen option 3.");
      Console.WriteLine("\nPlease enter a number of grams you wish to convert to ounces below: ");
      double MyConvert;
      MyConvert = Convert.ToDouble(Console.ReadLine());
	  
	   double YourAnswer = MyConvert * 0.03527396;
      Console.WriteLine("\nYour answer is:");
      Console.WriteLine(YourAnswer);
	  Console.WriteLine("\nPress enter to exit...");
	  Console.ReadLine();
    }

    else if (choice == 4)
    {
      Console.WriteLine("\nYou have choosen option 4.");
      Console.WriteLine("\nPlease enter a number of ounces you wish to convert to grams below: ");
      double MyConvert;
      MyConvert = Convert.ToDouble(Console.ReadLine());
	  
	   double YourAnswer = MyConvert * 28.34952;
      Console.WriteLine("\nYour answer is:");
      Console.WriteLine(YourAnswer);
	  Console.WriteLine("\nPress enter to exit...");
	  Console.ReadLine();
    }

    else if (choice == 5)
    {
      Console.WriteLine("\nYou have choosen option 5.");
      Console.WriteLine("\nPlease enter a number of litres you wish to convert to pints below: ");
      double MyConvert;
      MyConvert = Convert.ToDouble(Console.ReadLine());
	  
	   double YourAnswer = MyConvert * 2.113376;
      Console.WriteLine("\nYour answer is:");
      Console.WriteLine(YourAnswer);
	  Console.WriteLine("\nPress enter to exit...");
	  Console.ReadLine();
    }

    else if (choice == 6)
    {
      Console.WriteLine("\nYou have choosen option 6.");
      Console.WriteLine("\nPlease enter a number of pints you wish to convert to litres below: ");
      double MyConvert;
      MyConvert = Convert.ToDouble(Console.ReadLine());
	  
	   double YourAnswer = MyConvert * 0.4731765;
      Console.WriteLine("\nYour answer is:");
      Console.WriteLine(YourAnswer);
	  Console.WriteLine("\nPress enter to exit...");
	  Console.ReadLine();
    }

    else
    {
      Console.WriteLine("Invalid choice of options, please press enter to exit and restart the program.");
      Console.ReadLine();
    }


///////////////end of choice logic//////////////////////////

  }

}