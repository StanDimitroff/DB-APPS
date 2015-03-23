namespace Import_Mountains_From_JSON
{
    using System;
    using System.Linq;
    using System.Data.Entity;
    using System.IO;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Mountains_Code_First;

    public class ImportFromJson
    {
        static void Main()
        {
            var json = File.ReadAllText("../../mountains.json");
            var mountains = JArray.Parse(json);
            foreach (var mountain in mountains)
            {
                try
                {
                    InsertMountain(mountain);
                    Console.WriteLine("Mountain {0} imported", mountain["mountainName"]);
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }

        private static void InsertMountain(JToken mountain)
        {
            var db = new MountainsContext();
            var newMountain = new Mountain();
            if (mountain["mountainName"] == null)
            {
                throw new ArgumentNullException("", "Mountain name is missing");
            }

            newMountain.Name = (string)mountain["mountainName"];

            var peaks = mountain["peaks"];
            if (peaks != null)
            {
                foreach (var peak in peaks)
                {
                    var newPeak = new Peak();
                    if (peak["peakName"] == null)
                    {
                        throw new ArgumentNullException("", "Peak name is missing");
                    }
                    newPeak.Name = (string)peak["peakName"];

                    if (peak["elevation"] == null)
                    {
                        throw new ArgumentNullException("", "Peak elevation is missing");
                    }
                    newPeak.Elevation = (int)peak["elevation"];

                    newMountain.Peaks.Add(newPeak);
                }
            }

            var countries = mountain["countries"];

            if (countries != null)
            {
                foreach (var country in countries)
                {
                    var newCountry = new Country();
                    newCountry.Name = (string)country;
                    newCountry.Code = newCountry.Name.Substring(0, 2).ToUpper();
                    newMountain.Countries.Add(newCountry);
                }
            }

            db.Mountains.Add(newMountain);
            db.SaveChanges();
        }
    }
}