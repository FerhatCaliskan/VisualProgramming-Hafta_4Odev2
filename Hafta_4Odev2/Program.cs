using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_4Odev2
{
    class Personel
    {
        private string tcKimlikNo;

        
        public string TcKimlikNo
        {
            get
            {
                
                return tcKimlikNo.Substring(0, 5);
            }
            set
            {
                
                if (value.Length == 11 && IsNumeric(value))
                {
                    tcKimlikNo = value;
                }
                else
                {
                    throw new ArgumentException("TC Kimlik No 11 karakter olmalı ve sayısal karakterlerden oluşmalı.");
                }
            }
        }

        
        private bool IsNumeric(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c)) 
                    return false;
            }
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();

            try
            {
                
                Console.Write("TC Kimlik No giriniz: ");
                string tcKimlikNo = Console.ReadLine();

                
                personel.TcKimlikNo = tcKimlikNo;

                
                Console.WriteLine("TC Kimlik No'nun ilk 5 karakteri: " + personel.TcKimlikNo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
