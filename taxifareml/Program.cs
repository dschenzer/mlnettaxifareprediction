using System;
using TaxifaremlML.Model;

namespace taxifareml
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput();
            input.Passenger_count = 1f;
            input.Payment_type = "CRD";
            input.Trip_distance = 5.3f;
            input.Trip_time_in_secs = 850;
            input.Vendor_id = "CMT";

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);

            Console.WriteLine($"The predicted fare is: {result.Score}");
        }
    }
}
