
using CleanCode._09_DuplicatedCode;
using System;

namespace CleanCode.DuplicatedCode
{
    class Admission
    {
        public AdmissionDateTime AdmissionDateTime { set; get; }

        public Admission()
        {
            AdmissionDateTime = new AdmissionDateTime();
        }

        public void AdmitGuest(string name, string admissionDateTime)
        {
            // Some logic 
            // ...

            int hours = 0;
            int minutes = 0;

            var admDateTime = AdmissionDateTime.GetDateTime(admissionDateTime);
            hours = admDateTime.Hours;
            minutes = admDateTime.Minutes;

            // Some more logic 
            // ...
            if (hours < 10)
            {

            }
        }

        public void UpdateAdmission(int admissionId, string name, string admissionDateTime)
        {
            // Some logic 
            // ...
            int hours = 0;
            int minutes = 0;

            var admDateTime = AdmissionDateTime.GetDateTime(admissionDateTime);
            hours = admDateTime.Hours;
            minutes = admDateTime.Minutes;

            // Some more logic 
            // ...
            if (hours < 10)
            {

            }
        }
    }
}
