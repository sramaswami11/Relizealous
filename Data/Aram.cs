using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Relizealous.Data
{
    public class Aram
    {

        public string Title { get; set; }

        public string Title_Enum { get; set; }
        public string Description { get; set; }

        public string Link { get; set; }


        public static readonly Aram[] Collection
        = new Aram[]
        {
            new Aram 
            {
                Title="கடவுள் வாழ்த்து",
                Title_Enum = "கடவுள்_வாழ்த்து",
                Description="The Praise of God.",
                Link="/Contents/slokas/Tamil/hayagriivakavacham1.pdf",
            },
            new Aram
            {
                Title="வான் சிறப்பு",
                Title_Enum = "வான்சிறப்பு",
                Description="The Blessing of Rain.",
                Link="/Contents/slokas/Tamil/gadaadharastotram.pdf"
            },
             new Aram
            {
                Title="நீத்தார் பெருமை",
                Title_Enum = "நீத்தார்_பெருமை",
                Description="The Greatness of Ascetics.",
                Link="/Contents/slokas/Tamil/hayagriivakavacham1.pdf",
            },
            new Aram
            {
                Title="அறன் வலியுறுத்தல்",
                Title_Enum = "அறன்_வலியுறுத்தல்",
                Description="Assertion of the Strength of Virtue",
                Link="/Contents/slokas/Tamil/gadaadharastotram.pdf"
            },
             new Aram
            {
                Title="இல்வாழ்க்கை",
                Description="Domestic Life.",
                Link="/Contents/slokas/Tamil/hayagriivakavacham1.pdf",
            },
            new Aram
            {
                Title="வாழ்க்கைத் துணைநலம்",
                Title_Enum = "வாழ்க்கைத்_துணைநலம்",
                Description="The Worth of a Wife.",
                Link="/Contents/slokas/Tamil/gadaadharastotram.pdf"
            }
        };
    }

    public class AramRepository
    {

        private static readonly Aram[] Collection = new Aram[] {

            new Aram
            {
                Title="June 29, 2021",
                Description="Divya Prabandham Pottrum Tirukkudandai, a collection of pasurams from 4000 Divya Prabandham dedicated to Lord Srii Shaargapaanii Perumaal.",
                Link="/Contents/slokas/Tamil/hayagriivakavacham1.pdf"

            },
            new Aram
            {
                Title="June 28, 2021",
                Description="Srii Gadaadharastotram from Srii Vamana Puranam composed by Raibhya.",
                Link="/Contents/slokas/Tamil/hayagriivakavacham1.pdf"
            }

        };

        public IEnumerable<Aram> Get()
        {
            return Collection;
        }

    }
}
