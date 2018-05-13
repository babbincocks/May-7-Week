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
        {

            string reverse = "";
            int yearLength = 0;
            //int yearValue = 0;

            try
            {

                if (input.Length > 0)
                {
                    input = input.Trim();

                    if (input.StartsWith("0") == true)
                    {
                        input = input.TrimStart('0');
                    }
                    
                    input = input.Replace('-', '/');

                    input = input.Replace('.', '/');

                    reverse = new string(input.ToCharArray().Reverse().ToArray());
                    yearLength = reverse.IndexOf('/');

                    int.TryParse(reverse.Substring(0, 2), out int yearValue);


                    string yv = new string(yearValue.ToString().ToCharArray().Reverse().ToArray());

                    yearValue = int.Parse(yv);

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

                    string[] splitDate = input.Split('/');
                    
                    if (splitDate[2].Length > 0 && splitDate[2].Length < 4)
                    {
                        if (yearValue < 10)
                        {
                            splitDate[2] = "200" + splitDate[2];
                            input = splitDate[0] + "/" + splitDate[1] + "/" + splitDate[2];
                        }
                        else if (yearValue >= (DateTime.Now.Year % 100))
                        {
                            splitDate[2] = "19" + splitDate[2];
                            input = splitDate[0] + "/" + splitDate[1] + "/" + splitDate[2];
                        }
                        else
                        {
                            splitDate[2] = "20" + splitDate[2];
                            input = splitDate[0] + "/" + splitDate[1] + "/" + splitDate[2];
                        }


                    }

                    if (int.Parse(splitDate[0]) > 12 && int.Parse(splitDate[1]) <= 12)
                    {
                        string hold = splitDate[0];
                        splitDate[0] = splitDate[1];
                        splitDate[1] = hold;
                        input =  splitDate[0] + "/" + splitDate[1] + "/" + splitDate[2];
                    }

                    if (int.Parse(splitDate[0]) < 10 && !splitDate[0].StartsWith("0"))
                    {
                        splitDate[0] = "0" + splitDate[0];
                        input = splitDate[0] + "/" + splitDate[1] + "/" + splitDate[2];
                    }

                    if (int.Parse(splitDate[1]) < 10 && !splitDate[1].StartsWith("0"))
                    {
                        splitDate[1] = "0" + splitDate[1];
                        input = splitDate[0] + "/" + splitDate[1] + "/" + splitDate[2];
                    }

                    input = splitDate[0] + "/" + splitDate[1] + "/" + splitDate[2];



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
