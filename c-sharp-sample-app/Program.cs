using Nautilus;
using System;

namespace c_sharp_sample_app {
    class Program {
        static void Main(string[] args) {

            DriverLicense lic = new DriverLicense() { };

            // Get the Parsing SDK's license file status
            DlplibLicenseStatus status = DriverLicense.GetDlpLibLicenseStatus();
            Console.Out.WriteLine("DLL License File Path: {0}", status.DlplibLicensePath);
            Console.Out.WriteLine("DLL License File Expiration Date: {0}", status.ExpirationDate);

            // Read in all the samepl data from the files
            string cac_barcode_one = System.IO.File.ReadAllText(@".\sample-data\cac_barcode_one.txt");
            string passport_mrz_one = System.IO.File.ReadAllText(@".\sample-data\passport_mrz_one.txt");
            string passport_mrz_two = System.IO.File.ReadAllText(@".\sample-data\passport_mrz_two.txt");
            string pdf417_barcode_one = System.IO.File.ReadAllText(@".\sample-data\pdf417_barcode_one.txt");
            string pdf417_barcode_two = System.IO.File.ReadAllText(@".\sample-data\pdf417_barcode_two.txt");
            string three_line_mrz_one = System.IO.File.ReadAllText(@".\sample-data\three_line_mrz_one.txt");

            // How to parse a CAC Card
            // Method one
            if (lic.ExtractInfo(cac_barcode_one)) {
                Console.Out.WriteLine("CAC Card's Full Name: {0}", lic.LastName);
            }
            // Method two
            DriverLicense cacCard = DriverLicense.ParseText(cac_barcode_one);
            Console.Out.WriteLine("CAC Card's Full Name: {0}", cacCard.LastName);



            // How to parse a Passport
            // Method one
            if (lic.ExtractInfo(passport_mrz_one)){
                Console.WriteLine("First Passport's Full Name: {0}", lic.LastName);   
            }
            // Method two
            DriverLicense passportOne = DriverLicense.ParseText(passport_mrz_one);
            Console.WriteLine("First Passport's Full Name: {0}", passportOne.LastName);



            // How to parse a Passport (second sample)
            // Method one 
            if (lic.ExtractInfo(passport_mrz_two)){
                Console.WriteLine("Second Passport's Full Name: {0}", lic.LastName);
            }
            // Method two
            DriverLicense passportTwo = DriverLicense.ParseText(passport_mrz_one);
            Console.WriteLine("Second Passport's Full Name: {0}", passportTwo.LastName);



            // How to parse a PDF417 barcode
            // Method one
            if (lic.ExtractInfo(pdf417_barcode_one)){
                Console.WriteLine("First Pdf417 Barcode's Full Name: {0}", lic.LastName);
            }
            // Method two
            DriverLicense pdf417One = DriverLicense.ParseText(pdf417_barcode_one);
            Console.WriteLine("First Pdf417 Barcode's Full Name: {0}", pdf417One.LastName);



            // How to parse PDF417 barcode (second sample)
            // Method one
            if (lic.ExtractInfo(pdf417_barcode_two)){
                Console.WriteLine("Second Pdf417 Barcode's Full Name: {0}", lic.LastName);
            }
            // Method two
            DriverLicense pdf417Two = DriverLicense.ParseText(pdf417_barcode_two);
            Console.WriteLine("Second Pdf417 Barcode's Full Name: {0}", pdf417Two.LastName);



            // How to parse a three line MRZ
            // Method one
            if (lic.ExtractInfo(three_line_mrz_one)){
                Console.WriteLine("Three Line MRZ's Full Name: {0}", lic.LastName);
            }
            // Method two
            DriverLicense threeLineMrz = DriverLicense.ParseText(three_line_mrz_one);
            Console.WriteLine("Three Line MRZ's Full Name: {0}", threeLineMrz.LastName);



            Console.In.ReadLine();
        }
    }
}
