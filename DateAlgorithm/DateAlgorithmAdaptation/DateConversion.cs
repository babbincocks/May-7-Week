using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateConversions
{
    class DateConversion
    {
        private DateTime StandardizeDates(string input)
        {
            DateTime result = DateTime.MinValue;
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
                    
                    input.Replace('-', '/');

                    input.Replace('.', '/');

                    reverse = new string(input.ToCharArray().Reverse().ToArray());
                    yearLength = reverse.IndexOf('/') - 1;

                    int.TryParse(reverse.Substring(0, 2), out int yearValue);

                    string yv = new string(yearValue.ToString().ToCharArray().Reverse().ToArray());

                    yearValue = int.Parse(yv);
                    
                    
                    if (yearLength > 0 && yearLength < 4)
                    {
                        if (yearValue < 10)
                        {
                            input = ;
                        }
                        else if (yearValue >= (DateTime.Now.Year % 100))
                        {

                        }
                        else
                        {

                        }


                    }


            }

                return result;
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception("A date without separators was found, and thus could not be converted.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
