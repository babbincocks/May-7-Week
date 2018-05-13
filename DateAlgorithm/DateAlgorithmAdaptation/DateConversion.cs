using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DateConversions
{
    class DateConversion
    {
        public static string StandardizeDates(string input)
        {       //Code for the StandardizeDates function.

            //Variable to hold reversed input later on.
            string reverse = "";

            try
            {
                //Make sure that there's a date to work with.
                if (input.Length > 0)
                {
                    //Spaces are trimmed off of the date.
                    input = input.Trim();

                    //Checks if the first number is a 0, and if so, gets rid of it, so as to more easily work with the numbers.
                    if (input.StartsWith("0") == true)
                    {
                        input = input.TrimStart('0');
                    }
                    
                    //Replaces common separators with a uniform /.
                    input = input.Replace('-', '/');
                    input = input.Replace('.', '/');

                    //Reverse the input so as to be able to get what the value of the year is, so potential formatting can be done soon.
                    reverse = new string(input.ToCharArray().Reverse().ToArray());
                    int.TryParse(reverse.Substring(0, 2), out int yearValue);
                    string yv = new string(yearValue.ToString().ToCharArray().Reverse().ToArray());
                    yearValue = int.Parse(yv);

                    //If the date contains a word literal for the month, its related integer value is brute-forced in.
                    input = input.Replace("Jan", "1");
                    input = input.Replace("January", "1");
                    input = input.Replace("Feb", "2");
                    input = input.Replace("February", "2");
                    input = input.Replace("Mar", "3");
                    input = input.Replace("March", "3");
                    input = input.Replace("Apr", "4");
                    input = input.Replace("April", "4");
                    input = input.Replace("May", "5");
                    input = input.Replace("Jun", "6");
                    input = input.Replace("June", "6");
                    input = input.Replace("Jul", "7");
                    input = input.Replace("July", "7");
                    input = input.Replace("Aug", "8");
                    input = input.Replace("August", "8");
                    input = input.Replace("Sep", "9");
                    input = input.Replace("September", "9");
                    input = input.Replace("Oct", "10");
                    input = input.Replace("October", "10");
                    input = input.Replace("Nov", "11");
                    input = input.Replace("November", "11");
                    input = input.Replace("Dec", "12");
                    input = input.Replace("December", "12");

                    //At this point, the date is split up into its (assumed) 3 sections.
                    string[] splitDate = input.Split('/');
                    
                    //Checks if the length of the year is less than 4 numbers long, but still exists.
                    if (splitDate[2].Length > 0 && splitDate[2].Length < 4)
                    {
                        //If the value of the year is less than 10, it's assumed to have been a year for this century 
                        //(i.e. a "6" is assumed to be "2006")
                        if (yearValue < 10)
                        {
                            splitDate[2] = "200" + splitDate[2];
                            input = splitDate[0] + "/" + splitDate[1] + "/" + splitDate[2];
                        }
                        //If the year value is greater than or equal to the current year value, it's assumed to have been of the last century.
                        else if (yearValue >= (DateTime.Now.Year % 100))
                        {
                            splitDate[2] = "19" + splitDate[2];
                            input = splitDate[0] + "/" + splitDate[1] + "/" + splitDate[2];
                        }
                        //Any other number is assumed to be of the current century.
                        else
                        {
                            splitDate[2] = "20" + splitDate[2];
                            input = splitDate[0] + "/" + splitDate[1] + "/" + splitDate[2];
                        }


                    }


                    //This checks if the first element is definitely a day, and if the second element is probably a month, and switches them if so.
                    if (int.Parse(splitDate[0]) > 12 && int.Parse(splitDate[1]) <= 12)
                    {
                        string hold = splitDate[0];
                        splitDate[0] = splitDate[1];
                        splitDate[1] = hold;
                        input =  splitDate[0] + "/" + splitDate[1] + "/" + splitDate[2];
                    }


                    //This places a 0 in front of the first number, assuming it's less than 10 and doesn't already have one (which it shouldn't)
                    if (int.Parse(splitDate[0]) < 10 && !splitDate[0].StartsWith("0"))
                    {
                        splitDate[0] = "0" + splitDate[0];
                        input = splitDate[0] + "/" + splitDate[1] + "/" + splitDate[2];
                    }

                    //Same, but with the second number.
                    if (int.Parse(splitDate[1]) < 10 && !splitDate[1].StartsWith("0"))
                    {
                        splitDate[1] = "0" + splitDate[1];
                        input = splitDate[0] + "/" + splitDate[1] + "/" + splitDate[2];
                    }

                    input = splitDate[0] + "/" + splitDate[1] + "/" + splitDate[2];

                    //At this point, the date should be in the format MM/DD/YYYY, and so it's now returned.

            }

                return input;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
