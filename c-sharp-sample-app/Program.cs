using Nautilus;
using System;

namespace c_sharp_sample_app {
    class Program {
        static void Main(string[] args) {

            DriverLicense lic = new DriverLicense() { };

            string cac_barcode_one = System.IO.File.ReadAllText(@".\sample-data\cac_barcode_one.txt");
            string passport_mrz_one = System.IO.File.ReadAllText(@".\sample-data\passport_mrz_one.txt");
            string passport_mrz_two = System.IO.File.ReadAllText(@".\sample-data\passport_mrz_two.txt");
            string pdf417_barcode_one = System.IO.File.ReadAllText(@".\sample-data\pdf417_barcode_one.txt");
            string pdf417_barcode_two = System.IO.File.ReadAllText(@".\sample-data\pdf417_barcode_two.txt");
            string three_line_mrz_one = System.IO.File.ReadAllText(@".\sample-data\three_line_mrz_one.txt");

            if (lic.ExtractInfo(cac_barcode_one)) {
                Console.Out.WriteLine("CAC Card's Full Name: {0}", lic.LastName);
             
            }

            if (lic.ExtractInfo(passport_mrz_one)){

                Console.WriteLine("Passport's Full Name: {0}", lic.LastName);
                
            }

            if (lic.ExtractInfo(passport_mrz_two))
            {
                Console.WriteLine("Passport's Full Name: {0}", lic.LastName);
                
            }

            if (lic.ExtractInfo(pdf417_barcode_one))
            {
                Console.WriteLine("Barcode's Full Name: {0}", lic.LastName);
                
            }

            if (lic.ExtractInfo(pdf417_barcode_two))
            {
                Console.WriteLine("Passport's Full Name: {0}", lic.LastName);
             
            }

            if (lic.ExtractInfo(three_line_mrz_one))
            {
                Console.WriteLine("MRZ's Full Name: {0}", lic.LastName);
             
            }

            Console.In.ReadLine();
        }
    }
}
