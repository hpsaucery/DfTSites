using SQLite;
using Xamarin.Forms;
namespace DfTSites
{
    public class Site
    {

        /*public Site()
        {

        }

        public Site(int id, string name)
        {
            ID = id;
            Name = name;
        }*/


        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Address1 { get; set; }

        [MaxLength(100)]
        public string Address2 { get; set; }

        [MaxLength(20)]
        public string City { get; set; }

        [MaxLength(20)]
        public string Postcode { get; set; }


        public byte[] Picture { get; set; }

        // use Image.FromStream() to convert from DB to image, change back to byte[]
        // for storing back in DB... for now, use string and copy local URL as source

        [MaxLength(255)]
        public string Facilities { get; set; }

        [MaxLength(255)]
        public string Comments { get; set; }

        [MaxLength(30)]
        public string Latitude { get; set; }

        [MaxLength(30)]
        public string Longitude { get; set; }

        [MaxLength(100)]
        public string ContactName { get; set; }

        [MaxLength(100)]
        public string ContactEmail { get; set; }

        [MaxLength(50)]
        public string ContactNo { get; set; }


    }





}
