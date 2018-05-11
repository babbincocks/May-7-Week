using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateConversions
{
    class DateConversion
    {
        enum DateNames
        {
            Jan = 1,
            January = 1,
            Feb = 2,
            February = 2,
            Mar = 3,
            March = 3,
            Apr = 4,
            April = 4,
            May = 5,
            Jun = 6,
            June = 6,
            Jul = 7,
            July = 7,
            Aug = 8,
            August = 8,
            Sep = 9,
            September = 9,
            Oct = 10,
            October = 10,
            Nov = 11,
            November = 11,
            Dec = 12,
            December = 12
        }

        public static DateTime StandardizeDates(string input)
        {
            DateTime result = DateTime.MinValue;
            //string reverse = "";
            //int yearLength = 0;
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

                    string[] splitDate = input.Split('/');

                    if (Enum.IsDefined(typeof(DateNames), splitDate[0]))
                    {
                        splitDate[0] = Enum.
                    }
                    else if (Enum.IsDefined(typeof(DateNames), splitDate[1]))
                    {

                    }

                    //reverse = new string(input.ToCharArray().Reverse().ToArray());
                    //yearLength = reverse.IndexOf('/');

                    //int.TryParse(reverse.Substring(0, 2), out int yearValue);

                    //string yv = new string(yearValue.ToString().ToCharArray().Reverse().ToArray());

                    //yearValue = int.Parse(yv);
                    
                    
                    if (splitDate[2].Length > 0 && splitDate[2].Length < 4)
                    {
                        if (int.Parse(splitDate[2]) < 10)
                        {
                            input = input.Substring(0, (input.Length - splitDate[2].Length)) + "200" + splitDate[2];
                        }
                        else if (int.Parse(splitDate[2]) >= (DateTime.Now.Year % 100))
                        {
                            input = input.Substring(0, (input.Length - splitDate[2].Length)) + "19" + splitDate[2];
                        }
                        else
                        {
                            input = input.Substring(0, (input.Length - splitDate[2].Length)) + "20" + splitDate[2];
                        }

                    }


                    input = input.Replace("/0", "/");

                    //string first = input.Substring(0, (input.IndexOf('/')));
                    //string second = input.Substring((input.IndexOf('/', 0) + 1),
                    //                ((input.IndexOf('/', input.IndexOf('/', 0) + 1)) - (input.IndexOf('/', 0)) - 1)) ;

                    if (int.Parse(splitDate[0]) > 12 && int.Parse(splitDate[1]) <= 12)
                    {
                        input = splitDate[1] + "/" + splitDate[0] + "/" + splitDate[2];
                    }
                    else
                    {
                        input = splitDate[0] + "/" + splitDate[1] + "/" + splitDate[2];
                    }

            }

                return result;
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception("The tested string does not seem to be in a discernible date format.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
