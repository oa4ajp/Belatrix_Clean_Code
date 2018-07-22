using System;

namespace CleanCode._09_DuplicatedCode
{
    public class AdmissionDateTime
    {
        public DateTimeOutput GetDateTime(string admissionDateTime)
        {
            int time;
            int hours = 0;
            int minutes = 0;

            if (!string.IsNullOrWhiteSpace(admissionDateTime))
            {
                if (int.TryParse(admissionDateTime.Replace(":", ""), out time))
                {
                    hours = time / 100;
                    minutes = time % 100;
                }
                else
                {
                    throw new ArgumentException("admissionDateTime");
                }

            }
            else
            {
                throw new ArgumentNullException("admissionDateTime");
            }

            return new DateTimeOutput
            {
                Time = time,
                Hours = hours,
                Minutes = minutes
            };
            
        }

    }
}
