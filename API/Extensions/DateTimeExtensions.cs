using System;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dateOfBirth)
        {
            var today = DateTime.Today; //01.03.2021
            var age = today.Year - dateOfBirth.Year; //2021 - 1989 = 32

            if(dateOfBirth>today.AddYears(-age)) 
                age--;

            return age;
        }
    }
}